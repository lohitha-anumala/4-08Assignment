using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LinkedListAssignment
{
    class Program
    {
       

        static void Main(string[] args)
        {
            LinkedList<string> IList = new LinkedList<string>(new string[] { "Quick", "Fox", "the", "Lazy" });
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }
            LinkedListNode<string> current = IList.Find("Fox");
            Console.WriteLine();
            Console.WriteLine("---- ----------------------------Find------------------------------------");
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }
            IList.AddFirst("the");
            Console.WriteLine();

            Console.WriteLine("----------------------------AddFirst()-----------------------------------------------");
          //  Console.WriteLine("After using Find");
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }

            IList.AddBefore(current, "brown");
            Console.WriteLine();

            Console.WriteLine("---------------------------------AddBefore()-----------------------------");
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }
            IList.AddAfter(current, "Jumps over");
            Console.WriteLine();
            Console.WriteLine("------------------------ AddAfter()---------------------------");
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }
            IList.AddLast("fox");
            Console.WriteLine();

            Console.WriteLine("--------------------AddLast-------------------------");
           
            foreach (string str in IList)
            {
                Console.Write(str + " ");
            }

           
            IList.FindLast( "fox");





        }
    }
}
