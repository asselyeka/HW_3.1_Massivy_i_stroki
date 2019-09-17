using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._1_Massivy_i_stroki
{
    class Program
    {
        static void Main(string[] args)
        {
            char enterSymbol=' ';
                var countSpace = 0;
            while(enterSymbol!='.')
            {
                enterSymbol = Console.ReadKey().KeyChar;
                if (enterSymbol == ' ') countSpace++;
            }
            Console.Write("\nКоличество введенных пробелов: ");
            Console.WriteLine(countSpace);
            Console.ReadLine();
        }
    }
}
