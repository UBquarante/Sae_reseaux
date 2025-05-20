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

        static public string[] StringToTab(string s)
        {
            // Remplace tous les types d'espaces Unicode par un espace standard
            // Cela permet d'éviter les bugs
            s = s.Replace('\u00A0', ' '); 
            s = s.Replace('\u2007', ' ');
            s = s.Replace('\u202F', ' ');
            // On passe la chaine en Majuscule
            s = s.ToUpper();
            // Index du string qui va contenir les 4 nombre Hexadécimal
            int indexElement = 0;
            // Taille d'une trame Classique
            int tailleTram = 24;

            // String qui va contenir les 4 chiffre Hexadécimal
            string element = "";

            // Notre Tableau de retour contenant les 4 chiffre Hexadécimal
            string[] tab = new string[tailleTram];
            //Index du tableau de retour 
            int indexTab = 0;

            // On parcours toute la chaine Saisie s
            for (int i = 0; i < s.Length; i += 1)
            {

                if (s[i] == ' ')
                {
                    element = "";
                    indexElement = 0;
                }

                else
                {
                    element += s[i];
                    indexElement++;
                }
                if (element.Length == 4)
                {
                    tab[indexTab] = element;
                    indexTab++;
                    element = "";
                    indexElement = 0;
                }
            }
            return tab;
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
            string[] tabSaisie = StrToTab(saisie);
            
        }
    }
}
