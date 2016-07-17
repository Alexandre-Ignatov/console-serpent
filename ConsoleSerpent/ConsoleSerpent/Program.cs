using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleSerpent {
	class Program {
		static void Main(string[] args) {

			Console.SetBufferSize(80, 25);

			Walls walls = new Walls(80, 25);
			walls.Draw();

			Point head = new Point(8, 8, '$');

			Snake snake = new Snake(head, 3, Direction.RIGHT);
			snake.Draw();

			FoodCreator foodCreator = new FoodCreator(80, 25, '*');
			Point food = foodCreator.CreateFood();
			food.Draw();

			while(true) {

				if (walls.IsHit(snake) || snake.IsHitTail()) {
					break;
				}

				if(snake.Eat(food)) {
					food = foodCreator.CreateFood();
					food.Draw();
				}

				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey();
					snake.ControlMovement(key.Key);					
				}
				Thread.Sleep(50);
				snake.Move();
			}
		}
	}
}
