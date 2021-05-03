using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeManagementMvc.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeManagementMvc.Controllers
{
    public class HomeController : Controller
    {

        String connectionString = "Server=RAED_COMPUTER\\SQLEXPRESS;Database=EmployeeManagementSystem;Trusted_Connection=True;";
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("EmployeeSave", connection);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Name", employee.Name);
            command.Parameters.AddWithValue("Age", employee.Age);
            command.Parameters.AddWithValue("Email", employee.Email);
            command.ExecuteNonQuery();
            connection.Close();
            ViewData["Message"] = "Employee Records" + employee.Name + "Is Saved Successfully";

            return View(employee);
        }
    }
}