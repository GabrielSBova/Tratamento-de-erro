using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tratamento_erro
{
    public partial class txt1 : Form
    {
        public void exibirErro(String mensagem)
        {
            MessageBox.Show(null,
                "Erro: " + mensagem,
                "Atenção",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        public txt1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            int a, b, soma;
            a = int.Parse(txtValor1.Text);
            b = int.Parse(txtValor2.Text);
            soma = a + b;
            txtResultado.Text = soma.ToString();
            }
            catch (Exception erro)
            {
                exibirErro(erro.Message.ToString());
            }
        }

        private void txt1_Load(object sender, EventArgs e)
        {

        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, subtracao;
                a = int.Parse(txtValor1.Text);
                b = int.Parse(txtValor2.Text);
                subtracao = a - b;
                txtResultado.Text = subtracao.ToString();
            }
            catch (Exception erro)
            {
                exibirErro(erro.Message.ToString());
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, mult;
                a = int.Parse(txtValor1.Text);
                b = int.Parse(txtValor2.Text);
                mult = a * b;
                txtResultado.Text = mult.ToString();
            }
            catch (Exception erro)
            {
                exibirErro(erro.Message.ToString());
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, divisao;
                a = int.Parse(txtValor1.Text);
                b = int.Parse(txtValor2.Text);
                divisao = a / b;
                txtResultado.Text = divisao.ToString();
            }
            catch (Exception erro)
            {
                exibirErro(erro.Message.ToString());
            }
        }

        private void btnRestoDiv_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b, resto;
                a = int.Parse(txtValor1.Text);
                b = int.Parse(txtValor2.Text);
                resto = a % b;
                txtResultado.Text = resto.ToString();
            }
            catch (Exception erro)
            {
                exibirErro(erro.Message.ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Utils.Utilitarios.limparTextos(this.Controls);
        }
    }
}
