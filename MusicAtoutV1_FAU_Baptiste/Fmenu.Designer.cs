namespace MusicAtoutV1_FAU_Baptiste
{
    partial class Fmenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmenu));
            MenuUser1 = new MenuStrip();
            listesToolStripMenuItem = new ToolStripMenuItem();
            villesToolStripMenuItem = new ToolStripMenuItem();
            sallesToolStripMenuItem = new ToolStripMenuItem();
            batimentsToolStripMenuItem = new ToolStripMenuItem();
            typesDoeuvreToolStripMenuItem = new ToolStripMenuItem();
            compositeurToolStripMenuItem = new ToolStripMenuItem();
            parNationalitéToolStripMenuItem = new ToolStripMenuItem();
            parStyleToolStripMenuItem = new ToolStripMenuItem();
            oeuvresToolStripMenuItem = new ToolStripMenuItem();
            utilisateursToolStripMenuItem = new ToolStripMenuItem();
            gestionToolStripMenuItem = new ToolStripMenuItem();
            ajouterToolStripMenuItem = new ToolStripMenuItem();
            supprimerToolStripMenuItem = new ToolStripMenuItem();
            changementMdpToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            btn_deco = new Button();
            MenuUser1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MenuUser1
            // 
            MenuUser1.Items.AddRange(new ToolStripItem[] { listesToolStripMenuItem, compositeurToolStripMenuItem, oeuvresToolStripMenuItem, utilisateursToolStripMenuItem });
            MenuUser1.Location = new Point(0, 0);
            MenuUser1.Name = "MenuUser1";
            MenuUser1.Size = new Size(907, 24);
            MenuUser1.TabIndex = 0;
            MenuUser1.Text = "menuStrip1";
            // 
            // listesToolStripMenuItem
            // 
            listesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { villesToolStripMenuItem, sallesToolStripMenuItem, batimentsToolStripMenuItem, typesDoeuvreToolStripMenuItem });
            listesToolStripMenuItem.Name = "listesToolStripMenuItem";
            listesToolStripMenuItem.Size = new Size(48, 20);
            listesToolStripMenuItem.Text = "Listes";
            // 
            // villesToolStripMenuItem
            // 
            villesToolStripMenuItem.Name = "villesToolStripMenuItem";
            villesToolStripMenuItem.Size = new Size(152, 22);
            villesToolStripMenuItem.Text = "Villes";
            villesToolStripMenuItem.Click += villesToolStripMenuItem_Click;
            // 
            // sallesToolStripMenuItem
            // 
            sallesToolStripMenuItem.Name = "sallesToolStripMenuItem";
            sallesToolStripMenuItem.Size = new Size(152, 22);
            sallesToolStripMenuItem.Text = "Salles";
            sallesToolStripMenuItem.Click += sallesToolStripMenuItem_Click;
            // 
            // batimentsToolStripMenuItem
            // 
            batimentsToolStripMenuItem.Name = "batimentsToolStripMenuItem";
            batimentsToolStripMenuItem.Size = new Size(152, 22);
            batimentsToolStripMenuItem.Text = "Batiments";
            batimentsToolStripMenuItem.Click += batimentsToolStripMenuItem_Click;
            // 
            // typesDoeuvreToolStripMenuItem
            // 
            typesDoeuvreToolStripMenuItem.Name = "typesDoeuvreToolStripMenuItem";
            typesDoeuvreToolStripMenuItem.Size = new Size(152, 22);
            typesDoeuvreToolStripMenuItem.Text = "Types d'oeuvre";
            typesDoeuvreToolStripMenuItem.Click += typesDoeuvreToolStripMenuItem_Click;
            // 
            // compositeurToolStripMenuItem
            // 
            compositeurToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { parNationalitéToolStripMenuItem, parStyleToolStripMenuItem });
            compositeurToolStripMenuItem.Name = "compositeurToolStripMenuItem";
            compositeurToolStripMenuItem.Size = new Size(88, 20);
            compositeurToolStripMenuItem.Text = "Compositeur";
            // 
            // parNationalitéToolStripMenuItem
            // 
            parNationalitéToolStripMenuItem.Name = "parNationalitéToolStripMenuItem";
            parNationalitéToolStripMenuItem.Size = new Size(150, 22);
            parNationalitéToolStripMenuItem.Text = "Par nationalité";
            parNationalitéToolStripMenuItem.Click += parNationalitéToolStripMenuItem_Click;
            // 
            // parStyleToolStripMenuItem
            // 
            parStyleToolStripMenuItem.Name = "parStyleToolStripMenuItem";
            parStyleToolStripMenuItem.Size = new Size(150, 22);
            parStyleToolStripMenuItem.Text = "Par style";
            parStyleToolStripMenuItem.Click += parStyleToolStripMenuItem_Click;
            // 
            // oeuvresToolStripMenuItem
            // 
            oeuvresToolStripMenuItem.Name = "oeuvresToolStripMenuItem";
            oeuvresToolStripMenuItem.Size = new Size(62, 20);
            oeuvresToolStripMenuItem.Text = "Oeuvres";
            oeuvresToolStripMenuItem.Click += oeuvresToolStripMenuItem_Click;
            // 
            // utilisateursToolStripMenuItem
            // 
            utilisateursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { gestionToolStripMenuItem, ajouterToolStripMenuItem, supprimerToolStripMenuItem, changementMdpToolStripMenuItem });
            utilisateursToolStripMenuItem.Name = "utilisateursToolStripMenuItem";
            utilisateursToolStripMenuItem.Size = new Size(77, 20);
            utilisateursToolStripMenuItem.Text = "Utilisateurs";
            // 
            // gestionToolStripMenuItem
            // 
            gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            gestionToolStripMenuItem.Size = new Size(180, 22);
            gestionToolStripMenuItem.Text = "Gestion";
            gestionToolStripMenuItem.Click += gestionToolStripMenuItem_Click_1;
            // 
            // ajouterToolStripMenuItem
            // 
            ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            ajouterToolStripMenuItem.Size = new Size(180, 22);
            ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // supprimerToolStripMenuItem
            // 
            supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            supprimerToolStripMenuItem.Size = new Size(180, 22);
            supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // changementMdpToolStripMenuItem
            // 
            changementMdpToolStripMenuItem.Name = "changementMdpToolStripMenuItem";
            changementMdpToolStripMenuItem.Size = new Size(180, 22);
            changementMdpToolStripMenuItem.Text = "Changement mdp";
            changementMdpToolStripMenuItem.Click += changementMdpToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(54, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(760, 361);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btn_deco
            // 
            btn_deco.BackColor = Color.IndianRed;
            btn_deco.Location = new Point(26, 462);
            btn_deco.Name = "btn_deco";
            btn_deco.Size = new Size(92, 23);
            btn_deco.TabIndex = 2;
            btn_deco.Text = "Déconnexion";
            btn_deco.UseVisualStyleBackColor = false;
            btn_deco.Click += button1_Click;
            // 
            // Fmenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 505);
            Controls.Add(btn_deco);
            Controls.Add(pictureBox1);
            Controls.Add(MenuUser1);
            MainMenuStrip = MenuUser1;
            Name = "Fmenu";
            Text = "FMenu";
            Load += Fmenu_Load;
            MenuUser1.ResumeLayout(false);
            MenuUser1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuUser1;
        private ToolStripMenuItem listesToolStripMenuItem;
        private ToolStripMenuItem villesToolStripMenuItem;
        private ToolStripMenuItem sallesToolStripMenuItem;
        private ToolStripMenuItem batimentsToolStripMenuItem;
        private ToolStripMenuItem typesDoeuvreToolStripMenuItem;
        private PictureBox pictureBox1;
        private ToolStripMenuItem compositeurToolStripMenuItem;
        private ToolStripMenuItem parNationalitéToolStripMenuItem;
        private ToolStripMenuItem parStyleToolStripMenuItem;
        private ToolStripMenuItem oeuvresToolStripMenuItem;
        private ToolStripMenuItem utilisateursToolStripMenuItem;
        private ToolStripMenuItem gestionToolStripMenuItem;
        private ToolStripMenuItem ajouterToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private Button btn_deco;
        private ToolStripMenuItem changementMdpToolStripMenuItem;
    }
}
