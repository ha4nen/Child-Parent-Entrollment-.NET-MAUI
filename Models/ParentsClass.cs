using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class ParentsClass
    {

        [PrimaryKey, AutoIncrement]
        public int P_Id { get; set; }
        public string P_Name { get; set; }
        public string P_L_Name { get; set; }
        public string P_Tel { get; set; }
        public string P_Mother_Father { get; set; }

    }
}
