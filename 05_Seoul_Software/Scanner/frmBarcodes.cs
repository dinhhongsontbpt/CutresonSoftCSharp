using Seoul_Software.Scanner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seoul_Software
{
    public partial class frmBarcodes : Form
    {
        private List<ucBarcode> ucBarcodeDisplays = new List<ucBarcode>();
        public frmBarcodes()
        {
            InitializeComponent();
            Init();

		}
        private void Init()
        {
            for (int i = 0; i < 10; i++)
            {
                ucBarcode uc = new ucBarcode();
                BarcodeModel barcode = new BarcodeModel();
                uc.index = i;
                barcode.Index = i;
                uc.SetModel(barcode);
                uc.Dock = DockStyle.Fill;
                ucBarcodeDisplays.Add(uc);
				tableLayoutPanel1.Controls.Add(uc);
				uc.BarcodeWritten += Uc_BarcodeWritten;
            }

            int[] idBarcodesIP = Global.PLC.ReadBarcodeIdInput();
            if (idBarcodesIP != null && idBarcodesIP.Length > 0)
            {
                for (int i = 0; i < idBarcodesIP.Length; i++)
                {
                    if(idBarcodesIP[i] != 0)
                    {
						if (!BarcodeModel.IsIdExist(idBarcodesIP[i]))
						{
							Global.Log.Alarm($"Barcode Id={idBarcodesIP[i]} is not exist in software. Please initial system");
                            tableLayoutPanel1.Visible = false;
                            return;
						}
                        else
                        {
                            BarcodeModel barcode = Global.Barcodes.Find(b => b.Id == idBarcodesIP[i]);
                            ucBarcode uc = ucBarcodeDisplays.Find(b => b.barcode.Index == barcode.Index);
                            uc.SetModel(barcode);
                            //Global.Log.Operation($"Load barcode: {barcode.Data},Id={barcode.Id} in history data");
                        }
					}
                    
                }
            }
            foreach(var item in ucBarcodeDisplays)
            {
                if (item.barcode.Id == 0)
                {
                    item.barcode.Id = GenerateId();
                }
                item.UpdateView();
            }
			//Event
			Global.PLC.PropertyChanged += PLC_PropertyChanged;
        }

		private void PLC_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == "PlcGetCvBarcode")
            {
                if(Global.PLC.PlcGetCvBarcode)
                {
                    if (!string.IsNullOrEmpty(ucBarcodeDisplays[0].barcode.Data))
                    {
						Global.Log.Operation("PLC get Barcode: " + ucBarcodeDisplays[0].barcode.ToString());
						for (int i = 0; i < 9; i++)
						{
							ucBarcodeDisplays[i].SetModel(ucBarcodeDisplays[i + 1].barcode);
							int id = ucBarcodeDisplays[i + 1].barcode.Id;
							BarcodeModel bc = Global.Barcodes.Find(b => b.Id == id);
							if (bc != null)
							{
								bc.Index = i;
							}
						}
						clsBarcodeManager.Save();
						BarcodeModel barcode = new BarcodeModel();
						barcode.Id = GenerateId();
						ucBarcodeDisplays[9].SetModel(barcode);
						for (int i = 0; i < 10; i++)
						{
							if (string.IsNullOrEmpty(ucBarcodeDisplays[i].barcode.Data))
							{
								ucBarcodeDisplays[i].FocusAndSelectAll();
								break;
							}
						}
					}
				}   
            }
            if(e.PropertyName == "Initial")
            {
                if(Global.PLC.Initial)
                {
					Global.Barcodes.Clear();
                    clsBarcodeManager.Save();
					foreach (var item in ucBarcodeDisplays)
					{
						BarcodeModel barcode = new BarcodeModel();
						barcode.Id = GenerateId();
						item.SetModel(barcode);
					}
                    ucBarcodeDisplays[0].FocusAndSelectAll();
                    Global.Log.Operation("Clear all barcode data");
				}
            }
		}

		private void Uc_BarcodeWritten(object sender, int e)
		{
			if(e >= 9)
            {
                ucBarcodeDisplays[0].FocusAndSelectAll();
			}
            else
            {
                ucBarcodeDisplays[e + 1].FocusAndSelectAll();
			}
		}

		private int GenerateId()
        {
            int id = 0;
            for(int i = 1; i <= clsConfig.IdBarcodeMax; i++)
            {
				bool check = !ucBarcodeDisplays.Any(b => b.barcode.Id == i);
				if ((!BarcodeModel.IsIdExist(i)) && check) return i;
            }
            return id;
		}
    }
}
