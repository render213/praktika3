using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktika3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }
 
    void Function(double x, double funtionX)
    {
      double function;
      if (x > 5) function = funtionX;
      else if ((x > 2) && (x <= 5)) function = funtionX * 0.5;
      else function = -1;
      textBox2.Text = "Результат работы программы Серебрякова С А" + Environment.NewLine;
      textBox2.Text += "При x=" + Convert.ToDouble(x) + Environment.NewLine;
      textBox2.Text += "Y=" + Convert.ToDouble(function) + Environment.NewLine;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      if (textBox1.Text == "")
      {
        textBox2.Text = "Значение не введено" + Environment.NewLine;
      }
      else
      {
        double x = Convert.ToDouble(textBox1.Text);
        int check = 0;
        if (radioButton2.Checked) check = 1;
        else if (radioButton3.Checked) check = 2;
        textBox2.Text = "Результат работы программы Серебрякова С А" + Environment.NewLine;
        textBox2.Text += "При x=" + Convert.ToDouble(x) + Environment.NewLine;

        switch (check)
        {
          case 0:
            Function(x, Math.Sinh(x));       
            break;
          case 1:
            Function(x, Math.Cosh(x));
            break;
          case 2:
            Function(x, Math.Exp(x));          
            break;
          default:
            textBox2.Text += "решение не найдено" + Environment.NewLine;
            break;
        }
      }

    }
  }
}
