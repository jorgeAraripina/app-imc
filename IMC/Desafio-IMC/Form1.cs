using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1Cal_Click(object sender, EventArgs e)
        {
            valor val=new valor();

            val.peso = double.Parse(textBox1peso.Text);
            val.altura = double.Parse(textBox2altura.Text);

            val.imc = val.peso / (val.altura * val.altura);

            if (val.imc < 18.5)
            {
                listBox1.Items.Add("Baixo Peso");
            }
            
            else if (val.imc >= 18.5 && val.imc <= 24.99)
            {
                listBox1.Items.Add("Peso Normal");
            }
            
            else if (val.imc >= 25 && val.imc <= 29.99)
            {
                listBox1.Items.Add("Sobrepeso");
            }
            
            else if (val.imc >= 30)
            {
                listBox1.Items.Add("Obeso");
            }
        }

        private void button2Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
