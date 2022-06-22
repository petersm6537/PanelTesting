using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelTesting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Back button pressed, move back a tab
            int selectedTab = -1;
            selectedTab = tabControl1.SelectedIndex;
            if(selectedTab >= 1)
            {
                tabControl1.SelectedIndex = selectedTab - 1;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //OK button pressed, move forward a tab
            int selectedTab = -1;
            selectedTab = tabControl1.SelectedIndex;
            if (selectedTab <= 5)
            {
                tabControl1.SelectedIndex = selectedTab + 1;
            }
        }
    }
}
