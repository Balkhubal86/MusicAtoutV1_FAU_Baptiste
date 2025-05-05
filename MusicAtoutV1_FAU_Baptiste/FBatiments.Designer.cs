namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FBatiments
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
            bsBatiments = new BindingSource(components);
            dgvBatiments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)bsBatiments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiments).BeginInit();
            SuspendLayout();
            // 
            // bsBatiments
            // 
            bsBatiments.CurrentChanged += bsBatiments_CurrentChanged;
            // 
            // dgvBatiments
            // 
            dgvBatiments.AllowUserToAddRows = false;
            dgvBatiments.AllowUserToDeleteRows = false;
            dgvBatiments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBatiments.Location = new Point(30, 56);
            dgvBatiments.Name = "dgvBatiments";
            dgvBatiments.ReadOnly = true;
            dgvBatiments.Size = new Size(734, 363);
            dgvBatiments.TabIndex = 0;
            dgvBatiments.CellContentClick += dgvBatiments_CellContentClick;
            // 
            // FBatiments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvBatiments);
            Name = "FBatiments";
            Text = "FBatiments";
            Load += FBatiments_Load;
            ((System.ComponentModel.ISupportInitialize)bsBatiments).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBatiments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bsBatiments;
        private DataGridView dgvBatiments;
    }
}