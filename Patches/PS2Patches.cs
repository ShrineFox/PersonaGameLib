using System.Collections.Generic;
using static Microsoft.AspNetCore.Hosting.IWebHostEnvironment;

namespace PersonaGameLib
{
    public partial class Patches
    {
        public static List<GamePatch> PS2P3FESUSAPatches = new List<GamePatch>()
        {
        new GamePatch() { Name = "HostFS", ShortName = "hostFS", Author = "TGE",
                Description = "Loads external files from folders named after the game's archives when running a game from an ELF in PCSX2. Make sure hostFS=enabled in PCSX2_vm.ini.",
                Text = Patches.P3FESHostFS,
                AlwaysOn = true,
                Enabled = true,
                TargetPlatform = "emulator"
            },
            new GamePatch() { Name = "Direct Commands", ShortName = "direct_commands", Author = "TGE, updated by Alexankitty",
                Description = "Allows you to choose a skill or item on your party member's turn, similar to in Persona 4 and 5.",
                Text = "\npatch=1,EE,0029AFC8,word,00000000 // nop check for if battle unit is not mc -> ai (original instruction 14460005 / bne v0,a2,000029AFE0)" +
                "\npatch=1,EE,0020207C,word,00000000 // load proper unit id for battle menu skill list (original instruction hex 14400006 / bnez v0,0000202098)" +
                "\npatch=1,EE,0020208C,word,8F84B6FC" +
                "\npatch=1,EE,00202090,word,8C840254 //Load skill list" +
                "\npatch=1,EE,00202094,word,8C840030 //Load skill list" +
                "\npatch=1,EE,00202098,word,8C8400A4 //Load skill list" +
                "\n//Fusion Skill Fix" +
                "\n//This block is long because the code has been shifted. Further line one is a MIPS characteristic hack where the first line of a branch executes" +
                "\npatch=1,EE,0020203C,word,14400005" +
                "\npatch=1,EE,00202040,word,8E340254" +
                "\npatch=1,EE,00202054,word,8E330148" +
                "\npatch=1,EE,0020207C,word,3C040068" +
                "\npatch=1,EE,00202080,word,24844F48" +
                "\npatch=1,EE,00202084,word,8F84B6FC" +
                "\npatch=1,EE,00202088,word,8C840254" +
                "\npatch=1,EE,0020208C,word,8C840030" +
                "\npatch=1,EE,00202090,word,8C8400A4" +
                "\npatch=1,EE,00202094,word,0C05D200" +
                "\npatch=1,EE,00202098,word,00000000" +
                "\npatch=1,EE,0020209C,word,0040902D" +
                "\npatch=1,EE,002020A0,word,0240202D" +
                "\npatch=1,EE,002020A4,word,0C05DA8C" +
                "\npatch=1,EE,002020A8,word,00000000" +
                "\npatch=1,EE,002020AC,word,0040A82D" +
                "\npatch=1,EE,002020B0,word,0240202D" +
                "\npatch=1,EE,002020B4,word,0C05CCDC" +
                "\npatch=1,EE,002020B8,word,00000000" +
                "\npatch=1,EE,002020BC,word,0040B02D" +
                "\npatch=1,EE,002020C0,word,0000902D" +
                "\npatch=1,EE,002020C4,word,0C0C3030" +
                "\npatch=1,EE,002020C8,word,00000000" +
                "\npatch=1,EE,002020CC,word,10400013" +
                "\npatch=1,EE,002020D0,word,00000000" +
                "\npatch=1,EE,002020D4,word,16740011" +
                "\npatch=1,EE,0028DE14,word,2405001B // fix escape" +
                "\npatch=1,EE,0029692C,word,00000000" +
                "\npatch=1,EE,0028AC5C,word,9683001A // disable persona menu for non-mc" +
                "\npatch=1,EE,0028AC60,word,3063FFBF" +
                "\npatch=1,EE,0028AC64,word,A683001A" +
                "\npatch=1,EE,0028AC68,word,96830018" +
                "\npatch=1,EE,0028AC6C,word,00000000" +
                "\npatch=1,EE,0028AC70,word,081A6AF8" +
                "\npatch=1,EE,0028AC74,word,92920028 //Item effect/Start of turn effect fix. Changes the register we load the one more compare into" +
                "\npatch=1,EE,0028AC78,word,1640000B //Changes which register we branch compare." +
                "\npatch=1,EE,0069ABE0,word,8F82B6FC" +
                "\npatch=1,EE,0069ABE4,word,8C420148" +
                "\npatch=1,EE,0069ABE8,word,14540004 " +
                "\npatch=1,EE,0069ABEC,word,00000000" +
                "\npatch=1,EE,0069ABF0,word,34630400" +
                "\npatch=1,EE,0069ABF4,word,A6830018" +
                "\npatch=1,EE,0069ABF8,word,34630400" +
                "\npatch=1,EE,0069ABFC,word,080A2B1D" +
                "\npatch=1,EE,0069AC00,word,00000000" +
                "\npatch=1,EE,001FF518,word,8E300254 // fix skill requirements" +
                "\npatch=1,EE,001FF51C,word,8E100030" +
                "\npatch=1,EE,001FF520,word,8E1000A4" +
                "\npatch=1,EE,001FF524,word,00000000" +
                "\npatch=1,EE,001FF528,word,00000000" +
                "\npatch=1,EE,001FF52C,word,00000000" +
                "\npatch=1,EE,002D8210,word,00000000 // fix items" +
                "\npatch=1,EE,002D8220,word,00000000" +
                "\npatch=1,EE,002D8224,word,00000000" +
                "\npatch=1,EE,002D823C,word,00000000" +
                "\npatch=1,EE,002A3914,word,081A6B01 // fix boss battle camera" +
                "\npatch=1,EE,0069AC04,word,1240000B" +
                "\npatch=1,EE,0069AC08,word,00000000" +
                "\npatch=1,EE,0069AC0C,word,8E420030" +
                "\npatch=1,EE,0069AC10,word,844700A2" +
                "\npatch=1,EE,0069AC14,word,20030001" +
                "\npatch=1,EE,0069AC18,word,14E00006" +
                "\npatch=1,EE,0069AC1C,word,00000000" +
                "\npatch=1,EE,0069AC20,word,844200A4" +
                "\npatch=1,EE,0069AC24,word,10430003" +
                "\npatch=1,EE,0069AC28,word,00001021" +
                "\npatch=1,EE,0069AC2C,word,080A8E47" +
                "\npatch=1,EE,0069AC30,word,00000000" +
                "\npatch=1,EE,0069AC34,word,0C0BE210" +
                "\npatch=1,EE,0069AC38,word,00000000" +
                "\npatch=1,EE,0069AC3C,word,080A8E47" +
                "\npatch=1,EE,0069AC40,word,00000000",
                Enabled = true
            },
            new GamePatch() { Name = "Debug Log", ShortName = "debug_log", Author = "TGE, Tupelov",
                Description = "Prints string output from the game's original debug functions into the PCSX2 log. Also prints the filename and path of each file the game accesses in real time, helpful for finding and narrowing down the location of assets like models, fields etc.",
                Text = "patch=1,EE,00503768,word,00000000 // always branch even if not debug" +
                "\npatch=1,EE,005CDE83,byte,0A // patch file load print string" +
                "\npatch=1,EE,00100DAC,word,0C14896A // patch file load function call to debug print" +
                "\npatch=0,EE,00558cd4,word,00000000// fixes sceopen error",
                Enabled = true
            },
            new GamePatch() { Name = "Unlimited Persona Changes", ShortName = "unlimited_persona_changes", Author = "TGE, Tupelov",
                Description = "This cheat allows you to change personas multiple times per turn.",
                Text = "patch=1,EE,00297724,word,00000000 // // Nop setting the persona switch flag"
            },
            new GamePatch() { Name = "Instant Persona Switch", ShortName = "instant_persona_switch", Author = "TGE, Tupelov",
                Description = "This cheat skips the animation that occurs when you switch personas.",
                Text = "patch=1,EE,00297708,word,00000000 // Nop checking if the battle packet is ready"
            },
            new GamePatch() { Name = "Field Script Anywhere", ShortName = "fldscript", Author = "Tupelov",
                Description = "Use the Field Script Anywhere (from Tupelov's Game Patches).",
                Text = "patch=1,EE,001c8998,word,00000000 //nops debug check",
                Enabled = false
            },
            new GamePatch() { Name = "No Battle UI", ShortName = "nobattleui", Author = "Tupelov",
                Description = "Hides UI graphics in battle (from Tupelov's Game Patches).",
                Text = "// return immediatly upon entering battle_panel_draw" +
                "\npatch=1,EE,001fdac0,word,03e00008 // jr ra" +
                "\npatch=1,EE,001fdac4,word,00000000 // nop",
                Enabled = false
            },
            new GamePatch() { Name = "Non-crusty Velvet Room BG", ShortName = "velvetBG", Author = "Tupelov",
                Description = "Makes the game not load the crusty background in the Velvet Room (from Tupelov's Game Patches).",
                Text = "patch=1,EE,003D3D84,word,24040001// Set register a0 to 1" +
                "\npatch=1,EE,003D3D88,word,24050001// Set register a1 to 1" +
                "\n//Edits fusion room call to not make npcs invisible" +
                "\npatch=1,EE,003D3D98,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003D3DA8,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003D3DB8,word,24050001// Set register a1 to 1" +
                "\n//Edits compendium call" +
                "\npatch=1,EE,003E9320,word,24040001// Set register a0 to 1" +
                "\npatch=1,EE,003E9324,word,24050001// Set register a1 to 1" +
                "\n//Edits compendium call to not make npcs invisble" +
                "\npatch=1,EE,003e9338,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003e9344,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003e9358,word,24050001// Set register a1 to 1" +
                "\n//Edits igor call" +
                "\npatch=1,EE,003d51a0,word,24040001// Set register a0 to 1" +
                "\npatch=1,EE,003d51a4,word,24050001// Set register a1 to 1" +
                "\n//Edits igor call to not make npcs invisible" +
                "\npatch=1,EE,003d51b4,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003d51c4,word,24050001// Set register a1 to 1" +
                "\npatch=1,EE,003d51d4,word,24050001// Set register a1 to 1" +
                "\n//Makes the game not load the crusty background" +
                "\npatch=1,EE,006a7a90,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006a7a94,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006a7a98,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006a7a9c,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006A7AA0,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006A7AA4,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,006A7AA8,word,00000000// Removes path to background sprite" +
                "\npatch=1,EE,00620194,word,00000000// Removes string for background sprite" +
                "\npatch=1,EE,00620198,word,00000000// Removes string for background sprite" +
                "\npatch=1,EE,0062019C,word,00000000// Removes string for background sprite" +
                "\npatch=1,EE,006201A0,word,00000000// Removes string for background sprite" +
                "\npatch=1,EE,006201A4,word,00000000// Removes string for background sprite" +
                "\npatch=1,EE,006201A8,word,00000000// Removes string for background sprite",
                Enabled = false
            },
            new GamePatch() { Name = "Debug Options in Tartarus", ShortName = "debug_options_in_tartarus", Author = "Unknown",
                Description = "This cheat grants you an extra menu option in Tartarus that can be used to skip to the next floor or return to the entrance.",
                Text = "patch=1,EE,D07E0842,extended,00007FFF" +
                "\npatch=1,EE,0083A418,extended,0000000F" +
                "\npatch=1,EE,D07E0842,extended,0000BFFF" +
                "\npatch=1,EE,0083A418,extended,00000000"
            },
            new GamePatch() { Name = "Debug Calendar Mode", ShortName = "debug_calendar_mode", Author = "Unknown",
                Description = "This cheat allows you to select a date and time of day from a calendar overlay by pressing Select.",
                Text = "// Debug Calendar Mode" +
                "\npatch=1,EE,211672E0,word,00000001" +
                "\npatch=1,EE,20100718,word,00000000" +
                "\npatch=1,EE,20100724,word,00000000" +
                "\npatch=1,EE,20100728,word,00000000"
            },
            new GamePatch() { Name = "Gain EXP x4095 (Whole Party)", ShortName = "gain_exp_x4095_(whole_party)", Author = "Unknown",
                Description = "This cheat multiplies the EXP you earn from battle by 4095. Use this to quickly reach level 99.",
                Text = "//Gain EXP x4095 (All party)" +
                "\npatch=1,EE,201FBF6C,extended,24010FFF" +
                "\npatch=1,EE,201FBF70,extended,10000003" +
                "\npatch=1,EE,201FBF74,extended,00411018"
            },
            new GamePatch() { Name = "Max Money", ShortName = "max_money", Author = "Unknown",
                Description = "This cheat maxes out your Yen.",
                Text = "patch=1,EE,2083A6DC,extended,0098967F"
            },
            new GamePatch() { Name = "Max Social Stats", ShortName = "max_social_stats", Author = "Unknown",
                Description = "These cheats give you the maximum level of points for each social stat.",
                Text = "patch=1,EE,40836BC8,extended,000C000D" +
                "\npatch=1,EE,63636363,extended,00000000" +
                "\npatch=1,EE,40836BCC,extended,000C000D" +
                "\npatch=1,EE,00000063,extended,00000000"
            },
            new GamePatch() { Name = "Max Persona Stats", ShortName = "max_persona_stats", Author = "Unknown",
                Description = "This cheat gives the protagonist's currently equipped Persona maximum stats.",
                Text = "patch=1,EE,40836BC8,extended,000C000D" +
                "\npatch=1,EE,63636363,extended,00000000" +
                "\npatch=1,EE,40836BCC,extended,000C000D" +
                "\npatch=1,EE,00000063,extended,00000000"
            },
            new GamePatch() { Name = "Max Armor Stats", ShortName = "max_armor_stats", Author = "Unknown",
                Description = "These cheats give you the maximum stats for each item currently equipped by the protagonist.",
                Text = "//All Weapon Max (When Equip By MC)" +
                "\npatch=1,EE,410C15F8,extended,00630005" +
                "\npatch=1,EE,03E74502,extended,00000000" +
                "//All Armor Max (When Equip By MC)" +
                "\npatch=1,EE,410C15FC,extended,00630005" +
                "\npatch=1,EE,03E703E7,extended,00000000" +
                "//All Footwear Max (When Equip By MC)" +
                "\npatch=1,EE,410C1600,extended,00630005" +
                "\npatch=1,EE,000003E7,extended,00000000"
            },
            new GamePatch() { Name = "All Items", ShortName = "all_items", Author = "Unknown",
                Description = "This cheat gives you 99 of every possible item you can obtain, even some dummy items that don't do anything.",
                Text = "patch=1,EE,410C2D90,extended,00700001" +
                "\npatch=1,EE,00630063,extended,00000000"
            },
            new GamePatch() { Name = "All Social Links Maxed", ShortName = "all_social_links_maxed", Author = "Unknown",
                Description = "This cheat maxes out the current level of each of your social links.",
                Text = "patch=1,EE,10836276,extended,00000A0A" +
                "\npatch=1,EE,40836278,extended,00070001" +
                "\npatch=1,EE,0A0A0A0A,extended,00000000"
            },
            new GamePatch() { Name = "All Personas in Compendium (Level 0)", ShortName = "all_personas_in_compendium_(level_0)", Author = "Unknown",
                Description = "This cheat unlocks every Persona you can possibly buy from the compendium. They start at Level 0 but can be levelled up after one battle. Note: This overwrites previously registered Personas. Save and then stop using this code to continue registering your own Personas.",
                Text = "patch=1,EE,10836E52,extended,00000001" +
                "\npatch=1,EE,10836E86,extended,00000002" +
                "\npatch=1,EE,10836EBA,extended,00000003" +
                "\npatch=1,EE,10836EEE,extended,00000004" +
                "\npatch=1,EE,10836F22,extended,00000005" +
                "\npatch=1,EE,10836F56,extended,00000006" +
                "\npatch=1,EE,10836F8A,extended,00000007" +
                "\npatch=1,EE,10836FBE,extended,00000008" +
                "\npatch=1,EE,10836FF2,extended,00000009" +
                "\npatch=1,EE,10837026,extended,0000000A" +
                "\npatch=1,EE,1083705A,extended,0000000B" +
                "\npatch=1,EE,1083708E,extended,0000000C" +
                "\npatch=1,EE,108370C2,extended,0000000D" +
                "\npatch=1,EE,108370F6,extended,0000000E" +
                "\npatch=1,EE,1083712A,extended,0000000F" +
                "\npatch=1,EE,1083715E,extended,00000010" +
                "\npatch=1,EE,10837192,extended,00000011" +
                "\npatch=1,EE,108371C6,extended,00000012" +
                "\npatch=1,EE,108371FA,extended,00000013" +
                "\npatch=1,EE,1083722E,extended,00000014" +
                "\npatch=1,EE,10837262,extended,00000015" +
                "\npatch=1,EE,10837296,extended,00000016" +
                "\npatch=1,EE,108372CA,extended,00000017" +
                "\npatch=1,EE,108372FE,extended,00000018" +
                "\npatch=1,EE,10837332,extended,00000019" +
                "\npatch=1,EE,10837366,extended,0000001A" +
                "\npatch=1,EE,1083739A,extended,0000001B" +
                "\npatch=1,EE,108373CE,extended,0000001C" +
                "\npatch=1,EE,10837402,extended,0000001D" +
                "\npatch=1,EE,10837436,extended,0000001E" +
                "\npatch=1,EE,1083746A,extended,0000001F" +
                "\npatch=1,EE,1083749E,extended,00000020" +
                "\npatch=1,EE,108374D2,extended,00000021" +
                "\npatch=1,EE,10837506,extended,00000022" +
                "\npatch=1,EE,1083753A,extended,00000023" +
                "\npatch=1,EE,1083756E,extended,00000024" +
                "\npatch=1,EE,108375A2,extended,00000025" +
                "\npatch=1,EE,108375D6,extended,00000026" +
                "\npatch=1,EE,1083760A,extended,00000027" +
                "\npatch=1,EE,1083763E,extended,00000028" +
                "\npatch=1,EE,10837672,extended,00000029" +
                "\npatch=1,EE,108376A6,extended,0000002A" +
                "\npatch=1,EE,108376DA,extended,0000002B" +
                "\npatch=1,EE,1083770E,extended,0000002C" +
                "\npatch=1,EE,10837742,extended,0000002D" +
                "\npatch=1,EE,10837776,extended,0000002E" +
                "\npatch=1,EE,108377AA,extended,0000002F" +
                "\npatch=1,EE,108377DE,extended,00000030" +
                "\npatch=1,EE,10837812,extended,00000031" +
                "\npatch=1,EE,10837846,extended,00000032" +
                "\npatch=1,EE,1083787A,extended,00000033" +
                "\npatch=1,EE,108378AE,extended,00000034" +
                "\npatch=1,EE,108378E2,extended,00000035" +
                "\npatch=1,EE,10837916,extended,00000036" +
                "\npatch=1,EE,1083794A,extended,00000037" +
                "\npatch=1,EE,1083797E,extended,00000038" +
                "\npatch=1,EE,108379B2,extended,00000039" +
                "\npatch=1,EE,108379E6,extended,0000003A" +
                "\npatch=1,EE,10837A1A,extended,0000003B" +
                "\npatch=1,EE,10837A4E,extended,0000003C" +
                "\npatch=1,EE,10837A82,extended,0000003D" +
                "\npatch=1,EE,10837AB6,extended,0000003E" +
                "\npatch=1,EE,10837AEA,extended,0000003F" +
                "\npatch=1,EE,10837B1E,extended,00000040" +
                "\npatch=1,EE,10837B52,extended,00000041" +
                "\npatch=1,EE,10837B86,extended,00000042" +
                "\npatch=1,EE,10837BBA,extended,00000043" +
                "\npatch=1,EE,10837BEE,extended,00000044" +
                "\npatch=1,EE,10837C22,extended,00000045" +
                "\npatch=1,EE,10837C56,extended,00000046" +
                "\npatch=1,EE,10837C8A,extended,00000047" +
                "\npatch=1,EE,10837CBE,extended,00000048" +
                "\npatch=1,EE,10837CF2,extended,00000049" +
                "\npatch=1,EE,10837D26,extended,0000004A" +
                "\npatch=1,EE,10837D5A,extended,0000004B" +
                "\npatch=1,EE,10837D8E,extended,0000004C" +
                "\npatch=1,EE,10837DC2,extended,0000004D" +
                "\npatch=1,EE,10837DF6,extended,0000004E" +
                "\npatch=1,EE,10837E2A,extended,0000004F" +
                "\npatch=1,EE,10837E5E,extended,00000050" +
                "\npatch=1,EE,10837E92,extended,00000051" +
                "\npatch=1,EE,10837EC6,extended,00000052" +
                "\npatch=1,EE,10837EFA,extended,00000053" +
                "\npatch=1,EE,10837F2E,extended,00000054" +
                "\npatch=1,EE,10837F62,extended,00000055" +
                "\npatch=1,EE,10837F96,extended,00000056" +
                "\npatch=1,EE,10837FCA,extended,00000057" +
                "\npatch=1,EE,10837FFE,extended,00000058" +
                "\npatch=1,EE,10838032,extended,00000059" +
                "\npatch=1,EE,10838066,extended,0000005A" +
                "\npatch=1,EE,1083809A,extended,0000005B" +
                "\npatch=1,EE,108380CE,extended,0000005C" +
                "\npatch=1,EE,10838102,extended,0000005D" +
                "\npatch=1,EE,10838136,extended,0000005E" +
                "\npatch=1,EE,1083816A,extended,0000005F" +
                "\npatch=1,EE,1083819E,extended,00000060" +
                "\npatch=1,EE,108381D2,extended,00000061" +
                "\npatch=1,EE,10838206,extended,00000062" +
                "\npatch=1,EE,1083823A,extended,00000063" +
                "\npatch=1,EE,1083826E,extended,00000064" +
                "\npatch=1,EE,108382A2,extended,00000065" +
                "\npatch=1,EE,108382D6,extended,00000066" +
                "\npatch=1,EE,1083830A,extended,00000067" +
                "\npatch=1,EE,1083833E,extended,00000068" +
                "\npatch=1,EE,10838372,extended,00000069" +
                "\npatch=1,EE,108383A6,extended,0000006A" +
                "\npatch=1,EE,108383DA,extended,0000006B" +
                "\npatch=1,EE,1083840E,extended,0000006C" +
                "\npatch=1,EE,10838442,extended,0000006D" +
                "\npatch=1,EE,10838476,extended,0000006E" +
                "\npatch=1,EE,108384AA,extended,0000006F" +
                "\npatch=1,EE,108384DE,extended,00000070" +
                "\npatch=1,EE,10838512,extended,00000071" +
                "\npatch=1,EE,10838546,extended,00000072" +
                "\npatch=1,EE,1083857A,extended,00000073" +
                "\npatch=1,EE,108385AE,extended,00000074" +
                "\npatch=1,EE,108385E2,extended,00000075" +
                "\npatch=1,EE,10838616,extended,00000076" +
                "\npatch=1,EE,1083864A,extended,00000077" +
                "\npatch=1,EE,1083867E,extended,00000078" +
                "\npatch=1,EE,108386B2,extended,00000079" +
                "\npatch=1,EE,108386E6,extended,0000007A" +
                "\npatch=1,EE,1083871A,extended,0000007B" +
                "\npatch=1,EE,1083874E,extended,0000007C" +
                "\npatch=1,EE,10838782,extended,0000007D" +
                "\npatch=1,EE,108387B6,extended,0000007E" +
                "\npatch=1,EE,108387EA,extended,0000007F" +
                "\npatch=1,EE,1083881E,extended,00000080" +
                "\npatch=1,EE,10838852,extended,00000081" +
                "\npatch=1,EE,10838886,extended,00000082" +
                "\npatch=1,EE,108388BA,extended,00000083" +
                "\npatch=1,EE,108388EE,extended,00000084" +
                "\npatch=1,EE,10838922,extended,00000085" +
                "\npatch=1,EE,10838956,extended,00000086" +
                "\npatch=1,EE,1083898A,extended,00000087" +
                "\npatch=1,EE,108389BE,extended,00000088" +
                "\npatch=1,EE,108389F2,extended,00000089" +
                "\npatch=1,EE,10838A26,extended,0000008A" +
                "\npatch=1,EE,10838A5A,extended,0000008B" +
                "\npatch=1,EE,10838A8E,extended,0000008C" +
                "\npatch=1,EE,10838AC2,extended,0000008D" +
                "\npatch=1,EE,10838AF6,extended,0000008E" +
                "\npatch=1,EE,10838B2A,extended,0000008F" +
                "\npatch=1,EE,10838B5E,extended,00000090" +
                "\npatch=1,EE,10838BC6,extended,00000092" +
                "\npatch=1,EE,10838BFA,extended,00000093" +
                "\npatch=1,EE,10838C2E,extended,00000094" +
                "\npatch=1,EE,10838C62,extended,00000095" +
                "\npatch=1,EE,10838C96,extended,00000096" +
                "\npatch=1,EE,10838CCA,extended,00000097" +
                "\npatch=1,EE,10838CFE,extended,00000098" +
                "\npatch=1,EE,10838D32,extended,00000099" +
                "\npatch=1,EE,10838D66,extended,0000009A" +
                "\npatch=1,EE,10838D9A,extended,0000009B" +
                "\npatch=1,EE,10838DCE,extended,0000009C" +
                "\npatch=1,EE,10838E02,extended,0000009D" +
                "\npatch=1,EE,10838E36,extended,0000009E" +
                "\npatch=1,EE,10838E6A,extended,0000009F" +
                "\npatch=1,EE,10838E9E,extended,000000A0" +
                "\npatch=1,EE,10838ED2,extended,000000A1" +
                "\npatch=1,EE,10838F06,extended,000000A2" +
                "\npatch=1,EE,10838F3A,extended,000000A3" +
                "\npatch=1,EE,10838F6E,extended,000000A4" +
                "\npatch=1,EE,10838FA2,extended,000000A5" +
                "\npatch=1,EE,10838FD6,extended,000000A6" +
                "\npatch=1,EE,1083900A,extended,000000A7" +
                "\npatch=1,EE,1083903E,extended,000000A8" +
                "\npatch=1,EE,10839072,extended,000000A9" +
                "\npatch=1,EE,10836E50,extended,00000001" +
                "\npatch=1,EE,10836E84,extended,00000001" +
                "\npatch=1,EE,10836EB8,extended,00000001" +
                "\npatch=1,EE,10836EEC,extended,00000001" +
                "\npatch=1,EE,10836F20,extended,00000001" +
                "\npatch=1,EE,10836F54,extended,00000001" +
                "\npatch=1,EE,10836F88,extended,00000001" +
                "\npatch=1,EE,10836FBC,extended,00000001" +
                "\npatch=1,EE,10836FF0,extended,00000001" +
                "\npatch=1,EE,10837024,extended,00000001" +
                "\npatch=1,EE,10837058,extended,00000001" +
                "\npatch=1,EE,1083708C,extended,00000001" +
                "\npatch=1,EE,108370C0,extended,00000001" +
                "\npatch=1,EE,108370F4,extended,00000001" +
                "\npatch=1,EE,10837128,extended,00000001" +
                "\npatch=1,EE,1083715C,extended,00000001" +
                "\npatch=1,EE,10837190,extended,00000001" +
                "\npatch=1,EE,108371C4,extended,00000001" +
                "\npatch=1,EE,108371F8,extended,00000001" +
                "\npatch=1,EE,1083722C,extended,00000001" +
                "\npatch=1,EE,10837260,extended,00000001" +
                "\npatch=1,EE,10837294,extended,00000001" +
                "\npatch=1,EE,108372C8,extended,00000001" +
                "\npatch=1,EE,108372FC,extended,00000001" +
                "\npatch=1,EE,10837330,extended,00000001" +
                "\npatch=1,EE,10837364,extended,00000001" +
                "\npatch=1,EE,10837398,extended,00000001" +
                "\npatch=1,EE,108373CC,extended,00000001" +
                "\npatch=1,EE,10837400,extended,00000001" +
                "\npatch=1,EE,10837434,extended,00000001" +
                "\npatch=1,EE,10837468,extended,00000001" +
                "\npatch=1,EE,1083749C,extended,00000001" +
                "\npatch=1,EE,108374D0,extended,00000001" +
                "\npatch=1,EE,10837504,extended,00000001" +
                "\npatch=1,EE,10837538,extended,00000001" +
                "\npatch=1,EE,1083756C,extended,00000001" +
                "\npatch=1,EE,108375A0,extended,00000001" +
                "\npatch=1,EE,108375D4,extended,00000001" +
                "\npatch=1,EE,10837608,extended,00000001" +
                "\npatch=1,EE,1083763C,extended,00000001" +
                "\npatch=1,EE,10837670,extended,00000001" +
                "\npatch=1,EE,108376A4,extended,00000001" +
                "\npatch=1,EE,108376D8,extended,00000001" +
                "\npatch=1,EE,1083770C,extended,00000001" +
                "\npatch=1,EE,10837740,extended,00000001" +
                "\npatch=1,EE,10837774,extended,00000001" +
                "\npatch=1,EE,108377A8,extended,00000001" +
                "\npatch=1,EE,108377DC,extended,00000001" +
                "\npatch=1,EE,10837810,extended,00000001" +
                "\npatch=1,EE,10837844,extended,00000001" +
                "\npatch=1,EE,10837878,extended,00000001" +
                "\npatch=1,EE,108378AC,extended,00000001" +
                "\npatch=1,EE,108378E0,extended,00000001" +
                "\npatch=1,EE,10837914,extended,00000001" +
                "\npatch=1,EE,10837948,extended,00000001" +
                "\npatch=1,EE,1083797C,extended,00000001" +
                "\npatch=1,EE,108379B0,extended,00000001" +
                "\npatch=1,EE,108379E4,extended,00000001" +
                "\npatch=1,EE,10837A18,extended,00000001" +
                "\npatch=1,EE,10837A4C,extended,00000001" +
                "\npatch=1,EE,10837A80,extended,00000001" +
                "\npatch=1,EE,10837AB4,extended,00000001" +
                "\npatch=1,EE,10837AE8,extended,00000001" +
                "\npatch=1,EE,10837B1C,extended,00000001" +
                "\npatch=1,EE,10837B50,extended,00000001" +
                "\npatch=1,EE,10837B84,extended,00000001" +
                "\npatch=1,EE,10837BB8,extended,00000001" +
                "\npatch=1,EE,10837BEC,extended,00000001" +
                "\npatch=1,EE,10837C20,extended,00000001" +
                "\npatch=1,EE,10837C54,extended,00000001" +
                "\npatch=1,EE,10837C88,extended,00000001" +
                "\npatch=1,EE,10837CBC,extended,00000001" +
                "\npatch=1,EE,10837CF0,extended,00000001" +
                "\npatch=1,EE,10837D24,extended,00000001" +
                "\npatch=1,EE,10837D58,extended,00000001" +
                "\npatch=1,EE,10837D8C,extended,00000001" +
                "\npatch=1,EE,10837DC0,extended,00000001" +
                "\npatch=1,EE,10837DF4,extended,00000001" +
                "\npatch=1,EE,10837E28,extended,00000001" +
                "\npatch=1,EE,10837E5C,extended,00000001" +
                "\npatch=1,EE,10837E90,extended,00000001" +
                "\npatch=1,EE,10837EC4,extended,00000001" +
                "\npatch=1,EE,10837EF8,extended,00000001" +
                "\npatch=1,EE,10837F2C,extended,00000001" +
                "\npatch=1,EE,10837F60,extended,00000001" +
                "\npatch=1,EE,10837F94,extended,00000001" +
                "\npatch=1,EE,10837FC8,extended,00000001" +
                "\npatch=1,EE,10837FFC,extended,00000001" +
                "\npatch=1,EE,10838030,extended,00000001" +
                "\npatch=1,EE,10838064,extended,00000001" +
                "\npatch=1,EE,10838098,extended,00000001" +
                "\npatch=1,EE,108380CC,extended,00000001" +
                "\npatch=1,EE,10838100,extended,00000001" +
                "\npatch=1,EE,10838134,extended,00000001" +
                "\npatch=1,EE,10838168,extended,00000001" +
                "\npatch=1,EE,1083819C,extended,00000001" +
                "\npatch=1,EE,108381D0,extended,00000001" +
                "\npatch=1,EE,10838204,extended,00000001" +
                "\npatch=1,EE,10838238,extended,00000001" +
                "\npatch=1,EE,1083826C,extended,00000001" +
                "\npatch=1,EE,108382A0,extended,00000001" +
                "\npatch=1,EE,108382D4,extended,00000001" +
                "\npatch=1,EE,10838308,extended,00000001" +
                "\npatch=1,EE,1083833C,extended,00000001" +
                "\npatch=1,EE,10838370,extended,00000001" +
                "\npatch=1,EE,108383A4,extended,00000001" +
                "\npatch=1,EE,108383D8,extended,00000001" +
                "\npatch=1,EE,1083840C,extended,00000001" +
                "\npatch=1,EE,10838440,extended,00000001" +
                "\npatch=1,EE,10838474,extended,00000001" +
                "\npatch=1,EE,108384A8,extended,00000001" +
                "\npatch=1,EE,108384DC,extended,00000001" +
                "\npatch=1,EE,10838510,extended,00000001" +
                "\npatch=1,EE,10838544,extended,00000001" +
                "\npatch=1,EE,10838578,extended,00000001" +
                "\npatch=1,EE,108385AC,extended,00000001" +
                "\npatch=1,EE,108385E0,extended,00000001" +
                "\npatch=1,EE,10838614,extended,00000001" +
                "\npatch=1,EE,10838648,extended,00000001" +
                "\npatch=1,EE,1083867C,extended,00000001" +
                "\npatch=1,EE,108386B0,extended,00000001" +
                "\npatch=1,EE,108386E4,extended,00000001" +
                "\npatch=1,EE,10838718,extended,00000001" +
                "\npatch=1,EE,1083874C,extended,00000001" +
                "\npatch=1,EE,10838780,extended,00000001" +
                "\npatch=1,EE,108387B4,extended,00000001" +
                "\npatch=1,EE,108387E8,extended,00000001" +
                "\npatch=1,EE,1083881C,extended,00000001" +
                "\npatch=1,EE,10838850,extended,00000001" +
                "\npatch=1,EE,10838884,extended,00000001" +
                "\npatch=1,EE,108388B8,extended,00000001" +
                "\npatch=1,EE,108388EC,extended,00000001" +
                "\npatch=1,EE,10838920,extended,00000001" +
                "\npatch=1,EE,10838954,extended,00000001" +
                "\npatch=1,EE,10838988,extended,00000001" +
                "\npatch=1,EE,108389BC,extended,00000001" +
                "\npatch=1,EE,108389F0,extended,00000001" +
                "\npatch=1,EE,10838A24,extended,00000001" +
                "\npatch=1,EE,10838A58,extended,00000001" +
                "\npatch=1,EE,10838A8C,extended,00000001" +
                "\npatch=1,EE,10838AC0,extended,00000001" +
                "\npatch=1,EE,10838AF4,extended,00000001" +
                "\npatch=1,EE,10838B28,extended,00000001" +
                "\npatch=1,EE,10838B5C,extended,00000001" +
                "\npatch=1,EE,10838B90,extended,00000001" +
                "\npatch=1,EE,10838BC4,extended,00000001" +
                "\npatch=1,EE,10838BF8,extended,00000001" +
                "\npatch=1,EE,10838C2C,extended,00000001" +
                "\npatch=1,EE,10838C60,extended,00000001" +
                "\npatch=1,EE,10838C94,extended,00000001" +
                "\npatch=1,EE,10838CC8,extended,00000001" +
                "\npatch=1,EE,10838CFC,extended,00000001" +
                "\npatch=1,EE,10838D30,extended,00000001" +
                "\npatch=1,EE,10838D64,extended,00000001" +
                "\npatch=1,EE,10838D98,extended,00000001" +
                "\npatch=1,EE,10838DCC,extended,00000001" +
                "\npatch=1,EE,10838E00,extended,00000001" +
                "\npatch=1,EE,10838E34,extended,00000001" +
                "\npatch=1,EE,10838E68,extended,00000001" +
                "\npatch=1,EE,10838E9C,extended,00000001" +
                "\npatch=1,EE,10838ED0,extended,00000001" +
                "\npatch=1,EE,10838F04,extended,00000001" +
                "\npatch=1,EE,10838F38,extended,00000001" +
                "\npatch=1,EE,10838F6C,extended,00000001" +
                "\npatch=1,EE,10838FA0,extended,00000001" +
                "\npatch=1,EE,10838FD4,extended,00000001" +
                "\npatch=1,EE,10839008,extended,00000001" +
                "\npatch=1,EE,1083903C,extended,00000001" +
                "\npatch=1,EE,10839070,extended,00000001"
            },
            new GamePatch() { Name = "No Level Limit When Fusing Persona", ShortName = "no_level_limit_when_fusing_persona", Author = "Unknown",
                Description = "This cheat removes the player level limitation when fusing Personas.",
                Text = "patch=1,EE,203d6bdc,extended,00000000"
            },
            new GamePatch() { Name = "Compendium Personas Cost No Money", ShortName = "compendium_personas_cost_no_money", Author = "Unknown",
                Description = "This cheat sets the cost to zero when summoning Personas from the Compendium.",
                Text = "patch=1,EE,2040bb58,extended,0000202D"
            },
            new GamePatch() { Name = "Party Member Mod", ShortName = "party_member_mod", Author = "Unknown",
                Description = "These cheats allow you to change the value of the other characters currently in your party. This has the unintended side effect of them following you even outside of the dungeon.",
                Text = "// 00 None 01 Protagonist (Crashes the game) 02 Yukari 03 Aigis 04 Mitsuru 05 Fuuka (Crashes the game) 06 Akihiko 07 Ken 08 Shinjiro (Metis in The Answer) 09 Koromaru" +
                "// Party Member 2 Mod" +
                "\npatch=1,EE,1083A6E0,extended,000000??" +
                "// Party Member 3 Mod" +
                "\npatch=1,EE,1083A6E2,extended,000000??" +
                "// Party Member 4 Mod" +
                "\npatch=1,EE,1083A6E4,extended,000000??"
            },
            new GamePatch() { Name = "Analog Camera Control", ShortName = "analog_camera_control", Author = "AltimorTASDK",
                Description = "This makes camera turn speed dependent on how far you've pushed the analog stick. Normally the game only lets you turn once the stick passes a certain threshold at a fixed speed.",
                Text = "// \"processInput\" jump to patch code" +
                "\npatch=1,EE,001E05B0,word,08140d17 // j $50345C  Jump to custom code that restores turn rate" +
                "// \"processInput\" fix sticks being offset by 128 instead of 127" +
                "\npatch=1,EE,001E073C,word,3c0242fe // lui v0, $42FE" +
                "\npatch=1,EE,001E07C4,word,3c0342fe // lui v1, $42FE" +
                "\npatch=1,EE,001E0844,word,3c0342fe // lui v1, $42FE" +
                "\npatch=1,EE,001E0898,word,3c0342fe // lui v1, $42FE" +
                "// \"processInput\" right stick left turn check, jump to patch code" +
                "\npatch=1,EE,001E09DC,word,3c03c120 // lui v1, $C120 Change deadzone to -10.0" +
                "\npatch=1,EE,001E09EC,word,08140d10 // j $503440  Jump to custom code that adjusts turn rate" +
                "// \"processInput\" right stick right turn check, jump to patch code" +
                "\npatch=1,EE,001E08B8,word,3c034120 // lui v1, $4120 Change deadzone to 10.0" +
                "\npatch=1,EE,001E08C8,word,08140cfc // j $5033F0  Jump to custom code that adjusts turn rate" +
                "// Patch custom turn code over some unused syscall wrappers" +
                "// Left turn hook" +
                "// $v1, $a0, $f0 and $f20 are free to use" +
                "// $f1 contains the right stick X axis as [-127, 128]" +
                "// -004AC4($gp) aka $B53C(gp) is turn rate" +
                "// Check if out of deadzone" +
                "\npatch=1,EE,00503440,word,45000005 // bc1f $5" +
                "// $f0 = $f1 / 64.0" +
                "\npatch=1,EE,00503444,word,3c03c1c0 // lui v1, $C1C0  $v1 = -24.0" +
                "\npatch=1,EE,00503448,word,44830000 // mtc1 v1, $f0   $f0 = v1" +
                "\npatch=1,EE,0050344C,word,46000803 // div.s $f0, $f1, $f0$f0 = $f1 / $f0" +
                "// $B53C(gp) *= f0" +
                "\npatch=1,EE,00503450,word,0807827d // j $1E09F4  return" +
                "\npatch=1,EE,00503454,word,e780b53c // swc1 $f0, $B53C(gp)$B53C(gp) = $f0" +
                "// outside of deadzone" +
                "\npatch=1,EE,00503458,word,080782ba // j $1E0AE8  return" +
                "\npatch=1,EE,0050345C,word,00000000 // nop" +
                "// Restore turn rate at the beginning of processInput" +
                "// $B53C(gp) = 4.0" +
                "\npatch=1,EE,0050345C,word,3c034080 // lui v1, $4080  $v1 = 4.0" +
                "\npatch=1,EE,00503460,word,af83b53c // sw v1, $B53C(gp)   $B53C(gp) = v1" +
                "\npatch=1,EE,00503464,word,0807816d // j $1E05B4  return" +
                "\npatch=1,EE,00503468,word,27bdfed0 //Overwritten instruction" +
                "// Right turn hook" +
                "// $v1, $a0, $f0 and $f20 are free to use" +
                "// $f1 contains the right stick X axis as [-127, 128]" +
                "// -004AC4($gp) aka $B53C(gp) is turn rate" +
                "// Check if out of deadzone" +
                "\npatch=1,EE,005033F0,word,45010005 // bc1t $5" +
                "// $f0 = $f1 / 64.0" +
                "\npatch=1,EE,005033F4,word,3c0341c0 // lui v1, $41C0  $v1 = 24.0" +
                "\npatch=1,EE,005033F8,word,44830000 // mtc1 v1, $f0   $f0 = v1" +
                "\npatch=1,EE,005033FC,word,46000803 // div.s $f0, $f1, $f0$f0 = $f1 / $f0" +
                "// $B53C(gp) *= f0" +
                "\npatch=1,EE,00503400,word,08078234 // j $1E08D0  return" +
                "\npatch=1,EE,00503404,word,e780b53c // swc1 $f0, $B53C(gp)$B53C(gp) = $f0" +
                "// outside of deadzone" +
                "\npatch=1,EE,00503408,word,08078274 // j $1E09D0  return" +
                "\npatch=1,EE,0050340C,word,00000000 // nop"
            },
            new GamePatch() { Name = "Broken 60FPS", ShortName = "broken_60fps", Author = "Unknown",
                Description = "This cheat forces the game to render 60 frames per second, however it breaks a lot of things that rely on accurate framecount for timing.",
                Text = "patch=1,EE,2019D330,extended,10000006 ////fps" +
                "\npatch=1,EE,207CADD4,extended,3C888889 ////speed" +
                "\npatch=1,EE,204C6A30,extended,3C023F00 ////traverse"
            },
            new GamePatch() { Name = "Enable Code", ShortName = "enable_code", Author = "Unknown",
                Description = "Enables cheats.",
                Text = "patch=1,EE,F0511884,extended,00511887" +
                "\npatch=1,EE,2017F6B8,word,24420001",
                AlwaysOn = true,
                Enabled = true
            }
        };

