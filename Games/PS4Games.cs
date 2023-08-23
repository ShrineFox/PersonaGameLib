using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> PS4Games = new List<Game>()
        {
            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "CUSA05877", Region = "USA",
                Patches = Patches.PS4P5RUSAPatches,
                Platform = "PS4",
                UpdatePKGName = "UP2611-CUSA05877_00-PERSONA512345678-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },
            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "CUSA06638", Region = "EUR",
                Patches = Patches.PS4P5REURPatches,
                UpdatePKGName = "EP4062-CUSA06638_00-PERSONA512345678-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },

            new Game() { Name = "Persona 5 Royal", ShortName = "P5R", TitleID = "CUSA17416", Region = "USA",
                CRC32 = "E2452B1C", MD5 = "E669D7F9F9AB3989A2ED9D8D615547BD", SHA1 = "25ABE8EFBD0D0CB7307927CD6AE6F1BB5ED506F4",
                Patches = Patches.PS4P5RUSAPatches,
                Platform = "PS4",
                SFName = "P5R", GBURL = "8464",
                UpdatePKGMinSize = 870645760, UpdatePKGName = "UP0177-CUSA17416_00-PERSONA5R0000000-A0102-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/8842019-persona-5-royal-front-cover.jpg" },
            new Game() { Name = "Persona 5 Royal", ShortName = "P5R", TitleID = "CUSA17419", Region = "EUR",
                CRC32 = "8221F3EE", MD5 = "9FA6741E1EC98F0DF6027DB553168B45", SHA1 = "98DE4F768453F32FFB17C57C2480518F80999EF8",
                Patches = Patches.PS4P5REURPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 870645760, UpdatePKGName = "EP0177-CUSA17419_00-PERSONA5R0000000-A0101-V0101.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/8842019-persona-5-royal-front-cover.jpg" },
            
            new Game() { Name = "Persona 3 Dancing", ShortName = "P3D", TitleID = "CUSA12636", Region = "USA",
                CRC32 = "FD46F56F", MD5 = "73482E870BEB91F5AD8BA0AEC4515F68", SHA1 = "A4889A43400DC4FD333B9B9C109816B47777C339",
                Patches = Patches.PS4P3DUSAPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 13631488, UpdatePKGName = "UP2611-CUSA12636_00-PERSONA3DUS00000-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/7364420-persona-3-dancing-in-moonlight-front-cover.jpg" },
            new Game() { Name = "Persona 3 Dancing", ShortName = "P3D", TitleID = "CUSA12810", Region = "EUR",
                Patches = Patches.PS4P3DUSAPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 13631488, UpdatePKGName = "EP2475-CUSA12810_00-PERSONA3DEU00000-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/7364420-persona-3-dancing-in-moonlight-front-cover.jpg" },

            new Game() { Name = "Persona 4 Dancing", ShortName = "P4D", TitleID = "CUSA12811", Region = "EUR",
                CRC32 = "9B2CDA6E", MD5 = "7794E4C921AFB7B759F481C564AFF1CB", SHA1 = "176AF1377B97217E2E02DCC855E64FB730B80960",
                Patches = Patches.PS4P4DEURPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 11993088, UpdatePKGName = "EP2475-CUSA12811_00-PERSONA4DEU00000-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/2024487-persona-4-dancing-all-night-front-cover.jpg" },

            new Game() { Name = "Persona 5 Dancing", ShortName = "P5D", TitleID = "CUSA12380", Region = "USA",
                CRC32 = "50A4FB33", MD5 = "D4E08AE0C5C7027B4FC01E55CDD23EF6", SHA1 = "521C247ADB8AA675C370257D53D60B77812E343A",
                Patches = Patches.PS4P5DUSAPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 13631488, UpdatePKGName = "UP2611-CUSA12380_00-PERSONA5DUS00000-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/7364423-persona-5-dancing-in-starlight-front-cover.jpg" },
            new Game() { Name = "Persona 5 Dancing", ShortName = "P5D", TitleID = "CUSA12813", Region = "EUR",
                Patches = Patches.PS4P5DUSAPatches,
                Platform = "PS4",
                UpdatePKGMinSize = 13631488, UpdatePKGName = "EP2475-CUSA12813_00-PERSONA5DEU00000-A0101-V0100.pkg",
                ImageUrl = "https://cdn.mobygames.com/covers/7364423-persona-5-dancing-in-starlight-front-cover.jpg" },
        };
    }
}