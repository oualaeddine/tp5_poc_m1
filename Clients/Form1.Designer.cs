namespace Clients
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.nom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_stud = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.creer_pile = new System.Windows.Forms.Button();
            this.adresse_pile = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.taille = new System.Windows.Forms.NumericUpDown();
            this.add_result = new System.Windows.Forms.Label();
            this.show_size = new System.Windows.Forms.Button();
            this.size = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taille)).BeginInit();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(139, 71);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 20);
            this.nom.TabIndex = 1;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(299, 71);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(100, 20);
            this.prenom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nom : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "prenom :";
            // 
            // add_stud
            // 
            this.add_stud.Location = new System.Drawing.Point(405, 71);
            this.add_stud.Name = "add_stud";
            this.add_stud.Size = new System.Drawing.Size(113, 23);
            this.add_stud.TabIndex = 6;
            this.add_stud.Text = "ajouter etudiant";
            this.add_stud.UseVisualStyleBackColor = true;
            this.add_stud.Click += new System.EventHandler(this.add_stud_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "taille de la pile a creer :";
            // 
            // creer_pile
            // 
            this.creer_pile.Location = new System.Drawing.Point(205, 31);
            this.creer_pile.Name = "creer_pile";
            this.creer_pile.Size = new System.Drawing.Size(102, 23);
            this.creer_pile.TabIndex = 10;
            this.creer_pile.Text = "creer une pile";
            this.creer_pile.UseVisualStyleBackColor = true;
            this.creer_pile.Click += new System.EventHandler(this.creer_pile_Click);
            // 
            // adresse_pile
            // 
            this.adresse_pile.AutoSize = true;
            this.adresse_pile.Location = new System.Drawing.Point(313, 34);
            this.adresse_pile.Name = "adresse_pile";
            this.adresse_pile.Size = new System.Drawing.Size(89, 13);
            this.adresse_pile.TabIndex = 11;
            this.adresse_pile.Text = "adresse de la pile";
            this.adresse_pile.Visible = false;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(40, 71);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(51, 20);
            this.id.TabIndex = 12;
            // 
            // taille
            // 
            this.taille.Location = new System.Drawing.Point(134, 31);
            this.taille.Name = "taille";
            this.taille.Size = new System.Drawing.Size(65, 20);
            this.taille.TabIndex = 13;
            this.taille.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // add_result
            // 
            this.add_result.AutoSize = true;
            this.add_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_result.Location = new System.Drawing.Point(149, 94);
            this.add_result.Name = "add_result";
            this.add_result.Size = new System.Drawing.Size(197, 26);
            this.add_result.TabIndex = 14;
            this.add_result.Text = "ajouté avec succes";
            this.add_result.Visible = false;
            // 
            // show_size
            // 
            this.show_size.Location = new System.Drawing.Point(13, 125);
            this.show_size.Name = "show_size";
            this.show_size.Size = new System.Drawing.Size(120, 23);
            this.show_size.TabIndex = 15;
            this.show_size.Text = "afficher taille actuelle";
            this.show_size.UseVisualStyleBackColor = true;
            this.show_size.Click += new System.EventHandler(this.show_size_Click);
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(139, 130);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(28, 13);
            this.size.TabIndex = 16;
            this.size.Text = "taille";
            this.size.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "ip serveur : ";
            // 
            // ip
            // 
            this.ip.Location = new System.Drawing.Point(187, 8);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(100, 20);
            this.ip.TabIndex = 19;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(293, 6);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 20;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 170);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.size);
            this.Controls.Add(this.show_size);
            this.Controls.Add(this.add_result);
            this.Controls.Add(this.taille);
            this.Controls.Add(this.id);
            this.Controls.Add(this.adresse_pile);
            this.Controls.Add(this.creer_pile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add_stud);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.nom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taille)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.TextBox prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_stud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button creer_pile;
        private System.Windows.Forms.Label adresse_pile;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.NumericUpDown taille;
        private System.Windows.Forms.Label add_result;
        private System.Windows.Forms.Button show_size;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ip;
        private System.Windows.Forms.Button connect;
    }
}

