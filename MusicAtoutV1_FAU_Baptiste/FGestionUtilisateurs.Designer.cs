namespace MusicAtoutV1_FAU_Baptiste.Models
{
    partial class FGestionUtilisateurs
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            dgvUtilisateurs = new DataGridView();
            bsUtilisateurs = new BindingSource(components);
            btnReactivation = new Button();
            btnDesactivation = new Button();
            btnAjout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateurs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Gestion Utilisateurs";
            // 
            // dgvUtilisateurs
            // 
            dgvUtilisateurs.AllowUserToAddRows = false;
            dgvUtilisateurs.AllowUserToDeleteRows = false;
            dgvUtilisateurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilisateurs.Location = new Point(12, 37);
            dgvUtilisateurs.Name = "dgvUtilisateurs";
            dgvUtilisateurs.ReadOnly = true;
            dgvUtilisateurs.Size = new Size(1021, 484);
            dgvUtilisateurs.TabIndex = 1;
            dgvUtilisateurs.CellContentClick += dgvUtilisateurs_CellContentClick;
            // 
            // bsUtilisateurs
            // 
            bsUtilisateurs.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // btnReactivation
            // 
            btnReactivation.Location = new Point(12, 542);
            btnReactivation.Name = "btnReactivation";
            btnReactivation.Size = new Size(75, 23);
            btnReactivation.TabIndex = 3;
            btnReactivation.Text = "Réactiver";
            btnReactivation.UseVisualStyleBackColor = true;
            btnReactivation.Click += btnReactivation_Click;
            // 
            // btnDesactivation
            // 
            btnDesactivation.Location = new Point(109, 542);
            btnDesactivation.Name = "btnDesactivation";
            btnDesactivation.Size = new Size(75, 23);
            btnDesactivation.TabIndex = 4;
            btnDesactivation.Text = "Désactiver";
            btnDesactivation.UseVisualStyleBackColor = true;
            btnDesactivation.Click += btnDesactivation_Click;
            // 
            // btnAjout
            // 
            btnAjout.Location = new Point(206, 542);
            btnAjout.Name = "btnAjout";
            btnAjout.Size = new Size(75, 23);
            btnAjout.TabIndex = 5;
            btnAjout.Text = "Ajouter";
            btnAjout.UseVisualStyleBackColor = true;
            btnAjout.Click += btnAjout_Click;
            // 
            // FGestionUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 577);
            Controls.Add(btnAjout);
            Controls.Add(btnDesactivation);
            Controls.Add(btnReactivation);
            Controls.Add(dgvUtilisateurs);
            Controls.Add(label1);
            Name = "FGestionUtilisateurs";
            Text = "FGestionUtilisateurs";
            Load += FGestionUtilisateurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUtilisateurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUtilisateurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvUtilisateurs;
        private BindingSource bsUtilisateurs;
        private Button btnReactivation;
        private Button btnDesactivation;
        private Button btnAjout;
    }
}