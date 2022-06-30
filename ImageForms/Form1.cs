using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageForms
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != "" && txtSobrenome.Text != "" && txtAnoNascimento.Text.Length == 4)
            {
                string nome = txtNome.Text;
                string sobrenome = txtSobrenome.Text;
                int anoNascimento = int.Parse(txtAnoNascimento.Text);
                int idade = int.Parse(DateTime.Now.ToString("yyyy")) - anoNascimento;


                if (idade >= 18)
                {
                    lblMensagem.Text ="Bem-vindo " + nome.Replace(nome[0].ToString(), nome[0].ToString().ToUpper()) +
                        " " +
                        sobrenome.Replace(sobrenome[0].ToString(), sobrenome[0].ToString().ToUpper()) + " " + idade + " anos";
                    pibImage.Image = Properties.Resources.aberto;
                } 
                else
                {
                    lblMensagem.Text = "Acesso Negado!";
                    pibImage.Image = Properties.Resources.fechado;
                }
            }
            else
            {
                MessageBox.Show("Insira as informações corretamente.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtAnoNascimento.Clear();
            lblMensagem.Text = "";
            pibImage.Image = null;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


