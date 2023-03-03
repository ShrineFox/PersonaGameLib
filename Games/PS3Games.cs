using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static string[] disabledEXPatches = new string[] { "Mod Cpk Support", "File Access Log", 
            "P5 Modding Community Patches", "Force PSZ Models", "Disable EXIST.TBL Check", 
            "Encounter BGM Random Order", "Encounter BGM in Order", "Fix Script Printing Functions" };

        private static List<GamePatch> P5Patches = Patches.ParseYML(
            FileUtil.GetFromPath("./App_Data/yml/patch.yml"));
        private static List<GamePatch> P5EXPatches = Patches.ParseYML(
            FileUtil.GetFromPath("./App_Data/yml/p5_ex/patch.yml"))
            .Concat(P5Patches.Where(x => !disabledEXPatches.Any(y => y.Equals(x.Name))))
            .ToList();

        public static List<Game> PS3Games = new List<Game>()
        {
            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "NPUB31848", Region = "USA",
                Patches = P5Patches,
                SFName = "P5", GBURL = "7545",
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },

            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "NPEB02436", Region = "EUR",
                Patches = P5Patches,
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },

            new Game() { Name = "Persona 5 EX", ShortName = "P5EX", TitleID = "NPUB31848", Region = "USA",
                Patches = P5EXPatches,
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },

            new Game() { Name = "Persona 5 EX", ShortName = "P5EX", TitleID = "NPEB02436", Region = "EUR",
                Patches = P5EXPatches,
                ImageUrl = "https://cdn.mobygames.com/covers/2723792-persona-5-front-cover.jpg" },
        };
    }
}