using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary.InterfaceModel
{

    /// <summary>
    /// This interface is a template to follow in order to execute Arithmentic operation
    /// </summary>
    public interface IArithmenticOperation
    {

        /// <summary>
        /// This method executes the addition operation of the calculator
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        string Addition(string operand1, string operand2);

        /// <summary>
        /// This method executes the subtraction operation of the calculator
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        string Subtraction(string operand1, string operand2);

        /// <summary>
        /// This method executes the multiplication operation of the calculator
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        string Multiplication(string operand1, string operand2);

        /// <summary>
        /// This method executes the division operation of the calculator
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <returns></returns>
        string Division(string operand1, string operand2);

        /// <summary>
        /// This method compute the operand values pass to it using the specify operation type
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operand2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        string PerformArithmetic(string operand1, string operand2, string operation);

    }
}
