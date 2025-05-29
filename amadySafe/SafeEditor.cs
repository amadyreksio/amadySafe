using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amadySafe
{
    public partial class SafeEditor : Form
    {
        bool visible = false;
        public SafeEditor()
        {
            InitializeComponent();
        }

        private void SafeEditor_Load(object sender, EventArgs e)
        {
            textBox1.Text = dane.mainform.password;
        }

        private void amadyButton2_Click(object sender, EventArgs e)
        {
            visible=!visible;
            textBox1.PasswordChar = visible?'\0': '•';
            amadyButton2.Icon = visible ? Properties.Resources.hide : Properties.Resources.show;
        }

        private void amadyButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty) return;
            dane.mainform.applySettings(textBox1.Text);
            this.Close();
        }
    }
}
