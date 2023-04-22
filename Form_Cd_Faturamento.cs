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
    public partial class Form_Cd_Faturamento : Form
    {
        private int codigo;
        string alxiliar;

        RegrasNegocio.RN_Faturamento rN_Faturamento;

        public Form_Cd_Faturamento()
        {
            InitializeComponent();
            ListarDataGrid();
          


        }

        private void Form_Cd_Faturamento_Load(object sender, EventArgs e)
        {
            CarregarAnoAtual();
            listarTalhão();
            ListarDataGrid();
            LimParCampos();
        }

        private void ListarDataGrid()
        {
            try
            {
                DataTable lidtarTabela;
                rN_Faturamento = new RegrasNegocio.RN_Faturamento();
                lidtarTabela = rN_Faturamento.ListarFaturamento();

                dgvFaturamento.DataSource = lidtarTabela;

                FormatarDataGrid(dgvFaturamento);
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void listarTalhão()
        {
            RegrasNegocio.RN_Talhão talhão = new RegrasNegocio.RN_Talhão();

            cboTalhão.DataSource = talhão.listarTalhão();
            cboTalhão.DisplayMember = "nomeTalhão";
            cboTalhão.ValueMember = "idTalhão";

            cboTalhão.SelectedIndex = -1;
        }


        private void FormatarDataGrid(DataGridView dgvFaturamento)
        {
            dgvFaturamento.Columns["dgvclnFaturamentoTotal"].DefaultCellStyle.Format = "C2";
            dgvFaturamento.Columns["dgvclnFaturamentoUnitario"].DefaultCellStyle.Format = "C2";
            dgvFaturamento.Columns["dgvclnTalhão"].DisplayIndex = 1;
            dgvFaturamento.Columns["dgvclnQuntidade"].DisplayIndex = 2;
            dgvFaturamento.Columns["dgvclnDataFaturamento"].DisplayIndex = 3;
            dgvFaturamento.Columns["dgvclnFaturamentoUnitario"].DisplayIndex = 4;
            dgvFaturamento.Columns["dgvclnFaturamentoTotal"].DisplayIndex = 5;
            dgvFaturamento.Columns["dgvclnTipodeCafé"].DisplayIndex = 6;
            dgvFaturamento.Columns["btnEditar"].DisplayIndex = 7;
            dgvFaturamento.Columns["btnExcluir"].DisplayIndex = 8;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            rN_Faturamento = new RegrasNegocio.RN_Faturamento();

            if (rbDescascado.Checked == true)
            {
                alxiliar = "Descascado";
            }
            else if (rbDespolpado.Checked == true)
            {
                alxiliar = "Despolpado";
            }

            try
            {

                if (codigo == 0)
                {
                    rN_Faturamento.SalvarFaturamento(cboTalhão.Text, Convert.ToDouble(txtQuantidade.Text), Convert.ToDateTime(dateTimePicker1.Text)
                        ,Convert.ToDouble(txtValorAreccadadoUnidade.Text), Convert.ToDouble(Convert.ToDouble(txtValorAreccadadoUnidade.Text) * Convert.ToDouble(txtQuantidade.Text)), Convert.ToDouble(txtQuantidadeDisponivel.Text), alxiliar);
                    MessageBox.Show("Registros salvos com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if(codigo >0)
                {
                    rN_Faturamento.AlterarFaturamento( codigo,cboTalhão.Text, Convert.ToDouble(txtQuantidade.Text) , Convert.ToDateTime(dateTimePicker1.Text),
                    Convert.ToDouble(txtValorAreccadadoUnidade.Text), Convert.ToDouble(txtValorArrecadadoTotal.Text), Convert.ToDouble(txtQuantidadeDisponivel.Text), alxiliar );
                    MessageBox.Show("Registros alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimParCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvFaturamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFaturamento.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";

                String tipoCafé;
                codigo = Convert.ToInt32(dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnidFAturamento"].Value.ToString());
                cboTalhão.Text = dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnTalhão"].Value.ToString();
                txtQuantidade.Text = dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnQuntidade"].Value.ToString();
                txtValorAreccadadoUnidade.Text = Convert.ToString(Convert.ToDouble(dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnFaturamentoUnitario"].Value.ToString()) * 100);
                txtValorArrecadadoTotal.Text = Convert.ToString(Convert.ToDouble(dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnFaturamentoTotal"].Value.ToString())* 100);
                dateTimePicker1.Text = dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnDataFaturamento"].Value.ToString();
                alxiliar = dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnTipodeCafé"].Value.ToString();
                tipoCafé = Convert.ToString(dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnTipodeCafé"].Value.ToString());

                if (tipoCafé == "Descascado")
                {
                    rbDescascado.Checked = true;
                }
                else if (tipoCafé == "Despolpado")
                {
                    rbDespolpado.Checked = true;
                }
                else if(tipoCafé.Trim().Length == 0)
                {
                    rbDescascado.Checked = false;
                    rbDespolpado.Checked = false;
                }
                
            }

            else if (dgvFaturamento.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja excluir o faturamento ", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                 rN_Faturamento.ExcluirFaturamento(Convert.ToInt32(dgvFaturamento.Rows[e.RowIndex].Cells["dgvclnidFAturamento"].Value.ToString()));
                MessageBox.Show("Registros excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ListarDataGrid();
            }
        }

        private void LimParCampos()
        {
            txtPesquisar.Text = "";
            txtValorAreccadadoUnidade.Text  = "0";
            txtValorArrecadadoTotal.Text = "0";
            txtQuantidade.Text = "0";
            cboTalhão.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Today;
            txtQuantidadeDisponivel.Text = "0";
            ListarDataGrid();
            rbDescascado.Checked = false;
            rbDespolpado.Checked = false;
            CarregarAnoAtual();
            alxiliar = "";
            btnSalvar.Text = "Salvar";
        }



        private void CarregarAnoAtual()
        {
            cboAno.Items.Clear();
            int currentYear = DateTime.Now.Year;
            cboAno.Items.Add(currentYear);
            for (int i = 1; i <= 9; i++)
            {
                cboAno.Items.Add(currentYear - i);
            }
            cboAno.SelectedIndex = 0; 
        }

        private void rbDescascado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDescascado.Checked == true)
                {
                  
                    string alxiliar = "Descascado";
                    rN_Faturamento = new RegrasNegocio.RN_Faturamento();
                    txtQuantidadeDisponivel.Text = "0";
                    txtQuantidadeDisponivel.Text = "  " + rN_Faturamento.RetornarQuantidadeProduzida(cboTalhão.Text, alxiliar, cboAno.Text);
                }

                else {  }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbDescascado.Checked = false;
            }
        }

        private void rbDespolpado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbDespolpado.Checked == true)
                {

                    string alxiliar = "Despolpado";
                    rN_Faturamento = new RegrasNegocio.RN_Faturamento();
                    txtQuantidadeDisponivel.Text = "0";
                    txtQuantidadeDisponivel.Text = "  " + rN_Faturamento.RetornarQuantidadeProduzida(cboTalhão.Text, alxiliar, cboAno.Text); 
                }
                else { }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbDespolpado.Checked = true;
            }
        }

      
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimParCampos();
           
        }


        private void CalcularValorTotal()
        {

            double valorTotal = 0, valorUnidade = 0, quantidade = 0;
            valorUnidade = Convert.ToDouble(txtValorAreccadadoUnidade.Text);
            quantidade = Convert.ToDouble(txtQuantidade.Text);

            valorTotal = quantidade * valorUnidade;

            txtValorArrecadadoTotal.Text = Convert.ToString(valorTotal);

        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            int novoNumero;

            // Verifica se o conteúdo do text é um número inteiro válido
            if (int.TryParse(txtQuantidade.Text, out novoNumero))
            {
                // Atualiza o valor selecionado no ComboBox com o novo número
                txtQuantidade.Text = novoNumero.ToString();
            
            }


            if (double.TryParse(txtQuantidade.Text, out double valorUnidade) && valorUnidade > 0)
            {
                CalcularValorTotal();
            }
            else if (txtQuantidade.Text == "0")
            {
                txtQuantidade.Text = "0";
            }
        }

        private void txtValorAreccadadoUnidade_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtValorAreccadadoUnidade);
            if (double.TryParse(txtValorAreccadadoUnidade.Text, out double valorUnidade) && valorUnidade > 0)
            {
                CalcularValorTotal();
            }
            else if (txtValorAreccadadoUnidade.Text == "0")
            {
                txtValorAreccadadoUnidade.Text = "0";
            }

        }

        private void txtValorAreccadadoUnidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
          

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
          
        }

        private void dgvFaturamento_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFaturamento.AllowUserToAddRows = false;
        }
    }
}
