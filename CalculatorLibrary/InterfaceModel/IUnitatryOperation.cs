using System;

namespace CalculatorLibrary.InterfaceModel
{

    /// <summary>
    /// This interface is a template to follow in order to execute Unitary operation
    /// </summary>

    public interface IUnitatryOperation
    {

        /// <summary>
        /// This method executes the square operation of the calculator
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns> 
        string Square(string operand);

        /// <summary>
        /// This method executes the square root operation of the calculator
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
        string SquareRoot(string operand);

        /// <summary>
        /// This method executes the percentage operation of the calculator
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
        string Percent(string operand);

        /// <summary>
        /// This method negate the operand
        /// </summary>
        /// <param name="operand"></param>
        /// <returns></returns>
        string Negator(string operand);

        /// <summary>
        /// This method perform unary operation on value pass to it using the specify operation type
        /// </summary>
        /// <param name="operand1"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        string PerformUnitary(string operand1, string operation);

    }
}
