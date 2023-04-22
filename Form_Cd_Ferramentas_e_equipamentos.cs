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
    public partial class Form_Ferramentas_e_equipamentos : Form
    {
        RegrasNegocio.RN_Ferramentas ferramentas;

        public static int codigo;
        public Form_Ferramentas_e_equipamentos()
        {
            InitializeComponent();
            ListarFerramentas();
        }
        private void Form_Ferramentas_Load(object sender, EventArgs e)
        {
            ListarFerramentas();
        }

        private void ListarFerramentas()
        {
            try
            {
                ferramentas = new RegrasNegocio.RN_Ferramentas();

                dgvFerramentas.DataSource = ferramentas.retornarFerrramenta();

                FormatarDataGruid(dgvFerramentas);
            }
            catch (Exception)
            {

                throw;
            }



        }

        private void FormatarDataGruid(DataGridView dgvFerramentas)
        {
            dgvFerramentas.Columns["dgvclnValor"].DefaultCellStyle.Format = "C2";
            dgvFerramentas.Columns["dgvclnFerramenta"].DisplayIndex = 0;
            dgvFerramentas.Columns["dgvclnValor"].DisplayIndex = 1;
            dgvFerramentas.Columns["dgvclnDataAquisição"].DisplayIndex = 2;
            dgvFerramentas.Columns["btnEditar"].DisplayIndex = 3;
            dgvFerramentas.Columns["btnExcluir"].DisplayIndex = 4;
           
        }


        private void dgvFerramentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFerramentas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvFerramentas.Rows[e.RowIndex].Cells["dtgcolunidFeramentas"].Value.ToString());
                txtNomeFerramenta.Text = dgvFerramentas.Rows[e.RowIndex].Cells["dgvclnFerramenta"].Value.ToString();
                txtValor.Text = Convert.ToString(Convert.ToDouble(dgvFerramentas.Rows[e.RowIndex].Cells["dgvclnValor"].Value.ToString()) * 100);
                dateTimePicker1.Text = dgvFerramentas.Rows[e.RowIndex].Cells["dgvclnDataAquisição"].Value.ToString();
            }
            else if (dgvFerramentas.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                MessageBox.Show("Deseja realmente excluir esta ferramenta? se fiser isto registros que usam esta ferramenta podem ser alterados tambem", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ferramentas = new RegrasNegocio.RN_Ferramentas();
                ferramentas.excluirFeramenta(Convert.ToInt32(dgvFerramentas.Rows[e.RowIndex].Cells["dtgcolunidFeramentas"].Value.ToString()));

                MessageBox.Show("Sucesso", "Ferramenta excluida com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarFerramentas();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try

            {
                    ferramentas = new RegrasNegocio.RN_Ferramentas();

                    if (codigo == 0)
                    {

                        ferramentas.salvarFerramentas(txtNomeFerramenta.Text, Convert.ToDouble(txtValor.Text), Convert.ToDateTime(dateTimePicker1.Text));

                        MessageBox.Show("Sucesso", "Ferramenta cadastrada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarFerramentas();

                        limpar();


                    }
                    else if (codigo > 0 && MessageBox.Show("Deseja realmente alterar esta ferramenta?", "Deseja Alterar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        ferramentas.alterarFerramnta(codigo, txtNomeFerramenta.Text, Convert.ToDouble(txtValor.Text), Convert.ToDateTime(dateTimePicker1.Text));
                        MessageBox.Show("Sucesso", "Ferramenta alterada com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ListarFerramentas();

                        limpar();

                    }
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                ferramentas = new RegrasNegocio.RN_Ferramentas();
                if (txtPesquisar.Text != "")
                {
                    dgvFerramentas.DataSource = ferramentas.pesquisarFerramenta(txtPesquisar.Text);

                }

                else
                {
                    MessageBox.Show("Nenhum nome informado para realizar a pesquisa", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro ao realizar a pesquisa ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpar()
        {
            codigo = 0;
            txtNomeFerramenta.Text = "";
            txtValor.Text = "0";
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            btnSalvar.Text = "Salvar";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            ListarFerramentas();
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtValor);
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void dgvFerramentas_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFerramentas.AllowUserToAddRows = false;
        }
    }
}
