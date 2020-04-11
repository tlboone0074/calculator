using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            

        }

       
        private void Button_Click(object sender, EventArgs e)  //Button for all numbers and (.) on calculator.
        {
            if ((result.Text == "0") || (operation_pressed))
            {
                result.Clear();
            }
            operation_pressed = false;
               
            /*when the event fires,this method gets called and the button that fired the event 
             * is also sent as a parameter to the method.  Its a generic object but we have to 
             * convert it to a button.  Then we can perform button properties.               
             */
            Button b = (Button)sender;
            if  (b.Text == ".")
            {
                if (!result.Text.Contains("."))
                     result.Text = result.Text + b.Text;              
            }
            else
                    result.Text = result.Text + b.Text;

            //Above the result textbox is equal to whatever already is in the text box plus whatever
            // label that was press from the button. for ex. 1,2,4,5.     
            // So when we run our applicaation, the event handler will determine what button pressed.  
            // It will retrieve the label from the button and will append it to our text box.
        }

        private void Operator_click(object sender, EventArgs e)    // Button for  operators: (+,-,*,/)
        {
            Button b = (Button)sender;
            //when the operation button is clicked during run time, the string(+,-,*,/) gets 
            //stored in operation.
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;

        }

        private void button18_Click(object sender, EventArgs e)  //Eaual button on calculator.
        {
            equation.Text = "";
            switch (operation)     //code block for the equal(=) sign. 
            {
                case "+":         //Will return a double.  Have to use .ToString to store string into text boxes.
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;

                case "-":         //Will return a double.  Have to use .ToString to store string into text boxes.
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break; 

                case "*":         //Will return a double.  Have to use .ToString to store string into text boxes.
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;

                case "/":         //Will return a double.  Have to use .ToString to store string into text boxes.
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;      
                    
            }// end switch
            operation_pressed = false;
        }

        private void Clear_Button(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Button_ClearEntry(object sender, EventArgs e)
        {
            result.Text = "0";
            
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
