using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExercise02
{
    public class PayDay
    {

        
        public int ActualPaycheck(int num01, int num02)
        {
            
            int tempValue;
            tempValue = num01 * num02;
            return tempValue;
           
        }
        public decimal ActualPaycheck (decimal num01, decimal num02)
        {
            decimal tempValue;
            tempValue = num01 + num02;
            return tempValue;
        }

        public void ActualPaycheck(string num01, string num02, out int tempValue)
        {
            
            tempValue = Convert.ToInt32(num01) - Convert.ToInt32(num02);   //for math operations you must convert string to int      
            
        }


    }
}
