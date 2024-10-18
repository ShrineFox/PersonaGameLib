using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonaGameLib
{
    public class GamePatch
    {
        /// <summary>
        /// Title of the patch.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Abbreviated title of the patch used as an identifier.
        /// </summary>
        public string ShortName { get; set; } = "";
        /// <summary>
        /// List of creators who contributed to the patch.
        /// </summary>
        public string Author { get; set; } = "";
        public string Version { get; set; } = "";
        public string Description { get; set; } = "";
        public string LongDescription { get; set; } = "";
        /// <summary>
        /// Raw contents of the patch itself.
        /// </summary>
        public string Text { get; set; } = "";
        /// <summary>
        /// When true, the patch cannot be disabled.
        /// </summary>
        public bool AlwaysOn { get; set; } = false;
        /// <summary>
        /// When true, the patch is enabled to start with but can be disabled by user.
        /// </summary>
        public bool Enabled { get; set; } = false;
        /// <summary>
        /// When true, the patch is chosen to be downloaded by the user.
        /// </summary>
        public List<string> Conflicts { get; set; } = new List<string>();
        /// <summary>
        /// The name of the platform this patch is for.
        /// </summary>
        public string TargetPlatform { get; set; } = "";
    }
}