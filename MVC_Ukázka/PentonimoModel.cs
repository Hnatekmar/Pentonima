using System;
using System.Diagnostics;

namespace MVC_Ukázka
{
	public class PentonimoModel
	{
		public uint Sirka {
			get;
			private set;
		}

		public uint Vyska {
			get;
			private set;
		}

		private bool[,] model;

		public PentonimoModel (uint vyska, uint sirka)
		{
			Vyska = vyska;
			Sirka = sirka;
			model = new bool[vyska,sirka];
		}

		public bool NachaziSeDilek(uint x, uint y)
		{
			#region asserts
				Debug.Assert(x < Sirka && x >= 0);
				Debug.Assert(y < Vyska && y >= 0);
			#endregion
			return model [y, x];
		}

		public void NastavDilek(uint x, uint y)
		{
			#region asserts
				Debug.Assert(x < Sirka && x >= 0);
				Debug.Assert(y < Vyska && y >= 0);
			#endregion
			this.model [y, x] = true;
		}

		public void Rotuj()
		{
			uint tmp = Vyska;
			Vyska = Sirka;
			Sirka = tmp;
			bool[,] novyModel = new bool[Vyska, Sirka];
			for (uint y = 0; y < Vyska; y++) {
				for (uint x = 0; x < Sirka; y++) {
					novyModel [y, x] = this.model [x,y];
				}
			}
			this.model = novyModel;
		}
	}
}

