using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GestionFactureClient.couche_persistance;
using MySql.Data.MySqlClient;

namespace GestionFactureClient
{
    public class systemeController
    {
        private IArticleMySqlRepository articleRepo;
        private IClientMySqlRepository clientRepo;
        private IFactureMySqlRepository factureRepo;
        private IFactureArticlesMySqlRepository factArtRepo;


        public systemeController()
        {
            this.articleRepo = new ArticleMySqlRepository("127.0.0.1", "systemeFacturation", "root", "Joelkamo1!");
            this.clientRepo = new ClientMySqlRepository("127.0.0.1", "SystemeFacturation", "root", "Joelkamo1!");
            this.factureRepo = new FactureMySqlRepository("127.0.0.1", "SystemeFacturation", "root", "Joelkamo1!", (ClientMySqlRepository)this.clientRepo, (FactureArticlesMySqlRepository)this.factArtRepo);
            this.factArtRepo = new FactureArticlesMySqlRepository("127.0.0.1", "SystemeFacturation", "root", "Joelkamo1!", (ArticleMySqlRepository)this.articleRepo);


        }

        //fonction pour Client

        public Client ClientCreate(string nom, string prenom, string adresse, string ville)
        {
            Client x = new Client(nom, prenom, adresse, ville);
            this.clientRepo.insert(x);

            return x;

        }

        public Client ClientGet(int id)
        {
            Client x = this.clientRepo.select(id);

            return x;
        }

        public List<Client> ClientGetAll()
        {
            List<Client> x = this.clientRepo.selectAll();

            return x;

        }

        public Client ClientUpdate(int id, string nom, string prenom, string adresse, string ville)
        {
            Client x = this.clientRepo.select(id);
            x.Nom = nom;
            x.Prenom = prenom;
            x.Adresse = adresse;
            x.Ville = ville;
            x.IdClient = id;

            this.clientRepo.updateClient(x);

            return x;

        }

        public void ClientDelete(int id)
        {

            this.clientRepo.delete(id);
        }

        //Fonctions Articles

        public Articles ArticleCreate(string nom, int inventaire, double prixDetail, double prixVente)
        {
            Articles x = new Articles(nom, inventaire, prixDetail, prixVente);
            this.articleRepo.Insert(x);

            return x;

        }

        public Articles ArticleSelect(int id)
        {
            Articles x = this.articleRepo.Select(id);

            return x;
        }

        public List<Articles> ArticleGetAll()
        {
            List<Articles> x = this.articleRepo.selectAll();

            return x;
        }

        public Articles ArticleUpdate(int id, string nom, int quantite, double prixDetail, double prixVente)
        {

            Articles x = this.articleRepo.Select(id);
            x.NomArticle = nom;
            x.QuantiteInventaire = quantite;
            x.PrixDetail = prixDetail;
            x.PrixVendu = prixVente;
            x.IdArticle = id;

            this.articleRepo.ModifyArticle(x);
            Articles y = this.articleRepo.Select(x.IdArticle);

            return y;
        }

        public void ArticlesDelete(int id)
        {
            this.articleRepo.DeleteArticle(id);

        }

        //fonctions de Facture

        public Facture FactureSelect(int id)
        {
            Facture x = new Facture();
            if (this.factureRepo.select(id) != null)
            {
                x = this.factureRepo.select(id);
                x.ListeArticles = FactureGetArticle(id);
            }
            return x;
        }

        public List<Facture> FactureSelectAll()
        {
            List<Facture> x = this.factureRepo.selectAll();
            

            for (int i = 0; i < x.Count; i++)
            {
                x[i].ListeArticles = FactureGetArticle(x[i].IdFacture);
            }

            return x;

        }

