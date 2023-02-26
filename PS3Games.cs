using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShrineFoxCom
{
    public partial class Games
    {
        public static string[] disabledEXPatches = new string[] { "Mod Cpk Support", "File Access Log", 
            "P5 Modding Community Patches", "Force PSZ Models", "Disable EXIST.TBL Check", 
            "Encounter BGM Random Order", "Encounter BGM in Order", "Fix Script Printing Functions" };

        private static List<GamePatch> P5Patches = Patches.ParseYML(
            HttpContext.Current.Server.MapPath(".\\App_Data\\yml\\patch.yml"));
        private static List<GamePatch> P5EXPatches = Patches.ParseYML(
            HttpContext.Current.Server.MapPath(".\\App_Data\\yml\\p5_ex\\patch.yml"))
            .Concat(P5Patches.Where(x => !disabledEXPatches.Any(y => y.Equals(x.Name))))
            .ToList();

        public static List<Game> PS3Games = new List<Game>()
        {
            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "NPUB31848", Region = "USA",
                Patches = P5Patches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/414569-persona-5-playstation-3-front-cover.jpg" },

            new Game() { Name = "Persona 5", ShortName = "P5", TitleID = "NPEB02436", Region = "EUR",
                Patches = P5Patches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/414569-persona-5-playstation-3-front-cover.jpg" },

            new Game() { Name = "Persona 5 EX", ShortName = "P5EX", TitleID = "NPUB31848", Region = "USA",
                Patches = P5EXPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/414569-persona-5-playstation-3-front-cover.jpg" },

            new Game() { Name = "Persona 5 EX", ShortName = "P5EX", TitleID = "NPEB02436", Region = "EUR",
                Patches = P5EXPatches,
                ImageUrl = "https://www.mobygames.com/images/covers/l/414569-persona-5-playstation-3-front-cover.jpg" },
        };
    }
}