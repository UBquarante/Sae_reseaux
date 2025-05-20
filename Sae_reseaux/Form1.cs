using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
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
            // Cela permet d'�viter les bugs
            s = s.Replace('\u00A0', ' ');
            s = s.Replace('\u2007', ' ');
            s = s.Replace('\u202F', ' ');
            // On passe la chaine en Majuscule
            s = s.ToUpper();
            // Index du string qui va contenir les 4 nombre Hexad�cimal
            int indexElement = 0;
            // Taille d'une trame Classique
            int tailleTram = 24;

            // String qui va contenir les 4 chiffre Hexad�cimal
            string element = "";

            // Notre Tableau de retour contenant les 4 chiffre Hexad�cimal
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
        public string AdditionHexa(string element1, string element2)
        {

            int somme;
            string resultat;
            somme = Convert.ToInt32(element1, 16) +
                    Convert.ToInt32(element2, 16);
            resultat = somme.ToString("X4");
            return resultat;
        }


        public string Depassement(string somme)
        {
            string nombre2 = "";
            string resultat;
            string nombreDepassement;

            if (somme.Length == 5)
            {
                nombreDepassement = somme[0].ToString();
                for (int i = 1; i < somme.Length; i++)
                {
                    nombre2 += somme[i];
                }
                // On fait la somme des deux nombre
                resultat = AdditionHexa(nombreDepassement, nombre2);
                return resultat;
            }
            else
            {
                return somme;
            }

        }

        public string negatif(string nombre)
        {
            string resultat = "";
            int nombreNegatif = 0;
            int nombreINT;

            for (int i = 0; i < nombre.Length; i++)
            {
                nombreINT = Convert.ToInt32(nombre[i].ToString(), 16);
                // Cela recupere l'inverse du nombre
                nombreNegatif = 15 - nombreINT;
                // On le converti en Hexad�cimal et on l'ajoute dans resultat
                resultat += nombreNegatif.ToString("X");
            }
            return resultat;
        }

        public string[] Separation(string[] tram)
        {

            int nombreTram = 0;
            int indexTram = 0;
            // Les 10 premier element sont utilis�e lors du calcul
            // On eneleve les 0000 du checksum

            string[] tramResultat = new string[9];
            while (nombreTram < 10)
            {
                if (nombreTram !=5)
                {
                    tramResultat[indexTram] = tram[nombreTram];
                    indexTram++;
                }
                nombreTram++;
                
            }
            return tramResultat;
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
            string[] tabSaisie = StringToTab(saisie);
            tabSaisie = Separation(tabSaisie);
         
            string somme = CalculSommeHexa(tabSaisie);
            // On v�rifie si la somme est sup�rieur � 4 chiffre
            somme = Depassement(somme);
            somme = negatif(somme);
            MessageBox.Show(somme);
        }
    }
}
