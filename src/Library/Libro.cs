using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Libro
    {
        private string Nombre;
        private int Damage;

        private ArrayList Hechizos = new ArrayList();

        public Libro (string nombre)
        {
            this.Nombre = nombre;
        }

        public void AddSpell(Hechizo hechizo)
        {
            this.Hechizos.Add(hechizo);
            this.Damage = this.Damage + hechizo.SpellDamage();
        }

        public int ItemDamage()
        {
            return this.Damage;
        }
    }
}