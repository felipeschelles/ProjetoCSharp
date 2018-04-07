namespace Models
{
    public abstract class Conta
    {
        public int ContaID { get; set; }

        public int Numero { get; set; }

        public int ClienteID { get; set; }

        public float Saldo { get; set; }

    }
}
