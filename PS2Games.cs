using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShrineFoxCom
{
    public partial class Games
    {
        public static List<Game> PS2Games = new List<Game>()
        {
            new Game() { Name = "Persona 3 FES", ShortName = "P3FES", TitleID = "SLUS_216.21", Region = "USA", CRC = "94A82AAA",
                Patches = Patches.PS2P3FESUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/112775-shin-megami-tensei-persona-3-fes-playstation-2-front-cover.jpg" },
            new Game() { Name = "Persona 4", ShortName = "P4", TitleID = "SLUS_217.82", Region = "USA", CRC = "DEDC3B71",
                Patches = Patches.PS2P4USAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/133680-shin-megami-tensei-persona-4-playstation-2-front-cover.png" },
            new Game() { Name = "Shin Megami Tensei: Nocturne", ShortName = "SMT3", TitleID = "SLUS_209.11", Region = "USA", CRC = "E8FCF8EC",
                Patches = Patches.PS2SMT3USAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/42346-shin-megami-tensei-nocturne-playstation-2-front-cover.jpg" },
        };
    }
}