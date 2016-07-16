﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSerpent {
	class Snake : Figure {
		Direction direction;

		public Snake (Point head, int length, Direction _direction) {
			direction = _direction;
			pList = new List<Point>();

			for (int i = 0; i < length; i++) {
				Point p = new Point(head);
				p.MoveOpposite(i, direction);
				pList.Add(p);
			}
		}

		internal void Move() {
			Point tail = pList.Last();
			pList.Remove(tail);
			Point head = GetNextPoint();
			pList.Insert(0, head);

			tail.Clear();
			head.Draw();
		}

		public Point GetNextPoint() {
			Point head = pList.First();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}
	}
}
