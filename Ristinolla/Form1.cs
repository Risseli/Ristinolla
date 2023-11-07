using Newtonsoft.Json;
using Ristinolla;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ristinolla
{
    public partial class FrmRistinolla : Form
    {
        public bool paivitaMuuttujat = false;
        public bool yksinpeli = false;      // luodaan muuttujat joihin tallennetaan pelajaatiedot
        public string P1Etunimi;            // jotka myöhemmin tallennetaan listaan
        public string P1sukunimi;
        public int P1Voitot = 0;
        public int P1Tappiot = 0;
        public int P1Tasapelit = 0;
        public double P1Peliaika = 0;
        public string P2Etunimi;
        public string P2sukunimi;
        public int P2Voitot = 0;
        public int P2Tappiot = 0;
        public int P2Tasapelit = 0;
        public double P2Peliaika = 0;

        public int P1syntymaPaiva;
        public int P2syntymaPaiva;
        public Stopwatch stopwatch = new Stopwatch(); // Mitataan pelattu aika                            
        Random rnd = new Random();                    // random muuttuja AI:lle
        List<Panel> panels;                            // luodaan lista paneeleille
        public int klikkaukset = 0;         // klikkaukset, pariton on aloittaja, eli X. Parillinen on toinen pelaaja 0.  

        public static List<PelaajaTiedot> tiedot = new List<PelaajaTiedot>();  // luodaan lista pelaajien tiedoista


        public static string pelaajatiedotfile = "pelaajatiedot.json";


        public void SerializeJSON(List<PelaajaTiedot> input)            // Lukee listan tiedostoon
        {
            string json = JsonConvert.SerializeObject(input);
            //write string to file
            System.IO.File.WriteAllText(pelaajatiedotfile, json);
        }


        public List<PelaajaTiedot> DeserializeJSON()                    // lukee tiedostosta
        {
            if (File.Exists(pelaajatiedotfile))
            {
                using (StreamReader r = new StreamReader(pelaajatiedotfile))
                {
                    string json = r.ReadToEnd();
                    return JsonConvert.DeserializeObject<List<PelaajaTiedot>>(json);
                }
            }
            else
                return null;
        }
        public void Nollaamuuttujat()
        {
            P1Tappiot = 0; P1Tasapelit = 0; P1Voitot = 0; P1Peliaika = 0; stopwatch.Reset();     // tarvitaanko tätä? poistetaan jos turha..
            P2Tappiot = 0; P2Tasapelit = 0; P2Voitot = 0; P2Peliaika = 0;

        }
        public void NollaaTekstikentat()
        {
            lblP1Tasapelit.Text = "0";
            lblP1Voitot.Text = "0";
            lblP1Tappiot.Text = "0";
            lblP1Peliaika.Text = "00:00:00";

            lblP2Tasapelit.Text = "0";
            lblP2Voitot.Text = "0";
            lblP2Tappiot.Text = "0";
            lblP2Peliaika.Text = "00:00:00";
        }

        public void LisaaListaan()
        {
            if (tiedot == null)
                tiedot = new List<PelaajaTiedot>();     // luodaan uusi lista jos lista tyhjennetään välillä

            PelaajaTiedot p1 = new PelaajaTiedot();
            PelaajaTiedot p2 = new PelaajaTiedot();

            p1.Etunimi = P1Etunimi;                 // määritellään pelaajalle p1 muuttujat
            p1.Sukunimi = P1sukunimi;
            p1.Tappiot = P1Tappiot;
            p1.Voitot = P1Voitot;
            p1.Tasapelit = P1Tasapelit;
            p1.PelattuAika = P1Peliaika;
            p1.Syntymapaiva = P1syntymaPaiva;

            p2.Etunimi = P2Etunimi;                 // määritellään pelaajalle p2 muuttujat
            p2.Sukunimi = P2sukunimi;
            p2.Syntymapaiva = P2syntymaPaiva;
            p2.Tappiot = P2Tappiot;
            p2.Voitot = P2Voitot;
            p2.Tasapelit = P2Tasapelit;
            p2.PelattuAika = P2Peliaika;


            if (tiedot.Count == 0)      // tutkitaan onko listalla henkilöitä, jos ei lisätään pelaajat p1 ja p2

            {
                tiedot.Add(p1);
                tiedot.Add(p2);
            }

            else if (tiedot.Count > 0)   // jos on pelaajia tutkitaan loopissa onko samannimisiä pelaajia jo listalla
            {

                for (int i = 0; i < tiedot.Count; i++)
                {
                    if ((tiedot.Count > 0 && tiedot[i].Etunimi == P1Etunimi) && (tiedot[i].Sukunimi == P1sukunimi) && (tiedot[i].Syntymapaiva == P1syntymaPaiva))
                    {
                        // käydään for loopissa läpi onko pelaaja jo listalla ja lisätään voitot/tappiot/tasapelit sekä peliaika

                        p1.Tappiot += tiedot[i].Tappiot;
                        p1.Voitot += tiedot[i].Voitot;
                        p1.Tasapelit += tiedot[i].Tasapelit;
                        p1.PelattuAika += tiedot[i].PelattuAika;

                        tiedot.RemoveAt(i);                              // poistetaan duplikaatti

                    }
                }

                for (int i = 0; i < tiedot.Count; i++)
                {
                    if ((tiedot[i].Etunimi == P2Etunimi) && (tiedot[i].Sukunimi == P2sukunimi) && (tiedot[i].Syntymapaiva == P2syntymaPaiva))

                    { // käydään for loopissa läpi onko pelaaja jo listalla ja lisätään voitot/tappiot/tasapelit sekä peliaika

                        p2.Tappiot += tiedot[i].Tappiot;
                        p2.Voitot += tiedot[i].Voitot;
                        p2.Tasapelit += tiedot[i].Tasapelit;
                        p2.PelattuAika += tiedot[i].PelattuAika;

                        tiedot.RemoveAt(i);                         // poistetaan duplikaatti
                    }
                }
                tiedot.Add(p1);                 // lisätään pelaaja p1 sekä p2 listaan kun muuttujat päivitetty
                tiedot.Add(p2);
            }
        }

        // Piirretään ympyrä tässä funktiossa ja määritetään taustaväri
        public void PiirraYmpyra(Panel p)
        {
            p.BackColor = Color.LightSalmon;
            p.Refresh();
            Pen blackpen = new Pen(Color.Black, 4);
            Graphics panelGraphics;
            panelGraphics = p.CreateGraphics();
            RectangleF rect = new RectangleF(25.0F, 10.0F, 80, 80);
            panelGraphics.DrawEllipse(blackpen, rect);
            panelGraphics.Dispose();
            p.AccessibleName = "O";             // määritetäään paneelille AccessibleNAme "O"

        }
        // Piirretään rasti tässä funktiossa ja määritetään taustaväri 
        public void PiirraRasti(Panel p)
        {
            p.BackColor = Color.LightBlue;
            p.Refresh();
            Pen blackPen = new Pen(Color.Black, 4);
            Graphics panelGraphics;
            panelGraphics = p.CreateGraphics();
            panelGraphics.DrawLine(blackPen, 0, 0, ClientSize.Width, 600);
            panelGraphics.DrawLine(blackPen, 125, 0, 0, 95);
            panelGraphics.Dispose();
            p.AccessibleName = "X";             // määritetäään paneelille AccessibleNAme "X"

        }
        public FrmRistinolla()
        {
            InitializeComponent();
            panelA1.Enabled = false;            // alussa pelattavat paneelit ovat pois käytöstä
            panelA2.Enabled = false;
            panelA3.Enabled = false;
            panelB1.Enabled = false;
            panelB2.Enabled = false;
            panelB3.Enabled = false;
            panelC1.Enabled = false;
            panelC2.Enabled = false;
            panelC3.Enabled = false;
            
            nollaaPeli();

            lblPelaaja1.Visible = false;
            lblPelaaja2.Visible = false;

            tiedot = DeserializeJSON();             // luetaan tiedostosta pelaajat listaan

            if (tiedot == null)                       // Jos pelaajatiedostossa ei pelaajia luodaan uusi lista
                tiedot = new List<PelaajaTiedot>();

        }
        private void nollaaPeli()
        {
            klikkaukset = 0;
           
            lataaLista();
            foreach (Panel p in panels)
            {
                p.BackColor = DefaultBackColor;
                p.Refresh();
                p.Invalidate();
                p.AccessibleName = null;  
            }

            lblPelaaja1vuoro.Visible = true;
            lblPelaaja2vuoro.Visible = false;
            
        }

        private void lataaLista() // lataa pelattavat paneelit listaan
        {
            panels = new List<Panel> { panelA1, panelA2, panelA3, panelB1, panelB2, panelB3, panelC1, panelC2, panelC3 };

        }

        // yksinpelivalinta luodaan pelaajat pelaaja 1 ja pelaaja 2. Alustetaan fieldit pelaajille sekä näytetään pelaajien nimet
        // labeleissa. Ladataan paneelit ja nollataan muuuttujat
        private void yksinpeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paivitaMuuttujat = false;
            Nollaamuuttujat();
            nollaaPeli();
            NollaaTekstikentat();
            PelaajaTiedot pelaaja1 = new PelaajaTiedot();               
            PelaajaTiedot pelaaja2 = new PelaajaTiedot();

            FrmTiedot frmtiedot = new FrmTiedot(pelaaja1, pelaaja2);
            frmtiedot.ShowDialog();

            P1Etunimi = pelaaja1.Etunimi;                          
            P1sukunimi = pelaaja1.Sukunimi;
            P1syntymaPaiva = pelaaja1.Syntymapaiva;
            P1Peliaika = pelaaja1.PelattuAika;
            klikkaukset = 0;
            P2Etunimi = pelaaja2.Etunimi;
            P2sukunimi = pelaaja2.Sukunimi;
            P2Peliaika = pelaaja2.PelattuAika;
            P2syntymaPaiva = 1956;                               // wikipedian mukaan tekoälyn syntymävuosi =)

            lblPelaaja1.Visible = true;
            lblPelaaja2.Visible = true;

            lblPelaaja1.Text = P1Etunimi;
            lblPelaaja2.Text = P2Etunimi;                                        
            
                paneelitPelattavaksi();
                yksinpeli = true;
                Nollaamuuttujat();
                stopwatch.Start();
            

        }
        // Kaksinpeli valinta 
        private void kaksinpeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paivitaMuuttujat = false;
            Nollaamuuttujat();
            nollaaPeli();
            NollaaTekstikentat();
            
            PelaajaTiedot pelaaja1 = new PelaajaTiedot();
            PelaajaTiedot pelaaja2 = new PelaajaTiedot();
            FrmKaksinpeliTiedot frmKaksinpelitiedot = new FrmKaksinpeliTiedot(pelaaja1, pelaaja2);
            frmKaksinpelitiedot.ShowDialog();

            P1Etunimi = pelaaja1.Etunimi;
            P1sukunimi = pelaaja1.Sukunimi;
            P1syntymaPaiva = pelaaja1.Syntymapaiva;
            P1Peliaika = pelaaja1.PelattuAika;

            P2Etunimi = pelaaja2.Etunimi;
            P2sukunimi = pelaaja2.Sukunimi;
            P2syntymaPaiva = pelaaja2.Syntymapaiva;
            P2Peliaika = pelaaja2.PelattuAika;

            lblPelaaja1.Text = P1Etunimi;
            lblPelaaja2.Text = P2Etunimi;
            lblPelaaja1.Visible = true;
            lblPelaaja2.Visible = true;
            
           
                paneelitPelattavaksi();
                yksinpeli = false;
                stopwatch.Start();
            
        }

        // tekoälylle oma funktio jossa tarkistetaan mmyös onko voittomahdollisuutta tai voiko blokata toisen pelaajan
        public void AIpeli(object sender, EventArgs e) 
        {
           
            Panel p = new Panel();
            if (panels.Count > 0)
            {
                
                klikkaukset++;
               
                // arvotaan AI pelaajalle miettimisaika
                int aika = rnd.Next(3);
                if (aika == 0)
                {
                    AImoves.Interval = 500;
                }
                else if (aika == 1)
                {
                    AImoves.Interval = 800;
                }
                else if (aika == 2)
                {
                    AImoves.Interval =1500;
                }
                else if (aika == 3)
                {
                    AImoves.Interval = 2300;
                }
                // tarkistetaan onko voittomahdollisuutta vaakariveillä ja piirretään ympyrä jos on. Samalla poistetaan paneeli 
                // listalta sekä tarkistetaan voitto
               if (panelA1.AccessibleName == "O" && panelA2.AccessibleName == "O" && panelA3.AccessibleName == null)           // tarkistetaan  vaakatasossa A1,B1,C1 / A2,B2,C2 / A3,B3,C3
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == "O" && panelA2.AccessibleName == null && panelA3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA2);
                    panels.Remove(panelA2);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == null && panelA2.AccessibleName == "O" && panelA3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                    Tarkista();
                }
                else if (panelB1.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelB3.AccessibleName == null)
                {
                    PiirraYmpyra(panelB3);
                    panels.Remove(panelB3);
                    Tarkista();
                }
                else if (panelB1.AccessibleName == "O" && panelB2.AccessibleName == null && panelB3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    Tarkista();
                }
                else if (panelB1.AccessibleName == null && panelB2.AccessibleName == "O" && panelB3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB1);
                    panels.Remove(panelB1);
                    Tarkista();
                }
                else if (panelC1.AccessibleName == "O" && panelC2.AccessibleName == "O" && panelC3.AccessibleName == null)
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                    Tarkista();
                }
                else if (panelC1.AccessibleName == "O" && panelC2.AccessibleName == null && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelC2);
                    panels.Remove(panelC2);
                    Tarkista();
                }
                else if (panelC1.AccessibleName == null && panelC2.AccessibleName == "O" && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);
                    Tarkista();
                }

                //Tarkistetaan voittomahdollisuudet pystyriveiltä
                else if (panelA1.AccessibleName == "O" && panelB1.AccessibleName == "O" && panelC1.AccessibleName == null)       // tarkistetaa pystyrivit A1,B1,C1 / A2,B2,C2 / A3,B3,C3
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == "O" && panelB1.AccessibleName == null && panelC1.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB1);
                    panels.Remove(panelB1);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == null && panelB1.AccessibleName == "O" && panelC1.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                    Tarkista();
                }
                else if (panelA2.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC2.AccessibleName == null)
                {
                    PiirraYmpyra(panelC2);
                    panels.Remove(panelC2);
                    Tarkista();
                }
                else if (panelA2.AccessibleName == "O" && panelB2.AccessibleName == null && panelC2.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    Tarkista();
                }
                else if (panelA2.AccessibleName == null && panelB2.AccessibleName == "O" && panelC2.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA2);
                    panels.Remove(panelA2);
                    Tarkista();
                }
                else if (panelA3.AccessibleName == "O" && panelB3.AccessibleName == "O" && panelC3.AccessibleName == null)
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                    Tarkista();
                }
                else if (panelA3.AccessibleName == "O" && panelB3.AccessibleName == null && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB3);
                    panels.Remove(panelB3);
                    Tarkista();
                }
                else if (panelA3.AccessibleName == null && panelB3.AccessibleName == "O" && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                    Tarkista();
                }

                //Tarkistetaan voittomahdollisuudet diagonaalisti
                else if (panelA1.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC3.AccessibleName == null)       // tarkistetaan diagonaalit A1,B2,C3
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == "O" && panelB2.AccessibleName == null && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    Tarkista();
                }
                else if (panelA1.AccessibleName == null && panelB2.AccessibleName == "O" && panelC3.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                    Tarkista();
                }

                else if (panelA3.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC1.AccessibleName == null)      // tarkistetaan diagonaalit A3,B2,C1
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);
                    Tarkista();
                }
                else if (panelA3.AccessibleName == "O" && panelB2.AccessibleName == null && panelC1.AccessibleName == "O")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    Tarkista();
                }
                else if (panelA3.AccessibleName == null && panelB2.AccessibleName == "O" && panelC1.AccessibleName == "O")
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                    Tarkista();

                }

                // --------------------------------------------------------------------------
                // Tarkistetaan voidaanko blokata toinen pelaaja vaakarivit

                if (panelA1.AccessibleName == "X" && panelA2.AccessibleName == "X" && panelA3.AccessibleName == null)           // tarkistetaan  vaakatasossa A1,B1,C1 / A2,B2,C2 / A3,B3,C3
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                   
                }
                else if (panelA1.AccessibleName == "X" && panelA2.AccessibleName == null && panelA3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA2);
                    panels.Remove(panelA2);
                   
                }
                else if (panelA1.AccessibleName == null && panelA2.AccessibleName == "X" && panelA3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                   
                }
                else if (panelB1.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelB3.AccessibleName == null)
                {
                    PiirraYmpyra(panelB3);
                    panels.Remove(panelB3);
                   
                }
                else if (panelB1.AccessibleName == "X" && panelB2.AccessibleName == null && panelB3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                   
                }
                else if (panelB1.AccessibleName == null && panelB2.AccessibleName == "X" && panelB3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB1);
                    panels.Remove(panelB1);
                   
                }
                else if (panelC1.AccessibleName == "X" && panelC2.AccessibleName == "X" && panelC3.AccessibleName == null)
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                  
                }
                else if (panelC1.AccessibleName == "X" && panelC2.AccessibleName == null && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelC2);
                    panels.Remove(panelC2);         
                }
                else if (panelC1.AccessibleName == null && panelC2.AccessibleName == "X" && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);                   
                }

                //Tarkistetaan voidaanko blokata toinen pelaaja pystyrivit
                else if (panelA1.AccessibleName == "X" && panelB1.AccessibleName == "X" && panelC1.AccessibleName == null)       // tarkistetaa pystyrivit A1,B1,C1 / A2,B2,C2 / A3,B3,C3
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);
                    
                }
                else if (panelA1.AccessibleName == "X" && panelB1.AccessibleName == null && panelC1.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB1);
                    panels.Remove(panelB1);
                   
                }
                else if (panelA1.AccessibleName == null && panelB1.AccessibleName == "X" && panelC1.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                   
                }
                else if (panelA2.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC2.AccessibleName == null)
                {
                    PiirraYmpyra(panelC2);
                    panels.Remove(panelC2);
                   
                }
                else if (panelA2.AccessibleName == "X" && panelB2.AccessibleName == null && panelC2.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    
                }
                else if (panelA2.AccessibleName == null && panelB2.AccessibleName == "X" && panelC2.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA2);
                    panels.Remove(panelA2);
                    
                }
                else if (panelA3.AccessibleName == "X" && panelB3.AccessibleName == "X" && panelC3.AccessibleName == null)
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                    
                }
                else if (panelA3.AccessibleName == "X" && panelB3.AccessibleName == null && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB3);
                    panels.Remove(panelB3);
                   
                }
                else if (panelA3.AccessibleName == null && panelB3.AccessibleName == "X" && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                    
                }

                //Tarkistetaan Voidaanko blokata diagonaalisti
                else if (panelA1.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC3.AccessibleName == null)       // tarkistetaan diagonaalit A1,B2,C3
                {
                    PiirraYmpyra(panelC3);
                    panels.Remove(panelC3);
                   
                }
                else if (panelA1.AccessibleName == "X" && panelB2.AccessibleName == null && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                   
                    
                }
                else if (panelA1.AccessibleName == null && panelB2.AccessibleName == "X" && panelC3.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA1);
                    panels.Remove(panelA1);
                    
                    
                }

                else if (panelA3.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC1.AccessibleName == null)      // tarkistetaan diagonaalit A3,B2,C1
                {
                    PiirraYmpyra(panelC1);
                    panels.Remove(panelC1);
                    
                    
                }
                else if (panelA3.AccessibleName == "X" && panelB2.AccessibleName == null && panelC1.AccessibleName == "X")
                {
                    PiirraYmpyra(panelB2);
                    panels.Remove(panelB2);
                    
                    
                }
                else if (panelA3.AccessibleName == null && panelB2.AccessibleName == "X" && panelC1.AccessibleName == "X")
                {
                    PiirraYmpyra(panelA3);
                    panels.Remove(panelA3);
                    
                    
                }
                else
                {
                    Tarkista();
                    if (klikkaukset > 0)
                    {
                        Tarkista();
                        int luku = rnd.Next(panels.Count);  // arpoo jonkun vapaista paneeleista ja  piirtää arvottuun
                        panels[luku].Enabled = false;
                        PiirraYmpyra(panels[luku]);     // paneeliin ympyrän. Paneeli poistetaan käytöstä sen jälkeen                                                 
                        panels.RemoveAt(luku);           // ettei arvota uudelleen samaa paneelia
                    }
                                                        
                }
                                          
                             
                Tarkista();                         
                AImoves.Stop();
                lblPelaaja1vuoro.Visible = true;
                lblPelaaja2vuoro.Visible = false;

            }
        }

        private void paneelitPelattavaksi() // paneelit avataan pelattavaksi
        {
            panelA1.Enabled = true;
            panelA2.Enabled = true;
            panelA3.Enabled = true;
            panelB1.Enabled = true;
            panelB2.Enabled = true;
            panelB3.Enabled = true;
            panelC1.Enabled = true;
            panelC2.Enabled = true;
            panelC3.Enabled = true;

        }

        private void aloitaUusi()   // aloita uusi peli funktio
        {
            LisaaListaan();
            SerializeJSON(tiedot);
            stopwatch.Start();
            paivitaMuuttujat = true;
            nollaaPeli();
            paneelitPelattavaksi();
            Nollaamuuttujat();
            klikkaukset = 0;
        }

        // click event kaikille paneeleille, sender antaa tiedon mihin paneeliin toiminto kohdistuu
        private void panelA1_Click(object sender, EventArgs e)
        {
            
            klikkaukset++;
             
            Panel p = (Panel)sender;

            if (klikkaukset % 2 == 1 && yksinpeli == true)          // 1. pelaaja pelaa jos yksinpeli
            {
                if (stopwatch.ElapsedMilliseconds <= 0)
                {
                    stopwatch.Start();
                }
                if ((p.AccessibleName != "X") && (p.AccessibleName != "O"))
                {
                    
                    AImoves.Stop();
                    PiirraRasti(p);
                    panels.Remove(p);
                    Tarkista();                                    // tarkistuksen jälkeen ei mennä enää AI vuorolle 
                    if (klikkaukset != 0)                          // jos peli loppunut/aloitettu uudelleen
                                                
                    {
                        AImoves.Start();                            // AI pelaa 
                        Tarkista();
                        panels.Remove(p);
                        lblPelaaja1vuoro.Visible = false;
                        lblPelaaja2vuoro.Visible = true;
                    }
                  
                }
                else
                {
                    klikkaukset--;                                       // jos ruutu jo pelattu vähennetään klikkaus
                }
                
            }
           
            else if (klikkaukset % 2 == 0 && yksinpeli == false)            // 2. pelaaja pelaa jos kaksinpeli
            {
                if (stopwatch.ElapsedMilliseconds <= 0)
                    
                {
                    stopwatch.Start();
                }
                if (p.AccessibleName != "X" && p.AccessibleName != "O")      // tarkistetaan onko ruutu jo pelattu                 
                {
                    PiirraYmpyra(p);
                    Tarkista();
                    panels.Remove(p);
                    lblPelaaja1vuoro.Visible = false;
                    lblPelaaja2vuoro.Visible = true;
                }
                else
                {
                    klikkaukset--;
                }
            }

            else
            {                                                       
                if (klikkaukset % 2 == 1 && yksinpeli == false)                 // 1. pelaaja pelaa jos kaksinpeli
                {
                    if (p.AccessibleName != "X" && p.AccessibleName != "O")     // tarkistetaan onko ruutu jo pelattu
                    {
                        
                        PiirraRasti(p);
                        Tarkista();
                        panels.Remove(p);
                        lblPelaaja1vuoro.Visible = true;
                        lblPelaaja2vuoro.Visible = false;
                        
                    }
                    else
                    {
                        klikkaukset--;
                    }
                        
                }

            }

            if (panels.Count == 0)              // jos kaikki paneelit on pelattu päädytään tasapeliin
            {
                stopwatch.Stop();   
                P1Tasapelit++;
                P2Tasapelit++;

                if (paivitaMuuttujat == true)
                {
                    int TasapelitP1 = int.Parse(lblP1Tasapelit.Text) + P1Tasapelit;
                    int TasapelitP2 = int.Parse(lblP2Tasapelit.Text) + P2Tasapelit;

                    lblP1Tasapelit.Text = TasapelitP1.ToString();
                    lblP2Tasapelit.Text = TasapelitP2.ToString();
                }
                else
                {
                    lblP1Tasapelit.Text = P1Tasapelit.ToString();
                    lblP2Tasapelit.Text = P2Tasapelit.ToString();
                }
                
                AImoves.Stop();
                MessageBox.Show("Olitte yhtä hyviä!", "Peli loppui!", MessageBoxButtons.OK);
                aloitaUusi();

            }

        }
        
        private void Tarkista()
        {
            Panel panel = new Panel();
            // tarkistetaan ensin X, voitto mahdollisuudet
            if (panelA1.AccessibleName == "X" && panelA2.AccessibleName == "X" && panelA3.AccessibleName == "X"
               || panelB1.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelB3.AccessibleName == "X"
               || panelC1.AccessibleName == "X" && panelC2.AccessibleName == "X" && panelC3.AccessibleName == "X"
               || panelA1.AccessibleName == "X" && panelB1.AccessibleName == "X" && panelC1.AccessibleName == "X"
               || panelA2.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC2.AccessibleName == "X"
               || panelA3.AccessibleName == "X" && panelB3.AccessibleName == "X" && panelC3.AccessibleName == "X"
               || panelA1.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC3.AccessibleName == "X"
               || panelA3.AccessibleName == "X" && panelB2.AccessibleName == "X" && panelC1.AccessibleName == "X")
            {
                stopwatch.Stop();
                P1Voitot++;
                P2Tappiot++;
                if (paivitaMuuttujat == true)
                {
                    int VoitotP1 = int.Parse(lblP1Voitot.Text) + P1Voitot;
                    int TappiotP2 = int.Parse(lblP2Tappiot.Text) + P2Tappiot;

                    lblP1Voitot.Text = VoitotP1.ToString();
                    lblP2Tappiot.Text = TappiotP2.ToString();
                }
                else
                {
                    lblP1Voitot.Text = P1Voitot.ToString();
                    lblP2Tappiot.Text = P2Tappiot.ToString();
                }
               // lblP1Voitot.Text = P1Voitot.ToString();
               // lblP2Tappiot.Text = P2Tappiot.ToString();
                AImoves.Stop();
                MessageBox.Show(P1Etunimi  + " voitti pelin", "Peli loppui!", MessageBoxButtons.OK);
                klikkaukset = 0;
                aloitaUusi();
            }

            // tarkistetaan O, voitto mahdollisuudet
            else if (panelA1.AccessibleName == "O" && panelA2.AccessibleName == "O" && panelA3.AccessibleName == "O"
               || panelB1.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelB3.AccessibleName == "O"
               || panelC1.AccessibleName == "O" && panelC2.AccessibleName == "O" && panelC3.AccessibleName == "O"
               || panelA1.AccessibleName == "O" && panelB1.AccessibleName == "O" && panelC1.AccessibleName == "O"
               || panelA2.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC2.AccessibleName == "O"
               || panelA3.AccessibleName == "O" && panelB3.AccessibleName == "O" && panelC3.AccessibleName == "O"
               || panelA1.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC3.AccessibleName == "O"
               || panelA3.AccessibleName == "O" && panelB2.AccessibleName == "O" && panelC1.AccessibleName == "O")
            {
              
                stopwatch.Stop();
                P2Voitot++;
                P1Tappiot++;
                if (paivitaMuuttujat == true)
                {
                    int VoitotP2 = int.Parse(lblP2Voitot.Text) + P2Voitot;              /// jos ei vaiihdeta pelaajia päivitetääm
                    int TappiotP1 = int.Parse(lblP1Tappiot.Text) + P1Tappiot;           // päivitetään voitot/tappiot ja tasapeli tekstikentät 

                    lblP2Voitot.Text = VoitotP2.ToString();
                    lblP1Tappiot.Text = TappiotP1.ToString();
                }
                else
                {
                    lblP2Voitot.Text = P2Voitot.ToString();
                    lblP1Tappiot.Text = P1Tappiot.ToString();
                }
                
                AImoves.Stop();
                MessageBox.Show(P2Etunimi + " voitti pelin", "Peli loppui!", MessageBoxButtons.OK);
                
                klikkaukset = 0;
                aloitaUusi();
            }

        }

        private void tilastotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTilastot frmtilastot = new FrmTilastot();
            frmtilastot.Show();
        }

        private void timerPeliaika_Tick(object sender, EventArgs e)
        {
            double peliaikaSekunneissa = stopwatch.Elapsed.TotalSeconds;

           
            this.lblP1Peliaika.Text = peliaikaSekunneissa.ToString();
            this.lblP2Peliaika.Text = peliaikaSekunneissa.ToString();

            lblP1Peliaika.Text = $"{stopwatch.ElapsedMilliseconds / 1000}";
            lblP2Peliaika.Text = $"{stopwatch.ElapsedMilliseconds / 1000}";

           
           lblP1Peliaika.Text = String.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);
           lblP2Peliaika.Text = String.Format("{0:00}:{1:00}:{2:00}", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds);

            P1Peliaika = peliaikaSekunneissa;
            P2Peliaika = peliaikaSekunneissa;
        }

        private void infoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Käyttöliittymäohjelmoinnin näytetyö." + "\r" + "Tekijät Risto Rytilahti & Riku Ovaskainen", "Info");
        }

        private void lopetaPeliToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (P1Etunimi != null)       // tarkistetaan onko peliä aloitettu, jos ei niin suljetaan ohjelma tallentamatta
            {
                MessageBox.Show("Tallennetaanko pelaajien voitot?", "Tallennus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    LisaaListaan();
                    SerializeJSON(tiedot);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
                
                Application.Exit();
        }

        private void btn1PUusipeli_Click(object sender, EventArgs e)
        {
            if (P1Voitot > 0 || P1Tappiot > 0 || P1Tasapelit > 0 )   // Tarkistetaan onko tallennettavia tietoja, jos on
                                                                     // kysytään  tallennetaanko
            {
                MessageBox.Show("Tallennetaanko pelaajien voitot?", "Tallennus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    LisaaListaan();
                    SerializeJSON(tiedot);
                    Nollaamuuttujat();
                    NollaaTekstikentat();
                }
                else
                {
                   
                }

            }
            yksinpeliToolStripMenuItem.PerformClick();

        }
        private void btnP2Uusipeli_Click(object sender, EventArgs e)
        {
            if ((P1Voitot > 0 || P1Tasapelit > 0 || P2Voitot > 0 || P2Tappiot > 0))
            {
                MessageBox.Show("Tallennetaanko pelaajien voitot?", "Tallennus", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    LisaaListaan();
                    SerializeJSON(tiedot);
                    Nollaamuuttujat();
                    NollaaTekstikentat();
                }
                else
                {
                    
                }

            }
            kaksinpeliToolStripMenuItem.PerformClick();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (P1Etunimi != null)                                      // tarkistetaan onko peliä aloitettu, jos ei niin suljetaan ohjelma tallentamatta
            {
                MessageBox.Show("Tallennetaanko pelaajien voitot?", "Tallennus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    LisaaListaan();
                    SerializeJSON(tiedot);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
                Application.Exit();
        }

        private void btnLopeta_Click_1(object sender, EventArgs e)
        {
            if (P1Etunimi != null)                                      // tarkistetaan onko peliä aloitettu, jos ei niin suljetaan ohjelma tallentamatta
            {
                MessageBox.Show("Tallennetaanko pelaajien voitot?", "Tallennus", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (DialogResult == DialogResult.Yes)
                {
                    LisaaListaan();
                    SerializeJSON(tiedot);
                    Application.Exit();
                }
                else
                {
                    Application.Exit();
                }
            }
            else
                Application.Exit();
        }
    }
}



