using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Dashboard
{
    public class CheckLists : Conexion
    {
        public int id_cl { get; set; }
        public bool Salarma { get; set; }
        public string SalarmaCom { get; set; }
        public bool Sled { get; set; }
        public string SledCom { get; set; }
        public bool ACfunciona { get; set; }
        public string ACfuncionaCom { get; set; }
        public bool AVdeteccion { get; set; }
        public string ACdeteccionCom { get; set; }
        public string username { get; set; }
        public DateTime fecha { get; set; }
    }
}