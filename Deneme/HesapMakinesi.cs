using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class HesapMakinesi : Form
    {
        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        public HesapMakinesi()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operation_pressed))
                result.Clear();
            
            operation_pressed = false;
            Button b = (Button)sender;
            if (b.Text==".")
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
            result.Text = result.Text + b.Text;
            label2.Focus();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            label2.Focus();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (value != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = b.Text;
                equation.Text = value + " " + operation;
            }
            else 
            { 
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            }
            label2.Focus();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;

            }
            value = Double.Parse(result.Text);
            operation = "";
            label2.Focus();

        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text="";
            value = 0;
            equation.Text = "";
            label2.Focus();
        }

        private void HesapMakinesi_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    zero.PerformClick();
                    break;
                case "1":
                    one.PerformClick();
                    break;
                case "2":
                    two.PerformClick();
                    break;
                case "3":
                    three.PerformClick();
                    break;
                case "4":
                    four.PerformClick();
                    break;
                case "5":
                    five.PerformClick();
                    break;
                case "6":
                    six.PerformClick();
                    break;
                case "7":
                    seven.PerformClick();
                    break;
                case "8":
                    eight.PerformClick();
                    break;
                case "9":
                    nine.PerformClick();
                    break;
                case "+":
                    add.PerformClick();
                    break;
                case "-":
                    sub.PerformClick();
                    break;
                case "/":
                    div.PerformClick();
                    break;
                case "*":
                    times.PerformClick();
                    break;
                case "=":
                    equal.PerformClick();
                    break;
                case " ":
                    equal.PerformClick();
                    break;
                case "\r":
                    equal.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
