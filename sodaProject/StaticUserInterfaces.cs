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
            
            Console.WriteLine(" Cola  ");
            Console.WriteLine( "RootBeer ");
            Console.WriteLine( "OrangeSoda ");
            Console.WriteLine();
            Console.WriteLine(" Please select your drink");
            Console.ReadLine();
        }
        static public string ValidateDrinkSelection(string selection)
        {
            bool selectionValid = false;
            while(!selectionValid)
            {
                switch(selection)
                {
                    case "Cola":
                        Console.WriteLine("Thank you for choosing Cola");
                        
                        
                        selectionValid = true;
                        break;
                        

                    case "RootBeer":
                        Console.WriteLine("Thank you for choosing RootBeer");
                       
                        selectionValid = true;
                        break;


                    case "OrangSoda":
                        Console.WriteLine("Thank you for choosing OrangeSoda");
                        
                        selectionValid = true;
                        break;

                    default:
                        Console.WriteLine("Invalid selection. Please re-enter your selection");
                        selection = Console.ReadLine();
                        selectionValid = false;
                        break;


                }

                
            }
            return selection;

        }
       
        static public void CoinSelectionDisplay()
        { 
            Console.WriteLine(" 1 - Penny     ");
            Console.WriteLine(" 5 - Nickle    ");
            Console.WriteLine(" 10 - Dime     ");
            Console.WriteLine(" 25 - Quarter  ");
            Console.WriteLine();
            Console.WriteLine(" Please insert your coin");
            Convert.ToDouble(Console.ReadLine().ToUpper());
        }
        


    }




    

    
        
            
    
}
