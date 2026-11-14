using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DAL;

namespace WebUI
{
    public partial class Students : System.Web.UI.Page
    {
        private readonly StudentService _studentService = new StudentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindStudentGrid();
            }
        }

        private void BindStudentGrid()
        {
            var students = _studentService.GetAllStudents();
            gvStudents.DataSource = students;
            gvStudents.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentName = txtName.Text,
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text),
                DateOfBirth = DateTime.Now, 
                YearOfEnroll = DateTime.Now.Year,
                Major = "IT",
                GPA = 0
            };
            _studentService.AddStudent(student);
            Response.Write("Đã thêm sinh viên thành công!");
            BindStudentGrid();
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var student = _studentService.GetStudent(id);
            if (student != null)
            {
                txtName.Text = student.StudentName;
                txtCity.Text = student.City;
                txtAge.Text = student.Age.ToString();
            }
            else
            {
                Response.Write("Không tìm thấy sinh viên!");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                StudentID = int.Parse(txtId.Text),
                StudentName = txtName.Text,
                City = txtCity.Text,
                Age = int.Parse(txtAge.Text)
            };
            _studentService.UpdateStudent(student);
            Response.Write("Đã cập nhật sinh viên thành công!");
            BindStudentGrid();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            _studentService.DeleteStudent(id);
            Response.Write("Đã xóa sinh viên thành công!");
            BindStudentGrid();
        }
    }
}