using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaApp.WForm
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bttmLimpiar_Click(object sender, EventArgs e)
        {
            txtFirstName.ResetText();
            txtLastName.ResetText();
            txtCreationD.ResetText();
            txtCreatioU.ResetText();
            txtDeleted.ResetText();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("First Name");
            dt.Columns.Add("Last Name");
            dt.Columns.Add("Creation Date");
            dt.Columns.Add("Creation User");
            dt.Columns.Add("Deleted");

            DataRow dr = dt.NewRow();
            dr[0] = "1";
            dr[1] = "Wagner";
            dr[2] = "Matos";
            dr[3] = DateTime.Now.ToString();
            dr[4] = "1";
            dr[5] = "0";
            dt.Rows.Add(dr);

            DataRow dr2 = dt.NewRow();
            dr2[0] = "2";
            dr2[1] = "Eliezer";
            dr2[2] = "Vargas";
            dr2[3] = DateTime.UtcNow.ToString();
            dr2[4] = "1";
            dr2[5] = "0";
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3[0] = "3";
            dr3[1] = "Rusbel";
            dr3[2] = "Rodriguez";
            dr3[3] = DateTime.Today.ToString();
            dr3[4] = "1";
            dr3[5] = "0";
            dt.Rows.Add(dr3);

            gridStudents.DataSource = dt;
        }
    }
}

