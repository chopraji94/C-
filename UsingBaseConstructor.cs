using System;

public class BaseClass {
	String name;
	
	public BaseClass(String cName) {
		this.name = cName;
	}
	
	public void PrinttheName() {
		Console.WriteLine("Entered name is - : " +  name);
	}
}

public class Derivedclass : BaseClass {
	
	int num2;
	
	public Derivedclass(int number,String nameIs):base(nameIs) {
		this.num2 = number;
	}
	
	public void PrintAge() {
		Console.WriteLine("age mentioned is -: " + num2);
	}
}

public class Check {
	public static void Main() {
		Derivedclass dv = new Derivedclass(40, "Hello Everyone");
		dv.PrinttheName();
		dv.PrintAge();
	}
}