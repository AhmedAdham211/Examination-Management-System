using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using student.DAL.DALCourseName;

namespace student.BL.BLCourseName
{
    public class BLCourseName
    {
        //get course Name in combobox course
        public static DataTable GetCourseName()
        {
            //create command 
            SqlCommand cmd = new SqlCommand("Course_name");
            cmd.CommandType = CommandType.StoredProcedure;
            return DAL.DALCourseName.CourseName.Select(cmd);                //الفولدر الخاص بالداتالير 
        }

        //get Track Name in combobox Track
        public static DataTable GetTrackName()
        {
            //create command 
            SqlCommand cmd = new SqlCommand("Track_name");
            cmd.CommandType = CommandType.StoredProcedure;
            return DAL.DALCourseName.CourseName.Select(cmd);                //الفولدر الخاص بالداتالير 
        }




        // Method in the BL layer to retrieve student data related to a specific course
        public static DataTable GetStudentsByCourse(string courseName)
        {
            // Call the DAL method to get the student data for the specified course
            return DAL.DALCourseName.CourseName.GetStudentsByCourse(courseName);
        }


        // Method in the BL layer to retrieve student data related to a specific track
        public static DataTable GetStudentsByTrack(string trackName)
        {
            // Call the DAL method to get the student data for the specified course
            return DAL.DALCourseName.CourseName.GetStudentsByTrack(trackName);
        }

        // Method in the BL layer to retrieve student data related to a specific track & course
        public static DataTable GetStudentsByTrackAndCourse(string trackName, string courseName)
        {
            // Call the DAL method to get the student data for the specified course
            return DAL.DALCourseName.CourseName.GetStudentsByTrackAndCourse(trackName, courseName);
        }
    }
}
