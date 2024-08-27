using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {

        DelegateNumber delegateNumber;
        DelegateText delegateText;

        public FrmRegistration()
        {
            InitializeComponent();

            ProgramCB.Items.Add("BS in Computer Science");
            ProgramCB.Items.Add("BS in Information Technology");
            ProgramCB.Items.Add("BS in Computer Engineering");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = FirstNameB.Text.ToString();
            StudentInfoClass.LastName = LastNameB.Text.ToString();
            StudentInfoClass.MiddleName = MiddleNameB.Text.ToString();
            StudentInfoClass.Address = AddressB.Text.ToString();
            StudentInfoClass.Program = ProgramCB.Text.ToString();
            StudentInfoClass.Age = (long)Convert.ToDouble(AgeB.Text.ToString());
            StudentInfoClass.ContactNo = (long)Convert.ToDouble(ContactNoB.Text.ToString());
            StudentInfoClass.StudentNo = (long)Convert.ToDouble(StudNoB.Text.ToString());

            FrmConfirm frmConfirm = new FrmConfirm();
            frmConfirm.ShowDialog();
        }
            
       
    }
}
