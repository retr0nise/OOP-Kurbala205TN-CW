using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Kurbala205TN_CW
{
    public partial class SettingForm : Form
    {
        private MainForm mainForm;
        public SettingForm(MainForm form)
        {    mainForm = form;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lines = int.Parse(LineBox.Text);
            int columns = int.Parse(ColumnsBox.Text);
            string path = PathBox.Text;
            string savepath = SavingBox.Text;
            mainForm.setparameters(lines, columns, path, savepath);
            this.Close();
        }
    }

}
