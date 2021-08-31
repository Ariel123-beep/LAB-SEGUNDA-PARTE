using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_SEGUNDA_PARTE.Entidades
{
    class PERSONA
    {
        private string Nombre;
        private string Edad;
        private string Sexo;
        private int Peso;
        private int Altura;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Edad1 { get => Edad; set => Edad = value; }
        public string Sexo1 { get => Sexo; set => Sexo = value; }
        public int Peso1 { get => Peso; set => Peso = value; }
        public int Altura1 { get => Altura; set => Altura = value; }

        public PERSONA(string nombre, string edad, string sexo, int peso, int altura)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
        }

        public PERSONA(string nombre, string edad, string sexo)
        {
            Nombre = nombre;
            Edad = edad;
            Sexo = sexo;
        }

        public PERSONA(string nombre, string edad, string sexo, int peso, int altura, string nombre1, string edad1, string sexo1, int peso1, int altura1) : this(nombre, edad, sexo, peso, altura)
        {
            Nombre1 = nombre1;
            Edad1 = edad1;
            Sexo1 = sexo1;
            Peso1 = peso1;
            Altura1 = altura1;
        }

        




    }



}

