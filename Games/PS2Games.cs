using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PS2Games = new List<Game>()
        {
            new Game() { Name = "Persona 3 FES", ShortName = "P3FES", TitleID = "SLUS_216.21", Region = "USA", CRC = "94A82AAA",
                Patches = Patches.PS2P3FESUSAPatches,
                SFName = "P3FES", GBURL = "8502",
                ImageUrl = "https://cdn.mobygames.com/covers/4749225-shin-megami-tensei-persona-3-fes-front-cover.jpg" },
            new Game() { Name = "Persona 4", ShortName = "P4", TitleID = "SLUS_217.82", Region = "USA", CRC = "DEDC3B71",
                Patches = Patches.PS2P4USAPatches,
                SFName = "P4", GBURL = "8761",
                ImageUrl = "https://cdn.mobygames.com/covers/5295776-shin-megami-tensei-persona-4-front-cover.jpg" },
            new Game() { Name = "Shin Megami Tensei: Nocturne", ShortName = "SMT3", TitleID = "SLUS_209.11", Region = "USA", CRC = "E8FCF8EC",
                Patches = Patches.PS2SMT3USAPatches,
                SFName = "SMT3",
                ImageUrl = "https://cdn.mobygames.com/covers/1783257-shin-megami-tensei-nocturne-front-cover.jpg" },
        };
    }
}