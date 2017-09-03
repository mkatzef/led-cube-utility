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

			Led3dAnimation l3a = new Led3dAnimation(5, 5, 5);
			l3a.AddFrame(1);
			l3a.GetFrame(1).GetLed3dFrameLayer(0).SetPixel(0, 1, true);
			l3a.SetFrameDuration(1, 2);
			JObject jo = l3a.ToJson();
			Console.WriteLine(jo);

			Console.Write(new string('\n', 5));

			String testJson = jo.ToString();

			Led3dAnimation l3atest = Led3dAnimation.FromJson(testJson);
			JObject jotest = l3atest.ToJson();
			Console.WriteLine("TEST:");
			Console.WriteLine(jotest);

			Console.Write(new string('\n', 5));

			String resString = jotest.ToString();

			if(resString == testJson) {
				Console.WriteLine("PASS");
			} else {
				Console.WriteLine("FAIL");
			}
		}
	}
}
