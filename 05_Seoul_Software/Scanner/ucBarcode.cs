using Cutreson_Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software.Scanner
{
	public partial class ucBarcode : UserControl
	{
		public BarcodeModel barcode;
		public int index;
		public event EventHandler<int> BarcodeWritten;
		public ucBarcode()
		{
			InitializeComponent();
		}
		public void EnableControl(bool enable)
		{
			txtBarcode.ReadOnly = !enable;
			if (enable)
			{
				this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			}
			else
			{
				this.txtBarcode.KeyDown -= new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
			}
		}
		public void SetModel(BarcodeModel barcode)
		{
			barcode.Index = index;
			this.barcode = barcode;
			UpdateView();
		}

		public void UpdateView()
		{
			//clsInvokeControl.ControlTextInvoke(lbId, barcode.Id.ToString());
			clsInvokeControl.ControlTextInvoke(lbIndex, (barcode.Index + 1).ToString());
			clsInvokeControl.ControlTextInvoke(txtBarcode, barcode.Data);
			if (string.IsNullOrEmpty(barcode.Data))
			{
				clsInvokeControl.ControlBackColorInvoke(lbIndex, Color.Teal);
			}
			else
			{
				clsInvokeControl.ControlBackColorInvoke(lbIndex, Color.DarkGreen);
			}
		}
		public void FocusAndSelectAll()
		{
			if (txtBarcode.InvokeRequired)
			{
				txtBarcode.Invoke(new Action(() =>
				{
					txtBarcode.Focus();
					txtBarcode.SelectAll();
				}));
			}
			else
			{
				txtBarcode.Focus();
				txtBarcode.SelectAll();
			}
		}

		private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Enter();
			}
		}
		public void SetCode(string strCode)
		{
			txtBarcode.Text = strCode;
		}
		public void Enter()
		{
			string enteredText = txtBarcode.Text;
			clsInvokeControl.ControlBackColorInvoke(lbIndex, Color.Teal);
			if (string.IsNullOrEmpty(enteredText)) return;
			clsInvokeControl.ControlBackColorInvoke(lbIndex, Color.DarkGreen);
			Global.Log.Operation("Scan: " + enteredText);
			if (MySetting.Setting.CheckBarcodeOverlap)
			{
				BarcodeModel check = Global.Barcodes.Find(f => f.Data == enteredText && f.Index != index);
				if (check != null)
				{
					Global.Log.Alarm($"Barcode {enteredText} overlap");
					FocusAndSelectAll();
					clsMessageBox.Warning($"Barcode {enteredText} overlap");
					return;
				}
			}
			barcode.Data = enteredText;
			barcode.TimeScan = DateTime.Now;
			barcode.Index = index;
			if (barcode.IsIdExist())
			{
				Global.Barcodes.RemoveAll(b => b.Id == barcode.Id);
			}
			if (barcode.Id != 0)
			{
				Global.Barcodes.Add(barcode);
				if (Global.Barcodes.Count >= 100)
				{
					Global.Barcodes.RemoveAt(Global.Barcodes.Count - 1);
				}
				clsBarcodeManager.Save();

				if (Global.PLC.WriteBarcode(barcode))
				{
					Global.Log.Operation($"Write barcode {barcode.Index + 1}:{barcode.Data},Id={barcode.Id}");
					OnBarcodeWritten();
				}
				else
				{
					Global.Log.Alarm($"Write barcode {barcode.Index + 1}: {barcode.Data},Id={barcode.Id}");
				}
			}
		}
		protected virtual void OnBarcodeWritten()
		{
			BarcodeWritten?.Invoke(this, index);
		}	
	}
}
