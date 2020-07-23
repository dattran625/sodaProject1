using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sodaProject
{
     class StaticUserInterfaces
    {


        static public void DisplaySelection()
        {
            
            Console.WriteLine(" C - Cola     ");
            Console.WriteLine("R - RootBeer  ");
            Console.WriteLine("O - OrangeSoda");
            Console.WriteLine();
            Console.WriteLine(" Please select your drink");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }
        static public void MakeDrinkSelection(char selection)
        {
            bool selectionValid = false;
            while(!selectionValid)
            {
                switch(selection)
                {
                    case 'C':
                        Console.WriteLine("Thank you, Here is your Cola");
                        selectionValid = true;
                        break;

                    case 'R':
                        Console.WriteLine("Thank you, Here is your RootBeer");
                        selectionValid = true;
                        break;


                    case 'O':
                        Console.WriteLine("Thank you, Here is your OrangeSoda");
                        selectionValid = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please re-enter your selection");
                        selection = Convert.ToChar(Console.ReadLine().ToUpper());
                        selectionValid = false;
                        break;


                }

            }

        }
    }
}
