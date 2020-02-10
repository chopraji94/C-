using System;

namespace GameProgram {
	public class Calculate {
		public static void Main() {
			bool check = false;
			var x = 5;
			
			if ( x % 2 == 0 ) {
				Console.WriteLine("Even number");
			}else {
				check = true;
			}
			
			if ( check == true ) {
				Console.WriteLine("Odd Number is there");
			}
		}
	}
}