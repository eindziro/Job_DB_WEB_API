using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Connect2DB_WEB_Service.Models
{
    [Serializable]
    public class BaseEmployee
    {
        private int id;
        private string firstname;
        private string lastname;
        private string department;
        private int salary;

        public virtual int Id { get => id; set => id = value; }
        public virtual string FirstName { get => firstname; set => firstname = value; }
        public virtual string LastName { get => lastname; set => lastname = value; }
        public virtual string Dep { get => department; set => department = value; }
        public virtual int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"{firstname} {lastname} {department} {salary}";
        }




    }

}