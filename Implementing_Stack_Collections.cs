using System;
using System.Collections;

namespace PlayingWithText {
	public class Check {
		public static void Main() {
			Stack s1 = new Stack(); 
			bool check = false;
			Console.WriteLine("Enter the string");
			string text = Console.ReadLine();
			Console.WriteLine("Processing................");
			foreach ( char i in text ) {
				s1.Push(i);
			}
			
			foreach ( char i in text ) {
				if ( i.Equals( s1.Pop() ) ) {
					check = true;
				} else {
					check = false;
					break;
				}
			}
			
			string result = ( check ) ? "The reverse of string is same" : "The reverse of the string is not same" ;
			Console.WriteLine(result);
			
		}
	}
}