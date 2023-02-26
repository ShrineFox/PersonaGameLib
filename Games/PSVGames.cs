using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PSVGames = new List<Game>()
        {
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G", TitleID = "PCSE00120", Region = "USA",
                Patches = Patches.PSVP4GUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" },
            new Game() { Name = "Persona 4 Golden", ShortName = "P4G", TitleID = "PCSB00245", Region = "EUR",
                Patches = Patches.PSVP4GEURPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/276137-persona-4-golden-ps-vita-front-cover.png" },
            new Game() { Name = "Persona 3 Dancing", ShortName = "P3D", TitleID = "PCSE01274", Region = "USA",
                Patches = Patches.PSVP3DUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/526580-persona-3-dancing-in-moonlight-playstation-4-front-cover.png" },
            new Game() { Name = "Persona 4 Dancing", ShortName = "P4D", TitleID = "PCSE00764", Region = "USA",
                Patches = Patches.PSVP4DUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/381830-persona-4-dancing-all-night-ps-vita-front-cover.png" },
            new Game() { Name = "Persona 5 Dancing", ShortName = "P5D", TitleID = "PCSE01275", Region = "USA",
                Patches = Patches.PSVP5DUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/526581-persona-5-dancing-in-starlight-playstation-4-front-cover.png" },
        };
    }
}