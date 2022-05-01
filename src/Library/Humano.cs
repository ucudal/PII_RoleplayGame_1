using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Humano
    {
       //Los enanos son seres temperamentales, muy buenos en combate con las armas, 
       //físicamente fuertes, con mucha resistencia y leales a sus amigos.

        private string Nombre {get;}

        private int Vida {get; set;}

        private int Damage {get; set;}

        private int Magia {get; set;}

        /*
        private Escudo escudo {get; set;}
        private Cuchillo cuchillo {get; set;}
        private Armadura armadura {get; set;}
        private Baston baston {get; set;}
        private Libro libro {get; set;}
        private Escopeta escopeta {get; set;}
        private Arco arco {get; set;}
        private Espada espada {get; set;}
        */

        private Escudo escudo {get; set;}
        private Armadura armadura {get; set;}
        private Cuchillo cuchillo {get; set;}
        
        public Humano (string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 50;
            this.Damage = 30;
            this.Magia = 0;
        }

        // METODOS RELACIONADOS A LOS OBJETOS
        public void EquiparCuchillo(Cuchillo item)
        {
            this.cuchillo = item; 
            this.Damage = this.Damage + item.ItemDamage();
        }

        public void DesequiparCuchullo()
        {
            this.Damage = this.Damage - this.cuchillo.ItemDamage(); 
            this.cuchillo = null;
        }

        public void EquiparArmadura(Armadura item)
        {
            this.armadura = item;
            this.Vida = this.Vida + item.ItemDefensa(); 
        }

        public void DesequiparArmadura()
        {
            this.Damage = this.Vida- this.armadura.ItemDefensa();
            this.armadura = null;
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
       public int TotalDamageHumano()
        {
            return this.Damage;
        }

        public void AtacarMago(Mago mago)
        {
            mago.RecibirDamage(this.TotalDamageHumano());
        }

        public void AtacarEnano(Enano enano)
        {
            enano.RecibirDamage(this.TotalDamageHumano());
        }

        public void AtacarElfo(Elfo elfo)
        {
            elfo.RecibirDamage(this.TotalDamageHumano());
        }
        public void AtacarHumano(Humano humano)
        {
            humano.RecibirDamage(this.TotalDamageHumano());
        }

        public void RecibirDamage(int damage)
        {
            this.Vida -= damage;
        }

        public void Curar(int curacion)
        {
            this.Vida = this.Vida + curacion;
        }

        public int VidaActual()
        {
            return this.Vida;
        }
        //
    }
}