using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmtheme : Form
    {
        dsBiblio d;
        public frmtheme()
        {
            InitializeComponent();
        }
        //BindingSource bc = new BindingSource();
        private void loadDgv()
        {
            dataGridView1.DataSource = clsDb.listeTheme;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = clsDb.listeLivre;
            //comboBox1.DisplayMember = "intituleTh";
            //comboBox1.DisplayMember = "codeTh";


            //connexion using sql data client
            clsDb.loadDs();
            d = (dsBiblio)clsDb.ds;
            //bc = new BindingSource();
            //bindingSource1.DataSource = clsDb.db.livre;



            ////bindingSource1.DataMember = "livre";
            //txtCodeA.DataBindings.Add("text", bindingSource1, "codeA");
            //txtTitre.DataBindings.Add("text", bindingSource1, "nomA");
            //txtNbrEx.DataBindings.Add("text", bindingSource1, "adresse");

            //**************
            //dateTimePicker1.DataBindings.Add("date", bindingSource1, "dateInscription");
            
            //dataGridView1.DataSource = clsDb.listeAdherent;


            //txtCodeA.Text = bindingSource1.DataMember;
            loadDgv();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNv_Click(object sender, EventArgs e)
        {
            if (btnNv.Text == "Nouveau")
            {
                btnNv.Text = "Ajouter";
            }
            if (btnNv.Text == "Ajouter")
            {


                try
                {
                    if (clsDb.ajouterTheme(txtTitre.Text))
                    {
                        loadDgv();
                        MessageBox.Show("theme ajouté avec succès");
                    }
                    else { Console.WriteLine("ajouté"); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                loadDgv();
            



                btnNv.Text = "Nouveau";

            }

            loadDgv();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Console.WriteLine();
            theme obj = clsDb.getTheme(id);
            afficher(obj);
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtrechA.Text);
            theme obj = clsDb.getTheme(id);
            afficher(obj);
        }

        public void afficher(theme t)
        {
            txtTitre.Text = t.intitule;
            txtCodeA.Text = t.codeTh.ToString();
            //txtNbrEx.Text = a.nbExemplaire.ToString();
            //txtAuteur.Text = a.auteur;
            
            //dateTimePicker1.Value = DateTime.Parse(a.dateInscription.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsDb.modifiertheme(int.Parse(txtCodeA.Text), txtTitre.Text))
                {
                    loadDgv();
                    MessageBox.Show("Livre modifié avec succès");
                }
                else { Console.WriteLine("non ajouté"); }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

            loadDgv();
            


        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            clsDb.supptheme(int.Parse(txtCodeA.Text));
            loadDgv();

            MessageBox.Show("supprimé");

        }

        
    }
}
