using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PSVGames = new List<Game>()
        {
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G", TitleID = "PCSE00120", Region = "USA",
                Patches = Patches.PSVP4GUSAPatches,
                GBURL = "15703", SFName = "P4G-PSV",
                Platform = "PSVita",
                ImageUrl = "https://cdn.mobygames.com/covers/6989549-persona-4-golden-front-cover.png" },
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G", TitleID = "PCSB00245", Region = "EUR",
                Patches = Patches.PSVP4GEURPatches,
                Platform = "PSVita",
                ImageUrl = "https://cdn.mobygames.com/covers/6989549-persona-4-golden-front-cover.png" },
            new Game() { Name = "Persona 3 Dancing in Moonlight", ShortName = "P3D", TitleID = "PCSE01274", Region = "USA",
                Patches = Patches.PSVP3DUSAPatches,
                Platform = "PSVita",
                GBURL = "8747", SFName = "P3D",
                ImageUrl = "https://cdn.mobygames.com/covers/7364420-persona-3-dancing-in-moonlight-front-cover.jpg" },
            new Game() { Name = "Persona 4 Dancing All Night", ShortName = "P4D", TitleID = "PCSE00764", Region = "USA",
                Patches = Patches.PSVP4DUSAPatches,
                Platform = "PSVita",
                GBURL = "16093", SFName = "P4D",
                ImageUrl = "https://cdn.mobygames.com/covers/2024487-persona-4-dancing-all-night-front-cover.jpg" },
            new Game() { Name = "Persona 5 Dancing in Starlight", ShortName = "P5D", TitleID = "PCSE01275", Region = "USA",
                GBURL = "8615", SFName = "P5D",
                Patches = Patches.PSVP5DUSAPatches,
                Platform = "PSVita",
                ImageUrl = "https://cdn.mobygames.com/covers/7364423-persona-5-dancing-in-starlight-front-cover.jpg" },
            new Game() { Name = "Catherine: Full Body", ShortName = "CFB", TitleID = "PCSG01179", Region = "JP",
                GBURL = "8222", SFName = "CFB",
                Platform = "PSVita",
                ImageUrl = "https://cdn.mobygames.com/covers/7950619-catherine-full-body-front-cover.png" }
        };
    }
}