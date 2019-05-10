using System;

namespace OrienteObjetCharp
{



    class Program

    {
        static Client[] tabClient = new Client[10];
        static int nbrClient = 0;

        /// <summary>
        /// Structure pour la création des clients
        /// Cleint.
        /// </summary>
        private struct Client
        {
            //definition des attributs
            private int id_client;
            private String prenom_client, nom_client;
            private string[] produit_client;

            //encapsulation des atributs
            public int Id_client
            {
                get { return this.id_client; }
                set { this.id_client = value; }
            }
            public string Prenom_client { get => prenom_client; set => prenom_client = value; }
            public string Nom_client { get => nom_client; set => nom_client = value; }
            public string[] Produit_client { get => produit_client; set => produit_client = value; }



            //les constructeur
            public Client(int id_client, String nom, String prenom, string[]prod) : this()
            {
                this.id_client = id_client;
                this.nom_client = nom;
                this.prenom_client = prenom;
                this.produit_client=prod;
            }

            //Methode qui affiche sans le tableau produit
            public void afficher()
            {
                Console.WriteLine("**** Produit pour le client: "+id_client+" **** \n");
                foreach (string produit in produit_client)
                {
                    Console.WriteLine(produit);
                }
                Console.WriteLine("*****************************");
            }
        }


        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        static void Main(string[] args)
        {
            //Declaration et instaciation des objet
            Client c1 = new Client(1, "Malcom", "Juno", new string[] { "produit1","produis2"});
            //Client c2 = new Client();

            //c2.Id_client = 2;
            //c2.Prenom_client = "Jean";
            //c2.Nom_client = "Marc";
            //c2.Produit_client = new string []{ "prod3","prod3"};
            //c2.afficher();
            //c1.afficher();

            

            ajouterClient();
            AfficherClient(tabClient);

            //supprimerClient();
            
            //AfficherClientProduit(tabClient);




        }

        private static void AfficherClientProduit(Client[] tabClient)
        {
            int idClient;
            Console.WriteLine("Entrez l'id client");
            idClient = int.Parse(Console.ReadLine());

            foreach (Client monClient in tabClient)
            {
                if (monClient.Id_client.Equals(idClient))
                {
                    Console.WriteLine();
                    Console.Write(
                            monClient.Id_client+" "+
                            monClient.Prenom_client+" "+
                            monClient.Nom_client+" a {0} produits qui sont: ", monClient.Produit_client.Length

                        );

                    for (int i = 0; i < monClient.Produit_client.Length; i++)
                    {
                        Console.Write(monClient.Produit_client[i]+" | ");
                    }
                    Console.WriteLine();
                }
            }

        }


        /// <summary>
        /// Methode qui permet d'ajout le client ainsi que ses produits
        /// Ajouters the client.
        /// </summary>
        public static void ajouterClient()
        {
            string nom, prenom, produit;
            char choix = 'Y';
            int id, nbreProduit;

            do
            {
                //Console.WriteLine("Entrez ID");

                id = nbrClient;
                Console.WriteLine("Entrez nom");
                nom = Console.ReadLine();
                Console.WriteLine("Entrez prenom");
                prenom = Console.ReadLine();
                Console.WriteLine("Entrez le nombre de vos produits");
                nbreProduit = int.Parse(Console.ReadLine());



                tabClient[nbrClient].Id_client = id;
                tabClient[nbrClient].Prenom_client = prenom;
                tabClient[nbrClient].Nom_client = nom;
                tabClient[nbrClient].Produit_client = new string[nbreProduit];

                for (int i = 0; i < nbreProduit; i++)
                {
                    Console.WriteLine("Saisir le produit");
                    produit = Console.ReadLine();
                    tabClient[nbrClient].Produit_client[i] = produit;
                }
                nbrClient++;

                Console.WriteLine("Voulez-vous recommencer Y/N ?");
                choix = char.Parse(Console.ReadLine());



            } while (choix=='Y');








        }

        /// <summary>
        /// Methode qui permet de supprimer les clients 
        /// Supprimers the client.
        /// </summary>
        public static void supprimerClient()
        {
            int idToDelete;




            char choix = 'Y';


            do
            {
                Console.WriteLine("Entrez ID du client");
                idToDelete = int.Parse(Console.ReadLine());

                Console.WriteLine("Voulez-vous recommencer Y/N ?");
                choix = char.Parse(Console.ReadLine());



            } while (choix == 'Y');




            for (int i = 0; i < tabClient.Length; i++)
            {
                if (tabClient[i].Id_client.Equals(idToDelete))
                {
                    tabClient[i].Id_client = 0;
                    tabClient[i].Nom_client = "";
                    tabClient[i].Prenom_client = "";

                }
            }

            AfficherClient(tabClient);


        }

        /// <summary>
        /// Methode qui affiche seulement le clients
        /// the client.
        /// </summary>
        /// <param name="clients">Clients.</param>
        private static void AfficherClient(Client[] clients)
        {
            Console.WriteLine("****Affichage des clients*** \n");

            foreach (Client monClient in clients)
            {
                Console.WriteLine("|--------------------------------------|");
                Console.WriteLine("\t "+monClient.Id_client + "\t " + monClient.Prenom_client+"\t "+monClient.Nom_client);

            }
        }



    }


}
