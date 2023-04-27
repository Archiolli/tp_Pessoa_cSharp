using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ParaCasa1
{
    public partial class LivroUIL : Form
    {
        Pessoa umaPessoa = new Pessoa();
        public LivroUIL()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcod.Text = "";
            txtnome.Text = "";
            txtidade.Text = "";
            Masculino.Checked = false;
            Feminino.Checked = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            umaPessoa.setCodigo(txtcod.Text);
            umaPessoa.setNome(txtnome.Text);
            umaPessoa.setIdade(txtidade.Text);
            if (Masculino.Checked == true)
            {
                umaPessoa.setSexo("M");
            }else if(Feminino.Checked == true)
            {
                umaPessoa.setSexo("F");
            }


            PessoaBLL.validaDados(umaPessoa, 'i');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void CadLivrosUIL_Load(object sender, EventArgs e)
        {
            PessoaBLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void button3_Click(object sender, EventArgs e)
        {


            string sexo;
            umaPessoa.setCodigo(txtcod.Text);
            PessoaBLL.validaCodigo(umaPessoa,'c');
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {

                txtcod.Text = umaPessoa.getCodigo();
                txtnome.Text = umaPessoa.getNome();
                txtidade.Text = umaPessoa.getIdade();
                sexo = umaPessoa.getSexo();
                if (sexo == "M")
                {
                    Masculino.Checked = true;
                    
                }
                else if (sexo == "F")
                {
                    Feminino.Checked = true;
                }
            }
        }

        private void CadLivrosUIL_FormClosing(object sender, FormClosingEventArgs e)
        {
            PessoaBLL.desconecta();
        }



        private void button4_Click(object sender, EventArgs e)
        {

            umaPessoa.setCodigo(txtcod.Text);
            umaPessoa.setNome(txtnome.Text);
            umaPessoa.setIdade(txtidade.Text);
            if (Masculino.Checked == true)
            {
                umaPessoa.setSexo("M");
            }
            else if (Feminino.Checked == true)
            {
                umaPessoa.setSexo("F");
            }


            PessoaBLL.validaDados(umaPessoa, 'a');

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados alterados com sucesso!");
        }
       
            private void button5_Click(object sender, EventArgs e)
            {
            umaPessoa.setCodigo(txtcod.Text);

            PessoaBLL.validaCodigo(umaPessoa, 'e');

            if (Erro.getErro())
                    MessageBox.Show(Erro.getMsg());
                else
                    MessageBox.Show("Pessoa Excluída!");
            }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
