using SgPropriedade_3._0;
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
    public partial class Form_Logim : Form
    {
        
        public Form_Logim()
        {
            InitializeComponent();
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                RegrasNegocio.RN_Proprietario usuario = new RegrasNegocio.RN_Proprietario();
                DataTable dadostabela = new DataTable();

                dadostabela = usuario.Logim(txtNome.Text, txtSenha.Text);

                if (dadostabela.Rows.Count == 0)
                {
                    MessageBox.Show("Erro", "Usuario ou senha invalidos!! Por favor tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show("Olá, " + dadostabela.Rows[0]["nomeProprieatrio"].ToString() + ".\nBem-vindo ao sistema!", "Bem-vindo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                    Form_Principal form_Principal = new Form_Principal();
                    form_Principal.Show();

                    this.Hide();

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao efetuar o Logim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checExibirSenha.Checked)
            {
                txtSenha.PasswordChar = Convert.ToChar("\0");
               
            }
            else
            {
               
               txtSenha.PasswordChar = Convert.ToChar(".");

            }
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Form_Cd_Proprietario_Usuario form_Cd_Proprietario_Usuario = new Form_Cd_Proprietario_Usuario();
            form_Cd_Proprietario_Usuario.Show();
            this. Hide();
        }
    }
}
