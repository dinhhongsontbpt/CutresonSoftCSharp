using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_Terumo
{
	public class Global
	{
		public static ControlIO ControlIO;
		public const int InputBitCount = 8;
		//
		public static bool[] InputBits = new bool[InputBitCount];
		public const int OutputBitCount = 8;
		//Command OK - Command NG - Change No. Complete - USB Connection ERROR - Spare - Spare - Spare - Software Ready
		public static bool[] OutputBits = new bool[OutputBitCount];
		public static string[] CommandKeys;
		public static string[] OutputComments = new string[] {"Command OK", "Command NG", "Change Model No. Complete", "USB Connection ERROR", "Spare", "Spare", "Spare", "Software Ready" };
		public static bool LogicON;
		public static bool LogicOFF;
		public static ClassCommon Common = new ClassCommon();
	}
}
