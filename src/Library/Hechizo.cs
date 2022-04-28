using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Hechizo
    {
        private string Nombre;
        private int Damage;

        public Hechizo (string nombre, int damage)
        {
            this.Nombre = nombre;
            this.Damage = damage;
        }

        public int SpellDamage()
        {
            return this.Damage;
        }
    }
}