namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FCompositeurStyle
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
            cboStyle = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtDebut = new TextBox();
            txtFin = new TextBox();
            bsStyle = new BindingSource(components);
            bsCompositeur = new BindingSource(components);
            dgvCompositeur = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(199, 15);
            label1.TabIndex = 0;
            label1.Text = "Sélectionner un style ou une époque";
            // 
            // cboStyle
            // 
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(217, 16);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(121, 23);
            cboStyle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(382, 19);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "Début du style";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 19);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Fin du style";
            // 
            // txtDebut
            // 
            txtDebut.Location = new Point(465, 16);
            txtDebut.Name = "txtDebut";
            txtDebut.Size = new Size(100, 23);
            txtDebut.TabIndex = 4;
            // 
            // txtFin
            // 
            txtFin.Location = new Point(644, 16);
            txtFin.Name = "txtFin";
            txtFin.Size = new Size(100, 23);
            txtFin.TabIndex = 5;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(12, 70);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.Size = new Size(732, 368);
            dgvCompositeur.TabIndex = 6;
            // 
            // FCompositeurStyle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCompositeur);
            Controls.Add(txtFin);
            Controls.Add(txtDebut);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cboStyle);
            Controls.Add(label1);
            Name = "FCompositeurStyle";
            Text = "FCompositeurStyle";
            Load += FCompositeurStyle_Load;
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboStyle;
        private Label label2;
        private Label label3;
        private TextBox txtDebut;
        private TextBox txtFin;
        private BindingSource bsStyle;
        private BindingSource bsCompositeur;
        private DataGridView dgvCompositeur;
    }
}