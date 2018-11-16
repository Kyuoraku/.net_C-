using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class fPrimero : Form
    {

        private decimal _Operand;
        private string _OperandTxt;

        public fPrimero()
        {
            InitializeComponent();
        }

        private void setOp(String num)
        {
            _OperandTxt += num;
            this.Res.Text = this._OperandTxt;
        }
        


        private void btn0_Click(object sender, EventArgs e)
        {
            if(_OperandTxt != null)
            {
                this.setOp("0");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.setOp("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.setOp("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.setOp("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.setOp("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.setOp("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.setOp("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.setOp("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.setOp("9");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.setOp(" + ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.setOp(" - ");
        }

        private void muestra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void fPrimero_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (Char.IsDigit(key))
            {
                this.setOp(e.KeyChar.ToString());
            }
        }

        private void fPrimero_Load(object sender, EventArgs e)
        {

        }
    }
}
