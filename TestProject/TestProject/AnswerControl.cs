using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProject
{
    public partial class AnswerControl : UserControl
    {
        private EditForm editForm;
        public AnswerControl(EditForm editForm)
        {
            InitializeComponent();
            this.editForm = editForm;
        }

        public void btRemove_Click(object sender, EventArgs e)
        {
            editForm.AnswerRemove(this, e);
        }
    }
}
