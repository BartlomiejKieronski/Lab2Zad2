using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 5);
                if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Bold);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Bold);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Bold);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Bold);

                    }
                    else textBox1.Text = "błąd danych";
                }
                else if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Italic);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Italic);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Italic);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox3.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Underline);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Underline);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Underline);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, FontStyle.Underline);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Italic | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Italic | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 5, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);


                    }
                    else
                    {
                        textBox1.Text = "błąd danych";
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
                if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Bold);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Bold);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Bold);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Bold);

                    }
                    else textBox1.Text = "błąd danych";
                }
                else if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Italic);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Italic);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Italic);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox3.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Underline);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Underline);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Underline);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Underline);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Italic | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Italic | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);


                    }
                    else textBox1.Text = "błąd danych";

                }
            }
            else if (radioButton3.Checked)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                if (checkBox1.Checked && checkBox3.Checked == false && checkBox2.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Bold);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Bold);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Bold);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Bold);

                    }
                    else textBox1.Text = "błąd danych";
                }
                else if (checkBox2.Checked == true && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Italic);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Italic);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, FontStyle.Italic);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox2.Checked == false && checkBox1.Checked == false && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox3.Checked == true && checkBox2.Checked == false && checkBox1.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Underline);
                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Underline);
                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Underline);
                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, FontStyle.Underline);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Italic);

                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 9, style: FontStyle.Bold | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Italic | FontStyle.Underline);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Italic | FontStyle.Underline);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Italic | FontStyle.Underline);


                    }
                    else textBox1.Text = "błąd danych";

                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
                {
                    textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    if (radioButton4.Checked)
                    {

                        textBox1.ForeColor = Color.Red;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton5.Checked)
                    {
                        textBox1.ForeColor = Color.Blue;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);

                    }
                    else if (radioButton6.Checked)
                    {
                        textBox1.ForeColor = Color.Green;
                        textBox1.Font = new Font(textBox1.Font.FontFamily, 16, style: FontStyle.Bold | FontStyle.Underline | FontStyle.Italic);


                    }
                    else textBox1.Text = "błąd danych";

                }
            }
        }
    }
}
