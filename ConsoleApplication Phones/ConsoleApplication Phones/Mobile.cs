using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication_Phones
{
    
        
      public  abstract class feature
        {
            public abstract void calling();
        }

       public  class Apple : feature
        {

            public override void calling()
            {
                System.Diagnostics.Debug.WriteLine("Camera: 64MP");
                System.Diagnostics.Debug.WriteLine("Storage 64gb ");
                System.Diagnostics.Debug.WriteLine("Calling:Dual");
            }
        }
        public class Samsung : feature
        {
            public override void calling()
            {
                System.Diagnostics.Debug.WriteLine("Camera:32MP");
                System.Diagnostics.Debug.WriteLine("Storage:32gb");
                System.Diagnostics.Debug.WriteLine("Calling:Dual Sim");
            }

             
       
        }
        class Test
        {
            public static void Main(string[] args)
            {
             
                string name = Console.ReadLine();
                System.Diagnostics.Debug.WriteLine("Name of brand: " + name);
                feature f;
            name = name.ToLower();

            if(name.Equals("apple"))
            {
                f = new Apple();
                f.calling();
            } else if (name.Equals("samsung") )
            {
                f = new Samsung();
                f.calling();
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Brand not available");
            }
                   
                    

                
                   
                
            }
        }
    }