        public static List<GamePatch> PS2P4USAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "HostFS", ShortName = "hostFS", Author = "TGE",
                Description = "Loads external files from folders named after the game's archives when running a game from an ELF in PCSX2. Make sure hostFS=enabled in PCSX2_vm.ini.",
                Text = Patches.P4HostFS,
                AlwaysOn = true,
                Enabled = true,
                TargetPlatform = "emulator"
            },
            new GamePatch() { Name = "Debug Log", ShortName = "debug_log", Author = "TGE",
                Description = "Prints string output from the game's original debug functions into the PCSX2 log. Also prints the filename and path of each file the game accesses in real time, helpful for finding and narrowing down the location of assets like models, fields etc.",
                Text = "patch=1,EE,00421DE8,word,00000000 // always branch even if not debug",
                Enabled = true
            },
            new GamePatch() { Name = "Disable Save File Integrity Check", ShortName = "disable_save_file_integrity_check", Author = "Fendroidus, TGE",
                Description = "This patch allows you to load modified save files where the checksum doesn't match the contents. Useful for changing the player's name or stats.",
                Text = "patch=1,EE,002A402C,word,00000000 // don't branch to crc check" +
                "\npatch=1,EE,002A3FE8,word,10000004 // always branch to 00002A3FFC regardless if v0 is zero"
            },
            new GamePatch() { Name = "Enable Debug Options in TV World", ShortName = "enable_debug_options_in_tv_world", Author = "Unknown",
                Description = "This cheat grants you an extra menu option in dungeons that can be used to skip to the next floor or return to the entrance.",
                Text = "patch=1,EE,D08C0142,extended,00007FFF" +
                "\npatch=1,EE,0079B34C,extended,000000FF" +
                "\npatch=1,EE,D08C0142,extended,0000BFFF" +
                "\npatch=1,EE,0079B34C,extended,000000FF"
            },
            new GamePatch() { Name = "Gain EXP x256 (Protag)", ShortName = "gain_exp_x256_(protag)", Author = "Unknown",
                Description = "This cheat multiplies the EXP you earn from battle by 256. Use this to quickly reach level 99.",
                Text = "patch=1,EE,200A0000,word,00118A00" +
                "\npatch=1,EE,200A0004,word,08087895" +
                "\npatch=1,EE,200A0008,word,02222021" +
                "\npatch=1,EE,2021E250,word,08028000" +
                "\npatch=1,EE,2021E254,word,00000000" +
                "\npatch=1,EE,2021E258,word,0C041678" +
                "\npatch=1,EE,2021E25C,word,00000000" +
                "\npatch=1,EE,2021E260,word,304200FF" +
                "\npatch=1,EE,2021E264,word,12020003"
            },
            new GamePatch() { Name = "Gain EXP x256 (Party)", ShortName = "gain_exp_x256_(party)", Author = "Unknown",
                Description = "This cheat multiplies the EXP your party members earn from battle by 256. Use this to quickly reach level 99.",
                Text = "patch=1,EE,200A0010,word,00108A00" +
                "\npatch=1,EE,200A0014,word,00701821" +
                "\npatch=1,EE,200A0018,word,0804326F" +
                "\npatch=1,EE,200A001C,word,AE230008" +
                "\npatch=1,EE,2010C9B8,word,08028004" +
                "\npatch=1,EE,2010C9BC,word,00000000"
            },
            new GamePatch() { Name = "Max Money", ShortName = "max_money", Author = "Unknown",
                Description = "This cheat maxes out your Yen.",
                Text = "patch=1,EE,2079B68C,word,05F5E0FF"
            },
            new GamePatch() { Name = "Max Social Stats", ShortName = "max_social_stats", Author = "Unknown",
                Description = "These cheats give you the maximum level of points for each social stat.",
                Text = "// Max Courage" +
                "\npatch=1,EE,007973F4,word,000000FF" +
                "// Max Knowledge" +
                "\npatch=1,EE,007973F6,word,000000FF" +
                "// Max Diligence" +
                "\npatch=1,EE,007973F8,word,000000FF" +
                "// Max Understanding" +
                "\npatch=1,EE,007973FA,word,000000FF" +
                "// Max Expression" +
                "\npatch=1,EE,007973FC,word,000000FF"
            },
            new GamePatch() { Name = "Max Persona Stats (MC)", ShortName = "max_persona_stats_(mc)", Author = "Unknown",
                Description = "This cheat gives the protagonist's currently equipped Persona maximum stats.",
                Text = "patch=1,EE,40836BC8,extended,000C000D" +
                "\npatch=1,EE,63636363,extended,00000000" +
                "\npatch=1,EE,40836BCC,extended,000C000D" +
                "\npatch=1,EE,00000063,extended,00000000"
            },
            new GamePatch() { Name = "Party Member Mod", ShortName = "party_member_mod", Author = "Unknown",
                Description = "These cheats allow you to change the value of the other characters currently in your party. This has the unintended side effect of them following you even outside of the dungeon.",
                Text = "// 00 None 01 Protagonist (Crashes the game) 02 Yosuke 03 Chie 04 Yukiko 05 Rise (Crashes the game) 06 Kanji 07 Naoto 08 Teddie 09 Koromaru" +
                "// Party Member 2 Mod" +
                "\npatch=1,EE,1079B690,extended,000000??" +
                "// Party Member 3 Mod" +
                "\npatch=1,EE,1079B692,extended,000000??" +
                "// Party Member 4 Mod" +
                "\npatch=1,EE,1079B694,extended,000000??"
            },
            new GamePatch() { Name = "Disable Motion Blur", ShortName = "disable_motion_blur", Author = "Unknown",
                Description = "This cheat attempts to remove the motion blur in the game. However, it has the side effect of making the game appear darker.",
                Text = "patch=1,EE,00485AFC,word,00000000"
            },
            new GamePatch() { Name = "Broken 60FPS", ShortName = "broken_60fps", Author = "Unknown",
                Description = "This cheat forces the game to render 60 frames per second, however it breaks a lot of things that rely on accurate framecount for timing.",
                Text = "patch=1,EE,201026C0,extended,10000006 //fps" +
                "\npatch=1,EE,20761130,extended,3C888889 //speed" +
                "\npatch=1,EE,203E40F0,extended,3C023F00 //traverse"
            },
            new GamePatch() { Name = "Day Repeater ON", ShortName = "day_repeater_on", Author = "Unknown",
                Description = "Will keep repeating the same date until you deactivate this code and activate Day Repeater OFF.",
                Text = "patch=1,EE,20106304,word,00000000"
            },
            new GamePatch() { Name = "Day Repeater OFF", ShortName = "day_repeater_off", Author = "Unknown",
                Description = "Stops the days from repeating after using Day Repeater ON (which must be disabled first).",
                Text = "patch=1,EE,20106304,word,A4647B84"
            },
            new GamePatch() { Name = "Time of Day Repeater ON", ShortName = "time_of_day_repeater_on", Author = "Unknown",
                Description = "Will keep repeating a time of the day without finish it, use for requests and these. Deactivate with Time of Day Repeater OFF code.",
                Text = "patch=1,EE,201062F4,word,00000000"
            },
            new GamePatch() { Name = "Time of Day Repeater OFF", ShortName = "time_of_day_repeater_off", Author = "Unknown",
                Description = "Stops the time of day from repeating after using Time of Day Repeater ON (which must be disabled first).",
                Text = "patch=1,EE,201062F4,word,A0647B7C"
            },
            new GamePatch() { Name = "All Weapons, Armors, Accessories (MC, Party)", ShortName = "all_weapons,_armors,_accessories_(mc,_party)", Author = "Unknown",
                Description = "The main character and all party members will have all weapons, armors and accessories.",
                Text = "patch=1,EE,4079757C,extended,00080001" +
                "\npatch=1,EE,09090909,extended,00000000" +
                "\npatch=1,EE,1079759C,extended,00000909" +
                "\npatch=1,EE,0079759E,extended,00000009//All Weapons - Yousuke" +
                "\npatch=1,EE,007975A1,extended,00000009" +
                "\npatch=1,EE,107975A2,extended,00000909" +
                "\npatch=1,EE,407975A4,extended,00070001" +
                "\npatch=1,EE,09090909,extended,00000000" +
                "\npatch=1,EE,007975C0,extended,00000009//All Weapons - Chie" +
                "\npatch=1,EE,107975EA,extended,00000909" +
                "\npatch=1,EE,407975EC,extended,00070001" +
                "\npatch=1,EE,09090909,extended,00000000" +
                "\npatch=1,EE,00797608,extended,00000009//All Weapons - Yukiko" +
                "\npatch=1,EE,007975C7,extended,00000009" +
                "\npatch=1,EE,407975C8,extended,00070001" +
                "\npatch=1,EE,09090909,extended,00000000//All Weapons - Kanji" +
                "\npatch=1,EE,00797611,extended,00000009" +
                "\npatch=1,EE,10797612,extended,00000909" +
                "\npatch=1,EE,40797614,extended,00050001" +
                "\npatch=1,EE,09090909,extended,00000000" +
                "\npatch=1,EE,10797628,extended,00000909//All Weapons - Naoto" +
                "\npatch=1,EE,10797632,extended,00000909" +
                "\npatch=1,EE,20797634,extended,09090909" +
                "\npatch=1,EE,20797638,extended,09090909" +
                "\npatch=1,EE,2079763C,extended,09090909//All Weapons - Teddie" +
                "\npatch=1,EE,40797654,extended,00050001" +
                "\npatch=1,EE,09090909,extended,00000000" +
                "\npatch=1,EE,00797668,extended,00000009" +
                "\npatch=1,EE,00797678,extended,00000009//Have All Armor" +
                "\npatch=1,EE,0079767B,extended,00000008" +
                "\npatch=1,EE,2079767C,extended,08080808" +
                "\npatch=1,EE,10797680,extended,00000808" +
                "\npatch=1,EE,00797682,extended,00000008" +
                "\npatch=1,EE,20797684,extended,08080808" +
                "\npatch=1,EE,10797688,extended,00000808" +
                "\npatch=1,EE,00797699,extended,00000008" +
                "\npatch=1,EE,0079769B,extended,00000008" +
                "\npatch=1,EE,0079769F,extended,00000008" +
                "\npatch=1,EE,007976A1,extended,00000008" +
                "\npatch=1,EE,007976AD,extended,00000008" +
                "\npatch=1,EE,007976AF,extended,00000008" +
                "\npatch=1,EE,007976B0,extended,00000008" +
                "\npatch=1,EE,007976B5,extended,00000008" +
                "\npatch=1,EE,007976B6,extended,00000008" +
                "\npatch=1,EE,107976C2,extended,00000808" +
                "\npatch=1,EE,107976C4,extended,00000808" +
                "\npatch=1,EE,207976C8,extended,08080808" +
                "\npatch=1,EE,007976CC,extended,00000008" +
                "\npatch=1,EE,007976D5,extended,00000008" +
                "\npatch=1,EE,007976D6,extended,00000008" +
                "\npatch=1,EE,207976D8,extended,08080808" +
                "\npatch=1,EE,207976DC,extended,08080808" +
                "\npatch=1,EE,007976E0,extended,00000008" +
                "\npatch=1,EE,007976E9,extended,00000008" +
                "\npatch=1,EE,107976EA,extended,00000808" +
                "\npatch=1,EE,007976EC,extended,00000008" +
                "\npatch=1,EE,107976EE,extended,00000808" +
                "\npatch=1,EE,207976F0,extended,08080808" +
                "\npatch=1,EE,007976F4,extended,00000008" +
                "\npatch=1,EE,007976FD,extended,00000008" +
                "\npatch=1,EE,107976FE,extended,00000808" +
                "\npatch=1,EE,10797700,extended,00000808" +
                "\npatch=1,EE,00797702,extended,00000008" +
                "\npatch=1,EE,20797704,extended,08080808" +
                "\npatch=1,EE,00797708,extended,00000008" +
                "\npatch=1,EE,00797711,extended,00000008" +
                "\npatch=1,EE,10797712,extended,00000808" +
                "\npatch=1,EE,10797714,extended,00000808" +
                "\npatch=1,EE,00797716,extended,00000008" +
                "\npatch=1,EE,20797718,extended,08080808" +
                "\npatch=1,EE,0079771C,extended,00000008//All Accessories" +
                "\npatch=1,EE,0079777B,extended,00000011" +
                "\npatch=1,EE,2079777C,extended,11111111" +
                "\npatch=1,EE,10797780,extended,00001111" +
                "\npatch=1,EE,40797784,extended,00150001" +
                "\npatch=1,EE,11111111,extended,00000000" +
                "\npatch=1,EE,107977D8,extended,00001111" +
                "\npatch=1,EE,007977DA,extended,00000011" +
                "\npatch=1,EE,007977E1,extended,00000011" +
                "\npatch=1,EE,107977E2,extended,00001111" +
                "\npatch=1,EE,407977E4,extended,00100001" +
                "\npatch=1,EE,11111111,extended,00000000" +
                "\npatch=1,EE,10797824,extended,00001111//Have All Special Accessories" +
                "\npatch=1,EE,2079786C,extended,11111111" +
                "\npatch=1,EE,20797870,extended,11111111" +
                "\npatch=1,EE,20797874,extended,11111111" +
                "\npatch=1,EE,00797878,extended,00000011"
            },
            new GamePatch() { Name = "Infinite HP", ShortName = "infinite_hp", Author = "Unknown",
                Description = "Gives the main character (and party?) infinite HP",
                Text = "patch=1,EE,207973CC,word,000003E7" +
                "\npatch=1,EE,007973CC,word,000003E7"
            },
            new GamePatch() { Name = "Infinite SP", ShortName = "infinite_sp", Author = "Unknown",
                Description = "Gives the main character (and party?) infinite SP.",
                Text = "patch=1,EE,007973CE,word,000003E7" 
            },
            new GamePatch() { Name = "Enemies Fully Analyzed", ShortName = "enemies_fully_analyzed", Author = "Unknown",
                Description = "Enemies are already fully analyzed in battle while this code is enabled.",
                Text = "patch=1,EE,201F09EC,extended,24020001"
            },
            new GamePatch() { Name = "All Items (x99)", ShortName = "all_items_(x99)", Author = "Unknown",
                Description = "Have 99 of each item, including key items and some unused dummy items",
                Text = "patch=1,EE,1013C8F4,extended,00000000" +
                "\npatch=1,EE,00106640,extended,00000001" +
                "\npatch=1,EE,0079787B,extended,00000062" +
                "\npatch=1,EE,4079787C,extended,00190001" +
                "\npatch=1,EE,62626262,extended,00000000" +
                "\npatch=1,EE,107978E0,extended,00006262" +
                "\npatch=1,EE,40797A7C,extended,003F0001" +
                "\npatch=1,EE,62626262,extended,00000000// All Quest Items" +
                "\npatch=1,EE,4079794C,extended,000A0001" +
                "\npatch=1,EE,62626262,extended,00000000"
            },
            new GamePatch() { Name = "All Personas in Compendium", ShortName = "all_personas_in_compendium", Author = "Unknown",
                Description = "Unlocks all the Personas in the compendium.",
                Text = "patch=1,EE,407981FC,extended,00BF000C" +
                "\npatch=1,EE,00010001,extended,00010000"
            },
            new GamePatch() { Name = "Compendium Personas Max Stats/Level", ShortName = "compendium_personas_max_stats/level", Author = "Unknown",
                Description = "All Personas in the compendium will have maxed out stats/level.",
                Text = "patch=1,EE,40798200,extended,00BF000C" +
                "\npatch=1,EE,00000063,extended,00000000" +
                "\npatch=1,EE,40798218,extended,00BF000C" +
                "\npatch=1,EE,63636363,extended,00000000" +
                "\npatch=1,EE,4079821C,extended,00BF000C" +
                "\npatch=1,EE,63636363,extended,00000000" +
                "\npatch=1,EE,40798220,extended,00BF000C" +
                "\npatch=1,EE,00006363,extended,00000000"
            },
            new GamePatch() { Name = "No Level Limit When Fusing Persona", ShortName = "no_level_limit_when_fusing_persona", Author = "Unknown",
                Description = "This cheat removes the player level limitation when fusing Personas.",
                Text = "patch=1,EE,202ef884,word,24010000" +
                "\npatch=1,EE,202f055c,word,24010000" +
                "\npatch=1,EE,202f5350,word,24010000" +
                "\npatch=1,EE,202f6314,word,24010000" +
                "\npatch=1,EE,202f8d3c,word,24010000" +
                "\npatch=1,EE,202f9798,word,24010000"
            },
            new GamePatch() { Name = "Enable Code", ShortName = "enable_code", Author = "Unknown",
                Description = "Enables cheats.",
                Text = "patch=1,EE,F0511884,extended,00511887" +
                "\npatch=1,EE,2017F6B8,word,24420001",
                AlwaysOn = true,
                Enabled = true
            },
        };

        public static List<GamePatch> PS2SMT3USAPatches = new List<GamePatch>()
        {
            new GamePatch() { Name = "HostFS", ShortName = "hostfs", Author = "TGE",
                Description = "Loads external files from folders named after the game's archive (dds3data) when running a game from an ELF in PCSX2. Make sure hostFS=enabled in PCSX2_vm.ini. Also extract the MOVIE folder from the ISO into the dds3data folder.",
                Text = "// skip mount of dds3.ddt/img" +
                "patch=1,EE,00101CDC,word,00000000" +
                "// set host base directory to './dds3data'" +
                "patch=1,EE,0052DEF8,word,64642F2E" +
                "patch=1,EE,0052DEFC,word,61643373" +
                "patch=1,EE,0052DF00,word,00006174" +
                "// set primary device id to 1 (host)" +
                "patch=1,EE,00101D64,word,24040001" +
                "// patch special treatment of movie files" +
                "patch=1,EE,002BF270,word,24040007" +
                "//patch device ids" +
                "patch=1,EE,002BF304,word,9385D7EE" +
                "patch=1,EE,002BF30C,word,9382D7EE",
                AlwaysOn = true,
                Enabled = true
            },
            new GamePatch() { Name = "480p Resolution", ShortName = "480p_resolution", Author = "TGE",
                Description = "Upscale graphics to 480p natively.",
                Text = "// NOP out old interlaced field switch" +
                "patch=1,EE,002AA1B4,word,00000000 // Another field switch here that needs to be NOP'd to prevent// post processing effects from getting misaligned when entering// and leaving menus." +
                "patch=1,EE,002ADBE0,word,00000000 // Patch sceGsResetGraph arguments to set 480p" +
                "patch=1,EE,002C81D4,word,24110000 // addiu $s1, 0, 0000" +
                "patch=1,EE,002C81D8,word,24120050 // addiu $s2, 0, 0050" +
                "patch=1,EE,002C81DC,word,24020001 // addiu $s3, 0, 000/",
                Enabled = true
            },
            new GamePatch() { Name = "Debug Log", ShortName = "debug_log", Author = "TGE",
                Description = "Prints string output from the game's original debug functions into the PCSX2 log. Also prints the filename and path of each file the game accesses in real time, helpful for finding and narrowing down the location of assets like models, fields etc.",
                Text = "patch=1,EE,002E67C8,word,080E84F2" +
                "patch=1,EE,003A13C8,word,0C0C00FC" +
                "patch=1,EE,003A13CC,word,2384C830" +
                "patch=1,EE,003A13D0,word,0C0C00FC" +
                "patch=1,EE,003A13D4,word,02802021" +
                "patch=1,EE,003A13D8,word,0C0C00FC" +
                "patch=1,EE,003A13DC,word,2384C830" +
                "patch=1,EE,003A13E0,word,0C0C0763" +
                "patch=1,EE,003A13E4,word,02802021" +
                "patch=1,EE,003A13E8,word,080B99F4" +
                "patch=1,EE,003076EC,word,00000000",
                Enabled = true
            },
            new GamePatch() { Name = "Shadow Alpha Hack", ShortName = "shadow_alpha_hack", Author = "Krisan Thyme",
                Description = "Optional shadow alpha hack",
                Text = "patch=1,EE,202FBD80,extended,00000000" +
                "patch=1,EE,202FBD84,extended,00000000" +
                "patch=1,EE,202FBD88,extended,00000000" +
                "patch=1,EE,202FBD8C,extended,00000000" +
                "patch=1,EE,202FBD90,extended,00000000" +
                "patch=1,EE,202FBD94,extended,00000000" +
                "patch=1,EE,202FBD98,extended,00000000" +
                "patch=1,EE,202FBD9C,extended,00000000" +
                "patch=1,EE,202FBDA0,extended,00000000" +
                "patch=1,EE,202FBDA4,extended,00000000" +
                "patch=1,EE,202FBDA8,extended,00000000" +
                "patch=1,EE,202FBDAC,extended,00000000" +
                "patch=1,EE,202FBDB0,extended,00000000" +
                "patch=1,EE,202FBDB4,extended,00000000" +
                "patch=1,EE,202FBDB8,extended,00000000" +
                "patch=1,EE,202FBDBC,extended,00000000" +
                "patch=1,EE,202FBDC0,extended,00000000" +
                "patch=1,EE,202FBDC4,extended,00000000" +
                "patch=1,EE,202FBDC8,extended,00000000" +
                "patch=1,EE,202FBDCC,extended,00000000" +
                "patch=1,EE,202FBDD0,extended,00000000" +
                "patch=1,EE,202FBDD4,extended,00000000" +
                "patch=1,EE,202FBDD8,extended,00000000" +
                "patch=1,EE,202FBDDC,extended,00000000" +
                "patch=1,EE,202FBDE0,extended,00000000" +
                "patch=1,EE,202FBDE4,extended,00000000" +
                "patch=1,EE,202FBDE8,extended,00000000" +
                "patch=1,EE,202FBDEC,extended,00000000" +
                "patch=1,EE,202FBDF0,extended,00000000" +
                "patch=1,EE,202FBDF4,extended,00000000" +
                "patch=1,EE,202FBDF8,extended,00000000" +
                "patch=1,EE,202FBDFC,extended,00000000"
            },
            new GamePatch() { Name = "Remove Shadow", ShortName = "remove_shadow", Author = "Krisan Thyme",
                Description = "Remove shadows",
                Text = "patch=1,EE,202FBD80,extended,00000000" +
                "patch=1,EE,202FBD84,extended,00000000" +
                "patch=1,EE,202FBD88,extended,00000000" +
                "patch=1,EE,202FBD8C,extended,00000000" +
                "patch=1,EE,202FBD90,extended,00000000" +
                "patch=1,EE,202FBD94,extended,00000000" +
                "patch=1,EE,202FBD98,extended,00000000" +
                "patch=1,EE,202FBD9C,extended,00000000" +
                "patch=1,EE,202FBDA0,extended,00000000" +
                "patch=1,EE,202FBDA4,extended,00000000" +
                "patch=1,EE,202FBDA8,extended,00000000" +
                "patch=1,EE,202FBDAC,extended,00000000" +
                "patch=1,EE,202FBDB0,extended,00000000" +
                "patch=1,EE,202FBDB4,extended,00000000" +
                "patch=1,EE,202FBDB8,extended,00000000" +
                "patch=1,EE,202FBDBC,extended,00000000" +
                "patch=1,EE,202FBDC0,extended,00000000" +
                "patch=1,EE,202FBDC4,extended,00000000" +
                "patch=1,EE,202FBDC8,extended,00000000" +
                "patch=1,EE,202FBDCC,extended,00000000" +
                "patch=1,EE,202FBDD0,extended,00000000" +
                "patch=1,EE,202FBDD4,extended,00000000" +
                "patch=1,EE,202FBDD8,extended,00000000" +
                "patch=1,EE,202FBDDC,extended,00000000" +
                "patch=1,EE,202FBDE0,extended,00000000" +
                "patch=1,EE,202FBDE4,extended,00000000" +
                "patch=1,EE,202FBDE8,extended,00000000" +
                "patch=1,EE,202FBDEC,extended,00000000" +
                "patch=1,EE,202FBDF0,extended,00000000" +
                "patch=1,EE,202FBDF4,extended,00000000" +
                "patch=1,EE,202FBDF8,extended,00000000" +
                "patch=1,EE,202FBDFC,extended,00000000"
            },
            new GamePatch() { Name = "No Location Name/Compass", ShortName = "no_location_name/compass", Author = "FuxorLuck",
                Description = "No location Name and no compass on Screen",
                Text = "patch=1,EE,202FC010,word,00000000"
            },
            new GamePatch() { Name = "Right Stick Up/Down Invert Fix", ShortName = "right_stick_up/down_invert_fix", Author = "Unknown",
                Description = "Right Joystick Up Down Invert Fix (Unkown)",
                Text = "patch=1,EE,002ca65c,word,0803f414" +
                "patch=1,EE,000fd050,word,00c0c821" +
                "patch=1,EE,000fd054,word,080b2999" +
                "patch=1,EE,000fd058,word,24030070" +
                "patch=1,EE,002ca6cc,word,0803f417" +
                "patch=1,EE,000fd05c,word,93210005" +
                "patch=1,EE,000fd060,word,382400ff" +
                "patch=1,EE,000fd064,word,03e00008" +
                "patch=1,EE,000fd068,word,a3240005"
            },
            new GamePatch() { Name = "No Interlacing", ShortName = "no_interlacing", Author = "Altimor",
                Description = "Removes interlacing.",
                Text = "patch=1,EE,002AA1B4,word,00000000" +
                "patch=1,EE,002ADBE0,word,00000000"
            },
            new GamePatch() { Name = "Swap DemiFiend with Hooded Jacket Human Protag", ShortName = "swap_demifiend_with_hooded_jacket_human_protag", Author = "FuxorLuck",
                Description = "Please only use one of these at a time.",
                Text = "patch=1,EE,005316c4,word,42502e63" +
                "patch=1,EE,00531704,word,42502e61",
                Conflicts = new List<string> () { "swap_demifiend_with_leather_jacket_human_protag" }
            },
            new GamePatch() { Name = "Swap DemiFiend with Leather Jacket Human Protag", ShortName = "swap_demifiend_with_leather_jacket_human_protag", Author = "FuxorLuck",
                Description = "Please only use one of these at a time.",
                Text = "patch=1,EE,005316c4,word,42502e62" +
                "patch=1,EE,005316e4,word,42502e61",
                Conflicts = new List<string> () { "swap_demifiend_with_hooded_jacket_human_protag" }
            },

        };
    }
}