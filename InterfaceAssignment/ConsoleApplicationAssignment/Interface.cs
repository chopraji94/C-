using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
   public interface I1
    {
        void method();
    }
    public interface I2
    {
        void method();
    }
    class Interfaces
    {
        
            void method()
        {
                System.Diagnostics.Debug.WriteLine("This is a console application");
            }
        static void Main(string[]args)
        {
            Interfaces I = new Interfaces();
            I.method();
                 
        }
        }
    }

