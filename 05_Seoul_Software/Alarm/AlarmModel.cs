using Seoul_Software.Log;
using System.Drawing;

namespace Seoul_Software.Alarm
{
	public class AlarmModel
	{
		public int No {  get; set; }
		public eLogLevel AlarmLevel { get; set; }
		public int Index {  get; set; }
		public string Unit {  get; set; }
		public string Description {  get; set; }
		public string Text {  get; set; }
		public Image Image { get; set; }
		public string ErrorHelp {  get; set; }
		public string ErrorCode { get {  return Index.ToString("0000"); } }
	}
}
