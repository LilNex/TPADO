using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmEmprunt : Form
    {
        public frmEmprunt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emprunt em = new emprunt();
            em.dateEmprunt = DateTime.Now;
            em.dateRetour = dateTimePicker1.Value;
            em.codeA = int.Parse(((adherent)comboBox1.SelectedItem).codeA.ToString());
            em.codel = int.Parse(((livre)listBox1.SelectedItem).codel.ToString());

            clsDb.ajouterEmprunt(em);
            MessageBox.Show("Emprunt ajouté");
        }
        public void loadDgv()
        {
            dataGridView1.DataSource = clsDb.listeEmprunt;
        }

        private void frmEmprunt_Load(object sender, EventArgs e)
        {
            adherentBindingSource.DataSource = clsDb.listeAdherent;
            themeBindingSource.DataSource = clsDb.listeTheme;
            livreBindingSource.DataSource = clsDb.listeLivre;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs ex)
        {
            var x = comboBox1.SelectedItem;
            txtNom.Text = ((adherent)x).nomA;

            var liste = clsDb.db.emprunt.Select((emprunt e) => e.codeA == ((adherent)x).codeA).ToList();
            dataGridView1.DataSource = liste;
            //var liste = clsDb.db.
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.DataSource = clsDb.db.livre.Select((livre l) => l.codeTh ==int.Parse(comboBox2.SelectedValue.ToString()));
        }
    }
}
