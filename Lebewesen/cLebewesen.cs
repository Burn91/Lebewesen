using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lebewesen
{
   abstract class CLebewesen
    {

        string name;
        string farbe;
        int alter;

        public string Name
        {
            set { name = value; }
            get { return this.name; }
           
        }

        public string Farbe
        {
            set { farbe = value; }
            get { return this.farbe; }
        
        }

        public int Alter
        {
            set { alter = value; }
            get { return this.alter; }
            
        }
    }


    class Katze : CLebewesen
    {

        string rasse;
        int groeße;

        public string Rasse
        {
            set { rasse = value; }
            get { return this.rasse; }
           
        }

        public int Groeße
        {
            set { groeße = value; }
            get { return this.groeße; }
         
        }
        
    }

    class Fisch : CLebewesen
    {
        int maxTiefe;
        int laenge;
      
        public int MaxTiefe
        {
            set { maxTiefe = value; }
            get { return this.maxTiefe; }
            
        }

        public int Laenge
        {
            set { laenge = value; }
            get { return this.laenge; }

        }


    }
}
