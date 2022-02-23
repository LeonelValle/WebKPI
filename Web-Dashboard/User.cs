namespace Web_Dashboard
{
    public class User : Conexion
    {
        string username;
        string email;
        int nemploy;
        static string name;

        public string Username { get => username; set => username = value; }
        public string Email { get => email; set => email = value; }
        public int Nemploy { get => nemploy; set => nemploy = value; }
        public string Name { get => name; set => name = value; }
    }
}