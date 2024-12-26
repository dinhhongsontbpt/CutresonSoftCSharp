using Newtonsoft.Json;
using Seoul_Software.Log;
using System;
using System.Drawing;

namespace Seoul_Software.Alarm
{
	public class AlarmModel
	{		
		public int No {  get; set; }
		public DateTime Time { get; set; }
		public string Code { get { return Index.ToString("0000"); } }
		public string Text { get; set; }
		public string Unit { get; set; }
		public string Description { get; set; }	
		public eLogLevel Level { get; set; }
		public int Index {  get; set; }
		[JsonIgnore]
		public Image Image { get; set; }
		public string ImageLink {  get; set; }
		public string Help {  get; set; }
	}
}
