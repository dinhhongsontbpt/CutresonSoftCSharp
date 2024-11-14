using Seoul_Software.Log;

namespace Seoul_Software.Alarm
{
	public class AlarmModel
	{
		public int No {  get; set; }
		public eLogLevel AlarmLevel { get; set; }
		public int Index {  get; set; }
		public string Text {  get; set; }
	}
}
