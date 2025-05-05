namespace MusicAtoutV1_FAU_Baptiste
{
    partial class FTypesOeuvres
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
            dgvTO = new DataGridView();
            bsTO = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvTO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsTO).BeginInit();
            SuspendLayout();
            // 
            // dgvTO
            // 
            dgvTO.AllowUserToAddRows = false;
            dgvTO.AllowUserToDeleteRows = false;
            dgvTO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTO.Location = new Point(28, 29);
            dgvTO.Name = "dgvTO";
            dgvTO.ReadOnly = true;
            dgvTO.Size = new Size(732, 384);
            dgvTO.TabIndex = 0;
            // 
            // FTypesOeuvres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTO);
            Name = "FTypesOeuvres";
            Text = "FTypesOeuvres";
            Load += FTypesOeuvres_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTO).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsTO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTO;
        private BindingSource bsTO;
    }
}