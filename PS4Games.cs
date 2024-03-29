﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShrineFoxCom
{
    public partial class Games
    {
        public static List<Game> PS4Games = new List<Game>()
        {
            new Game() { Name = "Persona 5 Royal", ShortName = "P5R", TitleID = "CUSA17416", Region = "USA",
                CRC32 = "E2452B1C", MD5 = "E669D7F9F9AB3989A2ED9D8D615547BD", SHA1 = "25ABE8EFBD0D0CB7307927CD6AE6F1BB5ED506F4",
                Patches = Patches.PS4P5RUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/700943-persona-5-royal-playstation-4-manual.jpg" },
            new Game() { Name = "Persona 5 Royal", ShortName = "P5R", TitleID = "CUSA17419", Region = "EUR",
                CRC32 = "8221F3EE", MD5 = "9FA6741E1EC98F0DF6027DB553168B45", SHA1 = "98DE4F768453F32FFB17C57C2480518F80999EF8",
                Patches = Patches.PS4P5REURPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/700943-persona-5-royal-playstation-4-manual.jpg" },
            new Game() { Name = "Persona 3 Dancing", ShortName = "P3D", TitleID = "CUSA12636", Region = "USA",
                CRC32 = "FD46F56F", MD5 = "73482E870BEB91F5AD8BA0AEC4515F68", SHA1 = "A4889A43400DC4FD333B9B9C109816B47777C339",
                Patches = Patches.PS4P3DUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/526580-persona-3-dancing-in-moonlight-playstation-4-front-cover.png" },
            new Game() { Name = "Persona 4 Dancing", ShortName = "P4D", TitleID = "CUSA12811", Region = "EUR",
                CRC32 = "9B2CDA6E", MD5 = "7794E4C921AFB7B759F481C564AFF1CB", SHA1 = "176AF1377B97217E2E02DCC855E64FB730B80960",
                Patches = Patches.PS4P4DEURPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/381830-persona-4-dancing-all-night-ps-vita-front-cover.png" },
            new Game() { Name = "Persona 5 Dancing", ShortName = "P5D", TitleID = "CUSA12380", Region = "USA",
                CRC32 = "50A4FB33", MD5 = "D4E08AE0C5C7027B4FC01E55CDD23EF6", SHA1 = "521C247ADB8AA675C370257D53D60B77812E343A",
                Patches = Patches.PS4P5DUSAPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/526581-persona-5-dancing-in-starlight-playstation-4-front-cover.png" },
        };
    }
}