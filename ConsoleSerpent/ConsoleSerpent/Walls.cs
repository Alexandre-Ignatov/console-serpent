using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Walls {
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight) {
			wallList = new List<Figure>();

			HorizontalLine top = new HorizontalLine(0, 0, mapWidth - 1, '#');
			HorizontalLine bottom = new HorizontalLine(0, mapHeight - 1, mapWidth - 1, '#');
			VerticalLine left = new VerticalLine(0, 0, mapHeight - 1, '#');
			VerticalLine right = new VerticalLine(mapWidth - 1, 0, mapHeight - 1, '#');

			wallList.Add(top);
			wallList.Add(bottom);
			wallList.Add(left);
			wallList.Add(right);
		}

		public void Draw() {
			foreach (var wall in wallList) {
				wall.Draw();
			}
		}

		internal bool IsHit(Figure figure) {
			foreach(var wall in wallList) {
				if (wall.IsHit(figure)) {
					return true;
				}
			}

			return false;
		}

	}
}
