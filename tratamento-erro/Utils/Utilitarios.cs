using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tratamento_erro.Utils
{
    public class Utilitarios
    {
        public static void limparTextos(Control.ControlCollection controles)
        {
            //Preparação para apagar qualquer caixa de texto
            foreach(Control obj in controles)
            {
                if (obj is TextBox)
                {
                    TextBox caixa = (TextBox)obj;
                }
            }
        }
    }
}
