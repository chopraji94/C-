
using System;
using System.Collections;
using System.Collections.Generic;
					
public class HelloWorld
{
	
	public static void Main() {
		IDictionary<Object,Object> dict = new Dictionary<Object,Object>();
		addTotheDict(dict);
		printThedict(dict);
	}
	
	public static void addTotheDict(IDictionary<Object,Object> id) {
		id.Add("helllo",23);
		id.Add(53,"Bye");
		id.Add(34,45);
	}
	
	public static void printThedict(IDictionary<Object,Object> id) {
		foreach ( KeyValuePair<Object, Object> item in id ) {
			Console.WriteLine("The Key is -: " + item.Key + " value for the given key is -: " + item.Value);	
		}
	}
	
	
	/*public static void Main() {
		IDictionary<int,string> dict = new Dictionary<int,string>();
		addToTheDict(dict);
		printTheDictionary(dict);
	}
	
	public static void addToTheDict(IDictionary<int,string> id) {
		id.Add(1,"Pranav");
		id.Add(2,"Chopra");
		id.Add(3,"Hello");
	}
	
	public static void printTheDictionary(IDictionary<int,string> id) {
		foreach ( KeyValuePair<int , string> item in id)
		{
			Console.WriteLine("Key is " + item.Key + " value for the ksy is -: " + item.Value);
		}	
	}*/

	/*public static void Main()
		
	{
		Hashtable ht = new Hashtable();
		ht.Add("001","Hello1");
		ht.Add(12,"Yellow");
		ht.Add("Name","pranav");
		
		Console.WriteLine(ht.Count);
		ICollection key = ht.Keys;
		
		foreach ( Object k in key  ) {
			Console.WriteLine(k + " the word corresponding to the key is : " + ht[k]);
		}
	}  */
}