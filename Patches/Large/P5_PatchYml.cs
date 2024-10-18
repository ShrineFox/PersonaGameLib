using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGameLib
{
    public partial class Patches
    {
        public static string P5_PatchYml { get; } = "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Mod Cpk Support:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: File replacement through mod.cpk. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # make %s/hdd.cpk -> %s%s/mod.cpk\r\n" +
            "      - [ be32, 0x00B4D638, 0x25732573 ]\r\n" +
            "      - [ be32, 0x00B4D63C, 0x2F6D6F64 ]\r\n" +
            "      - [ be32, 0x00B4D640, 0x2E63706B ]\r\n" +
            "      # make mod.cpk file path\r\n" +
            "      - [ be32, 0x00114CA4, 0x3C6000B5 ] # lis    r3, cpkPathString@ha\r\n" +
            "      - [ be32, 0x00114CA8, 0x33E3D638 ] # addic  r31, r3, cpkPathString@l\r\n" +
            "      - [ be32, 0x00114CAC, 0x48968BEB ] # bla    getInstallPath\r\n" +
            "      - [ be32, 0x00114CB0, 0x60000000 ] # nop\r\n" +
            "      - [ be32, 0x00114CB4, 0x7C7E1B78 ] # mr     r30, r3\r\n" +
            "      - [ be32, 0x00114CB8, 0x48968BF7 ] # bla    getInstallPath2\r\n" +
            "      - [ be32, 0x00114CBC, 0x60000000 ] # nop\r\n" +
            "      - [ be32, 0x00114CC0, 0x33A10070 ] # addic  r29, r1, 0x70\r\n" +
            "      - [ be32, 0x00114CC4, 0x7C661B78 ] # mr     r6, r3\r\n" +
            "      - [ be32, 0x00114CC8, 0x7FA3EB78 ] # mr     r3, r29\r\n" +
            "      - [ be32, 0x00114CCC, 0x7FE4FB78 ] # mr     r4, r31\r\n" +
            "      - [ be32, 0x00114CD0, 0x7FC5F378 ] # mr     r5, r30\r\n" +
            "      - [ be32, 0x00114CD4, 0x48AD567F ] # bla    sprintf\r\n" +
            "      - [ be32, 0x00114CD8, 0x60000000 ] # nop\r\n" +
            "      - [ be32, 0x00114CDC, 0x48B44A9E ] # ba     branchOffset\r\n" +
            "      - [ be32, 0x00114CE0, 0x60000000 ] # nop\r\n" +
            "      # trampoline\r\n" +
            "      - [ be32, 0x00B44A9C, 0x7FA3EB78 ] # mr     r3, r29\r\n" +
            "      - [ be32, 0x00B44AA0, 0x48114B77 ] # bla    criFsBindCpk\r\n" +
            "      - [ be32, 0x00B44AA4, 0x60000000 ] # nop\r\n" +
            "      - [ be32, 0x00B44AA8, 0x3880000A ] # li     r4, 0xA\r\n" +
            "      - [ be32, 0x00B44AAC, 0x48AB8ED7 ] # bla    criFsBindPatch\r\n" +
            "      - [ be32, 0x00B44AB0, 0x60000000 ] # nop\r\n" +
            "      - [ be32, 0x00B44AB4, 0x48114CE6 ] # ba     0x114CA4 + 0x40\r\n" +
            "      - [ be32, 0x00B44AB8, 0x60000000 ] # nop\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  File Access Log:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Prints file paths to the console's TTY Log as they are accessed. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # branch to trampoline\r\n" +
            "      - [ be32, 0x00AC0A78, 0x48B44ABF ] # bla 0xB44ABC\r\n" +
            "      - [ be32, 0x00AC0A7C, 0x60000000 ] # nop\r\n" +
            "      # trampoline\r\n" +
            "      # prologue\r\n" +
            "      - [ be32, 0x00B44ABC, 0xF821FF41 ] # stdu    r1, -STACK_SIZE(r1)\r\n" +
            "      - [ be32, 0x00B44AC0, 0x7C0802A6 ] # mflr    r0\r\n" +
            "      - [ be32, 0x00B44AC4, 0xF80100D0 ] # std     r0, STACK_SIZE + 0x10(r1)\r\n" +
            "      # save volatile regs\r\n" +
            "      - [ be32, 0x00B44AC8, 0xF86100B8 ] # std     r3, STACK_SIZE - 0x08(r1)\r\n" +
            "      - [ be32, 0x00B44ACC, 0xF88100B0 ] # std     r4, STACK_SIZE - 0x10(r1)\r\n" +
            "      - [ be32, 0x00B44AD0, 0xF8A100A8 ] # std     r5, STACK_SIZE - 0x18(r1)\r\n" +
            "      - [ be32, 0x00B44AD4, 0xF8C100A0 ] # std     r6, STACK_SIZE - 0x20(r1)\r\n" +
            "      - [ be32, 0x00B44AD8, 0xF8E10098 ] # std     r7, STACK_SIZE - 0x28(r1)\r\n" +
            "      - [ be32, 0x00B44ADC, 0xF9010090 ] # std     r8, STACK_SIZE - 0x30(r1)\r\n" +
            "      - [ be32, 0x00B44AE0, 0xF9210088 ] # std     r9, STACK_SIZE - 0x38(r1)\r\n" +
            "      - [ be32, 0x00B44AE4, 0xF9410080 ] # std     r10, STACK_SIZE - 0x40(r1)\r\n" +
            "      - [ be32, 0x00B44AE8, 0xF9610078 ] # std     r11, STACK_SIZE - 0x48(r1)\r\n" +
            "      - [ be32, 0x00B44AEC, 0xF9810070 ] # std     r12, STACK_SIZE - 0x50(r1)\r\n" +
            "      # print file name\r\n" +
            "      - [ be32, 0x00B44AF0, 0x80630004 ] # lwz     r3, 0x04(r3)\r\n" +
            "      - [ be32, 0x00B44AF4, 0x7C6307B4 ] # extsw   r3, r3\r\n" +
            "      - [ be32, 0x00B44AF8, 0x48AD546F ] # bla     PTR_PRINTF\r\n" +
            "      - [ be32, 0x00B44AFC, 0x60000000 ] # nop\r\n" +
            "      # print newline\r\n" +
            "      - [ be32, 0x00B44B00, 0x3C6000B9 ] # lis    r3, PTR_NEWLINECHAR@ha\r\n" +
            "      - [ be32, 0x00B44B04, 0x30631820 ] # addic  r3, r3, PTR_NEWLINECHAR@l\r\n" +
            "      - [ be32, 0x00B44B08, 0x48AD546F ] # bla    PTR_PRINTF\r\n" +
            "      - [ be32, 0x00B44B0C, 0x60000000 ] # nop\r\n" +
            "      # restore volatile regs\r\n" +
            "      - [ be32, 0x00B44B10, 0xE86100B8 ] # ld     r3, STACK_SIZE - 0x08(r1)\r\n" +
            "      - [ be32, 0x00B44B14, 0xE88100B0 ] # ld     r4, STACK_SIZE - 0x10(r1)\r\n" +
            "      - [ be32, 0x00B44B18, 0xE8A100A8 ] # ld     r5, STACK_SIZE - 0x18(r1)\r\n" +
            "      - [ be32, 0x00B44B1C, 0xE8C100A0 ] # ld     r6, STACK_SIZE - 0x20(r1)\r\n" +
            "      - [ be32, 0x00B44B20, 0xE8E10098 ] # ld     r7, STACK_SIZE - 0x28(r1)\r\n" +
            "      - [ be32, 0x00B44B24, 0xE9010090 ] # ld     r8, STACK_SIZE - 0x30(r1)\r\n" +
            "      - [ be32, 0x00B44B28, 0xE9210088 ] # ld     r9, STACK_SIZE - 0x38(r1)\r\n" +
            "      - [ be32, 0x00B44B2C, 0xE9410080 ] # ld     r10, STACK_SIZE - 0x40(r1)\r\n" +
            "      - [ be32, 0x00B44B30, 0xE9610078 ] # ld     r11, STACK_SIZE - 0x48(r1)\r\n" +
            "      - [ be32, 0x00B44B34, 0xE9810070 ] # ld     r12, STACK_SIZE - 0x50(r1)\r\n" +
            "      # destroy stack frame\r\n" +
            "      - [ be32, 0x00B44B38, 0xE80100D0 ] # ld     r0, STACK_SIZE + 0x10(r1)\r\n" +
            "      - [ be32, 0x00B44B3C, 0x7C0803A6 ] # mtlr   r0\r\n" +
            "      - [ be32, 0x00B44B40, 0x382100C0 ] # addi   r1, r1, STACK_SIZE\r\n" +
            "      # return\r\n" +
            "      - [ be32, 0x00B44B44, 0xFB2100F8 ] # std    r25, 0xF8(r1)\r\n" +
            "      - [ be32, 0x00B44B48, 0xFAA100D8 ] # std    r21, 0xD8(r1)\r\n" +
            "      - [ be32, 0x00B44B4C, 0x4E800020 ] # blr\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Fix Script Printing Functions:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Allows flowscripts to print strings to TTY Log. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      #ScriptInterpreter_Comm_PUT_Hook\r\n" +
            "      - [ be32, 0x001E9D10, 0x48B44B9A ]\r\n" +
            "      #PutInt\r\n" +
            "      - [ be32, 0x00B44B98, 0x7C641B78 ]\r\n" +
            "      - [ be32, 0x00B44B9C, 0x3C6000B6 ]\r\n" +
            "      - [ be32, 0x00B44BA0, 0x3063394C ]\r\n" +
            "      - [ be32, 0x00B44BA4, 0x48AD546F ]\r\n" +
            "      - [ be32, 0x00B44BA8, 0x3C6000B9 ]\r\n" +
            "      - [ be32, 0x00B44BAC, 0x30631820 ]\r\n" +
            "      - [ be32, 0x00B44BB0, 0x48AD546F ]\r\n" +
            "      - [ be32, 0x00B44BB4, 0x481E9D16 ]\r\n" +
            "      #ScriptInterpreter_Comm_PUTF_Hook\r\n" +
            "      - [ be32, 0x001E9D68, 0x48B44BBA ]\r\n" +
            "      #PutFloat\r\n" +
            "      - [ be32, 0xB44BB8, 0xFC400890 ]\r\n" +
            "      - [ be32, 0xB44BBC, 0x3C6000B6 ]\r\n" +
            "      - [ be32, 0xB44BC0, 0x3063397C ]\r\n" +
            "      - [ be32, 0xB44BC4, 0x48AD546F ]\r\n" +
            "      - [ be32, 0xB44BC8, 0x3C6000B9 ]\r\n" +
            "      - [ be32, 0xB44BCC, 0x30631820 ]\r\n" +
            "      - [ be32, 0xB44BD0, 0x48AD546F ]\r\n" +
            "      - [ be32, 0xB44BD4, 0x481E9D6E ]\r\n" +
            "      #ScriptInterpreter_Comm_PUTS_Hook\r\n" +
            "      - [ be32, 0x001E9D3C, 0x48B44BDA ]\r\n" +
            "      #PutString\r\n" +
            "      - [ be32, 0x00B44BD8, 0x7C641B78 ]\r\n" +
            "      - [ be32, 0x00B44BDC, 0x3C6000B6 ]\r\n" +
            "      - [ be32, 0x00B44BE0, 0x30633994 ]\r\n" +
            "      - [ be32, 0x00B44BE4, 0x48AD546F ]\r\n" +
            "      - [ be32, 0x00B44BE8, 0x3C6000B9 ]\r\n" +
            "      - [ be32, 0x00B44BEC, 0x30631820 ]\r\n" +
            "      - [ be32, 0x00B44BF0, 0x48AD546F ]\r\n" +
            "      - [ be32, 0x00B44BF4, 0x481E9D42 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Skip Intro Videos:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x0055AC8C, 0x60000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  P5 Modding Community Patches:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: DeathChaos\r\n" +
            "    Notes: A collection of QoL patches to help make some game mods possible. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.4\r\n" +
            "    Patch:\r\n" +
            "      # Force Single GAP Combat Animations\r\n" +
            "      - [ be32, 0x723630, 0x428000ac ]\r\n" +
            "      # Expand DLC Outfit BGM List\r\n" +
            "      # Skip DLC Check for new outfits\r\n" +
            "      - [ be32, 0x0019b830, 0x60000000 ]\r\n" +
            "      - [ be32, 0x0019b83c, 0x60000000 ]\r\n" +
            "      # Patch table to redirect to new one\r\n" +
            "      - [ be32, 0x06cd00, 0x3fe000b4 ] # lis r31, 0xb4\r\n" +
            "      - [ be32, 0x06cd0c, 0x33ff4bf8 ] # addic r31, r31, 0x4bf8\r\n" +
            "      # Patch table size to new size 0x15\r\n" +
            "      - [ be32, 0x06cd5c, 0x2c1e0015 ] # cmpwi r30, 0x15\r\n" +
            "      # expand the table\r\n" +
            "      # Default BGM\r\n" +
            "      - [ be32, 0xB44BF8, 0x0000FFFF ]\r\n" +
            "      - [ be32, 0xB44BFC, 0x00000000 ]\r\n" +
            "      # bgm_01\r\n" +
            "      - [ be16, 0xB44C00, 0x0001 ]\r\n" +
            "      - [ be16, 0xB44C02, 0x7053 ]\r\n" +
            "      - [ be16, 0xB44C04, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C06, 0x2290 ]\r\n" +
            "      # bgm_02\r\n" +
            "      - [ be16, 0xB44C08, 0x0002 ]\r\n" +
            "      - [ be16, 0xB44C0A, 0x704A ]\r\n" +
            "      - [ be16, 0xB44C0C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C0E, 0x2291 ]\r\n" +
            "      # bgm_03\r\n" +
            "      - [ be16, 0xB44C10, 0x0003 ]\r\n" +
            "      - [ be16, 0xB44C12, 0x7065 ]\r\n" +
            "      - [ be16, 0xB44C14, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C16, 0x2292 ]\r\n" +
            "      # bgm_04\r\n" +
            "      - [ be16, 0xB44C18, 0x0004 ]\r\n" +
            "      - [ be16, 0xB44C1A, 0x705C ]\r\n" +
            "      - [ be16, 0xB44C1C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C1E, 0x2293 ]\r\n" +
            "      # bgm_05\r\n" +
            "      - [ be16, 0xB44C20, 0x0005 ]\r\n" +
            "      - [ be16, 0xB44C22, 0x7077 ]\r\n" +
            "      - [ be16, 0xB44C24, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C26, 0x2294 ]\r\n" +
            "      # bgm_06\r\n" +
            "      - [ be16, 0xB44C28, 0x0006 ]\r\n" +
            "      - [ be16, 0xB44C2A, 0x7092 ]\r\n" +
            "      - [ be16, 0xB44C2C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C2E, 0x2295 ]\r\n" +
            "      # bgm_07\r\n" +
            "      - [ be16, 0xB44C30, 0x0007 ]\r\n" +
            "      - [ be16, 0xB44C32, 0x709b ]\r\n" +
            "      - [ be16, 0xB44C34, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C36, 0x2296 ]\r\n" +
            "      # bgm_08\r\n" +
            "      - [ be16, 0xB44C38, 0x0008 ]\r\n" +
            "      - [ be16, 0xB44C3A, 0x70a4 ]\r\n" +
            "      - [ be16, 0xB44C3C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C3E, 0x2297 ]\r\n" +
            "      # bgm_09\r\n" +
            "      - [ be16, 0xB44C40, 0x0009 ]\r\n" +
            "      - [ be16, 0xB44C42, 0x70ad ]\r\n" +
            "      - [ be16, 0xB44C44, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C46, 0x2298 ]\r\n" +
            "      # bgm_10 - Original List ends here\r\n" +
            "      - [ be16, 0xB44C48, 0x000A ]\r\n" +
            "      - [ be16, 0xB44C4A, 0x706e ]\r\n" +
            "      - [ be16, 0xB44C4C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C4E, 0x2299 ]\r\n" +
            "      # bgm_11 - Starlight (c0001_170_00.GMD)\r\n" +
            "      - [ be16, 0xB44C50, 0x000B ]\r\n" +
            "      - [ be16, 0xB44C52, 0x70b6 ]\r\n" +
            "      - [ be16, 0xB44C54, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C56, 0x229A ]\r\n" +
            "      # bgm_12 - Midwinter Uniform (c0001_171_00.GMD)\r\n" +
            "      - [ be16, 0xB44C58, 0x000C ]\r\n" +
            "      - [ be16, 0xB44C5A, 0x70bf ]\r\n" +
            "      - [ be16, 0xB44C5C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C5E, 0x229B ]\r\n" +
            "      # bgm_13 - Midwinter Casual (c0001_172_00.GMD)\r\n" +
            "      - [ be16, 0xB44C60, 0x000D ]\r\n" +
            "      - [ be16, 0xB44C62, 0x70c8 ]\r\n" +
            "      - [ be16, 0xB44C64, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C66, 0x229C ]\r\n" +
            "      # bgm_14 - Featherman (c0001_173_00.GMD)\r\n" +
            "      - [ be16, 0xB44C68, 0x000E ]\r\n" +
            "      - [ be16, 0xB44C6A, 0x70d1 ]\r\n" +
            "      - [ be16, 0xB44C6C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C6E, 0x229D ]\r\n" +
            "      # bgm_15 - Summer Break (P5S) (c0001_174_00.GMD)\r\n" +
            "      - [ be16, 0xB44C70, 0x000F ]\r\n" +
            "      - [ be16, 0xB44C72, 0x70da ]\r\n" +
            "      - [ be16, 0xB44C74, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C76, 0x229E ]\r\n" +
            "      # bgm_16 - Deminica Suit (No Helmet) (c0001_175_00.GMD)\r\n" +
            "      - [ be16, 0xB44C78, 0x0010 ]\r\n" +
            "      - [ be16, 0xB44C7A, 0x70e3 ]\r\n" +
            "      - [ be16, 0xB44C7C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C7E, 0x229F ]\r\n" +
            "      # bgm_17 - New Cinema (c0001_176_00.GMD)\r\n" +
            "      - [ be16, 0xB44C80, 0x0011 ]\r\n" +
            "      - [ be16, 0xB44C82, 0x70ec ]\r\n" +
            "      - [ be16, 0xB44C84, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C86, 0x22A0 ]\r\n" +
            "      # bgm_18 - Ultramarine (Velvet Room) (c0001_177_00.GMD)\r\n" +
            "      - [ be16, 0xB44C88, 0x0012 ]\r\n" +
            "      - [ be16, 0xB44C8A, 0x70f5 ]\r\n" +
            "      - [ be16, 0xB44C8C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C8E, 0x22A1 ]\r\n" +
            "      # bgm_19 - RESERVE (c0001_178_00.GMD)\r\n" +
            "      - [ be16, 0xB44C90, 0x0013 ]\r\n" +
            "      - [ be16, 0xB44C92, 0x70fe ]\r\n" +
            "      - [ be16, 0xB44C94, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C96, 0x22A2 ]\r\n" +
            "      # bgm_20 - RESERVE (c0001_179_00.GMD)\r\n" +
            "      - [ be16, 0xB44C98, 0x0014 ]\r\n" +
            "      - [ be16, 0xB44C9A, 0x7107 ]\r\n" +
            "      - [ be16, 0xB44C9C, 0x0000 ]\r\n" +
            "      - [ be16, 0xB44C9E, 0x22A3 ]\r\n" +
            "      # Disable Player Swordtrack loading\r\n" +
            "      - [ be32, 0x00265cc, 0x38600000 ] # li   param_1,0x0\r\n" +
            "      # DLC\r\n" +
            "      - [ be32, 0x0019b830, 0x60000000 ]\r\n" +
            "      - [ be32, 0x0019b83c, 0x60000000 ]\r\n" +
            "      # Increase red menu bg size\r\n" +
            "      - [ bef32,0x4c1400, 2.00000000 ]\r\n" +
            "      - [ bef32,0x4c4d9c, 2.00000000 ]\r\n" +
            "      - [ be32, 0x4c4cd8, 0x60000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  60 FPS:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Patch may accelerate some game effects by 2x. Causes game progress breaking in some places. Updated patch fixes subtitle cut-off in cutscenes.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00010268, 0x9061009C ] # set update rate to 60 -> r3, 0xE0+var_44(r1)\r\n" +
            "      - [ be32, 0x008FC864, 0x60000000 ] # nop cellGcmSetSecondVFrequency\r\n" +
            "      - [ bef32, 0x00012484, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00045678, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000616F0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00073F20, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x000753A0, 0.01666667 ] # Doubles camera speed\r\n" +
            "      - [ bef32, 0x00077E54, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00078A70, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0007A238, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00081864, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000885C8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0008C550, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0008D6D0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000D058C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000D0B4C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000E4754, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x000E50F0, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x000E8190, 0.01666667 ] # Breaks crumpled paper animation\r\n" +
            "      - [ bef32, 0x000F8B78, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00101CE8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001E7344, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EB0D4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EB328, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EB814, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EB940, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EBA04, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EBBA0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001EBCD0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x001ECCA0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00234C64, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0023F4BC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002400BC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00240BB0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0029231C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00294A70, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002952F8, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x002B027C, 0.01666667 ] # Makes it impossible to run < 60FPS\r\n" +
            "      - [ bef32, 0x002B0688, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002B6154, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002B71F8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002B82C8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002B98F8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002B9F8C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002BA614, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002BC84C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002BCD2C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002C550C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002D1328, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x002D230C, 0.01666667 ] # Doubles movement speed\r\n" +
            "      - [ bef32, 0x002D2DDC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002D8A10, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002D8A18, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002DA46C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x002FBB00, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0030E258, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x003181D4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0031CE24, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0031DBE0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0033DBD0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00358664, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00359020, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0035AD10, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00364A98, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0037429C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00376E7C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00379B08, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0037AAAC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0037CF54, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0037DB7C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x003803F4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00387A80, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00388684, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x003ACBC0, 0.01666667 ] # kaleidoscope speedup\r\n" +
            "      - [ bef32, 0x003BDDD0, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x003E944C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x003F35EC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x003F6FF4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058CE18, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058DE64, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058E82C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058E958, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058F47C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058FA00, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058FAB4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058FBE4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058FD2C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0058FE6C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00590A04, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x005B6914, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x005F1C6C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0062076C, 0.01666667 ] # battle related stuff\r\n" +
            "      - [ bef32, 0x007072BC, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00722D7C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0073C840, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00772E50, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x0087B338, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B10110, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B6AA14, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B6AA38, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B70B48, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B70BC8, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B71CF4, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00B72F38, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00CFF46C, 0.01666667 ]\r\n" +
            "      - [ bef32, 0x00061700, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00069AA4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0007A1EC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00081880, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x000C8258, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x000C991C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00101CCC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x001E2C44, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x001E61E8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x001E7338, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00250C50, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00256B20, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00292100, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00294A60, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002952E4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0029FD98, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002A1BB8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002A41D0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002A6124, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002B4FF0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002B60DC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002B7174, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002B82F4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002B8E74, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BA600, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BAB30, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BB4E0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BB808, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BC368, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BC844, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002BD414, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002C4F54, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002C4FF0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002C69E4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002D4378, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002DD968, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002DE538, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x002DEA04, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0030D7A0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0030E6BC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003181B8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0031AFE0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0031CE38, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0031DBF0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0031EC74, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00322FB4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00356560, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003586BC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00358F90, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0035A380, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0035AA3C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00364A9C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003688C8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00368A88, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00368E30, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00376FD0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00377538, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00377CD8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037C2B0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037D310, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037D418, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037D5B4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037DD08, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037DE10, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0037DF78, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00382F38, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003845F0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00387A6C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00398208, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00398460, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003999F8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003A7C64, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003AA418, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003AE0E4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003AE3A0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003B25D8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003BC448, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003C58C0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003C67B0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003C6D6C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003EBC20, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003EE5F0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003F1FE0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x003F6FC0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x004EB808, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0055251C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0055EC48, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0055F4A8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0057DC08, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x0057E498, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x005C5364, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00620714, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00635CB4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00642B98, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00654EE8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00662B04, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x006AFF98, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x006CAA44, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x006E0224, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x006E31A0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x006FCD3C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00772E54, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00797508, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B52E3C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6AD00, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6B71C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E478, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E880, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E8B8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E8F0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E928, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E960, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E998, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6E9D0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EA08, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EA40, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EA78, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EAB0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EAE8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EB20, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EB58, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EB90, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EBC8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EC00, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EC38, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6EC70, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B6ECA8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70A54, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70AF0, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70AF8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B00, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B08, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B10, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B20, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B78, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70B88, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70BB4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70BC4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B70F60, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B71BAC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B71BBC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00B9BD30, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CF96AC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFA1E8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFA20C, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFB210, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFB778, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFBC30, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFBCA8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFBFD4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFC0A8, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFF3CC, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFF3D4, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFF470, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFF478, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00CFF480, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00D06840, 0.1666667 ]\r\n" +
            "      - [ bef32, 0x00D06848, 0.1666667 ]\r\n" +
            "      - [ be32, 0x000FB71C, 0x3C603C88 ]\r\n" +
            "      - [ be32, 0x00109B14, 0x3C603C88 ]\r\n" +
            "      - [ be32, 0x0023FBDC, 0x3CA03C88 ]\r\n" +
            "      - [ be32, 0x00240620, 0x3CA03C88 ]\r\n" +
            "      - [ be32, 0x00241258, 0x3C803C88 ]\r\n" +
            "      - [ be32, 0x003CA4BC, 0x3C603C88 ]\r\n" +
            "      - [ be32, 0x0087B448, 0x3C603C88 ]\r\n" +
            "      #- [ bef32, 0x0009eb60, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x002cb9e8, 0.01666667 ]\r\n" +
            "      #- [ bef32, 0x00331FF0, 0.1666667 ]\r\n" +
            "      #- [ bef32, 0x003B0520, 0.1666667 ]\r\n" +
            "      #- [ bef32, 0x003B05E8, 0.1666667 ]\r\n" +
            "      #- [ bef32, 0x003b25cc, 0.1666667 ]\r\n" +
            "      #- [ bef32, 0x003BC478, 0.1666667 ]\r\n" +
            "      #- [ be32, 0x000a7e6c, 0x3d803c88 ]\r\n" +
            "      - [ be32, 0x0026dca0, 0x3860001e ] # batting cages\r\n" +
            "      - [ be32, 0x0026de4c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026e36c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fb10, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fb3c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fb78, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fc30, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fca0, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fd14, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fd50, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fdf4, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fe14, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fe50, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fe9c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0026fedc, 0x3860001e ]\r\n" +
            "      - [ be32, 0x002700e4, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00270304, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288b04, 0x3860001e ] # party panel\r\n" +
            "      - [ be32, 0x00288b4c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288b70, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288bb0, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288bdc, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288c18, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00288c3c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x002892f0, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028931c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x00289344, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028b324, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028b4c8, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028c1a0, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028c1cc, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028c1f4, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028ea90, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028eacc, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028eafc, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028eb3c, 0x3860001e ]\r\n" +
            "      - [ be32, 0x0028eb60, 0x3860001e ]\r\n" +
            "      - [ be32, 0x001cfe60, 0x3860001e ] # blink anim\r\n" +
            "      # Removes framerate dependency for both script interpreters\r\n" +
            "      - [ be32, 0xb44e00, 0x38600001 ]# li r3,0x1\r\n" +
            "      - [ be32, 0xb44e04, 0x38dd0170 ]# addi r6,r29,0x170\r\n" +
            "      - [ be32, 0xb44e08, 0x48b44e2f ]# bla0xb44e2c\r\n" +
            "      - [ be32, 0xb44e0c, 0x2c040000 ]# cmpwir4,0x0\r\n" +
            "      - [ be32, 0xb44e10, 0x40820008 ]# bne+0x8\r\n" +
            "      - [ be32, 0xb44e14, 0x481f263a ]# ba 0x1f2638\r\n" +
            "      - [ be32, 0xb44e18, 0x7c844014 ]# addc r4,r4,r8\r\n" +
            "      - [ be32, 0xb44e1c, 0x7ca54014 ]# addc r5,r5,r8\r\n" +
            "      - [ be32, 0xb44e20, 0x481f2642 ]# ba 0x1f2640\r\n" +
            "      - [ be32, 0xb44e24, 0x3cc000d9 ]# lisr6,0xd9\r\n" +
            "      - [ be32, 0xb44e28, 0x60c6c6ec ]# orir6,r6,0xc6ec\r\n" +
            "      - [ be32, 0xb44e2c, 0x3ce000ff ]# lisr7,0xff\r\n" +
            "      - [ be32, 0xb44e30, 0x80e7fb50 ]# lwzr7,-0x4b0(r7)\r\n" +
            "      - [ be32, 0xb44e34, 0x81060000 ]# lwzr8,0(r6)\r\n" +
            "      - [ be32, 0xb44e38, 0x90e60000 ]# stwr7,0(r6)\r\n" +
            "      - [ be32, 0xb44e3c, 0x7d083850 ]# subf r8,r8,r7\r\n" +
            "      - [ be32, 0xb44e40, 0x7d09fe70 ]# srawir9,r8,0x1f\r\n" +
            "      - [ be32, 0xb44e44, 0x7d084850 ]# subf r8,r8,r9\r\n" +
            "      - [ be32, 0xb44e48, 0x55080ffe ]# rlwinm r8,r8,0x1,0x1f,0x1f\r\n" +
            "      - [ be32, 0xb44e4c, 0x5509103a ]# rlwinm r9,r8,0x2,0x0,0x1d\r\n" +
            "      - [ be32, 0xb44e50, 0x4e800020 ]# blr\r\n" +
            "      - [ be32, 0x1f161c, 0x38600174 ]# li r3,0x174\r\n" +
            "      - [ be32, 0x1f1640, 0x38800174 ]# li r4,0x174\r\n" +
            "      - [ be32, 0x1f2634, 0x48b44e02 ]# ba 0xb44e00\r\n" +
            "      - [ be32, 0x575fb4, 0x48b44e27 ]# bla0xb44e24\r\n" +
            "      - [ be32, 0x576010, 0x48b44e27 ]# bla0xb44e24\r\n" +
            "      - [ be32, 0x576020, 0x7c892010 ]# subfcr4,r9,r4\r\n" +
            "      - [ be32, 0x57602c, 0x7c882010 ]# subfcr4,r8,r4\r\n" +
            "      - [ be32, 0x575fc4, 0x7c892010 ]# subfcr4,r9,r4\r\n" +
            "      - [ be32, 0x575fe0, 0x7c681810 ]# subfcr3,r8,r3\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  4K Mod:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: rexis\r\n" +
            "    Notes: To be used only with 4K Bustup Mod by rexis.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x5748f8, 0x48b44f93 ]  # font\r\n" +
            "      - [ be32, 0x56ead4, 0x38600020 ]\r\n" +
            "      - [ be32, 0x56ead8, 0x4e800020 ]\r\n" +
            "      - [ be32, 0x56e6e8, 0x38800020 ]\r\n" +
            "      - [ be32, 0x56e724, 0x39000020 ]\r\n" +
            "      - [ be32, 0x56e72c, 0x38600020 ]\r\n" +
            "      - [ be32, 0x1cffb0, 0x48b45007 ]  # bustups\r\n" +
            "      - [ be32, 0x1d027C, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d039C, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1cffd4, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d02a0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d03c0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db940, 0x48b45007 ]  # navigator portraits\r\n" +
            "      - [ be32, 0x1db544, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db684, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db978, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db568, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db6a8, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x5b90f0, 0x48b45007 ]  # cutins\r\n" +
            "      - [ be32, 0x5b9100, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x5b9598, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x5b9634, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1c4958, 0x481c458a ]  # sprite size\r\n" +
            "      - [ be32, 0x1c4a08, 0x481c45f2 ]\r\n" +
            "      - [ be32, 0x1c45bc, 0x80630038 ]\r\n" +
            "      - [ be32, 0x1c4624, 0x8063003c ]\r\n" +
            "      - [ be32, 0x43077c, 0x80630038 ]\r\n" +
            "      - [ be32, 0x430814, 0x8063003c ]\r\n" +
            "      - [ be32, 0x430978, 0x80640028 ]  # sprites\r\n" +
            "      - [ be32, 0x43097c, 0x80a4003c ]\r\n" +
            "      - [ be32, 0x430a10, 0x48b44f03 ]\r\n" +
            "      - [ be32, 0x430a24, 0x60000000 ]\r\n" +
            "      - [ be32, 0x430d90, 0x80630038 ]  # sprites 2\r\n" +
            "      - [ be32, 0x430e10, 0x8084003c ]\r\n" +
            "      - [ be32, 0x0ce18c, 0x48b45007 ]  # minimap\r\n" +
            "      - [ be32, 0x0ce1b0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x3ebd14, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x3ebd38, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x4e67f0, 0x48b45007 ]  # hero\r\n" +
            "      - [ be32, 0x4e6810, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x245e54, 0x48b45007 ]  # poem\r\n" +
            "      - [ be32, 0x245e78, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x240a14, 0x48b45007 ]  # fusion unlocked\r\n" +
            "      - [ be32, 0x240a3c, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x0da694, 0x48b45007 ]  # mission title\r\n" +
            "      - [ be32, 0x0da6c0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x0673b0, 0x48b45007 ]  # palace alert lvl\r\n" +
            "      - [ be32, 0x0673d0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x3a753c, 0x48b45007 ]  # place pictures\r\n" +
            "      - [ be32, 0x3a7570, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x11bba0, 0x48b45007 ]  # shop\r\n" +
            "      - [ be32, 0x11bbc4, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x17c0b4, 0x4842fbe3 ]\r\n" +
            "      - [ be32, 0x141644, 0x48b45007 ]  # clinic bg\r\n" +
            "      - [ be32, 0x141674, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1416ac, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1416dc, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d2a44, 0x48b45007 ]  # inventory icons\r\n" +
            "      - [ be32, 0x1d2a64, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x135834, 0x48b45026 ]\r\n" +
            "      - [ be32, 0x42fc70, 0x48b44ee3 ]  # misc dds\r\n" +
            "      - [ be32, 0x42fc94, 0x48b44ee3 ]\r\n" +
            "      - [ be32, 0x42fe64, 0x48b44ed3 ]\r\n" +
            "      - [ be32, 0x42fe90, 0x48b44ed3 ]\r\n" +
            "      - [ be32, 0x4c3eac, 0x4811bb13 ]\r\n" +
            "      - [ be32, 0x1b46e4, 0x4811bb13 ]\r\n" +
            "      - [ be32, 0x3f6284, 0x48b44f4e ]  # the 'Q'\r\n" +
            "      - [ bef32,0x43226c,-0.16666666 ]  # persona mask\r\n" +
            "      - [ bef32,0x432270, 0.16666666 ]\r\n" +
            "      - [ bef32,0x431a44, 0.16666666 ]  # confidant rotating thing\r\n" +
            "      - [ bef32,0x4c1400, 3.00000000 ]  # menu red bg (todo)\r\n" +
            "      - [ bef32,0x4c4d9c, 3.00000000 ]\r\n" +
            "      - [ be32, 0x4c4cd8, 0x60000000 ]\r\n" +
            "      - [ be32, 0x8143cc, 0x60000000 ]  # heart (todo)\r\n" +
            "      - [ be32, 0x8143dc, 0x60000000 ]\r\n" +
            "      - [ be32, 0x288310, 0x48b44f3f ]  # hb revert tex width\r\n" +
            "      - [ be32, 0x288320, 0x48b44f47 ]  # hb revert tex height\r\n" +
            "      - [ be32, 0x2883c8, 0x48b44fa7 ]  # scale to 1/3 patch\r\n" +
            "      - [ be32, 0x28c160, 0x48b44fb6 ]  # hp bar patch\r\n" +
            "      - [ be32, 0x28c320, 0x48b44fde ]  # sp bar patch\r\n" +
            "      # common stuff\r\n" +
            "      - [ be32, 0xb45004, 0x38a00003 ]  # li r5,0x3\r\n" +
            "      - [ be32, 0xb45008, 0x7c632bd2 ]  # divd   r3,r3,r5\r\n" +
            "      - [ be32, 0xb4500c, 0x4e800020 ]  # blr\r\n" +
            "      - [ be32, 0xb45024, 0xf8610018 ]  # stdr3,0x18(r1)\r\n" +
            "      - [ be32, 0xb45028, 0x63c30000 ]  # orir3,r30,0x0\r\n" +
            "      - [ be32, 0xb4502c, 0x48b44f3f ]  # bla0xb44f3c\r\n" +
            "      - [ be32, 0xb45030, 0xffa00890 ]  # fmrf29,f1\r\n" +
            "      - [ be32, 0xb45034, 0x63c30000 ]  # orir3,r30,0x0\r\n" +
            "      - [ be32, 0xb45038, 0x48b44f47 ]  # bla0xb44f44\r\n" +
            "      - [ be32, 0xb4503c, 0xff800890 ]  # fmrf28,f1\r\n" +
            "      - [ be32, 0xb45040, 0x4813583a ]  # ba 0x135838\r\n" +
            "      - [ be32, 0xb44ed0, 0xa0a100e5 ]  # lhzr5,0xe5(r1)\r\n" +
            "      - [ be32, 0xb44ed4, 0x2c054c4d ]  # cmpwi  r5,0x4c4d\r\n" +
            "      - [ be32, 0xb44ed8, 0x40820020 ]  # bne+0x20\r\n" +
            "      - [ be32, 0xb44edc, 0x4e800020 ]  # blr\r\n" +
            "      - [ be32, 0xb44ee0, 0xa0a10165 ]  # lhzr5,0x165(r1)\r\n" +
            "      - [ be32, 0xb44ee4, 0x2c0542fe ]  # cmpwi  r5,0x42fe\r\n" +
            "      - [ be32, 0xb44ee8, 0x40820014 ]  # bne+0x14\r\n" +
            "      - [ be32, 0xb44eec, 0xa0a10235 ]  # lhzr5,0x235(r1)\r\n" +
            "      - [ be32, 0xb44ef0, 0x2c054c4d ]  # cmpwi  r5,0x4c4d\r\n" +
            "      - [ be32, 0xb44ef4, 0x41820008 ]  # beq+0x8\r\n" +
            "      - [ be32, 0xb44ef8, 0x48b45006 ]  # ba 0xb45004\r\n" +
            "      - [ be32, 0xb44efc, 0x4e800020 ]  # blr\r\n" +
            "      - [ be32, 0xb44f00, 0xc9a10018 ]  # lfdf13,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f04, 0x81440038 ]  # lwzr10,0x38(r4)\r\n" +
            "      - [ be32, 0xb44f08, 0xf9410018 ]  # stdr10,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f0c, 0xc9010018 ]  # lfdf8,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f10, 0xfd00469c ]  # fcfid  f8,f8\r\n" +
            "      - [ be32, 0xb44f14, 0x8144002c ]  # lwzr10,0x2c(r4)\r\n" +
            "      - [ be32, 0xb44f18, 0xf9410018 ]  # stdr10,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f1c, 0xc8e10018 ]  # lfdf7,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f20, 0xfce03e9c ]  # fcfid  f7,f7\r\n" +
            "      - [ be32, 0xb44f24, 0xfd40569c ]  # fcfid  f10,f10\r\n" +
            "      - [ be32, 0xb44f28, 0x4e800020 ]  # blr\r\n" +
            "      - [ be32, 0xb44f3c, 0xf821ff81 ]  # stdu   r1,-0x80(r1)\r\n" +
            "      - [ be32, 0xb44f40, 0x481c495e ]  # ba 0x1c495c\r\n" +
            "      - [ be32, 0xb44f44, 0xf821ff81 ]  # stdu   r1,-0x80(r1)\r\n" +
            "      - [ be32, 0xb44f48, 0x481c4a0e ]  # ba 0x1c4a0c\r\n" +
            "      - [ be32, 0xb44f4c, 0xfda00890 ]  # fmrf13,f1\r\n" +
            "      - [ be32, 0xb44f50, 0x807d0010 ]  # lwzr3,0x10(r29)\r\n" +
            "      - [ be32, 0xb44f54, 0x48b44f3f ]  # bla0xb44f3c\r\n" +
            "      - [ be32, 0xb44f58, 0xff800890 ]  # fmrf28,f1\r\n" +
            "      - [ be32, 0xb44f5c, 0x807d0010 ]  # lwzr3,0x10(r29)\r\n" +
            "      - [ be32, 0xb44f60, 0x48b44f47 ]  # bla0xb44f44\r\n" +
            "      - [ be32, 0xb44f64, 0xc37c0010 ]  # lfsf27,0x10(r28)\r\n" +
            "      - [ be32, 0xb44f68, 0xef7b0072 ]  # fmuls  f27,f27,f1\r\n" +
            "      - [ be32, 0xb44f6c, 0x807e0004 ]  # lwzr3,0x4(r30)\r\n" +
            "      - [ be32, 0xb44f70, 0xa0630008 ]  # lhzr3,0x8(r3)\r\n" +
            "      - [ be32, 0xb44f74, 0xf8610018 ]  # stdr3,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f78, 0xc8610018 ]  # lfdf3,0x18(r1)\r\n" +
            "      - [ be32, 0xb44f7c, 0xfc601e9c ]  # fcfid  f3,f3\r\n" +
            "      - [ be32, 0xb44f80, 0xec7a1824 ]  # fdivs  f3,f26,f3\r\n" +
            "      - [ be32, 0xb44f84, 0xec4dd82a ]  # fadds  f2,f13,f27\r\n" +
            "      - [ be32, 0xb44f88, 0xfc206890 ]  # fmrf1,f13\r\n" +
            "      - [ be32, 0xb44f8c, 0x483f6292 ]  # ba 0x3f6290\r\n" +
            "      - [ be32, 0xb44f90, 0x3ca00111 ]  # lisr5,0x111\r\n" +
            "      - [ be32, 0xb44f94, 0x80a5f75c ]  # lwzr5,-0x8a4(r5)\r\n" +
            "      - [ be32, 0xb44f98, 0xa0850010 ]  # lhzr4,0x10(r5)\r\n" +
            "      - [ be32, 0xb44f9c, 0xa0a50012 ]  # lhzr5,0x12(r5)\r\n" +
            "      - [ be32, 0xb44fa0, 0x4e800020 ]  # blr\r\n" +
            "      # healthbars (todo)\r\n" +
            "      - [ be32, 0xb44fa4, 0x3c803eaa ]  # lisr4,0x3eaa\r\n" +
            "      - [ be32, 0xb44fa8, 0x90870090 ]  # stwr4,0x90(r7)\r\n" +
            "      - [ be32, 0xb44fac, 0x90870094 ]  # stwr4,0x94(r7)\r\n" +
            "      - [ be32, 0xb44fb0, 0x4e800020 ]  # blr\r\n" +
            "      - [ be32, 0xb44fb4, 0x3c60c30a ]  # lisr3,-0x3e90\r\n" +
            "      - [ be32, 0xb44fb8, 0x9061008c ]  # stwr3,0x8c(r1)\r\n" +
            "      - [ be32, 0xb44fbc, 0x3c60c170 ]  # lisr3,-0x3cf6\r\n" +
            "      - [ be32, 0xb44fc0, 0x90610090 ]  # stwr3,0x90(r1)\r\n" +
            "      - [ be32, 0xb44fc4, 0x63430000 ]  # orir3,r26,0x0\r\n" +
            "      - [ be32, 0xb44fc8, 0x62240000 ]  # orir4,r17,0x0\r\n" +
            "      - [ be32, 0xb44fcc, 0x62a50000 ]  # orir5,r21,0x0\r\n" +
            "      - [ be32, 0xb44fd0, 0x48288003 ]  # bla0x288000\r\n" +
            "      - [ be32, 0xb44fd4, 0x3c600029 ]  # lisr3,0x29\r\n" +
            "      - [ be32, 0xb44fd8, 0x4828c166 ]  # ba 0x28c164\r\n" +
            "      - [ be32, 0xb44fdc, 0x3c60c2ba ]  # lisr3,-0x3d46\r\n" +
            "      - [ be32, 0xb44fe0, 0x9061008c ]  # stwr3,0x8c(r1)\r\n" +
            "      - [ be32, 0xb44fe4, 0x63430000 ]  # orir3,r26,0x0\r\n" +
            "      - [ be32, 0xb44fe8, 0x62240000 ]  # orir4,r17,0x0\r\n" +
            "      - [ be32, 0xb44fec, 0x62a50000 ]  # orir5,r21,0x0\r\n" +
            "      - [ be32, 0xb44ff0, 0x48288003 ]  # bla0x288000\r\n" +
            "      - [ be32, 0xb44ff4, 0xe8610130 ]  # ld r3,0x130(r1)\r\n" +
            "      - [ be32, 0xb44ff8, 0x4828c326 ]  # ba 0x28c324\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  4K Mod Bustups Only:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: rexis\r\n" +
            "    Notes: To be used only with 4K Bustup Mod by rexis.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x1cffb0, 0x48b45007 ] # bustups A\r\n" +
            "      - [ be32, 0x1d027C, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d039C, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1cffd4, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d02a0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1d03c0, 0x48b45007 ]\r\n" +
            "      - [ be32, 0xb45004, 0x38a00003 ] # li     r5,0x3\r\n" +
            "      - [ be32, 0xb45008, 0x7c632bd2 ] # divd   r3,r3,r5\r\n" +
            "      - [ be32, 0xb4500c, 0x4e800020 ] # blr\r\n" +
            "      - [ be32, 0x1db940, 0x48b45007 ]  # navigator portraits\r\n" +
            "      - [ be32, 0x1db544, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db684, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db978, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db568, 0x48b45007 ]\r\n" +
            "      - [ be32, 0x1db6a8, 0x48b45007 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Encounter BGM in Order:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma, Lipsum\r\n" +
            "    Notes: Plays alternate BGM files in order instead of shuffling) Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # patch SoundManager__SetEquipBgm\r\n" +
            "      # branch to trampoline\r\n" +
            "      - [ be32, 0x0006CD68, 0x48B44B52 ] # ba 0x00B44B50\r\n" +
            "      # trampoline\r\n" +
            "      - [ be32, 0x00B44B50, 0x3FDE3000 ] # addis  r30, r30, 0x3000 -> 0x30B49738\r\n" +
            "      - [ be32, 0x00B44B54, 0xA07E0000 ] # lhzr3, 0x0(r30)\r\n" +
            "      - [ be32, 0x00B44B58, 0x38630001 ] # addi   r3, r3, 0x1\r\n" +
            "      - [ be32, 0x00B44B5C, 0x2803000B ] # cmplwi r3, 0xb (MaxBgm)\r\n" +
            "      - [ be16, 0x00B44B5E, 11 ] # bgm_10 -> 11\r\n" +
            "      - [ be32, 0x00B44B60, 0x41800008 ] # blt+0x8\r\n" +
            "      - [ be32, 0x00B44B64, 0x38600000 ] # li r3, 0x0\r\n" +
            "      # patch music id\r\n" +
            "      - [ be32, 0x00B44B68, 0xB07E0000 ] # sth   r3, 0(r30)\r\n" +
            "      # return\r\n" +
            "      - [ be32, 0x00B44B6C, 0x2C1E0000 ] # cmpwi r30, 0\r\n" +
            "      - [ be32, 0x00B44B70, 0x4806CD6E ] # ba0x0006CD6C\r\n" +
            "      # patch Btl__PlayBgm\r\n" +
            "      # branch to trampoline\r\n" +
            "      - [ be32, 0x0063ACE4, 0x48B44B87 ] # bla 0x00B44B84 (trampoline)\r\n" +
            "      - [ be32, 0x0063ACE8, 0x4806CCBB ] # bla 0x0006CCB8 (SoundManager__GetBgmId)\r\n" +
            "      # trampoline\r\n" +
            "      # check and return if not normal battle bgm\r\n" +
            "      - [ be32, 0x00B44B84, 0x2C1F012C ] # cmpwi r31, 300 # normal battle\r\n" +
            "      - [ be32, 0x00B44B88, 0x41820008 ] # beq   8# return if not normal battle music\r\n" +
            "      - [ be32, 0x00B44B8C, 0x4E800020 ] # blr\r\n" +
            "      # randomize sound bank\r\n" +
            "      - [ be32, 0x00B44B90, 0x4806CCCB ] # bla 0x0006CCC8 (SoundManager__SetEquipBgm)\r\n" +
            "      # return\r\n" +
            "      - [ be32, 0x00B44B94, 0x4863ACEA ] # ba 0x0063ACE8\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Encounter BGM Random Order:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Plays encounter BGM in random order. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # patch SoundManager__SetEquipBgm\r\n" +
            "      # branch to trampoline\r\n" +
            "      - [ be32, 0x0006CD68, 0x48B44B52 ] # ba 0x00B44B50\r\n" +
            "      # trampoline\r\n" +
            "      # Rnd() % MaxBgm\r\n" +
            "      - [ be32, 0x00B44B50, 0x4891DA07 ] # bla   0x0091DA04 (Rnd)\r\n" +
            "      - [ be32, 0x00B44B54, 0x38C0000B ] # li    r6, 11 (MaxBgm)\r\n" +
            "      - [ be16, 0x00B44B56, 11 ] # bgm_10 -> 11\r\n" +
            "      - [ be32, 0x00B44B58, 0x30860001 ] # addic r4, r6, 1\r\n" +
            "      - [ be32, 0x00B44B5C, 0x7C832396 ] # divwu r4, r3, r4\r\n" +
            "      - [ be32, 0x00B44B60, 0x7CA431D6 ] # mullw r5, r4, r6\r\n" +
            "      - [ be32, 0x00B44B64, 0x7C852014 ] # addc  r4, r5, r4\r\n" +
            "      - [ be32, 0x00B44B68, 0x7C641810 ] # subfc r3, r4, r3\r\n" +
            "      - [ be32, 0x00B44B6C, 0x7C6307B4 ] # extsw r3, r3\r\n" +
            "      # patch music id\r\n" +
            "      - [ be32, 0x00B44B70, 0x3FDE3000 ] # addis r30, r30, 0x3000 -> 0x30B49738\r\n" +
            "      - [ be32, 0x00B44B74, 0xB07E0000 ] # sth   r3, 0(r30)\r\n" +
            "      # return\r\n" +
            "      - [ be32, 0x00B44B78, 0x2C1E0000 ] # cmpwi r30, 0\r\n" +
            "      - [ be32, 0x00B44B7C, 0x4806CD6E ] # ba    0x0006CD6C\r\n" +
            "      # patch Btl__PlayBgm\r\n" +
            "      # branch to trampoline\r\n" +
            "      - [ be32, 0x0063ACE4, 0x48B44B87 ] # bla 0x00B44B84 (trampoline)\r\n" +
            "      - [ be32, 0x0063ACE8, 0x4806CCBB ] # bla 0x0006CCB8 (SoundManager__GetBgmId)\r\n" +
            "      # trampoline\r\n" +
            "      # check and return if not normal battle bgm\r\n" +
            "      - [ be32, 0x00B44B84, 0x2C1F012C ] # cmpwi r31, 300 # normal battle\r\n" +
            "      - [ be32, 0x00B44B88, 0x41820008 ] # beq   8        # return if not normal battle music\r\n" +
            "      - [ be32, 0x00B44B8C, 0x4E800020 ] # blr\r\n" +
            "      # randomize sound bank\r\n" +
            "      - [ be32, 0x00B44B90, 0x4806CCCB ] # bla 0x0006CCC8 (SoundManager__SetEquipBgm)\r\n" +
            "      # return\r\n" +
            "      - [ be32, 0x00B44B94, 0x4863ACEA ] # ba 0x0063ACE8\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable DLC Unlock Messages:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x197AE8, 0x4E800020 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable Blur Filter:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma, ruipin, kd-11\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00FEE27A, 0x9E001700 ]\r\n" +
            "      - [ be32, 0x00FEE27E, 0xC801001D ]\r\n" +
            "      - [ be32, 0x00FEE282, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FEE286, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FEE28A, 0x1E810100 ]\r\n" +
            "      - [ be32, 0x00FEE28E, 0xC800001D ]\r\n" +
            "      - [ be32, 0x00FEE292, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FEE296, 0x00000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable Normal Distortion Filter [<=99% Alert & Velvet Room:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma, ruipin, kd-11\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00FE2E28, 0x9E001700 ]\r\n" +
            "      - [ be32, 0x00FE2E2C, 0xC801001D ]\r\n" +
            "      - [ be32, 0x00FE2E30, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE2E34, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE2E38, 0x1E810100 ]\r\n" +
            "      - [ be32, 0x00FE2E3C, 0xC800001D ]\r\n" +
            "      - [ be32, 0x00FE2E40, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE2E44, 0x00000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable Angry Distortion Filter [100% Alert]:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma, ruipin, kd-11\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00FE31CC, 0x9E001700 ]\r\n" +
            "      - [ be32, 0x00FE31D0, 0xC801001D ]\r\n" +
            "      - [ be32, 0x00FE31D4, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE31D8, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE31DC, 0x1E810100 ]\r\n" +
            "      - [ be32, 0x00FE31E0, 0xC800001D ]\r\n" +
            "      - [ be32, 0x00FE31E4, 0x00000000 ]\r\n" +
            "      - [ be32, 0x00FE31E8, 0x00000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable HUD Elements:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Elements can disabled separately by adding/removing their respective lines from the patch.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0xDE4EC, 0x60000000 ] # mission list\r\n" +
            "      - [ be32, 0xE83F4, 0x60000000 ] # place pict\r\n" +
            "      - [ be32, 0xE5920, 0x60000000 ] # check\r\n" +
            "      - [ be32, 0x69CC4, 0x38600001 ] # alert\r\n" +
            "      - [ be32, 0x5F678, 0x60000000 ] # date\r\n" +
            "      - [ be32, 0x38A0D0, 0x4838A186 ] # misc field hud\r\n" +
            "      - [ be32, 0x28FBA0, 0x38600000 ] # party panel\r\n" +
            "      - [ be32, 0x28FBA4, 0x4E800020 ] # party panel\r\n" +
            "      - [ be32, 0xD6B48, 0x60000000 ] # mini map\r\n" +
            "      - [ be32, 0xD6490, 0x60000000 ] # mini map\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable HUD Elements [Aggressive]:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: TGEnigma\r\n" +
            "    Notes: Disable HUD by disabling rendering of 2D elements entirely. Breaks things.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x116934, 0x4E800020 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Custom Maximum Bullet Count:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Lipsum\r\n" +
            "    Notes: To change the maximum bullet counts for each character, edit this patch and input your desired values. By default, this patch retains the game defaults until modified.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be16, 0x00D5C188, 0  ] # empty - base start\r\n" +
            "      - [ be16, 0x00D5C18A, 16 ] # joker (16)\r\n" +
            "      - [ be16, 0x00D5C18C, 8  ] # ryuji (8)\r\n" +
            "      - [ be16, 0x00D5C18E, 15 ] # morgana (15)\r\n" +
            "      - [ be16, 0x00D5C190, 36 ] # ann (36)\r\n" +
            "      - [ be16, 0x00D5C192, 24 ] # yusuke (24)\r\n" +
            "      - [ be16, 0x00D5C194, 12 ] # makoto (12)\r\n" +
            "      - [ be16, 0x00D5C196, 6  ] # haru (6)\r\n" +
            "      - [ be16, 0x00D5C198, 0  ] # futaba (0)\r\n" +
            "      - [ be16, 0x00D5C19A, 12 ] # goro (12)\r\n" +
            "      - [ be16, 0x00D5C19C, 0  ] # empty - tower rank 5 start\r\n" +
            "      - [ be16, 0x00D5C19E, 32 ] # joker (32)\r\n" +
            "      - [ be16, 0x00D5C1A0, 16 ] # ryuji (16)\r\n" +
            "      - [ be16, 0x00D5C1A2, 25 ] # morgana (25)\r\n" +
            "      - [ be16, 0x00D5C1A4, 60 ] # ann (60)\r\n" +
            "      - [ be16, 0x00D5C1A6, 48 ] # yusuke (48)\r\n" +
            "      - [ be16, 0x00D5C1A8, 24 ] # makoto (24)\r\n" +
            "      - [ be16, 0x00D5C1AA, 12 ] # haru (12)\r\n" +
            "      - [ be16, 0x00D5C1AC, 0  ] # futaba (0)\r\n" +
            "      - [ be16, 0x00D5C1AE, 24 ] # goro (24)\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable Navigator Battle Messages:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Lipsum\r\n" +
            "    Notes: Disables Navigator battle lines (voice and message popups).\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x0074a3b4, 0x38a00000 ] # li r5, 0x0 # morgana\r\n" +
            "      - [ be32, 0x0074a424, 0x38a00000 ] # li r5, 0x0 # futaba\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Replace Color d0d0d0:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Lipsum\r\n" +
            "    Notes: Replaces the red color in the pause menu. Yellow by default.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x0045a6d8, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x0045a6dc, 0x60842200 ] # ori param_2,param_2,0xd000\r\n" +
            "      - [ be32, 0x0049c938, 0x3ca0ffff ] # lis param_3,-0x2f30\r\n" +
            "      - [ be32, 0x0049c93c, 0x60a52200 ] # ori param_3,param_3,0xd000\r\n" +
            "      - [ be32, 0x0049c978, 0x3ca0ffff ] # lis param_3,-0x2f30\r\n" +
            "      - [ be32, 0x0049c97c, 0x60a52200 ] # ori param_3,param_3,0xd000\r\n" +
            "      - [ be32, 0x0049ca6c, 0x3f20ffff ] # lis r25,-0x2f30\r\n" +
            "      - [ be32, 0x0049ca70, 0x63392200 ] # ori r25,r25,0xd000\r\n" +
            "      - [ be32, 0x0049caac, 0x3f20ffff ] # lis r25,-0x2f30\r\n" +
            "      - [ be32, 0x0049cab0, 0x63392200 ] # ori r25,r25,0xd000\r\n" +
            "      - [ be32, 0x004a02a0, 0x3d20ffff ] # lis param_7,-0x2f30\r\n" +
            "      - [ be32, 0x004a02c0, 0x61272200 ] # ori param_5,param_7,0xd000\r\n" +
            "      - [ be32, 0x004a2fe0, 0x3f80ffff ] # lis r28,-0x2f30\r\n" +
            "      - [ be32, 0x004a2fec, 0x639c2200 ] # ori r28,r28,0xd000\r\n" +
            "      - [ be32, 0x004a2ff4, 0x3f80ffff ] # lis r28,-0x2f30\r\n" +
            "      - [ be32, 0x004a3000, 0x639c2200 ] # ori r28,r28,0xd000\r\n" +
            "      - [ be32, 0x004a4374, 0x3cc0ffff ] # lis param_4,-0x2f30\r\n" +
            "      - [ be32, 0x004a437c, 0x60c62200 ] # ori param_4,param_4,0xd000\r\n" +
            "      - [ be32, 0x004a4490, 0x3ce0ffff ] # lis param_5,-0x2f30\r\n" +
            "      - [ be32, 0x004a4498, 0x60e72200 ] # ori param_5,param_5,0xd000\r\n" +
            "      - [ be32, 0x004a4bd0, 0x3c60ffff ] # lis param_1,-0x2f30\r\n" +
            "      - [ be32, 0x004a4bdc, 0x607a2200 ] # ori r26,param_1,0xd000\r\n" +
            "      - [ be32, 0x004a6304, 0x3c60ffff ] # lis param_1,-0x2f30\r\n" +
            "      - [ be32, 0x004a6308, 0x60632200 ] # ori param_1,param_1,0xd000\r\n" +
            "      - [ be32, 0x004ac530, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x004ac538, 0x60842200 ] # ori param_2,param_2,0xd000\r\n" +
            "      - [ be32, 0x004b3ad4, 0x3fc0ffff ] # lis r30,-0x2f30\r\n" +
            "      - [ be32, 0x004b3ad8, 0x63de2200 ] # ori r30,r30,0xd000\r\n" +
            "      - [ be32, 0x004c0f80, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x004c0f88, 0x60842200 ] # ori param_2,param_2,0xd000\r\n" +
            "      - [ be32, 0x004c1150, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x004c115c, 0x609d2200 ] # ori r29,param_2,0xd000\r\n" +
            "      - [ be32, 0x004c1154, 0x3ca0ffff ] # lis param_3,-0x2f30\r\n" +
            "      - [ be32, 0x004c1160, 0x60a32200 ] # ori param_1,param_3,0xd000\r\n" +
            "      - [ be32, 0x004c3c18, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x004c3c1c, 0x60842200 ] # ori param_2,param_2,0xd000\r\n" +
            "      - [ be32, 0x004c3c30, 0x3c60ffff ] # lis param_1,-0x2f30\r\n" +
            "      - [ be32, 0x004c3c38, 0x60632200 ] # ori param_1,param_1,0xd000\r\n" +
            "      - [ be32, 0x004c5b34, 0x3c60ffff ] # lis param_1,-0x2f30\r\n" +
            "      - [ be32, 0x004c5b38, 0x606522ff ] # ori param_3,param_1,0xd0ff\r\n" +
            "      - [ be32, 0x004c5f0c, 0x3c80ffff ] # lis param_2,-0x2f30\r\n" +
            "      - [ be32, 0x004c5f18, 0x60842200 ] # ori param_2,param_2,0xd000\r\n" +
            "      - [ be32, 0x0052b1b0, 0x3ca0ffff ] # lis param_3,-0x2f30\r\n" +
            "      - [ be32, 0x0052b1c4, 0x60a52200 ] # ori param_3,param_3,0xd000\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Prevent Party Panel From Loading:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: DeathChaos\r\n" +
            "    Notes: Prevents in combat HP/SP Bar UI from loading for testing purposes\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # Prevent party_panel from being loaded\r\n" +
            "      - [ be32, 0x28fc14, 0x60000000 ]\r\n" +
            "      - [ be32, 0x28fc1c, 0x60000000 ]\r\n" +
            "      - [ be32, 0x28fc20, 0x60000000 ]\r\n" +
            "      - [ be32, 0x28fc34, 0x60000000 ]\r\n" +
            "      - [ be32, 0x28fc40, 0x60000000 ]\r\n" +
            "      - [ be32, 0x28fc54, 0x60000000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disables background music:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: DniweTamp\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # rename bgm.awb\r\n" +
            "      - [ be32, 0x00B4972E, 0x63756D2E ]\r\n" +
            "      # rename bgm_xx.awb\r\n" +
            "      - [ be32, 0x00B497AE, 0x63756D2E ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Load same ENV on all Fields:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: DniweTamp\r\n" +
            "    Notes: Loads /env/testing_envs_file.ENV on every field\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be64, 0x00B477A8, 0x74657374696E675F ]\r\n" +
            "      - [ be64, 0x00B477B0, 0x656E76735F66696C ]\r\n" +
            "      - [ byte, 0x00B477B8, 0x65 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Disable EXIST TBL Check:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Scarltz\r\n" +
            "    Notes: Prevent crash on invalid Personas, enemies, and party members. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      # Prevent crash on invalid Personas, enemies, and party members\r\n" +
            "      - [ be32, 0x26b39c, 0x386000c9 ] # li r3,0xc9\r\n" +
            "      - [ be32, 0x26b36c, 0x386000c9 ]\r\n" +
            "      - [ be32, 0x26b2bc, 0x38600029 ] # li r3,0x29\r\n" +
            "      - [ be32, 0x26b2ec, 0x38600029 ]\r\n" +
            "      - [ be32, 0x26b32c, 0x38600029 ]\r\n" +
            "      - [ be32, 0x26b000, 0x38600002 ] # li r3,0x2\r\n" +
            "      - [ be32, 0x26b0a4, 0x38600002 ]\r\n" +
            "      - [ be32, 0x26b158, 0x38600002 ]\r\n" +
            "      - [ be32, 0x26b20c, 0x38600002 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Force PSZ Models:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Scarltz\r\n" +
            "    Notes: Always use the model with a .psz filename for Personas. Not compatible with P5 EX.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00039dc0, 0x63840000 ]\r\n" +
            "      - [ be32, 0x0003a46c, 0x63840000 ]\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Prevent Being Kicked From Palaces:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: DeathChaos\r\n" +
            "    Notes: Don't get removed from palaces if you're at max security level.\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00321bf8, 0x38600000 ] #   li r3, 0x0\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Remove Player Active Combat Idle Animations:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: Sierra\r\n" +
            "    Notes:\r\n" +
            "    Patch Version: 1.1\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x00afc7f0, 0x4e800020 ] #Make Transition Anim Function BLR immediately\r\n" +
            "      - [ be32, 0x00afc900, 0x38800000 ] #Replace Active Combat Idle anim with normal Idle Anim\r\n" +
            "      - [ be32, 0x00720dcc, 0x42800014 ] #Remove AoA Ready Anim Check\r\n" +
            "      - [ be32, 0x00702cd0, 0x80840008 ] #Ambush Start Transition Fix\r\n" +
            "      - [ be32, 0x00702ba0, 0x80840008 ] #Exit Gun Menu Transition Fix\r\n" +
            "      - [ be32, 0x007035fc, 0x80840008 ] #Exit Persona Menu Transition Fix\r\n" +
            "      - [ be32, 0x007038b4, 0x80840008 ] #Exit Order Menu Transition Fix\r\n" +
            "      - [ be32, 0x007039f0, 0x80840008 ] #Exit Item Menu Transition Fix\r\n" +
            "PPU-b8c34f774adb367761706a7f685d4f8d9d355426:\r\n" +
            "  Fix SEL_DEFKEY:\r\n" +
            "    Games:\r\n" +
            "      \"Persona 5\":\r\n" +
            "        BLES02247: [ All ]\r\n" +
            "        NPEB02436: [ All ]\r\n" +
            "        BLUS31604: [ All ]\r\n" +
            "        NPUB31848: [ All ]\r\n" +
            "    Author: SecreC.\r\n" +
            "    Notes: Fixes SEL_DEFKEY oversight in the English version of P5, allowing you to back out of most prompts by pressing O\r\n" +
            "    Patch Version: 1.0\r\n" +
            "    Patch:\r\n" +
            "      - [ be32, 0x582b64, 0x48614d3c ] #b 0xb978a0\r\n" +
            "      - [ be32, 0xb978a0, 0x3cc00111 ] #lis  r6, 0x111 (original instruction)\r\n" +
            "      - [ be32, 0xb978a4, 0x2c04000e ] #cmpwi  r4, 0xe\r\n" +
            "      - [ be32, 0xb978a8, 0x40820008 ] #bne  0xb978b0\r\n" +
            "      - [ be32, 0xb978ac, 0x3880000d ] #li  r4, 0xd (if first arg of SEL_DEFKEY is 14, make it 13)\r\n" +
            "      - [ be32, 0xb978b0, 0x4b9eb2b8 ] #b  0x582b68";

    }
}
