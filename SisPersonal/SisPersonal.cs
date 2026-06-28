namespace Personal
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    public class Empleado
    {
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private char EstadoCivil;
        private DateTime FechaIngresoEnEmpresa;
        private double SueldoBasico;
        private Cargos Cargo;
        public Empleado(string nombre, string apellido, DateTime nacimiento, char estadoCivil, DateTime ingresoEmpresa, double sueldoBasico, Cargos cargo)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = nacimiento;
            EstadoCivil = estadoCivil;
            FechaIngresoEnEmpresa = ingresoEmpresa;
            SueldoBasico = sueldoBasico;
            Cargo = cargo;
        }
        public string nombre
        {
            get { return Nombre; }
        }

        public string apellido
        {
            get { return Apellido; }
        }

        public DateTime fecha_Nac
        {
            get { return FechaNacimiento; }
        }

        public char estado_Civil
        {
            get {return EstadoCivil;}
        }

        public DateTime ingreso_Empresa
        {
            get {return FechaIngresoEnEmpresa;}
        }

        public double sueldo_Basico
        {
            get {return SueldoBasico;}
        }

        public Cargos cargo_Empresa
        {
            get {return Cargo;}
        }
        public int Antiguedad()
        {
            DateTime fechaActual = DateTime.Today;
            int antiguedad = fechaActual.Year - FechaIngresoEnEmpresa.Year;

            if (fechaActual < FechaIngresoEnEmpresa.AddYears(antiguedad))
            {
                antiguedad--;
            }

            return antiguedad;
        }

        public int Edad()
        {
            DateTime fechaActual = DateTime.Today;

            int edad = fechaActual.Year - FechaNacimiento.Year;

            if (fechaActual < FechaNacimiento.AddYears(edad))
            {
                edad--;
            }

            return edad;
        }

        public int Jubilacion()
        {
            return 65 - Edad();
        }

        public double Adicional()
        {
            double adicional = 0;

            adicional = (Antiguedad() < 20) ? SueldoBasico * (Antiguedad() * 0.01) : SueldoBasico * (25 * 0.01);

            if (Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
            {
                adicional *= 1.5;
            }

            if (char.ToUpper(EstadoCivil) == 'C')
            {
                adicional += 150000;
            }

            return adicional;
        }

        public double Salario()
        {
            double salario = SueldoBasico + Adicional();
            return salario;
        }
    }
}