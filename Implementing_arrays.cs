using System;

namespace Practicing {
	public class ReturnFunctions {
		
		public static int MyMethod(int[] array) {
			int sum = 0;
			foreach ( int i in array ) {
				sum = sum + i ;
			}
			return sum ;
		}
		
		public static void Main() {
			Console.WriteLine("Enter how many numbers to enter");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] array = new int[size];
			Console.WriteLine("Enter the numbers");
			for( int i = 0;i < size; i++ ) {
				int num = Convert.ToInt32(Console.ReadLine());
				array[i] = num;
			}
			int z = MyMethod(array);
			Console.WriteLine("Sum of elements in array is : " + z);
		}
	}
}