namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FAjoutUtilisateur
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
            lbIdentifiant = new Label();
            lbConfMdp = new Label();
            lbMdp = new Label();
            tbIdentifiant = new TextBox();
            tbMdp = new TextBox();
            tbConfMdp = new TextBox();
            label1 = new Label();
            label2 = new Label();
            nudDroit = new NumericUpDown();
            btnAjoutUtilisateur = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDroit).BeginInit();
            SuspendLayout();
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(18, 77);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(61, 15);
            lbIdentifiant.TabIndex = 0;
            lbIdentifiant.Text = "Identifiant";
            // 
            // lbConfMdp
            // 
            lbConfMdp.AutoSize = true;
            lbConfMdp.Location = new Point(18, 191);
            lbConfMdp.Name = "lbConfMdp";
            lbConfMdp.Size = new Size(147, 15);
            lbConfMdp.TabIndex = 1;
            lbConfMdp.Text = "Confirmez le Mot de passe";
            // 
            // lbMdp
            // 
            lbMdp.AutoSize = true;
            lbMdp.Location = new Point(18, 137);
            lbMdp.Name = "lbMdp";
            lbMdp.Size = new Size(77, 15);
            lbMdp.TabIndex = 2;
            lbMdp.Text = "Mot de Passe";
            lbMdp.Click += lbMdp_Click;
            // 
            // tbIdentifiant
            // 
            tbIdentifiant.Location = new Point(214, 74);
            tbIdentifiant.Name = "tbIdentifiant";
            tbIdentifiant.Size = new Size(144, 23);
            tbIdentifiant.TabIndex = 3;
            // 
            // tbMdp
            // 
            tbMdp.Location = new Point(214, 129);
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(144, 23);
            tbMdp.TabIndex = 4;
            tbMdp.UseSystemPasswordChar = true;
            // 
            // tbConfMdp
            // 
            tbConfMdp.Location = new Point(214, 188);
            tbConfMdp.Name = "tbConfMdp";
            tbConfMdp.Size = new Size(144, 23);
            tbConfMdp.TabIndex = 5;
            tbConfMdp.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(226, 29);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 6;
            label1.Text = "Ajout d'un Utilisateur";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 244);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "Niveau de droit";
            // 
            // nudDroit
            // 
            nudDroit.Location = new Point(214, 244);
            nudDroit.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            nudDroit.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDroit.Name = "nudDroit";
            nudDroit.Size = new Size(144, 23);
            nudDroit.TabIndex = 8;
            nudDroit.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAjoutUtilisateur
            // 
            btnAjoutUtilisateur.Location = new Point(214, 287);
            btnAjoutUtilisateur.Name = "btnAjoutUtilisateur";
            btnAjoutUtilisateur.Size = new Size(144, 23);
            btnAjoutUtilisateur.TabIndex = 9;
            btnAjoutUtilisateur.Text = "Ajouter";
            btnAjoutUtilisateur.UseVisualStyleBackColor = true;
            btnAjoutUtilisateur.Click += btnAjoutUtilisateur_Click;
            // 
            // FAjoutUtilisateur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 322);
            Controls.Add(btnAjoutUtilisateur);
            Controls.Add(nudDroit);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbConfMdp);
            Controls.Add(tbMdp);
            Controls.Add(tbIdentifiant);
            Controls.Add(lbMdp);
            Controls.Add(lbConfMdp);
            Controls.Add(lbIdentifiant);
            Name = "FAjoutUtilisateur";
            Text = "FAjoutUtilisateur";
            ((System.ComponentModel.ISupportInitialize)nudDroit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIdentifiant;
        private Label lbConfMdp;
        private Label lbMdp;
        private TextBox tbIdentifiant;
        private TextBox tbMdp;
        private TextBox tbConfMdp;
        private Label label1;
        private Label label2;
        private NumericUpDown nudDroit;
        private Button btnAjoutUtilisateur;
    }
}