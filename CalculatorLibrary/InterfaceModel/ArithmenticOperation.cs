using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using CalculatorLibrary.HelperClass;

namespace CalculatorLibrary.InterfaceModel
{
 
    //The Arithmetic implement the Arithematic interface
    public class ArithmenticOperation : IArithmenticOperation
    {
        //The Addition method execute addition operation on the values passed to it
        public string Addition(string num1, string num2)
        {
            
            var outCome = Computes.TypeConverter(num1, num2);
            return (outCome[0] + outCome[1]).ToString();
            
        }

        //The Subtraction method execute minus operation on the values passed to it
        public string Subtraction(string operand1, string operand2)
        {
            var outCome = Computes.TypeConverter(operand1, operand2);
            return (outCome[0] - outCome[1]).ToString();
        }

        //The Division method execute division operation on the values passed to it
        public string Division(string operand1, string operand2)
        {
           
            var outCome = Computes.TypeConverter(operand1, operand2);
            if (outCome[1] == 0)
            {
                throw new DivideByZeroException("Can't divide by 0");
            }

            return (outCome[0] / outCome[1]).ToString();
        }

        //The Multiplication method execute multiplication operation on the values passed to it
        public string Multiplication(string operand1, string operand2)
        {
            var outCome = Computes.TypeConverter(operand1, operand2);
            return (outCome[0] * outCome[1]).ToString();
        }

        //The PerformArithmetic method takes two strings of number and a string of operator
        public string PerformArithmetic(string operand1, string operand2, string operation)
        {

            string compute = "";

            switch (operation)
            {
                case "+":

                    //Addition of the two operands 
                    compute = this.Addition(operand1, operand2);
                    break;

                case "-":

                    //Subtraction of the two operands
                    compute = this.Subtraction(operand1, operand2);
                    break;

                case "X":

                    //Multiplication of the two operands
                    compute = this.Multiplication(operand1, operand2);
                    break;

                case "÷":

                    //Division of the two operands
                    compute = this.Division(operand1, operand2);
                    break;
                default:
                    break;

            }

            return compute;

        }

       
    }
}
