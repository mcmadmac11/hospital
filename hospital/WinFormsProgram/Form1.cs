using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Storage;


namespace WinFormsProgram
{
    public partial class Form1 : Form
    {
         
        public Form1()
        {
            
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDoctorName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAppt_Click(object sender, EventArgs e)
        {
            Personnel.Patient patient = new Personnel.Patient();
            patient.SetName(textBoxName.Text);
            Personnel.Doctor doctor = new Personnel.Doctor();
            doctor.SetName(textBoxDoctorName.Text);

            

            Information.Appointment appointment = new Information.Appointment();
            Storage.Report report = new Report(patient, appointment, "");
            Storage.Database database = new Database();
            database.AddReport(report.ConstructReportXML());
            //report.OutputPatient();
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /*
        private void radButton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (DateTime selectedDate in radCalendar1.SelectedDates)
            {
                ListBox item = new ListBox();
                item.Text = selectedDate.ToShortDateString();
                listBox1.Items.Add(item);
            }
        }
        */


    }
}
