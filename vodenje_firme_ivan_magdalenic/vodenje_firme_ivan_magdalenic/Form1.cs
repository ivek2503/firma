/*
 Enkapsulacija je jedno od kljuènih naèela objektno orijentiranog programiranja , koje omoguæuje skrivanje unutarnjih detalja 
objekta od vanjskog svijeta i omoguæuje kontrolirani pristup tim detaljima. Cilj enkapsulacije je ogranièiti pristup i manipulaciju
podacima unutar objekta samo na odreðene metode ili suèelja, èime se poveæava modularnost, sigurnost i održivost programa.

primjer koda: 
using System;

class Osoba
{
    private string ime;
    private int godine;
    public Osoba(string ime, int godine)
    {
        this.ime = ime;
        this.godine = godine;
    }

    public void PrikaziDetalje()
    {
        Console.WriteLine("Ime: "+ime+", Godine: "+godine);
    }
}

class Program
{
    static void Main()
    {

        Osoba osoba = new Osoba("Ana", 18);
        osoba.PrikaziDetalje();
    }
}

 */
using System.Text;

namespace vodenje_firme_ivan_magdalenic
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer timer;
        private List<Firma> listaFirmi = new List<Firma>();

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            dolazak_start.Format = DateTimePickerFormat.Time;
            dolazak_start.ShowUpDown = true;
            dolazak_kraj.Format = DateTimePickerFormat.Time;
            dolazak_kraj.ShowUpDown = true;
            odlazak_start.Format = DateTimePickerFormat.Time;
            odlazak_start.ShowUpDown = true;
            odlazak_kraj.Format = DateTimePickerFormat.Time;
            odlazak_kraj.ShowUpDown = true;
            Console.WriteLine("bok");
        }

        private void InitializeTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label14.Text = "Trenutno vrijeme: " + DateTime.Now.ToString("dd.MM.yyyy. HH:mm:ss");
        }

        private void btn_dodaj_firmu_Click(object sender, EventArgs e)
        {
            int idFirme = Convert.ToInt32(id_firme.Text);
            string nazivFirme = dodaj_firmu.Text;

            TimeSpan pocetakDolaska = dolazak_start.Value.TimeOfDay;
            TimeSpan krajDolaska = dolazak_kraj.Value.TimeOfDay;
            TimeSpan pocetakOdlaska = odlazak_start.Value.TimeOfDay;
            TimeSpan krajOdlaska = odlazak_kraj.Value.TimeOfDay;

            Firma novaFirma = new Firma(idFirme, nazivFirme, pocetakDolaska, krajDolaska, pocetakOdlaska, krajOdlaska);

            listaFirmi.Add(novaFirma);
            if ((!string.IsNullOrEmpty(id_firme.Text) || !string.IsNullOrEmpty(dodaj_firmu.Text)) && !firma.Items.Contains(dodaj_firmu.Text) && !firma.Items.Contains(Convert.ToInt32(id_firme.Text)))
            {
                firma.Items.Add(dodaj_firmu.Text);
                odabir_firme.Items.Add(dodaj_firmu.Text);
                dodaj_firmu.Clear();
                id_firme.Clear();
            }
            else
            {
                MessageBox.Show("Unesite valjani ID i/ili naziv firme koja veæ nije dodana.");
            }
        }

        private void OIB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void id_firme_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dodaj_radnika_Click(object sender, EventArgs e)
        {
            if (firma.SelectedItem != null)
            {
                string odabranoImeFirme = firma.SelectedItem.ToString();
                Firma odabranaFirma = null;

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }

                if (odabranaFirma != null)
                {
                    int oib = Convert.ToInt32(OIB.Text);
                    string Ime = ime.Text;
                    string Prezime = prezime.Text;

                    Radnik noviRadnik = new Radnik(oib, Ime, Prezime, odabranoImeFirme);
                    odabranaFirma.DodajRadnika(noviRadnik);

                    OIB.Clear();
                    ime.Clear();
                    prezime.Clear();
                }
                else
                {
                    MessageBox.Show("Firma nije pronaðena u listi.");
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite firmu.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (odabir_firme.SelectedItem != null && odabir_radnika.SelectedItem != null)
            {
                string odabranoImeFirme = odabir_firme.SelectedItem.ToString();
                string odabraniRadnikPodaci = odabir_radnika.SelectedItem.ToString();

                Firma odabranaFirma = null;

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }

                Radnik odabraniRadnik = null;
                foreach (Radnik radnik in odabranaFirma.DohvatiListuRadnika())
                {
                    if (radnik.podaci() == odabraniRadnikPodaci)
                    {
                        odabraniRadnik = radnik;
                        break;
                    }
                }

                if (odabranaFirma != null && odabraniRadnik != null)
                {
                    Dictionary<DayOfWeek, TimeSpan> radniSatiPoDanu = odabraniRadnik.DohvatiRadneSatePoDanu();

                    if (radniSatiPoDanu.Any()) // Provjerava ima li unosa
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.AppendLine($"Radnik podaci: {odabraniRadnik.podaci()}");
                        sb.AppendLine("Radni sati po danu:");

                        foreach (var kvp in radniSatiPoDanu)
                        {
                            sb.AppendLine($"{kvp.Key}: {kvp.Value.TotalHours} sati");
                        }

                        label11.Text = sb.ToString();
                    }
                    else
                    {
                        label11.Text = "Radnik podaci: " + odabraniRadnik.podaci() + "\nNema podataka o radnim satima.";
                    }
                }
                else
                {
                    MessageBox.Show("Firma ili radnik nisu pronaðeni u listi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Molimo odaberite firmu i radnika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dolazak_Click(object sender, EventArgs e)
        {
            if (odabir_firme.SelectedItem != null && odabir_radnika.SelectedItem != null)
            {

                string odabranoImeFirme = odabir_firme.SelectedItem.ToString();
                string odabraniRadnikPodaci = odabir_radnika.SelectedItem.ToString();

                Firma odabranaFirma = null;

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }
                Radnik odabraniRadnik = null;
                foreach (Radnik radnik in odabranaFirma.DohvatiListuRadnika())
                {
                    if (radnik.podaci() == odabraniRadnikPodaci)
                    {
                        odabraniRadnik = radnik;
                        break;
                    }
                }

                if (odabranaFirma != null && odabraniRadnik != null)
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        MessageBox.Show("Ne možete oznaèiti dolazak jer je danas vikend.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (odabraniRadnik.DohvatiVrijemeDolaska() == DateTime.MinValue)
                    {
                        odabraniRadnik.Radnik_dolazak();
                        MessageBox.Show("Vrijeme dolaska zabilježeno za radnika: " + odabraniRadnikPodaci, "Dolazak zabilježen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Vrijeme dolaska veæ zabilježeno za radnika: " + odabraniRadnikPodaci, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Firma ili radnik nisu pronaðeni u listi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite firmu i radnika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odlazak_Click(object sender, EventArgs e)

        {


            if (odabir_firme.SelectedItem != null && odabir_radnika.SelectedItem != null)

            {
                string odabranoImeFirme = odabir_firme.SelectedItem.ToString();
                string odabraniRadnikPodaci = odabir_radnika.SelectedItem.ToString();

                Firma odabranaFirma = null;

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }
                Radnik odabraniRadnik = null;
                foreach (Radnik radnik in odabranaFirma.DohvatiListuRadnika())
                {
                    if (radnik.podaci() == odabraniRadnikPodaci)
                    {
                        odabraniRadnik = radnik;
                        break;
                    }
                }


                if (odabranaFirma != null && odabraniRadnik != null)
                {
                    if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                    {
                        MessageBox.Show("Ne možete oznaèiti odlazak jer je danas vikend.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (odabraniRadnik.DohvatiVrijemeOdlaska() == DateTime.MinValue)
                    {
                        // Provjeri je li radnik veæ dolazio prije nego što oznaèi odlazak
                        if (odabraniRadnik.DohvatiVrijemeDolaska() != DateTime.MinValue)
                        {
                            odabraniRadnik.Radnik_odlazak();
                            label11.Text = "Ukupni radni sati tjedno: " + odabraniRadnik.UkupniRadniSati();
                            MessageBox.Show("Vrijeme odlaska zabilježeno za radnika: " + odabraniRadnikPodaci, "Odlazak zabilježen", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            odabraniRadnik.resetirajDiO();
                        }
                        else
                        {
                            MessageBox.Show("Ne možete otiæi prije dolaska, radnik: " + odabraniRadnikPodaci, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vrijeme odlaska veæ zabilježeno za radnika: " + odabraniRadnikPodaci, "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Firma ili radnik nisu pronaðeni u listi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Molimo odaberite firmu i radnika.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void vom2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void odabir_firme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (odabir_firme.SelectedItem != null)
            {
                string odabranoImeFirme = odabir_firme.SelectedItem.ToString();
                Firma odabranaFirma = null;

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }
                if (odabranaFirma != null)
                {
                    List<Radnik> radniciFirme = odabranaFirma.DohvatiListuRadnika();

                    odabir_radnika.Items.Clear();
                    foreach (Radnik radnik in radniciFirme)
                    {
                        odabir_radnika.Items.Add(radnik.podaci());
                    }
                }
                else
                {
                    MessageBox.Show("Firma nije pronaðena u listi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (odabir_radnika.SelectedItem != null)
            {
                // Pronaði odabrane objekte
                Firma odabranaFirma = null;
                Radnik odabraniRadnik = null;

                string odabranoImeFirme = odabir_firme.SelectedItem.ToString();
                string odabraniRadnikPodaci = odabir_radnika.SelectedItem.ToString();

                foreach (Firma firma in listaFirmi)
                {
                    if (firma.getName() == odabranoImeFirme)
                    {
                        odabranaFirma = firma;
                        break;
                    }
                }

                if (odabranaFirma != null)
                {
                    foreach (Radnik radnik in odabranaFirma.DohvatiListuRadnika())
                    {
                        if (radnik.podaci() == odabraniRadnikPodaci)
                        {
                            odabraniRadnik = radnik;
                            break;
                        }
                    }
                }

                if (odabraniRadnik != null)
                {
                    // Provjeri ako je radnik veæ dolazio
                    if (odabraniRadnik.DohvatiVrijemeDolaska() != DateTime.MinValue)
                    {
                        // Ako je radnik dolazio, ispiši podatke o radniku, ukljuèujuæi vrijeme dolaska i odlaska
                        label11.Text = "Radnik podaci: " + odabraniRadnik.podaci() +
                    "\nVrijeme dolaska: " + odabraniRadnik.DohvatiVrijemeDolaska().ToString("dd.MM.yyyy. HH:mm:ss") +
                    "\nVrijeme odlaska: " + (odabraniRadnik.DohvatiVrijemeOdlaska() != DateTime.MinValue ? odabraniRadnik.DohvatiVrijemeOdlaska().ToString("dd.MM.yyyy. HH:mm:ss") : "Nije otišao") +
                    "\nUkupni radni sati tjedno: " + odabraniRadnik.UkupniRadniSati();

                    }
                    else
                    {
                        // Ako radnik nije dolazio, ispiši samo podatke o radniku
                        label11.Text = "Radnik podaci: " + odabraniRadnik.podaci() + "\nVrijeme dolaska: Nije došao";
                    }
                }
                else
                {
                    MessageBox.Show("Firma ili radnik nisu pronaðeni u listi.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Radnik nije odabran.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void kasnili_Click(object sender, EventArgs e)
        {

        }

        private void nedovoljni_Click(object sender, EventArgs e)
        {
            DayOfWeek danas = DateTime.Now.DayOfWeek;

            if (danas == DayOfWeek.Saturday || danas == DayOfWeek.Sunday)
            {
                // Vikend
                StringBuilder nedovoljniRadnici = new StringBuilder();
                foreach (Firma firma in listaFirmi)
                {
                    foreach (Radnik radnik in firma.DohvatiListuRadnika())
                    {
                        if (radnik.UkupniRadniSati().TotalHours < 40)
                        {
                            nedovoljniRadnici.AppendLine(radnik.podaci() + " - " + radnik.UkupniRadniSati().TotalHours + " sati");
                        }
                    }
                }

                if (nedovoljniRadnici.Length > 0)
                {
                    MessageBox.Show("Nedovoljni radnici:\n" + nedovoljniRadnici.ToString(), "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Svi radnici su radili dovoljno sati.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (danas == DayOfWeek.Monday)
            {
                // Ponedjeljak - resetiraj listu
                foreach (Firma firma in listaFirmi)
                {
                    firma.ResetirajVrijemeDolaskaIOdlaska();
                }

                MessageBox.Show("Radni tjedan je resetiran. Možete ispisivati listu od vikenda.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Radni tjedan u tijeku
                MessageBox.Show("Radni tjedan je u tijeku. Možete ispisivati listu samo za vikend.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Radnik
    {
        private int OIB;
        private string ime = "";
        private string prezime = "";
        private string ferma = "";
        private DateTime dolazak;
        private DateTime odlazak;
        private Dictionary<DayOfWeek, TimeSpan> RadniSatiPoDanu = new Dictionary<DayOfWeek, TimeSpan>();
        private List<DateTime> daniDolaska = new List<DateTime>();
        public Radnik(int oib, string ime_, string prezime_, string ferma_)
        {
            OIB = oib;
            ime = ime_;
            prezime = prezime_;
            ferma = ferma_;
        }
        public void Radnik_dolazak()
        {
            
            DateTime danas = DateTime.Now.Date;

            if (daniDolaska.Contains(danas))
            {
                MessageBox.Show("Radnik veæ oznaèio dolazak danas.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dolazak = DateTime.Now;
            daniDolaska.Add(danas);
            
        }
        public void Radnik_odlazak()
        {
            odlazak = DateTime.Now;
            if (dolazak != DateTime.MinValue)
            {
                DayOfWeek dan = dolazak.DayOfWeek;
                TimeSpan radnoVrijeme = odlazak - dolazak;

                if (RadniSatiPoDanu.ContainsKey(dan))
                {
                    RadniSatiPoDanu[dan] += radnoVrijeme;
                }
                else
                {
                    RadniSatiPoDanu[dan] = radnoVrijeme;
                }
                
            }
            
        }
        public DateTime DohvatiVrijemeDolaska()
        {
            return dolazak;
        }

        public DateTime DohvatiVrijemeOdlaska()
        {
            return odlazak;
        }
        public void resetirajDiO()
        {
            dolazak = DateTime.MinValue;
            odlazak = DateTime.MinValue;
        }
        public TimeSpan UkupniRadniSati()
        {
            TimeSpan ukupnoVrijeme = TimeSpan.Zero;

            foreach (var kvp in RadniSatiPoDanu)
            {
                ukupnoVrijeme += kvp.Value;
            }

            return ukupnoVrijeme;
        }

        public string podaci()
        {
            return ime + " " + prezime + " " + OIB + " " + ferma;
        }
        public Dictionary<DayOfWeek, TimeSpan> DohvatiRadneSatePoDanu()
        {
            return RadniSatiPoDanu;
        }
    }

    public class Firma
    {
        private int ID;
        private string Naziv;
        private TimeSpan PocetakDolaska;
        private TimeSpan KrajDolaska;
        private TimeSpan PocetakOdlaska;
        private TimeSpan KrajOdlaska;
        private List<Radnik> ListaRadnika;
        private List<Radnik> RanijeOdlaziliRadnici;

        public Firma(int id, string naziv, TimeSpan pocetakDolaska, TimeSpan krajDolaska,
                     TimeSpan pocetakOdlaska, TimeSpan krajOdlaska)
        {
            ID = id;
            Naziv = naziv;
            PocetakDolaska = pocetakDolaska;
            KrajDolaska = krajDolaska;
            PocetakOdlaska = pocetakOdlaska;
            KrajOdlaska = krajOdlaska;
            ListaRadnika = new List<Radnik>();
        }

        public void DodajRadnika(Radnik radnik)
        {
            ListaRadnika.Add(radnik);
        }

        public string getName()
        {
            return Naziv;
        }

        public string ispisRadnika()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in ListaRadnika)
            {
                sb.AppendLine(item.podaci());
            }
            return sb.ToString();
        }

        public List<Radnik> DohvatiListuRadnika()
        {
            return ListaRadnika;
        }
        public void ResetirajVrijemeDolaskaIOdlaska()
        {
            foreach (Radnik radnik in ListaRadnika)
            {
                radnik.resetirajDiO();
            }
        }
        
    }
}
