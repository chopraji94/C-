using System;

namespace EnumsCheck {
	public class Check {
		
		enum Level {
			monday,
			tuesday,
			sunday
		}
		
		public static void Main() {
			Level myLvl = Level.monday;
			Level[] myvar = { Level.monday, Level.tuesday, Level.sunday };
			switch ( myLvl ) {
				case Level.monday:
					Console.WriteLine("It is Mondayaaaaa");
					break;
				case Level.tuesday:
					Console.WriteLine("It is Tuesday");
					break;
				case Level.sunday:
					Console.WriteLine("It is a fun day");
					break;
			}
			
			foreach ( object i in myvar ) {
				Console.WriteLine(i);
			}
		}
	}
}