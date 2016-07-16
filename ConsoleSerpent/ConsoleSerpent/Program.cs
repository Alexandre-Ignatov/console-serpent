using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Draw(5, 5, '*');
			Draw(6, 6, '@');
			Console.ReadLine();
		}

		static void Draw(int x, int y, char symbol) {
			Console.SetCursorPosition(x, y);
			Console.Write(symbol);
		}
	}
}
