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
    public partial class Form_Principal : Form
    {
        private Form atvForm;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form_Principal_Load(object sender, EventArgs e)
        {

        }


        public void AbrirNovoFormulario(Form childForm, object sender)
        {

            if (atvForm != null)
                atvForm.Close();
            atvForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnApresentação.Controls.Add(childForm);
            this.pnApresentação.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }


        private void cadastroDeColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_cadColaborador(), sender);

        }

        private void cadastroDeFerramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Ferramentas_e_equipamentos(), sender);

        }

        private void cadastroDeManutençoesFerramentasEEquipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_cadManutenção_Ferramentas(), sender);

        }

        private void cadastroDeInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_cadInsumos(), sender);

        }

        private void cadastroDePropriedadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Cd_Propriedade(), sender);

        }

        private void cadastroDeTalhãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Cd_Talhão(), sender);

        }

        private void cadastroDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Cd_Serviços(), sender);

        }

        private void cadastroDeExecuçãoDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Cd_ServiçosExecutados(), sender);

        }

        private void cadastroFaturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Cd_Faturamento(), sender);
        }

        private void cadastroProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Produção(), sender);
        }

        private void relatoriosPorServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirNovoFormulario(new SGPropriedade3.Form_Relatórios(), sender);
        }
    }
}
