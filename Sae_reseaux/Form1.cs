using Microsoft.VisualBasic;

namespace Sae_reseaux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        string CalculSommeHexa(string[] TableauxValeur)
        {
            string resultat = "0";
            int somme = 0;
            foreach (string s in TableauxValeur)
            {
                somme = Convert.ToInt32(resultat, 16) +
                    Convert.ToInt32(s, 16);
                resultat = Conversion.Hex(somme);
            }
            return resultat;
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
    }
}
