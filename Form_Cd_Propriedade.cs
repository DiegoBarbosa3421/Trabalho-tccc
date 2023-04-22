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
    public partial class Form_Cd_Propriedade : Form
    {

        RegrasNegocio.RN_Propriedade Propriedade;
        RegrasNegocio.RN_Proprietario proprietario;

        public static int codigo;
        public Form_Cd_Propriedade()
        {
            InitializeComponent();
            listarDatagrid();
            ListarProprietario();
            limparcampos();

      
        }

        private void Form_Cd_Propriedade_Load(object sender, EventArgs e)
        {
            listarDatagrid();
            ListarProprietario();
            limparcampos();
        }


        public void listarDatagrid()
        {
            try
            {

                Propriedade = new RegrasNegocio.RN_Propriedade();
                dgvPropriedade.DataSource = Propriedade.RetornarPropriedade();
                formatar(dgvPropriedade);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
          

        }

        public void formatar(DataGridView dgvPropriedade)
        {

                dgvPropriedade.Columns["dgvclnValor"].DefaultCellStyle.Format = "C2";
                dgvPropriedade.Columns["dgvclnnome"].DisplayIndex = 0;
                dgvPropriedade.Columns["dgvclnValor"].DisplayIndex = 1;
                dgvPropriedade.Columns["dgvclnTipoDeCultivo"].DisplayIndex = 2;
                dgvPropriedade.Columns["dgvclnHarea"].DisplayIndex = 3;
                dgvPropriedade.Columns["dgvclndata"].DisplayIndex = 4;
                dgvPropriedade.Columns["dgvclnProprietario"].DisplayIndex = 5;
                dgvPropriedade.Columns["btnEditar"].DisplayIndex = 6;
                dgvPropriedade.Columns["btnExcluir"].DisplayIndex = 9;

        }



        public void ListarProprietario()
        {
            try
            {

                proprietario = new RegrasNegocio.RN_Proprietario();

                cboProprietario.DataSource = proprietario.RetornarProprietario();
                cboProprietario.DisplayMember = "nomeProprieatrio";
                cboProprietario.ValueMember = "idproprietario";

              
                cboProprietario.SelectedIndex = -1;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "1", "Erro" + ex + "1" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                Propriedade = new RegrasNegocio.RN_Propriedade();

                if (codigo == 0)
                {
 
                    Propriedade.SalvarPropriedade(txtPropriedade.Text, txtTipoCultivo.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDouble(txtValorPropriedade.Text), Convert.ToDouble(txtHareaHectares.Text), cboProprietario.Text);

                    MessageBox.Show("Propriedade cadastrada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (codigo > 0 && MessageBox.Show("Deseja salvar as alteraçoes", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Propriedade.AlterarPropriedade(codigo, txtPropriedade.Text, txtTipoCultivo.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDouble(txtValorPropriedade.Text), Convert.ToDouble(txtHareaHectares.Text), cboProprietario.Text);

                    MessageBox.Show("Propriedade alterada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                listarDatagrid(); ;
                limparcampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparcampos()
        {
            txtPropriedade.Text = "";
            txtValorPropriedade.Text = "0";
            txtTipoCultivo.Text = "";
            txtPesquisar.Text = "";
            txtHareaHectares.Text = "0";
            cboProprietario.SelectedIndex = -1;
            codigo = 0;
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            btnSalvar.Text = "Salvar";


        }


        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtValorPropriedade);
        }


        private void txtHareaHectares_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void txtHareaHectares_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtHareaHectares);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                Propriedade = new RegrasNegocio.RN_Propriedade();

                dgvPropriedade.DataSource = Propriedade.PesquisarPropriedade(txtPesquisar.Text);

                formatar(dgvPropriedade);
            }
            catch (Exception)
            {

                throw;
            }

        }




        private void dgvPropriedade_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropriedade.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnidPropriedade"].Value.ToString());
                txtPropriedade.Text = dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnnome"].Value.ToString();
                txtHareaHectares.Text = dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnHarea"].Value.ToString();
                txtTipoCultivo.Text = dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnTipoDeCultivo"].Value.ToString();
                txtValorPropriedade.Text = Convert.ToString(Convert.ToDouble(dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnValor"].Value.ToString()) * 100);
                dateTimePicker1.Text = dgvPropriedade.Rows[e.RowIndex].Cells["dgvclndata"].Value.ToString();
                cboProprietario.Text = dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnProprietario"].Value.ToString();

            }
            else if (dgvPropriedade.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show(" Deseja realmente escluir esta Propriedade", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Propriedade = new RegrasNegocio.RN_Propriedade();

                    Propriedade.ExclluirPropriedade(Convert.ToInt32(dgvPropriedade.Rows[e.RowIndex].Cells["dgvclnidPropriedade"].Value.ToString()));

                    MessageBox.Show("Propriedade excluida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listarDatagrid();
                }
                catch (Exception ex)
                {


                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparcampos();
            listarDatagrid();
        }

        private void dgvPropriedade_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvPropriedade.AllowUserToAddRows = false;
        }
    }
}
