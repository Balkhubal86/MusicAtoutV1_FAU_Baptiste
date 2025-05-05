namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FAjoutModifCompositeur
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnSubmit = new Button();
            tbNom = new TextBox();
            tbPrenom = new TextBox();
            tbRemarque = new TextBox();
            tbNais = new TextBox();
            tbMort = new TextBox();
            cboNation = new ComboBox();
            cboStyle = new ComboBox();
            btnCancel = new Button();
            bsNation = new BindingSource(components);
            bsStyle = new BindingSource(components);
            error1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)bsNation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)error1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 29);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 0;
            label1.Text = "Nom Compositeur :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 64);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 1;
            label2.Text = "Prénom Compositeur :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 2;
            label3.Text = "Remarque :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 179);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 3;
            label4.Text = "Année Nais :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(347, 179);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 4;
            label5.Text = "Année Mort :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 212);
            label6.Name = "label6";
            label6.Size = new Size(71, 15);
            label6.TabIndex = 5;
            label6.Text = "Nationalité :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 241);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "Style :";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(167, 278);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "OK";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbNom
            // 
            tbNom.Location = new Point(167, 26);
            tbNom.Name = "tbNom";
            tbNom.Size = new Size(100, 23);
            tbNom.TabIndex = 8;
            // 
            // tbPrenom
            // 
            tbPrenom.Location = new Point(167, 56);
            tbPrenom.Name = "tbPrenom";
            tbPrenom.Size = new Size(100, 23);
            tbPrenom.TabIndex = 9;
            // 
            // tbRemarque
            // 
            tbRemarque.Location = new Point(167, 85);
            tbRemarque.Multiline = true;
            tbRemarque.Name = "tbRemarque";
            tbRemarque.Size = new Size(548, 80);
            tbRemarque.TabIndex = 10;
            // 
            // tbNais
            // 
            tbNais.Location = new Point(167, 171);
            tbNais.Name = "tbNais";
            tbNais.Size = new Size(100, 23);
            tbNais.TabIndex = 11;
            // 
            // tbMort
            // 
            tbMort.Location = new Point(465, 176);
            tbMort.Name = "tbMort";
            tbMort.Size = new Size(100, 23);
            tbMort.TabIndex = 12;
            // 
            // cboNation
            // 
            cboNation.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNation.FormattingEnabled = true;
            cboNation.Location = new Point(167, 204);
            cboNation.Name = "cboNation";
            cboNation.Size = new Size(121, 23);
            cboNation.TabIndex = 13;
            // 
            // cboStyle
            // 
            cboStyle.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStyle.FormattingEnabled = true;
            cboStyle.Location = new Point(167, 233);
            cboStyle.Name = "cboStyle";
            cboStyle.Size = new Size(121, 23);
            cboStyle.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(288, 278);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "ANNULER";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // error1
            // 
            error1.ContainerControl = this;
            // 
            // FAjoutModifCompositeur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(cboStyle);
            Controls.Add(cboNation);
            Controls.Add(tbMort);
            Controls.Add(tbNais);
            Controls.Add(tbRemarque);
            Controls.Add(tbPrenom);
            Controls.Add(tbNom);
            Controls.Add(btnSubmit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FAjoutModifCompositeur";
            Text = "FAjoutModifCompositeur";
            Load += FAjoutModifCompositeur_Load;
            ((System.ComponentModel.ISupportInitialize)bsNation).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ((System.ComponentModel.ISupportInitialize)error1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnSubmit;
        private TextBox tbNom;
        private TextBox tbPrenom;
        private TextBox tbRemarque;
        private TextBox tbNais;
        private TextBox tbMort;
        private ComboBox cboNation;
        private ComboBox cboStyle;
        private Button btnCancel;
        private BindingSource bsNation;
        private BindingSource bsStyle;
        private ErrorProvider error1;
    }
}