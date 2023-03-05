using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	public class Validation
	{
		
		public bool intInputValidation(int input)
        {
			
			while(true)
            {
                Console.WriteLine("Please enter integer value:");
				string rawInput = Console.ReadLine();
				if (int.TryParse(rawInput, out input))
				{
					return true;
				}
				else
				{
                    Console.WriteLine("Incorrect value type");
					return false;
				}				
            }
        }

		
		public bool rangeValidation(int lowerVal, int upperVal, int value)
		{
			while(true)
            {
				if (value > lowerVal && value < upperVal)
                {
					return true;
                }
				else
                {
                    Console.WriteLine($"Please enter value in range of {lowerVal} and {upperVal}");
					return false;
                }
            }
		}
	}
}
