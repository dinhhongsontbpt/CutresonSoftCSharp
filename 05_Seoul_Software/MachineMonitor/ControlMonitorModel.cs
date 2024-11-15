namespace Seoul_Software.MachineMonitor
{
	public class ControlMonitorModel
	{
		public int No {  get; set; }
		public int Index {  get; set; }
		public string ControlName {  get; set; }
		public int Value {  get; set; }
		public string Message {  get; set; }
		public string HexCode { get; set; } = "#FFFF00";
	}
}
