using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.IO;

namespace Connect2DB_WEB_Service.Models
{
    public class DataPeople
    {
        /// <summary>
        /// Получение списка всех служащих
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployeeList()
        {
            List<Employee> list = new List<Employee>();

            DataContext context = new DataContext();

            foreach (var e in context.Employees)
            {
                list.Add(new Employee(e.FirstName, e.LastName, e.Dep, e.Salary) { Id = e.Id });


            }


            //проверяем считались ли данные из БД
            using (StreamWriter sw = new StreamWriter(@"C:\Users\cptn_n3mo\Desktop\GB\Course\Csharp2\Connect2DB_WEB_Service\bin\test.txt"))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item.GetType());

                }

            }

            return list;
        }
        /// <summary>
        /// Получение конкретного служащего по ID
        /// </summary>
        /// <param name="Id">Номер служащего в БД</param>
        /// <returns></returns>
        public Employee GetEMployeeById(int Id)
        {
            Employee tmpEmployee;
            using (DataContext context = new DataContext())
            {
                tmpEmployee = context.Employees.Where(e => e.Id == Id).FirstOrDefault();

            }
            return tmpEmployee;

        }
        /// <summary>
        /// Добавление нового служащего
        /// </summary>
        /// <param name="e">Данные нового служащего</param>
        /// <returns></returns>
        public bool AddEmployee(Employee e)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    context.Employees.Add(e);
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Удаление служащего
        /// </summary>
        /// <param name="Id">Номер служащего в БД</param>
        /// <returns></returns>
        public bool RemoveEmployee(int Id)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    context.Employees.Remove(context.Employees.Where(e => e.Id == Id).FirstOrDefault());
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Изменение данных служащего в БД
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public bool EditEmployee(Employee employee)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    Employee tmpUser = context.Employees.Where(e => e.Id == employee.Id).FirstOrDefault();

                    tmpUser.LastName = employee.LastName;
                    tmpUser.FirstName = employee.FirstName;
                    tmpUser.Dep = employee.Dep;
                    tmpUser.Salary = employee.Salary;

                    context.Entry(tmpUser).State = EntityState.Modified;
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Получение списка всех отделов
        /// </summary>
        /// <returns></returns>
        public List<Department> GetDepartmentList()
        {
            DataContext context = new DataContext();
            return context.Departments.ToList();
        }
        /// <summary>
        /// Добавление нового отдела
        /// </summary>
        /// <param name="d">Данные нового отдела</param>
        /// <returns></returns>
        public bool AddDepartament(Department d)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    context.Departments.Add(d);
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;


        }
        /// <summary>
        /// Удаление отдела
        /// </summary>
        /// <param name="Id">Номер отдела в БД</param>
        /// <returns></returns>
        public bool RemoveDepartment(int Id)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    context.Departments.Remove(context.Departments.FirstOrDefault(e => e.Id == Id));
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }
        /// <summary>
        /// Изменение данных отдела
        /// </summary>
        /// <param name="department">Данные отдела</param>
        /// <returns></returns>
        public bool EditDepartment(Department department)
        {
            try
            {
                using (DataContext context = new DataContext())
                {
                    var tmpDepartment = context.Departments.FirstOrDefault(d => d.Id == department.Id);
                    tmpDepartment.DP = department.DP;
                    context.Entry(tmpDepartment).State = EntityState.Modified;
                    context.SaveChanges();

                }

            }
            catch (Exception)
            {

                return false;
            }
            return true;

        }






    }
}