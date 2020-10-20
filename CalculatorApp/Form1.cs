using CalculatorLibrary.InterfaceModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class frmCaculator : Form
    {
        
        double answer = 0;
        string operatorationSymbol = "";
        bool isOperationSymbol = false;
        
        string singleOperator = "";
        bool equalToStatus = false;
        private readonly IArithmenticOperation calculatorObj;
        private readonly IUnitatryOperation unitCalObj;

        public frmCaculator(IArithmenticOperation objCal, IUnitatryOperation unitObjCal)
        {
            InitializeComponent();
            calculatorObj = objCal;
            unitCalObj = unitObjCal;
        }

        private void frmCaculator_Load(object sender, EventArgs e)
        {

        }

        //Display numbers to the screen when numerical button is pressed
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

           

            if ((textBox_result.Text == "0" && button.Text != ".") || isOperationSymbol)
            {
                textBox_result.Clear();
            }

            if(button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text += button.Text;
                }
            }
            else
            {
                textBox_result.Text += button.Text;
            }
            
            isOperationSymbol = false;

            


        }

        //Perform an opeation whenever an operation button is clicked
        private void operator_click(object sender, EventArgs e)
        {
            //If answer is not zero carryout arithmentic operation
            if (answer != 0)
            {
                btnEqualTo.PerformClick();
            }

            Button button = (Button)sender;
            operatorationSymbol = button.Text;
            answer = Convert.ToDouble(textBox_result.Text);
            labelAnswer.Text = answer.ToString();
            textBox_result.Text = textBox_result.Text + operatorationSymbol;
            isOperationSymbol = true;
        }

        //To clear button clear the screen an set value to zero
        private void btnClear_click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labelAnswer.Text = "";
            answer = 0;
        }

        //Perform arithmentic calculation when the equal to button is pressed
        private void btnEqual_click(object sender, EventArgs e)
        {
            if (!isOperationSymbol)
            {

                

                try
                {
                    labelAnswer.Text = calculatorObj.PerformArithmetic(answer.ToString(), textBox_result.Text, operatorationSymbol);
                    textBox_result.Text = calculatorObj.PerformArithmetic(answer.ToString(), textBox_result.Text, operatorationSymbol);
                    
                }
                catch (DivideByZeroException ex)
                {

                    labelAnswer.Text = ex.Message;
                }
                
                equalToStatus = true;

            }
        }

        //Perform uninary operation
        private void singleOperand_click(object sender, EventArgs e)
        {
            Button myButton = (Button)sender;
            singleOperator = myButton.Text;

            if(singleOperator == "←")
            {
                //Back space
                if (equalToStatus)
                {
                    btnCancel.PerformClick();
                    equalToStatus = false;
                }
                else
                {

                    if (textBox_result.Text.Length == 1) { textBox_result.Text = "0"; }
                    else { textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1); }

                }
            }
            else
            {
                
                labelAnswer.Text = unitCalObj.PerformUnitary(textBox_result.Text, singleOperator);
                textBox_result.Text = unitCalObj.PerformUnitary(textBox_result.Text, singleOperator);

            }
            //switch (singleOperator) 
            //{
            //    case "←":
            //        //Back space
            //        if (equalToStatus)
            //        {
            //            btnCancel.PerformClick();
            //            equalToStatus = false;
            //        }
            //        else
            //        {

            //            if (textBox_result.Text.Length == 1) { textBox_result.Text = "0"; }
            //            else { textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1); }

            //        }

            //        break;

            //    case "X²":
            //        //Get square of the operand
            //        try
            //        {
            //            singleOperand = Convert.ToDouble(textBox_result.Text);
            //            textBox_result.Text = Math.Pow(singleOperand, 2).ToString();
            //            labelAnswer.Text = textBox_result.Text;
            //            equalToStatus = true;
            //        }
            //        catch (OverflowException ex)
            //        {

            //            MessageBox.Show(ex.Message);
            //        }
            //        catch (NotFiniteNumberException ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }

            //        break;

            //    case "∫x":

            //        //Get square root of operand
            //        try
            //        {
            //            singleOperand = Convert.ToDouble(textBox_result.Text);
            //            textBox_result.Text = Math.Sqrt(singleOperand).ToString();
            //            labelAnswer.Text = textBox_result.Text;
            //            equalToStatus = true;
            //        }
            //        catch (OverflowException ex)
            //        {

            //            MessageBox.Show(ex.Message);
            //        }
            //        catch(NotFiniteNumberException ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }

            //        break;

            //    case "%":
            //        //Get percentage of value of the operand
            //        try
            //        {
            //            singleOperand = Convert.ToDouble(textBox_result.Text);
            //            textBox_result.Text = (singleOperand / 100).ToString();
            //            labelAnswer.Text = textBox_result.Text;
            //            equalToStatus = true;
            //        }
            //        catch (OverflowException ex)
            //        {
            //            MessageBox.Show(ex.Message);

            //        }

            //        break;

            //    case "(+-)":
            //        //Negator
            //        singleOperand = Convert.ToDouble(textBox_result.Text);
            //        textBox_result.Text = (-1 * singleOperand).ToString();
            //        labelAnswer.Text = textBox_result.Text;
            //        equalToStatus = true;
            //        break;

            //}//Switch case

        }

        public void OffCalculator()
        {
            //Off the calculator by disabling all member elements
            btnOff.Hide();
            btnOn.Show();
            textBox_result.Clear();
            textBox_result.Enabled = false;
            labelAnswer.Text = "";
            labelAnswer.Enabled = false;
            btnBack.Enabled = false;
            btnSign.Enabled = false;
            btnCancel.Enabled = false;
            btnSq.Enabled = false;
            btnSqrt.Enabled = false;
            btnPer.Enabled = false;
            btnDivide.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnTimes.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btnMinus.Enabled = false;
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btnPlus.Enabled = false;
            btn0.Enabled = false;
            btnDot.Enabled = false;
            btnEqualTo.Enabled = false;

        }

        public void OnCalculator()
        {
            //On the calculator by making on member element active again
            btnOff.Show();
            btnOn.Hide();
            textBox_result.Text = "0";
            textBox_result.Enabled = true;
            labelAnswer.Text = "";
            labelAnswer.Enabled = true;
            btnBack.Enabled = true;
            btnSign.Enabled = true;
            btnCancel.Enabled = true;
            btnSq.Enabled = true;
            btnSqrt.Enabled = true;
            btnPer.Enabled = true;
            btnDivide.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnTimes.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btnMinus.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btnPlus.Enabled = true;
            btn0.Enabled = true;
            btnDot.Enabled = true;
            btnEqualTo.Enabled = true;

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            //Off button click event called offCalculator method to disable calculator
            OffCalculator();
        }

        private void btnOn_click(object sender, EventArgs e)
        {
            //On button click event called onCalculator method to enable calculator
            OnCalculator();
        }
    }
}
