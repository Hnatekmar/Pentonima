using System;

namespace MVC_Ukázka
{
	public class PentonimoView
	{
		PentonimoModel model;

		public PentonimoView (PentonimoModel model)
		{
			this.model = model;
		}

		public void Zobraz()
		{
			for (uint y = 0; y < model.Vyska; y++) {
				for (uint x = 0; x < model.Sirka; x++) {
					if (this.model.NachaziSeDilek (x, y)) {
						Console.BackgroundColor = ConsoleColor.Red;
					} else {
						Console.BackgroundColor = ConsoleColor.Black;
					}
					Console.Write (" ");
				}
				Console.WriteLine ();
			}
		}
	}
}

