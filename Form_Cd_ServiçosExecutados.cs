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
    public partial class Form_Cd_ServiçosExecutados : Form
    {
        RegrasNegocio.RN_Atividades atividade;
        private static int codigo;
        private static string auxiliar;
        public Form_Cd_ServiçosExecutados()
        {
            InitializeComponent();
            listarAtividades();
        }


        private void Form_ExecuçãodeAtividades_Load(object sender, EventArgs e)
        {
            
            Listarserviços();
            listarcolaborador();
            listarTalhão(); 
            limparCampos();
            listarAtividades();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

     
        private void Listarserviços()
        {
            RegrasNegocio.RN_Serviços serviços = new RegrasNegocio.RN_Serviços();

            cboServiço.DataSource = serviços.retornarServiços();
            cboServiço.DisplayMember = "tiposerviço";
            cboServiço.ValueMember = "idserviço";

            cboColaborador.SelectedIndex = -1;
        }

        private void listarcolaborador()
        {
            RegrasNegocio.RN_Colaborador colaborador = new RegrasNegocio.RN_Colaborador();

            cboColaborador.DataSource = colaborador.ListarColaborador();
            cboColaborador.DisplayMember = "nomeColaborador";
            cboColaborador.ValueMember = "idColaborador";

            cboColaborador.SelectedIndex = -1;
        }

        private void listarTalhão()
        {
            RegrasNegocio.RN_Talhão talhão = new RegrasNegocio.RN_Talhão();

            cboTalhão.DataSource = talhão.listarTalhão();
            cboTalhão.DisplayMember = "nomeTalhão";
            cboTalhão.ValueMember = "idTalhão";

            cboTalhão.SelectedIndex = -1;
        }

      
        private void listarAtividades()
        {
            try
            {
                atividade = new RegrasNegocio.RN_Atividades();

                dgvServiçosExecutados.DataSource = atividade.ListarAtividades();

                formatardgv(dgvServiçosExecutados);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatardgv(DataGridView dgvServiçosExecutados)
        {
            dgvServiçosExecutados.Columns["dgvclnColaborador"].DisplayIndex = 1;
            dgvServiçosExecutados.Columns["dgvclnTalhão"].DisplayIndex = 2;
            dgvServiçosExecutados.Columns["dgvclnAtividade"].DisplayIndex = 3;
            dgvServiçosExecutados.Columns["dgvclnDataComeço"].DisplayIndex = 4;
            dgvServiçosExecutados.Columns["dgvclndataTermino"].DisplayIndex = 5;
            dgvServiçosExecutados.Columns["dgvclnSituação"].DisplayIndex = 6;
            dgvServiçosExecutados.Columns["btnEditar"].DisplayIndex = 7;
            dgvServiçosExecutados.Columns["btnExcluir"].DisplayIndex = 8;

        }

        private void limparCampos()
        {
            codigo = 0;
            cboServiço.SelectedIndex = -1;
            cboColaborador.SelectedIndex = -1;
            cboTalhão.SelectedIndex = -1;
            txtPesquisar.Text = "";
            rbAPagar.Checked = false;
            rbPago.Checked = false;
            rbDeCasa.Checked = false;
            listarAtividades();
            btnSalvar.Text = "Salvar";
        }


        private string ConferiSituação()
        {

            if (rbAPagar.Checked == true)
            {
                auxiliar = rbAPagar.Text;
            }
            else   if (rbDeCasa.Checked == true)
            {
                auxiliar = rbDeCasa.Text;
            }
            else if (rbPago.Checked == true)
            {
                auxiliar = rbPago.Text;

            }
            else
            {
                auxiliar = "";
            }

            return auxiliar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resultadoSituação = ConferiSituação();
                atividade = new RegrasNegocio.RN_Atividades();
                if (codigo == 0)
                {

                    atividade.SalvarAtividade(resultadoSituação, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text)
                                                                                            , cboTalhão.Text, cboColaborador.Text, cboServiço.Text);

                    MessageBox.Show("Atividade salva com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (codigo > 0  && MessageBox.Show("Deseja realmente alterar o registro desta atividade", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                    atividade.AlterarAtividade(codigo, auxiliar, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text),
                                                                                             cboTalhão.Text, cboColaborador.Text, cboServiço.Text);
                    MessageBox.Show("Atividade alterada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                listarAtividades();
                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvServiços_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvServiçosExecutados.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                codigo = Convert.ToInt32(dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnidExecuçãoAtividades"].Value.ToString()); 
                cboTalhão.Text = dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnTalhão"].Value.ToString();
                cboServiço.Text = dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnAtividade"].Value.ToString();
                cboColaborador.Text = dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnColaborador"].Value.ToString();
                dateTimePicker1.Text = dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnDataComeço"].Value.ToString();
                dateTimePicker2.Text = dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclndataTermino"].Value.ToString();
                auxiliar = Convert.ToString(dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnSituação"].Value.ToString());

                RadioButons(auxiliar);

            }

            if (dgvServiçosExecutados.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir o registro desta atividade", "Infomação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    atividade = new RegrasNegocio.RN_Atividades();
                    atividade.ExcluirAtividade(Convert.ToInt32(dgvServiçosExecutados.Rows[e.RowIndex].Cells["dgvclnidExecuçãoAtividades"].Value.ToString()));
                    listarAtividades();
        

                        MessageBox.Show("Registro excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void RadioButons(string dados)
        {
            switch (dados)
            {
                case "Pago":
                    rbPago.Checked = true;
                    break;

                case "Apagar":
                    rbAPagar.Checked = true;
                    break;

                case "casa":
                    rbDeCasa.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            atividade = new RegrasNegocio.RN_Atividades();
            try
            {
                dgvServiçosExecutados.DataSource = atividade.PesquisarAtividade(txtPesquisar.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            formatardgv(dgvServiçosExecutados);
        }

        private void dgvServiços_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvServiçosExecutados.AllowUserToAddRows = false;
        }
    }
}
