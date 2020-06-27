using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GYM.Klase;

namespace GYM
{
    public partial class arhiva : UserControl
    {
        GymEntities10 vezasaBazom;
        public arhiva()
        {
            InitializeComponent();
            vezasaBazom = new GymEntities10();
            popuniTabeluArhiva();
            this.Dock = DockStyle.Fill;
        }

        private void popuniTabeluArhiva()
        {
            var termini = Bazaa.popuniTabeluarhiva();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = termini;
        }
    }
}
