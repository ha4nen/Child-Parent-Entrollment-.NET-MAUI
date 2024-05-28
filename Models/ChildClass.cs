using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ChildClass
    {

        [PrimaryKey, AutoIncrement]
        public int C_Id { get; set; }
        public string C_Name { get; set; }
        public string C_L_Name { get; set; }
        public string C_Gender { get; set; }

        public bool C_IsFootball { get; set; }
        public bool C_IsSail { get; set; }
    }


}
