using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaGameLib
{
    public partial class Games
    {
        public static List<Game> N3DSGames = new List<Game>()
        {
            new Game() { Name = "Persona Q", ShortName = "PQ", TitleID = "0004000000123400", Region = "USA",
                Platform = "3DS",
                GBURL = "14377", SFName = "PQ",
                Patches = Patches.PQUSAPatches,
                ImageUrl = "https://cdn.mobygames.com/covers/2146239-persona-q-shadow-of-the-labyrinth-front-cover.png" },
            new Game() { Name = "Persona Q2", ShortName = "PQ2", TitleID = "00040000001CBE00", Region = "USA",
                Platform = "3DS",
                GBURL = "9561", SFName = "PQ2",
                Patches = Patches.PQ2USAPatches,
                ImageUrl = "https://cdn.mobygames.com/covers/8005616-persona-q2-new-cinema-labyrinth-front-cover.png" }
        };
    }
}