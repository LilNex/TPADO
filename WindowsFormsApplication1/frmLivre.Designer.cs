namespace WindowsFormsApplication1
{
    partial class frmLivre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeA = new System.Windows.Forms.TextBox();
            this.txtTitre = new System.Windows.Forms.TextBox();
            this.txtNbrEx = new System.Windows.Forms.TextBox();
            this.btnNv = new System.Windows.Forms.Button();
            this.btnModif = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.txtrechA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRech = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAuteur = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.themeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tpdbDataSet = new WindowsFormsApplication1.tpdbDataSet();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeTableAdapter = new WindowsFormsApplication1.tpdbDataSetTableAdapters.themeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code Livre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "nbrExemplaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "auteur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nomtitre";
            // 
            // txtCodeA
            // 
            this.txtCodeA.Location = new System.Drawing.Point(180, 51);
            this.txtCodeA.Name = "txtCodeA";
            this.txtCodeA.Size = new System.Drawing.Size(147, 20);
            this.txtCodeA.TabIndex = 4;
            // 
            // txtTitre
            // 
            this.txtTitre.Location = new System.Drawing.Point(180, 81);
            this.txtTitre.Name = "txtTitre";
            this.txtTitre.Size = new System.Drawing.Size(147, 20);
            this.txtTitre.TabIndex = 5;
            // 
            // txtNbrEx
            // 
            this.txtNbrEx.Location = new System.Drawing.Point(180, 147);
            this.txtNbrEx.Name = "txtNbrEx";
            this.txtNbrEx.Size = new System.Drawing.Size(147, 20);
            this.txtNbrEx.TabIndex = 6;
            // 
            // btnNv
            // 
            this.btnNv.Location = new System.Drawing.Point(492, 43);
            this.btnNv.Name = "btnNv";
            this.btnNv.Size = new System.Drawing.Size(107, 28);
            this.btnNv.TabIndex = 8;
            this.btnNv.Text = "Nouveau";
            this.btnNv.UseVisualStyleBackColor = true;
            this.btnNv.Click += new System.EventHandler(this.btnNv_Click);
            // 
            // btnModif
            // 
            this.btnModif.Location = new System.Drawing.Point(492, 84);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(107, 28);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifier";
            this.btnModif.UseVisualStyleBackColor = true;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(492, 135);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(107, 28);
            this.btnSupp.TabIndex = 10;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(532, 312);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(107, 28);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Quitter";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // txtrechA
            // 
            this.txtrechA.Location = new System.Drawing.Point(558, 238);
            this.txtrechA.Name = "txtrechA";
            this.txtrechA.Size = new System.Drawing.Size(41, 20);
            this.txtrechA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(474, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Code Livre";
            // 
            // btnRech
            // 
            this.btnRech.Location = new System.Drawing.Point(492, 264);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(107, 28);
            this.btnRech.TabIndex = 14;
            this.btnRech.Text = "rechercher";
            this.btnRech.UseVisualStyleBackColor = true;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 28);
            this.button2.TabIndex = 16;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 28);
            this.button3.TabIndex = 17;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(318, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 28);
            this.button4.TabIndex = 18;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(637, 198);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Intitulé theme";
            // 
            // txtAuteur
            // 
            this.txtAuteur.Location = new System.Drawing.Point(180, 111);
            this.txtAuteur.Name = "txtAuteur";
            this.txtAuteur.Size = new System.Drawing.Size(147, 20);
            this.txtAuteur.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.themeBindingSource;
            this.comboBox1.DisplayMember = "intitule";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(180, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.ValueMember = "codeTh";
            // 
            // themeBindingSource1
            // 
            this.themeBindingSource1.DataMember = "theme";
            this.themeBindingSource1.DataSource = this.tpdbDataSet;
            // 
            // tpdbDataSet
            // 
            this.tpdbDataSet.DataSetName = "tpdbDataSet";
            this.tpdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataSource = typeof(WindowsFormsApplication1.theme);
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // frmLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 580);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAuteur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrechA);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnModif);
            this.Controls.Add(this.btnNv);
            this.Controls.Add(this.txtNbrEx);
            this.Controls.Add(this.txtTitre);
            this.Controls.Add(this.txtCodeA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLivre";
            this.Text = "Ajout livre";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeA;
        private System.Windows.Forms.TextBox txtTitre;
        private System.Windows.Forms.TextBox txtNbrEx;
        private System.Windows.Forms.Button btnNv;
        private System.Windows.Forms.Button btnModif;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.TextBox txtrechA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAuteur;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private tpdbDataSet tpdbDataSet;
        private System.Windows.Forms.BindingSource themeBindingSource1;
        private tpdbDataSetTableAdapters.themeTableAdapter themeTableAdapter;
    }
}

