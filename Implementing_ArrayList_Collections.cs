using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections {
	public class arrayList {
		public static void Main() {
			ArrayList a1 = new ArrayList();
			a1.Add(1);
			a1.Add(2);
			a1.Add(3);
			
			Console.WriteLine("The length of the array list is : " + a1.Count);
			
			Console.WriteLine("Do You want to add Ohter Elements");
			string opt = Console.ReadLine().ToLower();
			string text = "";
			if ( opt == "yes" ) {
				do {
					Console.WriteLine("Which type of element to eneter");
					text = Console.ReadLine();
					if ( text.Contains("int") ) {
						Console.WriteLine("Kidly Enter the input");
					  	int num = Convert.ToInt32(Console.ReadLine());
					  	a1.Add(num);
					  Console.WriteLine("Added Seccesfully..............");
					} else if ( text.Contains("string") ) {
						Console.WriteLine("Kidly Enter the input");
					 	string num = Console.ReadLine();
						a1.Add(num);
						Console.WriteLine("Added Seccesfully..............");
					} else {
						Console.WriteLine("This optiuon is not present");
					}
					Console.WriteLine("Type done to quit or No to proceed");
					text = Console.ReadLine().ToLower();
					if ( text == "done" ) {
						break;
					}
				} while( true );
				printArrayValues(a1);
			} else if ( opt == "no" ) {
				printArrayValues(a1);
			} else {
				Console.WriteLine("Not a correct option");
			}				
			
		}
		
		public static void printArrayValues(ArrayList a1) {
			Console.WriteLine("We have following elements in the array List");
			for ( int  i = 0 ; i < a1.Count ;  i = i+1 ) {
				Console.WriteLine(a1[i]);
			}
			
			foreach ( object i in a1 ) {
				Console.WriteLine(i);
			}
		}
	}
}