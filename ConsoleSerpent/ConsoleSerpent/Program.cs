﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Point p1 = new Point(1, 3, '*');
			p1.Draw();

			Point p2 = new Point(2, 6, '@');
			p2.Draw();

			Point p3 = new Point(7, 2, '^');
			p3.Draw();

			Console.ReadLine();
		}

	}
}
