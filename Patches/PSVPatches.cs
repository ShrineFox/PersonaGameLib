using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Patches
    {
        public static List<GamePatch> PSVP4GUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie (can still be viewed in Thieves Den)",
                AlwaysOn = true,
                Enabled = true
            }
        };

        public static List<GamePatch> PSVP4GEURPatches = PSVP4GUSAPatches;

        public static List<GamePatch> PSVP3DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie (can still be viewed in Thieves Den)",
                AlwaysOn = true,
                Enabled = true
            }
        };

        public static List<GamePatch> PSVP4DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie (can still be viewed in Thieves Den)",
                AlwaysOn = true,
                Enabled = true
            }
        };

        public static List<GamePatch> PSVP5DUSAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "Intro Skip", ShortName = "intro_skip", Author = "zarroboogs",
                Description = "Skips boot logos and intro movie (can still be viewed in Thieves Den)",
                AlwaysOn = true,
                Enabled = true
            }
        };
    }
}