

namespace EjercicioExcepciones
{
    public class Operaciones
    {
       public double n1 { get; set; }
       public double n2 { get; set; }

        public double Suma()
        {
            return n1 + n2;
        }

        public double Resta()
        {
            return n1-n2;
        }

        public double Division()
        {
            return n1/n2;
        }

        public double Multiplicacion()
        {
            return n1*n2;
        }

    }
}
