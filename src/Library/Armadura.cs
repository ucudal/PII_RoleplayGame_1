using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Armadura
    {
        private string Nombre;
        private int Defensa;

        public Armadura (string nombre, int defensa)
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