using CalculatorLibrary.InterfaceModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibrary
{
    public static class CentralConfig
    {

        /// <summary>
        /// The instance to be use as object in the calculator
        /// </summary>
        public static IArithmenticOperation ILinks { get; set; }
        public static IUnitatryOperation IUnitatryLinks { get; set; }

        public static void AddLinkInstance()
        {


            ArithmenticOperation arithmentic = new ArithmenticOperation();
            //Functionality of class Arithmentic given to instance Ilink
            ILinks = arithmentic;

            UnitaryOperation unitOperation = new UnitaryOperation();
            //Functionality of class UnitaryOperation given to instance IUnitatryLinks
            IUnitatryLinks = unitOperation;

        }

        public static void RemoveLinkInstance()
        {
            ILinks = null;
            IUnitatryLinks = null;
        }

    }
}
