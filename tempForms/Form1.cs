using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace tempForms
{
    public partial class Form1 : Form
    {
        Calculator _calculator = new Calculator();

        bool _tochange = false;

        bool _isNew = false;

        string _operetion = string.Empty;

        public Form1()
        {
            InitializeComponent();

            panel1.Height = 0;

            buttonMR.Enabled = false;

            buttonMC.Enabled = false;

            buttonM.Enabled = false;
        }

        private void CloseMemory()
        {
            panel1.Height = 0;
            
            txtDesplay.Enabled = true;
            
            txtDesplay.Visible = true;
            
            lblOperetion.Enabled = true;
        }

        private void numbersOnly(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (_isNew)
            {
                buttonClear.PerformClick();
                lblOperetion.Text = string.Empty;

                _tochange = false;
                _isNew = false;
            }
            else if (_tochange)
            {
                buttonClear.PerformClick();

                _tochange = false;
            }

            txtDesplay.Text += button.Text;

            CorrectNumber();
        }

        //удаляем лишний ноль впереди числа, если таковой имеется
        private void CorrectNumber()
        {
            //если есть знак "бесконечность" - не даёт писать цифры после него
            if (txtDesplay.Text.IndexOf("∞") != -1)
                txtDesplay.Text = txtDesplay.Text.Substring(0, txtDesplay.Text.Length - 1);

            //ситуация: слева ноль, а после него НЕ запятая, тогда ноль можно удалить
            if (txtDesplay.Text[0] == '0' && (txtDesplay.Text.IndexOf(",") != 1))
                txtDesplay.Text = txtDesplay.Text.Remove(0, 1);

            //аналогично предыдущему, только для отрицательного числа
            if (txtDesplay.Text[0] == '-')
                if (txtDesplay.Text[1] == '0' && (txtDesplay.Text.IndexOf(",") != 2))
                    txtDesplay.Text = txtDesplay.Text.Remove(1, 1);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtDesplay.Text = "0";

            if (_calculator.IsFirst)
            {
                _calculator.ClearFirst();
            }
            else
            {
                _calculator.ClearSecond();
            }

            _tochange = false;
        }

        private void buttonС_Click(object sender, EventArgs e)
        {
            txtDesplay.Text = "0";

            _calculator.ClearFirst();

            _calculator.ClearSecond();

            _calculator.IsFirst = true;

            lblOperetion.Text = string.Empty;

            _operetion = string.Empty;

            _tochange = false;

            _isNew = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!txtDesplay.Text.Contains('E'))
            {
                txtDesplay.Text = txtDesplay.Text.Length == 1 ? "0" :
                    txtDesplay.Text.Remove(txtDesplay.Text.Length - 1);
            }
        }

        private void BinaryOperathionLogic(string operetion)
        {
            if (_calculator.IsFirst)
            {
                if (!_calculator.ThereIsFirst)
                {
                    _calculator.First = double.Parse(txtDesplay.Text);
                }

                _calculator.IsFirst = false;

                _tochange = true;

                _operetion = operetion;

                lblOperetion.Text = $"{_calculator.FirstNum} {_operetion}";
            }
            else if (_operetion != operetion)
            {
                _operetion = operetion;

                lblOperetion.Text = $"{_calculator.FirstNum} {_operetion}";
            }
            else
            {
                _calculator.ClearSecond();

                _tochange = true;

                _isNew = false;
            }
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            if (!_calculator.ThereIsFirst)
            {
                _calculator.First = Double.Parse(txtDesplay.Text);

                lblOperetion.Text = _calculator.FirstNum + " = ";
            }
            else
            {
                lblOperetion.Text = $"{_calculator.FirstNum} {_operetion}";
            }

            _tochange = true;

            _isNew = true;

            Calculete();
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            BinaryOperathionLogic("÷");
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            BinaryOperathionLogic("×");
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            BinaryOperathionLogic("-");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            BinaryOperathionLogic("+");
        }

        private void Calculete()
        {
            if (!_calculator.ThereIsSecond)
            {
                _calculator.Second = double.Parse(txtDesplay.Text);
            }
            try
            {

                switch (_operetion)
                {
                    case "+":
                        txtDesplay.Text = _calculator.Sum().ToString();
                        break;
                    case "-":
                        txtDesplay.Text = _calculator.Subtraction().ToString();
                        break;
                    case "×":
                        txtDesplay.Text = _calculator.Multiplication().ToString();
                        break;
                    case "÷":
                        txtDesplay.Text = _calculator.Division().ToString();
                        break;
                    default:
                        break;
                }

                lblOperetion.Text = _calculator.Result;

                _calculator.IsFirst = true;

            }
            catch (Exception ex)
            {
                lblOperetion.Text = ex.Message;

                _isNew = true;
            }

        }

        private void UnaryOperationLogic()
        {
            if (_calculator.IsFirst)
            {
                if (!_calculator.ThereIsFirst)
                    _calculator.First = Double.Parse(txtDesplay.Text);
            }
            else
            {
                if (!_calculator.ThereIsSecond)
                    _calculator.Second = Double.Parse(txtDesplay.Text);
            }

            _tochange = true;
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            UnaryOperationLogic();

            txtDesplay.Text = _calculator.Square().ToString();

            lblOperetion.Text = _calculator.IsFirst ? _calculator.FirstNum : _calculator.SecondNum;
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            UnaryOperationLogic();

            try
            {
                txtDesplay.Text = _calculator.Factorial().ToString();

                lblOperetion.Text = _calculator.IsFirst ? _calculator.FirstNum : _calculator.SecondNum;
            }
            catch (Exception ex)
            {
                lblOperetion.Text = ex.Message;

                _isNew = true;
            }
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            UnaryOperationLogic();

            try
            {
                txtDesplay.Text = _calculator.Sqrt().ToString();

                lblOperetion.Text = _calculator.IsFirst ? _calculator.FirstNum : _calculator.SecondNum;
            }
            catch (Exception ex)
            {
                lblOperetion.Text = ex.Message;

                _isNew = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            UnaryOperationLogic();

            try
            {
                txtDesplay.Text = _calculator.ReversNumber().ToString();

                lblOperetion.Text = _calculator.IsFirst ? _calculator.FirstNum : _calculator.SecondNum;
            }
            catch (Exception ex)
            {
                lblOperetion.Text = ex.Message;

                _isNew = true;
            }
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            UnaryOperationLogic();

            txtDesplay.Text = _calculator.Negate().ToString();

            lblOperetion.Text = _calculator.IsFirst ? _calculator.FirstNum : _calculator.SecondNum;
        }


        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.Height = 0;
            button1.Enabled = true;
            button2.Enabled = true;
            txtDesplay.Enabled = true;
            txtDesplay.Visible = true;
            lblOperetion.Enabled = true;
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 110; i++)
            {
                panel1.Height += 3;
            }

            button1.Enabled = false;

            button2.Enabled = false;

            txtDesplay.Enabled = false;

            lblOperetion.Enabled = false;
        }

        private void setUserControl1(UserControl1 userControl1) 
        {
            userControl1.buttonMMinus.Click += (sender, e) =>
            {
                userControl1.label_1.Text = (decimal.Parse(userControl1.label_1.Text) - decimal.Parse(txtDesplay.Text)).ToString();
            };

            userControl1.buttonMPlus.Click += (sender, e) =>
            {
                userControl1.label_1.Text = (decimal.Parse(userControl1.label_1.Text) + decimal.Parse(txtDesplay.Text)).ToString();
            };

            userControl1.buttonMC.Click += (sender, e) =>
            {
                flowLayoutPanel1.Controls.Remove(userControl1);

                if (flowLayoutPanel1.Controls.Count == 0)
                {
                    buttonMR.Enabled = false;

                    buttonMC.Enabled = false;

                    buttonM.Enabled = false;

                    CloseMemory();
                }
            };

            userControl1.Click += (sender, e) =>
            {
                txtDesplay.Text = userControl1.label_1.Text;

                _tochange = true;
                panel1.Height = 0;
                txtDesplay.Enabled = true;
                txtDesplay.Visible = true;
                lblOperetion.Enabled = true;
                lblOperetion.Text = string.Empty;
                _calculator.ClearFirst();
            };

            userControl1.label_1.Click += (sender, e) =>
            {
                txtDesplay.Text = userControl1.label_1.Text;

                _tochange = true;
                panel1.Height = 0;
                txtDesplay.Enabled = true;
                txtDesplay.Visible = true;
                lblOperetion.Enabled = true;
                lblOperetion.Text = string.Empty;
                _calculator.ClearFirst();
            };
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            var temp = new UserControl1();

            temp.label_1.Text = txtDesplay.Text;

            setUserControl1(temp);

            flowLayoutPanel1.SuspendLayout();

            flowLayoutPanel1.Controls.Add(temp);

            flowLayoutPanel1.Controls.SetChildIndex(temp, 0);

            flowLayoutPanel1.ResumeLayout();

            buttonMR.Enabled = true;

            buttonMC.Enabled = true;

            buttonM.Enabled = true;

            _tochange = true;
        }

        private void buttonMPlus_Click(object sender, EventArgs e)
        {
            var temp = flowLayoutPanel1.Controls.OfType<UserControl1>().FirstOrDefault();

            if (temp != null)
            {
                temp.label_1.Text = (double.Parse(temp.label_1.Text) + double.Parse(txtDesplay.Text)).ToString();
            }
            else
            {
                temp = new UserControl1();

                temp.label_1.Text = txtDesplay.Text;

                setUserControl1(temp);

                flowLayoutPanel1.Controls.Add(temp);

                buttonMR.Enabled = true;

                buttonMC.Enabled = true;

                buttonM.Enabled = true;
            }

            _tochange = true;
        }

        private void buttonMMinus_Click(object sender, EventArgs e)
        {
            var temp = flowLayoutPanel1.Controls.OfType<UserControl1>().FirstOrDefault();

            if (temp != null)
            {
                temp.label_1.Text = (double.Parse(temp.label_1.Text) - double.Parse(txtDesplay.Text)).ToString();
            }
            else
            {
                temp = new UserControl1();

                temp.label_1.Text = '-' + txtDesplay.Text;

                setUserControl1(temp);

                flowLayoutPanel1.Controls.Add(temp);

                buttonMR.Enabled = true;

                buttonMC.Enabled = true;

                buttonM.Enabled = true;
            }

            _tochange = true;
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            buttonMR.Enabled = false;

            buttonMC.Enabled = false;

            buttonM.Enabled = false;
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            txtDesplay.Text = flowLayoutPanel1.Controls.OfType<UserControl1>().FirstOrDefault().label_1.Text;

            _tochange = true;

            lblOperetion.Text = string.Empty;

            _calculator.ClearFirst();
        }
    }
}