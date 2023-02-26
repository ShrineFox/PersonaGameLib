using PersonaGameLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGameLib
{
    public class Game
    {
        /// <summary>
        /// Full title of the game.
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Abbreviated title of the game.
        /// </summary>
        public string ShortName { get; set; } = "";
        /// <summary>
        /// Identifier used for the game on consoles/storefronts.
        /// </summary>
        public string TitleID { get; set; } = "";
        /// <summary>
        /// Geographical location where version of the game is sold.
        /// </summary>
        public string Region { get; set; } = "";
        /// <summary>
        /// Hash used to check if the game's PKG is valid.
        /// </summary>
        public string CRC32 { get; set; } = "";
        /// <summary>
        /// Hash used to check if the game's PKG is valid.
        /// </summary>
        public string MD5 { get; set; } = "";
        /// <summary>
        /// Hash used to check if the game's PKG is valid.
        /// </summary>
        public string SHA1 { get; set; } = "";
        /// <summary>
        /// Hash used to check if the game's ISO is valid.
        /// </summary>
        public string CRC { get; set; } = "";
        /// <summary>
        /// Boxart image URL to represent game.
        /// </summary>
        public string ImageUrl { get; set; } = "";
        /// <summary>
        /// Filename of the output update PKG.
        /// </summary>
        public string UpdatePKGName { get; set; } = "";
        /// <summary>
        /// Size in bytes of the output update PKG.
        /// </summary>
        public int UpdatePKGMinSize { get; set; } = 0;
        /// <summary>
        /// List of patches that the game supports.
        /// </summary>
        public List<GamePatch> Patches { get; set; } = new List<GamePatch>();
    }

    public class FileUtil
    {
        public static string GetFromPath(string path)
        {
            string text = "";
            path = path.Replace("./", System.Web.Hosting.HostingEnvironment.MapPath("~/."));
            if (File.Exists(path))
            {
                text = File.ReadAllText(path);
            }
            return text;
        }
    }
}
