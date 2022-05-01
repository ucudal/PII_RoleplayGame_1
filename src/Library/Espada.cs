using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Espada
    {
        private string Nombre;
        private int Damage;

        public Espada (string nombre, int damage)
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