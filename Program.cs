using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPropriedade3
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

            RegrasNegocio.RN_CriarBancoDeDados rN_CriarBancoDeDados = new RegrasNegocio.RN_CriarBancoDeDados();

            DataTable listarTabela = new DataTable();
            listarTabela = rN_CriarBancoDeDados.VerificarBanco();
            try
            {
                if (listarTabela.Rows.Count <= 0)
                {
                    rN_CriarBancoDeDados.CriarBancodeDados();
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Logim
                ());
        }
    }
}
