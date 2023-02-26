using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PCGames = new List<Game>()
        {
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G",
                Patches = new List<GamePatch>(),
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" },
            new Game() { Name = "Persona 4 Arena Ultimax", ShortName = "P4AU",
                Patches = new List<GamePatch>(),
                ImageUrl = "https://www.mobygames.com/images/covers/l/381851-persona-4-arena-ultimax-playstation-3-front-cover.png" },
            new Game() { Name = "Persona 5 Strikers", ShortName = "P5S",
                Patches = new List<GamePatch>(),
                ImageUrl = "https://www.mobygames.com/images/covers/l/717665-persona-5-strikers-nintendo-switch-front-cover.jpg" },
        };
    }
}