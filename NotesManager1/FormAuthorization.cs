using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesManager1
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }

        private void EntranceBtn_Click(object sender, EventArgs e)
        {
            // Check Authorization Code
            FormNotesManager fNotes = new FormNotesManager(this);
            fNotes.Show();
            this.Hide();
        }
    }
}
