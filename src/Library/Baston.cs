using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Baston
    {
        private string Nombre;
        private int Damage;

        public Baston (string nombre, int damage)
        {
            this.Nombre = nombre;
            this.Damage = damage;
        }

        public int ItemDamage()
        {
            return this.Damage;
        }
    }
}