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
    public partial class Form_cadManutenção_Ferramentas : Form
    {
        RegrasNegocio.RN_Manutenções rN_Manutenções;
        int codigo;
        public Form_cadManutenção_Ferramentas()
        {
            InitializeComponent();
            LisatarFerramentas();
            ListarManutenção();
        }
        private void Form_cadManutenção_Ferramentas_Load(object sender, EventArgs e)
        {
            LisatarFerramentas();
            ListarManutenção();
            LimparCampos();
        }


        private void LisatarFerramentas()
        {
            try
            {
                RegrasNegocio.RN_Ferramentas rN_Ferramentas = new RegrasNegocio.RN_Ferramentas();
                cboFerramanta.DataSource = rN_Ferramentas.retornarFerrramenta();
                cboFerramanta.DisplayMember = ("nomeFerramenta");
                cboFerramanta.ValueMember = ("idFerramentas");
                cboFerramanta.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        public void ListarManutenção()
        {
            try
            {
                rN_Manutenções = new RegrasNegocio.RN_Manutenções();

                dgvManutenções.DataSource = rN_Manutenções.ListarMnutenção();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FormatarDatagrid(dgvManutenções);

        }

        private void FormatarDatagrid(DataGridView dgvManutenções)
        {
            dgvManutenções.Columns["dgvclnValorManutenção"].DefaultCellStyle.Format = "C2";
            dgvManutenções.Columns["dgvclnNomeFerramenta"].DisplayIndex = 0;
            dgvManutenções.Columns["dgvclnTipodeMnutenção"].DisplayIndex = 1;
            dgvManutenções.Columns["dgvclnValorManutenção"].DisplayIndex = 2;
            dgvManutenções.Columns["dgvclnDataManutenção"].DisplayIndex = 3;
            dgvManutenções.Columns["btnEditar"].DisplayIndex = 4;
            dgvManutenções.Columns["btnExcluir"].DisplayIndex = 5;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (codigo == 0)
                {
                    rN_Manutenções = new RegrasNegocio.RN_Manutenções();

                    rN_Manutenções.SalvarManutenção(txtManutenção.Text, Convert.ToDouble(txtValorManutenção.Text), Convert.ToDateTime(dateTimePicker1.Text), cboFerramanta.Text);

                    MessageBox.Show("Registro de manutenção cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else if (codigo > 0  && MessageBox.Show("Deseja realmente alterar o registro de Manutenção de ferramentas ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes )
                {
                    rN_Manutenções.AlterarManutenção(txtManutenção.Text, Convert.ToDouble(txtValorManutenção.Text), Convert.ToDateTime(dateTimePicker1.Text), cboFerramanta.Text, codigo);
                    MessageBox.Show("Registro de manutenção alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ListarManutenção();
                LimparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
        
            }

        private void dgvManutenções_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManutenções.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvManutenções.Rows[e.RowIndex].Cells["dgvclnIdManutenção"].Value.ToString());
                cboFerramanta.Text =  dgvManutenções.Rows[e.RowIndex].Cells["dgvclnNomeFerramenta"].Value.ToString();
                txtManutenção.Text = dgvManutenções.Rows[e.RowIndex].Cells["dgvclnTipodeMnutenção"].Value.ToString();
                txtValorManutenção.Text =Convert.ToString(Convert.ToDouble( dgvManutenções.Rows[e.RowIndex].Cells["dgvclnValorManutenção"].Value.ToString()) * 100);  
                dateTimePicker1.Text = dgvManutenções.Rows[e.RowIndex].Cells["dgvclnDataManutenção"].Value.ToString();
                codigo = Convert.ToInt32(dgvManutenções.Rows[e.RowIndex].Cells["dgvclnIdManutenção"].Value.ToString());

            }

            else if(dgvManutenções.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir está manutenção", "Dezeja excluir ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                rN_Manutenções = new RegrasNegocio.RN_Manutenções();

                rN_Manutenções.ExcluirManutenção(Convert.ToInt32(dgvManutenções.Rows[e.RowIndex].Cells["dgvclnIdManutenção"].Value.ToString()));

                MessageBox.Show("Registro de manutenção excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarManutenção(); 

                }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                rN_Manutenções = new RegrasNegocio.RN_Manutenções();

                dgvManutenções.DataSource = rN_Manutenções.Pesquisar(txtPesquisar.Text);

                FormatarDatagrid(dgvManutenções);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        public void LimparCampos()
        {
            btnSalvar.Text = "Salvar";
            txtManutenção.Text = "";
            txtPesquisar.Text = "";
            txtValorManutenção.Text = "0";
            cboFerramanta.SelectedIndex = -1;
            ListarManutenção();

        }



        private void txtValorManutenção_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtValorManutenção);
        }

        private void txtValorManutenção_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void dgvManutenções_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManutenções.AllowUserToAddRows = false;
        }
    }
}
