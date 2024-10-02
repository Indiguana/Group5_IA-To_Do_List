using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5_IA_To_Do_List
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void archived_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public enum myTags
        {
            IBEnglish = 0,
            IBCS = 1,
            German = 2,
            IBAnalysis = 3
        }

        private void myTags_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
