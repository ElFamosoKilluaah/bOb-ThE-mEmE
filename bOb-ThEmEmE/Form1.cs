using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bOb_ThEmEmE {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }
        private String text;
        /*
         * That's a retarded program.
         */
        private void pictureBox1_Click(object sender, EventArgs e) {
            StringBuilder sb = new StringBuilder();
            Boolean maj = false;

            foreach (char c in text) {
                if (maj) sb.Append(c.ToString().ToUpper());

                else sb.Append(c.ToString());

                maj = !maj;
            }
            MessageBox.Show("Copied to clipboard");
            Clipboard.SetText(sb.ToString());

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            text = textBox1.Text.ToLower();
        }
    }
}
