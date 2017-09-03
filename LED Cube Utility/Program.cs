using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Led3dImage;
using Newtonsoft.Json.Linq;

namespace LED_Cube_Utility {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());

			Console.Write(new string('\n', 5));

			Led3dAnimation l3a = new Led3dAnimation(2, 2, 2);
			l3a.AddFrame(1);
			l3a.GetFrame(1).GetLed3dFrameLayer(0).SetPixel(0, 1, true);
			JObject jo = l3a.ToJson();
			Console.WriteLine(jo);

			Console.Write(new string('\n', 5));

		}
	}
}
