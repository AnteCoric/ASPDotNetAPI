using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPDotNetAPI
{
    public enum Role { Mage, Fighter, Marksman, Support, Jungler, Tank, Assassin };
    public class Champion
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Title { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int Magic { get; set; }

        public int Difficuly { get; set; }

        public Role Role { get; set; }
    }
}
