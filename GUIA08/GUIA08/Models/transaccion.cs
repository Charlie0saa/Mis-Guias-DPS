namespace GUIA08.Models
{   
    public class Transaccion
    {
        // Campos privados
        private string sNumeroTarjeta;
        private double fSaldo;
        // Constructor que acepta solo el número de tarjeta
        public Transaccion(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = 500;
        }
        // Constructor que acepta número de tarjeta y saldo
        public Transaccion(string tarjeta, double saldo)
        {
            sNumeroTarjeta = tarjeta;
            fSaldo = saldo;
        }
        // Métodos de acceso (getters y setters)
        public double GetSaldo()
        {
            return fSaldo;
        }
        public void SetSaldo(double saldo)
        {
            fSaldo = saldo;
        }
        public string GetNumTarjeta()
        {
            return sNumeroTarjeta;
        }
        public void SetNumTarjeta(string tarjeta)
        {
            sNumeroTarjeta = tarjeta;
        }
        // Métodos para realizar transferencias
        public void TransferenciaNacional(double monto)
        {
            fSaldo -= monto;
        }
        public void TransferenciaInternacional(double monto)
        {
            fSaldo -= monto;
        }
    }
}
