using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace olassessment
{
    public static class Question2
    {
        

        public static void DecimalToBinary(){
            try{
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(num, 2);
            Console.WriteLine(binary);

            }catch(Exception ex){
                Console.WriteLine("Your input is incorrect", ex.Message);
            }
            
        
        }
    }
}