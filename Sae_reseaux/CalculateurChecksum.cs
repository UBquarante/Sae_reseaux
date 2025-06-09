using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;
using Microsoft.VisualBasic;

namespace Sae_reseaux
{
    public partial class CalculateurChecksum : Form
    {
        public CalculateurChecksum()
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
                // On le converti en Hexadécimal et on l'ajoute dans resultat
                resultat += nombreNegatif.ToString("X");
            }
            return resultat;
        }

        public string[] Separation(string[] tram)
        {

            int nombreTram = 0;
            int indexTram = 0;
            // Les 10 premier element sont utilisée lors du calcul
            // On eneleve les 0000 du checksum

            string[] tramResultat = new string[9];
            while (nombreTram < 10)
            {
                if (nombreTram != 5)
                {
                    tramResultat[indexTram] = tram[nombreTram];
                    indexTram++;
                }
                nombreTram++;

            }
            return tramResultat;
        }

        public string AdresseIPSource(string[] strings)
        {
            string adresseIP = "";
            // On recupere les 2 element de l'adresse IP source
            for (int i = 5; i < 7; i++)
            {
                // On divise en 2 chaque élément afin de garder uniquement chaque décimal de l'adresse 
                string nombre1 = strings[i].Substring(0, 2);
                adresseIP += Convert.ToInt16(nombre1, 16).ToString();
                // On ajoute un point à chaque décimal
                adresseIP += ".";
                string nombre2 = strings[i].Substring(2, 2);
                adresseIP += Convert.ToInt16(nombre2, 16).ToString();
                // on vérifie si on est pas à la fin de l'adresse IP
                if (i != 6)
                {
                    adresseIP += ".";
                }
            }
            return adresseIP;
        }

        public string AdresseIPDest(string[] strings)
        {
            string adresseIP = "";
            // On recupere les 2 element de l'adresse IP destinataire
            for (int i = 7; i < 9; i++)
            {
                // On divise en 2 chaque élément afin de garder uniquement chaque décimal de l'adresse 
                string nombre1 = strings[i].Substring(0, 2);
                adresseIP += Convert.ToInt16(nombre1, 16).ToString();
                // On ajoute un point à chaque décimal
                adresseIP += ".";
                string nombre2 = strings[i].Substring(2, 2);
                adresseIP += Convert.ToInt16(nombre2, 16).ToString();
                // on vérifie si on est pas à la fin de l'adresse IP
                if (i != 8)
                {
                    adresseIP += ".";
                }
            }
            return adresseIP;
        }

        public string TimeToLive(string[] strings)
        {
            string timeToLive = "";
            // On recupere le Time to live
            string nombre1 = strings[4].Substring(0, 2);
            timeToLive += Convert.ToInt16(nombre1, 16).ToString();
            return timeToLive;
        }

        private void Calcul_Click(object sender, EventArgs e)
        {
            if (txtSaisie.TextLength < 40) MessageBox.Show("Veuillez entrer au moins une en-tête IP complète");
            else
            {
                string saisie = txtSaisie.Text;
                string[] tabSaisie = StringToTab(saisie);
                tabSaisie = Separation(tabSaisie);

                string somme = CalculSommeHexa(tabSaisie);
                // On vérifie si la somme est supérieur à 4 chiffre
                somme = Depassement(somme);
                somme = negatif(somme);
                lblResultat.Text = somme;
                IPsource.Text = AdresseIPSource(tabSaisie);
                IPdest.Text = AdresseIPDest(tabSaisie);
                TTL.Text = TimeToLive(tabSaisie);
            }
        }

        private void Saisie_TextChanged(object sender, EventArgs e)
        {
            btnCalcul.Enabled = txtSaisie.TextLength > 0;
            lblResultat.Show();
        }



       
    }
}
