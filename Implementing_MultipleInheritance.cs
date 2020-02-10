using System;

namespace MultipleInherit {
	
	interface first {
	  void print();
	}
	
	interface second {
		void printOther();	
	}
	
	public class Sum : first , second {
		public void print() {
			Console.WriteLine("First");
		}
		
		public void printOther() {
			Console.WriteLine("second");
		}
	}
	
	public class Combine {
		public static void Main() {
			
			Sum sr = new Sum();
			sr.print();
			sr.printOther();
		}
	}
}