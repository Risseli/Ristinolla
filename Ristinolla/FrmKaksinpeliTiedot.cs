using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ristinolla
{
    public partial class FrmKaksinpeliTiedot : Form
    {
        PelaajaTiedot PelaajaTiedot;
        PelaajaTiedot PelaajaTiedot2;

        public void TiedotOk()
        {
            PelaajaTiedot.Etunimi = tbEtunimiPelaaja1.Text;
            PelaajaTiedot.Sukunimi = tbSukunimiPelaaja1.Text;
            PelaajaTiedot.Syntymapaiva = int.Parse(nudP1.Text);
            PelaajaTiedot2.Etunimi = tbEtunimiPelaaja2.Text;
            PelaajaTiedot2.Sukunimi = tbSukunimiPelaaja2.Text;
            PelaajaTiedot2.Syntymapaiva = int.Parse(nudP2.Text);

            if ((tbEtunimiPelaaja1.Text != "") && (tbSukunimiPelaaja1.Text != "") && (tbEtunimiPelaaja2.Text != "" && tbSukunimiPelaaja2.Text != ""))
            
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Anna pelaajien tiedot", "Tiedot puuttuu", MessageBoxButtons.OK,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button1);
            }

        }

        public bool ValidNimi(string sNimi, out string msg)
        {

            {
                if (sNimi.Trim().Length == 0) // Trim poistaa alusta ja lopusta välilyönnit
                {
                    msg = "Anna ainakin yksi merkki!";
                    return false;
                }
                msg = string.Empty;
                return true;

            }
        }

        
        public FrmKaksinpeliTiedot(PelaajaTiedot p1, PelaajaTiedot p2) // viedään pelaajat p1, p2 parameterina Form1 lomakkeelle
        {
            InitializeComponent();
            PelaajaTiedot = p1;
            PelaajaTiedot2 = p2;

            p1.Etunimi = tbEtunimiPelaaja1.Text;
            p1.Sukunimi = tbSukunimiPelaaja1.Text;
            p1.Syntymapaiva = int.Parse(nudP1.Text);

            p2.Etunimi = tbEtunimiPelaaja2.Text;
            p2.Sukunimi = tbSukunimiPelaaja2.Text;
            p2.Syntymapaiva = int.Parse(nudP2.Text);
          
        }
            //  määritellään muuttujiin arvot
        private void btnOk_Click(object sender, EventArgs e)
        {
            TiedotOk();
           
        }

        private void tbEtunimiPelaaja1_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(tbEtunimiPelaaja1, String.Empty);
        }

        private void tbSukunimiPelaaja1_Validated(object sender, EventArgs e)
        {

            errorProvider1.SetError(tbEtunimiPelaaja1, String.Empty);
        }

        private void tbEtunimiPelaaja2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEtunimiPelaaja1, String.Empty);
        }

        private void tbSukunimiPelaaja2_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEtunimiPelaaja1, String.Empty);
        }

        private void tbEtunimiPelaaja1_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbEtunimiPelaaja1.Text, out msg))
                e.Cancel = true;
            tbEtunimiPelaaja1.Select(0, tbEtunimiPelaaja1.Text.Length);
            this.errorProvider1.SetError(tbEtunimiPelaaja1, msg);
        }

        private void tbSukunimiPelaaja1_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbSukunimiPelaaja1.Text, out msg))
                e.Cancel = true;
            tbSukunimiPelaaja1.Select(0, tbSukunimiPelaaja1.Text.Length);
            this.errorProvider1.SetError(tbSukunimiPelaaja1, msg);
        }

        private void tbEtunimiPelaaja2_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbEtunimiPelaaja2.Text, out msg))
                e.Cancel = true;
            tbEtunimiPelaaja2.Select(0, tbEtunimiPelaaja2.Text.Length);
            this.errorProvider1.SetError(tbEtunimiPelaaja2, msg);
        }

        private void tbSukunimiPelaaja2_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbSukunimiPelaaja2.Text, out msg))
                e.Cancel = true;
            tbSukunimiPelaaja2.Select(0, tbSukunimiPelaaja2.Text.Length);
            this.errorProvider1.SetError(tbSukunimiPelaaja2, msg);

        } 
       

        private void nudP1_Enter(object sender, EventArgs e)
        {
            nudP1.Select(0, nudP1.Text.Length);                     // Valitsee takstikentässä olevan tekstin 
        }

        private void nudP2_Enter(object sender, EventArgs e)
        {
            nudP2.Select(0, nudP2.Text.Length);                      // Valitsee takstikentässä olevan tekstin 
        }
    }
}
