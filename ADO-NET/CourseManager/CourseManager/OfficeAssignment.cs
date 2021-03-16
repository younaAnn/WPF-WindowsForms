using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseManager
{
    public partial class OfficeAssignment : Form
    {
        private SchoolEntities schoolContext;

        public OfficeAssignment()
        {
            InitializeComponent();
        }

        private void OfficeAssignment_Load(object sender, EventArgs e)
        {
            schoolContext = new SchoolEntities();
            var instrQuery = schoolContext.People.OfType<Instructor>();
            dataGridView1.DataSource = instrQuery.ToList();
            dataGridView1.Columns["HireDate"].Visible = false;
            dataGridView1.Columns["Timestamp"].Visible = false;
            dataGridView1.Columns["PersonID"].Visible = false;
            dataGridView1.Columns["EnrollmentDate"].Visible = false;
            dataGridView1.Columns["StudentGrades"].Visible = false;
            dataGridView1.Columns["Courses"].Visible = false;
        }

        private void officeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            schoolContext.SaveChanges();
            MessageBox.Show("Change(s) saved to the database.");
            Refresh();
        }
    }
}
