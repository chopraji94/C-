using System;

namespace Inheritance {
	
	public class Shop { //base class
		string fruitName = "Oranges";
		public void speak() {
			Console.WriteLine(fruitName);
		}
	}
	
	public class Fruit:Shop { //derived class
		public string shopName = "Ambala";
	}
	
	public class Program {
		public static void Main() {
			Fruit fr = new Fruit();
			fr.speak();
			Console.WriteLine(fr.shopName);
		}
	}
}