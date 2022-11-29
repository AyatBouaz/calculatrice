using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormscalculette
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        string operateur = "";
        double nombre1 = 0;
       
        private object Texte;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button0.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CEbutton_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
        }

        private void calculate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void suprbutton_Click(object sender, EventArgs e)
        {
            int longueur = textBox_Result.Text.Length - 1;
            string texte = textBox_Result.Text;
            textBox_Result.Clear();
            for (int i = 0; i < longueur; i++)
                textBox_Result.Text += texte[i];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
          if (operateur == "+")
            {
                string [] chaine = textBox_Result.Text.Split('+');
                textBox_Result.Text+= Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) + double.Parse(chaine[1])).ToString() ;
            }
            if (operateur == "-")
            {
                string[] chaine = textBox_Result.Text.Split('-');
                textBox_Result.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) - double.Parse(chaine[1])).ToString();
            }
            if (operateur == "*")
            {
                string[] chaine = textBox_Result.Text.Split('*');
                textBox_Result.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) * double.Parse(chaine[1])).ToString();
            }
            if (operateur == "/")
            {
                string[] chaine = textBox_Result.Text.Split('/');
                textBox_Result.Text += Environment.NewLine + "=" + Environment.NewLine + (double.Parse(chaine[0]) / double.Parse(chaine[1])).ToString();
            }
        }

        private void buttonvergule_Click(object sender, EventArgs e)
        {
            Button buttonclick = (Button)sender;
            textBox_Result.Text += buttonvergule.Text;
        }

        private void buttonsigne_Click(object sender, EventArgs e)
        {

        }

        private void buttonadd_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button2.Text;
        }

        private void buttonsoustr_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button5.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button1.Text;
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text+= button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button9.Text;
        }

        private void buttonmultipl_Click(object sender, EventArgs e)
        {
            Button buttonoperateur = (Button)sender;
            textBox_Result.Text += buttonoperateur.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button4.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button chifre = (Button)sender;
            textBox_Result.Text += button6.Text;
           
        }

        private void operateur_Click(object sender, EventArgs e)
        {
            Button buttonoperateur = (Button)sender;
            textBox_Result.Text += buttonoperateur.Text;
            label3.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;
            operateur = "/";

        }

        private void operateurmultipl_Click(object sender, EventArgs e)
        {
            Button buttonoperateur = (Button)sender;
            textBox_Result.Text += buttonoperateur.Text;
            label3.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;
            operateur = "*";

        }

        private void operateursoustr_Click(object sender, EventArgs e)
        {
            Button buttonoperateur = (Button)sender;
            textBox_Result.Text += buttonoperateur.Text;
            label3.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;
            operateur = "-";
           
        }

        private void operateuradd_Click(object sender, EventArgs e)
        {
            Button buttonoperateur = (Button)sender;
            textBox_Result.Text += buttonoperateur.Text;
            label3.Text = resultValue + "" + operationPerformed;
            isOperationPerformed = true;
            operateur = "+";
            
        }

        private void operationbutton(object sender, EventArgs e)
        {

        }

        private void btnclear_click(object sender, EventArgs e)
        {
            textBox_Result.Clear();
            textBox_Result.Text = "0";
            nombre1 = 0;

        }
    }
}
