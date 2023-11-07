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
    public partial class FrmTilastot : Form
    {
        public FrmTilastot()
        {
            
            InitializeComponent();
            dgvTilastot.DataSource = FrmRistinolla.tiedot;
        }

        private void btnSulje_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnNollaaLista_Click(object sender, EventArgs e)
        {
            dgvTilastot.DataSource = null;
            System.IO.File.Delete(FrmRistinolla.pelaajatiedotfile);
            FrmRistinolla.tiedot = null;
            
        }
    }
}
