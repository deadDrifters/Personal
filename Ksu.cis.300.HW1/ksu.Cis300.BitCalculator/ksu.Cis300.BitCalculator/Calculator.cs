using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ksu.Cis300.BitCalculator
{
    public partial class UxCalculator : Form
    {

        private Stack _wholeExpression = new Stack();
        private bool _inputMode = true;
        public UxCalculator()
        {
            InitializeComponent();
        }

        //good
        private void Ux0_Click_1(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string input = btn.Text;
            if (!_inputMode)
            {
                TextBox.Text = input;
                _inputMode = true;
            }
            else if (_inputMode) {
                if (TextBox.Text.Length >= 8)
                {
                    return;
                }
                else if (TextBox.Text == "0")
                {
                    TextBox.Text = input;
                }
                else
                {
                    TextBox.Text += input;
                }
             }   
        }
        
        //good
        private int Precendence(string _inString)
        {
            int _precedenceLvl = 0;
            switch (_inString)
            {
                case "NOT":
                    _precedenceLvl = 5;
                    break;
                case "AND":
                    _precedenceLvl = 4;
                    break;
                case "XOR":
                    _precedenceLvl = 3;
                    break;
                case "OR":
                    _precedenceLvl = 2;
                    break;
                case ")":
                    _precedenceLvl = 2;
                    break;
                case "(":
                    _precedenceLvl = 1;
                    break;
                default:
                    _precedenceLvl = 1000;
                    break;
            }
            return _precedenceLvl;
        }

        //good
        private uint BinaryOp(string _inString, uint _operandOne, uint _operandTwo)
        {
            uint _result = 0;
            switch (_inString)
            {
                case "AND":
                    _result = _operandOne & _operandTwo;
                    break;
                case "XOR":
                    _result = _operandOne ^ _operandTwo;
                    break;
                case "OR":
                    _result = _operandOne | _operandTwo;
                    break;                
            }
            return _result;
        }

        private uint Simplifier(int minPrecendence, uint operand)
        {
            uint simpleExp = operand;
            if (_wholeExpression.Count == 0)
            {
                return simpleExp;
            }
            else while (_wholeExpression.Count > 0 && Precendence(_wholeExpression.Peek().ToString()) >= minPrecendence)
            {
                simpleExp = BinaryOp(_wholeExpression.Pop().ToString(), Convert.ToUInt32(_wholeExpression.Pop()), simpleExp);
            }
            return simpleExp;
        }

        private uint ClosePar(uint newValue)
        {
            uint simpleExp = newValue;
                do
                {
                    simpleExp = BinaryOp(_wholeExpression.Pop().ToString(), Convert.ToUInt32(_wholeExpression.Pop()), simpleExp);
                    //need error code
                } while (_wholeExpression.Peek().ToString() != "(");
            if (_wholeExpression.Peek().ToString() == "(")
            {
                _wholeExpression.Pop();
            }
            return simpleExp;
        }

        //good
        private void UxNOT_Click(object sender, EventArgs e)
        {
            uint expression = Convert.ToUInt32(TextBox.Text, 16);
            expression = expression ^ 0xFFFFFFFF;
            TextBox.Text = expression.ToString("X");
            _inputMode = false;
        }

        private void UxAND_Click(object sender, EventArgs e)
        {
            
            //_wholeExpression.Push(TextBox.Text);
            int _precedence = Precendence((sender as Button).Text);
            uint evaluated = Simplifier(_precedence, Convert.ToUInt32(TextBox.Text));
            TextBox.Text = evaluated.ToString();
            _wholeExpression.Push(evaluated);
            _inputMode = false;
        }

        private void UxClosePar_Click(object sender, EventArgs e)
        {
            uint paranthesis = ClosePar(Convert.ToUInt32((sender as Button).Text));
            TextBox.Text = paranthesis.ToString();
            _inputMode = false;
        }

        //good
        private void UxClear_Click(object sender, EventArgs e)
        {
            if (_inputMode)
            {
                TextBox.Text = "0";
                _inputMode = false;
            }
            else if (!_inputMode)
            {
                TextBox.Text = "0";
                while (_wholeExpression.Count > 0)
                {
                    _wholeExpression.Pop();
                }
                _inputMode = true;
            }
        }


    }
}
