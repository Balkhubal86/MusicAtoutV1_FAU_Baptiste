namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FCompositeurNation
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
            cboNation = new ComboBox();
            label1 = new Label();
            dgvCompositeur = new DataGridView();
            bsCompositeur = new BindingSource(components);
            bsNation = new BindingSource(components);
            button1 = new Button();
            btAjout = new Button();
            btModif = new Button();
            btSupp = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            SuspendLayout();
            // 
            // cboNation
            // 
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(86, 8);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 11);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Nationalité";
            // 
            // dgvCompositeur
            // 
            dgvCompositeur.AllowUserToAddRows = false;
            dgvCompositeur.AllowUserToDeleteRows = false;
            dgvCompositeur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompositeur.Location = new Point(6, 37);
            dgvCompositeur.Name = "dgvCompositeur";
            dgvCompositeur.ReadOnly = true;
            dgvCompositeur.Size = new Size(782, 384);
            dgvCompositeur.TabIndex = 2;
            // 
            // bsCompositeur
            // 
            bsCompositeur.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // bsNation
            // 
            bsNation.CurrentChanged += bsNation_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(229, 8);
            button1.Name = "button1";
            button1.Size = new Size(138, 23);
            button1.TabIndex = 3;
            button1.Text = "Toutes les nationalités";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btAjout
            // 
            btAjout.Location = new Point(9, 440);
            btAjout.Name = "btAjout";
            btAjout.Size = new Size(75, 23);
            btAjout.TabIndex = 4;
            btAjout.Text = "AJOUT";
            btAjout.UseVisualStyleBackColor = true;
            btAjout.Click += btAjout_Click;
            // 
            // btModif
            // 
            btModif.Location = new Point(90, 440);
            btModif.Name = "btModif";
            btModif.Size = new Size(107, 23);
            btModif.TabIndex = 5;
            btModif.Text = "MODIFICATION";
            btModif.UseVisualStyleBackColor = true;
            btModif.Click += btModif_Click_1;
            // 
            // btSupp
            // 
            btSupp.Location = new Point(203, 440);
            btSupp.Name = "btSupp";
            btSupp.Size = new Size(85, 23);
            btSupp.TabIndex = 6;
            btSupp.Text = "SUPRESSION";
            btSupp.UseVisualStyleBackColor = true;
            btSupp.Click += btSupp_Click;
            // 
            // FCompositeurNation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 489);
            Controls.Add(btSupp);
            Controls.Add(btModif);
            Controls.Add(btAjout);
            Controls.Add(button1);
            Controls.Add(dgvCompositeur);
            Controls.Add(label1);
            Controls.Add(cboNation);
            Name = "FCompositeurNation";
            Text = "FCompositeurNation";
            Load += FCompositeurNation_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCompositeur).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboNation;
        private Label label1;
        private DataGridView dgvCompositeur;
        private BindingSource bsCompositeur;
        private BindingSource bsNation;
        private Button button1;
        private Button btAjout;
        private Button btModif;
        private Button btSupp;
    }
}