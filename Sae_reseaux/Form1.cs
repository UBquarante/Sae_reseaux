using Microsoft.VisualBasic;

namespace Sae_reseaux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        static public string CalculSommeHexa(string[] TableauxValeur)
        {
            string resultat = "0";
            int somme = 0;
            foreach (string s in TableauxValeur)
            {
                somme = Convert.ToInt32(resultat, 16) +
                    Convert.ToInt32(s, 16);
                resultat = somme.ToString("X4");
            }
            return resultat;
        }

        static public string[] StringToTab(string saisie)
        {
            int nb = saisie.Length;
            int taillePaquet = 4;
            int nombrePaquets = (int)Math.Ceiling((double)nb / taillePaquet);
            string[] tabSaisie = new string[nombrePaquets];
            int indexTableau = 0;

            for (int i = 0; i < nb; i += taillePaquet)
            {
                int longueurPaquet = Math.Min(taillePaquet, nb - i);
                tabSaisie[indexTableau] = saisie.Substring(i, longueurPaquet);
                indexTableau++;
            }
            return tabSaisie;
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            string saisie = Saisie.Text;
        }
    }
}
