using MauiApp1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.DataTransactions
{

    public class DBTrans
    {
        public string dbPath;
        private SQLiteConnection conn;

        public DBTrans(string _dbPath)
        {
            this.dbPath = _dbPath;
        }
        public void InitC()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<ChildClass>();
        }
        public void InitP()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<ParentsClass>();
        }
        public void InitE()
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.CreateTable<EnrollmentClass>();
        }

        public List<ChildClass> GetAllChild()
        {
            InitC();
            return conn.Table<ChildClass>().ToList();
        }
        public List<ParentsClass> GetAllParents()
        {
            InitP();
            return conn.Table<ParentsClass>().ToList();
        }
        public List<EnrollmentClass> GetAllEntroll()
        {
            InitE();
            return conn.Table<EnrollmentClass>().ToList();
        }

        public void AddC(ChildClass student)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(student);
        }
        public void AddP(ParentsClass course)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(course);
        }
        public void AddE(EnrollmentClass entroll)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Insert(entroll);
        }

        public void DeleteC(int student_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new ChildClass { C_Id = student_id });
        }
        public void DeleteP(int course_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new ParentsClass { P_Id = course_id });
        }
        public void DeleteE(int entroll_id)
        {
            conn = new SQLiteConnection(this.dbPath);
            conn.Delete(new EnrollmentClass { E_Id = entroll_id });
        }
    }
}

