using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PQGames = new List<Game>()
        {
            new Game() { Name = "Persona Q", ShortName = "PQ", TitleID = "PCSE00120", Region = "USA",
                Patches = Patches.PQUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" },
            new Game() { Name = "Persona Q2", ShortName = "PQ2", TitleID = "PCSB00245", Region = "USA",
                Patches = Patches.PQ2USAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" }
        };
    }
}