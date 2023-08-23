using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Patches
    {
        public static List<GamePatch> PS4P5RUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs", 
                Description = "mod.cpk file replacement via FTP with optional language support",
                LongDescription = "Loads modded files from a <kbd>mod.cpk</kbd> file in <code>/data/p5r</code> on the PS4's internal memory via FTP." +
                "<br>Also supports optional language-specific .cpk files, which take priority when the system language isn't English (e.x. <kbd>mod_F.cpk</kbd> for French)" +
                "<br>Additionally, loose files can be loaded from <kbd>data/p5r/bind</kbd> or language-dependent equivalent (e.x. <kbd>data/p5r/bind_F</kbd> for French)",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Bypass opening logos/movie",
                LongDescription = "Skips boot logos and intro movie (can still be viewed in Thieves Den).",
                AlwaysOn = true,
                OnByDefault = true
            },
            new GamePatch() { Name = "PS4 FW 5.05 Backport", ShortName = "0505", Author = "zarroboogs",
                Description = "Run on firmware 5.05+.",
                LongDescription = "Allows the game to run on the lowest possible moddable PS4 firmware, and all those above it.",
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
                Description = "Square button menu usable everywhere",
                LongDescription = "Enables the square menu globally (e.g. in Thieves Den and in Velvet Room or during events or game sections which disable it).",
                AlwaysOn = true,
                OnByDefault = true
            },
            // Optional Patches
            new GamePatch() { Name = "Disable Trophies", ShortName = "no_trp", Author = "zarroboogs",
                Description = "Prevents the game from unlocking trophies.",
            },
            new GamePatch() { Name = "Content Enabler", ShortName = "all_dlc", Author = "zarroboogs",
                Description = "Enables on-disc content and skips DLC unlock messages. " +
                                "<b>Important:</b> Saves created while this patch is enabled will be unable to load " +
                                "if you remove the patch in the future.",
            },
            new GamePatch() { Name = "Skip DLC Unlock Messages", ShortName = "dlc_msg", Author = "zarroboogs",
                Description = "Especially useful when using the Content Enabler patch together with a mod that skips " +
                "the title screen and boots directly into a field.",
            },
            new GamePatch() { Name = "Randomized Battle BGM", ShortName = "bgm_rnd", Author = "zarroboogs",
                Description = "Plays randomly selected BGM track for each battle",
                LongDescription = "A different (random) battle BGM track plays each time you encounter an enemy, regardless of equipped MC outfit.",
                Conflicts = new List<string>() { "bgm_ord" }
            },
            new GamePatch() { Name = "Sequential  Battle BGM", ShortName = "bgm_ord", Author = "zarroboogs",
                Description = "Plays different BGM track for each battle",
                LongDescription = "A different battle BGM track plays (in order) each time you encounter an enemy, regardless of equipped MC outfit.",
                Conflicts = new List<string>() { "bgm_rnd" }
            },
        };

        public static List<GamePatch> PS4P5REURPatches = PS4P5RUSAPatches;

        public static List<GamePatch> PS4P3DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Mod Support", ShortName = "mod", Author = "zarroboogs",
                Description = "mod.cpk file replacement via FTP with optional language support",
                LongDescription = "Loads modded files from a <kbd>mod.cpk</kbd> file in <code>/data/p3d</code> on the PS4's internal memory via FTP." +
                "<br>Additionally, loose files can be loaded from <kbd>data/p3d/bind</kbd>",
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
                Description = "mod.cpk file replacement via FTP with optional language support",
                LongDescription = "Loads modded files from a <kbd>mod.cpk</kbd> file in <code>/data/p4d</code> on the PS4's internal memory via FTP." +
                "<br>Additionally, loose files can be loaded from <kbd>data/p4d/bind</kbd>",
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
                Description = "mod.cpk file replacement via FTP with optional language support",
                LongDescription = "Loads modded files from a <kbd>mod.cpk</kbd> file in <code>/data/p5d</code> on the PS4's internal memory via FTP." +
                "<br>Additionally, loose files can be loaded from <kbd>data/p5d/bind</kbd>",
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