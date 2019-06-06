using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Connect2DB_WEB_Service.Models
{
    public class DataContext:DbContext
    {
        //Отображение таблиц базы данных на свойства с типом DbSet
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        /// <summary>
        /// Создать БД со строкой подключения "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_test;Integrated Security=True;Pooling=False"
        /// </summary>
        public DataContext():base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB_test5;Integrated Security=True;Pooling=False")
        {

        }
    }
}