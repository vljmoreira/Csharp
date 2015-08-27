using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectoCursos
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //mostrar a data formato diminuto
            toolStripStatusLabel2.Text = DateTime.Now.ToShortDateString();
            //mostrar a hora
            toolStripStatusLabel3.Text = DateTime.Now.ToShortTimeString();
        }
    }
}
