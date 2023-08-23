using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace PersonaGameLib
{
    public partial class Patches
    {
        public static List<GamePatch> ParseYML(string ymlText)
        {
            List<string> ymlLines = ymlText.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None).ToList();
            List<GamePatch> patches = new List<GamePatch>();

            for (int i = 0; i < ymlLines.Count(); i++)
            {
                // If line starts with "PPU-", begin reading patch
                if (ymlLines[i].StartsWith("PPU-"))
                {
                    // Continue serializing data until end of patch or yml file
                    var patch = new GamePatch();
                    int x = i;
                    x++;
                    patch.Name = ymlLines[x].TrimEnd(':').Trim();
                    x++;

                    while (x < ymlLines.Count() && !ymlLines[x].StartsWith("PPU-"))
                    {
                        x++;
                        switch (ymlLines[x])
                        {
                            case string s when !s.StartsWith(" "):
                                patch.Name = s.TrimEnd(':').Trim();
                                break;
                            case string s when s.StartsWith("    Author:"):
                                patch.Author = s.Replace("    Author:", "").Trim();
                                break;
                            case string s when s.StartsWith("    Notes:"):
                                patch.Description = s.Replace("    Notes:", "").Trim();
                                break;
                            case string s when s.StartsWith("    Patch Version:"):
                                patch.Version = s.Replace("    Patch Version:", "").Trim();
                                break;
                            case string s when s.StartsWith("    Patch:"):
                                x++;
                                while (x < ymlLines.Count() && !ymlLines[x].StartsWith("PPU-"))
                                {
                                    patch.Text += "  " + ymlLines[x].Trim() + "\n";
                                    x++;
                                }
                                i = x - 1;
                                break;
                        }
                    }

                    patch.ShortName = patch.Name.Replace(" ", "");

                    // Add serialized patch to patch list
                    patches.Add(patch);
                }
            }

            foreach(var patch in patches)
            {
                switch (patch.Name)
                {
                    case "Mod Cpk Support":
                    case "P5EX":
                    case "Mod SPRX":
                        patch.OnByDefault = true;
                        patch.AlwaysOn = true;
                        break;
                    case "File Access Log":
                    case "Fix Script Printing Functions":
                    case "Skip Intro Videos":
                        patch.OnByDefault = true;
                        break;
                }
            }

            return patches;
        }
    }
}
