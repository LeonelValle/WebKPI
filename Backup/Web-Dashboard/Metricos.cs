using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Dashboard
{
    public class Metricos : Conexion
    {
        int id;
        int license_office;
        int license_av;
        int pc;
        int user;
        int laptop;
        float downtime;
        string username;
        DateTime dateReg;

        public int Id { get => id; set => id = value; }
        public int License_office { get => license_office; set => license_office = value; }
        public int License_av { get => license_av; set => license_av = value; }
        public int Pc { get => pc; set => pc = value; }
        public int User { get => user; set => user = value; }
        public int Laptop { get => laptop; set => laptop = value; }
        public float Downtime { get => downtime; set => downtime = value; }
        public string Username { get => username; set => username = value; }
        public DateTime DateReg { get => dateReg; set => dateReg = value; }
    }
}