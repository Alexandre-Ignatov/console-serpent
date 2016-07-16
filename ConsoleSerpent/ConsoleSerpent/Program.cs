using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Point p1 = new Point();
			p1.x = 1;
			p1.y = 3;
			p1.symbol = '*';
			p1.Draw();

			Console.ReadLine();
		}

	}
}
