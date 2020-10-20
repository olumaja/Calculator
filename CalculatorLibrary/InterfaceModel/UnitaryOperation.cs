using System;
using System.Collections.Generic;
using System.Text;
using CalculatorLibrary.HelperClass;

namespace CalculatorLibrary.InterfaceModel
{

    //The Unitary operation implement the Unitary interface
    public class UnitaryOperation : IUnitatryOperation
    {

        //The Negator method return opposite sign of the operand
        public string Negator(string operand)
        {
            var outCome = Computes.TypeConverter(operand);

            return (-1 * outCome).ToString();
        }

        //The Percent method return the percentage value of the given operand
        public string Percent(string operand)
        {
            var outCome = Computes.TypeConverter(operand);
            return (outCome / 100).ToString();
        }

        //The Square method return the square value of the given operand
        public string Square(string operand)
        {
            var outCome = Computes.TypeConverter(operand);
            return (Math.Pow(outCome, 2)).ToString();
        }

        //The Square root method return the square root value of the given operand
        public string SquareRoot(string operand)
        {

            var outCome = Computes.TypeConverter(operand);
            return (Math.Sqrt(outCome)).ToString();
        }

        //Takes operand and the operation type and pass it to appropriate method
        public string PerformUnitary(string operand1, string operation)
        {

            string compute = "";

            switch (operation)
            {
                case "(+-)":

                    //Return signed number 
                    compute = this.Negator(operand1);
                    break;

                case "X²":

                    //Give square of a given number
                    compute = this.Square(operand1);
                    break;

                case "%":

                    //Give percentage of a given number
                    compute = this.Percent(operand1);
                    break;

                case "∫x":

                    //Give square root of a given number
                    compute = this.SquareRoot(operand1);
                    break;
                default:
                    break;

            }

            return compute;

        }
    }
}
