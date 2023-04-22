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
   
    public partial class Form_Produção : Form
    {
        int codigo = 0;
        string axiliar = null;
        util Util = new util();
        

        RegrasNegocio.RN_Produção _Produção;
        public Form_Produção()
        {
            InitializeComponent();
            listarcolaborador();
            listarTalhão();
            ListarProduçãoDatagrid();
        }

        private void Form_Produção_Load(object sender, EventArgs e)
        {
            listarcolaborador();
            listarTalhão();
            ListarProduçãoDatagrid();
            limparCampos();
        }

        private void ListarProduçãoDatagrid()
        {
            try
            {
                _Produção = new RegrasNegocio.RN_Produção();
                dgvProdução.DataSource = _Produção.ListarProdução();
                FormatarDatgrid(dgvProdução);
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void FormatarDatgrid(DataGridView dgvProdução)
        {
            dgvProdução.Columns["dgvclnCustoUnitario"].DefaultCellStyle.Format = "C2";
            dgvProdução.Columns["dgvclnCustoTotal"].DefaultCellStyle.Format = "C2";

            dgvProdução.Columns["dgvclnColaborador"].DisplayIndex = 1;
            dgvProdução.Columns["dgvclnTalhão"].DisplayIndex = 2;
            dgvProdução.Columns["dgvclnDataInicio"].DisplayIndex = 3;
            dgvProdução.Columns["dgvclnDataFim"].DisplayIndex = 4;
            dgvProdução.Columns["dgvclnObservação"].DisplayIndex = 5;
            dgvProdução.Columns["dgvclnQuantidade"].DisplayIndex = 6;
            dgvProdução.Columns["dgvclnCustoUnitario"].DisplayIndex = 7;
            dgvProdução.Columns["dgvclnCustoTotal"].DisplayIndex = 8;
            dgvProdução.Columns["btnEditar"].DisplayIndex = 9;
            dgvProdução.Columns["btnExcluir"].DisplayIndex = 10;
        }

        private void listarcolaborador()
        {
            try
            {
                RegrasNegocio.RN_Colaborador colaborador = new RegrasNegocio.RN_Colaborador();

                cboColaborador.DataSource = colaborador.ListarColaborador();
                cboColaborador.DisplayMember = "nomeColaborador";
                cboColaborador.ValueMember = "idColaborador";

                cboColaborador.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void listarTalhão()
        {
            try
            {
                RegrasNegocio.RN_Talhão talhão = new RegrasNegocio.RN_Talhão();

                cboTalhão.DataSource = talhão.listarTalhão();
                cboTalhão.DisplayMember = "nomeTalhão";
                cboTalhão.ValueMember = "idTalhão";

                cboTalhão.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }


        private string Checd_Tipo_Produção()
        {

            if (rbNatural.Checked == true)
            {
                axiliar = "Natural";
            }
            else if (rbDespolpado.Checked == true)
            {
                axiliar = "Despolpado";
            }
            else if (rbSeco.Checked == true)
            {
                axiliar = "Seco";
            }
            else if (rbLimpo.Checked == true)
            {
                axiliar = "Descascado";
            }

            else
            {
                axiliar = "";
            }

            return axiliar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _Produção = new RegrasNegocio.RN_Produção();

            string tipoProdução;

            tipoProdução = Checd_Tipo_Produção();
            try
            {
             if (codigo == 0)
                {
                    _Produção.SalvarProdução(tipoProdução, Convert.ToDouble(txtQuantidade.Text), Convert.ToDouble(txtCustos.Text), cboColaborador.Text, cboTalhão.Text,
                                                                                 Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));

                    MessageBox.Show("Registro de produção salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

             else if (codigo > 0 && MessageBox.Show("Deseja alterar este registro de produção ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes ) {
                    _Produção.AlterarProdução(codigo, tipoProdução, Convert.ToDouble(txtQuantidade.Text), Convert.ToDouble(txtCustos.Text), cboColaborador.Text, cboTalhão.Text, 
                                                                                              Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));

                    MessageBox.Show("Registro de produção alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                limparCampos();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limparCampos()
        {
            cboColaborador.SelectedIndex = -1;
            cboTalhão.SelectedIndex = -1;
            txtCustos.Text = "0";
            txtQuantidade.Text = "0";
            txtPesquisar.Text = "";
            ListarProduçãoDatagrid();
            rbNatural.Checked = false;
            rbDespolpado.Checked = false;
            rbLimpo.Checked = false;
            rbSeco.Checked = false;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
            txtPesquisar.Visible = true;
            btnSalvar.Text = "Salvar";

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {

                _Produção = new RegrasNegocio.RN_Produção();
                if(rbColaborador.Checked == true )
                {
                    axiliar = "Colaborador";
                 dgvProdução.DataSource =   _Produção.PesquisarProdução(axiliar, txtPesquisar.Text, null);
                    FormatarDatgrid(dgvProdução);
                }

                else if (rbTalhão.Checked == true)
                {
                    axiliar = "Talhão";
                    dgvProdução.DataSource = _Produção.PesquisarProdução(axiliar, txtPesquisar.Text, null);
                    FormatarDatgrid(dgvProdução);
                }

                else if (rbData.Checked == true)
                {
                    axiliar = "Data";
                    dgvProdução.DataSource = _Produção.PesquisarProdução(axiliar, dateTimePicker3.Text, dateTimePicker4.Text);
                    FormatarDatgrid(dgvProdução);
                }

                else
                {

                }
          
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void dgvProdução_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdução.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvProdução.Rows[e.RowIndex].Cells["dgvclnIdProdução"].Value.ToString());
                cboTalhão.Text = dgvProdução.Rows[e.RowIndex].Cells["dgvclnTalhão"].Value.ToString();
                cboColaborador.Text = dgvProdução.Rows[e.RowIndex].Cells["dgvclnColaborador"].Value.ToString();
                txtQuantidade.Text = dgvProdução.Rows[e.RowIndex].Cells["dgvclnQuantidade"].Value.ToString();
                txtCustos.Text =Convert.ToString(Convert.ToDouble( dgvProdução.Rows[e.RowIndex].Cells["dgvclnCustoUnitario"].Value.ToString()) * 100);
                dateTimePicker1.Text = dgvProdução.Rows[e.RowIndex].Cells["dgvclnDataInicio"].Value.ToString();
                dateTimePicker2.Text = dgvProdução.Rows[e.RowIndex].Cells["dgvclnDataFim"].Value.ToString();
                string observação;
                observação = dgvProdução.Rows[e.RowIndex].Cells["dgvclnObservação"].Value.ToString();

                switch (observação)
                {
                    case "Natural":
                        rbNatural.Checked = true;
                        break;

                    case "Despolpado":
                        rbDespolpado.Checked = true;
                        break;

                    case "Descascado":
                        rbSeco.Checked = true;
                        break;

                    case "limpo":
                        rbLimpo.Checked = true;
                        break;

                    default:
                        break;
                }
  

            }
            else if (dgvProdução.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir este registro de Produção ?" , " Ecluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    _Produção = new RegrasNegocio.RN_Produção();
                    _Produção.EsxcluirProdução(Convert.ToInt32(dgvProdução.Rows[e.RowIndex].Cells["dgvclnIdProdução"].Value.ToString()));

                    MessageBox.Show("Registro de produção excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message ,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListarProduçãoDatagrid();
                }
            }
        }

      
        private void txtCustos_TextChanged(object sender, EventArgs e)
        {
            util.formatar(ref txtCustos);
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void txtCustos_KeyPress(object sender, KeyPressEventArgs e)
        {
            util.numeros(e);
        }

        private void rbData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = false;
            dateTimePicker3.Visible = true;
            dateTimePicker4.Visible = true;
        }

        private void rbColaborador_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
        }

        private void rbTalhão_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisar.Visible = true;
            dateTimePicker3.Visible = false;
            dateTimePicker4.Visible = false;
        }

        private void dgvProdução_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvProdução.AllowUserToAddRows = false;
        }

      
    }
}
