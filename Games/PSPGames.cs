using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PSPGames = new List<Game>()
        {
            new Game() { Name = "Persona 3 Portable", ShortName = "P3P", TitleID = "PCSE00120", Region = "USA",
                Patches = Patches.PSPP3PUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" },
        };
    }
}