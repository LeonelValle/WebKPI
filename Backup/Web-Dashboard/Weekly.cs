using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Dashboard
{
    public class Weekly : Conexion
    {
		static int id_clw;
		public bool MoverFuerabkp { get; set; }
		public string Comment_MoverFuerabkp { get; set; }
		public bool ControlAccesobkp { get; set; }
		public string Comment_ControlAccesobkp { get; set; }
		public bool RevisionClientesWIFI { get; set; }
		public string Comment_RevisionClientesWIFI { get; set; }
        public int Id_clw { get => id_clw; set => id_clw = value; }
    }
}