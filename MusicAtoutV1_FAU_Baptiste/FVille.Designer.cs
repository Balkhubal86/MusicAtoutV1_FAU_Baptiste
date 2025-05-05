namespace MusicAtoutV1_FAU_Baptiste.Models
{
    partial class FVille
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
            bsVille = new BindingSource(components);
            dgvVille = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsVille).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).BeginInit();
            SuspendLayout();
            // 
            // bsVille
            // 
            bsVille.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dgvVille
            // 
            dgvVille.AllowUserToAddRows = false;
            dgvVille.AllowUserToDeleteRows = false;
            dgvVille.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVille.Location = new Point(25, 12);
            dgvVille.Name = "dgvVille";
            dgvVille.ReadOnly = true;
            dgvVille.Size = new Size(751, 416);
            dgvVille.TabIndex = 0;
                //dgvVille.CellContentClick += this.dgvVille_CellContentClick;
            // 
            // FVille
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvVille);
            Name = "FVille";
            Text = "FVille";
            Load += FVille_Load;
            ((System.ComponentModel.ISupportInitialize)bsVille).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVille).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsVille;
        private DataGridView dgvVille;
    }
}