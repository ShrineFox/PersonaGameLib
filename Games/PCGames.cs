using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PCGames = new List<Game>()
        {
            new Game() { Name = "Persona 5 Royal", ShortName = "P5R",
                SFName = "P5R-PC", GBURL = "16951",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/8842019-persona-5-royal-front-cover.jpg" },
            new Game() { Name = "Persona 5 Strikers", ShortName = "P5S",
                SFName = "P5S", GBURL = "9099",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/9713840-persona-5-strikers-front-cover.jpg" },
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G",
                SFName = "P4G64", GBURL = "17755",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/6989549-persona-4-golden-front-cover.png" },
            new Game() { Name = "Persona 4 Arena Ultimax", ShortName = "P4AU",
                SFName = "P4AU", GBURL = "16053",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/2027374-persona-4-arena-ultimax-front-cover.jpg" },
            new Game() { Name = "Persona 3 Portable", ShortName = "P3P",
                SFName = "P3P-PC", GBURL = "16613",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/11273243-shin-megami-tensei-persona-3-portable-front-cover.jpg" },
            new Game() { Name = "Shin Megami Tensei: Nocturne HD", ShortName = "SMT3",
                SFName = "SMT3HD",
                Platform = "PC",
                ImageUrl = "https://cdn.mobygames.com/covers/1783257-shin-megami-tensei-nocturne-front-cover.jpg" },
        };
    }
}