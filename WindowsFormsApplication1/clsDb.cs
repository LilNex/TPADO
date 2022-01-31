using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace WindowsFormsApplication1
{
    class clsDb
    {
        static string cnxStr = @"Data Source=DESKTOP-CLLLEH7\sqlexpress;Initial Catalog=tpdb;Integrated Security=True";
        static SqlConnection cnx;
        public static dsBiblio ds = new dsBiblio();
        public static DataSet dataset = new DataSet();
        public static SqlDataAdapter daAdherent;
        static SqlDataAdapter daLivre;
        static SqlDataAdapter daTheme;

        public static tpdbEntities1 db = new tpdbEntities1();

        public static void initConn()
        {
            cnx = new SqlConnection(cnxStr);

        }

        public static List<adherent> listeAdherent {
            get {
                return db.adherent.ToList();
            }
        }
        public static List<theme> listeTheme
        {
            get
            {
                return db.theme.ToList();
            }
        }
        public static List<livre> listeLivre
        {
            get
            {
                return db.livre.ToList();
            }
        }
        public static List<emprunt> listeEmprunt
        {
            get
            {
                return db.emprunt.ToList();
            }
        }
        public static void connect()
        {
            initConn();
            cnx.Open();
        }
        public static void loadDs() {
            connect();
            SqlCommand cmd = new SqlCommand("select * from adherent", cnx);
            daAdherent = new SqlDataAdapter("select * from adherent", cnx);
            daAdherent.Fill(ds, "adherent");
            daAdherent.Fill(dataset, "adherent");
            daLivre= new SqlDataAdapter("select * from livre", cnx);
            daLivre.Fill(ds, "livre");
            daLivre.Fill(dataset, "livre");
            daTheme = new SqlDataAdapter("select * from theme", cnx);
            daTheme.Fill(ds, "theme");
            daTheme.Fill(dataset, "theme");
        
        }
        public void saveDb()
        { 
            
        }
            
        public static bool ajouterAdherent(string nom, string adresse, DateTime dateajout)
        {
            //DataRow row = ds.Tables["adherent"].NewRow();
            //row[1] = nom;
            //row[2] = adresse;
            //row[3] = dateajout.ToString();

            adherent a = new adherent();
            a.nomA = nom;
            a.adresse = adresse;
            a.dateInscription = dateajout;

            db.adherent.Add(a);
            //db.adherent.
            db.SaveChanges();

            return true;
            

        }
        public static bool modifierAdherent(int id, string nom, string adresse, DateTime dateajout)
        {

            adherent a = db.adherent.First((adherent obj) => obj.codeA == id);
            a.nomA = nom;
            a.adresse = adresse;
            a.dateInscription = dateajout;

            db.SaveChanges();

            return true;


        }
        

        public static adherent getAdherent(int id)
        {
            return clsDb.db.adherent.First((adherent a) => a.codeA == id);
        }
        public static livre getLivre(int id)
        {
            return clsDb.db.livre.First((livre l) => l.codel == id);
        }
        public static theme getTheme(int id)
        {
            return clsDb.db.theme.First((theme t) => t.codeTh == id);
        }
        
        public static bool ajouterLivre(string titre,string auteur,int nbt,int codeTh)
        {
            //DataRow row = ds.Tables["adherent"].NewRow();
            //row[1] = nom;
            //row[2] = adresse;
            //row[3] = dateajout.ToString();

            livre l = new livre();
            l.auteur = auteur;
            l.titre = titre;
            l.nbEx = nbt;
            l.codeTh = codeTh;
            db.livre.Add(l);
            //db.adherent.
            db.SaveChanges();

            return true;


        }
        public static bool modifierLivre(int id ,string titre, string auteur, int nbt, int codeTh)
        {
            livre l = getLivre(id);

            //livre l = new livre();
            l.auteur = auteur;
            l.titre = titre;
            l.nbEx = nbt;
            l.codeTh = codeTh;
            //db.livre.Add(l);
            //db.adherent.
            db.SaveChanges();

            return true;


        }

        public static bool ajouterTheme(string intitule)
        {
            //DataRow row = ds.Tables["adherent"].NewRow();
            //row[1] = nom;
            //row[2] = adresse;
            //row[3] = dateajout.ToString();
            theme t = new theme();
            t.intitule = intitule;
            //db.adherent.
            db.theme.Add(t);
            db.SaveChanges();

            return true;


        }
        public static bool ajouterEmprunt(emprunt e)
        {
            db.emprunt.Add(e);
            db.SaveChanges();
            return true;
        }
        public static bool modifiertheme(int id, string intitule)
        {
            theme t = getTheme(id);
            t.intitule = intitule;
            db.SaveChanges();
                return true;

        }

        public static bool supptheme(int id) {
            db.theme.Remove(getTheme(id));
            db.SaveChanges();
            return true;
        }
        public static bool suppadherent(int id) {
            db.adherent.Remove(getAdherent(id));
            db.SaveChanges();
            return true;
        }
        public static bool supplivre(int id) {
            db.livre.Remove(getLivre(id));
            db.SaveChanges();
            return true;
        }

    }

    class dsBiblio : DataSet
    {
        public dsBiblio() { }    
    }


}
