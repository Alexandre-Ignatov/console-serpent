using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class VerticalLine {
		List<Point> pList;

		public VerticalLine(int x, int y, int length, char symbol) {
			pList = new List<Point>();

			for (int i = 0; i < length; i++) {
				Point p = new Point(x, y + i, symbol);
				pList.Add(p);
			}
		}

		public void Draw() {
			foreach (Point p in pList) {
				p.Draw();
			}
		}
	}
}
