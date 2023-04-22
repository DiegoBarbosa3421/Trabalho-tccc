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
    public partial class Form_cadInsumos : Form
    {
        RegrasNegocio.RN_Insumos insumos;

        SGPropriedade3.util util = new SGPropriedade3.util();

        public static int codigo;
        public Form_cadInsumos()
        {
            InitializeComponent();
            listardatagrid();
        }

        private void Form_cadInsumos_Load(object sender, EventArgs e)
        {
            listardatagrid();
            limparCampos();
        }

        public void listardatagrid()
        {


            try
            {
                insumos = new RegrasNegocio.RN_Insumos();

                dgvInsumos.DataSource = insumos.retornarInsumos();

                formatarDatagrid(dgvInsumos);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public void formatarDatagrid(DataGridView dgvInsumos)
        {
            dgvInsumos.Columns["dgvclnPreçoUnitario"].DefaultCellStyle.Format = "C2";
            dgvInsumos.Columns["dgvclnValorTotal"].DefaultCellStyle.Format = "C2";
            dgvInsumos.Columns["dgvclnInsumos"].DisplayIndex = 0;
            dgvInsumos.Columns["dgvclnquantidade"].DisplayIndex = 1;
            dgvInsumos.Columns["dgvclnPreçoUnitario"].DisplayIndex = 3;
            dgvInsumos.Columns["dgvclnValorTotal"].DisplayIndex = 4;  
            dgvInsumos.Columns["dgvclnObservação"].DisplayIndex = 5;
            dgvInsumos.Columns["dgvclnData"].DisplayIndex = 6;
            dgvInsumos.Columns["btnEditar"].DisplayIndex = 7;
            dgvInsumos.Columns["btnExcluir"].DisplayIndex = 8;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {

                if (codigo == 0)
                {
                    insumos = new RegrasNegocio.RN_Insumos();
                    insumos.salvarInsumos(txtInsumo.Text, Convert.ToDouble(txtValorUnidade.Text), Convert.ToDouble(txtValorTotal.Text),
                    Convert.ToDouble(txtQuantidade.Text), txtObservações.Text, Convert.ToDateTime(dateTimePicker1.Text));

                    MessageBox.Show("Insumos cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (codigo > 0 && MessageBox.Show("Deseja alterar este insumo", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes )
                {
                    insumos = new RegrasNegocio.RN_Insumos();
                    insumos.alterarInsumos(codigo, txtInsumo.Text, Convert.ToDouble(txtValorUnidade.Text), Convert.ToDouble(txtValorTotal.Text),
                        Convert.ToDouble(txtQuantidade.Text), txtObservações.Text, Convert.ToDateTime(dateTimePicker1.Text));

                    MessageBox.Show("Insumos alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                listardatagrid();
                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvInsumos.Columns[e.ColumnIndex].Name == "btnEditar")
                {
                    btnSalvar.Text = "Editar";
                    codigo = Convert.ToInt32(dgvInsumos.Rows[e.RowIndex].Cells["dgvclnIdInsumos"].Value.ToString());
                    txtInsumo.Text = dgvInsumos.Rows[e.RowIndex].Cells["dgvclnInsumos"].Value.ToString();
                    txtValorUnidade.Text =Convert.ToString(Convert.ToDouble(dgvInsumos.Rows[e.RowIndex].Cells["dgvclnPreçoUnitario"].Value.ToString()) *100);
                    txtQuantidade.Text = dgvInsumos.Rows[e.RowIndex].Cells["dgvclnquantidade"].Value.ToString();
                    txtValorTotal.Text = Convert.ToString(Convert.ToDouble(dgvInsumos.Rows[e.RowIndex].Cells["dgvclnValorTotal"].Value.ToString()) * 100); 
                    txtObservações.Text = dgvInsumos.Rows[e.RowIndex].Cells["dgvclnObservação"].Value.ToString();
                    dateTimePicker1.Text = dgvInsumos.Rows[e.RowIndex].Cells["dgvclnData"].Value.ToString();

                }

                else if (dgvInsumos.Columns[e.ColumnIndex].Name == "btnExcluir" &&
                    MessageBox.Show("Deseja realmente excluir este insumo? Ao faser isto registros que usam este Isumo podem ser alterados tambem", "Deseja Excluir?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    insumos = new RegrasNegocio.RN_Insumos();
                    insumos.excluirInsumos(Convert.ToInt32(dgvInsumos.Rows[e.RowIndex].Cells["dgvclnIdInsumos"].Value.ToString()));

                    MessageBox.Show("Insumos excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listardatagrid();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void limparCampos()
        {
            codigo = 0;
            txtInsumo.Text = "";
            txtValorUnidade.Text = "0";
            txtQuantidade.Text = "0";
            txtValorTotal.Text = "0";
            txtObservações.Text = "";
            txtPesquisar.Text = "";
            dateTimePicker1.Text = Convert.ToString(DateTime.Today);
            btnSalvar.Text = "Salvar";

        }

        private void CalcularValorTotal()
        {

            double valorTotal = 0, valorUnidade = 0, quantidade = 0;
            valorUnidade = Convert.ToDouble(txtValorUnidade.Text);
            quantidade = Convert.ToDouble(txtQuantidade.Text);

            valorTotal = quantidade * valorUnidade;

            txtValorTotal.Text = Convert.ToString(valorTotal);

        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            insumos = new RegrasNegocio.RN_Insumos();

            dgvInsumos.DataSource = insumos.pesquisarInsumos(txtPesquisar.Text);

            formatarDatagrid(dgvInsumos);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            listardatagrid();
        }



        private void txtValorUnidade_TextChanged(object sender, EventArgs e)
        {
            util.formatarDecimal(ref txtValorUnidade);
            if (txtValorUnidade.Text != null && Convert.ToDouble(txtValorUnidade.Text) > 0)
            {
                CalcularValorTotal();
            }

            else if (txtValorUnidade.Text == "0")
            {
                txtValorUnidade.Text = "0";
            }
        }

        private void txtValorUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {

            util.numeros(e);
        }


        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtQuantidade);
            if (txtQuantidade.Text != null && Convert.ToDouble(txtQuantidade.Text) >= 0)
            {
                CalcularValorTotal();
            }
            else if (txtQuantidade.Text == "0")
            {
                txtValorTotal.Text = "0";
            }
           

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);


        }


        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            util.formatarDecimal(ref txtValorTotal);

        }


        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void dgvInsumos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvInsumos.AllowUserToAddRows = false;
        }
    }
}
