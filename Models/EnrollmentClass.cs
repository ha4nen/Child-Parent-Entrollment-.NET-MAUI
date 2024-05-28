using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class EnrollmentClass
    {
        [PrimaryKey, AutoIncrement]
        public int E_Id { get; set; }
        public int P_Id { get; set; }
        public int C_Id { get; set; }


    }
}
