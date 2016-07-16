using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class HorizontalLine {
		List<Point> pList;

		public HorizontalLine(int x, int y, int length, char symbol) {
			pList = new List<Point>();

			int maxX = x + length;
			int currentX = x;

			for (int i = x; i < maxX; i++) {
				currentX = x + i;
				Point p = new Point(currentX, y, symbol);
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
