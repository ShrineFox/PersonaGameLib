using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> NXGames = new List<Game>()
        {
            new Game() { Name = "Persona 5 Royal", ShortName = "P5R", TitleID = "01005CA01580E000", Region = "USA",
                Platform = "Switch",
                SFName = "P5R-NX", GBURL = "17354",
                ImageUrl = "https://cdn.mobygames.com/covers/8842019-persona-5-royal-front-cover.jpg" },
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G", TitleID = "PCSE00120", Region = "USA",
                Platform = "Switch",
                GBURL = "17433", SFName = "P4G-NX",
                ImageUrl = "https://cdn.mobygames.com/covers/6989549-persona-4-golden-front-cover.png" },
            new Game() { Name = "Persona 3 Portable", ShortName = "P3P", TitleID = "PCSE00120", Region = "USA",
                Platform = "Switch",
                GBURL = "17434", SFName = "P3P-NX",
                ImageUrl = "https://cdn.mobygames.com/covers/11273243-shin-megami-tensei-persona-3-portable-front-cover.jpg" },
            new Game() { Name = "Shin Megami Tensei V", ShortName = "SMTV", TitleID = "010063B012DC6000", Region = "USA",
                SFName = "SMTV", GBURL = "14768",
                Platform = "Switch",
                ImageUrl = "https://cdn.mobygames.com/covers/11260366-shin-megami-tensei-v-front-cover.jpg" },
            new Game() { Name = "Shin Megami Tensei: Nocturne HD", ShortName = "SMT3",
                SFName = "SMT3HD", GBURL = "10084",
                Platform = "Switch",
                ImageUrl = "https://cdn.mobygames.com/covers/1783257-shin-megami-tensei-nocturne-front-cover.jpg" },
            new Game() { Name = "Catherine: Full Body", ShortName = "CFB", TitleID = "PCSG01179", Region = "USA",
                ImageUrl = "https://cdn.mobygames.com/covers/7950619-catherine-full-body-front-cover.png",
                Platform = "Switch"
            }
        };
    }
}