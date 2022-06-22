using FirstDBApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FirstDBApp.Controllers
{
    public class HomeController : Controller
    {
        SqlConnection con = new SqlConnection("Server=AMITPC;Database=AnyDB;User Id=sa;Password=abc123;");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public IActionResult Index()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from EmployeeTB";
            dr = com.ExecuteReader();

            while(dr.Read())
            {
                var emp = new EmployeeModel
                {
                    id = dr.GetInt32(0),
                    name=dr.GetString(1),
                    email = dr.GetString(2),
                    phone = dr.GetString(3),
                };

                employees.Add(emp);
            }

            ViewBag.emplist = employees;

            return View();
        }

        [HttpPost]
        public IActionResult AddNewRecord(int id, string name, string email, string phone)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Insert into EmployeeTB values(" + id + ",'" + name + "','" + email + "','" + phone + "')";

                com.ExecuteNonQuery();

                con.Close();

                TempData["message"] = "Data Saved Successfully";
                return RedirectToAction("Index", "Home");
            }
            catch(Exception ex)
            {
                if(con.State==System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

                TempData["message"] = "Data Save Failed";
                return RedirectToAction("Index", "Home");
            }
        } 

        [HttpPost]
        public JsonResult FindRecord(int cusid)
        {
            con.Open();
            com.Connection = con;
            com.CommandText = "Select * from EmployeeTB where id=" + cusid;
            dr = com.ExecuteReader();

            var emp = new EmployeeModel();

            while(dr.Read())
            {
                emp.id = dr.GetInt32(0);
                emp.name = dr.GetString(1);
                emp.email = dr.GetString(2);
                emp.phone = dr.GetString(3);
            }

            return Json(emp);
        }



        [HttpPost]
        public IActionResult EditRecord(int id, string name, string email, string phone)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Update EmployeeTB set name='" + name + "', email='" + email + "', phone='" + phone + "' where id=" + id;

                com.ExecuteNonQuery();

                con.Close();

                TempData["message"] = "Data Updated Successfully";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

                TempData["message"] = "Data Update Failed";
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult DeleteRecord(int id)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Delete from EmployeeTB where id=" + id;

                com.ExecuteNonQuery();

                con.Close();

                TempData["message"] = "Data Deleted Successfully";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }

                TempData["message"] = "Data Deletion Failed";
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
