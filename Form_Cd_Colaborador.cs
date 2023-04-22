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
    public partial class Form_cadColaborador : Form
    {
        RegrasNegocio.RN_Colaborador colaborador;

        private static int codigo;
        public Form_cadColaborador()
        {
            InitializeComponent();
            listarDatagrid();
        }

        private void Form_Colaborador_Load(object sender, EventArgs e)
        {
            listarDatagrid();
            limparCampos();
        }

       private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string situação = null;

                if (rbAtivo.Checked == true)
                {
                    situação = rbAtivo.Text;
                }
                else if (rbInativo.Checked == true)
                {
                    situação = rbInativo.Text;
                }

                else if(rbAdministrativo.Checked == true)
                {
                    situação = rbAdministrativo.Text;
                }

                else
                {
                    situação = "";
                }
                string contato = txtContato.Text.Replace("(", "").Replace(")", "").Replace("-", "");
                colaborador = new RegrasNegocio.RN_Colaborador();
                if (codigo == 0)
                {

                    colaborador.SalvarColaborador(txtNome.Text, txtContato.Text, txtEndereço.Text, situação);

                    MessageBox.Show("Colaborador cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                else if (codigo > 0 && MessageBox.Show("Deseja realmente alterar este colaborador ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    colaborador.AlteraColaborador(codigo, txtNome.Text, contato, txtEndereço.Text, situação);

                    MessageBox.Show("Informaçoes do Colaborador alteradas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                listarDatagrid();

                limparCampos();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listarDatagrid()
        {

            try
            {
                colaborador = new RegrasNegocio.RN_Colaborador();
                dgvColaborador.DataSource = colaborador.ListarColaborador();

                formatarDatagrid(dgvColaborador);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void formatarDatagrid(DataGridView dgvColaborador)
        {
            dgvColaborador.Columns["dgvclncontato"].DefaultCellStyle.Format = "(##) #####-####";
            dgvColaborador.Columns["dgvclnnome"].DisplayIndex = 0;
            dgvColaborador.Columns["dgvclncontato"].DisplayIndex = 1;
            dgvColaborador.Columns["dgvclnendereço"].DisplayIndex = 2;
            dgvColaborador.Columns["dgvclnsituação"].DisplayIndex = 3;
            dgvColaborador.Columns["btnEditar"].DisplayIndex = 4;
            dgvColaborador.Columns["btnExcluir"].DisplayIndex = 5;
        }

        private void dgvColaborador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvColaborador.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                btnSalvar.Text = "Editar";
                txtNome.Text = dgvColaborador.Rows[e.RowIndex].Cells["dgvclnnome"].Value.ToString();
                txtContato.Text = dgvColaborador.Rows[e.RowIndex].Cells["dgvclncontato"].Value.ToString();
                txtEndereço.Text = dgvColaborador.Rows[e.RowIndex].Cells["dgvclnendereço"].Value.ToString();
                string alxiliar = dgvColaborador.Rows[e.RowIndex].Cells["dgvclnsituação"].Value.ToString();
                if (alxiliar == "Ativo")
                {
                    rbAtivo.Checked = true;
                }
                else if (alxiliar == "Administrativo")
                {
                    rbAdministrativo.Checked = true;
                }
                else 
                {
                    rbInativo.Checked = true;
                }



                codigo = Convert.ToInt32(dgvColaborador.Rows[e.RowIndex].Cells["dgvclnidColaborador"].Value.ToString());




            }

            else if (dgvColaborador.Columns[e.ColumnIndex].Name == "btnExcluir" && MessageBox.Show("Deseja realmente excluir este colaborador ? Ao fazer isto registros associados a ele podem ser alterados tambem", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

            {
                try
                {
                   

                    colaborador = new RegrasNegocio.RN_Colaborador();
                    colaborador.ExcluirColaborador(Convert.ToInt32(dgvColaborador.Rows[e.RowIndex].Cells["dgvclnidColaborador"].Value.ToString()));

                    MessageBox.Show("Registro excluido com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listarDatagrid();
                    limparCampos();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtContato.Text = "";
            txtEndereço.Text = "";
            txtPesquisar.Text = "";
            codigo = 0;
            rbAdministrativo.Checked = false;
            rbInativo.Checked = false;
            rbAtivo.Checked = false;
            btnSalvar.Text = "Salvar";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                colaborador = new RegrasNegocio.RN_Colaborador();
                dgvColaborador.DataSource = colaborador.PesquisarColaborador(txtPesquisar.Text);

                formatarDatagrid(dgvColaborador);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            listarDatagrid();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvColaborador_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvColaborador.AllowUserToAddRows = false;
        }
    }
}
