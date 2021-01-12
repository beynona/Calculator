using System;
using System.Windows.Forms;
namespace Caltulators
{
    public partial class Caltulator : Form
    {
        //Initialize
        public Caltulator()
        {
            InitializeComponent();   
        }
        //Numbers and result variables
        double N1, N2, result;
        bool lastOperation = false;
        int lastOperationIndex;
        bool calculated = false;   
        string N2comma;
        string N2Number;
        private OperationEnum resultEnum = OperationEnum.none;
        //Prop
        public string ResultText
        {
            get { return textBox.Text; }
            set { textBox.Text += value; }
        }
        //Number input
        private void NumberClicked(object sender, EventArgs e)
        {
            N2Number = ResultText.Remove(0, ResultText.Length - 1);

            if (!calculated && N2Number != "!" && N2Number != "√" && N2Number != "|")
            {
                Button button = (Button)sender;
                switch (button.Name)
                {
                    case "Button0":
                        ResultText = "0";
                        break;
                    case "Button1":
                        if (ResultText == "0")
                        {
                            textBox.Text = "1";
                        }
                        else
                        {
                            ResultText = "1";
                        }
                        break;
                    case "Button2":
                        if (ResultText == "0")
                        {
                            textBox.Text = "2";
                        }
                        else
                        {
                            ResultText = "2";
                        }
                        break;
                    case "Button3":
                        if (ResultText == "0")
                        {
                            textBox.Text = "3";
                        }
                        else
                        {
                            ResultText = "3";
                        }
                        break;
                    case "Button4":
                        if (ResultText == "0")
                        {
                            textBox.Text = "4";
                        }
                        else
                        {
                            ResultText = "4";
                        }
                        break;
                    case "Button5":
                        if (ResultText == "0")
                        {
                            textBox.Text = "5";
                        }
                        else
                        {
                            ResultText = "5";
                        }
                        break;
                    case "Button6":
                        if (ResultText == "0")
                        {
                            textBox.Text = "6";
                        }
                        else
                        {
                            ResultText = "6";
                        }
                        break;
                    case "Button7":
                        if (ResultText == "0")
                        {
                            textBox.Text = "7";
                        }
                        else
                        {
                            ResultText = "7";
                        }
                        break;
                    case "Button8":
                        if (ResultText == "0")
                        {
                            textBox.Text = "8";
                        }
                        else
                        {
                            ResultText = "8";
                        }
                        break;
                    case "Button9":
                        if (ResultText == "0")
                        {
                            textBox.Text = "9";
                        }
                        else
                        {
                            ResultText = "9";
                        }
                        break;
                }
            }
            
        }
        //Clear and CE text
        private void ClearText(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Name)
            {
                case "C":
                    textBox.Text = "0";
                    N1 = 0;
                    N2 = 0;
                    result = 0;
                    lastOperation = false;
                    calculated = false;
                    equally.Enabled = true;
                    CE.Enabled = true;
                    dots.Enabled = true;
                    break;
                case "CE":
                    if (ResultText.Length > 0)
                    {
                        textBox.Text = ResultText.Remove(ResultText.Length - 1);
                    }
                    if (ResultText.Length < 1)
                    {
                        textBox.Text = "0";
                        N1 = 0;
                        N2 = 0;
                        result = 0;
                        lastOperation = false;
                    }
                    if (!ResultText.Contains("/") && !ResultText.Contains("*") && !ResultText.Contains("+") && !ResultText.Contains("-") && !ResultText.Contains("%") && !ResultText.Contains("^") && !ResultText.Contains("!") && !ResultText.Contains("√") && !ResultText.Contains("||") && !ResultText.Contains("n√"))
                    {
                        lastOperation = false;
                    }
                    break;
            }
        }
        //Сomma (разделитель дробного числа - запятая)
        private void Comma(object sender, EventArgs e)
        {
            if(!calculated)
            {
                if (!ResultText.Contains(","))
                {
                    ResultText = ",0";
                }
            }
            N2comma = ResultText.Remove(0, ResultText.Length-1);
            if (lastOperation && N2comma !=",")
            {
                ResultText = ",0";
            }
            
        }
        //OperationsEvents
        private void OperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!lastOperation && !calculated)
            {
                switch (button.Name)
                {
                    case "division":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.division;
                        lastOperation = true;
                        break;
                    case "multiplication":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.multiplication;
                        lastOperation = true;
                        break;
                    case "ABS":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        N2 = 0;
                        resultEnum = OperationEnum.ABS;
                        lastOperation = true;
                        break;
                    case "addition":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.addition;
                        lastOperation = true;
                        break;
                    case "Nsqrt":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.Nsqrt;
                        lastOperation = true;
                        break;
                    case "sqrt":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.sqrt;
                        lastOperation = true;
                        N2 = 0;
                        break;
                    case "subtraction":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.subtraction;
                        lastOperation = true;
                        break;
                    case "factorial":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        N2 = 0;
                        resultEnum = OperationEnum.factorial;
                        lastOperation = true;
                        break;
                    case "power":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.power;
                        lastOperation = true;
                        break;
                    case "percent":
                        // label1.Text = ResultText;
                        N1 = Convert.ToDouble(ResultText);
                        resultEnum = OperationEnum.percent;
                        lastOperation = true;
                        break;
                }
                OperationsSybol(resultEnum);
                lastOperationIndex = ResultText.Length;
               
            }
        }
        //Equal
        private void Equal(object sender, EventArgs e)
        {
            if (calculated == false && lastOperationIndex < ResultText.Length)
            {
                N2 = Convert.ToDouble(ResultText.Remove(0, lastOperationIndex));
                result = Operations(N1, N2, resultEnum);
                ResultText = $"={result}";
                calculated = true;
                equally.Enabled = false;
                dots.Enabled = false;
                CE.Enabled = false;
            }
            if (resultEnum == OperationEnum.factorial || resultEnum == OperationEnum.sqrt || resultEnum == OperationEnum.ABS)
            {
                result = Operations(N1, N2, resultEnum);
                ResultText = $"={result}";
                calculated = true;
                equally.Enabled = false;
                dots.Enabled = false;
                CE.Enabled = false;
            }

        }
        //Operations
        public double Operations(double a, double b, OperationEnum op)
        {
            switch (op)
            {
                case OperationEnum.division:
                    return a / b;
                case OperationEnum.multiplication:
                    return a * b;
                case OperationEnum.addition:
                    return a + b;
                case OperationEnum.subtraction:
                    return a - b;
                case OperationEnum.percent:
                    return a * b / 100;
                case OperationEnum.power:
                    return Math.Pow(a, b);
                case OperationEnum.factorial:
                    return Fact(a);
                case OperationEnum.ABS:
                    return Math.Abs(a);
                case OperationEnum.sqrt:
                    return Math.Sqrt(a);
                case OperationEnum.Nsqrt:
                    return Math.Pow(a, 1 / b);
                case OperationEnum.none:
                    break;
            }
            return 0;
        }


        //OperationsSybol
        public void OperationsSybol(OperationEnum op)
        {

            switch (op)
            {
                case OperationEnum.division:
                    ResultText = "/";
                    break;
                case OperationEnum.multiplication:
                    ResultText = "*";
                    break;
                case OperationEnum.addition:
                    ResultText = "+";
                    break;
                case OperationEnum.subtraction:
                    ResultText = "-";
                    break;
                case OperationEnum.percent:
                    ResultText = "%";
                    break;
                case OperationEnum.power:
                    ResultText = "^";
                    break;
                case OperationEnum.factorial:
                    ResultText = "!";
                    break;
                case OperationEnum.ABS:
                    ResultText = "||";
                    break;
                case OperationEnum.sqrt:
                    ResultText = "√";
                    break;
                case OperationEnum.Nsqrt:
                    ResultText = "√n";
                    break;
                case OperationEnum.none:
                    break;
            }
        }
        //Factorial
        static double Fact(double a)
        {
            if (a == 0)
            {
                return 1;
            }
            else
            {
                return a * Fact(a - 1);
            }
        }
    }
}
