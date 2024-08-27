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

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {

        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);

            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);


            StudNoL.Text = DelStudNo(StudentInfoClass.StudentNo).ToString();
            ProgramL.Text = DelProgram(StudentInfoClass.Program).ToString();
            LastNameL.Text = DelLastName(StudentInfoClass.LastName).ToString();
            FirstNameL.Text = DelFirstName(StudentInfoClass.FirstName).ToString();
            MiddleNameL.Text = DelMiddleName(StudentInfoClass.MiddleName).ToString();   

            AgeL.Text = DelNumAge(StudentInfoClass.Age).ToString();
            ContactNoL.Text = DelNumContactNo(StudentInfoClass.ContactNo).ToString();
            AddressL.Text = DelAddress(StudentInfoClass.Address).ToString();

        }

    }
}
