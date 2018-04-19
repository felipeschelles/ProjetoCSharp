namespace Models
{
    public abstract class Conta
    //public class Conta
    {

        
        public int Numero { get; set; }

        public int Senha { get; set; }

        public int ClienteID { get; set; }

        public virtual Cliente _Cliente { get; set; }

        public double Saldo { get; set; }

    }


   // public void Sacar(double sacar)
  /*  {
        this.Saldo -= sacar;
    }

    public void Deposito(double deposito)
    {
        this.Sacar += deposito;
    }*/



}
