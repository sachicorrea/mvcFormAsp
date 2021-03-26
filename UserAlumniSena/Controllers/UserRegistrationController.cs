using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using UserAlumniSena.Models;

namespace UserAlumniSena.Controllers
{
    public class UserRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserRegClass ur)
        {
            string connection = "Data Source=DESKTOP-KU3FQ7M\\santi;Initial Catalog=MVCAlumniSena;Integrated Security=True";

            using (SqlConnection sqlconn = new SqlConnection(connection))
            {
                string sqlquery = "insert into(Usr_doc, Usr_kind_doc, Usr_name, Usr_phonenum, Usr_email, Usr_gender, Usr_category, Usr_program, Usr_startdate, Usr_address, Usr_neighborhood, Usr_city, Usr_province, Usr_dateregistr) values('" +ur.Usr_doc+ "', '" +ur.Usr_kind_doc+ "', '" + ur.Usr_name + "', '" + ur.Usr_phonenum + "', '" + ur.Usr_email + "', '" + ur.Usr_gender + "', '" + ur.Usr_category + "', '" + ur.Usr_program + "', '" + ur.Usr_startdate + "', '" + ur.Usr_address + "', '" + ur.Usr_neighborhood + "', '" + ur.Usr_city + "', '" + ur.Usr_province + "', '" + ur.Usr_dateregistr + "')";

                using (SqlCommand sqlcomm = new SqlCommand(sqlquery, sqlconn))
                {
                    sqlconn.Open();
                    sqlcomm.ExecuteNonQuery();
                    ViewData["Message"] = "The student/alumnus " + ur.Usr_name + " was saved correctly";
                 }
            }
            
            return View(ur);
        }

    }
}
