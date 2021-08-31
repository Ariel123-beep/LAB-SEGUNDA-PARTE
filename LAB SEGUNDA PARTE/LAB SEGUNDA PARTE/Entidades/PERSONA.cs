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
            this.Edad = edad;
            this.Sexo = sexo;
            this.Peso = peso;
            this.Altura = altura;
        }

        public PERSONA(string nombre, string edad, string sexo)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Sexo = sexo;
        }

        public PERSONA(string nombre, string edad, string sexo, int peso, int altura, string nombre1, string edad1, string sexo1, int peso1, int altura1) : this(nombre, edad, sexo, peso, altura)
        {
            this.Nombre1 = nombre1;
            this.Edad1 = edad1;
            this.Sexo1 = sexo1;
            this.Peso1 = peso1;
            this.Altura1 = altura1;
        }

        public PERSONA(int peso, int altura)
        {
            this.Peso = peso;
            this.Altura = altura;
          
        }

        public override string ToString()
        {
            return "La persona  de nombre " + Nombre + " de edad " + Edad + " Tiene un peso de " + Peso + " Y una altura de " + Altura;
            
        }

       
    }


    
}

