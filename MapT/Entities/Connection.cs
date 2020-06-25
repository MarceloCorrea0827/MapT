namespace MapT.Entities

{
    public class Connection
    {
        public string User { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Dbname { get; set; }

        public Connection(string user, string password, string host, string dbname)
        {
            User = user;
            Password = password;
            Host = host;
            Dbname = dbname;
        }

        public string StringConexao()
        {
            return $"PG:host={Host} dbname={Dbname} user={User} password={Password}";
        }
    }
}
