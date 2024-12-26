using _07_Kefico_LeakCurrentSystem.Log;
using _07_Kefico_LeakCurrentSystem.Login;
using _07_Kefico_LeakCurrentSystem.PLC;

namespace _07_Kefico_LeakCurrentSystem
{
	public class Global
	{
		public static Logger Log = new Logger();
		public static eRole Role;
		public static clsControlPLC PLC;
	}
}
