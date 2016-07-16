using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Console.SetBufferSize(80, 25);

			new HorizontalLine(0, 0, 80, '#').Draw();
			new HorizontalLine(0, 23, 80, '#').Draw();
			new VerticalLine(0, 0, 24, '#').Draw();
			new VerticalLine(79, 0, 24, '#').Draw();

			new Point(4, 4, '@').Draw();

			Console.ReadLine();
		}

	}
}
