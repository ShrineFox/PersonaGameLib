using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGameLib
{
    public partial class Patches
    {
        public static string P5_Beta_PatchYml { get; } = "PPU-940ac9d6643a40a051c179ba4885e55123cdba13:\r\n" +
        "  \"Fix Battles\":\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ 01.00 ]\r\n" +
        "    Author: \"jason098, Edness\"\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ be32, 0x091ac2c, 0x3CA00120 ]\r\n" +
        "      - [ be32, 0x091ac3c, 0x30A56E80 ]\r\n" +
        "\r\n" +
        "PPU-ad990ca2932c0b2a93776a9374c5e28dfaf5051d:\r\n" +
        "  Skip to title:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TESTJUN14: [ All ]\r\n" +
        "    Author: TGE\r\n" +
        "    Notes: Hack to prevent loading init files crashing the game\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ be32, 0x0824AC0, 0x4e800020 ]\r\n" +
        "      - [ be32, 0x01777CC, 0x4e800020 ]\r\n" +
        "      - [ be32, 0x00109AC, 0x38600001 ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Mod Cpk Support:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: DeathChaos\r\n" +
        "    Notes: File replacement through mod.cpk.\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      # redirect uses of exact copy of GetEquippedPersona to the first one to free some code space\r\n" +
        "      - [ be32, 0x002523b8, 0x48074551 ] \r\n" +
        "      - [ be32, 0x0025251c, 0x480743ed ] \r\n" +
        "      # make CPK BIND ERROR -> %s%s/mod.cpk\r\n" +
        "      - [ be32, 0x00f41e04, 0x25732573 ]\r\n" +
        "      - [ be32, 0x00f41e08, 0x2F6D6F64 ]\r\n" +
        "      - [ be32, 0x00f41e0C, 0x2E63706B ]\r\n" +
        "      - [ be32, 0x00f41e10, 0x00000000 ]\r\n" +
        "      # branch to now unused copy of GetEquippedPersona\r\n" +
        "      - [ be32, 0x00160148, 0x48166818 ]\r\n" +
        "      # make mod.cpk file path\r\n" +
        "      - [ be32, 0x002c6960, 0x3C6000F4 ] # lis    r3, 0xf4\r\n" +
        "      - [ be32, 0x002c6964, 0x33e10070 ] # addic  r31, r1, 0x70\r\n" +
        "      - [ be32, 0x002c6968, 0x33c31e04 ] # addic  r30, r3, 0x1e04\r\n" +
        "      - [ be32, 0x002c696c, 0x48850d2d ] # bl     00b17698\r\n" +
        "      - [ be32, 0x002c6970, 0x60000000 ] # nop\r\n" +
        "      - [ be32, 0x002c6974, 0x607d0000 ] # ori    r29, r3, 0x0\r\n" +
        "      - [ be32, 0x002c6978, 0x48850d2d ] # bl     00b176a4\r\n" +
        "      - [ be32, 0x002c697C, 0x60000000 ] # nop\r\n" +
        "      - [ be32, 0x002c6980, 0x60660000 ] # ori    r6, r3, 0x0\r\n" +
        "      - [ be32, 0x002c6984, 0x63E30000 ] # ori    r3, r31, 0x0\r\n" +
        "      - [ be32, 0x002c6988, 0x63C40000 ] # ori    r4, r30, 0x0\r\n" +
        "      - [ be32, 0x002c698C, 0x63A50000 ] # ori    r5, r29, 0x0\r\n" +
        "      - [ be32, 0x002c6990, 0x48bc3345 ] # bl     sprintf\r\n" +
        "      - [ be32, 0x002c6994, 0x60000000 ] # nop\r\n" +
        "      - [ be32, 0x002c6998, 0x63e30000 ] # ori    r3, r31, 0x0\r\n" +
        "      - [ be32, 0x002c699C, 0x4be99619 ] # bl     bind_cpk\r\n" +
        "      - [ be32, 0x002c69a0, 0x60000000 ] # nop\r\n" +
        "      # original instruction we replaced with trampoline\r\n" +
        "      - [ be32, 0x002c69a4, 0x3c6000f4 ] # lis    r3, 0xF4\r\n" +
        "      # go back to original function\r\n" +
        "      - [ be32, 0x002c69a8, 0x4be997a4 ] # b      0x0016014c\r\n" +
        "\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Single Combat GAP:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: DeathChaos\r\n" +
        "    Notes: Makes characters load singular GAP file in combat\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      # Make Emergency Shift use Single GAP\r\n" +
        "      - [ be32, 0x00781f68, 0x428000cc ] # b   LAB_006262fc\r\n" +
        "      # isValidCombatModel\r\n" +
        "      - [ be32, 0x008893bc, 0x38600000 ] # li  r3, 0x0\r\n" +
        "      - [ be32, 0x008893c0, 0x4e800020 ] # blr\r\n" +
        "      \r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Disable Asserts:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: SecreC.\r\n" +
        "    Notes: Stops Asserts from freezing the game\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ be32, 0xa7aa08, 0x4e800020 ]\r\n" +
        "\r\n" +
        "# Translations below\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Right Click Menu Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Scarltz, Lyn, KingJackSkellington\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ utf8, 0x0105E678, \"Filer View\" ]\r\n" +
        "      - [ be16, 0x0105E682, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E688, \"Debug Console\" ]\r\n" +
        "      - [ be16, 0x0105E695, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E810, \"Model View\" ]\r\n" +
        "      - [ be16, 0x0105E81A, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E828, \"Texture View\" ]\r\n" +
        "      - [ be16, 0x0105E834, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E848, \"Asset View\" ]\r\n" +
        "      - [ be16, 0x0105E852, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E870, \"Performance Meter\" ]\r\n" +
        "      - [ be16, 0x0105E881, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E898, \"Memory Info\" ]\r\n" +
        "      - [ be16, 0x0105E8A3, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E8A8, \"Graphic Info\" ]\r\n" +
        "      - [ utf8, 0x0105E8B8, \"Camera Info\" ]\r\n" +
        "      - [ be16, 0x0105E8C3, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E8C8, \"Build Info\" ]\r\n" +
        "      - [ be16, 0x0105E8D2, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E8D8, \"Animated Texture Editor\" ]\r\n" +
        "      - [ be16, 0x0105E8EF, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E900, \"Scene/ENV Editor\" ]\r\n" +
        "      - [ be16, 0x0105E910, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E920, \"Effect Editor\" ]\r\n" +
        "      - [ be16, 0x0105E92D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E940, \"FPS Stabilizer \" ]\r\n" +
        "      - [ be16, 0x0105E94E, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E950, \"Task Info Console Output\" ]\r\n" +
        "      - [ be16, 0x0105E968, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E978, \"About GFD Engine\" ]\r\n" +
        "      - [ be16, 0x0105E988, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E990, \"Serial Num. Capture Detail\" ]\r\n" +
        "      - [ be16, 0x0105E9AA, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105E9B0, \"Serial Num. Capture Start\" ]\r\n" +
        "      - [ be16, 0x0105E9C9, 0x00 ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  EPT Editor Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Century\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ utf8, 0x0105F470, \"EPT - Animated Texture Editor \" ]\r\n" +
        "      - [ be64, 0x0105f48e, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f496, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f49e, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105F528, \"New\" ]\r\n" +
        "      - [ be32, 0x0105f52b, 0x00000000 ]\r\n" +
        "      - [ utf8, 0x0105F530, \"Save\" ]\r\n" +
        "      - [ be16, 0x0105f534, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0105F538, \" Save As... \" ]\r\n" +
        "      - [ utf8, 0x0105F548, \"Open\" ]\r\n" +
        "      - [ be16, 0x0105f54c, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0105F7F8, \"Confirm File Overwrite\" ]\r\n" +
        "      - [ utf8, 0x0105F648, \"Confirm Clear\" ]\r\n" +
        "      - [ utf8, 0x0105F810, \"This will overwrite and save %s. Is that okay?\" ]\r\n" +
        "      - [ be64, 0x0105f83e, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105F848, \"The EPT file currently being edited will be deleted. Is that okay?\" ]\r\n" +
        "      - [ be64, 0x0105f88a, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105EE70, \"[Frame Width]\" ]\r\n" +
        "      - [ utf8, 0x0105EE80, \"[Frame Height]\" ]\r\n" +
        "      - [ utf8, 0x0105EEA0, \"Loop Playback  \" ]\r\n" +
        "      - [ utf8, 0x0105EEB0, \"Intermittent Play\" ]\r\n" +
        "      - [ utf8, 0x0105EEC8, \"Load Texture Asset\" ]\r\n" +
        "      - [ utf8, 0x0105EEE0, \"Preview        \" ]\r\n" +
        "      - [ utf8, 0x0105EEF0, \"Actual Size\" ]\r\n" +
        "      - [ utf8, 0x0105FA48, \"Cancel\" ]\r\n" +
        "      - [ be64, 0x0105fa4e, 0x0000000000000000 ]\r\n" +
        "      - [ be16, 0x0105fa56, 0x0000 ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  EPD/EPL Editor Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Century, KingJackSkellington\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ utf8, 0x0105F590, \"Finish\" ]\r\n" +
        "      - [ utf8, 0x0105F5E0, \"Animated Texture Editor\" ]\r\n" +
        "      - [ be64, 0x0105f5f7, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f5ff, 0x0000000000000000 ]\r\n" +
        "      - [ be32, 0x0105f607, 0x00000000 ]\r\n" +
        "      - [ utf8, 0x0105F610, \"Texture Displacement Editor\" ]\r\n" +
        "      - [ be64, 0x0105f62b, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f633, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f63b, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105F658, \"Will you delete %s?\" ]\r\n" +
        "      - [ be64, 0x0105f66b, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105F678, \"Will you delete it?\" ]\r\n" +
        "      - [ be16, 0x0105f68b, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0105F690, \"The EPL file currently being edited will be deleted. Is that okay?\" ]\r\n" +
        "      - [ be64, 0x0105f6d2, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x0105F6E0, \"All hidden parts will be deleted. Is that okay?\" ]\r\n" +
        "      - [ be64, 0x0105f70f, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f717, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f71f, 0x0000000000000000 ]\r\n" +
        "      - [ be32, 0x0105f727, 0x00000000 ]\r\n" +
        "      - [ utf8, 0x0105F7D0, \"%s file not found\" ]\r\n" +
        "      - [ be64, 0x0105f7e1, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0105f7e9, 0x0000000000000000 ]\r\n" +
        "      - [ be32, 0x0105f7f1, 0x00000000 ]\r\n" +
        "      - [ be16, 0x0105f7f5, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0105F7F8, \"Confirm File Overwrite\" ]\r\n" +
        "      - [ utf8, 0x0105F598, \"Actual Size\" ]\r\n" +
        "      - [ be16, 0x0105F5A3, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01066DF8, \"Wire Floor\" ]\r\n" +
        "      - [ be16, 0x01066E02, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01066DE8, \"Polygon Floor\" ]\r\n" +
        "      - [ be16, 0x01066DF5, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01066E08, \"Floor Off\" ]\r\n" +
        "      - [ be16, 0x01066E11, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0105F5C8, \"Camera\" ]\r\n" +
        "      - [ be16, 0x0105F5CE, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F5D8, \"Speed\" ]\r\n" +
        "      - [ be16, 0x0105F5DE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D78, \"Default\" ]\r\n" +
        "      - [ be16, 0x01066D7F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D88, \"Front\" ]\r\n" +
        "      - [ be16, 0x01066D8D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D98, \"Back\" ]\r\n" +
        "      - [ be16, 0x01066D9C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066DA8, \"Top\" ]\r\n" +
        "      - [ be16, 0x01066DAB, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066DB8, \"Bottom\" ]\r\n" +
        "      - [ be16, 0x01066DBE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066DC8, \"Left\" ]\r\n" +
        "      - [ be16, 0x01066DCC, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066DD8, \"Right\" ]\r\n" +
        "      - [ be16, 0x01066DDD, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F5A8, \"Display Emitter\" ]\r\n" +
        "      - [ be16, 0x0105F5B7, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F558, \"Properties\" ]\r\n" +
        "      - [ be16, 0x0105F562, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F110, \"Zoom\" ]\r\n" +
        "      - [ be16, 0x0105F114, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060C00, \"Total Frames\" ]\r\n" +
        "      - [ be16, 0x01060C0C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060C20, \"Loop Playback\" ]\r\n" +
        "      - [ be16, 0x01060C2D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060C30, \"Reset Effects When Looping\" ]\r\n" +
        "      - [ be16, 0x01060C4A, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060728, \"Realtime Plybck\" ]\r\n" +
        "      - [ utf8, 0x0105B880, \"Node\" ]\r\n" +
        "      - [ be16, 0x0105B884, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105B890, \"Type\" ]\r\n" +
        "      - [ be16, 0x0105B894, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F460, \"Root\" ]\r\n" +
        "      - [ be16, 0x0105F464, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066CC8, \"Performance Meter\" ]\r\n" +
        "      - [ be16, 0x01066CD9, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066CF0, \"Memory Info\" ]\r\n" +
        "      - [ be16, 0x01066CFB, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D00, \"Drawing Info\" ]\r\n" +
        "      - [ utf8, 0x01066D10, \"Camera Info\" ]\r\n" +
        "      - [ be16, 0x01066D1B, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D20, \"Asset Viewer\" ]\r\n" +
        "      - [ be16, 0x01066D2C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D38, \"Texture Viewer\" ]\r\n" +
        "      - [ be16, 0x01066D46, 0x00 ]\r\n" +
        "      - [ utf8, 0x01066D58, \"Scene/ENV Editor\" ]\r\n" +
        "      - [ be16, 0x01066D68, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105EFD8, \"Reset\" ]\r\n" +
        "      - [ be16, 0x0105EFDD, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105EFF0, \"Loop\" ]\r\n" +
        "      - [ be16, 0x0105EFF4, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DB58, \"Dummy\" ]\r\n" +
        "      - [ be16, 0x0105DB5D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DA98, \"Points\" ]\r\n" +
        "      - [ be16, 0x0105DA9E, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DBE0, \"Model\" ]\r\n" +
        "      - [ be16, 0x0105DBE5, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DCB8, \"Post Effects\" ]\r\n" +
        "      - [ be16, 0x0105DCC4, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064B60, \"Radial Blur\" ]\r\n" +
        "      - [ be16, 0x01064B6B, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064BA8, \"Fill\" ]\r\n" +
        "      - [ be16, 0x01064BAC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC98, \"Camera\" ]\r\n" +
        "      - [ be16, 0x0105DC9E, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC10, \"Object Particles\" ]\r\n" +
        "      - [ be16, 0x0105DC20, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D9E0, \"Explosn\" ]\r\n" +
        "      - [ utf8, 0x0105DB68, \"Particle\" ]\r\n" +
        "      - [ be16, 0x0105DB70, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DCD8, \"Helper\" ]\r\n" +
        "      - [ be16, 0x0105DCDE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064920, \"Effect\" ]\r\n" +
        "      - [ be16, 0x01064926, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064930, \"Model Location\" ]\r\n" +
        "      - [ be16, 0x0106493E, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D9D8, \"Smoke\" ]\r\n" +
        "      - [ utf8, 0x0105D9E8, \"Spiral\" ]\r\n" +
        "      - [ utf8, 0x0105D9F0, \"Sphere\" ]\r\n" +
        "      - [ utf8, 0x0105DB98, \"Circle Polygon\" ]\r\n" +
        "      - [ utf8, 0x0105D130, \"Fill\" ]\r\n" +
        "      - [ be16, 0x0105D134, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC68, \"Directional Particles\" ]\r\n" +
        "      - [ be16, 0x0105DC7D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D118, \"Ring\" ]\r\n" +
        "      - [ be16, 0x0105D11C, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DBA8, \"Thunder Polygon\" ]\r\n" +
        "      - [ utf8, 0x0105CDC0, \"Bar\" ]\r\n" +
        "      - [ utf8, 0x01060A30, \"Add Child Node\" ]\r\n" +
        "      - [ be16, 0x01060A3E, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060AA0, \"Copy Node\" ]\r\n" +
        "      - [ be16, 0x01060AA9, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060A48, \"Paste Node\" ]\r\n" +
        "      - [ be16, 0x01060A52, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060AB8, \"Copy Parameters\" ]\r\n" +
        "      - [ be16, 0x01060AC7, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060A60, \"Paste Parameters\" ]\r\n" +
        "      - [ be16, 0x01060A70, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060AD8, \"Delete\" ]\r\n" +
        "      - [ utf8, 0x01060AE0, \"Rename\" ]\r\n" +
        "      - [ be16, 0x01060AE6, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F568, \"Save Parts\" ]\r\n" +
        "      - [ be16, 0x0105F572, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F578, \"Load Parts\" ]\r\n" +
        "      - [ be16, 0x0105F582, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060A80, \"Delete Hidden Parts\" ]\r\n" +
        "      - [ be16, 0x01060A93, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F773, \"Loaded\" ]\r\n" +
        "      - [ be16, 0x0105F779, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060B48, \"Allow Scaling\" ]\r\n" +
        "      - [ be16, 0x01060B55, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060B68, \"Fix Y Coordinate to Ground Level\" ]\r\n" +
        "      - [ be16, 0x01060B88, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060B90, \"Position Offset\" ]\r\n" +
        "      - [ be16, 0x01060B9F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060BA8, \"Disable Y-Axis Movement\" ]\r\n" +
        "      - [ be16, 0x01060BBF, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060240, \"Billboard\" ]\r\n" +
        "      - [ be16, 0x01060249, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060BD0, \"Fix the Y Axis\" ]\r\n" +
        "      - [ be16, 0x01060BDE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060BE8, \"Disable Rotation Inher.\" ]\r\n" +
        "      - [ utf8, 0x0105F4F8, \"Type:\" ]\r\n" +
        "      - [ be16, 0x0105F4FD, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F43E, \"Parts Template\" ]\r\n" +
        "      - [ be16, 0x0105F44C, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F500, \"Template:\" ]\r\n" +
        "      - [ be16, 0x0105F509, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F518, \"Parts\" ]\r\n" +
        "      - [ be16, 0x0105F51D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D9F8, \"Circle\" ]\r\n" +
        "      - [ utf8, 0x0105DA00, \"Line\" ]\r\n" +
        "      - [ utf8, 0x0105DB80, \"Flash Polygon\" ]\r\n" +
        "      - [ be16, 0x0105DB8D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DBB8, \"Trajectory Polygon\" ]\r\n" +
        "      - [ utf8, 0x0105DBD0, \"Wind Polygon\" ]\r\n" +
        "      - [ be16, 0x0105DBDC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DBF0, \"Soul Polygon\" ]\r\n" +
        "      - [ be16, 0x0105DBFC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC00, \"Billboard Plg\" ]\r\n" +
        "      - [ be16, 0x0105DC0D, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC38, \"Spark Polygon\" ]\r\n" +
        "      - [ be16, 0x0105DC45, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DC50, \"Glow Polygon\" ]\r\n" +
        "      - [ be16, 0x0105DC5C, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105DCA8, \"Light\" ]\r\n" +
        "      - [ be16, 0x0105DCAD, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D438, \"Radiatn\" ]\r\n" +
        "      - [ utf8, 0x0105D440, \"Explosn\" ]\r\n" +
        "      - [ utf8, 0x0105D448, \"Ring\" ]\r\n" +
        "      - [ be16, 0x0105D44C, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D458, \"Scatter\" ]\r\n" +
        "      - [ utf8, 0x0105D460, \"Cylinder\" ]\r\n" +
        "      - [ be16, 0x0105D468, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105D128, \"Trajec.\" ]\r\n" +
        "      - [ utf8, 0x0105D140, \"Hoop\" ]\r\n" +
        "      - [ be16, 0x0105D144, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105CDC8, \"Sphere\" ]\r\n" +
        "      - [ utf8, 0x0105CA40, \"Spiral\" ]\r\n" +
        "      - [ utf8, 0x0105CA48, \"Explosn\" ]\r\n" +
        "      - [ utf8, 0x0105CA50, \"Sphere\" ]\r\n" +
        "      - [ utf8, 0x01065DB8, \"Square\" ]\r\n" +
        "      - [ be16, 0x01065DBE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01065DC8, \"Rectangle\" ]\r\n" +
        "      - [ utf8, 0x0105C700, \"Explosn\" ]\r\n" +
        "      - [ utf8, 0x0105C708, \"Scatter\" ]\r\n" +
        "      - [ utf8, 0x0105C710, \"Cylinder\" ]\r\n" +
        "      - [ be16, 0x0105C718, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105C720, \"Wall\" ]\r\n" +
        "      - [ utf8, 0x01064B70, \"Straight Blur\" ]\r\n" +
        "      - [ be16, 0x01064B7D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064B80, \"Noise Blur\" ]\r\n" +
        "      - [ be16, 0x01064B8A, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064B98, \"Distortion Blur\" ]\r\n" +
        "      - [ utf8, 0x01064BB8, \"Lens Flare\" ]\r\n" +
        "      - [ be16, 0x01064BC2, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064BD0, \"ColorCorrection\" ]\r\n" +
        "      - [ utf8, 0x01064BE0, \"Monotone\" ]\r\n" +
        "      - [ be16, 0x01064BE8, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FEC0, \"Setting\" ]\r\n" +
        "      - [ utf8, 0x0105FEC8, \"Overall Scale\" ]\r\n" +
        "      - [ be16, 0x0105FED5, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FEE0, \"Overall Speed\" ]\r\n" +
        "      - [ utf8, 0x0105FEF0, \"Emitter\" ]\r\n" +
        "      - [ be16, 0x0105FEF7, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF00, \"# Occurrences\" ]\r\n" +
        "      - [ utf8, 0x0105FF10, \"Occ. Period\" ]\r\n" +
        "      - [ be16, 0x0105FF1B, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF20, \"Occ. Range\" ]\r\n" +
        "      - [ be16, 0x0105FF2A, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF30, \"Offset\" ]\r\n" +
        "      - [ be16, 0x0105FF36, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF40, \"Random Placement\" ]\r\n" +
        "      - [ be16, 0x0105FF50, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF58, \"Z Test Enabled\" ]\r\n" +
        "      - [ be16, 0x0105FF66, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FF70, \"Behav.\" ]\r\n" +
        "      - [ utf8, 0x0105FF78, \"Lifespn\" ]\r\n" +
        "      - [ utf8, 0x0105FF80, \"Ini.Vel\" ]\r\n" +
        "      - [ utf8, 0x0105FF88, \"Amplit. Start\" ]\r\n" +
        "      - [ utf8, 0x0105FF98, \"Amplit. End\" ]\r\n" +
        "      - [ be16, 0x0105FFA3, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FFA8, \"Amplit. Speed\" ]\r\n" +
        "      - [ utf8, 0x0105FFB8, \"Gravity\" ]\r\n" +
        "      - [ utf8, 0x0105FFC0, \"Flat Square Material\" ]\r\n" +
        "      - [ be16, 0x0105FFD4, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105FFE0, \"Material Change\" ]\r\n" +
        "      - [ utf8, 0x0105FFF0, \"Reload\" ]\r\n" +
        "      - [ be16, 0x0105FFF6, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060000, \"Blend\" ]\r\n" +
        "      - [ be16, 0x01060005, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060010, \"Alpha\" ]\r\n" +
        "      - [ be16, 0x01060015, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060020, \"Fade\" ]\r\n" +
        "      - [ be16, 0x01060024, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060030, \"Random\" ]\r\n" +
        "      - [ be16, 0x01060036, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060040, \"StartPt\" ]\r\n" +
        "      - [ utf8, 0x01060048, \"Midpoint 1\" ]\r\n" +
        "      - [ utf8, 0x01060058, \"Midpoint 2\" ]\r\n" +
        "      - [ utf8, 0x01060068, \"EndPnt\" ]\r\n" +
        "      - [ utf8, 0x01060070, \"Animation Curve\" ]\r\n" +
        "      - [ be16, 0x0106007F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060090, \"Flat Square Scale\" ]\r\n" +
        "      - [ be16, 0x010600A1, 0x00 ]\r\n" +
        "      - [ utf8, 0x010600B0, \"X Ratio\" ]\r\n" +
        "      - [ be16, 0x010600B7, 0x00 ]\r\n" +
        "      - [ utf8, 0x010600C0, \"Y Ratio\" ]\r\n" +
        "      - [ be16, 0x010600C7, 0x00 ]\r\n" +
        "      - [ utf8, 0x010600D0, \"Flat Square Rotation\" ]\r\n" +
        "      - [ be16, 0x010600E4, 0x00 ]\r\n" +
        "      - [ utf8, 0x010600E8, \"Type\" ]\r\n" +
        "      - [ be16, 0x010600EC, 0x00 ]\r\n" +
        "      - [ utf8, 0x010600F8, \"Starting Angle\" ]\r\n" +
        "      - [ utf8, 0x01060108, \"Acceleration\" ]\r\n" +
        "      - [ utf8, 0x01060118, \"Rndm. #\" ]\r\n" +
        "      - [ utf8, 0x01060120, \"Seed Value\" ]\r\n" +
        "      - [ be16, 0x0106012B, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060130, \"Seed Value Auto. Generation\" ]\r\n" +
        "      - [ utf8, 0x01060150, \"XZ Occ. Angle\" ]\r\n" +
        "      - [ be16, 0x0106015D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060160, \"Y Occ. Angle\" ]\r\n" +
        "      - [ be16, 0x0106016C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060160, \"Gener. Angle\" ]\r\n" +
        "      - [ utf8, 0x01060170, \"Gener. Radius\" ]\r\n" +
        "      - [ utf8, 0x0104E970, \"Opaque\" ]\r\n" +
        "      - [ be16, 0x0104E976, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104E980, \"Transluscent\" ]\r\n" +
        "      - [ utf8, 0x0104E990, \"Additive Trnsl.\" ]\r\n" +
        "      - [ utf8, 0x0104E9A0, \"Subtrac. Trnsl.\" ]\r\n" +
        "      - [ utf8, 0x0104E9B0, \"Multiply Trnsl.\" ]\r\n" +
        "      - [ utf8, 0x0104E9C0, \"2x Multiplication Trnsl\" ]\r\n" +
        "      - [ utf8, 0x0104E920, \"Random Rotation\" ]\r\n" +
        "      - [ be16, 0x0104E92F, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104E938, \"Clockwise Rotation\" ]\r\n" +
        "      - [ be16, 0x0104E94A, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104E950, \"Counter-Clockwise Rotation\" ]\r\n" +
        "      - [ utf8, 0x0105BBB0, \"Hue\" ]\r\n" +
        "      - [ be16, 0x0105BBB3, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105BBB8, \"Sat.\" ]\r\n" +
        "      - [ be16, 0x0105BBBC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105BBC0, \"Brit.\" ]\r\n" +
        "      - [ be16, 0x0105BBB5, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F733, \"Deleted\" ]\r\n" +
        "      - [ be16, 0x0105F73A, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063D90, \"Asset Editor\" ]\r\n" +
        "      - [ be16, 0x01063D9C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063DB0, \"List of Loaded Assets\" ]\r\n" +
        "      - [ be16, 0x01063DC5, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063DE0, \"Preview\" ]\r\n" +
        "      - [ be16, 0x01063DE7, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063DF0, \"Cancel\" ]\r\n" +
        "      - [ be16, 0x01063DF6, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063E00, \"Select\" ]\r\n" +
        "      - [ be16, 0x01063E06, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063E08, \"Select from File\" ]\r\n" +
        "      - [ be16, 0x01063E18, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063EA8, \"Resource Name\" ]\r\n" +
        "      - [ be16, 0x01063EB5, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063EB8, \"Type\" ]\r\n" +
        "      - [ be16, 0x01063EBC, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063EC0, \"Attrib.\" ]\r\n" +
        "      - [ utf8, 0x01063EC8, \"Refer.\" ]\r\n" +
        "      - [ utf8, 0x01063EB8, \"Type\" ]\r\n" +
        "      - [ be16, 0x01063EBC, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060180, \"Ini. Rise Speed\" ]\r\n" +
        "      - [ utf8, 0x01060190, \"Radius Start\" ]\r\n" +
        "      - [ utf8, 0x010601A0, \"Radius End\" ]\r\n" +
        "      - [ be16, 0x010601AA, 0x00 ]\r\n" +
        "      - [ utf8, 0x010601B0, \"Rotat. Speed\" ]\r\n" +
        "      - [ utf8, 0x010601C0, \"Rotat. Accel.\" ]\r\n" +
        "      - [ be16, 0x010601CC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0105F790, \"%d hidden parts have been removed\" ]\r\n" +
        "      - [ be16, 0x0105F7B1, 0x00 ]\r\n" +
        "      - [ utf8, 0x010601D0, \"Occur. Angle\" ]\r\n" +
        "      - [ utf8, 0x010601E0, \"Expans. Veloc.\" ]\r\n" +
        "      - [ utf8, 0x010601F0, \"Expans. Accel.\" ]\r\n" +
        "      - [ be16, 0x010601FE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060200, \"Rotat. Speed\" ]\r\n" +
        "      - [ utf8, 0x01060210, \"Occur. Length\" ]\r\n" +
        "      - [ utf8, 0x01060220, \"Total # Occur.\" ]\r\n" +
        "      - [ utf8, 0x01060230, \"Generation Loop\" ]\r\n" +
        "      - [ utf8, 0x01060250, \"Flat Square (Fixed Y Axis)\" ]\r\n" +
        "      - [ be16, 0x0106026A, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060270, \"Length\" ]\r\n" +
        "      - [ utf8, 0x01060278, \"In.Wdth\" ]\r\n" +
        "      - [ utf8, 0x01060280, \"Ou.Wdth\" ]\r\n" +
        "      - [ utf8, 0x01060288, \"Rotation Type\" ]\r\n" +
        "      - [ be16, 0x01060295, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060298, \"Scale\" ]\r\n" +
        "      - [ be16, 0x0106029D, 0x00 ]\r\n" +
        "      - [ utf8, 0x010602A8, \"Material\" ]\r\n" +
        "      - [ be16, 0x010602B0, 0x00 ]\r\n" +
        "      - [ utf8, 0x010602B8, \"Inner Color\" ]\r\n" +
        "      - [ be16, 0x010602C3, 0x00 ]\r\n" +
        "      - [ utf8, 0x010602C8, \"Outer Color\" ]\r\n" +
        "      - [ utf8, 0x010602D8, \"Width\" ]\r\n" +
        "      - [ utf8, 0x010602E0, \"Radius\" ]\r\n" +
        "      - [ utf8, 0x010602E8, \"Spread\" ]\r\n" +
        "      - [ be16, 0x010602EE, 0x00 ]\r\n" +
        "      - [ utf8, 0x010602F8, \"Shape\" ]\r\n" +
        "      - [ be16, 0x010602FE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060300, \"Thickness Core\" ]\r\n" +
        "      - [ utf8, 0x01060310, \"Thick. Outside\" ]\r\n" +
        "      - [ utf8, 0x01060320, \"Divis. Number\" ]\r\n" +
        "      - [ utf8, 0x01060330, \"Taper\" ]\r\n" +
        "      - [ be16, 0x01060335, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060341, \"Color Core]\" ]\r\n" +
        "      - [ be16, 0x0106034C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060351, \"Color Outside]\" ]\r\n" +
        "      - [ be16, 0x0106035F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060369, \"Alpha]\" ]\r\n" +
        "      - [ be16, 0x0106036F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060378, \"V Movement\" ]\r\n" +
        "      - [ utf8, 0x01060388, \"V Repeat\" ]\r\n" +
        "      - [ be16, 0x01060390, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060398, \"Slope\" ]\r\n" +
        "      - [ be16, 0x0106039D, 0x00 ]\r\n" +
        "      - [ utf8, 0x010603A0, \"Rad. Start Pnt.\" ]\r\n" +
        "      - [ utf8, 0x010603B0, \"Rad. End Pnt.\" ]\r\n" +
        "      - [ utf8, 0x010603C0, \"Radius Animation Curve\" ]\r\n" +
        "      - [ be16, 0x010603D6, 0x00 ]\r\n" +
        "      - [ utf8, 0x010603E8, \"Height StartPnt\" ]\r\n" +
        "      - [ utf8, 0x010603F8, \"Height EndPnt\" ]\r\n" +
        "      - [ utf8, 0x01060408, \"Height Animation Curve\" ]\r\n" +
        "      - [ be16, 0x0106041E, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060430, \"Thick. StartPnt\" ]\r\n" +
        "      - [ utf8, 0x01060440, \"Thick. EndPnt\" ]\r\n" +
        "      - [ utf8, 0x01060450, \"Thickness Animation Curve\" ]\r\n" +
        "      - [ be16, 0x01060469, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060478, \"Edge Alpha\" ]\r\n" +
        "      - [ be16, 0x01060482, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060488, \"U Movement\" ]\r\n" +
        "      - [ utf8, 0x01060498, \"Thickness Ratio\" ]\r\n" +
        "      - [ utf8, 0x010604A8, \"U Repeat\" ]\r\n" +
        "      - [ be16, 0x010604B0, 0x00 ]\r\n" +
        "      - [ utf8, 0x010604B8, \"Occurrence Time\" ]\r\n" +
        "      - [ utf8, 0x010604C8, \"Shader\" ]\r\n" +
        "      - [ be16, 0x010604CE, 0x00 ]\r\n" +
        "      - [ utf8, 0x010604D8, \"Medium Color\" ]\r\n" +
        "      - [ utf8, 0x010604E9, \"Inner Color]\" ]\r\n" +
        "      - [ be16, 0x010604F5, 0x00 ]\r\n" +
        "      - [ utf8, 0x010604F9, \"Outer Color]\" ]\r\n" +
        "      - [ be16, 0x01060505, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060508, \"Starting Radius\" ]\r\n" +
        "      - [ utf8, 0x01060519, \"Medium Color\" ]\r\n" +
        "      - [ utf8, 0x0105BBC8, \"Tnsp.\" ]\r\n" +
        "      - [ be16, 0x0105BBCD, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060528, \"# of Amplitudes\" ]\r\n" +
        "      - [ utf8, 0x01060538, \"Amplitude Amnt.\" ]\r\n" +
        "      - [ utf8, 0x01060548, \"Unevenness Amnt\" ]\r\n" +
        "      - [ utf8, 0x01060558, \"Core Width\" ]\r\n" +
        "      - [ be16, 0x01060562, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060568, \"Tapered\" ]\r\n" +
        "      - [ be16, 0x0106056F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060578, \"Core Color\" ]\r\n" +
        "      - [ be16, 0x01060582, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060588, \"Border Color\" ]\r\n" +
        "      - [ be16, 0x01060594, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060598, \"Edge Color\" ]\r\n" +
        "      - [ be16, 0x010605A2, 0x00 ]\r\n" +
        "      - [ utf8, 0x010605A8, \"Y Rotation Type\" ]\r\n" +
        "      - [ be16, 0x010605B7, 0x00 ]\r\n" +
        "      - [ utf8, 0x010605C0, \"Y Rotat. Speed\" ]\r\n" +
        "      - [ be16, 0x010605CE, 0x00 ]\r\n" +
        "      - [ utf8, 0x010605D0, \"Y Rotational Acceler.\" ]\r\n" +
        "      - [ utf8, 0x010605E8, \"Z Rotation Type\" ]\r\n" +
        "      - [ be16, 0x010605F7, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060600, \"Z Rotat. Speed\" ]\r\n" +
        "      - [ be16, 0x0106060E, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060610, \"Z Rotational Acceler.\" ]\r\n" +
        "      - [ utf8, 0x01060628, \"Num. of Laps\" ]\r\n" +
        "      - [ utf8, 0x01060638, \"Random Animation\" ]\r\n" +
        "      - [ be16, 0x01060648, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060660, \"Distance from Screen\" ]\r\n" +
        "      - [ be16, 0x01060674, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060678, \"Adjust to Angle of View\" ]\r\n" +
        "      - [ utf8, 0x01060690, \"BasePnt\" ]\r\n" +
        "      - [ utf8, 0x010606A9, \"Side Length]\" ]\r\n" +
        "      - [ be16, 0x010606B5, 0x00 ]\r\n" +
        "      - [ utf8, 0x010606B9, \"Horiz. Length]\" ]\r\n" +
        "      - [ utf8, 0x010606C9, \"Vert. Length\" ]\r\n" +
        "      - [ utf8, 0x010606D8, \"Rotate\" ]\r\n" +
        "      - [ utf8, 0x010606E1, \"Rotat. Axis]\" ]\r\n" +
        "      - [ utf8, 0x010606F8, \"Random Rotation\" ]\r\n" +
        "      - [ be16, 0x01060707, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060710, \"Distan.\" ]\r\n" +
        "      - [ utf8, 0x01060718, \"Option\" ]\r\n" +
        "      - [ be16, 0x0106071E, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063FD8, \"Type\" ]\r\n" +
        "      - [ be16, 0x01063FDC, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063FE8, \"Number\" ]\r\n" +
        "      - [ be16, 0x01063FEE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063FF8, \"Speed\" ]\r\n" +
        "      - [ be16, 0x01063FFD, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064008, \"Interp.\" ]\r\n" +
        "      - [ be16, 0x0106400F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064018, \"Loop Playback\" ]\r\n" +
        "      - [ be16, 0x01064025, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064028, \"After playing, change to the motion below:\" ]\r\n" +
        "      - [ be16, 0x01064052, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064060, \"Number\" ]\r\n" +
        "      - [ utf8, 0x01064068, \"Speed\" ]\r\n" +
        "      - [ be16, 0x0106406D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01064070, \"Interp.\" ]\r\n" +
        "      - [ utf8, 0x0104E8E8, \"Reprod.\" ]\r\n" +
        "      - [ utf8, 0x0104E8F0, \"Stop\" ]\r\n" +
        "      - [ be16, 0x01104EF4, 0x00 ]\r\n" +
        "\r\n" +
        "      #--------------EPD Editor Window--------------\r\n" +
        "\r\n" +
        "      - [ utf8, 0x01066810, \"Preview\" ]\r\n" +
        "      - [ be64, 0x01066817, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x01066820, \"Load Color Map Texture\" ]\r\n" +
        "      - [ be64, 0x01066836, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x01066840, \"Load Displacement Map Texture\" ]\r\n" +
        "      - [ be64, 0x0106685d, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x01066865, 0x0000000000000000 ]\r\n" +
        "      - [ be64, 0x0106686d, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x01066878, \"Loop Play\" ]\r\n" +
        "      - [ be32, 0x01066881, 0x00000000 ]\r\n" +
        "      - [ be16, 0x01066885, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01066888, \"Intermittent Play \" ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Debug-System Window Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Scarltz\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ utf8, 0x00FB7770, \"System      \" ]\r\n" +
        "      - [ utf8, 0x00FB7780, \"Damage      \" ]\r\n" +
        "      - [ utf8, 0x00FB7790, \"Next turn   \" ]\r\n" +
        "      - [ utf8, 0x00FB77A0, \"Cost consumption            \" ]\r\n" +
        "      - [ utf8, 0x00FB77C0, \"Critical          \" ]\r\n" +
        "      - [ utf8, 0x00FB77D8, \"Baste? Recovery\" ]\r\n" +
        "      - [ utf8, 0x00FB77E8, \"Al. reflect \" ]\r\n" +
        "      - [ utf8, 0x00FB77F8, \"Al. absorb  \" ]\r\n" +
        "      - [ utf8, 0x00FB7808, \"Always hit  \" ]\r\n" +
        "      - [ utf8, 0x00FB7818, \"Always miss\" ]\r\n" +
        "      - [ utf8, 0x00FB7828, \"Al. disabled\" ]\r\n" +
        "      - [ utf8, 0x00FB7838, \"Always weak/critical             \" ]\r\n" +
        "      - [ utf8, 0x00FB7860, \"Always downed  \" ]\r\n" +
        "      - [ utf8, 0x00FB7870, \"Always slip       \" ]\r\n" +
        "      - [ utf8, 0x00FB7888, \"Always co-op skill (ally) \" ]\r\n" +
        "      - [ utf8, 0x00FB78A8, \"Always co-op skill (navi)       \" ]\r\n" +
        "      - [ utf8, 0x00FB78D0, \"Always cut in        \" ]\r\n" +
        "      - [ utf8, 0x00FB78E8, \"Select everyone   \" ]\r\n" +
        "      - [ utf8, 0x00FB7900, \"Use all skills    \" ]\r\n" +
        "      - [ utf8, 0x00FB7918, \"Enemy skill select\" ]\r\n" +
        "      - [ utf8, 0x00FB7930, \"Al. threaten en\" ]\r\n" +
        "      - [ utf8, 0x00FB7940, \"Enemy al. surre\" ]\r\n" +
        "      - [ utf8, 0x00FB7950, \"Network debugging             \" ]\r\n" +
        "      - [ utf8, 0x00FB7980, \"Use all skills in order       \" ]\r\n" +
        "      - [ utf8, 0x00FB79A0, \"Use all persona in order         \" ]\r\n" +
        "      - [ utf8, 0x00FB79C8, \"BED shader collection         \" ]\r\n" +
        "      - [ utf8, 0x00FB79E8, \"Aging          \" ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  BtlUnit-Status Window Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Scarltz\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      - [ utf8, 0x00FB7CB8, \"Status         \" ]\r\n" +
        "      - [ utf8, 0x00FB7CC8, \"Level       \" ]\r\n" +
        "      - [ utf8, 0x00FB7CF8, \"Ailment     \" ]\r\n" +
        "      - [ utf8, 0x00FB7D08, \"Full Heal\" ]\r\n" +
        "      - [ utf8, 0x00FB7D18, \"All 1    \" ]\r\n" +
        "      - [ utf8, 0x00FB7D28, \"Downed   \" ]\r\n" +
        "      - [ utf8, 0x00FB7D38, \"Kill  \" ]\r\n" +
        "      - [ utf8, 0x00FB7D40, \"Fully open analyze            \" ]\r\n" +
        "      - [ utf8, 0x00FB7D60, \"Fully close analyze           \" ]\r\n" +
        "      - [ utf8, 0x00FB7D80, \"Darken ON      \" ]\r\n" +
        "      - [ utf8, 0x00FB7D90, \"Darken OFF        \" ]\r\n" +
        "      - [ utf8, 0x00FB7DA8, \"Lipsync ON     \" ]\r\n" +
        "      - [ utf8, 0x00FB7DB8, \"Lipsync OFF       \" ]\r\n" +
        "      - [ utf8, 0x00FB7DD0, \"Unit change       \" ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  Model View Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: KingJackSkellington\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      # Animation Blend\r\n" +
        "      - [ utf8, 0x01060F40, \"Animation Blend\" ]\r\n" +
        "      - [ be16, 0x01060F4F, 0x00 ]\r\n" +
        "      # Attachment\r\n" +
        "      - [ utf8, 0x01061408, \"Helper ID\" ]\r\n" +
        "      - [ be16, 0x01061411, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061418, \"File Select\" ]\r\n" +
        "      - [ be16, 0x01061423, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061430, \"Cancel\" ]\r\n" +
        "      - [ be16, 0x01061436, 0x00 ]\r\n" +
        "      # Bounding Box\r\n" +
        "      - [ utf8, 0x01061220, \"Bounding Box\" ]\r\n" +
        "      - [ be16, 0x0106122C, 0x00 ]\r\n" +
        "      # Create Navigation Mesh\r\n" +
        "      - [ utf8, 0x01061A30, \"Navigation Map Creation\" ]\r\n" +
        "      - [ be16, 0x01061A47, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061B20, \"BasePnt\" ]\r\n" +
        "      - [ utf8, 0x01061B40, \"Interv.\" ]\r\n" +
        "      - [ utf8, 0x01061B48, \"Allow. Slope\" ]\r\n" +
        "      - [ utf8, 0x01061B58, \"Height Diff.\" ]\r\n" +
        "      - [ be16, 0x01061B64, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061B68, \"Range\" ]\r\n" +
        "      - [ be16, 0x01061B6D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061B70, \"Minimum X\" ]\r\n" +
        "      - [ utf8, 0x01061B80, \"Minimum Y\" ]\r\n" +
        "      - [ utf8, 0x01061B90, \"Minimum Z\" ]\r\n" +
        "      - [ utf8, 0x01061BA0, \"Maximum X\" ]\r\n" +
        "      - [ utf8, 0x01061BB0, \"Maximum Y\" ]\r\n" +
        "      - [ utf8, 0x01061BC0, \"Maximum Z\" ]\r\n" +
        "      - [ utf8, 0x01061BD0, \" Start \" ]\r\n" +
        "      - [ be16, 0x01061BD7, 0x00 ]\r\n" +
        "      # GFS Viewer\r\n" +
        "      - [ utf8, 0x01061360, \"Reload\" ]\r\n" +
        "      - [ be16, 0x01061366, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061370, \"Delete\" ]\r\n" +
        "      - [ utf8, 0x010612E8, \"Physics Editing\" ]\r\n" +
        "      - [ utf8, 0x010612F8, \"Create Navigation Mesh\" ]\r\n" +
        "      - [ utf8, 0x01061318, \"Move Camera to Front\" ]\r\n" +
        "      - [ be16, 0x0106132C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061338, \"Load Animation Pack (GAP)\" ]\r\n" +
        "      - [ be16, 0x01061351, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061258, \"Node Link\" ]\r\n" +
        "      - [ be16, 0x01061261, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061270, \"Node Name\" ]\r\n" +
        "      - [ be16, 0x01061279, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061280, \"Node Helper ID\" ]\r\n" +
        "      - [ be16, 0x0106128E, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061298, \"Physical Object\" ]\r\n" +
        "      - [ be16, 0x010612A7, 0x00 ]\r\n" +
        "      - [ utf8, 0x010612B8, \"Disable Separate KeyComposition\" ]\r\n" +
        "      - [ utf8, 0x010612D8, \"Transluscent\" ]\r\n" +
        "      - [ be16, 0x010612E4, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061458, \"GFS Viewer\" ]\r\n" +
        "      - [ be16, 0x01061462, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061470, \"Camera\" ]\r\n" +
        "      - [ be16, 0x01061476, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061480, \"Controller\" ]\r\n" +
        "      - [ be16, 0x0106148A, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061490, \"File Name\" ]\r\n" +
        "      - [ be16, 0x01061499, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614A0, \"Controls\" ]\r\n" +
        "      - [ be16, 0x010614A8, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614B8, \"Default\" ]\r\n" +
        "      - [ be16, 0x010614BF, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614C8, \"Front\" ]\r\n" +
        "      - [ be16, 0x010614CD, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614D8, \"Back\" ]\r\n" +
        "      - [ be16, 0x010614DC, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614E8, \"Top\" ]\r\n" +
        "      - [ be16, 0x010614EB, 0x00 ]\r\n" +
        "      - [ utf8, 0x010614F8, \"Bottom\" ]\r\n" +
        "      - [ be16, 0x010614FE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061508, \"Left\" ]\r\n" +
        "      - [ be16, 0x0106150C, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061518, \"Right\" ]\r\n" +
        "      - [ be16, 0x0106151D, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061528, \"Polygon Floor\" ]\r\n" +
        "      - [ be16, 0x01061535, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061538, \"Wire Floor\" ]\r\n" +
        "      - [ be16, 0x01061542, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061548, \"Floor Off\" ]\r\n" +
        "      - [ be16, 0x01061551, 0x00 ]\r\n" +
        "      - [ utf8, 0x01060F70, \"Interp.\" ]\r\n" +
        "      - [ utf8, 0x01060F78, \"Speed\" ]\r\n" +
        "      - [ utf8, 0x01060F90, \"Loop\" ]\r\n" +
        "      - [ be16, 0x01060F94, 0x00 ]\r\n" +
        "      - [ utf8, 0x010613D8, \"Reduction\" ]\r\n" +
        "      - [ be16, 0x010613E1, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061020, \"Neck Bending\" ]\r\n" +
        "      - [ utf8, 0x01061050, \"Info  \" ]\r\n" +
        "      - [ utf8, 0x010611A0, \"Dtls\" ]\r\n" +
        "      - [ be16, 0x010611A4, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061248, \"Node Position\" ]\r\n" +
        "      - [ utf8, 0x010611B0, \"Neck Bending View  \" ]\r\n" +
        "      - [ utf8, 0x010611C8, \"Attachment\" ]\r\n" +
        "      - [ be16, 0x010611D2, 0x00 ]\r\n" +
        "      - [ utf8, 0x010611E0, \"Node Hierarchy\" ]\r\n" +
        "      - [ be16, 0x010611EE, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061200, \"View Properties\" ]\r\n" +
        "      - [ be16, 0x0106120F, 0x00 ]\r\n" +
        "      # Info\r\n" +
        "      - [ utf8, 0x01061058, \"Number of nodes\" ]\r\n" +
        "      - [ utf8, 0x01061070, \"Number of skin nodes \" ]\r\n" +
        "      - [ utf8, 0x01061090, \"Number of geometries\" ]\r\n" +
        "      - [ utf8, 0x010610B0, \"Number of materials\" ]\r\n" +
        "      # Move\r\n" +
        "      - [ utf8, 0x0104E730, \"   Move   \" ]\r\n" +
        "      - [ be16, 0x0104E73A, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104E748, \"   Rotate   \" ]\r\n" +
        "      - [ be16, 0x0104E754, 0x00 ]\r\n" +
        "      - [ utf8, 0x010611A8, \"Move\" ]\r\n" +
        "      - [ be16, 0x010611AC, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063040, \"Edit with mouse\" ]\r\n" +
        "      - [ be16, 0x0106304F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063060, \"Move\" ]\r\n" +
        "      - [ be16, 0x01063064, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063080, \"Rotate\" ]\r\n" +
        "      - [ utf8, 0x01063090, \"Scale\" ]\r\n" +
        "      - [ be16, 0x01063095, 0x00 ]\r\n" +
        "      - [ utf8, 0x010630A0, \"Fixed XYZ Scaling\" ]\r\n" +
        "      - [ be16, 0x010630B1, 0x00 ]\r\n" +
        "      - [ utf8, 0x01063000, \"Revert Changes\" ]\r\n" +
        "      - [ be16, 0x0106300E, 0x00 ]\r\n" +
        "      # Neck Bending\r\n" +
        "      - [ utf8, 0x01061448, \"Up/Down\" ]\r\n" +
        "      - [ utf8, 0x01061450, \"LT/RT\" ]\r\n" +
        "      # Open File\r\n" +
        "      - [ utf8, 0x0104DCB8, \"Name\" ]\r\n" +
        "      - [ be16, 0x0104DCBC, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104DC80, \"Cancel\" ]\r\n" +
        "      - [ be16, 0x0104DC86, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0104DC90, \"Open\" ]\r\n" +
        "      - [ be16, 0x0104DC94, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0104DCC0, \"Size\" ]\r\n" +
        "      - [ be16, 0x0104DCC4, 0x0000 ]\r\n" +
        "      - [ utf8, 0x0104DCD0, \"Last Updated\" ]\r\n" +
        "      # Physics Editing\r\n" +
        "      - [ utf8, 0x01061378, \"Open \" ]\r\n" +
        "      - [ utf8, 0x01062050, \"Save GPC File\" ]\r\n" +
        "      - [ be64, 0x0106205D, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x01062098, \"Load GPC File\" ]\r\n" +
        "      - [ be32, 0x010620A5, 0x000000 ]\r\n" +
        "      - [ utf8, 0x010620F0, \"Particle\" ]\r\n" +
        "      - [ be32, 0x010620F8, 0x000000 ]\r\n" +
        "      - [ utf8, 0x01062108, \"Collision\" ]\r\n" +
        "      - [ be16, 0x01062111, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01062118, \"Constraint\" ]\r\n" +
        "      - [ be64, 0x01062122, 0x0000000000 ]\r\n" +
        "      - [ utf8, 0x01062138, \"Z Comparison\" ]\r\n" +
        "      - [ utf8, 0x01062148, \"Wire\" ]\r\n" +
        "      - [ be64, 0x0106214C, 0x0000000000000000 ]\r\n" +
        "      - [ utf8, 0x01062158, \"Open\" ]\r\n" +
        "      - [ be16, 0x0106215C, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01062160, \"Save\" ]\r\n" +
        "      - [ be16, 0x01062164, 0x00 ]\r\n" +
        "      - [ utf8, 0x01062168, \"WindEffective\" ]\r\n" +
        "      - [ utf8, 0x01062198, \"Node Name\" ]\r\n" +
        "      - [ be32, 0x010621A1, 0x000000 ]\r\n" +
        "      - [ utf8, 0x010621A8, \"Radius\" ]\r\n" +
        "      - [ utf8, 0x010621B0, \"Mass\" ]\r\n" +
        "      - [ be16, 0x010621B4, 0x0000 ]\r\n" +
        "      - [ utf8, 0x010621B8, \"RestoreForce\" ]\r\n" +
        "      - [ utf8, 0x010621C8, \"Wind\" ]\r\n" +
        "      - [ utf8, 0x010621D0, \"Type\" ]\r\n" +
        "      - [ be16, 0x010621D4, 0x0000 ]\r\n" +
        "      - [ utf8, 0x010621D8, \"Node A\" ]\r\n" +
        "      - [ be64, 0x010621DE, 0x000000000000 ]\r\n" +
        "      - [ utf8, 0x010621E8, \"Node B\" ]\r\n" +
        "      - [ be64, 0x010621EE, 0x000000000000 ]\r\n" +
        "      - [ utf8, 0x010621F8, \"Angle Limit\" ]\r\n" +
        "      - [ be16, 0x01062203, 0x00 ]\r\n" +
        "      - [ utf8, 0x01062208, \"Hit Radius\" ]\r\n" +
        "      - [ be16, 0x01062212, 0x0000 ]\r\n" +
        "      - [ utf8, 0x01062218, \"Add Particles\" ]\r\n" +
        "      - [ be64, 0x01062225, 0x0000000000000000000000 ]\r\n" +
        "      - [ utf8, 0x01062238, \"Add Collision - Ball\" ]\r\n" +
        "      - [ be64, 0x0106224C, 0x00000000000000 ]\r\n" +
        "      - [ utf8, 0x01062258, \"Add Collision - Capsule\" ]\r\n" +
        "      - [ be64, 0x0106226F, 0x00000000000000000000000000 ]\r\n" +
        "      - [ utf8, 0x01062280, \"Add Collision - Raft\" ]\r\n" +
        "      - [ be64, 0x01062294, 0x00000000000000000000000000 ]\r\n" +
        "      - [ utf8, 0x010622A8, \"Copy Parameters\" ]\r\n" +
        "      - [ be64, 0x010622B7, 0x000000000000000000  ]\r\n" +
        "      - [ utf8, 0x010622C8, \"Paste Parameters\" ]\r\n" +
        "      - [ be64, 0x010622D8, 0x00000000000000000000  ]\r\n" +
        "      - [ utf8, 0x010622E8, \"Delete Constraint\" ]\r\n" +
        "      - [ be64, 0x010622F9, 0x00000000000000000000  ]\r\n" +
        "      - [ utf8, 0x01062308, \"Delete Node\" ]\r\n" +
        "      - [ be64, 0x01062313, 0x00000000000000000000000000  ]\r\n" +
        "      - [ utf8, 0x01062328, \"Move/Rotate\" ]\r\n" +
        "      - [ be32, 0x01062333, 0x00000000  ]\r\n" +
        "      - [ utf8, 0x01062338, \"Parameter Mirror Paste\"  ]\r\n" +
        "      - [ be64, 0x01062350, 0x000000000000000000000000  ]\r\n" +
        "      - [ utf8, 0x01062360, \"Reset Position\"  ]\r\n" +
        "      - [ be32, 0x0106236E, 0x00000000  ]\r\n" +
        "      - [ utf8, 0x01062378, \"Reset Rotation\"  ]\r\n" +
        "      - [ be32, 0x01062386, 0x00000000  ]\r\n" +
        "      - [ utf8, 0x01062390, \"Delete Collision\"  ]\r\n" +
        "      - [ be64, 0x010623A0, 0x0000000000  ]\r\n" +
        "      - [ utf8, 0x010623A8, \"WindInfluence\" ]\r\n" +
        "      - [ utf8, 0x010623B8, \"Height\" ]\r\n" +
        "      - [ utf8, 0x01062D30, \"Edit with mouse\" ]\r\n" +
        "      - [ be16, 0x01062D3F, 0x00 ]\r\n" +
        "      - [ utf8, 0x01062D08, \"Revert Changes\" ]\r\n" +
        "      - [ be16, 0x01062D16, 0x00 ]\r\n" +
        "      # View Properties / Debug Console\r\n" +
        "      - [ utf8, 0x0104DDB8, \"Clear\" ]\r\n" +
        "      - [ be16, 0x0104DDBD, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104DDC8, \"Mem Info Output\" ]\r\n" +
        "      - [ be16, 0x0104DDD7, 0x00 ]\r\n" +
        "      - [ utf8, 0x0104DDE0, \"Task Info Output\" ]\r\n" +
        "      - [ be16, 0x0104DDF0, 0x00 ]\r\n" +
        "      - [ utf8, 0x01061030, \"Debug Console\" ]\r\n" +
        "      - [ be16, 0x0106103D, 0x00 ]\r\n" +
        "\r\n" +
        "PPU-800df00a7e7ac3ba08f8f0f40f9ec15433c7c6bb:\r\n" +
        "  L2 + R2 Translation:\r\n" +
        "    Games:\r\n" +
        "      \"XRD664\":\r\n" +
        "        TEST00000: [ All ]\r\n" +
        "    Author: Lyn, KingJackSkellington\r\n" +
        "    Notes: Translation\r\n" +
        "    Patch Version: 1.0\r\n" +
        "    Patch:\r\n" +
        "      # Main L2 + R2 Menu\r\n" +
        "      - [ utf8, 0x00F4091B, \"Collis.)\" ]\r\n" +
        "      - [ utf8, 0x00F40924, \"Player\" ]\r\n" +
        "      - [ be16, 0x00F4092A, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40934, \"Enemies\" ]\r\n" +
        "      - [ utf8, 0x00F4093C, \"Door & Tre. Box\" ]\r\n" +
        "      - [ utf8, 0x00F4094C, \"Camera\" ]\r\n" +
        "      - [ be16, 0x00F40952, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F4095C, \"Script\" ]\r\n" +
        "      - [ be16, 0x00F40962, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F4096C, \"Field Settings\" ]\r\n" +
        "      - [ be16, 0x00F4097A, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40994, \"Show Debug\" ]\r\n" +
        "      - [ be16, 0x00F4099E, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F409AC, \"Show Model\" ]\r\n" +
        "      - [ be16, 0x00F409B6, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F409BC, \"Show 2D\" ]\r\n" +
        "      - [ be16, 0x00F409C3, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F409CC, \"Show Performance\" ]\r\n" +
        "      - [ be16, 0x00F409DC, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F409EC, \"Resource Viewer\" ]\r\n" +
        "      - [ be16, 0x00F409FB, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A0C, \"Transition Wipe Viewer\" ]\r\n" +
        "      - [ utf8, 0x00F40A27, \" Editor\" ]\r\n" +
        "      - [ be16, 0x00F40A2E, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A37, \" Player\" ]\r\n" +
        "      - [ be16, 0x00F40A3E, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A4C, \"Save\" ]\r\n" +
        "      - [ be16, 0x00F40A50, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A5C, \"Load\" ]\r\n" +
        "      - [ be16, 0x00F40A60, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A6C, \"Return to Calendar\" ]\r\n" +
        "      - [ be16, 0x00F40A7E, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40A8F, \" Editor\" ]\r\n" +
        "      - [ be16, 0x00F40A96, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40AA7, \" Editor\" ]\r\n" +
        "      - [ be16, 0x00F40AAE, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40ABF, \" Editor\" ]\r\n" +
        "      - [ be16, 0x00F40AC6, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40AD7, \" Editor\" ]\r\n" +
        "      - [ be16, 0x00F40ADE, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40AEC, \"Reload Constant Objects\" ]\r\n" +
        "      - [ be16, 0x00F40B03, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40B0C, \"Reload Party Members\" ]\r\n" +
        "      - [ be16, 0x00F40B20, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F40B2C, \"Reload Background\" ]\r\n" +
        "      - [ be16, 0x00F40B3D, 0x00 ]\r\n" +
        "      # BULLET Menu\r\n" +
        "      - [ utf8, 0x00F7CE20, \"UphillSlopeAng.\" ]\r\n" +
        "      - [ utf8, 0x00F7CE30, \"BG Elasticity\" ]\r\n" +
        "      - [ utf8, 0x00F7CE40, \"Draw Cylinder\" ]\r\n" +
        "      - [ be16, 0x00F7CE4E, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7CE58, \"Per-Polygon Drawing\" ]\r\n" +
        "      - [ be16, 0x00F7CE6B, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7CE78, \"Per-Camera Polygon Drawing\" ]\r\n" +
        "      - [ be16, 0x00F7CE92, 0x00 ]\r\n" +
        "      # Player Menu\r\n" +
        "      - [ utf8, 0x00F7E558, \"Display Info\" ]\r\n" +
        "      - [ utf8, 0x00F7E568, \"Running Speed\" ]\r\n" +
        "      - [ be16, 0x00F7E575, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E578, \"Walking Speed\" ]\r\n" +
        "      - [ be16, 0x00F7E585, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E588, \"Crouch-Walking Speed\" ]\r\n" +
        "      - [ be16, 0x00F7E59C, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E5A8, \"Animation Speed\" ]\r\n" +
        "      - [ utf8, 0x00F7E5B8, \"Animation Info Output\" ]\r\n" +
        "      - [ utf8, 0x00F7E5E1, \" Coord\" ]\r\n" +
        "      - [ utf8, 0x00F7E5E9, \" Coord\" ]\r\n" +
        "      - [ utf8, 0x00F7E5F1, \" Coord\" ]\r\n" +
        "      - [ utf8, 0x00F7E5F8, \"Rotation Angle\" ]\r\n" +
        "      - [ utf8, 0x00F7E608, \"Hor. Neck Bend\" ]\r\n" +
        "      - [ utf8, 0x00F7E618, \"Vert. Neck Bend\" ]\r\n" +
        "      - [ utf8, 0x00F7E628, \"Costume\" ]\r\n" +
        "      - [ be16, 0x00F7E62F, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E638, \"Animation Pack Number\" ]\r\n" +
        "      - [ utf8, 0x00F7E650, \"Bag Status\" ]\r\n" +
        "      - [ be16, 0x00F7E65A, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E660, \"Parasol\" ]\r\n" +
        "      - [ utf8, 0x00F7E668, \"Rat\" ]\r\n" +
        "      - [ be16, 0x00F7E66B, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E678, \"Unlim. Disguise\" ]\r\n" +
        "      - [ utf8, 0x00F7E688, \"Info. Support Ability\" ]\r\n" +
        "      - [ utf8, 0x00F7E6A0, \"Treasure Reboot\" ]\r\n" +
        "      - [ be16, 0x00F7E6AF, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E6C0, \"Mementos Scan\" ]\r\n" +
        "      - [ be16, 0x00F7E6CD, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E6E0, \"Unique Action\" ]\r\n" +
        "      - [ be16, 0x00F7E6ED, 0x00 ]\r\n" +
        "      - [ utf8, 0x00F7E6F8, \"MAX Status\" ]\r\n" +
        "      - [ be16, 0x00F7E702, 0x00 ]";
    }
}