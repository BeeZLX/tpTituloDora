using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTituloEleitor_230610
{
    internal class validaTitulo
    {
        #region Validar Titulo
        public static Boolean ValidaTitulo(string TT, System.Windows.Forms.Label lbl)
        {
            if (TT.Length != 12)
            {
                return false;
            }

            int somaum = 0;
            int somadois = 0;

            #region Verificador um
            for (int i = 0; i < 8; i++)
            {
                int valorum = int.Parse(TT[i].ToString());
                somaum += valorum * (i + 2);
            }
            int DvUm = somaum % 11;
            #endregion

            #region Verificador dois
            somadois += DvUm * 7;

            for (int i = 8; i < 11; i++)
            {
                int valordois = int.Parse(TT[i].ToString());
                somadois += valordois * (i - 1);
            }
            int DVdois = somadois % 11;
            #endregion
            lbl.Text = Convert.ToString(somadois);
            return (DvUm == int.Parse(TT[8].ToString()) && DVdois == int.Parse(TT[11].ToString()));
        }
        #endregion
    }
}