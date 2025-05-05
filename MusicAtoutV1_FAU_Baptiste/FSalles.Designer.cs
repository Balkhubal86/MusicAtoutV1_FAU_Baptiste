namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FSalles
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
            bsSalle = new BindingSource(components);
            dgvSalle = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsSalle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).BeginInit();
            SuspendLayout();
            // 
            // bsSalle
            // 
            bsSalle.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // dgvSalle
            // 
            dgvSalle.AllowUserToAddRows = false;
            dgvSalle.AllowUserToDeleteRows = false;
            dgvSalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalle.Location = new Point(24, 64);
            dgvSalle.Name = "dgvSalle";
            dgvSalle.ReadOnly = true;
            dgvSalle.Size = new Size(745, 346);
            dgvSalle.TabIndex = 0;
            // 
            // FSalles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSalle);
            Name = "FSalles";
            Text = "FSalles";
            Load += FSalles_Load;
            ((System.ComponentModel.ISupportInitialize)bsSalle).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalle).EndInit();
            ResumeLayout(false);
        }



        #endregion

        private BindingSource bsSalle;
        private DataGridView dgvSalle;
    }
}