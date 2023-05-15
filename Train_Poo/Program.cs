using System.Linq;

namespace Train_Poo
{
    internal class Program
    {
        class Personne
        {
            static int nombrePersonnes = 0;

            public string nom;
            int age;
            string emploi;
            int numeroPersonne;


            public Personne(string nom, int age, string emploi)
            {
                this.nom = nom;
                this.age = age;
                this.emploi = emploi;

                nombrePersonnes++;

                this.numeroPersonne = nombrePersonnes;

            }

            public void Afficher()
            {
                Console.WriteLine($"Personne N° {numeroPersonne}");
                Console.WriteLine($"Nom : {nom}");
                Console.WriteLine($"    Age : {age}");
                Console.WriteLine($"    Emploi : {emploi}");
            }

            public static void AfficherNombreDePersonnes()
            {
                //Ici on ne peut lire que la variable de classe parce qu'on est dans une fonction static donc une fonction de la classe. On ne peut pas accéder au variable d'instance qui sont nom, age et emploi
                Console.WriteLine($"Nombre total de personnes : {nombrePersonnes}");
            }
        }
        /*static void AfficherInfosPersonne(string nom, int age, string emploi)
        {
            Console.WriteLine($"Nom : {nom}");
            Console.WriteLine($"    Age : {age}");
            Console.WriteLine($"    Emploi : {emploi}");
        }*/
        static void Main(string[] args)
        {
            /*
            var noms = new List<string> { "Paul", "Jacques", "David", "Juliette"};
            var ages = new List<int> { 30, 35, 20, 8};
            var emplois = new List<string> { "Développeur", "Professeur", "Etudiant", "CP"};

            for (int i = 0; i < noms.Count; i++)
            {
                AfficherInfosPersonne(noms[i], ages[i], emplois[i]);
            }
            */

            /*
            Personne personne1 = new Personne("Paul", 30, "Développeur");
            personne1.Afficher();

            Personne personne2 = new Personne("Jacques", 35, "Professeur");
            personne2.Afficher();
            */

            /*
            // cette méthode fonctionne mais on peut faire plus simple
            var personnes = new List<Personne>();
            personnes.Add(new Personne("Paul", 30, "Développeur"));
            personnes.Add(new Personne("Jacques", 35, "Professeur"));
            personnes.Add(new Personne("David", 20, "Etudiant"));
            personnes.Add(new Personne("Juliette", 8, "CP"));
            */

            var personnes = new List<Personne> {
                new Personne("Paul", 30, "Développeur"),
                new Personne("Jacques", 35, "Professeur"),
                new Personne("David", 20, "Etudiant"),
                new Personne("Juliette", 8, "CP")
            };

            // Il faut mettre le nom en public pour pouvoir récuperer le nom et trier par ordre alphabétique
            personnes = personnes.OrderBy(p => p.nom).ToList();
            // A la ligne 71 si il n'y a pas ToList() à la fin il y aura une erreur que l'IDE va nous signaler, il ne peut pas passer de linq à List sans cette méthode

            foreach(Personne personne in personnes)
            {
                personne.Afficher();
            }

            // Pour lire la varible de classe mais seulement quand la variable est publique
            //Console.WriteLine($"Nombre total de personnes : {Personne.nombrePersonnes}");

            // Notre variable de classe est en private on ne peut plus faire comme pour la ligne 96. Pour la lire il faut faire comme en dessous
            Personne.AfficherNombreDePersonnes();
        }
    }
}