using Personal;

// c) CARGANDO DATOS PARA 3 EMPLEADOS:
Empleado[] personal = new Empleado[3];

personal[0] = new Empleado("Gabriela", "Medina", new DateTime(1989, 08, 09), 'C', new DateTime(2010, 11, 01), 650000, Cargos.Especialista);
personal[1] = new Empleado("Estefania", "Girones", new DateTime(1967, 08, 09), 'S', new DateTime(2000, 02, 15), 800000, Cargos.Ingeniero);
personal[2] = new Empleado("Gustavo", "Pereyra", new DateTime(1975, 05, 22), 'C', new DateTime(2005, 05, 18), 550000, Cargos.Administrativo);

// d) MONTO TOTAL EN CONCEPTO DE SALARIOS:
double SalarioTotal = 0;
for (int i = 0; i < personal.Length; i++)
{
    SalarioTotal += personal[i].Salario();
}

Console.WriteLine($"Suma Total de los Salarios de los empleados = ${SalarioTotal}\n");

// e) DATOS DEL EMPLEADO MAS PROXIMO A JUBILARSE
Empleado proximoAJubilarse = personal[0];

for (int i = 1; i < personal.Length; i++)
{
    if (personal[i].Jubilacion() < proximoAJubilarse.Jubilacion())
    {
        proximoAJubilarse = personal[i];
    }
}

Console.WriteLine("****************** EMPLEADO MAS PROXIMO PARA JUBILARSE ******************");
Console.WriteLine($"Nombre y Apellido: {proximoAJubilarse.nombre} {proximoAJubilarse.apellido}");
Console.WriteLine($"Fecha de Nacimiento: {proximoAJubilarse.fecha_Nac}");
Console.WriteLine($"Estado Civil: {proximoAJubilarse.estado_Civil}");
Console.WriteLine($"Fecha de Ingreso a la Empresa: {proximoAJubilarse.ingreso_Empresa}");
Console.WriteLine($"Sueldo Basico: ${proximoAJubilarse.sueldo_Basico}");
Console.WriteLine($"Cargo en la Empresa: {proximoAJubilarse.cargo_Empresa}");
Console.WriteLine($"Antiguedad: {proximoAJubilarse.Antiguedad()}");
Console.WriteLine($"Edad del Empleado: {proximoAJubilarse.Edad()}");
Console.WriteLine($"Anios faltantes para Jubilacion: {proximoAJubilarse.Jubilacion()}");
Console.WriteLine($"Salario Actual: {proximoAJubilarse.Salario()}");