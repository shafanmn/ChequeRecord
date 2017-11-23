using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChequeRecord.MainForms
{
    public partial class frmReceiveCheque : Form
    {
        Classes.MyClasses my = new Classes.MyClasses();
        public frmReceiveCheque()
        {
            InitializeComponent();
        }

        private void frmReceiveCheque_Load(object sender, EventArgs e)
        {
            my.fillCombo(cmbBank, "SELECT name FROM banks;","name");
        }
    }
}
