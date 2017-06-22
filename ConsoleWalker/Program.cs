using System;
using System.Linq;

namespace ConsoleWalker
{
	class Program
	{
		static string[] dude = {
			@" =,    (\_/)    ,= ",
			@"  /`-'--("")--'-'\  ",
			@" /     (___)     \ ",
			@"/.-.-./ "" "" \.-.-.\",
		};
		static int x = 0;
		static int y = 0;

		static void Main(string[] args)
		{
			var key = default(ConsoleKeyInfo);

			do
			{
				// clear
				Console.Clear();

				// move dude
				switch (key.Key)
				{
					case ConsoleKey.LeftArrow:
						x--;
						break;
					case ConsoleKey.UpArrow:
						y--;
						break;
					case ConsoleKey.RightArrow:
						x++;
						break;
					case ConsoleKey.DownArrow:
						y++;
						break;
				}

				// draw dude
				for (int i = 0; i < y; i++)
				{
					Console.WriteLine();
				}
				var indent = string.Concat(Enumerable.Repeat(" ", x));
				foreach (var line in dude)
				{
					Console.WriteLine();
					Console.Write(indent);
					Console.Write(line);
				}

			}
			while ((key = Console.ReadKey()).Key != ConsoleKey.Escape);

			// make sure we return the cursor like a nice guy
			Console.WriteLine();
		}
	}
}