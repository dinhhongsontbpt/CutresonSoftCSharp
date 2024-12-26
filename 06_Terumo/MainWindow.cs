using _06_Terumo.Device;
using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
			Nortec.MainPort = new PanSerialPort();
			Init();
		}
		private void Init()
		{
			//Log view
			FrmLogger frmLogger = new FrmLogger();
			Global.Common.ControlForm.LoadFormInControl(groupBoxLog, frmLogger);
			Global.Common.LogInfor("Initial start");
			InitObject();
			InitDisplay();

			if(ret == 0)
			{
				Global.ControlIO.WriteBit(7, Global.LogicON);
				Global.Common.LogInfor("Initial complete");
			}	
			else
			{
				Global.ControlIO.WriteBit(3, Global.LogicON);
				Global.Common.LogError("Initial failed");
			}	
		}

		private int ret;
		private void InitObject()
		{
			//Load setting
			MySetting.Setting.LoadSetting();
			if(MySetting.Setting.PositiveLogic)
			{
				Global.LogicON = true;
				Global.LogicOFF = false;
			}
			else
			{
				Global.LogicON = true;
				Global.LogicOFF = false;
			}
			//
			if (MySetting.Setting.CommandKeys.Length != 8)
			{
				Global.Common.LogError("Command keys error, check file config.ini");
			}
			else
			{
				Global.CommandKeys = MySetting.Setting.CommandKeys;
			}
			Global.CommandKeys[7] = "PLC COMMAND MODEL NO.";
			//DIO
			int retIo;
			Global.ControlIO = new ControlIO(out retIo);
			ret += retIo;
			Global.ControlIO.InputChanged += ControlIO_InputChanged;
			Global.ControlIO.OutputChanged += ControlIO_OutputChanged;
			//Nortec
			if(!Nortec.CheckOnLine())
			{
				ret += 1;
			}
			//PLC
			RS232 rS232 = new RS232();
			string port = MySetting.Setting.PortName;
			int baudrate = MySetting.Setting.BaudRate;
			string parity = MySetting.Setting.Parity;
			int databit = MySetting.Setting.DataBit;
			string stopbit = MySetting.Setting.StopBit;
			if (!rS232.Connect(port, baudrate, parity, databit, stopbit))
			{
				ret += 1;
			}
			else
			{
				RS232.Port.DataReceived += SerialPort_DataReceived;
			}	

		}

		private List<Label> lampInputs = new List<Label>();
		private List<Label> lampOutputs = new List<Label>();
		Label lbSerial;
		private void InitDisplay()
		{
			labelBuildDate.Text = "Built: " + File.GetLastWriteTime(Application.ProductName + ".exe").ToString("yyyy/MM/dd");
			//Input
			tbInput.RowCount = Global.InputBitCount;
			tbLampInput.RowCount = Global.InputBitCount;
			tbInput.RowStyles.Clear();
			tbLampInput.RowStyles.Clear();
			for (int i = 0; i < Global.InputBitCount; i++)
			{
				tbInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.InputBitCount));
				tbLampInput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.InputBitCount));
			}
			
			for (int i = 0; i < Global.InputBitCount; i++)
			{
				Label label = new Label();
				label.Text = Global.CommandKeys[i];
				label.Dock = DockStyle.Fill;
				label.TextAlign = ContentAlignment.MiddleCenter;
				tbInput.Controls.Add(label);
				lbSerial = label;

				Label lamp = new Label();
				lamp.BackColor = Color.Red;
				lamp.Dock = DockStyle.Fill;
				lamp.TextAlign = ContentAlignment.MiddleCenter;
				lamp.Text = i.ToString();
				tbLampInput.Controls.Add(lamp);
				lamp.Click += LampIP_Click;
				lampInputs.Add(lamp);
			}

			//Output
			tbOutput.RowCount = Global.OutputBitCount;
			tbLampOutput.RowCount = Global.OutputBitCount;
			tbOutput.RowStyles.Clear();
			tbLampOutput.RowStyles.Clear();
			for (int i = 0; i < Global.OutputBitCount; i++)
			{
				tbOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.OutputBitCount));
				tbLampOutput.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / Global.OutputBitCount));
			}

			for (int i = 0; i < Global.OutputBitCount; i++)
			{
				Label label = new Label();
				label.Text = Global.OutputComments[i];
				label.Dock = DockStyle.Fill;
				label.TextAlign = ContentAlignment.MiddleCenter;
				tbOutput.Controls.Add(label);

				Label lamp = new Label();
				lamp.BackColor = Color.Red;
				lamp.Dock = DockStyle.Fill;
				lamp.TextAlign = ContentAlignment.MiddleCenter;
				lamp.Text = i.ToString();
				lamp.Click += Lamp_Click;
				tbLampOutput.Controls.Add(lamp);
				lampOutputs.Add(lamp);			
			}
		}

		private void Lamp_Click(object sender, EventArgs e)
		{
			if (sender is Label clickedLamp)
			{
				int index = Convert.ToInt16(clickedLamp.Text);
				bool value;
				if (Global.LogicON == !Global.OutputBits[index])
				{
					value = true;
				}
				else
				{
					value = false;
				}
				if (Global.ControlIO.WriteBit(index, !Global.OutputBits[index]))
				{
					Global.Common.LogDebug($"Test write output bit O0{index} = {value}");
				} 
				else
				{
					Global.Common.LogError("Write bit error");
				}	
			}	
		}
		private void LampIP_Click(object sender, EventArgs e)
		{
			if (sender is Label clickedLamp)
			{
				int index = Convert.ToInt16(clickedLamp.Text);
				SendCommand(index);
			}
		}
		private void ControlIO_InputChanged(object sender, EventParam e)
		{
			bool value;
			if(Global.LogicON == e.Value)
			{
				value = true;
			}
			else
			{
				value = false;
			}
			string strValue = value == true ? "ON" : "OFF";
			Global.Common.LogDebug($"I0{e.Index} = {strValue}");
			clsControlLamp.ControlLamp(lampInputs[e.Index], value);
			//
			if(value)
			{
				SendCommand(e.Index);
			}	
		}
		private void ControlIO_OutputChanged(object sender, EventParam e)
		{
			bool value;
			if (Global.LogicON == e.Value)
			{
				value = true;
			}
			else
			{
				value = false;
			}
			string strValue = value == true ? "ON" : "OFF";
			Global.Common.LogDebug($"O0{e.Index} = {strValue}");
			clsControlLamp.ControlLamp(lampOutputs[e.Index], value);
		}

		private void SendCommand(int index)
		{
			Global.ControlIO.WriteBit(0, Global.LogicOFF);
			Global.ControlIO.WriteBit(1, Global.LogicOFF);
			if(index == 7)
			{
				Global.ControlIO.WriteBit(2, Global.LogicOFF);
			}
			//
			if (!Nortec.IsOnLine)
			{
				Nortec.CheckOnLine();
			}
			if(!Nortec.IsOnLine) return;
			if (!Nortec.MainPort.OpenPort(bSetDataRec: false))
			{
				Global.Common.LogError("Cannot Connect to Nortec");
				Global.ControlIO.WriteBit(1, Global.LogicON);
				return;
			}
			Nortec.MainPort.SetDataRevMode(bSetDataRec: false);
			string text = Global.CommandKeys[index];
			text = text.Trim();
			switch (text)
			{
				case "":
					Global.Common.LogError("Please check a Command");
					Global.ControlIO.WriteBit(1, Global.LogicON);
					return;
				case "~":
					text = "GAGEINFO?";
					break;
				case "~~":
					text = "FILEDIR?";
					break;
				case "##":
					text = "KEY=SAVE";
					break;
			}
			text += "\r\n";
			string text2 = "";
			Global.Common.LogDebug($"Send command to Nortec -> {text}");
			text2 = ((!Nortec.MainPort.SendCommand(text)) ? Nortec.MainPort.GetPortResponse() : Nortec.MainPort.GetPortResponse());
			if(text2.Contains("OK"))
			{
				Global.Common.LogDebug($"Nortec response -> {text2}");
				Global.ControlIO.WriteBit(0, Global.LogicON);
				if (index == 7)
				{
					Global.ControlIO.WriteBit(2, Global.LogicON);
				}
			}	
			else
			{
				Global.Common.LogError($"Nortec response -> {text2}");
				Global.ControlIO.WriteBit(1, Global.LogicON);
			}	
			Nortec.MainPort.ClosePort();
		}

		private void btnCommandSetting_Click(object sender, EventArgs e)
		{
			FrmCommandSetting frmCommandSetting = new FrmCommandSetting();
			frmCommandSetting.ShowDialog();
		}

		private void btnSetting_Click(object sender, EventArgs e)
		{
			FrmPlcSetting frmPlcSetting = new FrmPlcSetting();
			frmPlcSetting.ShowDialog();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			try
			{
				string data = RS232.Port.ReadLine();
				data = data.Trim().ToUpper();
				Global.Common.LogInfor($"Receive data from PLC: {data}");
				Global.CommandKeys[7] = data;
				clsInvokeControl.ControlTextInvoke(lbSerial, Global.CommandKeys[7]);
			}
			catch (Exception ex)
			{
				Global.Common.LogFatal($"Serial port: Error while reading data: {ex.Message}");
			}
		}
		//private void CheckConnection()
		//{
		//	if (!Global.CheckOnLine())
		//	{
		//		txtCommand.Enabled = false;
		//		txtStatus.Enabled = false;
		//		btnSend.Enabled = false;
		//	}
		//}
		//private void btnSend_Click(object sender, EventArgs e)
		//{
		//	CheckConnection();
		//	if (!Global.IsOnLine)
		//	{
		//		return;
		//	}
		//	if (!Global.MainPort.OpenPort(bSetDataRec: false))
		//	{
		//		MessageBox.Show("ERROR: Cannot Connect to Device");
		//		return;
		//	}
		//	Global.MainPort.SetDataRevMode(bSetDataRec: false);
		//	string text = txtCommand.Text;
		//	text = text.Trim();
		//	switch (text)
		//	{
		//		case "":
		//			MessageBox.Show("Please enter a Command");
		//			txtCommand.Focus();
		//			txtCommand.SelectionStart = 0;
		//			return;
		//		case "~":
		//			text = "GAGEINFO?";
		//			break;
		//		case "~~":
		//			text = "FILEDIR?";
		//			break;
		//		case "##":
		//			text = "KEY=SAVE";
		//			break;
		//	}
		//	text += "\r\n";
		//	string text2 = "";
		//	text2 = ((!Global.MainPort.SendCommand(text)) ? Global.MainPort.GetPortResponse() : Global.MainPort.GetPortResponse());
		//	txtStatus.Text = text2;
		//	Global.MainPort.ClosePort();
		//}

		//private void button1_Click(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		master = ModbusMaster.TCP("192.168.3.10", 8500);
		//		MessageBox.Show("Connected");
		//	}
		//	catch
		//	{
		//		MessageBox.Show("Not connected");
		//	}
		//}

		//private void button2_Click(object sender, EventArgs e)
		//{
		//	try
		//	{
		//		bool[] b = master.ReadCoils(1, 10000, 10);
		//		//ushort[] d = master.ReadHoldingRegisters(1, 40000, 10);
		//		Console.WriteLine(b);
		//	}
		//	catch(Exception ex) 
		//	{
		//		MessageBox.Show(ex.Message);
		//	}
		//}
	}
}
