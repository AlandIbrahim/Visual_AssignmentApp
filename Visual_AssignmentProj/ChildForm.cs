using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_AssignmentProj
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();


            //extra stuff (for fun):
            unchecked
            {
                //generate "random" object
                Random r= new Random();
                //assign an integer a random value from its lowest value to its highest.
                int val=r.Next(int.MinValue, int.MaxValue);
                //use "|=" aka "OR" to add full opacity to the color (because backColor doesn't support transparency)
                val |= (int)0xff000000;
                //use our processed value to create a color from Argb color system and assign it to the BackColor.
            BackColor = Color.FromArgb(val);
            }
            //end of the extra stuff.
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
