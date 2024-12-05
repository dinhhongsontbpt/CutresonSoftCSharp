using Cutreson_Utility;
using Seoul_Software.Properties;
using System;
using System.Collections.Generic;
using System.IO;

namespace Seoul_Software.Scanner
{
	public class clsBarcodeManager
	{
		public static void Save()
		{
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.BarcodeFile);
				clsSave.WriteToXmlFile<List<BarcodeModel>>(pathFile, Global.Barcodes, false);
			}
			catch (Exception ex)
			{
				Global.Log.Error("Save barcode: " + ex.Message);
			}
		}
		public static void Load()
		{
			if (!Directory.Exists(clsConfig.DatabasePathFolder))
			{
				Directory.CreateDirectory(clsConfig.DatabasePathFolder);
			}
			try
			{
				string pathFile = Path.Combine(clsConfig.DatabasePathFolder, clsConfig.BarcodeFile);
				if (File.Exists(pathFile))
				{
					Global.Barcodes = (List<BarcodeModel>)clsSave.ReadFromXmlFile<List<BarcodeModel>>(pathFile);
				}
				else
				{
					Save();
				}
			}
			catch (Exception ex)
			{
				Global.Log.Error("Save barcode: " + ex.Message);
			}
		}
	}
}
