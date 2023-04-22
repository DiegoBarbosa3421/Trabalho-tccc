using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPropriedade3
{
    public partial class Form_Cd_Proprietario_Usuario : Form
    {
        RegrasNegocio.RN_Proprietario _Proprietario;
        public Form_Cd_Proprietario_Usuario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            _Proprietario = new RegrasNegocio.RN_Proprietario();

            try
            {
                if (txtConfirmarSenha.Text == txtSenha.Text)
                {
                    _Proprietario.Cadastrar(txtNome.Text, txtSenha.Text, txtCPF.Text);
                    MessageBox.Show("Usuario cadastrado com sucesso irei retornalo para tela de logim para proceguir para o sitema", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form_Logim form_Logim = new Form_Logim();
                    form_Logim.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Senhas não coincidem!! Tente inserilas novamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

              


                LimparCampos();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void chbExibiSenha_CheckedChanged(object sender, EventArgs e)
        {
          
                if (checExibirSenha.Checked)
                {
                    txtSenha.PasswordChar = Convert.ToChar("\0");
                     txtConfirmarSenha.PasswordChar = Convert.ToChar("\0");
            }
                else
                {

                    txtSenha.PasswordChar = Convert.ToChar(".");
                txtConfirmarSenha.PasswordChar = Convert.ToChar(".");
            }
           
        }

       private void LimparCampos()
        {
            txtConfirmarSenha.Text = "";
            txtCPF.Text = "";
            txtSenha.Text = "";
            txtNome.Text = "";
        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Form_Logim form_Logim = new Form_Logim();
            form_Logim.Show();
            this.Hide();
        }
    }
}
