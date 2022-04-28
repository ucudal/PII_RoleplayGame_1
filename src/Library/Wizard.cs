
using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Mago
    {
        //Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque 
        //y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediente el estudio de la asignatura, 
        //y mediante elementos que la potencian (por ejemplo, un bastón mágico).

        private string Nombre { get; }

        private int Vida { get; set;}

        private int Damage { get; set; }

        private int Magia { get; set; }

        /*
        private Espada espada {get; set;}
        private Escudo escudo {get; set;}
        private Arco arco {get; set;}
        private Cuchillo cuchillo {get; set;}
        private Escopeta escopeta {get; set;}
        private Armadura armadura {get; set;}
        */

        private Baston baston {get; set;}
        private Escudo escudo {get; set;}
        private Libro libro {get; set;}

        public Mago (string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 50;
            this.Damage = 30;
            this.Magia = 15;
        }

        // METODOS RELACIONADOS A LOS OBJETOS
        public void EquiparBaston(Baston item)
        {
            this.baston = item; 
            this.Damage = this.Damage + item.ItemDamage();
        }

        public void DesequiparBaton()
        {
            this.Damage = this.Damage - this.baston.ItemDamage(); 
            this.baston = null;
        }

        public void EquiparLibro(Libro item)
        {
            this.libro = item;
            this.Damage = item.ItemDamage(); 
        }

        public void DesequiparLibro()
        {
            this.Damage = this.Damage - this.libro.ItemDamage();
            this.libro = null;
        }

         public void EquiparEscudo(Escudo item)
        {
            this.escudo = item; 
            this.Vida = this.Vida + item.ItemDefensa();
        }

        public void DesequiparEscudo()
        {
            this.Vida = this.Vida - this.escudo.ItemDefensa(); 
            this.escudo = null;
        }
        //
        
        /// METODOS PARA INTERACIONES CON OTROS PERSONAJES
        public int TotalDamage()
        {
            return this.Damage + this.Magia;
        }

        public void RecibirDamage(int damage)
        {
            this.Vida -= damage;
        }

        public bool Healthy()
        {
            return this.Vida > 0;
        }
        ///
    }
}