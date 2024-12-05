using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seoul_Software.SQL
{
	public class LotModel
	{
		public long Id {  get; set; }
		public string LotNo {  get; set; }
		public DateTime TimeInput { get; set; } = DateTime.Now;
		public DateTime TimeOutput { get; set; } = DateTime.Now;
		public int Total { get; set; } = 0;
	}
	public class RingModel
	{
		public long Id { get; set; }
		public string LotNo { get; set; }
		public DateTime TimeOutput { get; set; } = DateTime.Now;
		public int Total { get; set; } = 0;
	}
}
