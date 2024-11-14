using System;
using System.Linq;

namespace Seoul_Software.Scanner
{
	public class BarcodeModel
	{
		public int Id {  get; set; }
		public string Data {  get; set; }
		public int Index {  get; set; }
		public DateTime TimeScan { get; set; }
		public override string ToString()
		{
			return $"{Data},Id={Id}, Time scan: {TimeScan.ToString("yyyy-MM-dd HH:mm:ss")}";
		}
		public bool IsIdExist()
		{
			return Global.Barcodes.Any(b => b.Id == Id);
		}
		public static bool IsIdExist(int idCheck)
		{
			if(Global.Barcodes == null)
			{
				return false;
			}	
			return Global.Barcodes.Any(b => b.Id == idCheck);
		}
	}
}
