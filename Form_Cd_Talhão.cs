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
    public partial class Form_Cd_Talhão : Form
    {
        RegrasNegocio.RN_Talhão talhão;
        RegrasNegocio.RN_Propriedade propriedade;



        private static int codigo;
        public Form_Cd_Talhão()
        {
            InitializeComponent();
            ListarDatagridTalhão();
            
        }
        private void Form_Talhão_Load(object sender, EventArgs e)
        {

            ListarPropriedade();
            ListarDatagridTalhão();
            Limparcampos();
        }

        private void ListarDatagridTalhão()
        {
            try
            {
                talhão = new RegrasNegocio.RN_Talhão();

                dgvTalhão.DataSource = talhão.listarTalhão();

                Formatar(dgvTalhão);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Formatar(DataGridView dgvTalhão)
        {
            dgvTalhão.Columns["dgvclnTalhão"].DisplayIndex = 1;
            dgvTalhão.Columns["dgvclnhareaHectares"].DisplayIndex = 2;
            dgvTalhão.Columns["dgvclntipodePlanta"].DisplayIndex = 3;
            dgvTalhão.Columns["dgvclnespaçamento"].DisplayIndex = 4;
            dgvTalhão.Columns["dgvclndataPlantio"].DisplayIndex = 5;
            dgvTalhão.Columns["dgvclnPropriedade"].DisplayIndex = 6;
            dgvTalhão.Columns["dgvclnQuantidadedePlantas"].DisplayIndex = 7;
            dgvTalhão.Columns["btnEditar"].DisplayIndex = 8;
            dgvTalhão.Columns["btnExcluir"].DisplayIndex = 9;


        }

        public void ListarPropriedade()
        {
            try
            {
                propriedade = new RegrasNegocio.RN_Propriedade();

                cboPropriedade.DataSource = propriedade.RetornarPropriedade();
                cboPropriedade.DisplayMember = "nomePropriedade";
                cboPropriedade.ValueMember = "idPropriedade";

                cboPropriedade.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                propriedade = new RegrasNegocio.RN_Propriedade();

               

                if (codigo == 0)
                {

                    talhão.SalvarTalhão(txtTalhão.Text, txtTipoPlanta.Text, Convert.ToDouble(txtEspaçamento.Text), Convert.ToDouble(txtHareaHectares.Text), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtqtdPlantas.Text), cboPropriedade.Text);
                    MessageBox.Show("Propriedade cadastrada  com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (codigo > 0 && MessageBox.Show("Ao efetuar está ação de alteração outros registro podem ser afetados deseja continuar ?", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    talhão.AlterarTalhão(codigo, txtTalhão.Text, txtTipoPlanta.Text, Convert.ToDouble(txtEspaçamento.Text), Convert.ToDouble(txtHareaHectares.Text), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtqtdPlantas.Text), cboPropriedade.Text);
                        
                    MessageBox.Show("Registro de Talhão alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }

                Limparcampos();
                ListarDatagridTalhão();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTalhão.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvTalhão.Rows[e.RowIndex].Cells["dgvclnIdtalhão"].Value.ToString());
                txtTalhão.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclnTalhão"].Value.ToString();
                txtHareaHectares.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclnhareaHectares"].Value.ToString();
                txtTipoPlanta.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclntipodePlanta"].Value.ToString();
                txtEspaçamento.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclnespaçamento"].Value.ToString();
                dateTimePicker1.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclndataPlantio"].Value.ToString();
                txtqtdPlantas.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclnQuantidadedePlantas"].Value.ToString();
                cboPropriedade.Text = dgvTalhão.Rows[e.RowIndex].Cells["dgvclnPropriedade"].Value.ToString();

            }

            else if (dgvTalhão.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Ao efetuar está ação de eclusão outros registro podem ser afetados deseja continuar ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    talhão = new RegrasNegocio.RN_Talhão();
                    talhão.ExcluirTalhão(Convert.ToInt32(dgvTalhão.Rows[e.RowIndex].Cells["dgvclnIdtalhão"].Value.ToString()));

                    MessageBox.Show("Registro excluido com sucesso ", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarDatagridTalhão();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limparcampos();
            ListarDatagridTalhão();
        }

        private void Limparcampos()
        {
            txtTalhão.Text = "";
            txtTipoPlanta.Text = "";
            txtEspaçamento.Text = "0";
            txtHareaHectares.Text = "0";
            txtPesquisar.Text = "";
            codigo = 0;
            txtqtdPlantas.Text = "0";
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            ListarPropriedade();
            ListarDatagridTalhão();
            btnSalvar.Text = "Salvar";


        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                talhão = new RegrasNegocio.RN_Talhão();
                dgvTalhão.DataSource = talhão.PesquisarTalhão(txtPesquisar.Text);

                Formatar(dgvTalhão);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEspaçamento_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtEspaçamento);
        }

        private void txtEspaçamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void txtqtdPlantas_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void txtHareaHectares_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtHareaHectares);
        }

        private void txtHareaHectares_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void dgvTalhão_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvTalhão.AllowUserToAddRows = false;
        }
    }
}
