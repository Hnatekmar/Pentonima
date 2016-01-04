using System;

namespace MVC_Ukázka
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			PentonimoModel ctverec = new PentonimoModel (2, 2);
			for (uint y = 0; y < 2; y++) {
				for (uint x = 0; x < 2; x++) {
					ctverec.NastavDilek (x, y);
				}
			}
			PentonimoView zobrazeni = new PentonimoView (ctverec);
			zobrazeni.Zobraz ();
		}
	}
}
