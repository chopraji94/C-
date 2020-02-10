 using System;

namespace Atoughgame {
	public class GameMaker {
		public static void Main() {
			Console.WriteLine("Enter the number of names to input in the array");
			int num = Convert.ToInt32(Console.ReadLine());
			string[] names = new String[num];
			Console.WriteLine("Start Entering the name");
			for (int i=0;i<num;i++) {
				string name = Console.ReadLine();
				names[i] = name;
			}
			Console.WriteLine("Sorting the array of names................");
			Array.Sort<string>(names);
			Console.WriteLine("Guess name and at what place it could be placed");
			int index = Convert.ToInt32(Console.ReadLine());
			string guessName = Console.ReadLine();
			bool check = true;
			bool notAllCheck = false;
			for ( int i=0 ;  i < names.Length ; i++ ){
				if ( guessName == names[i] ) {
					if ( index == i+1 ) {
						check = true;
						break;
					} else {
						notAllCheck = true ;
						break;
					}
				} else {
					check = false;
				}
			}
			
			if ( check ) {
				Console.WriteLine("The name and place guess was Correct");
			} else {
				if ( notAllCheck ) {
					Console.WriteLine("You find the name but not the exact location");
				} else {
				Console.WriteLine("We can't find the name in array");	
				}
			}
		}
	}
}