using MusicAtoutV1_FAU_Baptiste.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MusicAtoutV1_FAU_Baptiste
{
    public partial class FConnexion : Form
    {
        public FConnexion()
        {
            InitializeComponent();
        }

        private void FConnexion_Load(object sender, EventArgs e)
        {
            
        }

        public static void ThreadProc()
        {
            Application.Run(new Fmenu());
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (ModelProjet.validConnexion(tbLogin.Text, tbPassword.Text))
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                t.Start();
                this.Close();
            }
        }
    }
}
