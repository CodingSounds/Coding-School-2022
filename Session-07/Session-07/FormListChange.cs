using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_07
{
    public partial class FormListChange : Form
    {
        public string TextForward { get; set; }
        public FormListChange()
        {
            InitializeComponent();
            
        }

        private void FormListChange_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string info = string.Empty;
                info = textEdit1.Text;
                TextForward = info;
                this.DialogResult = DialogResult.OK;


            }
            
        }
    }
}
