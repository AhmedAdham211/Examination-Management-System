using student.DAL.DALCourseName;
using System.Configuration;
using System.Data;
using System.Xml.Linq;

namespace student
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = BL.BLCourseName.BLCourseName.GetCourseName();
            if (dataTable.Rows.Count > 0)
            {
                comboBox1.DataSource = dataTable;
                comboBox1.DisplayMember = "CourseName"; // Column to display
                comboBox1.ValueMember = "CourseName";   // Value stored (optional)

                // Set the first item as selected (optional)
                comboBox1.SelectedIndex = -1;

                //textBox1.DataBindings.Add("text", dataTable, "CourseName");

                // Initially clear the DataGridView

            }
            else
            {
                MessageBox.Show("Not found", "No", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = null;
            //DataTable dtCourseCode = BL.BLCourseName.BLCourseName.GetCourseCode();
            //if (dataTable.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = dtCourseCode;
            //}

            DataTable dataTableTrack = BL.BLCourseName.BLCourseName.GetTrackName();
            if (dataTableTrack.Rows.Count > 0)
            {
                TrackCombo.DataSource = dataTableTrack;
                TrackCombo.DisplayMember = "TrackName"; // Column to display
                TrackCombo.ValueMember = "TrackName";   // Value stored (optional)

                // Set the first item as selected (optional)
                TrackCombo.SelectedIndex = -1;

                //textBox1.DataBindings.Add("text", dataTable, "CourseName");

                // Initially clear the DataGridView

            }
            else
            {
                MessageBox.Show("Not found", "No", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dataGridView1.DataSource = null;
            //DataTable dtCourseCode = BL.BLCourseName.BLCourseName.GetCourseCode();
            //if (dataTable.Rows.Count > 0)
            //{
            //    dataGridView1.DataSource = dtCourseCode;
            //}
        }




        // Get course names and bind to ComboBox


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // Check if a valid item is selected in the ComboBox
            if (comboBox1.SelectedItem != null && TrackCombo.SelectedItem == null)
            {
                // Retrieve the selected course name from the ComboBox
                string selectedCourseName = comboBox1.SelectedValue.ToString();

                // Call the BL method to get student data for the selected course
                DataTable studentData = BL.BLCourseName.BLCourseName.GetStudentsByCourse(selectedCourseName);

                // Check if any data was returned
                if (studentData.Rows.Count > 0)
                {
                    // Bind the retrieved data to the DataGridView
                    dataGridView1.DataSource = studentData;
                }
                //else
                //{
                //    // If no data is found, show a message and clear the DataGridView
                //    MessageBox.Show("No student data found for the selected course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    dataGridView1.DataSource = null; // Clear the DataGridView
                //}
            }
            else if (TrackCombo.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                string selectedTrackName = TrackCombo.SelectedValue.ToString();
                string selectedCourseName = comboBox1.SelectedValue.ToString();

                // Call the BL method to get student data for the selected course
                DataTable studentData = BL.BLCourseName.BLCourseName.GetStudentsByTrackAndCourse(selectedTrackName, selectedCourseName);

                // Check if any data was returned
                if (studentData.Rows.Count > 0)
                {
                    // Bind the retrieved data to the DataGridView
                    dataGridView1.DataSource = studentData;
                }
            }
            else
            {
                // If no item is selected, clear the DataGridView
                dataGridView1.DataSource = null;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TrackCombo.SelectedItem != null &&  comboBox1.SelectedItem == null && checkBox1.Checked)
            {
                // Retrieve the selected course name from the ComboBox
                string selectedTrackName = TrackCombo.SelectedValue.ToString();

                // Call the BL method to get student data for the selected course
                DataTable studentData = BL.BLCourseName.BLCourseName.GetStudentsByTrack(selectedTrackName);

                // Check if any data was returned
                if (studentData.Rows.Count > 0)
                {
                    // Bind the retrieved data to the DataGridView
                    dataGridView1.DataSource = studentData;
                }
                //if(checkBox1.Checked = false)
                //    dataGridView1.DataSource = studentData;
                //else
                //{
                //    // If no data is found, show a message and clear the DataGridView
                //    MessageBox.Show("No student data found for the selected course.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    dataGridView1.DataSource = null; // Clear the DataGridView
                //}
            }
            //else if (checkBox1.Checked == false)
            //{
            //    dataGridView1 = null;
            //}
            else if (TrackCombo.SelectedItem != null && comboBox1.SelectedItem != null)
            {
                string selectedTrackName = TrackCombo.SelectedValue.ToString();
                string selectedCourseName = comboBox1.SelectedValue.ToString();

                // Call the BL method to get student data for the selected course
                DataTable studentData = BL.BLCourseName.BLCourseName.GetStudentsByTrackAndCourse(selectedTrackName, selectedCourseName);

                // Check if any data was returned
                if (studentData.Rows.Count > 0)
                {
                    // Bind the retrieved data to the DataGridView
                    dataGridView1.DataSource = studentData;
                }
            }
            else
            {
                // If no item is selected, clear the DataGridView
                dataGridView1.DataSource = null;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkBox1.Checked)
            //{
            //    MessageBox.Show("Checkbox is checked!");
            //}
            //else
            //{
            //    MessageBox.Show("Checkbox is unchecked!");
            //}

        }
    }
}
