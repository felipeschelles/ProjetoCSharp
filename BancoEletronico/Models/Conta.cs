namespace Models
{
    public abstract class Conta
    {


        public int Numero { get; set; }

        public int ClienteID { get; set; }

        public Cliente _Cliente { get; set; }

        public float Saldo { get; set; }

    }
}
