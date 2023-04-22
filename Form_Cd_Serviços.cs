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
    public partial class Form_Cd_Serviços : Form
    {
        RegrasNegocio.RN_Serviços serviços;

        util util = new util();

        public static int codigo = 0;

        public Form_Cd_Serviços()
        {
            InitializeComponent();
            ListarDataGridServiços();
        }

        private void Form_CadastroServiços_Load(object sender, EventArgs e)
        {
            ListarDataGridServiços();
            LimparCampos();
            codigo = 0;

        }

        private void ListarDataGridServiços()
        {
            try
            {
                serviços = new RegrasNegocio.RN_Serviços();
                dgvServiços.DataSource = serviços.retornarServiços();

                formatarDataGrid(dgvServiços);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatarDataGrid(DataGridView dgvServiços)
        {
            dgvServiços.Columns["dgvclnValor"].DefaultCellStyle.Format = "C2";
            dgvServiços.Columns["dgvclnServiços"].DisplayIndex = 0;
            dgvServiços.Columns["dgvclnValor"].DisplayIndex = 1;
            dgvServiços.Columns["dgvclnData"].DisplayIndex = 2;
            dgvServiços.Columns["btnEditar"].DisplayIndex = 3;
            dgvServiços.Columns["btnExcluir"].DisplayIndex = 4;
           

        }

     
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                serviços = new RegrasNegocio.RN_Serviços();

                if (codigo == 0)
                {
                    serviços.SalvarServiços(txtServiços.Text, Convert.ToDouble(txtValor.Text), Convert.ToDateTime(dateTimePicker1.Text));
                    MessageBox.Show("Serviço salvo com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (codigo > 0 && MessageBox.Show("Deseja realmente alterar este Serviço!! Caso execute esta alteração registro que usem este registro tambem podem ser alterados", "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    serviços.AlterarServiços(codigo, txtServiços.Text, Convert.ToDouble(txtValor.Text), Convert.ToDateTime(dateTimePicker1.Text));
                    MessageBox.Show("Serviço alterado com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                ListarDataGridServiços();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvServiços_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServiços.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                txtServiços.Text = dgvServiços.Rows[e.RowIndex].Cells["dgvclnServiços"].Value.ToString();
                txtValor.Text = Convert.ToString( Convert.ToDouble(dgvServiços.Rows[e.RowIndex].Cells["dgvclnValor"].Value.ToString()) * 100);
                dateTimePicker1.Text = dgvServiços.Rows[e.RowIndex].Cells["dgvclnData"].Value.ToString();
                codigo = Convert.ToInt32(dgvServiços.Rows[e.RowIndex].Cells["dgvclnID"].Value.ToString());
            }

            else if (dgvServiços.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir este Serviço!! Caso execute esta alteração registro que usem este registro tambem podem ser alterados", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    serviços = new RegrasNegocio.RN_Serviços();

                    serviços.ExcluirServiços(Convert.ToInt32(dgvServiços.Rows[e.RowIndex].Cells["dgvclnID"].Value.ToString()));

                    MessageBox.Show("Serviço Excluido com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListarDataGridServiços();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LimparCampos()
        {
            txtServiços.Text = "";
            txtValor.Text = "0";
            txtPesquisar.Text = "";
            codigo = 0;
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            btnSalvar.Text = "Salvar";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ListarDataGridServiços();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            util.formatar( ref txtValor);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            util.numeros(e);
        }


        private void dgvServiços_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvServiços.AllowUserToAddRows = false;
        }
    }
}
