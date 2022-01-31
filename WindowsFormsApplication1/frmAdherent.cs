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
    public partial class frmAdherent : Form
    {
        dsBiblio d;
        public frmAdherent()
        {
            InitializeComponent();
        }
        //BindingSource bc = new BindingSource();
        private void loadDgv()
        {
            dataGridView1.DataSource = clsDb.listeAdherent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //connexion using sql data client
            clsDb.loadDs();
            d = (dsBiblio)clsDb.ds;
            //bc = new BindingSource();
            bindingSource1.DataSource = clsDb.dataset;



            bindingSource1.DataMember = "adherent";
            txtCodeA.DataBindings.Add("text", bindingSource1, "codeA");
            txtNom.DataBindings.Add("text", bindingSource1, "nomA");
            txtAdresse.DataBindings.Add("text", bindingSource1, "adresse");

            //**************
            //dateTimePicker1.DataBindings.Add("date", bindingSource1, "dateInscription");
            
            dataGridView1.DataSource = clsDb.listeAdherent;


            //txtCodeA.Text = bindingSource1.DataMember;

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
                    if (clsDb.ajouterAdherent(txtNom.Text, txtAdresse.Text, dateTimePicker1.Value) == true)
                    {
                        MessageBox.Show("Adherent ajouté avec succes !");
                        loadDgv();

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    loadDgv();
                }


                btnNv.Text = "Nouveau";

            }

            loadDgv();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Console.WriteLine();
            adherent obj = clsDb.db.adherent.First((adherent a) => a.codeA == id);
            afficher(obj);
        }

        private void btnRech_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtrechA.Text);
            adherent obj = clsDb.getAdherent(id);
            afficher(obj);
        }

        public void afficher(adherent a)
        {
            txtNom.Text = a.nomA;
            txtCodeA.Text = a.codeA.ToString();
            txtAdresse.Text = a.adresse;
            dateTimePicker1.Value = DateTime.Parse(a.dateInscription.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            try
            {
                if (clsDb.modifierAdherent(int.Parse(txtCodeA.Text), txtNom.Text, txtAdresse.Text, dateTimePicker1.Value))
                {
                    loadDgv();
                    MessageBox.Show("Adherent modifié avec succès");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }

            loadDgv();
            


        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            clsDb.suppadherent(int.Parse(txtCodeA.Text));
            loadDgv();
            MessageBox.Show("supprimé");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
