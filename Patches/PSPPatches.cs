using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonaGameLib
{
    public partial class Patches
    {

        public static List<GamePatch> PSPP3PUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Intro Skip", ShortName = "introSkip", Author = "zarroboogs",
                Description = "Skips logos and intro movie when booting the game.",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Mod Support", ShortName = "modSupport", Author = "zarroboogs",
                Description = "File replacement via (from highest to lowest load priority):" +
                                "<ul><li>Loose files in ms0:/PSP/P3P/bind/</li>" +
                                "<li>ms0:/PSP/P3P/mod.cpk</li>" +
                                "<li>ms0:/PSP/P3P/mod1.cpk</li>" +
                                "<li>ms0:/PSP/P3P/mod2.cpk</li>" +
                                "<li>ms0:/PSP/P3P/mod3.cpk</li>" +
                "Make sure to disable the Data Install setting via the Config menu as files from installed data will override some game files (even if they were replaced via a mod). " +
                "Loose file loading is done via a leftover debug function and might be unstable.",
                AlwaysOn = true,
                OnByDefault = true
            }
        };
    }
}