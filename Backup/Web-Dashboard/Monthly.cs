namespace Web_Dashboard
{
    public class Monthly : Conexion
    {
        static int id_clm;
        public bool WindowsUpdates { get; set; }
        public string Comment_WindowsUpdates { get; set; }
        public bool UpdateMeraki { get; set; }
        public string Comment_UpdateMeraki { get; set; }
        public bool UpdatesWAP { get; set; }
        public string Comment_UpdatesWAP { get; set; }
        public int Id_clm { get => id_clm; set => id_clm = value; }
    }
}