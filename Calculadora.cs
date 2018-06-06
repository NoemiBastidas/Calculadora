//Archivo Program.cs

using System;
namespace Operaciones
{
    class Program
    {
    static void Main(string[] args)
        {
            double valor=2;
            var calculator = new calculadora();
            var resultado = calculadora.Sumar(valor, 2);
            var resultado = calculadora.Restar(resultado, 3);
            var resultado = calculadora.Multiplicar(resultado, 4);
            var resultado = calculadora.Dividir(resultado, 8);
            console.WriteLine("Su resultado es:" + resultado)
            
        }
    }
}


//Archivo Operaciones.csproj

<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>netcoreapp2.0</TargetFramework>
    <CSFile Include = "Calculadora.cs"/>
    <CSFile Include = "Programa.cs"/>
  </PropertyGroup>

</Project>



//Archivo Calculadora.cs

using System;
namespace Calculadora
{
    public class Calculadora
    {
        double memoria = 0;
        public double Sumar(double sumando)
        {
            memoria = memoria + sumando;
            return memoria;
        } 
        public double Sumar(double sumando, double sumando1)
        {
            memoria = sumando+sumando1;
            return memoria;  
        }
       
       public double Restar(double sustraendo)
        {
            memoria = memoria - sustraendo;
            return memoria;
        } 
        public double Restar(double minuendo, double sustraendo)
        {
            memoria = minuendo-sustraendo;
           return memoria;
        }
       
       public double Multiplicar(double multiplicador)
        {
           memoria = memoria*multiplicador;
            return memoria;
        }
        public double Multiplicar(double multiplicando, double multiplicador)
        {
            memoria = multiplicando*multiplicador;
           return multiplicando*multiplicador;
        }

        public double Dividir(double divisor)
        {
            memoria = memoria/divisor;
            return memoria;
        } 
        public double Dividir(double dividendo, double divisor)
        {
            memoria = dividendo/divisor;
            return dividendo/dividendo;
        }
    }
}




