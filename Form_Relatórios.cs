using Microsoft.Reporting.WinForms;
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
    public partial class Form_Relatórios : Form
    {
        private string relatorio;

        RegrasNegocio.RN_Relatorios relatorios ;
        public Form_Relatórios()
        {
            InitializeComponent();
        }

        private void Form_Relatórios_Load(object sender, EventArgs e)
        {



            this.reportViewer1.RefreshReport();
        }

        private void ConsultarRelatorioServiços(DateTime dataInicioConsulta , DateTime dataFimConsulta)
        {


            relatorios = new RegrasNegocio.RN_Relatorios();
            ReportDataSource ds;

            switch (relatorio)
            {
                

                case "Relatório_Serviçosrdlc.rdlc":

                    relatorios.Relatorios_Por_Serviços(dataInicioConsulta, dataFimConsulta);
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioServiços", relatorios.RelatoriosServiços);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;

                    break;

                case "Relatorio_Produção.rdlc":

                    relatorios.Relatorio_Produção(dataInicioConsulta, dataFimConsulta, "", "", "");
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioProdução", relatorios.RelatorioProdução);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;

                    break;

                case  "Relatório_Faturamento.rdlc":
                    relatorios.Relatorio_Faturamento(dataInicioConsulta, dataFimConsulta);
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioFaturamento", relatorios.RelatorioFaturamento);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;
                    break;

                case "Relatorio_Insumos.rdlc":
                    relatorios.Relatorios_de_Insumos(dataInicioConsulta, dataFimConsulta);
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioInsumos", relatorios.RelatorioInsumos);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;
                    break;

                case "Relatorio_de_Ferramentas_e_Manutenção.rdlc":

                    relatorios.Relatorios_de_Ferramentas(dataInicioConsulta, dataFimConsulta);
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioFerramentas", relatorios.RelatorioFerramenta);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioManutenções", relatorios.RelatorioManutenção);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;

                    break;

                case "Relatorio_Completo.rdlc":
                    relatorios.Relatorio_Completo(dataInicioConsulta, dataFimConsulta);
                    RN_RelatoriosBindingSource.DataSource = relatorios;
                    ds = new ReportDataSource("DataSetRelatorioServiços", relatorios.RelatoriosServiços);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioProdução", relatorios.RelatorioProdução);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioFaturamento", relatorios.RelatorioFaturamento);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioInsumos", relatorios.RelatorioInsumos);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioFerramentas", relatorios.RelatorioFerramenta);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioFaturamento", relatorios.RelatorioFerramenta);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    ds = new ReportDataSource("DataSetRelatorioRendimento", relatorios.RelatorioFerramenta);
                    reportViewer1.LocalReport.DataSources.Add(ds);
                    reportViewer1.LocalReport.ReportEmbeddedResource = "SgPropriedade_3._0." + relatorio;
                    break;
                default:
                    break;


            }

            reportViewer1.RefreshReport();
        }

        private void Consulta_entervalos_pre_Progrmados(int dias)
        {
            DateTime dataInicioConsulta;
            DateTime dataFimConsulta;

            dataInicioConsulta = DateTime.Today.AddDays(dias);
            dataFimConsulta = DateTime.Today;

            ConsultarRelatorioServiços(dataInicioConsulta, dataFimConsulta);
        }

        private void btn7dias_Click(object sender, EventArgs e)
        {
            Consulta_entervalos_pre_Progrmados(-7);
        }

        private void btn30dias_Click(object sender, EventArgs e)
        {
            Consulta_entervalos_pre_Progrmados(-30);
        }

        private void btn90dias_Click(object sender, EventArgs e)
        {
            Consulta_entervalos_pre_Progrmados(-90);
        }

        private void btn1ano_Click(object sender, EventArgs e)
        {
            Consulta_entervalos_pre_Progrmados(-365);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            ConsultarRelatorioServiços(Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
        }

        private void btnServiços_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatório_Serviçosrdlc.rdlc";
            btnServiços.BackColor = Color.Teal;

        }

        private void btnProdução_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatorio_Produção.rdlc";
            btnProdução.BackColor = Color.Teal;
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatório_Faturamento.rdlc";
            btnFinanceiro.BackColor = Color.Teal;
        }

        private void btnInsumos_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatorio_Insumos.rdlc";
            btnInsumos.BackColor = Color.Teal;
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatorio_de_Ferramentas_e_Manutenção.rdlc";
            btnFerramentas.BackColor = Color.Teal;
        }

        private void btnRelatórioCompleto_Click(object sender, EventArgs e)
        {
            LimparCores();
            relatorio = "Relatorio_Completo.rdlc";
            btnRelatórioCompleto.BackColor = Color.Teal;

        }

        private void LimparCores()
        {
            btnServiços.BackColor = Color.FromArgb(87, 192, 188);
            btnProdução.BackColor = Color.FromArgb(87, 192, 188);
            btnInsumos.BackColor = Color.FromArgb(87, 192, 188);
            btnFinanceiro.BackColor = Color.FromArgb(87, 192, 188);
            btnFerramentas.BackColor = Color.FromArgb(87, 192, 188);
            btnRelatórioCompleto.BackColor = Color.FromArgb(87, 192, 188);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
