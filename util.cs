using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGPropriedade3
{
   public class util
    {
        /*--------------------------------------
      Classes de formatação de textBox para receber apenas numeros e convertelos em formato de moeda*/

        public static void formatarDecimal(ref System.Windows.Forms.TextBox txtBox)
        {
            string txt = string.Empty;
            double valor = 0;

            try
            {

                txt = txtBox.Text.Replace(",", "").Replace(".", "");
                if (txt.Equals(""))

                    txt = "";
                txt = txt.PadLeft(3, '0');


                if (txt.Length > 3 & txt.Substring(0, 1) == "0")

                    txt = txt.Substring(1, txt.Length - 1);
                valor = Convert.ToDouble(txt) / 100;

                txtBox.Text = string.Format("{0:N}", valor);

                txtBox.SelectionStart = txtBox.Text.Length;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void formatar(ref System.Windows.Forms.TextBox txtBox)
        {
            string txt = string.Empty;
            double valor = 0;

            try
            {

                txt = txtBox.Text.Replace(",", "").Replace(".", "");
                if (txt.Equals(""))

                    txt = "";
                txt = txt.PadLeft(1, '0');


                if (txt.Length > 3 & txt.Substring(0, 1) == "0")

                    txt = txt.Substring(1, txt.Length - 1);
                valor = Convert.ToDouble(txt) / 100;

                txtBox.Text = string.Format("{0:N}", valor);

                txtBox.SelectionStart = txtBox.Text.Length;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void numeros(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        internal static string FormatarMoeda(decimal valor)
        {
           
                return valor.ToString("C");
            
        }
    }
}
