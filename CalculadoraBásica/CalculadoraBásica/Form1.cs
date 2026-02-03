using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBásica
{
    public partial class Form1 : Form
    {
        public decimal LastValue { get; set; }
        public string Operator { get; set; }
        public bool IsLastResult { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (IsLastResult)
            {
                txtResultado.Clear();
                IsLastResult = false;
            }

            txtResultado.Text += ((Button)sender).Text;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var current_operator = (Button)sender;

            this.Operator = current_operator.Text;

            this.LastValue = decimal.Parse(txtResultado.Text);
            txtResultado.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (IsLastResult)
                return;

            if (string.IsNullOrEmpty(Operator) || string.IsNullOrEmpty(txtResultado.Text))
                return;

            decimal currentValue = decimal.Parse(txtResultado.Text);

            switch (this.Operator)
            {
                case "+":
                    txtResultado.Text = (this.LastValue + currentValue).ToString();
                    break;
                case "-":
                    txtResultado.Text = (this.LastValue - currentValue).ToString();
                    break;
                case "*":
                    txtResultado.Text = (this.LastValue * currentValue).ToString();
                    break;
                case "/":
                    txtResultado.Text = (this.LastValue / currentValue).ToString();
                    break;
            }

            IsLastResult = true;
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            decimal currentValue = decimal.Parse(txtResultado.Text) * -1;
            txtResultado.Text = currentValue.ToString();
        }
    }
}
