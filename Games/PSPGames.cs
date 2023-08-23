using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PSPGames = new List<Game>()
        {
            new Game() { Name = "Persona 3 Portable", ShortName = "P3P", TitleID = "PCSE00120", Region = "USA",
                GBURL = "8583", SFName = "P3P",
                Platform = "PSP",
                Patches = Patches.PSPP3PUSAPatches,
                ImageUrl = "https://cdn.mobygames.com/covers/11273243-shin-megami-tensei-persona-3-portable-front-cover.jpg" },
        };
    }
}