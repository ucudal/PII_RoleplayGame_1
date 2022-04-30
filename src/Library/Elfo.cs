using System;
using System.Collections;

namespace PII_RoleplayGame_1_Start
{
    public class Elfo
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
        */

        private Escudo escudo {get; set;}
        private Arco arco {get; set;}
        private Espada espada {get; set;}


        public Elfo (string nombre)
        {
            this.Nombre = nombre;
            this.Vida = 60;
            this.Damage = 30;
            this.Magia = 10;
        }

        // METODOS RELACIONADOS A LOS OBJETOS
        public void EquiparEspada(Espada item)
        {
            this.espada = item; 
            this.Damage = this.Damage + item.ItemDamage();
        }

        public void DesequiparEspada()
        {
            this.Damage = this.Damage - this.espada.ItemDamage(); 
            this.espada = null;
        }

        public void EquiparArco(Arco item)
        {
            this.arco = item;
            this.Damage = this.Damage + item.ItemDamage(); 
        }

        public void DesequiparEscopeta()
        {
            this.Damage = this.Damage - this.arco.ItemDamage();
            this.arco = null;
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
       public int TotalDamageElfo()
        {
            return this.Damage;
        }

        public void AtacarMago(Mago mago)
        {
            mago.RecibirDamage(this.TotalDamageElfo());
        }

        public void AtacarEnano(Enano enano)
        {
            enano.RecibirDamage(this.TotalDamageElfo());
        }

        public void AtacarElfo(Elfo elfo)
        {
            elfo.RecibirDamage(this.TotalDamageElfo());
        }
        public void AtacarHumano(Humano humano)
        {
            humano.RecibirDamage(this.TotalDamageElfo());
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