using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_m_bored
{
    public partial class Form1 : Form  
    {
        private bool commaIs = false;
        private decimal firstNum = 0;
        private decimal secondtNum = 0;
        private bool memoryMode = false;
        private bool justCalculated = false;
        private string tempMemory = "";
        Timer timer = new Timer();
        
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 10;
        }

        private bool IsCommaInStr(string str)
        {
            int length = str.Length;

            for (int i = 0; i < length; i++)
            {
                if (str[i] == '.')
                {
                    return true;
                }
            }
            return false;
        }
        private bool canAddSymbol()
        {
            if (output.Text.Length <= 9)
            {
                output.Font = new System.Drawing.Font("Bahnschrift Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                return true;
            }
            else if (output.Text.Length > 9 && output.Text.Length <= 18)
            {
                output.Font = new System.Drawing.Font("Bahnschrift Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                return true;
            }
            else
            {
                return false;
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            equally.Focus();
            output.Text = "";
            outputTop.Text = "";
            commaIs = false;
            clear.Text = "AC";
            clearHover.Text = "AC";
        }

        private void changeMark_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "TOO BIG")
            {
                output.Text = "-";
                justCalculated = false;
            }
            else if (output.Text != "")
            {
                if (output.Text[0] == '-')
                {
                    output.Text = output.Text.Remove(0, 1);
                }
                else
                {
                    if (canAddSymbol())
                    {
                        output.Text = output.Text.Insert(0, "-");
                    }
                        
                }
            }
            else
            {
                output.Text = output.Text.Insert(0, "-");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "TOO BIG")
            {
                output.Text = "";
            }
            else if (output.Text != "")
            {
                if (output.Text[output.Text.Length - 1] == '.')
                {
                    commaIs = false;
                }

                output.Text = output.Text.Remove(output.Text.Length - 1, 1);

                if (output.Text == "")
                {
                    clear.Text = "AC";
                    clearHover.Text = "AC";
                }
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (justCalculated && output.Text == "TOO BIG")
            {
                output.Text = "";
            }
            else
            {
                doOperation('/');
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "7";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "8";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "9";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "9";
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (justCalculated && output.Text == "TOO BIG")
            {
                output.Text = "";
            }
            else
            {
                doOperation('x');
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "4";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "5";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "6";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "6";
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (justCalculated && output.Text == "TOO BIG")
            {
                output.Text = "";
            }
            else
            {
                doOperation('-');
            }
        }

        private void one_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "1";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "2";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (output.Text == "0" || output.Text == "-0" || justCalculated)
            {
                output.Text = "3";
                justCalculated = false;
            }
            else if (canAddSymbol())
            {
                output.Text += "3";
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (justCalculated && output.Text=="TOO BIG")
            {
                output.Text = "";
            }
            else
            {
                doOperation('+');
            }
        }
        private void doOperation(char operation)
        {
            if (outputTop.Text == "")
            {
                if (output.Text == "" || output.Text == "-")
                {
                    firstNum = 0;
                }
                else
                {
                    firstNum = Convert.ToDecimal(output.Text);
                    tempMemory = "";
                    tempMemory += firstNum;
                    tempMemory += " ";
                    tempMemory += operation.ToString();
                    tempMemory += " ";
                }

                tempMemory = "";
                tempMemory += firstNum;
                tempMemory += " ";
                tempMemory += operation.ToString();
                tempMemory += " ";

                outputTop.Text = firstNum.ToString() + operation;
                output.Text = "";
                commaIs = false;
            }
            else
            {
                if (output.Text == "" && outputTop.Text != "")
                {
                    outputTop.Text = outputTop.Text.Remove(outputTop.Text.Length - 1, 1);
                    outputTop.Text += operation;
                }

                if (output.Text != "" && output.Text != "-")
                {
                    secondtNum = Convert.ToDecimal(output.Text);
                    tempMemory += secondtNum;
                    tempMemory += " ";
                    tempMemory += operation.ToString();
                    tempMemory += " ";
                    firstNum = Calculator.Calculate(firstNum, secondtNum, outputTop.Text[outputTop.Text.Length - 1]);
                    outputTop.Text = firstNum.ToString() + operation;
                    output.Text = "";

                    if (IsCommaInStr(output.Text))
                    {
                        commaIs = true;
                    }
                    else
                    {
                        commaIs = false;
                    }
                }
            }
        }
        private void zero_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (canAddSymbol())
            {
                if (output.Text != "")
                {
                    if (output.Text[0] == '0' && !IsCommaInStr(output.Text) || output.Text == "-0")
                    {

                    }
                    else if (justCalculated)
                    {
                        output.Text = "0";
                        justCalculated = false;
                    }
                    else
                    {
                        output.Text += "0";
                    }
                }
                else
                {
                    output.Text += "0";
                }
            }
            else if (justCalculated)
            {
                output.Text = "0";
                justCalculated = false;
            }
        }

        private void comma_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (canAddSymbol())
            {
                if (!commaIs)
                {
                    if (output.Text == "" || output.Text == "-" || justCalculated)
                    {
                        output.Text = "0.";
                        justCalculated = false;
                    }
                    else
                    {
                        output.Text += ".";
                    }
                    commaIs = true;
                }
            }
        }
        private int stringCount(string str)
        {
            int length = str.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == '\n')
                {
                    count += 40;
                }
                else
                {
                    count++;
                }
            }
            return count;
        }
        private string RemoveFirstString(string str)
        {
            int label = 0;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {
                if (str[i] == '\n')
                {
                    label = i + 2;
                    return str.Remove(0, label);
                }
            }
            return null;
        }
        private void equally_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (outputTop.Text != "" && output.Text != "")
            {
                char opMark = outputTop.Text[outputTop.Text.Length - 1];
                outputTop.Text = outputTop.Text.Remove(outputTop.Text.Length - 1, 1);
                firstNum = Convert.ToDecimal(outputTop.Text);
                secondtNum = Convert.ToDecimal(output.Text);
                tempMemory += secondtNum;
                tempMemory += " = ";
                string tempOut = Calculator.Calculate(firstNum, secondtNum, opMark).ToString();
                if (tempOut.Length > 18)
                {
                    output.Text = "TOO BIG";
                }
                else
                {
                    output.Text = tempOut;
                }
                tempMemory += tempOut;
                memoryLabel.Text += tempMemory;
                memoryLabel.Text += "\n\n";
                while (stringCount(memoryLabel.Text) > 1100)
                {
                    memoryLabel.Text = RemoveFirstString(memoryLabel.Text);
                }
                tempMemory = "";
                outputTop.Text = "";
                justCalculated = true;

            }
        }

        private void output_TextChanged(object sender, EventArgs e)
        {
            clear.Text = "C";
            clearHover.Text = "C";
        }

        private void clear_MouseEnter(object sender, EventArgs e)
        {
            clearHover.Visible = true;
        }

        private void changeMark_MouseEnter(object sender, EventArgs e)
        {
            changeMarkHover.Visible = true;
        }

        private void delete_MouseEnter(object sender, EventArgs e)
        {
            deleteHover.Visible = true;
        }

        private void divide_MouseEnter(object sender, EventArgs e)
        {
            divideHover.Visible = true;
        }

        private void seven_MouseEnter(object sender, EventArgs e)
        {
            sevenHover.Visible = true;
        }

        private void eight_MouseEnter(object sender, EventArgs e)
        {
            eightHover.Visible = true;
        }

        private void nine_MouseEnter(object sender, EventArgs e)
        {
            nineHover.Visible = true;
        }

        private void multiply_MouseEnter(object sender, EventArgs e)
        {
            multiplyHover.Visible = true;
        }

        private void four_MouseEnter(object sender, EventArgs e)
        {
            fourHover.Visible = true;
        }

        private void five_MouseEnter(object sender, EventArgs e)
        {
            fiveHover.Visible = true;
        }

        private void six_MouseEnter(object sender, EventArgs e)
        {
            sixHover.Visible = true;
        }

        private void minus_MouseEnter(object sender, EventArgs e)
        {
            minusHover.Visible = true;
        }

        private void one_MouseEnter(object sender, EventArgs e)
        {
            oneHover.Visible = true;
        }

        private void two_MouseEnter(object sender, EventArgs e)
        {
            twoHover.Visible = true;
        }

        private void three_MouseEnter(object sender, EventArgs e)
        {
            threeHover.Visible = true;
        }

        private void plus_MouseEnter(object sender, EventArgs e)
        {
            plusHover.Visible = true;
        }

        private void zero_MouseEnter(object sender, EventArgs e)
        {
            zeroHover.Visible = true;
        }

        private void comma_MouseEnter(object sender, EventArgs e)
        {
            commaHover.Visible = true;
        }

        private void equally_MouseEnter(object sender, EventArgs e)
        {
            equallyHover.Visible = true;
        }

        private void clear_MouseLeave(object sender, EventArgs e)
        {
            clearHover.Visible = false;
        }

        private void changeMark_MouseLeave(object sender, EventArgs e)
        {
            changeMarkHover.Visible = false;
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            deleteHover.Visible = false;
        }

        private void divide_MouseLeave(object sender, EventArgs e)
        {
            divideHover.Visible = false;
        }

        private void seven_MouseLeave(object sender, EventArgs e)
        {
            sevenHover.Visible = false;
        }

        private void eight_MouseLeave(object sender, EventArgs e)
        {
            eightHover.Visible = false;
        }

        private void nine_MouseLeave(object sender, EventArgs e)
        {
            nineHover.Visible = false;
        }

        private void multiply_MouseLeave(object sender, EventArgs e)
        {
            multiplyHover.Visible = false;
        }

        private void four_MouseLeave(object sender, EventArgs e)
        {
            fourHover.Visible = false;
        }

        private void five_MouseLeave(object sender, EventArgs e)
        {
            fiveHover.Visible = false;
        }

        private void six_MouseLeave(object sender, EventArgs e)
        {
            sixHover.Visible = false;
        }

        private void minus_MouseLeave(object sender, EventArgs e)
        {
            minusHover.Visible = false;
        }

        private void one_MouseLeave(object sender, EventArgs e)
        {
            oneHover.Visible = false;
        }

        private void two_MouseLeave(object sender, EventArgs e)
        {
            twoHover.Visible = false;
        }

        private void three_MouseLeave(object sender, EventArgs e)
        {
            threeHover.Visible = false;
        }

        private void plus_MouseLeave(object sender, EventArgs e)
        {
            plusHover.Visible = false;
        }

        private void zero_MouseLeave(object sender, EventArgs e)
        {
            zeroHover.Visible = false;
        }

        private void comma_MouseLeave(object sender, EventArgs e)
        {
            commaHover.Visible = false;
        }

        private void equally_MouseLeave(object sender, EventArgs e)
        {
            equallyHover.Visible = false;
        }

        private void memoryMod_Click(object sender, EventArgs e)
        {
            equally.Focus();
            if (memoryMode)
            {
                memoryLabel.Visible = false;
                memoryMod.Enabled = false;
                clearHistory.Visible = false;
                timer.Tick += ShrinkWindow;
                memoryMode = !memoryMode;
            }
            else
            {

                memoryLabel.Visible = false;
                memoryMod.Enabled = false;
                clearHistory.Visible = false;
                timer.Tick += ExpandWindow;
                memoryMode = !memoryMode;
            }
            timer.Start();
        }

        private void ShrinkWindow(object sender, EventArgs e)
        {
            if (this.Width != 352)
            {
                this.Width = this.Width - 44;
            }
            else
            {
                timer.Tick -= ShrinkWindow;
                timer.Stop();
                memoryMod.Enabled = true;
            }
        }

        private void ExpandWindow(object sender, EventArgs e)
        {
            if (this.Width != 704)
            {
                this.Width = this.Width + 44;
            }
            else
            {
                timer.Tick -= ExpandWindow;
                timer.Stop();
                memoryMod.Enabled = true;
                memoryLabel.Visible = true;
                clearHistory.Visible = true;
            }
        }

        private void memoryMod_MouseEnter(object sender, EventArgs e)
        {
            memoryModHover.Visible = true;
        }

        private void memoryMod_MouseLeave(object sender, EventArgs e)
        {
            memoryModHover.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;

            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    zero_Click(new object(), new EventArgs());
                    zeroHover.Visible = true;
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    one_Click(new object(), new EventArgs());
                    oneHover.Visible = true;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    two_Click(new object(), new EventArgs());
                    twoHover.Visible = true;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    three_Click(new object(), new EventArgs());
                    threeHover.Visible = true;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    four_Click(new object(), new EventArgs());
                    fourHover.Visible = true;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    five_Click(new object(), new EventArgs());
                    fiveHover.Visible = true;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    six_Click(new object(), new EventArgs());
                    sixHover.Visible = true;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    seven_Click(new object(), new EventArgs());
                    sevenHover.Visible = true;
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    eight_Click(new object(), new EventArgs());
                    eightHover.Visible = true;
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    nine_Click(new object(), new EventArgs());
                    nineHover.Visible = true;
                    break;
                case Keys.Divide:
                    divide_Click(new object(), new EventArgs());
                    divideHover.Visible = true;
                    break;
                case Keys.Multiply:
                    multiply_Click(new object(), new EventArgs());
                    multiplyHover.Visible = true;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    minus_Click(new object(), new EventArgs());
                    minusHover.Visible = true;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    plus_Click(new object(), new EventArgs());
                    plusHover.Visible = true;
                    break;
                case Keys.Delete:
                    clear_Click(new object(), new EventArgs());
                    clearHover.Visible = true;
                    break;
                case Keys.Back:
                    delete_Click(new object(), new EventArgs());
                    deleteHover.Visible = true;
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    comma_Click(new object(), new EventArgs());
                    commaHover.Visible = true;
                    break;
                case Keys.H:
                    memoryModHover.Visible = true;
                    break;
                case Keys.C:
                    clearHistory.ForeColor = Color.FromArgb(255, 20, 20, 20);
                    clearHistory.BackColor = Color.FromArgb(255, 75, 75, 75);
                    break;
                case Keys.Enter:
                    equally_Click(new object(), new EventArgs());
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            
            switch (e.KeyCode)
            {
                case Keys.D0:
                case Keys.NumPad0:
                    zeroHover.Visible = false;
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    oneHover.Visible = false;
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    twoHover.Visible = false;
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    threeHover.Visible = false;
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    fourHover.Visible = false;
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    fiveHover.Visible = false;
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    sixHover.Visible = false;
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    sevenHover.Visible = false;
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    eightHover.Visible = false;
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    nineHover.Visible = false;
                    break;
                case Keys.Divide:
                    divideHover.Visible = false;
                    break;
                case Keys.Multiply:
                    multiplyHover.Visible = false;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    minusHover.Visible = false;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    plusHover.Visible = false;
                    break;
                case Keys.Delete:
                    clearHover.Visible = false;
                    break;
                case Keys.Back:
                    deleteHover.Visible = false;
                    break;
                case Keys.OemPeriod:
                case Keys.Oemcomma:
                case Keys.Decimal:
                    commaHover.Visible = false;
                    break;
                case Keys.H:
                    if (memoryMod.Enabled)
                    {
                        memoryMod_Click(new object(), new EventArgs());
                    }
                    memoryModHover.Visible = false;
                    break;
                case Keys.C:
                    clearHistory_Click(new object(), new EventArgs());
                    clearHistory.ForeColor = Color.LightGray;
                    clearHistory.BackColor = Color.FromArgb(255, 50, 50, 50);
                    break;
                case Keys.Up:
                    equally.Focus();
                    break;
                case Keys.Down:
                    equally.Focus();
                    break;
                case Keys.Left:
                    equally.Focus();
                    break;
                case Keys.Right:
                    equally.Focus();
                    break;
            }
        }

        private void clearHistory_MouseEnter(object sender, EventArgs e)
        {
            clearHistory.ForeColor = Color.FromArgb(255, 20, 20, 20);
        }

        private void clearHistory_MouseLeave(object sender, EventArgs e)
        {
            clearHistory.ForeColor = Color.LightGray;
        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            memoryLabel.Text = "";
        }
    }
}
