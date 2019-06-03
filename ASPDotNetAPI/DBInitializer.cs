using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPDotNetAPI.Model;

namespace ASPDotNetAPI
{
    public class DBInitializer
    {
        public static void Initialize(ChampionsContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Champions.Any())
            {
                context.Champions.Add(new Champion() { Name = "Aatrox", Title = "The Darkin Blade", Attack = 8, Defense = 4, Magic = 3, Difficuly = 4, Role = Role.Fighter });
                context.Champions.Add(new Champion() { Name = "Ahri", Title = "The Nine-Tailed Fox", Attack = 3, Defense = 4, Magic = 8, Difficuly = 5, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Akali", Title = "The Fist of Shadow", Attack = 5, Defense = 3, Magic = 8, Difficuly = 7, Role = Role.Assassin });
                context.Champions.Add(new Champion() { Name = "Alistar", Title = "The Minotaur", Attack = 6, Defense = 9, Magic = 5, Difficuly = 7, Role = Role.Tank });
                context.Champions.Add(new Champion() { Name = "Amumu", Title = "The Sad Mummy", Attack = 2, Defense = 6, Magic = 8, Difficuly = 3, Role = Role.Jungler });
                context.Champions.Add(new Champion() { Name = "Anivia", Title = "The Cryophoenix", Attack = 1, Defense = 4, Magic = 10, Difficuly = 10, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Annie", Title = "The Dark Child", Attack = 2, Defense = 3, Magic = 10, Difficuly = 6, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Ashe", Title = "The Frost Archer", Attack = 7, Defense = 3, Magic = 2, Difficuly = 4, Role = Role.Marksman });
                context.Champions.Add(new Champion() { Name = "AurelionSol", Title = "The Star Forger", Attack = 2, Defense = 3, Magic = 8, Difficuly = 7, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Azir", Title = "The Emperor of the sands", Attack = 6, Defense = 3, Magic = 8, Difficuly = 9, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Bard", Title = "The Wandering Caretaker", Attack = 4, Defense = 4, Magic = 5, Difficuly = 9, Role = Role.Support });
                context.Champions.Add(new Champion() { Name = "Blitzcrank", Title = "The Great Steam Golem", Attack = 4, Defense = 8, Magic = 5, Difficuly = 4, Role = Role.Support });
                context.Champions.Add(new Champion() { Name = "Brand", Title = "The Burning Vengeance", Attack = 2, Defense = 2, Magic = 9, Difficuly = 4, Role = Role.Mage });
                context.Champions.Add(new Champion() { Name = "Braum", Title = "The Heart of the Freljord", Attack = 3, Defense = 9, Magic = 4, Difficuly = 3, Role = Role.Support });
                context.Champions.Add(new Champion() { Name = "Caitlyn", Title = "The Sheriff of Piltover", Attack = 8, Defense = 2, Magic = 2, Difficuly = 6, Role = Role.Marksman });                
                context.SaveChanges();
            }
        }
    }
}
