using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonaGameLib
{
    public class Platform
    {
        /// <summary>
        /// Full name of the platform.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Abbreviated name of the platform, used as an identifier.
        /// </summary>
        public string ShortName { get; set; } = "";
        /// <summary>
        /// List of games and their respective patches on the given platform.
        /// </summary>
        public List<Game> Games { get; set; } = new List<Game>();
        /// <summary>
        /// Name of the most common emulator used for this platform.
        /// </summary>
        public string EmulatorName { get; set; } = "";
    }
}