using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Connect2DB_WEB_Service.Models
{
    public class BaseDepartment
    {
        private string dp;
        private int id;
        public virtual string DP { get => dp; set => dp = value; }
        public virtual int Id { get => id; set => id = value; }


    }

}