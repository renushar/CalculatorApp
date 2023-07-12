using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp.Support
{
    public class Calculator
    {
public int FirstNumber { get; set; } //50

        public int SecondNumber { get; set; } //50

        public int actualResult;

        public int Add()
        { 
                actualResult = FirstNumber + SecondNumber;  
        return actualResult;
        }
        public int Sub()
        {
            actualResult = FirstNumber -SecondNumber;
            return actualResult;
        }

        public int Multiply()
        {
            actualResult = FirstNumber *SecondNumber;
            return actualResult;
        }

        public int Divide()
        {
            actualResult = FirstNumber /SecondNumber;
            return actualResult;
        }
    }
}