        public List<Articles> FactureGetArticle(int id)
        {
            List<Articles> result = new List<Articles>();
            List<FactureArticle> y = this.factArtRepo.getAllElement();

            if (y != null)
            {
                for (int i = 0; i < y.Count; i++)
                {
                    if (y[i].IdFacture == id)
                    {
                        Articles x = this.articleRepo.Select(y[i].IdArticle);
                        result.Add(x);

                    }
                }
            }
            return result;

        }

        public Facture FactureCreate(Client client)
        {
            
            Facture x = new Facture();
            x.ClientFacture = client;
            this.factureRepo.insert(x);
            return x;

        }
        public Facture FactureAjouterArticle(Articles article, Facture x)
        {
            Facture result = x;
            FactureArticle y = new FactureArticle(x.IdFacture, article.IdArticle);
            this.factArtRepo.insert(y);
            List<Articles> newListe = FactureGetArticle(x.IdFacture);
            result.ListeArticles = newListe;

            return result;
        }

        public Facture FactureAjouterListeArticle(List<Articles> liste, Facture x)
        {
           

            for (int i = 0; i < liste.Count; i++)
            {
                FactureArticle y = new FactureArticle(x.IdFacture, liste[i].IdArticle);
                this.factArtRepo.insert(y);

            }

            List<Articles> result = FactureGetArticle(x.IdFacture);
            x.ListeArticles = result;

            return x;
        }

        public void FacturesupprimerArticle(Articles article, Facture x, int quantite)
        {
            int count = 0;
            List<FactureArticle> liste = this.factArtRepo.getAllElement();

            //on verifie le nombre de fois que l'article est present sur la facture
            for (int i = 0; i < liste.Count; i++)
            {
                if(liste[i].IdArticle == article.IdArticle && liste[i].IdFacture == x.IdFacture)
                {
                    count++;

                }
            }
            // on verifie que la quantite d'article present est plus grand ou egal a la quantite que l'on veut supprimer
            if(count >= quantite)
            {
                //on supprime toute les instances de l'article dans la facuture
                this.factArtRepo.deleteElement(x.IdFacture, article.IdArticle);

            }

            // on rajoute ensuite la difference entre les deux 
            int total = count - quantite;
            if(total > 0)
            {
                for (int i = 1; i < total; i++)
                {
                    this.factArtRepo.insert(new FactureArticle(x.IdFacture, article.IdArticle));
                }

            }



        }

        public Facture FactureUpdate(Facture x)
        {

            this.factureRepo.update(x);
            Facture y = this.factureRepo.select(x.IdFacture);

            return y;

        }

        public void FactureDelete(int id)
        {
            this.factureRepo.delete(id);

        }

        //Section delete All et Refresh all
        /*
        public void ClientDeleteAll()
        {
            List<Client> liste = this.clientRepo.selectAll();

            for (int i = 0; i < liste.Count; i++)
            {
                this.clientRepo.delete(liste[i].IdClient);
            }


        }

        public void ClientResetAllId()
        {
            List<Client> liste = this.clientRepo.selectAll();

            for (int i = 0; i < liste.Count; i++)
            {
                this.clientRepo.delete(liste[i].IdClient);
            }

            //apres le delete on re-insere les elements pour faire un reset des Id
            for (int i = 0; i < liste.Count; i++)
            {
                this.clientRepo.insert(liste[i]);
            }
        }

        public void ArticleDeleteAll()
        {
            List<Articles> liste = this.articleRepo.selectAll();

            for (int i = 0; i < liste.Count; i++)
            {
                this.articleRepo.DeleteArticle(liste[i].IdArticle);
            }

        }

        public void ArticleResetAllId()
        {
            List<Articles> liste = this.articleRepo.selectAll();

            for (int i = 0; i < liste.Count; i++)
            {
                this.articleRepo.DeleteArticle(liste[i].IdArticle);
            }

            for (int i = 0; i < liste.Count; i++)
            {
                this.articleRepo.Insert(liste[i]);
            }

        }

        public void FactureDeleteAll()
        {
            List<Facture> liste = this.factureRepo

        }

        */
    }

}