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

    
    public partial class FrmTiedot : Form
    {
        // validointi funktio jossa tarkistetaan onko tekstikentässä merkkejä. Jos ei, antaa kehotuksen korjata ja estää
        // poistumisen tekstikentästä ennen korjausta. Poistetaan samalla tyhjät välilyönnit nimen edestä ja lopusta.
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
       
        // tarkistetaan onko tekstikenttiiin syötetty nimi. Varmistetaan että kaikille pelaajille on syötetty tiedot oikein
        
        public void Laheta()
        { 

            if ((tbEtunimi.Text != "") && (tbSukunimi.Text != ""))
            {
               
                this.Close();
            }
            else
            {
                MessageBox.Show("Anna pelaajien tiedot", "Tiedot puuttuu", MessageBoxButtons.OK);
            }
            
        }

        PelaajaTiedot pelaajatiedot;
        PelaajaTiedot pelaajatiedot2;
        public FrmTiedot(PelaajaTiedot p, PelaajaTiedot p2)
        {
            InitializeComponent();
            pelaajatiedot = p;
            pelaajatiedot2 = p2;
          
           
        }

        // napilla viedään tiedot tekstikentistä muuttujiin
        private void btnOk_Click(object sender, EventArgs e)
        {

            
            pelaajatiedot.Etunimi = tbEtunimi.Text;
            pelaajatiedot.Sukunimi = tbSukunimi.Text;
            pelaajatiedot.Syntymapaiva = int.Parse(nudSyntymaVuosi.Text);
            pelaajatiedot2.Etunimi = "AI";
            pelaajatiedot2.Sukunimi = "AI";
            pelaajatiedot2.Syntymapaiva = 1956;
            
           
            
            Laheta();
        }

        // Tarkistetaan onko tekstikentässä merkkejä
        private void tbEtunimi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbEtunimi, String.Empty);
        }
        // Tarkistetaan onko tekstikentässä merkkejä
        private void tbSukunimi_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbSukunimi, String.Empty);
        }

        private void tbEtunimi_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbEtunimi.Text, out msg))
                e.Cancel = true;
            tbEtunimi.Select(0, tbEtunimi.Text.Length);
            this.errorProvider1.SetError(tbEtunimi, msg);
        }
        // Validoidaan tekstikenttä. Tarkistetaan ValidNimi funktion avulla onko käyttäjä syöttänyt
        // jonkin nimen tai nimimerkin
        private void tbSukunimi_Validating(object sender, CancelEventArgs e)
        {
            string msg = String.Empty;

            if (!ValidNimi(tbSukunimi.Text, out msg))
                e.Cancel = true;
            tbSukunimi.Select(0, tbSukunimi.Text.Length);
            this.errorProvider1.SetError(tbSukunimi, msg);
        }


        // Siirtää osoittimen sukunimen kohdalle kun poistutaan etunimikentästä
        private void tbEtunimi_Leave(object sender, EventArgs e)
        {
            tbSukunimi.Focus();                                                 
        }                                                                       
        private void tbSukunimi_Leave(object sender, EventArgs e)
        {
            nudSyntymaVuosi.Focus();
        }
        // Varmistetaan että käyttäjä syöttää vain kokonaislukuja, pilkut ei sallittu
        private void nudSyntymaVuosi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))    
                e.Handled = true;
        }
        // Valitsee tekstikentässä olevan tekstin automaattisesti
        private void nudSyntymaVuosi_Enter(object sender, EventArgs e)
        {
            nudSyntymaVuosi.Select(0, nudSyntymaVuosi.Text.Length);             
        }
    }
}