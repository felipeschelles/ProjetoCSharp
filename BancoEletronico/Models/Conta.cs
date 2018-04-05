namespace Models
{
    public abstract class Conta
    {
        int ContaID { get; set; }
        int Numero { get; set; }
        int ClienteID { get; set; }
        float Saldo { get; set; }

    }
}
