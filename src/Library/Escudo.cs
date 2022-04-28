using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Escudo
    {
        private string Nombre;
        private int Defensa;

        public Escudo (string nombre, int defensa)
        {
            this.Nombre = nombre;
            this.Defensa = defensa;
        }

        public int ItemDefensa()
        {
            return this.Defensa;
        }
    }
}