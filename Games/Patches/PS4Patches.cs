using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShrineFoxCom
{
    public partial class Patches
    {
        public static List<GamePatch> PS4P5RUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs", 
                Description = "File replacement via (from highest to lowest load priority):" +
                                "<ul><li>Loose files in /data/p5r/bind/</li>" +
                                "<li>/data/p5r/mod.cpk</li>" +
                                "<li>/data/p5r/mod1.cpk</li>" +
                                "<li>/data/p5r/mod2.cpk</li>" +
                                "<li>/data/p5r/mod3.cpk</li>" +
                                "<li>USRDIR/mod.cpk (in pkg)</li></ul>" +
                                "<br>When using a language other than English, the game will also try to load " +
                                "(from highest to lowest load priority):" +
                                "<ul><li>Loose files in /data/p5r/bind_X/</li>" +
                                "<li>/data/p5r/mod_X.cpk</li>" +
                                "<li>/data/p5r/mod1_X.cpk</li>" +
                                "<li>/data/p5r/mod2_X.cpk</li>" +
                                "<li>/data/p5r/mod3_X.cpk</li>" +
                                "<li>USRDIR/mod_X.cpk (in pkg)</li>" +
                                "<br>Replace X with F, I, G, or S for French, Italian, German or Spanish respectively." +
                                "<br>Language specific files have a higher load priority than base English files.",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie (can still be viewed in Thieves Den)",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "PS4 FW 5.05 Backport", ShortName = "0505", Author = "zarroboogs",
                Description = "Allows the game to run on PS4 firmware 5.05.",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "P5 Save Bonus Enabler", ShortName = "p5_save", Author = "zarroboogs",
                Description = "Enables P5 save bonus without P5 saves present on system.",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Enable Share Button", ShortName = "share_button", Author = "zarroboogs",
                Description = "Enables video recording and screenshots using share button.",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Global Square Menu", ShortName = "square", Author = "zarroboogs",
                Description = "Enables the square menu globally (e.g. in Thieves Den and in Velvet Room or during " +
                                "events or game sections which disable it).",
                AlwaysOn = true,
                OnByDefault = true
            },
            // Optional Patches
            new GamePatch() { Name = "Disable Trophies", ShortName = "no_trp", Author = "zarroboogs",
                Description = "Prevents the game from unlocking trophies.",
            },
            new GamePatch() { Name = "Content Enabler", ShortName = "dlc", Author = "zarroboogs",
                Description = "Enables on-disc content and skips DLC unlock messages. " +
                                "<b>Important:</b> Saves created while this patch is enabled will be unable to load " +
                                "if you remove the patch in the future.",
            },
            new GamePatch() { Name = "Randomized Battle BGM", ShortName = "bgm_rnd", Author = "zarroboogs",
                Description = "Plays a different (random) battle BGM track each encounter regardless of equipped MC outfit.",
                Conflicts = new List<string>() { "bgm_ord" }
            },
            new GamePatch() { Name = "Sequential  Battle BGM", ShortName = "bgm_ord", Author = "zarroboogs",
                Description = "Plays the next battle BGM track each encounter regardless of equipped MC outfit.",
                Conflicts = new List<string>() { "bgm_rnd" }
            },
        };

        public static List<GamePatch> PS4P5REURPatches = PS4P5RUSAPatches;

        public static List<GamePatch> PS4P3DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs",
                Description = "File replacement via (from highest to lowest load priority):" +
                                "<ul><li>Loose files in /data/p3d/bind/</li>" +
                                "<li>/data/p3d/mod.cpk</li>" +
                                "<li>/data/p3d/mod1.cpk</li>" +
                                "<li>/data/p3d/mod2.cpk</li>" +
                                "<li>/data/p3d/mod3.cpk</li>" +
                                "<li>/data/mod.cpk (in pkg)</li></ul>",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Disable Screenshot Overlay", ShortName = "overlay", Author = "zarroboogs",
                Description = "Removes the annoying copyright overlay from in-game screenshots",
                AlwaysOn = true,
                OnByDefault = true
            },
            // Optional Patches
            new GamePatch() { Name = "Disable Trophies", ShortName = "no_trp", Author = "zarroboogs",
                Description = "Prevents the game from unlocking trophies.",
            },
        };

        public static List<GamePatch> PS4P4DEURPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs",
                Description = "File replacement via (from highest to lowest load priority):" +
                                "<ul><li>Loose files in /data/p4d/bind/</li>" +
                                "<li>/data/p4d/mod.cpk</li>" +
                                "<li>/data/p4d/mod1.cpk</li>" +
                                "<li>/data/p4d/mod2.cpk</li>" +
                                "<li>/data/p4d/mod3.cpk</li>" +
                                "<li>/data/mod.cpk (in pkg)</li></ul>",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie",
                AlwaysOn = true,
                OnByDefault = true
            },
            // Optional Patches
            new GamePatch() { Name = "Disable Trophies", ShortName = "no_trp", Author = "zarroboogs",
                Description = "Prevents the game from unlocking trophies.",
            },
        };

        public static List<GamePatch> PS4P5DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs",
                Description = "File replacement via (from highest to lowest load priority):" +
                                "<ul><li>Loose files in /data/p5d/bind/</li>" +
                                "<li>/data/p5d/mod.cpk</li>" +
                                "<li>/data/p5d/mod1.cpk</li>" +
                                "<li>/data/p5d/mod2.cpk</li>" +
                                "<li>/data/p5d/mod3.cpk</li>" +
                                "<li>/data/mod.cpk (in pkg)</li></ul>",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Disable Screenshot Overlay", ShortName = "overlay", Author = "zarroboogs",
                Description = "Removes the annoying copyright overlay from in-game screenshots",
                AlwaysOn = true,
                OnByDefault = true
            },
            // Optional Patches
            new GamePatch() { Name = "Disable Trophies", ShortName = "no_trp", Author = "zarroboogs",
                Description = "Prevents the game from unlocking trophies.",
            },
        };
    }
}