using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace student.DAL.DALCourseName
{
    public class CourseName
    {
        static SqlConnection con = new SqlConnection(Connection.ConString);


        //private static readonly string con = Connection.ConString;
        public static DataTable Select(SqlCommand _cmd)
        {
            
            //command with connection
            _cmd.Connection = con;

            //exe command with sql Datatable
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);

            
            adapter.Fill(dt);
            return dt;
        }



        // Method in the DAL layer to retrieve student data related to a specific course
        public static DataTable GetStudentsByCourse(string courseName)
        {
            // Create a SqlCommand object to execute the stored procedure
            SqlCommand cmd = new SqlCommand("SPStudents_course");
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the @CourseName parameter to the command with the provided course name
            cmd.Parameters.AddWithValue("@CourseName", courseName);

            // Call the Select method (assumed to be defined elsewhere in the DAL) to execute the command and return a DataTable
            return Select(cmd);
        }


        // Method in the DAL layer to retrieve student data related to a specific course
        public static DataTable GetStudentsByTrack(string trackName)
        {
            // Create a SqlCommand object to execute the stored procedure
            SqlCommand cmd = new SqlCommand("SPStudents_Track");
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the @CourseName parameter to the command with the provided course name
            cmd.Parameters.AddWithValue("@TrackName", trackName);

            // Call the Select method (assumed to be defined elsewhere in the DAL) to execute the command and return a DataTable
            return Select(cmd);
        }


        // Method in the DAL layer to retrieve student data related to a specific Track & course
        public static DataTable GetStudentsByTrackAndCourse(string trackName, string courseName)
        {
            // Create a SqlCommand object to execute the stored procedure
            SqlCommand cmd = new SqlCommand("SPStudents_Track_course");
            cmd.CommandType = CommandType.StoredProcedure;

            // Add the @CourseName parameter to the command with the provided course name
            cmd.Parameters.AddWithValue("@TrackName", trackName);
            cmd.Parameters.AddWithValue("@CourseName", courseName);

            // Call the Select method (assumed to be defined elsewhere in the DAL) to execute the command and return a DataTable
            return Select(cmd);
        }
    }
}
