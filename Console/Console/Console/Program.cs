using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    class Program
    {
        public void Main1()
        {
            Console.WriteLine("Bonjour !");
            Console.ReadKey();
        }

        public void Main2()
        {
            int i =1;
            int j = 1;
            i = i +1;

            Console.WriteLine(i.GetType().IsValueType);
            Console.WriteLine(i.GetType().FullName);
            Console.WriteLine(@"i{0}, j ={1}", i,j);

            // CLasse
            DemoClass classA = new DemoClass();
            classA.valeur = 1;
            DemoClass classB = new DemoClass();
            classA.valeur++;
            Console.WriteLine(classA.GetType().IsValueType);
            Console.WriteLine(classA.GetType().FullName);
            Console.WriteLine(@"classA={0}, clasB={1}", classA.valeur, classB.valeur);
            Console.WriteLine(Environment.NewLine);

            // Structure
            DemoStruct structA = new DemoStruct();
            structA.valeur = 1;
            DemoStruct structB = new DemoStruct();
            structA.valeur++;
            Console.WriteLine(structA.GetType().IsValueType);
            Console.WriteLine(structA.GetType().FullName);
            Console.WriteLine(@"structA={0}, structB={1}", structA.valeur, structB.valeur);
            Console.WriteLine(Environment.NewLine);


            String strA = "Hello";
            String strB = strA;
            strA += "World !";
            Console.WriteLine(strA.GetType().IsValueType);
            Console.WriteLine(strA.GetType().FullName);
            Console.WriteLine(@"strA={0}, strB={1}", strA, strB);
            Console.WriteLine(Environment.NewLine);

            String strC = "Hello";
            String strD = strC;
            strC += " World !";
            Console.WriteLine(@"strC={0}, strD={1}", strC, strD);

            Console.WriteLine("Appuyez sur une touche >");
            Console.ReadKey();
        }

        public void Main3()
        {
            Console.WriteLine(@"Tableau, Liste et enums");

            // Tableau
            int[] premiers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            //var premiers = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            //int[] premiers =  { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };

            Console.WriteLine(@"Premiers : 5eme : {0}", premiers[4]);
            Console.WriteLine(Environment.NewLine);

            // Liste
            List<int> fibo = new List<int> { 0, 1, 1 };
            // var fibo = new List<int>(){0,1,1};
            fibo.Add(2);
            fibo.Add(3);
            fibo.Add(8);
            fibo.Add(13);
            fibo.Add(21);

            Console.WriteLine(@"Fibo : 5ème : {0}", fibo[4]);
            Console.WriteLine(Environment.NewLine);

            // Enum
            Console.WriteLine(@"Tarif {0} : {1}", TarifSemaine.Mercredi, (int)TarifSemaine.Mercredi);
            var tarifTTC = (double)TarifSemaine.Lundi;
            tarifTTC *= 1.2;
            Console.WriteLine(@"Tarif Lundi TTC : {0}", tarifTTC);
            Console.WriteLine(Environment.NewLine);

            // Flag
            var droits = Droits.Aucun;
            droits |= Droits.LectureEcriture; // Valeur aucun ou lecture ecriture
            Console.WriteLine(@"Ecriture ; {0}", ((droits & Droits.Ecriture) == Droits.Ecriture));
            Console.WriteLine(@"Suppression : {0}", ((droits & Droits.Suppression) == Droits.Suppression));
        }

        public void Main4()
        {
            Console.WriteLine(@"Boucles");
            Console.WriteLine(Environment.NewLine);

            // For 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);
            }
            Console.WriteLine(Environment.NewLine);

            // While
            int j = 1;
            while (j < 100)
            {
                Console.WriteLine("j = {0}", j);
                j *= 2;
            }
            Console.WriteLine(Environment.NewLine);

            // DO while
            int k = 10;
            do
            {
                Console.WriteLine("K = {0}", k);
                k -= 1;
            } while (k > 0);

            // Foreach
            var iListe = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (int valeur in iListe)
            {
                Console.WriteLine("valeur {0}", valeur);
            }
            Console.WriteLine(Environment.NewLine);

            // Conitnue
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                    continue;
                Console.WriteLine("i = {0}", i);
            }
            Console.WriteLine(Environment.NewLine);

            // Break
            for (int i = 0; i < 100; i *= 2)
            {
                if (i == 128)
                    break;
                Console.WriteLine("i = {0}", i);
            }
            Console.WriteLine(Environment.NewLine);
        }

        private static void Main5(Program a)
        {
            Console.WriteLine("Borne max");
            String strMax = Console.ReadLine();
            int max = int.Parse(strMax);
            int min = 2;

            Console.WriteLine("Min : {0}, Max : {1}", min, max);

            List<int> res = a.getPrimeNumber(min, max);
            Console.WriteLine("Résultat !");
            foreach (int number in res)
            {
                Console.Write("{0} / ", number);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void Main6()
        {

            var personneA = new Personne();
            personneA.Nom = "O Brian";
            personneA.Prenom = "Patrick";
            personneA.Age = 75;

            var personneB = new Personne { Nom = "Saylor", Prenom = "Steven", Age= 80 };

            Console.WriteLine("A : {0}", personneA.NomPrenom);
        }

        public void Main7()
        {
            var etudiant = new Eleve { Nom = "Prince", Prenom = "Martin", Class = "CM1" };
            var prof = new Enseignant { Nom = "Krapabelle", Prenom = "Edna", Niveau = "Primaire" };
            Console.WriteLine(prof.Afficher());
            Console.WriteLine(etudiant.Afficher());


        }

        private static void Main(String[] args)
        {
            Program a = new Program();
            /*a.Main1();
            a.Main2();
            a.Main3();
            a.Main4();
            a.Main5()
            a.Main6();*/
            a.Main7();
        }

        /*
            Fonction Eratosthène(Limite)
                L = liste des entiers de 2 à Limite
                Tant que L est non vide
                    Afficher le premier entier de L
                    L = liste des entiers de L non multiples du premier
                Fin tant que
            Fin fonction
        */
        public List<int> getPrimeNumber(int min, int max)
        {
            List<int> res = new List<int>();
            List<int> tmp = new List<int>();
            List<int> tmpBis = new List<int>();

            for (int i = min; i <= max; i++ )
            {
                if (i % 2 != 0) 
                {
                    tmp.Add(i);
                    tmpBis.Add(i);
                }
            }

            res.Add(1);
            res.Add(2);

            while (tmp.Count > 0)
            {
                int currentIndex = tmp[0];
                res.Add(currentIndex);
                foreach (int number in tmp)
                {
                    if (number % currentIndex == 0)
                    {
                        tmpBis.Remove(number);
                    }
                }
                tmp = new List<int>();
                tmp.AddRange(tmpBis);
            }

            return res;
        }

    }

    class Enseignant : Personne
    {
        public string Niveau { get; set; }

        // new = on efface la méthode parente
        public new string Afficher()
        { return String.Format("{0}, {1} - {2}", Nom, Prenom, Niveau); }

        public override string QuiSuisJe()
        {
            return base.QuiSuisJe() + " mais aussi un enseignant !";
        }
    }

    class Eleve : Personne
    {
        public string Class { get; set; }

        public override string QuiSuisJe()
        {
            return base.QuiSuisJe() + ", mais aussi un élève! ";
        }
    }

    class Personne
    {
        public string Nom;
        private int _age;

        public void vieilli(int howMuch)
        {
            Age = Age + howMuch;
        }

        public void growUp()
        {
            vieilli(1);
        }

        public static Personne Generateur(string nom, string prenom, int age)
        {
            if (Instance >= 10) return null;
            return new Personne(nom, prenom, age);
        }

        // Virtual = autoriser la surchage pour les classes filles.
        public virtual string QuiSuisJe()
        {
            return "Je suis une Personne";
        }

        public static int Instance { get; private set; }

        private static int _lastId;
        private string nom;

        public Personne(string nom, string prenom, int age)
        {
            this.nom = nom;
            this.Prenom = prenom;
            this.Age = age;
        }

        public Personne() { }

        public int Id { get; private set; }


        public int Age
        {
            get { return _age; }
            set
            {
                _age = Math.Max(0, value);
            }
        }

        public string Afficher()
        {
            return Nom + " " + "Prenom";
        }

        public string Prenom { get; set; } 
        
        public string NomPrenom
        {
            get { return String.Format("{0},{1}", Nom, Prenom); }
        }


        static bool EstComplet(Personne persone)
        {
            return ((persone.Nom.Length > 0) && (persone.Prenom.Length > 0));
        }

    }

    class DemoClass
    {
        public int valeur;
    }

    struct DemoStruct
    {
        public int valeur;
    }

    enum TarifSemaine
    {
        Lundi = 2,
        Mardi = 3,
        Mercredi = 5,
        Jeudi = 3,
        Vendredi = 8,
        Samedi = 10,
        Dimanche = 8
    }

    [Flags]
    enum Droits
    {
        Aucun =0x0,
        Lecture =0x1,
        Ecriture =0x2,
        Suppression = 0x4,
        LectureEcriture =3,
        Tous= 7
    }



}
