﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Campo Nome


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Campo Endereco

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }//Campo Cidade

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }//Campo Estado

        private void button1_Click(object sender, EventArgs e)
        {
            int codigo      = Convert.ToInt32(maskedTextBox2.Text);
            string nome     = textBox2.Text; 
            string telefone = maskedTextBox1.Text;
            string endereco = textBox4.Text;
            string cidade   = textBox5.Text;
            string esta     = estado.Text;

            MessageBox.Show("Código: "     + codigo   + 
                            "\nNome: "     + nome     +
                            "\nTelefone: " + telefone +
                            "\nEndereço: " + endereco +
                            "\nCidade: "   + cidade   +
                            "\nEstado: "   + esta);
        }//Botão Cadastrar

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Código

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Telefone
    }//fim da classe
}//fim do projeto
