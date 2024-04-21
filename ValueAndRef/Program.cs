using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueAndRef
{
    class Cat
    {

    }
    class Program
    {

        static void Main(string[] args)
        {
            #region Boxing
           
            string Box = "Watch";
        
            object Giftwrapper = Box;
            
            Console.WriteLine(Giftwrapper);
            Console.ReadKey();
            #endregion

            #region Unboxing
           
            Box = (string)Giftwrapper;
            
            Console.WriteLine(Box);
            Console.ReadKey();
            #endregion

        }
    }
}
