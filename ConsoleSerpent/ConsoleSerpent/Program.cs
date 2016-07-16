using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Point p1 = new Point(1, 3, '*');
			Point p2 = new Point(2, 6, '@');
			Point p3 = new Point(7, 2, '^');

			HorizontalLine line = new HorizontalLine(4, 7, 12, '&');
			line.Draw();

			Console.ReadLine();
		}

	}
}
