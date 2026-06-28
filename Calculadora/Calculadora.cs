namespace EspacioCalculadora
{
    public class Calculadora
    {
        double Dato = 0; // Campo privado 

        public double resultado
        {
            get { return Dato; }
        }
        public void Sumar(double numero)
        {
            Dato += numero;
        }

        public void Restar(double numero)
        {
            Dato -= numero;
        }

        public void Multiplicar(double numero)
        {
            Dato *= numero;
        }

        public void Dividir(double numero)
        {
            if (numero == 0)
            {
                Console.WriteLine("No es posible dividir un numero por cero");
            }

            Dato /= numero;
        }

        public void Limpiar()
        {
            Dato = 0;
        }
    }
}