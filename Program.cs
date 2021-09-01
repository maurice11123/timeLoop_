using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace timeLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            int magicNum;

            Console.WriteLine("Enter Wizard Number");
            magicNum = int.Parse(Console.ReadLine());


            for (i = 1; i < magicNum + 1; i++)
            {
                Console.WriteLine(i + " Abracadabra");
            }
            Console.ReadLine();

        }

    }
}
