using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Console.SetBufferSize(80, 25);

			new HorizontalLine(0, 0, 80, '#').Draw();
			new HorizontalLine(0, 23, 80, '#').Draw();
			new VerticalLine(0, 0, 24, '#').Draw();
			new VerticalLine(79, 0, 24, '#').Draw();

			Point head = new Point(8, 8, '@');

			Snake snake = new Snake(head, 3, Direction.RIGHT);
			snake.Draw();
			snake.Move();

			Console.ReadLine();
		}

	}
}
