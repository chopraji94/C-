using System;

namespace ThirdProgram {
	public class InputGame {
		public static void Main() {
			Console.WriteLine("We will play a name guess game");
			string nameChose = "Maya";
			Console.WriteLine("Enter the name");
			string getName = Console.ReadLine();
			
			if ( nameChose == getName ) {
				Console.WriteLine("Winner");	
			} else {
				Console.WriteLine("Better Luck next time");
			}
		}
	}
}