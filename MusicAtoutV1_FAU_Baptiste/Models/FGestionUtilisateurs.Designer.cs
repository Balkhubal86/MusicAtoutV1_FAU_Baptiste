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
            btnSauvegarde = new Button();
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
            dgvUtilisateurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUtilisateurs.Location = new Point(12, 37);
            dgvUtilisateurs.Name = "dgvUtilisateurs";
            dgvUtilisateurs.Size = new Size(1021, 484);
            dgvUtilisateurs.TabIndex = 1;
            dgvUtilisateurs.CellContentClick += dgvUtilisateurs_CellContentClick;
            // 
            // bsUtilisateurs
            // 
            bsUtilisateurs.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // btnSauvegarde
            // 
            btnSauvegarde.Location = new Point(947, 542);
            btnSauvegarde.Name = "btnSauvegarde";
            btnSauvegarde.Size = new Size(86, 23);
            btnSauvegarde.TabIndex = 2;
            btnSauvegarde.Text = "Sauvegarder";
            btnSauvegarde.UseVisualStyleBackColor = true;
            // 
            // FGestionUtilisateurs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 577);
            Controls.Add(btnSauvegarde);
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
        private Button btnSauvegarde;
    }
}