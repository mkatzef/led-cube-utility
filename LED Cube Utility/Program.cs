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
			Application.Run(new MainForm());

			/*Console.Write(new string('\n', 5));

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
			}*/

			//Test layer
			/*Console.Write(new string('\n', 5));
			Led3dFrameLayer a = new Led3dFrameLayer(5, 5);
			a.SetPixel(3, 2, true);
			JObject b = a.ToJson();
			string t1 = b.ToString();
			Console.WriteLine(t1);

			Console.Write(new string('\n', 5));

			Led3dFrameLayer c = new Led3dFrameLayer(b);
			string t2 = c.ToJson().ToString();
			Console.WriteLine(t2);


			Console.Write(new string('\n', 5));
			Console.WriteLine(t1 == t2);*/

			//Test frame
			/*Console.Write(new string('\n', 5));
			Led3dFrame a = new Led3dFrame(5, 5, 5);
			a.GetLed3dFrameLayer(2).SetPixel(3, 2, true);
			JObject b = a.ToJson();
			string t1 = b.ToString();
			Console.WriteLine(t1);

			Console.Write(new string('\n', 5));

			Led3dFrame c = new Led3dFrame(b);
			string t2 = c.ToJson().ToString();
			Console.WriteLine(t2);


			Console.Write(new string('\n', 5));
			Console.WriteLine(t1 == t2);*/

			//Test Animation
			/*Console.Write(new string('\n', 5));
			Led3dAnimation a = new Led3dAnimation(5, 5, 5);
			a.AddFrame(1);
			a.GetFrame(1).GetLed3dFrameLayer(2).SetPixel(3, 2, true);
			JObject b = a.ToJson();
			string t1 = b.ToString();
			Console.WriteLine(t1);

			Console.Write(new string('\n', 5));

			Led3dAnimation c = new Led3dAnimation(b);
			string t2 = c.ToJson().ToString();
			Console.WriteLine(t2);


			Console.Write(new string('\n', 5));
			Console.WriteLine(t1 == t2);*/
		}
	}
}
