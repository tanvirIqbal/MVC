using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModel.Models
{
    public class StudentBinder : IModelBinder
    {
        
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            HttpContextBase obj = controllerContext.HttpContext;
            string studentCode = obj.Request.Form["txtStudentCode"];
            string studentName = obj.Request.Form["txtStudentName"];

            Student oStudent = new Student();
            oStudent.StudentCode = studentCode;
            oStudent.StudentName = studentName;

            return oStudent;
        }
    }
}