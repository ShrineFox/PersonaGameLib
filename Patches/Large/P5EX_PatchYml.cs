using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGameLib
{
    public partial class Patches
    {
        public static string P5EX_PatchYml { get; } = "PPU-e72e715d646a94770d1902364bc66fe33b1b6606:\r\n" +
"  P5EX:\r\n" +
"    Games:\r\n" +
"      \"Persona 5\":\r\n" +
"        BLES02247: [ All ]\r\n" +
"        NPEB02436: [ All ]\r\n" +
"        BLUS31604: [ All ]\r\n" +
"        NPUB31848: [ All ]\r\n" +
"    Author: DeathChaos, Sierra, Scarltz\r\n" +
"    Notes:\r\n" +
"    Patch Version: 2.0.0\r\n" +
"    Patch:\r\n" +
"      # redirect uses of exact copy of GetEquipPersona to the first one to free some code space\r\n" +
"        - [ be32, 0x001efdb8, 0x4806c085 ] \r\n" +
"        - [ be32, 0x001efef0, 0x4806bf4d ] \r\n" +
"\r\n" +
"        # Load Futaba navi voicepack for all IDs above 4\r\n" +
"        - [ be32, 0x00745888, 0x2c1e000a ] # cmpwi      r30, 0xA\r\n" +
"        - [ be32, 0x0074588c, 0x4081006c ] # ble        0x007458f8\r\n" +
"\r\n" +
"        # prevent navi game over dialogue on encounters 790 and up\r\n" +
"        - [ be32, 0x00b1be24, 0x480000f0 ] # NOP\r\n" +
"\r\n" +
"        # fix PT Joker Portrait until model 200\r\n" +
"        - [ be16, 0x004ead92, 200 ] #\r\n" +
"        #- [ be32, 0x00baaa84, 0x00cf1718 ]\r\n" +
"        # test\r\n" +
"        - [ be32, 0x00268ff4, 0x2c1103E8 ] # 350 -> 999\r\n" +
"        - [ be32, 0x00269af0, 0x2c1503E8 ] # 350 -> 999\r\n" +
"        #\r\n" +
"        #- [ be32, 0x00784838, 0x2c1f015f ] # cmpwi r31, 0xD9\r\n" +
"        #- [ be32, 0x00784940, 0x2c1e015f ] # cmpwi r30, 0xD9\r\n" +
"        #- [ be32, 0x007845ec, 0x281a0190 ] # cmpwi r26, 0xDA\r\n" +
"        #- [ be32, 0x00786824, 0x281f0190 ] # cmpwi r31, 0xDA\r\n" +
"        #- [ be32, 0x00786a98, 0x2c03033F ] # cmpwi r3, 0x30b\r\n" +
"        #- [ be32, 0x007853c8, 0x2c1e015f ] # cmpwi r30, 0xD9\r\n" +
"        #- [ be32, 0x00785538, 0x2c1e015f ] # cmpwi r30, 0xD9\r\n" +
"        #- [ be32, 0x002651f4, 0x339cf470 ] # subic r28, r28, 0xb90\r\n" +
"\r\n" +
"        # Boss voice stuff\r\n" +
"\r\n" +
"        # Enable attack cue id on black mask voice set\r\n" +
"        - [ be32, 0x00ba90ec, 0x00cf0918 ]\r\n" +
"\r\n" +
"        # enable Intro BCD on all new encounters\r\n" +
"        - [ be32, 0x00788088, 0x40800098 ] # bge        0x00788120\r\n" +
"\r\n" +
"        # Disable Player Swordtrack loading\r\n" +
"        - [ be32, 0x00265cc, 0x38600000 ] # li   param_1,0x0\r\n" +
"\r\n" +
"        # Make Emergency Shift use Single GAP\r\n" +
"        - [ be32, 0x00626230, 0x428000cc ] # b LAB_006262fc\r\n" +
"\r\n" +
"        # Let enemies use baton pass anims\r\n" +
"        - [ be16, 0x006e686A, 999 ] # change limit to 999\r\n" +
"        #- [ be32, 0x00ba6250, 0x00cee6a0 ]\r\n" +
"        #- [ be32, 0x00ba6254, 0x00cee6a8 ]\r\n" +
"        - [ be32, 0x00ba376c, 0x00cee690 ]\r\n" +
"        - [ be32, 0x00ba3770, 0x00cee698 ]\r\n" +
"        # baton pass\r\n" +
"        - [ be32, 0x00BA379C, 0x00ced808 ]\r\n" +
"        - [ be32, 0x00BA37A0, 0x00ced810 ]\r\n" +
"\r\n" +
"        # Let enemies use guard animation\r\n" +
"        #- [ be32, 0x00ba341c, 0x00ced790 ] # 0x104 into anim vtable\r\n" +
"        - [ be32, 0x00ba3760, 0x00cee6a8 ] # 0x104 into anim vtable, use anim 37\r\n" +
"        # Kamoshida vtable\r\n" +
"        - [ be32, 0x00ba3AA8, 0x00cee6a8 ] # 0x104 into anim vtable, use anim 37\r\n" +
"\r\n" +
"        # Let enemies use dodge animation\r\n" +
"        #- [ be32, 0x00ba619c, 0x00cee670 ] # 0x104 into anim vtable \r\n" +
"        #- [ be32, 0x00ba61a0, 0x00cee678 ] # 0x104 into anim vtable\r\n" +
"\r\n" +
"        # Let enemies use AoA animations\r\n" +
"        #- [ be32, 0x00ba62e4, 0x00cee6b0 ] # AoA Start, 0x1D4 into anim vtable, anim 25\r\n" +
"        #- [ be32, 0x00ba62e8, 0x00cee6b8 ] # AoA End,   0x1D8 into anim vtable, anim 26\r\n" +
"        - [ be32, 0x00ba3830, 0x00cee6b0 ] # AoA Start, 0x1D4 into anim vtable, anim 25\r\n" +
"        - [ be32, 0x00ba3834, 0x00cee6b8 ] # AoA End,   0x1D8 into anim vtable, anim 26\r\n" +
"\r\n" +
"        # Use unique boss anims based on Count 500\r\n" +
"        - [ be32, 0x0075422c, 0x386001f4 ]\r\n" +
"        - [ be32, 0x00754230, 0x4baf7d2d ]\r\n" +
"        - [ be32, 0x00754238, 0x483d9430 ]\r\n" +
"        - [ be32, 0x00b2d668, 0x60700000 ]\r\n" +
"        - [ be32, 0x00b2d66c, 0x4bc26bd4 ]\r\n" +
"        - [ be32, 0x00754304, 0x483d936c ]\r\n" +
"        - [ be32, 0x00b2d670, 0x2c1e01c6 ]\r\n" +
"        - [ be32, 0x00b2d674, 0x2c900000 ]\r\n" +
"        - [ be32, 0x00b2d678, 0x40860008 ]\r\n" +
"        - [ be32, 0x00b2d67c, 0x48000014 ]\r\n" +
"        - [ be32, 0x00b2d680, 0x8061014c ]\r\n" +
"        - [ be32, 0x00b2d684, 0x42800018 ]\r\n" +
"        - [ be32, 0x00b2d688, 0x3a000000 ]\r\n" +
"        - [ be32, 0x00b2d68c, 0x4bc26cbc ]\r\n" +
"        - [ be32, 0x00b2d690, 0x41820008 ]\r\n" +
"        - [ be32, 0x00b2d694, 0x4bc26c74 ]\r\n" +
"        - [ be32, 0x00b2d698, 0x3a000003 ]\r\n" +
"        - [ be32, 0x00b2d69c, 0x4bc27378 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00754a40, 0x62040000 ]     \r\n" +
"        - [ be32, 0x006ecd0c, 0x60000000 ]  \r\n" +
"        - [ be32, 0x0078529c, 0x386001f4 ] \r\n" +
"        - [ be32, 0x007852a0, 0x4bac6cbc ] \r\n" +
"        - [ be32, 0x00af005c, 0x386001f4 ] \r\n" +
"        - [ be32, 0x00af0060, 0x4b75befc ] \r\n" +
"\r\n" +
"        - [ be32, 0x00716984, 0x48416d2c ] \r\n" +
"        - [ be32, 0x00b2d6b0, 0x386001f4 ] \r\n" +
"        - [ be32, 0x00b2d6b4, 0x4b71e8a9 ] \r\n" +
"        - [ be32, 0x00b2d6b8, 0x2c030000 ] \r\n" +
"        - [ be32, 0x00b2d6bc, 0x4bbe92cc ] \r\n" +
"\r\n" +
"        # apply Kamoshida anims vtable function\r\n" +
"        # to Akechi boss vtable\r\n" +
"        - [ be32, 0x00baaa7c, 0x00cf0d40 ]\r\n" +
"\r\n" +
"        # unlock custom anims 10 + X\r\n" +
"        - [ be32, 0x00ba3868, 0x00cee0b0 ]\r\n" +
"\r\n" +
"        # Skip DLC Check for new outfits\r\n" +
"        - [ be32, 0x0019b830, 0x60000000 ]\r\n" +
"        - [ be32, 0x0019b83c, 0x60000000 ]\r\n" +
"\r\n" +
"        # Increase red menu bg size\r\n" +
"        - [ bef32,0x4c1400, 2.00000000 ]\r\n" +
"        - [ bef32,0x4c4d9c, 2.00000000 ]\r\n" +
"        - [ be32, 0x4c4cd8, 0x60000000 ]\r\n" +
"\r\n" +
"        # Expand Active Skills to 2000\r\n" +
"        - [ be32, 0x000444ac, 0x2c1b07d0 ] # idk, have > 799 checks tho\r\n" +
"        - [ be32, 0x001d258c, 0x2c1f07d0 ]\r\n" +
"        - [ be32, 0x002613bc, 0x2c0307d0 ]\r\n" +
"        - [ be32, 0x00256850, 0x2c0307d0 ]\r\n" +
"        - [ be32, 0x0026149c, 0x2c1e07d0 ]\r\n" +
"        - [ be32, 0x00261598, 0x2c1e07d0 ]\r\n" +
"        - [ be32, 0x00449ff8, 0x2c0e0000 ]\r\n" +
"        - [ be32, 0x0051c130, 0x2c1c07d0 ]\r\n" +
"        - [ be32, 0x007dd768, 0x2c1f07d0 ]\r\n" +
"        - [ be32, 0x002586e4, 0x280307d0 ]\r\n" +
"        - [ be32, 0x006816f8, 0x280507d0 ]\r\n" +
"        - [ be32, 0x007e8398, 0x60000000 ]\r\n" +
"        - [ be32, 0x007e839c, 0x60000000 ]\r\n" +
"        - [ be32, 0x007e83a0, 0x60000000 ]\r\n" +
"        - [ be32, 0x007e83a4, 0x60000000 ]\r\n" +
"        - [ be32, 0x007f5bfc, 0x281d07d0 ]\r\n" +
"        - [ be32, 0x0080f09c, 0x60000000 ] # nametags\r\n" +
"        - [ be32, 0x0080f0a0, 0x60000000 ]\r\n" +
"        - [ be32, 0x0080f0a4, 0x281d07d0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x0082a010, 0x2c8307d0 ] # show skill > 799 in skill list\r\n" +
"        - [ be32, 0x00829e18, 0x2c8307d0 ]\r\n" +
"        - [ be32, 0x00829ea8, 0x2c8307d0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x002500BC, 0x60000000 ] # from GetSkillData, originally returns Segment0 if bigger than 799\r\n" +
"        - [ be32, 0x002500c0, 0x60000000 ]\r\n" +
"\r\n" +
"        # expanding dialogue cutins\r\n" +
"        - [ be64, 0xb8e17c, 0x305f6d61696e5f30 ]\r\n" +
"        - [ be64, 0xb8e184, 0x2f437574496e4d61 ]\r\n" +
"        - [ be64, 0xb8e18c, 0x696e5f305f313100 ] # 0_main_0/CutInMain_0_11\r\n" +
"        #\r\n" +
"        - [ be64, 0xb8e198, 0x305f6d61696e5f30 ]\r\n" +
"        - [ be64, 0xb8e1a0, 0x2f437574496e4d61 ]\r\n" +
"        - [ be64, 0xb8e1a8, 0x696e5f305f313200 ] # 0_main_0/CutInMain_0_12\r\n" +
"        #\r\n" +
"        - [ be64, 0xb8e1b8, 0x305f6d61696e5f30 ]\r\n" +
"        - [ be64, 0xb8e1c0, 0x2f437574496e4d61 ]\r\n" +
"        - [ be64, 0xb8e1c8, 0x696e5f305f313300 ] # 0_main_0/CutInMain_0_13\r\n" +
"        #\r\n" +
"        - [ be64, 0xb8e1d4, 0x305f6d61696e5f30 ]\r\n" +
"        - [ be64, 0xb8e1dc, 0x2f437574496e4d61 ]\r\n" +
"        - [ be64, 0xb8e1e4, 0x696e5f305f313400 ] # 0_main_0/CutInMain_0_14\r\n" +
"        # update count\r\n" +
"        - [ be32, 0x00df305c, 15 ]\r\n" +
"        # update pointer to new pointer list\r\n" +
"        - [ be32, 0x00df3060, 0x0074b128 ] #\r\n" +
"        # pointers to names\r\n" +
"        - [ be32, 0x0074b128, 0x00b81314 ] #\r\n" +
"        - [ be32, 0x0074b12C, 0x00b8132c ] #\r\n" +
"        - [ be32, 0x0074b130, 0x00b81344 ] #\r\n" +
"        - [ be32, 0x0074b134, 0x00b8135c ] #\r\n" +
"        - [ be32, 0x0074b138, 0x00b81374 ] #\r\n" +
"        - [ be32, 0x0074b13C, 0x00b8138c ] #\r\n" +
"        - [ be32, 0x0074b140, 0x00b813a4 ] #\r\n" +
"        - [ be32, 0x0074b144, 0x00b813bc ] #\r\n" +
"        - [ be32, 0x0074b148, 0x00b813d4 ] #\r\n" +
"        - [ be32, 0x0074b14C, 0x00b813ec ] #\r\n" +
"        - [ be32, 0x0074b150, 0x00b81404 ] #\r\n" +
"        - [ be32, 0x0074b154, 0x00b8e17c ] # Kasumi, 11\r\n" +
"        - [ be32, 0x0074b158, 0x00b8e198 ] # Sumire, 12\r\n" +
"        - [ be32, 0x0074b15C, 0x00b8e1b8 ] # Maruki, 13\r\n" +
"        - [ be32, 0x0074b160, 0x00b8e1d4 ] # Maruki, 14\r\n" +
"\r\n" +
"        # apply Akechi encounter code to encounters 830 and up\r\n" +
"        - [ be32, 0x00630848, 0x484fcea4 ] #   b       0x00b2d6ec\r\n" +
"        - [ be32, 0x00b2d6ec, 0x7bff0020 ] #   rldicl  r31, r31, 0x0, 0x20\r\n" +
"        - [ be32, 0x00b2d6f0, 0x2c04033E ] #   cmpwi   r4, 0x33E\r\n" +
"        - [ be32, 0x00b2d6f4, 0x40800008 ] #   bge     8\r\n" +
"        - [ be32, 0x00b2d6f8, 0x4bb03154 ] #   b       0x0063084c\r\n" +
"        - [ be32, 0x00b2d6fc, 0x4bb03ea8 ] #   b       0x006315a4\r\n" +
"        #\r\n" +
"        #- [ be32, 0x006a7fec, 0x4280ff68 ] #   b       0x006a7f54\r\n" +
"\r\n" +
"        # skip Joker Dying BCD\r\n" +
"        - [ be32, 0x0065cd34, 0x42802248 ] #  \r\n" +
"        # redirect dummy function into other dummy function\r\n" +
"        - [ be32, 0x00ba7c2c, 0x00cef708 ] #  \r\n" +
"        # Change battle game over conditional checks\r\n" +
"        - [ be32, 0x00875734, 0x482af955 ] #   WAIT_BATTLE\r\n" +
"        - [ be32, 0x00876410, 0x482aec79 ] #   CALL_EVENTBATTLE\r\n" +
"        - [ be32, 0x0087541c, 0x482afc6d ] #   CALL_FIELDBATTLE\r\n" +
"\r\n" +
"        # Agnes summon fix\r\n" +
"        # The game normally checks if Persona ID is specifically Johanna to do something\r\n" +
"        # to make this work with Agnes, we change the check to if Persona is NOT Anat\r\n" +
"        # this is needed because Makoto's bike animations are a special condition \r\n" +
"        - [ be32, 0x00285e94, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00285e98, 0x40820020 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x0067186c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00671870, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00671a00, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00671a04, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006750cc, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006750d0, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006752f0, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006752f4, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0068097c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00680980, 0x4182000c ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00687abc, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00687ac4, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0069ba94, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0069ba98, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0069c288, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0069c28c, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0069c358, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0069c35c, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006ae7d8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006ae7dc, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006aeaa8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006aeaac, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x006eceb4, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006eceb8, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006ed5d8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006ed5dc, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006edcbc, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006edcc0, 0x41820018 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006ee53c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006ee540, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006ef490, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006ef494, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x006ef924, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x006ef928, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x00701114, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00701118, 0x4182008c ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00701868, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0070186c, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0070e8d4, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0070e8d8, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0070f07c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0070f080, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0070fe0c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0070fe10, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x00714278, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0071427c, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x00716de0, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00716de4, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x007170b4, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x007170b8, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x0071e76c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0071e770, 0x40820008 ] #   bne        \r\n" +
"\r\n" +
"        - [ be32, 0x00755518, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00755520, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00755cf8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00755d00, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0075d708, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0075d70c, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0075df34, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0075df38, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00767d84, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00767d88, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00767f3c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00767f44, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0076886c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00768874, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0076a3e0, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0076a3e8, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0077163c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00771640, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00772040, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00772044, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x007787e4, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x007787e8, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0077901c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00779020, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00779300, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00779304, 0x41820008 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00780d88, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00780d90, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00781568, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00781570, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0078705c, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00787060, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00787740, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00787744, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0078ead8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0078eae0, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x0078f2d8, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x0078f2e0, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00793960, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00793968, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x00794230, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x00794238, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x007a20b0, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x007a20b8, 0x41820010 ] #   beq        \r\n" +
"\r\n" +
"        - [ be32, 0x007a2a28, 0x2c0300d8 ] #   cmpwi      r3, 0xd8\r\n" +
"        - [ be32, 0x007a2a30, 0x41820010 ] #   beq    \r\n" +
"\r\n" +
"        # Initial Persona\r\n" +
"        # Change Call of Chaos Loki from 210 to 240\r\n" +
"        # because Kasumi is initialized with 210\r\n" +
"        - [ be32, 0x007857a0, 0x386000f0 ]   #li         param_1,0xf0\r\n" +
"\r\n" +
"        #DAT_00b6644c PartyPanelSPDId_WaitBG\r\n" +
"        - [ be32, 0x0028e780, 0x30846448 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6644c, 0x00000001 ]\r\n" +
"        - [ be32, 0x00b66450, 0x00000002 ]\r\n" +
"        - [ be32, 0x00b66454, 0x00000003 ]\r\n" +
"        - [ be32, 0x00b66458, 0x00000004 ]\r\n" +
"        - [ be32, 0x00b6645c, 0x00000005 ]\r\n" +
"        - [ be32, 0x00b66460, 0x00000006 ]\r\n" +
"        - [ be32, 0x00b66464, 0x00000007 ]\r\n" +
"        - [ be32, 0x00b66468, 0x00000000 ]\r\n" +
"        - [ be32, 0x00b6646c, 0x00000008 ]\r\n" +
"        - [ be32, 0x00b66470, 0x00000029 ] #id 10 data\r\n" +
"\r\n" +
"        #DAT_00b66474 PartyPanelSPDId_WaitFG\r\n" +
"        - [ be32, 0x0028b420, 0x30636470 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66474, 0x0000003d ]\r\n" +
"        - [ be32, 0x00b66478, 0x0000003e ]\r\n" +
"        - [ be32, 0x00b6647c, 0x0000003f ]\r\n" +
"        - [ be32, 0x00b66480, 0x00000040 ]\r\n" +
"        - [ be32, 0x00b66484, 0x00000041 ]\r\n" +
"        - [ be32, 0x00b66488, 0x00000042 ]\r\n" +
"        - [ be32, 0x00b6648c, 0x00000043 ]\r\n" +
"        - [ be32, 0x00b66490, 0x00000000 ]\r\n" +
"        - [ be32, 0x00b66494, 0x00000044 ]\r\n" +
"        - [ be32, 0x00b66498, 0x00000025 ] #id 10 data\r\n" +
"\r\n" +
"        #DAT_00b6649c PartyPanelSPDId_TurnFG\r\n" +
"        - [ be32, 0x0028b440, 0x30636498 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6649c, 0x00000034 ]\r\n" +
"        - [ be32, 0x00b664a0, 0x00000035 ]\r\n" +
"        - [ be32, 0x00b664a4, 0x00000036 ]\r\n" +
"        - [ be32, 0x00b664a8, 0x00000037 ]\r\n" +
"        - [ be32, 0x00b664ac, 0x00000038 ]\r\n" +
"        - [ be32, 0x00b664b0, 0x00000039 ]\r\n" +
"        - [ be32, 0x00b664b4, 0x0000003a ]\r\n" +
"        - [ be32, 0x00b664b8, 0x00000000 ]\r\n" +
"        - [ be32, 0x00b664bc, 0x0000003b ]\r\n" +
"        - [ be32, 0x00b664c0, 0x00000027 ] #id 10 data\r\n" +
"\r\n" +
"        #DAT_00b664c4 BattleActivePP_PLGId_BG\r\n" +
"        - [ be32, 0x0028e51c, 0x308664c0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b664c4, 0x00000000 ]\r\n" +
"        - [ be32, 0x00b664c8, 0x00000001 ]\r\n" +
"        - [ be32, 0x00b664cc, 0x00000002 ]\r\n" +
"        - [ be32, 0x00b664d0, 0x00000003 ]\r\n" +
"        - [ be32, 0x00b664d4, 0x00000004 ]\r\n" +
"        - [ be32, 0x00b664d8, 0x00000005 ]\r\n" +
"        - [ be32, 0x00b664dc, 0x00000006 ]\r\n" +
"        - [ be32, 0x00b664e0, 0x00000000 ]\r\n" +
"        - [ be32, 0x00b664e4, 0x00000007 ]\r\n" +
"        - [ be32, 0x00b664e8, 0x00000008 ] #id 10 data\r\n" +
"\r\n" +
"        #DAT_00b6658c PartyHUDInactiveHPSPPos_BG1/2\r\n" +
"        - [ be32, 0x0028e628, 0x30846580 ]\r\n" +
"        - [ be32, 0x0028e6bc, 0x306365f8 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6658c, 87 ]\r\n" +
"        - [ be32, 0x00b66590, 82 ]\r\n" +
"        - [ be32, 0x00b66594, -5 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66598, 86 ]\r\n" +
"        - [ be32, 0x00b6659c, 85 ]\r\n" +
"        - [ be32, 0x00b665a0, -1 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665a4, 97 ]\r\n" +
"        - [ be32, 0x00b665a8, 89 ]\r\n" +
"        - [ be32, 0x00b665ac, -5 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665b0, 91 ]\r\n" +
"        - [ be32, 0x00b665b4, 84 ]\r\n" +
"        - [ be32, 0x00b665b8, 1 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665bc, 86 ]\r\n" +
"        - [ be32, 0x00b665c0, 81 ]\r\n" +
"        - [ be32, 0x00b665c4, -4 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665c8, 96 ]\r\n" +
"        - [ be32, 0x00b665cc, 88 ]\r\n" +
"        - [ be32, 0x00b665d0, -2 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665d4, 92 ]\r\n" +
"        - [ be32, 0x00b665d8, 86 ]\r\n" +
"        - [ be32, 0x00b665dc, -7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665e0, 0 ]\r\n" +
"        - [ be32, 0x00b665e4, 0 ]\r\n" +
"        - [ be32, 0x00b665e8, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b665ec, 90 ]\r\n" +
"        - [ be32, 0x00b665f0, 84 ]\r\n" +
"        - [ be32, 0x00b665f4, 0 ]\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b665f8, 92 ]\r\n" +
"        - [ be32, 0x00b665fc, 86 ]\r\n" +
"        - [ be32, 0x00b66600, -7 ]\r\n" +
"\r\n" +
"\r\n" +
"        - [ be32, 0x00b66604, 115 ]\r\n" +
"        - [ be32, 0x00b66608, 93 ]\r\n" +
"        - [ be32, 0x00b6660c, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66610, 115 ]\r\n" +
"        - [ be32, 0x00b66614, 89 ]\r\n" +
"        - [ be32, 0x00b66618, 1 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6661c, 121 ]\r\n" +
"        - [ be32, 0x00b66620, 99 ]\r\n" +
"        - [ be32, 0x00b66624, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66628, 110 ]\r\n" +
"        - [ be32, 0x00b6662c, 92 ]\r\n" +
"        - [ be32, 0x00b66630, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66634, 110 ]\r\n" +
"        - [ be32, 0x00b66638, 90 ]\r\n" +
"        - [ be32, 0x00b6663c, 5 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66640, 121 ]\r\n" +
"        - [ be32, 0x00b66644, 95 ]\r\n" +
"        - [ be32, 0x00b66648, -8 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6664c, 115 ]\r\n" +
"        - [ be32, 0x00b66650, 100 ]\r\n" +
"        - [ be32, 0x00b66654, 5 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66658, 0 ]\r\n" +
"        - [ be32, 0x00b6665c, 0 ]\r\n" +
"        - [ be32, 0x00b66660, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66664, 106 ]\r\n" +
"        - [ be32, 0x00b66668, 86 ]\r\n" +
"        - [ be32, 0x00b6666c, 0 ]\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66670, 115 ]\r\n" +
"        - [ be32, 0x00b66674, 100 ]\r\n" +
"        - [ be32, 0x00b66678, 5 ]\r\n" +
"\r\n" +
"        #DAT_00b6667c PartyHUDInactivePortraitPos_BG\r\n" +
"        - [ be32, 0x0028c3bc, 0x30636674 ]\r\n" +
"        - [ be32, 0x0028c518, 0x30636674 ]\r\n" +
"        - [ be32, 0x0028e758, 0x30636674 ]\r\n" +
"        - [ be32, 0x0028e760, 0x30a56678 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6667c, 11 ]\r\n" +
"        - [ be32, 0x00b66680, 14 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66684, 13 ]\r\n" +
"        - [ be32, 0x00b66688, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6668c, 17 ]\r\n" +
"        - [ be32, 0x00b66690, 20 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66694, 7 ]\r\n" +
"        - [ be32, 0x00b66698, 11 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6669c, 1 ]\r\n" +
"        - [ be32, 0x00b666a0, 16 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666a4, 16 ]\r\n" +
"        - [ be32, 0x00b666a8, 17 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666ac, 3 ]\r\n" +
"        - [ be32, 0x00b666b0, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666b4, 0 ]\r\n" +
"        - [ be32, 0x00b666b8, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666bc, 11 ]\r\n" +
"        - [ be32, 0x00b666c0, 15 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b666c4, 15 ]\r\n" +
"        - [ be32, 0x00b666c8, 16 ]\r\n" +
"\r\n" +
"        #DAT_00b666cc PartyHUDInactivePortraitPos_FG\r\n" +
"        - [ be32, 0x0028b454, 0x306366c4 ]\r\n" +
"        - [ be32, 0x0028b45c, 0x30a566c8 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666cc, 22 ]\r\n" +
"        - [ be32, 0x00b666d0, 23 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666d4, 21 ]\r\n" +
"        - [ be32, 0x00b666d8, 21 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666dc, 24 ]\r\n" +
"        - [ be32, 0x00b666e0, 28 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666e4, 22 ]\r\n" +
"        - [ be32, 0x00b666e8, 17 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666ec, 14 ]\r\n" +
"        - [ be32, 0x00b666f0, 23 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666f4, 24 ]\r\n" +
"        - [ be32, 0x00b666f8, 24 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b666fc, 11 ]\r\n" +
"        - [ be32, 0x00b66700, 22 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66704, 0 ]\r\n" +
"        - [ be32, 0x00b66708, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6670c, 13 ]\r\n" +
"        - [ be32, 0x00b66710, 22 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66714, 17 ]\r\n" +
"        - [ be32, 0x00b66718, 20 ]\r\n" +
"\r\n" +
"        #DAT_00b6671c PartyHUDInactiveHPSPPos_FG\r\n" +
"        - [ be32, 0x0028b738, 0x30846710 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6671c, 107 ]\r\n" +
"        - [ be32, 0x00b66720, 86 ]\r\n" +
"        - [ be32, 0x00b66724, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66728, 104 ]\r\n" +
"        - [ be32, 0x00b6672c, 86 ]\r\n" +
"        - [ be32, 0x00b66730, -3 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66734, 112 ]\r\n" +
"        - [ be32, 0x00b66738, 88 ]\r\n" +
"        - [ be32, 0x00b6673c, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66740, 106 ]\r\n" +
"        - [ be32, 0x00b66744, 82 ]\r\n" +
"        - [ be32, 0x00b66748, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6674c, 101 ]\r\n" +
"        - [ be32, 0x00b66750, 82 ]\r\n" +
"        - [ be32, 0x00b66754, -5 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66758, 111 ]\r\n" +
"        - [ be32, 0x00b6675c, 88 ]\r\n" +
"        - [ be32, 0x00b66760, 2 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66764, 108 ]\r\n" +
"        - [ be32, 0x00b66768, 87 ]\r\n" +
"        - [ be32, 0x00b6676c, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66770, 0 ]\r\n" +
"        - [ be32, 0x00b66774, 0 ]\r\n" +
"        - [ be32, 0x00b66778, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6677c, 104 ]\r\n" +
"        - [ be32, 0x00b66780, 86 ]\r\n" +
"        - [ be32, 0x00b66784, 1 ]\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66788, 108 ]\r\n" +
"        - [ be32, 0x00b6678c, 87 ]\r\n" +
"        - [ be32, 0x00b66790, 0 ]\r\n" +
"\r\n" +
"        #DAT_00b66824 PartyHUDNonBattlePortraitPos_FG\r\n" +
"        - [ be32, 0x00288e70, 0x3063681c ]\r\n" +
"        - [ be32, 0x00288e78, 0x30a56820 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66824, 11 ]\r\n" +
"        - [ be32, 0x00b66828, 9 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6682c, 8 ]\r\n" +
"        - [ be32, 0x00b66830, 14 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66834, 7 ]\r\n" +
"        - [ be32, 0x00b66838, 8 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6683c, 15 ]\r\n" +
"        - [ be32, 0x00b66840, 6 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66844, 13 ]\r\n" +
"        - [ be32, 0x00b66848, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6684c, 8 ]\r\n" +
"        - [ be32, 0x00b66850, 7 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66854, 8 ]\r\n" +
"        - [ be32, 0x00b66858, 22 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6685c, 0 ]\r\n" +
"        - [ be32, 0x00b66860, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66864, 2 ]\r\n" +
"        - [ be32, 0x00b66868, 7 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b6686c, 9 ]\r\n" +
"        - [ be32, 0x00b66870, 5 ]\r\n" +
"\r\n" +
"        #DAT_00b66874 PartyHUDNonBattlePortraitPartsId\r\n" +
"        - [ be32, 0x0028f7ac, 0x30846868 ]\r\n" +
"        - [ be32, 0x0028f57c, 0x3084686c ]\r\n" +
"        - [ be32, 0x00288ee0, 0x33a46870 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66874, 69 ]\r\n" +
"        - [ be32, 0x00b66878, 1 ]\r\n" +
"        - [ be32, 0x00b6687c, 77 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66880, 70 ]\r\n" +
"        - [ be32, 0x00b66884, 2 ]\r\n" +
"        - [ be32, 0x00b66888, 78 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6688c, 71 ]\r\n" +
"        - [ be32, 0x00b66890, 3 ]\r\n" +
"        - [ be32, 0x00b66894, 79 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66898, 72 ]\r\n" +
"        - [ be32, 0x00b6689c, 4 ]\r\n" +
"        - [ be32, 0x00b668a0, 80 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668a4, 73 ]\r\n" +
"        - [ be32, 0x00b668a8, 5 ]\r\n" +
"        - [ be32, 0x00b668ac, 81 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668b0, 74 ]\r\n" +
"        - [ be32, 0x00b668b4, 6 ]\r\n" +
"        - [ be32, 0x00b668b8, 82 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668bc, 75 ]\r\n" +
"        - [ be32, 0x00b668c0, 7 ]\r\n" +
"        - [ be32, 0x00b668c4, 83 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668c8, 0 ]\r\n" +
"        - [ be32, 0x00b668cc, 0 ]\r\n" +
"        - [ be32, 0x00b668d0, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668d4, 76 ]\r\n" +
"        - [ be32, 0x00b668d8, 8 ]\r\n" +
"        - [ be32, 0x00b668dc, 84 ]\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b668e0, 40 ]\r\n" +
"        - [ be32, 0x00b668e4, 41 ]\r\n" +
"        - [ be32, 0x00b668e8, 38 ]\r\n" +
"\r\n" +
"        #DAT_00b668ec PartyHUDNonBattlePortraitPosPerPanelPerMember\r\n" +
"        - [ be32, 0x002888dc, 0x310868e4 ]\r\n" +
"        - [ be32, 0x00288944, 0x30846934 ]\r\n" +
"        - [ be32, 0x00288a04, 0x30636984 ]\r\n" +
"        - [ be32, 0x00288a1c, 0x30a66988 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668ec, 22 ]\r\n" +
"        - [ be32, 0x00b668f0, -59 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668f4, 2 ]\r\n" +
"        - [ be32, 0x00b668f8, -65 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b668fc, 0 ]\r\n" +
"        - [ be32, 0x00b66900, -61 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66904, -6 ]\r\n" +
"        - [ be32, 0x00b66908, -67 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6690c, -6 ]\r\n" +
"        - [ be32, 0x00b66910, -61 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66914, -1 ]\r\n" +
"        - [ be32, 0x00b66918, -61 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6691c, -12 ]\r\n" +
"        - [ be32, 0x00b66920, -80 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66924, 0 ]\r\n" +
"        - [ be32, 0x00b66928, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6692c, -8 ]\r\n" +
"        - [ be32, 0x00b66930, -63 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66934, -5 ]\r\n" +
"        - [ be32, 0x00b66938, -50 ]\r\n" +
"\r\n" +
"\r\n" +
"        - [ be32, 0x00b6693c, 0 ]\r\n" +
"        - [ be32, 0x00b66940, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66944, -8 ]\r\n" +
"        - [ be32, 0x00b66948, -62 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6694c, -5 ]\r\n" +
"        - [ be32, 0x00b66950, -60 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66954, -16 ]\r\n" +
"        - [ be32, 0x00b66958, -59 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6695c, -17 ]\r\n" +
"        - [ be32, 0x00b66960, -56 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66964, -9 ]\r\n" +
"        - [ be32, 0x00b66968, -55 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6696c, -22 ]\r\n" +
"        - [ be32, 0x00b66970, -75 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66974, 0 ]\r\n" +
"        - [ be32, 0x00b66978, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6697c, -12 ]\r\n" +
"        - [ be32, 0x00b66980, -58 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66984, -12 ]\r\n" +
"        - [ be32, 0x00b66988, -60 ]\r\n" +
"\r\n" +
"\r\n" +
"        - [ be32, 0x00b6698c, 0 ]\r\n" +
"        - [ be32, 0x00b66990, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66994, -23 ]\r\n" +
"        - [ be32, 0x00b66998, -56 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b6699c, -25 ]\r\n" +
"        - [ be32, 0x00b669a0, -56 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669a4, -34 ]\r\n" +
"        - [ be32, 0x00b669a8, -57 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669ac, -37 ]\r\n" +
"        - [ be32, 0x00b669b0, -51 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669b4, -28 ]\r\n" +
"        - [ be32, 0x00b669b8, -52 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669bc, -39 ]\r\n" +
"        - [ be32, 0x00b669c0, -69 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669c4, 0 ]\r\n" +
"        - [ be32, 0x00b669c8, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b669cc, -27 ]\r\n" +
"        - [ be32, 0x00b669d0, -54 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b669d4, -20 ]\r\n" +
"        - [ be32, 0x00b669d8, -55 ]\r\n" +
"\r\n" +
"        #DAT_00b66a9c BattleActivePPPos\r\n" +
"        - [ be32, 0x00289e14, 0x312b6a7c ]\r\n" +
"        - [ be32, 0x0028b578, 0x30c36a7c ]\r\n" +
"        - [ be32, 0x0028b580, 0x31056a80 ]\r\n" +
"        - [ be32, 0x0028e508, 0x30646a84 ]\r\n" +
"        - [ be32, 0x0028e4f8, 0x30a56a88 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66a9c, 0xc29c0000 ] #id 1 spdX\r\n" +
"        - [ be32, 0x00b66aa0, 0xc2d00000 ] #id 1 spdY\r\n" +
"        - [ be32, 0x00b66aa4, 0xc2940000 ] #id 1 plgX\r\n" +
"        - [ be32, 0x00b66aa8, 0xc2cc0000 ] #id 1 plgY\r\n" +
"        - [ be32, 0x00b66aac, 0xc1500000 ] #id 1 ailmentTopX\r\n" +
"        - [ be32, 0x00b66ab0, 0xc2340000 ] #id 1 ailmentTopY\r\n" +
"        - [ be32, 0x00b66ab4, 0xc1e80000 ] #id 1 ailmentBottomX\r\n" +
"        - [ be32, 0x00b66ab8, 0x41e00000 ] #id 1 ailmentBottomY\r\n" +
"\r\n" +
"        - [ be32, 0x00b66abc, 0xc2a20000 ]\r\n" +
"        - [ be32, 0x00b66ac0, 0xc2ce0000 ]\r\n" +
"        - [ be32, 0x00b66ac4, 0xc2960000 ]\r\n" +
"        - [ be32, 0x00b66ac8, 0xc2c60000 ]\r\n" +
"        - [ be32, 0x00b66acc, 0x42100000 ]\r\n" +
"        - [ be32, 0x00b66ad0, 0xc2040000 ]\r\n" +
"        - [ be32, 0x00b66ad4, 0xc1a80000 ]\r\n" +
"        - [ be32, 0x00b66ad8, 0x42040000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66adc, 0xc29a0000 ]\r\n" +
"        - [ be32, 0x00b66ae0, 0xc2b80000 ]\r\n" +
"        - [ be32, 0x00b66ae4, 0xc2960000 ]\r\n" +
"        - [ be32, 0x00b66ae8, 0xc2ac0000 ]\r\n" +
"        - [ be32, 0x00b66aec, 0x41100000 ]\r\n" +
"        - [ be32, 0x00b66af0, 0xc2040000 ]\r\n" +
"        - [ be32, 0x00b66af4, 0xc1d00000 ]\r\n" +
"        - [ be32, 0x00b66af8, 0x41f00000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66afc, 0xc2a20000 ]\r\n" +
"        - [ be32, 0x00b66b00, 0xc2c80000 ]\r\n" +
"        - [ be32, 0x00b66b04, 0xc2900000 ]\r\n" +
"        - [ be32, 0x00b66b08, 0xc2c20000 ]\r\n" +
"        - [ be32, 0x00b66b0c, 0x41600000 ]\r\n" +
"        - [ be32, 0x00b66b10, 0xc2080000 ]\r\n" +
"        - [ be32, 0x00b66b14, 0xc1f80000 ]\r\n" +
"        - [ be32, 0x00b66b18, 0x41c00000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66b1c, 0xc29c0000 ]\r\n" +
"        - [ be32, 0x00b66b20, 0xc2ce0000 ]\r\n" +
"        - [ be32, 0x00b66b24, 0xc2920000 ]\r\n" +
"        - [ be32, 0x00b66b28, 0xc2c20000 ]\r\n" +
"        - [ be32, 0x00b66b2c, 0xc1800000 ]\r\n" +
"        - [ be32, 0x00b66b30, 0xc2140000 ]\r\n" +
"        - [ be32, 0x00b66b34, 0xc2000000 ]\r\n" +
"        - [ be32, 0x00b66b38, 0x42080000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66b3c, 0xc2ae0000 ]\r\n" +
"        - [ be32, 0x00b66b40, 0xc2de0000 ]\r\n" +
"        - [ be32, 0x00b66b44, 0xc2aa0000 ]\r\n" +
"        - [ be32, 0x00b66b48, 0xc2cc0000 ]\r\n" +
"        - [ be32, 0x00b66b4c, 0xc1500000 ]\r\n" +
"        - [ be32, 0x00b66b50, 0xc2340000 ]\r\n" +
"        - [ be32, 0x00b66b54, 0xc1c00000 ]\r\n" +
"        - [ be32, 0x00b66b58, 0x42100000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66b5c, 0xc2ac0000 ]\r\n" +
"        - [ be32, 0x00b66b60, 0xc2d80000 ]\r\n" +
"        - [ be32, 0x00b66b64, 0xc2a00000 ]\r\n" +
"        - [ be32, 0x00b66b68, 0xc2ca0000 ]\r\n" +
"        - [ be32, 0x00b66b6c, 0xc0800000 ]\r\n" +
"        - [ be32, 0x00b66b70, 0xc2340000 ]\r\n" +
"        - [ be32, 0x00b66b74, 0xc1e00000 ]\r\n" +
"        - [ be32, 0x00b66b78, 0x42080000 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66b7c, 0 ]\r\n" +
"        - [ be32, 0x00b66b80, 0 ]\r\n" +
"        - [ be32, 0x00b66b84, 0 ]\r\n" +
"        - [ be32, 0x00b66b88, 0 ]\r\n" +
"        - [ be32, 0x00b66b8c, 0 ]\r\n" +
"        - [ be32, 0x00b66b90, 0 ]\r\n" +
"        - [ be32, 0x00b66b94, 0 ]\r\n" +
"        - [ be32, 0x00b66b98, 0 ]\r\n" +
"\r\n" +
"        - [ be32, 0x00b66b9c, 0xc2a60000 ]\r\n" +
"        - [ be32, 0x00b66ba0, 0xc2d00000 ]\r\n" +
"        - [ be32, 0x00b66ba4, 0xc2b00000 ]\r\n" +
"        - [ be32, 0x00b66ba8, 0xc2c60000 ]\r\n" +
"        - [ be32, 0x00b66bac, 0x41400000 ]\r\n" +
"        - [ be32, 0x00b66bb0, 0xc1f80000 ]\r\n" +
"        - [ be32, 0x00b66bb4, 0xc1e00000 ]\r\n" +
"        - [ be32, 0x00b66bb8, 0x42100000 ]\r\n" +
"\r\n" +
"        #id 10 data\r\n" +
"        - [ be32, 0x00b66bbc, 0xc2a80000 ]\r\n" +
"        - [ be32, 0x00b66bc0, 0xc2e00000 ]\r\n" +
"        - [ be32, 0x00b66bc4, 0xc2940000 ]\r\n" +
"        - [ be32, 0x00b66bc8, 0xc2cc0000 ]\r\n" +
"        - [ be32, 0x00b66bcc, 0xc0800000 ]\r\n" +
"        - [ be32, 0x00b66bd0, 0xc2340000 ]\r\n" +
"        - [ be32, 0x00b66bd4, 0xc2200000 ]\r\n" +
"        - [ be32, 0x00b66bd8, 0xc1400000 ]\r\n" +
"\r\n" +
"        #AOA\r\n" +
"        - [ be64, 0xb8d920, 0x626174746c652f65 ]\r\n" +
"        - [ be64, 0xb8d928, 0x76656e742f424344 ]\r\n" +
"        - [ be64, 0xb8d930, 0x2f676f6f64627965 ]\r\n" +
"        - [ be64, 0xb8d938, 0x2f626b736b5f757a ]\r\n" +
"        - [ be64, 0xb8d940, 0x756b692e42434400 ] # battle/event/BCD/goodbye/bksk_uzuki.BCD\r\n" +
"\r\n" +
"        - [ be32, 0x006c46d4, 0x484805cc ] # trampoline\r\n" +
"\r\n" +
"        - [ be32, 0x00b44ca0, 0x63c30000 ] # ori      r3, r30, 0x0\r\n" +
"        - [ be32, 0x00b44ca4, 0x4bfa8c41 ] # bl       0x00aed8e4\r\n" +
"        - [ be32, 0x00b44ca8, 0x60000000 ] # nop\r\n" +
"        - [ be32, 0x00b44cac, 0x2c1f000a ] # cmpwi    r31, 0xA\r\n" +
"        - [ be32, 0x00b44cb0, 0x41820008 ] # beq      0x00b44cb8\r\n" +
"        - [ be32, 0x00b44cb4, 0x4bb7fa2c ] # b        0x006c46e0\r\n" +
"\r\n" +
"        - [ be32, 0x00b44cb8, 0x3c8000b9 ] # lis      r4, 0xB9\r\n" +
"        - [ be32, 0x00b44cbc, 0x30610d58 ] # addic    r3, r1, 0xd58\r\n" +
"        - [ be32, 0x00b44cc0, 0x3084d920 ] # subic    r4, r4, 0x26e0\r\n" +
"        - [ be32, 0x00b44cc4, 0x4bf909b9 ] # bl       sprintf\r\n" +
"        - [ be32, 0x00b44cc8, 0x60000000 ] # nop\r\n" +
"        - [ be32, 0x00b44ccc, 0x4bb7fb20 ] # b        0x006c47ec\r\n" +
"\r\n" +
"        #Camp PLG Id\r\n" +
"        #- [ be32, 0x00b73f58,  ]\r\n" +
"        - [ be32, 0x00b44d04, 0x76656e74 ]\r\n" +
"        - [ be32, 0x00b44d08, 0x2f424344 ]\r\n" +
"        - [ be32, 0x00b44d0c, 0x2f676f6f ]\r\n" +
"        - [ be32, 0x00b44d10, 0x64627965 ]  \r\n" +
"\r\n" +
"        # testing stuff\r\n" +
"        # update party checks to include kasumi\r\n" +
"        #- [ be32, 0x0014f404, 0x2c1b0009 ]\r\n" +
"        - [ be32, 0x0006eca8, 0x281b000B ]\r\n" +
"        - [ be32, 0x002530a0, 0x281F000A ]\r\n" +
"        - [ be32, 0x00661b5c, 0x2C19000C ]\r\n" +
"        - [ be32, 0x0024b264, 0x2c03000A ]\r\n" +
"        - [ be32, 0x0024b2c4, 0x2c06000A ]\r\n" +
"        - [ be32, 0x0024b2fc, 0x2c03000A ]\r\n" +
"        #- [ be32, 0x00250548, 0x2c1e0009 ]\r\n" +
"        - [ be32, 0x00425ae4, 0x2c1e000A ]\r\n" +
"        #- [ be32, 0x0063cfb0, 0x2c1d000A ]\r\n" +
"        - [ be32, 0x00661954, 0x281d000A ]\r\n" +
"        #- [ be32, 0x002591b4, 0x2c060009 ]\r\n" +
"        #- [ be32, 0x006716e8, 0x2c1c000A ]\r\n" +
"        - [ be32, 0x006717b4, 0x2c1f000A ]\r\n" +
"        #- [ be32, 0x00480ff8, 0x2c15000A ]\r\n" +
"        #- [ be32, 0x006716e8, 0x2c1d000A ]\r\n" +
"        # check later\r\n" +
"        #- [ be32, 0x00670fe8, 0x2c03000A ]\r\n" +
"        #- [ be32, 0x00670ff0, 0x2c030009 ]\r\n" +
"        #- [ be32, 0x0074d5ec, 0x3bc00009 ] # li  r30, 0x9\r\n" +
"\r\n" +
"        # Implement Follow Up Attack at Skill ID 1512\r\n" +
"        #- [ be32, 0x006ddd30, 0x633d0000 ] # ori r29, r25, 0x0\r\n" +
"        #- [ be32, 0x006ddd30, 0x4844f9d0 ] # b   0x00b2d700\r\n" +
"\r\n" +
"        #- [ be32, 0x00b2d700, 0x2c1d000a ] # cmpwi r29, 0xa\r\n" +
"        #- [ be32, 0x00b2d704, 0x4182000c ] # beq  0xC\r\n" +
"\r\n" +
"        #- [ be32, 0x00b2d708, 0x633d0000 ] # ori r29, r25, 0x0\r\n" +
"        #- [ be32, 0x00b2d70C, 0x4bbb0628 ] # b   0x006ddd34\r\n" +
"\r\n" +
"        #- [ be32, 0x00b2d710, 0x3ba005e8 ] # li  r29,0 x5e8\r\n" +
"        #- [ be32, 0x00b2d714, 0x4bbb0620 ] # b   0x006ddd34\r\n" +
"        #\r\n" +
"        - [ be32, 0x006715dc, 0x2c1c000A ] # Auto- support skills checks\r\n" +
"        #- [ be32, 0x0072d840, 0x2c1c000A ]\r\n" +
"        - [ be32, 0x006716e8, 0x2c1c000A ] # Auto- support skills checks\r\n" +
"        #- [ be32, 0x006717b4, 0x2c1f000A ]\r\n" +
"        #- [ be32, 0x00671758, 0x2c1f000A ]\r\n" +
"        # default new game tactics to act freely on everyone\r\n" +
"        # including Joker\r\n" +
"        #- [ be32, 0x0024bd40, 0x38800000 ] # li    r4, 0\r\n" +
"\r\n" +
"        # Make all party members always available\r\n" +
"        #- [ be32, 0x00425e20, 0x38600001 ]\r\n" +
"        # Raise Party Menu Limit to 10\r\n" +
"        #- [ be32, 0x00425e64, 0x2c1f000a ]\r\n" +
"        #- [ be32, 0x00425cf4, 0x2c1f000a ]\r\n" +
"        #- [ be32, 0x00425d90, 0x2c1f000a ]\r\n" +
"        #- [ be32, 0x00531dec, 0x2c1b000a ]\r\n" +
"        # kill futaba specific check\r\n" +
"        #- [ be32, 0x00425e40, 0x2c1d0012 ]\r\n" +
"        # fix menu size to fit 10\r\n" +
"        #- [ be32, 0x00333ccc, 0x38800016 ]\r\n" +
"        #- [ be32, 0x00333d68, 0x38800016 ]\r\n" +
"        #- [ be32, 0x00333ff0, 0x38800016 ]\r\n" +
"        # idk something about flags in a menu function\r\n" +
"        #- [ be32, 0x001bb858, 0x48971e40 ] # b    0x00b2d698\r\n" +
"        #- [ be32, 0x00b2d698, 0x38607038 ] # li   r3, 0x7038\r\n" +
"        #- [ be32, 0x00b2d69c, 0x38800000 ] # li   r4, 0\r\n" +
"        #- [ be32, 0x00b2d6a0, 0x4b732ca1 ] # bl   0x00260340\r\n" +
"        #- [ be32, 0x00b2d6a4, 0x60000000 ] # nop\r\n" +
"        #- [ be32, 0x00b2d6a8, 0xe80100c0 ] # ld   r0, 0xc0(r1)\r\n" +
"        #- [ be32, 0x00b2d6ac, 0x4b68e1b0 ] # b    0x001bb85c\r\n" +
"\r\n" +
"        # command menu model\r\n" +
"        - [ be32, 0x0083495c, 0x40800070 ] # bge\r\n" +
"        # persona menu\r\n" +
"        - [ be32, 0x00834688, 0x408000dc ] # bge\r\n" +
"        # item menu\r\n" +
"        - [ be32, 0x00834808, 0x40800070 ] # bge\r\n" +
"        # camp menu\r\n" +
"        - [ be32, 0x0045be50, 0x4bc10e7c ] # b  0x0006cccc\r\n" +
"        - [ be32, 0x0006cccc, 0x60000000 ] # nop\r\n" +
"        - [ be32, 0x0006ccd0, 0x2c17000a ] # cmpwi r23, 0xA\r\n" +
"        - [ be32, 0x0006ccd4, 0x40800008 ] # bge 8\r\n" +
"        - [ be32, 0x0006ccd8, 0x483ef17C ] # b  0x0045be54\r\n" +
"\r\n" +
"        - [ be32, 0x0006ccdc, 0x3ae00004 ] # b  li r23, 4\r\n" +
"\r\n" +
"        - [ be32, 0x0006cce0, 0x483ef178 ] # b  0x0045be54\r\n" +
"\r\n" +
"        # items/skills menu stuff\r\n" +
"        - [ be32, 0x00B73F58, 4 ] # black hp/sp background party view plg id\r\n" +
"        - [ be32, 0x00B73F84, 70 ] # char icon black silhouette plg id\r\n" +
"        - [ be32, 0x00B73FB0, 2 ] # white hp/sp background party view plg id\r\n" +
"        - [ be32, 0x00B73FDC, 69 ] # char icon white background plg id\r\n" +
"        - [ be32, 0x00B74008, 0 ] # black hp/sp foreground party view plg id\r\n" +
"        # position data\r\n" +
"        - [ bef32, 0x00B7423C, 124 ] # black hp/sp background party view position X Sumi\r\n" +
"        - [ bef32, 0x00B74240, 26 ] # black hp/sp background party view position Y Sumi\r\n" +
"        - [ bef32, 0x00B74244, 14 ] # Sumi char icon black silhouette X position\r\n" +
"        - [ bef32, 0x00B74248, 30 ] # Sumi char icon black silhouette Y position\r\n" +
"        - [ bef32, 0x00B7424C, 106 ] # white hp/sp background party view position X Sumi\r\n" +
"        - [ bef32, 0x00B74250, 40 ] # white hp/sp background party view position Y Sumi\r\n" +
"        - [ bef32, 0x00B74254, 25 ] # char icon white background pos X Sumi\r\n" +
"        - [ bef32, 0x00B74258, 43 ] # char icon white background pos Y Sumi\r\n" +
"        - [ bef32, 0x00B7425C, 96 ] # black hp/sp foreground party view position X Sumi\r\n" +
"        - [ bef32, 0x00B74260, 56 ] # black hp/sp foreground party view position Y Sumi\r\n" +
"        - [ bef32, 0x00B74264, 95 ] # spd chara icon X position Sumi\r\n" +
"        - [ bef32, 0x00B74268, 120 ] # spd chara icon Y position Sumi\r\n" +
"        - [ be32, 0x00B743D0, 819 ] # Sumi Camp SPD ID\r\n" +
"        #\r\n" +
"        - [ bef32, 0x00b7444c, 15 ] # grouped sumi x pos\r\n" +
"        - [ bef32, 0x00b74450, -4 ] # grouped sumi y pos\r\n" +
"        - [ bef32, 0x00b74454, -3 ] # grouped sumi rotation\r\n" +
"\r\n" +
"        - [ bef32, 0xb7452c, 252 ] # name sumi x pos\r\n" +
"        - [ bef32, 0xb74530, 76 ] # name sumi y pos\r\n" +
"\r\n" +
"        # stats menu party list background thing     \r\n" +
"        - [ be32, 0xd9de74, 0x44200000 ] # 640 (Y3)     \r\n" +
"        - [ be32, 0xd9de7c, 0x441a0000 ] # 616 (Y4)\r\n" +
"\r\n" +
"        #Render Info\r\n" +
"        #- [ be32, 0x00463D78, 0x3860000A ]\r\n" +
"        #- [ be32, 0x004638E4, 0x3860000A ]\r\n" +
"        #Black BG Size\r\n" +
"        #- [ be32, 0x0045a15c, 0x3860000A ]\r\n" +
"        #Number Selectable\r\n" +
"        #- [ be32, 0x0046F408, 0x38A0000A ]\r\n" +
"        #Number Selectable With L1/R1\r\n" +
"        #- [ be32, 0x0046ECA8, 0x38A0000A ]\r\n" +
"\r\n" +
"        # battle party member switch thing :tm:\r\n" +
"        - [ be32, 0x830d04, 0x4b83c09c ] # b 0x6cda0\r\n" +
"        - [ be32, 0x830d08, 0x4bfeadf5 ] # bl 0x81bafc\r\n" +
"        # Hook\r\n" +
"        - [ be32, 0x6cda0, 0x2c1b000a ] # cmpwi r27, 0xa\r\n" +
"        - [ be32, 0x6cda4, 0x40820008 ] # bne 0x6cdd4\r\n" +
"        - [ be32, 0x6cda8, 0x38800333 ] # li r4, 0x333 (kasumi party icon)\r\n" +
"        - [ be32, 0x6cdac, 0x487c3f5c ] # b 0x830d08\r\n" +
"\r\n" +
"        # Kasumi in battle party switcher (no crash)\r\n" +
"        - [ be32, 0x831cd8, 0x4b83b118 ] # b 0x6cdf0\r\n" +
"        - [ be32, 0x831ce0, 0x4b83b180 ] # b 0x6ce60\r\n" +
"\r\n" +
"        - [ be32, 0x6ce60, 0x2c13000a ] # cmpwi r19, 0xa\r\n" +
"        - [ be32, 0x6ce64, 0x40820008 ] # bne 0x6ce6c\r\n" +
"        - [ be32, 0x6ce68, 0x3ba00007 ] # li r29, 0x7\r\n" +
"        - [ be32, 0x6ce6c, 0x487c4e78 ] # b 0x831ce4\r\n" +
"\r\n" +
"        - [ be32, 0x6cdf0, 0x2c05000a ] # cmpwi r5, 0xa\r\n" +
"        - [ be32, 0x6cdf4, 0x40820028 ] # bne 0x6ce1c\r\n" +
"        - [ be32, 0x6cdf8, 0x2c0f0001 ] # cmpwi r15, 0x1\r\n" +
"        - [ be32, 0x6cdfc, 0x40820008 ] # bne\r\n" +
"        - [ be32, 0x6ce00, 0x38a00008 ] # li r5, 0x8\r\n" +
"        - [ be32, 0x6ce04, 0x2c0f0003 ] # cmpwi r15, 0x3\r\n" +
"        - [ be32, 0x6ce08, 0x40820008 ] # bne\r\n" +
"        - [ be32, 0x6ce0c, 0x38a00008 ] # li r5, 0x8\r\n" +
"        - [ be32, 0x6ce10, 0x2c0f0005 ] # cmpwi r15, 0x5\r\n" +
"        - [ be32, 0x6ce14, 0x40820008 ] # bne\r\n" +
"        - [ be32, 0x6ce18, 0x38a00008 ] # li r5, 0x8\r\n" +
"        - [ be32, 0x6ce1c, 0x79e60020 ] # rldicl r6, r15, 0x0, 0x20 ( original instruction )\r\n" +
"        - [ be32, 0x6ce20, 0x487c4ebc ] # b 0x831cdc\r\n" +
"\r\n" +
"        - [ be16, 0xb8a87c, 0x0084 ] # kasumi portrait x\r\n" +
"        - [ be16, 0xb8a87e, 0x0064 ] # kasumi portrait y\r\n" +
"\r\n" +
"        # ==================\r\n" +
"        # 10th character slot in stats menu\r\n" +
"        - [ be32, 0x0045be50, 0x4bc10e7c ] # b  0x0006cccc # HOOK #1\r\n" +
"        # Fix Party Icon crashing\r\n" +
"        # HOOK #1\r\n" +
"        - [ be32, 0x0006cccc, 0x60000000 ] # nop\r\n" +
"        - [ be32, 0x0006ccd0, 0x2c17000a ] # cmpwi r23, 0xA (check if kasumi)\r\n" +
"        - [ be32, 0x0006ccd4, 0x40800008 ] # bge 8\r\n" +
"        - [ be32, 0x0006ccd8, 0x483ef17C ] # b  0x0045be54\r\n" +
"        # This is Kasumi\r\n" +
"        - [ be32, 0x0006ccdc, 0x3ae00002 ] # li r23, 4 # set party icon to yusuke's\r\n" +
"        - [ be32, 0x6cce0, 0x483ef174 ] # b 0x45be54\r\n" +
"\r\n" +
"        - [ be32, 0x45718c, 0x935f05b4 ] # stw r26, 0x5b4(r31)\r\n" +
"        - [ be32, 0x45cb98, 0x80ba05b8 ] # lwz r5, 0x5b8(r26)\r\n" +
"        - [ be32, 0x467694, 0x307f05b8 ] # addic r3, 0x5b8(r31)\r\n" +
"        - [ be32, 0x4676e8, 0x309f05b8 ] # addic r4, 0x5b8(r31)\r\n" +
"        - [ be32, 0x4587d4, 0x337e0798 ] # addic r27, 0x798(r30)\r\n" +
"\r\n" +
"        - [ be32, 0x457acc, 0x33be05b8 ] # addic r29, 0x5b8(r30)\r\n" +
"        - [ be32, 0x4571b0, 0x90bf05b4 ] # stw r5, 0x5b4(r31)\r\n" +
"        - [ be32, 0x4572a8, 0x33bf05c8 ] # addic r29, 0x5c8(r31)\r\n" +
"        - [ be32, 0x45b7d8, 0x33a305b8 ] # addic r29, 0x5b8(r3)\r\n" +
"        - [ be32, 0x463924, 0x307805b8 ] # addic r3, 0x5b8(r24)\r\n" +
"        - [ be32, 0x463968, 0x807805b8 ] # lwz r3, 0x5b8(r24)\r\n" +
"        - [ be32, 0x4587d0, 0x335e05b8 ] # addic r26, 0x5b8(r30)\r\n" +
"        - [ be32, 0x463810, 0x80b805b8 ] # lwz r5, 0x5b8(r24)\r\n" +
"        - [ be32, 0x463b80, 0x807805b8 ] # lwz r3, 0x5b8(r24)\r\n" +
"        - [ be32, 0x463f64, 0x809805b8 ] # lwz r4, 0x5b8(r24)\r\n" +
"        - [ be32, 0x464090, 0x809805b8 ] # lwz r4, 0x5b8(r24)\r\n" +
"        - [ be32, 0x45bd1c, 0x306305c8 ] # addic r3, 0x5c8(r3)\r\n" +
"        # party icons when highlighted\r\n" +
"        - [ be32, 0x4640b4, 0xc2d80768 ] # lfs f22, 0x768(r24)\r\n" +
"        - [ be32, 0x4640bc, 0xc2b80774 ] # lfs f21, 0x774(r24)\r\n" +
"        - [ be32, 0x4640c0, 0xc2980780 ] # lfs f20, 0x780(r24)\r\n" +
"        - [ be32, 0x4640cc, 0xc278078c ] # lfs f19, 0x78c(r24)\r\n" +
"        # party icons bg black\r\n" +
"        - [ be32, 0x463e70, 0xc0d80768 ] # lfs f6, 0x768(r24)\r\n" +
"        - [ be32, 0x463e74, 0xc0f80774 ] # lfs f7, 0x774(r24)\r\n" +
"        - [ be32, 0x463e78, 0xc1380780 ] # lfs f9, 0x780(r24)\r\n" +
"        - [ be32, 0x463e7c, 0xc118078c ] # lfs f8, 0x78c(r24)\r\n" +
"        - [ be32, 0x4587b0, 0x2c1b000a ] # cmpwi r27, 0xa (stop kasumi drifting when selected)\r\n" +
"        # fix text highlight\r\n" +
"        - [ be32, 0x4575a4, 0x307f05c8 ] # addic r3, 0x5c8(r31)\r\n" +
"        - [ be32, 0x4575c8, 0x307f0740 ] # addic r3, 0x740(r31)\r\n" +
"        - [ be32, 0x4575e0, 0x307f075c ] # addic r3, 0x75c(r31)\r\n" +
"        - [ be32, 0x4572f4, 0x307f0740 ] # addic r3, 0x740(r31)\r\n" +
"        - [ be32, 0x457304, 0x307f075c ] # addic r3, 0x75c(r31)\r\n" +
"        # fix tactics bg + other vector elements\r\n" +
"        - [ be32, 0x455da8, 0xc03f05b4 ] # lfs f1, 0x5b4(r31)\r\n" +
"        - [ be32, 0x457260, 0xc05f05b4 ] # fls f2, 0x5b4(r31)\r\n" +
"        - [ be32, 0x457270, 0xd03f05b4 ] # stfs f1, 0x5b4(r31)\r\n" +
"        - [ be32, 0x457318, 0x307f08a4 ] # addic r3, 0x8a4(r31)\r\n" +
"\r\n" +
"        - [ be32, 0x45c31c, 0x339b0798 ] # addic r28, 0x798(r27)\r\n" +
"        - [ be32, 0x4569b4, 0x30830798 ] # addic r4, 0x798(r3)\r\n" +
"        - [ be32, 0x45767c, 0x30830798 ] # addic r4, 0x798(r3)\r\n" +
"        - [ be32, 0x457dcc, 0x33f60798 ] # addic r31, 0x798(r22)\r\n" +
"        - [ be32, 0x45a6c0, 0x309f0798 ] # addic r4, 0x798(r31)\r\n" +
"        - [ be32, 0x45c17c, 0x30630798 ] # addic r4, 0x798(r4)\r\n" +
"        - [ be32, 0x45cb38, 0x333a0798 ] # addic r25, 0x798(r26)\r\n" +
"        - [ be32, 0x4636c8, 0x30b80798 ] # addic r5, 0x798(r24)\r\n" +
"        - [ be32, 0x4647a8, 0x33b80798 ] # addic r29, 0x798(r24)\r\n" +
"        - [ be32, 0x45d80c, 0x335a0810 ] # addic r26, 0x810(r26)\r\n" +
"\r\n" +
"        - [ be32, 0x45dc30, 0x33e308a4 ] # addic r31, 0x8a4(r3)\r\n" +
"        - [ be32, 0x459f0c, 0x33da08a4 ] # addic r30, 0x8a4(r26)\r\n" +
"        - [ be32, 0x466d20, 0x33c608a4 ] # addic r30, 0x8a4(r6)\r\n" +
"\r\n" +
"        # fix persona/stats button disappearing in character wanted screen\r\n" +
"        - [ be32, 0x4631e8, 0x60000000 ] # nop\r\n" +
"        # - [ be32, 0x455ca4, 0x335f0d0c ] # addic r26, 0xd0c(r31)\r\n" +
"        # - [ be32, 0x4631a0, 0x33c30d0c ] # addic r30, 0xd0c(r3)\r\n" +
"\r\n" +
"        # correct party sticker position in stats menu wanted poster\r\n" +
"        - [ be32, 0x42a7d4, 0x38600001 ] # li r3, 0x1 (always show wanted portrait phantom thief name and arcana)\r\n" +
"        - [ bef32, 0xd9c2d4, -25 ] # sumi party sticker x\r\n" +
"        - [ bef32, 0xd9c2d8, 105 ] # sumi party sticker y\r\n" +
"        - [ bef32, 0xd9c2dc, 15 ] # sumi party sticker rotation\r\n" +
"\r\n" +
"        # Position Kasumi's party tactics window\r\n" +
"        - [ be32, 0x45deb4, 0x4bc0ef14 ] # b 0x6cdc8\r\n" +
"        - [ be32, 0x6cdc8, 0x2c170009 ] # cmpwi r23, 0x9\r\n" +
"        - [ be32, 0x6cdcc, 0x40820020 ] # bne 0x6cdcc\r\n" +
"        # replace f2 (1087) with 582 (y position)\r\n" +
"        - [ be32, 0x6cdd0, 0xec421028 ] # fsubs f2, f2, f2 # clear f2\r\n" +
"        # write into r18 address to float 582\r\n" +
"        - [ be32, 0x6cdd4, 0x3e40000f ] # lis r18, 0xf\r\n" +
"        - [ be32, 0x6cdd8, 0x6252d3e4 ] # ori r18, r18, 0xd3ef\r\n" +
"        # value in r18 should now be 0x127ff0 (the address contains 612 as a float)\r\n" +
"        - [ be32, 0x6cddc, 0xc0520000 ] # lfs f2, 0x0(r18) # load 612 into f2\r\n" +
"        # copy to f26\r\n" +
"        - [ be32, 0x6cde0, 0xef5ad028 ] # fsubs f26, f26, f26 # clear f26\r\n" +
"        - [ be32, 0x6cde4, 0xff42d02a ] # fadd f26, f2, f26 # move f2 value to f26\r\n" +
"\r\n" +
"        - [ be32, 0x6cde8, 0x3a400000 ] # li r18, 0x0\r\n" +
"        - [ be32, 0x6cdec, 0x483f10cc ] # b 0x45deb8\r\n" +
"        # ==================\r\n" +
"\r\n" +
"        # ==================\r\n" +
"        # kasumi UI in battle attack menu (WIP)\r\n" +
"\r\n" +
"        # Show Action Button Names (e.g Persona, Item)\r\n" +
"        - [ be32, 0x846820, 0x4b826500 ] # b 0x6cd20\r\n" +
"        - [ be32, 0x6cd20, 0x3d000001 ] # lis r8, 0x1\r\n" +
"        - [ be32, 0x6cd24, 0x61080454 ] # ori r8, 0x454(r8)\r\n" +
"        - [ be32, 0x6cd28, 0xc0280000 ] # lfs f1, 0x0(r8) # load 0.8 into f1\r\n" +
"        - [ be32, 0x6cd2c, 0x61080410 ] # ori r8, 0x410(r8)\r\n" +
"        - [ be32, 0x6cd30, 0xc0680000 ] # lfs f3, 0x0(r8) # load 1 into f3\r\n" +
"        - [ be32, 0x6cd34, 0x39000010 ] # li r8, 0x10\r\n" +
"        - [ be32, 0x6cd38, 0x63840000 ] # ori r4, 0x0(r28) (original instruction)\r\n" +
"        - [ be32, 0x6cd3c, 0x487d9ae8 ] # b 0x846824\r\n" +
"\r\n" +
"        # Show Action Button Descriptions\r\n" +
"        - [ be32, 0x846ac8, 0x4b826278 ] # b 0x6cd40\r\n" +
"        - [ be32, 0x6cd40, 0x3d000001 ] # lis r8, 0x1\r\n" +
"        - [ be32, 0x6cd44, 0x61080410 ] # ori r8, 0x410(r8)\r\n" +
"        - [ be32, 0x6cd48, 0xc0680000 ] # lfs f3, 0x0(r8) # load 1 into f3\r\n" +
"        - [ be32, 0x6cd4c, 0x39000010 ] # li r8, 0x10\r\n" +
"        - [ be32, 0x6cd50, 0xefbd06b2 ] # fmuls f29, f29, f26 (original instruction)\r\n" +
"        - [ be32, 0x6cd54, 0x487d9d78 ] # b 0x846acc\r\n" +
"        # ==================\r\n" +
"\r\n" +
"        # 0x846500 - order description\r\n" +
"        # 0x8464d4 - order names\r\n" +
"\r\n" +
"        # 0x838f70 - gun description\r\n" +
"        # 0x838d00 - gun buttons and names\r\n" +
"\r\n" +
"        # 10th character slot in equip menu\r\n" +
"        # Show text highlight properly with 10th slot\r\n" +
"\r\n" +
"        - [ be32, 0x475cc0, 0x4bbf70b1 ] # bl 0x6cd70\r\n" +
"        - [ be32, 0x475d04, 0x4bbf706d ] # bl 0x6cd70\r\n" +
"        - [ be32, 0x475d6c, 0x4bbf7005 ] # bl 0x6cd70\r\n" +
"\r\n" +
"        - [ be32, 0x6cd70, 0xa07f0032 ] # lhz r3, 0x32(r31) # original instruction\r\n" +
"        - [ be32, 0x6cd74, 0x2c03000a ] # cmpwi r3, 0xa\r\n" +
"        - [ be32, 0x6cd78, 0x40820008 ] # bne 0x6cd80\r\n" +
"        - [ be32, 0x6cd7c, 0x3063ffff ] # subic r3, r3, 0x1\r\n" +
"        - [ be32, 0x6cd80, 0x4e800020 ] # blr\r\n" +
"      \r\n" +
"       \r\n" +
"PPU-e72e715d646a94770d1902364bc66fe33b1b6606:\r\n" +
"  Mod SPRX:\r\n" +
"    Games:\r\n" +
"      \"Persona 5\":\r\n" +
"        BLES02247: [ All ]\r\n" +
"        NPEB02436: [ All ]\r\n" +
"        BLUS31604: [ All ]\r\n" +
"        NPUB31848: [ All ]\r\n" +
"    Author: TGE\r\n" +
"    Notes: \r\n" +
"    Patch Version: 2.0.1\r\n" +
"    Patch:\r\n" +
"      - [ be32, 0xB4669C, 0x26090058 ] # replace _sys_heap_delete_heap with sys_prx_load_module\r\n" +
"      - [ be32, 0xB46678, 0x9f18429d ] # replace _sys_heap_malloc with sys_prx_start_module\r\n" +
"      - [ byte, 0xB4695F, 0 ]          # set cellSail import count to 0\r\n" +
"\r\n" +
"      # inject loader code into main\r\n" +
"      # bin2rpcs3patch begin shk_elf_loader_P5\r\n" +
"      - [ be32, 0x10250, 0x48a2bc21 ]\r\n" +
"      - [ be32, 0xa3be70, 0xf821ff81 ]\r\n" +
"      - [ be32, 0xa3be74, 0x7c0802a6 ]\r\n" +
"      - [ be32, 0xa3be78, 0xf8010090 ]\r\n" +
"      - [ be32, 0xa3be7c, 0xf84100a8 ]\r\n" +
"      - [ be32, 0xa3be80, 0x3c6000a4 ]\r\n" +
"      - [ be32, 0xa3be84, 0x3863bed0 ]\r\n" +
"      - [ be32, 0xa3be88, 0x38800000 ]\r\n" +
"      - [ be32, 0xa3be8c, 0x38a00000 ]\r\n" +
"      - [ be32, 0xa3be90, 0x48109fcd ]\r\n" +
"      - [ be32, 0xa3be94, 0x7c6307b4 ]\r\n" +
"      - [ be32, 0xa3be98, 0x38800000 ]\r\n" +
"      - [ be32, 0xa3be9c, 0x38a00000 ]\r\n" +
"      - [ be32, 0xa3bea0, 0x38c10070 ]\r\n" +
"      - [ be32, 0xa3bea4, 0x38e00000 ]\r\n" +
"      - [ be32, 0xa3bea8, 0x39000000 ]\r\n" +
"      - [ be32, 0xa3beac, 0x48109e91 ]\r\n" +
"      - [ be32, 0xa3beb0, 0xe8010090 ]\r\n" +
"      - [ be32, 0xa3beb4, 0xe84100a8 ]\r\n" +
"      - [ be32, 0xa3beb8, 0x38210080 ]\r\n" +
"      - [ be32, 0xa3bebc, 0x7c0803a6 ]\r\n" +
"      - [ be32, 0xa3bec0, 0x4e800020 ]\r\n" +
"      - [ be32, 0xa3bec4, 0x60000000 ]\r\n" +
"      - [ be32, 0xa3bec8, 0x60000000 ]\r\n" +
"      - [ be32, 0xa3becc, 0x60000000 ]\r\n" +
"      - [ be32, 0xa3bed0, 0x2f617070 ]\r\n" +
"      - [ be32, 0xa3bed4, 0x5f686f6d ]\r\n" +
"      - [ be32, 0xa3bed8, 0x652f6d6f ]\r\n" +
"      - [ be32, 0xa3bedc, 0x642e7370 ]\r\n" +
"      - [ be32, 0xa3bee0, 0x72780000 ]\r\n" +
"      - [ be32, 0xa3bee4, 0x0 ]\r\n" +
"      - [ be32, 0xa3bee8, 0x0 ]\r\n" +
"      - [ be32, 0xa3beec, 0x0 ]\r\n" +
"      # bin2rpcs3patch end\r\n" +
"\r\n" +
"      # bin2rpcs3patch begin shk_elf_inject_P5\r\n" +
"      - [ be32, 0xa3be6c, 0x480000dc ]\r\n" +
"      - [ be32, 0x9209b0, 0x4811b5a0 ]\r\n" +
"      - [ be32, 0x6cf04, 0x489cf054 ]\r\n" +
"      - [ be32, 0x10db4, 0x48a2b1ac ]\r\n" +
"      - [ be32, 0x1e9cfc, 0x4885226c ]\r\n" +
"      - [ be32, 0x1e9d54, 0x4885221c ]\r\n" +
"      - [ be32, 0x1e9d28, 0x48852250 ]\r\n" +
"      - [ be32, 0x1edff8, 0x4884df88 ]\r\n" +
"      - [ be32, 0x1ee000, 0x4884df88 ]\r\n" +
"      - [ be32, 0x24ba4c, 0x487f0544 ]\r\n" +
"      - [ be32, 0x24bf5c, 0x487f003c ]\r\n" +
"      - [ be32, 0x7ba410, 0x48281b90 ]\r\n" +
"      - [ be32, 0x7ba448, 0x48281b60 ]\r\n" +
"      - [ be32, 0x74c12c, 0x482efe84 ]\r\n" +
"      - [ be32, 0x74b124, 0x482f0e94 ]\r\n" +
"      - [ be32, 0x1c2c74, 0x4887934c ]\r\n" +
"      - [ be32, 0x118280, 0x48923d48 ]\r\n" +
"      - [ be32, 0x426ab8, 0x48615518 ]\r\n" +
"      - [ be32, 0x735164, 0x48306e74 ]\r\n" +
"      - [ be32, 0x967abc, 0x480d4524 ]\r\n" +
"      - [ be32, 0x190ac, 0x48a22f3c ]\r\n" +
"      - [ be32, 0x877b68, 0x481c4488 ]\r\n" +
"      - [ be32, 0xb25390, 0x4bf16c68 ]\r\n" +
"      - [ be32, 0xb2d664, 0x4bf0e99c ]\r\n" +
"      - [ be32, 0x39b74, 0x48a02494 ]\r\n" +
"      - [ be32, 0x62dfdc, 0x4840e034 ]\r\n" +
"      - [ be32, 0x264950, 0x487d76c8 ]\r\n" +
"      - [ be32, 0x2636dc, 0x487d8944 ]\r\n" +
"      - [ be32, 0x263728, 0x487d8900 ]\r\n" +
"      - [ be32, 0x263660, 0x487d89d0 ]\r\n" +
"      - [ be32, 0x2637ac, 0x487d888c ]\r\n" +
"      - [ be32, 0x263700, 0x487d8940 ]\r\n" +
"      - [ be32, 0x263714, 0x487d8934 ]\r\n" +
"      - [ be32, 0x263df8, 0x487d8258 ]\r\n" +
"      - [ be32, 0x511d6c, 0x4852a2ec ]\r\n" +
"      - [ be32, 0x74a3e8, 0x482f1c78 ]\r\n" +
"      - [ be32, 0x74a378, 0x482f1cf0 ]\r\n" +
"      - [ be32, 0x10fca4, 0x4892c3cc ]\r\n" +
"      - [ be32, 0xb20618, 0x4bf1ba60 ]\r\n" +
"      - [ be32, 0x1e9ac0, 0x488525c0 ]\r\n" +
"      - [ be32, 0x1e9b1c, 0x4885256c ]\r\n" +
"      - [ be32, 0x1e9be0, 0x488524b0 ]\r\n" +
"      - [ be32, 0x1e9b7c, 0x4885251c ]\r\n" +
"      - [ be32, 0x26b390, 0x487d0d10 ]\r\n" +
"      - [ be32, 0x26b360, 0x487d0d48 ]\r\n" +
"      - [ be32, 0x26b2b0, 0x487d0e00 ]\r\n" +
"      - [ be32, 0x26b2e0, 0x487d0dd8 ]\r\n" +
"      - [ be32, 0x26b320, 0x487d0da0 ]\r\n" +
"      - [ be32, 0x26aff0, 0x487d10d8 ]\r\n" +
"      - [ be32, 0x26b094, 0x487d103c ]\r\n" +
"      - [ be32, 0x26b148, 0x487d0f90 ]\r\n" +
"      - [ be32, 0x26b1fc, 0x487d0ee4 ]\r\n" +
"      - [ be32, 0x72360c, 0x48318adc ]\r\n" +
"      - [ be32, 0x114c7c, 0x48927474 ]\r\n" +
"      - [ be32, 0xac0a6c, 0x4bf7b68c ]\r\n" +
"      - [ be32, 0x785578, 0x482b6b88 ]\r\n" +
"      - [ be32, 0x7852a4, 0x482b6e64 ]\r\n" +
"      - [ be32, 0xb24b74, 0x4bf1759c ]\r\n" +
"      - [ be32, 0x3a5d8, 0x48a01b40 ]\r\n" +
"      - [ be32, 0x3a618, 0x48a01b08 ]\r\n" +
"      - [ be32, 0x3a658, 0x48a01ad0 ]\r\n" +
"      - [ be32, 0x3a698, 0x48a01a98 ]\r\n" +
"      - [ be32, 0x425b0c, 0x4861662c ]\r\n" +
"      - [ be32, 0x114b74, 0x489275cc ]\r\n" +
"      - [ be32, 0xab8ed4, 0x4bf83274 ]\r\n" +
"      - [ be32, 0x3735d8, 0x486c8b78 ]\r\n" +
"      - [ be32, 0x630060, 0x4840c0f8 ]\r\n" +
"      - [ be32, 0x263b94, 0x487d85cc ]\r\n" +
"      - [ be32, 0x74d250, 0x482eef18 ]\r\n" +
"      - [ be32, 0x3b9644, 0x48682b2c ]\r\n" +
"      - [ be32, 0x74aac0, 0x482f16b8 ]\r\n" +
"      - [ be32, 0x1ee1bc, 0x4884dfc4 ]\r\n" +
"      - [ be32, 0xb1c1a0, 0x4bf1ffe8 ]\r\n" +
"      - [ be32, 0xb1c398, 0x4bf1fdf8 ]\r\n" +
"      - [ be32, 0xb1c610, 0x4bf1fb88 ]\r\n" +
"      - [ be32, 0xb20ec8, 0x4bf1b2d8 ]\r\n" +
"      - [ be32, 0xb1ca18, 0x4bf1f790 ]\r\n" +
"      - [ be32, 0xb21980, 0x4bf1a830 ]\r\n" +
"      - [ be32, 0xb21bf8, 0x4bf1a5c0 ]\r\n" +
"      - [ be32, 0xb21e28, 0x4bf1a398 ]\r\n" +
"      - [ be32, 0xb22138, 0x4bf1a090 ]\r\n" +
"      - [ be32, 0xb22f60, 0x4bf19270 ]\r\n" +
"      - [ be32, 0xb1bf38, 0x4bf202a0 ]\r\n" +
"      - [ be32, 0xaf3cb0, 0x4bf48530 ]\r\n" +
"      - [ be32, 0x1cf704, 0x4886cae4 ]\r\n" +
"      - [ be32, 0x829ce8, 0x48212508 ]\r\n" +
"      - [ be32, 0x43fac, 0x489f824c ]\r\n" +
"      - [ be32, 0x262258, 0x487d9fa8 ]\r\n" +
"      - [ be32, 0x259658, 0x487e2bb0 ]\r\n" +
"      - [ be32, 0x252a10, 0x487e9800 ]\r\n" +
"      - [ be32, 0x264708, 0x487d7b10 ]\r\n" +
"      - [ be32, 0x263580, 0x487d8ca0 ]\r\n" +
"      - [ be32, 0x2635a0, 0x487d8c88 ]\r\n" +
"      - [ be32, 0x745e28, 0x482f6408 ]\r\n" +
"      - [ be32, 0x256830, 0x487e5a08 ]\r\n" +
"      - [ be32, 0x25b888, 0x487e09b8 ]\r\n" +
"      - [ be32, 0x25b740, 0x487e0b08 ]\r\n" +
"      - [ be32, 0x25b7b8, 0x487e0a98 ]\r\n" +
"      - [ be32, 0x24bb54, 0x487f0704 ]\r\n" +
"      - [ be32, 0x661220, 0x483db040 ]\r\n" +
"      - [ be32, 0x338a04, 0x48703864 ]\r\n" +
"      - [ be32, 0x7ed620, 0x4824ec50 ]\r\n" +
"      - [ be32, 0x7af1c0, 0x4828d0b8 ]\r\n" +
"      - [ be32, 0x784d18, 0x482b7568 ]\r\n" +
"      - [ be32, 0x3a6e4, 0x48a01ba4 ]\r\n" +
"      - [ be32, 0x3a70c, 0x48a01b84 ]\r\n" +
"      - [ be32, 0x25906c, 0x487e322c ]\r\n" +
"      - [ be32, 0x435c0, 0x489f8ce0 ]\r\n" +
"      - [ be32, 0xb24f84, 0x4bf17324 ]\r\n" +
"      - [ be32, 0xb1bd50, 0x4bf20560 ]\r\n" +
"      - [ be32, 0xb25348, 0x4bf16f70 ]\r\n" +
"      - [ be32, 0x74b294, 0x482f102c ]\r\n" +
"      - [ be32, 0xb24938, 0x4bf17990 ]\r\n" +
"      - [ be32, 0x60b90, 0x489db740 ]\r\n" +
"      - [ be32, 0x4b24c, 0x489f108c ]\r\n" +
"      - [ be32, 0x4951c, 0x489f2dc4 ]\r\n" +
"      - [ be32, 0xbee20, 0x4897d4c8 ]\r\n" +
"      - [ be32, 0x927d50, 0x481145a0 ]\r\n" +
"      - [ be32, 0x6ccc8, 0x489cf630 ]\r\n" +
"      - [ be32, 0x2625d4, 0x487d9d2c ]\r\n" +
"      - [ be32, 0x45d24, 0x489f65e4 ]\r\n" +
"      - [ be32, 0xb2cee8, 0x4bf0f428 ]\r\n" +
"      - [ be32, 0x332b4c, 0x487097cc ]\r\n" +
"      - [ be32, 0x4eaca4, 0x4855167c ]\r\n" +
"      - [ be32, 0x5528f8, 0x484e9a30 ]\r\n" +
"      - [ be32, 0x244250, 0x487f80e0 ]\r\n" +
"      - [ be32, 0x23c070, 0x488002c8 ]\r\n" +
"      - [ be32, 0xb0f558, 0x4bf2cde8 ]\r\n" +
"      - [ be32, 0xb0f5e8, 0x4bf2cd60 ]\r\n" +
"      - [ be32, 0xaff500, 0x4bf3ce50 ]\r\n" +
"      - [ be32, 0xaff590, 0x4bf3cdc8 ]\r\n" +
"      - [ be32, 0x786a88, 0x482b58d8 ]\r\n" +
"      - [ be32, 0x49eb90, 0x4859d7d8 ]\r\n" +
"      - [ be32, 0x49ee38, 0x4859d538 ]\r\n" +
"      - [ be32, 0x3e8ff8, 0x48653380 ]\r\n" +
"      - [ be32, 0x6a75c4, 0x48394dbc ]\r\n" +
"      - [ be32, 0xb25084, 0x4bf17304 ]\r\n" +
"      - [ be32, 0xb25088, 0x4bf17308 ]\r\n" +
"      - [ be32, 0x650700, 0x483ebc98 ]\r\n" +
"      - [ be32, 0xb18368, 0x4bf24038 ]\r\n" +
"      - [ be32, 0xb190a8, 0x4bf23300 ]\r\n" +
"      - [ be32, 0xb192e8, 0x4bf230c8 ]\r\n" +
"      - [ be32, 0x5a4584, 0x48497e34 ]\r\n" +
"      - [ be32, 0xafc7f0, 0x4bf3fbd0 ]\r\n" +
"      - [ be32, 0x6c9c60, 0x48372768 ]\r\n" +
"      - [ be32, 0x917934, 0x48124a9c ]\r\n" +
"      - [ be32, 0xb00cc8, 0x4bf3b710 ]\r\n" +
"      - [ be32, 0xafdd78, 0x4bf3e668 ]\r\n" +
"      - [ be32, 0xafddb8, 0x4bf3e630 ]\r\n" +
"      - [ be32, 0x4e392c, 0x48558ac4 ]\r\n" +
"      - [ be32, 0x425de0, 0x48616618 ]\r\n" +
"      - [ be32, 0x425c80, 0x48616780 ]\r\n" +
"      - [ be32, 0x34e128, 0x486ee2e0 ]\r\n" +
"      - [ be32, 0x60dd98, 0x4842e678 ]\r\n" +
"      - [ be32, 0x425d20, 0x486166f8 ]\r\n" +
"      - [ be32, 0x548c8c, 0x484f3794 ]\r\n" +
"      - [ be32, 0x24beac, 0x487f057c ]\r\n" +
"      - [ be32, 0x24bef8, 0x487f0538 ]\r\n" +
"      - [ be32, 0x475e10, 0x485c6628 ]\r\n" +
"      - [ be32, 0x47de54, 0x485be5ec ]\r\n" +
"      - [ be32, 0x449c6c, 0x485f27dc ]\r\n" +
"      - [ be32, 0x47f91c, 0x485bcb34 ]\r\n" +
"      - [ be32, 0x480cc0, 0x485bb798 ]\r\n" +
"      - [ be32, 0x44a5d8, 0x485f1e88 ]\r\n" +
"      - [ be32, 0x397f4c, 0x486a451c ]\r\n" +
"      - [ be32, 0x59bb98, 0x484a08d8 ]\r\n" +
"      - [ be32, 0x5a7098, 0x484953e0 ]\r\n" +
"      - [ be32, 0x597740, 0x484a4d40 ]\r\n" +
"      - [ be32, 0x5a6b78, 0x48495910 ]\r\n" +
"      - [ be32, 0x5a5130, 0x48497360 ]\r\n" +
"      - [ be32, 0x260340, 0x487dc158 ]\r\n" +
"      - [ be32, 0x503d0, 0x489ec0d0 ]\r\n" +
"      - [ be32, 0x2677a4, 0x487d4d04 ]\r\n" +
"      - [ be32, 0x263e20, 0x487d8690 ]\r\n" +
"      - [ be32, 0x10f0d4, 0x4892d3e4 ]\r\n" +
"      - [ be32, 0x44f7ac, 0x485ecd14 ]\r\n" +
"      - [ be32, 0x44f8e0, 0x485ecbe8 ]\r\n" +
"      - [ be32, 0x487c58, 0x485b4878 ]\r\n" +
"      - [ be32, 0xa3bef0, 0xf821ff81 ]\r\n" +
"      - [ be32, 0xa3bef4, 0xfbe10078 ]\r\n" +
"      - [ be32, 0xa3bef8, 0x7fe802a6 ]\r\n" +
"      - [ be32, 0xa3befc, 0xfbe10090 ]\r\n" +
"      - [ be32, 0xa3bf00, 0x3fe000ce ]\r\n" +
"      - [ be32, 0xa3bf04, 0x63ff2cb8 ]\r\n" +
"      - [ be32, 0xa3bf08, 0x83ff0000 ]\r\n" +
"      - [ be32, 0xa3bf0c, 0x7fe0fa14 ]\r\n" +
"      - [ be32, 0xa3bf10, 0x83ff0000 ]\r\n" +
"      - [ be32, 0xa3bf14, 0x801f0000 ]\r\n" +
"      - [ be32, 0xa3bf18, 0x7c0903a6 ]\r\n" +
"      - [ be32, 0xa3bf1c, 0xf8410028 ]\r\n" +
"      - [ be32, 0xa3bf20, 0x805f0004 ]\r\n" +
"      - [ be32, 0xa3bf24, 0x7c3f0b78 ]\r\n" +
"      - [ be32, 0xa3bf28, 0x4e800421 ]\r\n" +
"      - [ be32, 0xa3bf2c, 0xe8410028 ]\r\n" +
"      - [ be32, 0xa3bf30, 0xebe10000 ]\r\n" +
"      - [ be32, 0xa3bf34, 0xe81f0010 ]\r\n" +
"      - [ be32, 0xa3bf38, 0x7c0803a6 ]\r\n" +
"      - [ be32, 0xa3bf3c, 0x7fe1fb78 ]\r\n" +
"      - [ be32, 0xa3bf40, 0xebfffff8 ]\r\n" +
"      - [ be32, 0xa3bf44, 0x4e800020 ]\r\n" +
"      - [ be32, 0xa3bf48, 0x38000000 ]\r\n" +
"      - [ be32, 0xa3bf4c, 0x4bffffa4 ]\r\n" +
"      - [ be32, 0xa3bf50, 0x38000004 ]\r\n" +
"      - [ be32, 0xa3bf54, 0x4bffff9c ]\r\n" +
"      - [ be32, 0xa3bf58, 0x38000008 ]\r\n" +
"      - [ be32, 0xa3bf5c, 0x4bffff94 ]\r\n" +
"      - [ be32, 0xa3bf60, 0x3800000c ]\r\n" +
"      - [ be32, 0xa3bf64, 0x4bffff8c ]\r\n" +
"      - [ be32, 0xa3bf68, 0x38000010 ]\r\n" +
"      - [ be32, 0xa3bf6c, 0x4bffff84 ]\r\n" +
"      - [ be32, 0xa3bf70, 0x38000014 ]\r\n" +
"      - [ be32, 0xa3bf74, 0x4bffff7c ]\r\n" +
"      - [ be32, 0xa3bf78, 0x38000018 ]\r\n" +
"      - [ be32, 0xa3bf7c, 0x4bffff74 ]\r\n" +
"      - [ be32, 0xa3bf80, 0x3800001c ]\r\n" +
"      - [ be32, 0xa3bf84, 0x4bffff6c ]\r\n" +
"      - [ be32, 0xa3bf88, 0x38000020 ]\r\n" +
"      - [ be32, 0xa3bf8c, 0x4bffff64 ]\r\n" +
"      - [ be32, 0xa3bf90, 0x38000024 ]\r\n" +
"      - [ be32, 0xa3bf94, 0x4bffff5c ]\r\n" +
"      - [ be32, 0xa3bf98, 0x38000028 ]\r\n" +
"      - [ be32, 0xa3bf9c, 0x4bffff54 ]\r\n" +
"      - [ be32, 0xa3bfa0, 0x3800002c ]\r\n" +
"      - [ be32, 0xa3bfa4, 0x4bffff4c ]\r\n" +
"      - [ be32, 0xa3bfa8, 0x38000030 ]\r\n" +
"      - [ be32, 0xa3bfac, 0x4bffff44 ]\r\n" +
"      - [ be32, 0xa3bfb0, 0x38000034 ]\r\n" +
"      - [ be32, 0xa3bfb4, 0x4bffff3c ]\r\n" +
"      - [ be32, 0xa3bfb8, 0x38000038 ]\r\n" +
"      - [ be32, 0xa3bfbc, 0x4bffff34 ]\r\n" +
"      - [ be32, 0xa3bfc0, 0x3800003c ]\r\n" +
"      - [ be32, 0xa3bfc4, 0x4bffff2c ]\r\n" +
"      - [ be32, 0xa3bfc8, 0x38000040 ]\r\n" +
"      - [ be32, 0xa3bfcc, 0x4bffff24 ]\r\n" +
"      - [ be32, 0xa3bfd0, 0x38000044 ]\r\n" +
"      - [ be32, 0xa3bfd4, 0x4bffff1c ]\r\n" +
"      - [ be32, 0xa3bfd8, 0x38000048 ]\r\n" +
"      - [ be32, 0xa3bfdc, 0x4bffff14 ]\r\n" +
"      - [ be32, 0xa3bfe0, 0x3800004c ]\r\n" +
"      - [ be32, 0xa3bfe4, 0x4bffff0c ]\r\n" +
"      - [ be32, 0xa3bfe8, 0x38000050 ]\r\n" +
"      - [ be32, 0xa3bfec, 0x4bffff04 ]\r\n" +
"      - [ be32, 0xa3bff0, 0x38000054 ]\r\n" +
"      - [ be32, 0xa3bff4, 0x4bfffefc ]\r\n" +
"      - [ be32, 0xa3bff8, 0x38000058 ]\r\n" +
"      - [ be32, 0xa3bffc, 0x4bfffef4 ]\r\n" +
"      - [ be32, 0xa3c000, 0x3800005c ]\r\n" +
"      - [ be32, 0xa3c004, 0x4bfffeec ]\r\n" +
"      - [ be32, 0xa3c008, 0x38000060 ]\r\n" +
"      - [ be32, 0xa3c00c, 0x4bfffee4 ]\r\n" +
"      - [ be32, 0xa3c010, 0x38000064 ]\r\n" +
"      - [ be32, 0xa3c014, 0x4bfffedc ]\r\n" +
"      - [ be32, 0xa3c018, 0x38000068 ]\r\n" +
"      - [ be32, 0xa3c01c, 0x4bfffed4 ]\r\n" +
"      - [ be32, 0xa3c020, 0x3800006c ]\r\n" +
"      - [ be32, 0xa3c024, 0x4bfffecc ]\r\n" +
"      - [ be32, 0xa3c028, 0x38000070 ]\r\n" +
"      - [ be32, 0xa3c02c, 0x4bfffec4 ]\r\n" +
"      - [ be32, 0xa3c030, 0x38000074 ]\r\n" +
"      - [ be32, 0xa3c034, 0x4bfffebc ]\r\n" +
"      - [ be32, 0xa3c038, 0x38000078 ]\r\n" +
"      - [ be32, 0xa3c03c, 0x4bfffeb4 ]\r\n" +
"      - [ be32, 0xa3c040, 0x3800007c ]\r\n" +
"      - [ be32, 0xa3c044, 0x4bfffeac ]\r\n" +
"      - [ be32, 0xa3c048, 0x38000080 ]\r\n" +
"      - [ be32, 0xa3c04c, 0x4bfffea4 ]\r\n" +
"      - [ be32, 0xa3c050, 0x38000084 ]\r\n" +
"      - [ be32, 0xa3c054, 0x4bfffe9c ]\r\n" +
"      - [ be32, 0xa3c058, 0x38000088 ]\r\n" +
"      - [ be32, 0xa3c05c, 0x4bfffe94 ]\r\n" +
"      - [ be32, 0xa3c060, 0x3800008c ]\r\n" +
"      - [ be32, 0xa3c064, 0x4bfffe8c ]\r\n" +
"      - [ be32, 0xa3c068, 0x38000090 ]\r\n" +
"      - [ be32, 0xa3c06c, 0x4bfffe84 ]\r\n" +
"      - [ be32, 0xa3c070, 0x38000094 ]\r\n" +
"      - [ be32, 0xa3c074, 0x4bfffe7c ]\r\n" +
"      - [ be32, 0xa3c078, 0x38000098 ]\r\n" +
"      - [ be32, 0xa3c07c, 0x4bfffe74 ]\r\n" +
"      - [ be32, 0xa3c080, 0x3800009c ]\r\n" +
"      - [ be32, 0xa3c084, 0x4bfffe6c ]\r\n" +
"      - [ be32, 0xa3c088, 0x380000a0 ]\r\n" +
"      - [ be32, 0xa3c08c, 0x4bfffe64 ]\r\n" +
"      - [ be32, 0xa3c090, 0x380000a4 ]\r\n" +
"      - [ be32, 0xa3c094, 0x4bfffe5c ]\r\n" +
"      - [ be32, 0xa3c098, 0x380000a8 ]\r\n" +
"      - [ be32, 0xa3c09c, 0x4bfffe54 ]\r\n" +
"      - [ be32, 0xa3c0a0, 0x380000ac ]\r\n" +
"      - [ be32, 0xa3c0a4, 0x4bfffe4c ]\r\n" +
"      - [ be32, 0xa3c0a8, 0x380000b0 ]\r\n" +
"      - [ be32, 0xa3c0ac, 0x4bfffe44 ]\r\n" +
"      - [ be32, 0xa3c0b0, 0x380000b4 ]\r\n" +
"      - [ be32, 0xa3c0b4, 0x4bfffe3c ]\r\n" +
"      - [ be32, 0xa3c0b8, 0x380000b8 ]\r\n" +
"      - [ be32, 0xa3c0bc, 0x4bfffe34 ]\r\n" +
"      - [ be32, 0xa3c0c0, 0x380000bc ]\r\n" +
"      - [ be32, 0xa3c0c4, 0x4bfffe2c ]\r\n" +
"      - [ be32, 0xa3c0c8, 0x380000c0 ]\r\n" +
"      - [ be32, 0xa3c0cc, 0x4bfffe24 ]\r\n" +
"      - [ be32, 0xa3c0d0, 0x380000c4 ]\r\n" +
"      - [ be32, 0xa3c0d4, 0x4bfffe1c ]\r\n" +
"      - [ be32, 0xa3c0d8, 0x380000c8 ]\r\n" +
"      - [ be32, 0xa3c0dc, 0x4bfffe14 ]\r\n" +
"      - [ be32, 0xa3c0e0, 0x380000cc ]\r\n" +
"      - [ be32, 0xa3c0e4, 0x4bfffe0c ]\r\n" +
"      - [ be32, 0xa3c0e8, 0x380000d0 ]\r\n" +
"      - [ be32, 0xa3c0ec, 0x4bfffe04 ]\r\n" +
"      - [ be32, 0xa3c0f0, 0x380000d4 ]\r\n" +
"      - [ be32, 0xa3c0f4, 0x4bfffdfc ]\r\n" +
"      - [ be32, 0xa3c0f8, 0x380000d8 ]\r\n" +
"      - [ be32, 0xa3c0fc, 0x4bfffdf4 ]\r\n" +
"      - [ be32, 0xa3c100, 0x380000dc ]\r\n" +
"      - [ be32, 0xa3c104, 0x4bfffdec ]\r\n" +
"      - [ be32, 0xa3c108, 0x380000e0 ]\r\n" +
"      - [ be32, 0xa3c10c, 0x4bfffde4 ]\r\n" +
"      - [ be32, 0xa3c110, 0x380000e4 ]\r\n" +
"      - [ be32, 0xa3c114, 0x4bfffddc ]\r\n" +
"      - [ be32, 0xa3c118, 0x380000e8 ]\r\n" +
"      - [ be32, 0xa3c11c, 0x4bfffdd4 ]\r\n" +
"      - [ be32, 0xa3c120, 0x380000ec ]\r\n" +
"      - [ be32, 0xa3c124, 0x4bfffdcc ]\r\n" +
"      - [ be32, 0xa3c128, 0x380000f0 ]\r\n" +
"      - [ be32, 0xa3c12c, 0x4bfffdc4 ]\r\n" +
"      - [ be32, 0xa3c130, 0x380000f4 ]\r\n" +
"      - [ be32, 0xa3c134, 0x4bfffdbc ]\r\n" +
"      - [ be32, 0xa3c138, 0x380000f8 ]\r\n" +
"      - [ be32, 0xa3c13c, 0x4bfffdb4 ]\r\n" +
"      - [ be32, 0xa3c140, 0x380000fc ]\r\n" +
"      - [ be32, 0xa3c144, 0x4bfffdac ]\r\n" +
"      - [ be32, 0xa3c148, 0x38000100 ]\r\n" +
"      - [ be32, 0xa3c14c, 0x4bfffda4 ]\r\n" +
"      - [ be32, 0xa3c150, 0x38000104 ]\r\n" +
"      - [ be32, 0xa3c154, 0x4bfffd9c ]\r\n" +
"      - [ be32, 0xa3c158, 0x38000108 ]\r\n" +
"      - [ be32, 0xa3c15c, 0x4bfffd94 ]\r\n" +
"      - [ be32, 0xa3c160, 0x3800010c ]\r\n" +
"      - [ be32, 0xa3c164, 0x4bfffd8c ]\r\n" +
"      - [ be32, 0xa3c168, 0x38000110 ]\r\n" +
"      - [ be32, 0xa3c16c, 0x4bfffd84 ]\r\n" +
"      - [ be32, 0xa3c170, 0x38000114 ]\r\n" +
"      - [ be32, 0xa3c174, 0x4bfffd7c ]\r\n" +
"      - [ be32, 0xa3c178, 0x38000118 ]\r\n" +
"      - [ be32, 0xa3c17c, 0x4bfffd74 ]\r\n" +
"      - [ be32, 0xa3c180, 0x3800011c ]\r\n" +
"      - [ be32, 0xa3c184, 0x4bfffd6c ]\r\n" +
"      - [ be32, 0xa3c188, 0x38000120 ]\r\n" +
"      - [ be32, 0xa3c18c, 0x4bfffd64 ]\r\n" +
"      - [ be32, 0xa3c190, 0x38000124 ]\r\n" +
"      - [ be32, 0xa3c194, 0x4bfffd5c ]\r\n" +
"      - [ be32, 0xa3c198, 0x38000128 ]\r\n" +
"      - [ be32, 0xa3c19c, 0x4bfffd54 ]\r\n" +
"      - [ be32, 0xa3c1a0, 0x3800012c ]\r\n" +
"      - [ be32, 0xa3c1a4, 0x4bfffd4c ]\r\n" +
"      - [ be32, 0xa3c1a8, 0x38000130 ]\r\n" +
"      - [ be32, 0xa3c1ac, 0x4bfffd44 ]\r\n" +
"      - [ be32, 0xa3c1b0, 0x38000134 ]\r\n" +
"      - [ be32, 0xa3c1b4, 0x4bfffd3c ]\r\n" +
"      - [ be32, 0xa3c1b8, 0x38000138 ]\r\n" +
"      - [ be32, 0xa3c1bc, 0x4bfffd34 ]\r\n" +
"      - [ be32, 0xa3c1c0, 0x3800013c ]\r\n" +
"      - [ be32, 0xa3c1c4, 0x4bfffd2c ]\r\n" +
"      - [ be32, 0xa3c1c8, 0x38000140 ]\r\n" +
"      - [ be32, 0xa3c1cc, 0x4bfffd24 ]\r\n" +
"      - [ be32, 0xa3c1d0, 0x38000144 ]\r\n" +
"      - [ be32, 0xa3c1d4, 0x4bfffd1c ]\r\n" +
"      - [ be32, 0xa3c1d8, 0x38000148 ]\r\n" +
"      - [ be32, 0xa3c1dc, 0x4bfffd14 ]\r\n" +
"      - [ be32, 0xa3c1e0, 0x3800014c ]\r\n" +
"      - [ be32, 0xa3c1e4, 0x4bfffd0c ]\r\n" +
"      - [ be32, 0xa3c1e8, 0x38000150 ]\r\n" +
"      - [ be32, 0xa3c1ec, 0x4bfffd04 ]\r\n" +
"      - [ be32, 0xa3c1f0, 0x38000154 ]\r\n" +
"      - [ be32, 0xa3c1f4, 0x4bfffcfc ]\r\n" +
"      - [ be32, 0xa3c1f8, 0x38000158 ]\r\n" +
"      - [ be32, 0xa3c1fc, 0x4bfffcf4 ]\r\n" +
"      - [ be32, 0xa3c200, 0x3800015c ]\r\n" +
"      - [ be32, 0xa3c204, 0x4bfffcec ]\r\n" +
"      - [ be32, 0xa3c208, 0x38000160 ]\r\n" +
"      - [ be32, 0xa3c20c, 0x4bfffce4 ]\r\n" +
"      - [ be32, 0xa3c210, 0x38000164 ]\r\n" +
"      - [ be32, 0xa3c214, 0x4bfffcdc ]\r\n" +
"      - [ be32, 0xa3c218, 0x38000168 ]\r\n" +
"      - [ be32, 0xa3c21c, 0x4bfffcd4 ]\r\n" +
"      - [ be32, 0xa3c220, 0x3800016c ]\r\n" +
"      - [ be32, 0xa3c224, 0x4bfffccc ]\r\n" +
"      - [ be32, 0xa3c228, 0x38000170 ]\r\n" +
"      - [ be32, 0xa3c22c, 0x4bfffcc4 ]\r\n" +
"      - [ be32, 0xa3c230, 0x38000174 ]\r\n" +
"      - [ be32, 0xa3c234, 0x4bfffcbc ]\r\n" +
"      - [ be32, 0xa3c238, 0x38000178 ]\r\n" +
"      - [ be32, 0xa3c23c, 0x4bfffcb4 ]\r\n" +
"      - [ be32, 0xa3c240, 0x3800017c ]\r\n" +
"      - [ be32, 0xa3c244, 0x4bfffcac ]\r\n" +
"      - [ be32, 0xa3c248, 0x38000180 ]\r\n" +
"      - [ be32, 0xa3c24c, 0x4bfffca4 ]\r\n" +
"      - [ be32, 0xa3c250, 0x38000184 ]\r\n" +
"      - [ be32, 0xa3c254, 0x4bfffc9c ]\r\n" +
"      - [ be32, 0xa3c258, 0x38000188 ]\r\n" +
"      - [ be32, 0xa3c25c, 0x4bfffc94 ]\r\n" +
"      - [ be32, 0xa3c260, 0x3800018c ]\r\n" +
"      - [ be32, 0xa3c264, 0x4bfffc8c ]\r\n" +
"      - [ be32, 0xa3c268, 0x38000190 ]\r\n" +
"      - [ be32, 0xa3c26c, 0x4bfffc84 ]\r\n" +
"      - [ be32, 0xa3c270, 0x38000194 ]\r\n" +
"      - [ be32, 0xa3c274, 0x4bfffc7c ]\r\n" +
"      - [ be32, 0xa3c278, 0x38000198 ]\r\n" +
"      - [ be32, 0xa3c27c, 0x4bfffc74 ]\r\n" +
"      - [ be32, 0xa3c280, 0x3800019c ]\r\n" +
"      - [ be32, 0xa3c284, 0x4bfffc6c ]\r\n" +
"      - [ be32, 0xa3c288, 0x380001a0 ]\r\n" +
"      - [ be32, 0xa3c28c, 0x4bfffc64 ]\r\n" +
"      - [ be32, 0xa3c290, 0x380001a4 ]\r\n" +
"      - [ be32, 0xa3c294, 0x4bfffc5c ]\r\n" +
"      - [ be32, 0xa3c298, 0x380001a8 ]\r\n" +
"      - [ be32, 0xa3c29c, 0x4bfffc54 ]\r\n" +
"      - [ be32, 0xa3c2a0, 0x380001ac ]\r\n" +
"      - [ be32, 0xa3c2a4, 0x4bfffc4c ]\r\n" +
"      - [ be32, 0xa3c2a8, 0x380001b0 ]\r\n" +
"      - [ be32, 0xa3c2ac, 0x4bfffc44 ]\r\n" +
"      - [ be32, 0xa3c2b0, 0x380001b4 ]\r\n" +
"      - [ be32, 0xa3c2b4, 0x4bfffc3c ]\r\n" +
"      - [ be32, 0xa3c2b8, 0x380001b8 ]\r\n" +
"      - [ be32, 0xa3c2bc, 0x4bfffc34 ]\r\n" +
"      - [ be32, 0xa3c2c0, 0x380001bc ]\r\n" +
"      - [ be32, 0xa3c2c4, 0x4bfffc2c ]\r\n" +
"      - [ be32, 0xa3c2c8, 0x380001c0 ]\r\n" +
"      - [ be32, 0xa3c2cc, 0x4bfffc24 ]\r\n" +
"      - [ be32, 0xa3c2d0, 0x380001c4 ]\r\n" +
"      - [ be32, 0xa3c2d4, 0x4bfffc1c ]\r\n" +
"      - [ be32, 0xa3c2d8, 0x380001c8 ]\r\n" +
"      - [ be32, 0xa3c2dc, 0x4bfffc14 ]\r\n" +
"      - [ be32, 0xa3c2e0, 0x380001cc ]\r\n" +
"      - [ be32, 0xa3c2e4, 0x4bfffc0c ]\r\n" +
"      - [ be32, 0xa3c2e8, 0x380001d0 ]\r\n" +
"      - [ be32, 0xa3c2ec, 0x4bfffc04 ]\r\n" +
"      - [ be32, 0xa3c2f0, 0x380001d4 ]\r\n" +
"      - [ be32, 0xa3c2f4, 0x4bfffbfc ]\r\n" +
"      - [ be32, 0xa3c2f8, 0x380001d8 ]\r\n" +
"      - [ be32, 0xa3c2fc, 0x4bfffbf4 ]\r\n" +
"      - [ be32, 0xa3c300, 0x380001dc ]\r\n" +
"      - [ be32, 0xa3c304, 0x4bfffbec ]\r\n" +
"      - [ be32, 0xa3c308, 0x380001e0 ]\r\n" +
"      - [ be32, 0xa3c30c, 0x4bfffbe4 ]\r\n" +
"      - [ be32, 0xa3c310, 0x380001e4 ]\r\n" +
"      - [ be32, 0xa3c314, 0x4bfffbdc ]\r\n" +
"      - [ be32, 0xa3c318, 0x380001e8 ]\r\n" +
"      - [ be32, 0xa3c31c, 0x4bfffbd4 ]\r\n" +
"      - [ be32, 0xa3c320, 0x380001ec ]\r\n" +
"      - [ be32, 0xa3c324, 0x4bfffbcc ]\r\n" +
"      - [ be32, 0xa3c328, 0x380001f0 ]\r\n" +
"      - [ be32, 0xa3c32c, 0x4bfffbc4 ]\r\n" +
"      - [ be32, 0xa3c330, 0x380001f4 ]\r\n" +
"      - [ be32, 0xa3c334, 0x4bfffbbc ]\r\n" +
"      - [ be32, 0xa3c338, 0x380001f8 ]\r\n" +
"      - [ be32, 0xa3c33c, 0x4bfffbb4 ]\r\n" +
"      - [ be32, 0xa3c340, 0x380001fc ]\r\n" +
"      - [ be32, 0xa3c344, 0x4bfffbac ]\r\n" +
"      - [ be32, 0xa3c348, 0x38000200 ]\r\n" +
"      - [ be32, 0xa3c34c, 0x4bfffba4 ]\r\n" +
"      - [ be32, 0xa3c350, 0x38000204 ]\r\n" +
"      - [ be32, 0xa3c354, 0x4bfffb9c ]\r\n" +
"      - [ be32, 0xa3c358, 0x38000208 ]\r\n" +
"      - [ be32, 0xa3c35c, 0x4bfffb94 ]\r\n" +
"      - [ be32, 0xa3c360, 0x3800020c ]\r\n" +
"      - [ be32, 0xa3c364, 0x4bfffb8c ]\r\n" +
"      - [ be32, 0xa3c368, 0x38000210 ]\r\n" +
"      - [ be32, 0xa3c36c, 0x4bfffb84 ]\r\n" +
"      - [ be32, 0xa3c370, 0x38000214 ]\r\n" +
"      - [ be32, 0xa3c374, 0x4bfffb7c ]\r\n" +
"      - [ be32, 0xa3c378, 0x38000218 ]\r\n" +
"      - [ be32, 0xa3c37c, 0x4bfffb74 ]\r\n" +
"      - [ be32, 0xa3c380, 0x3800021c ]\r\n" +
"      - [ be32, 0xa3c384, 0x4bfffb6c ]\r\n" +
"      - [ be32, 0xa3c388, 0x38000220 ]\r\n" +
"      - [ be32, 0xa3c38c, 0x4bfffb64 ]\r\n" +
"      - [ be32, 0xa3c390, 0x38000224 ]\r\n" +
"      - [ be32, 0xa3c394, 0x4bfffb5c ]\r\n" +
"      - [ be32, 0xa3c398, 0x38000228 ]\r\n" +
"      - [ be32, 0xa3c39c, 0x4bfffb54 ]\r\n" +
"      - [ be32, 0xa3c3a0, 0x3800022c ]\r\n" +
"      - [ be32, 0xa3c3a4, 0x4bfffb4c ]\r\n" +
"      - [ be32, 0xa3c3a8, 0x38000230 ]\r\n" +
"      - [ be32, 0xa3c3ac, 0x4bfffb44 ]\r\n" +
"      - [ be32, 0xa3c3b0, 0x38000234 ]\r\n" +
"      - [ be32, 0xa3c3b4, 0x4bfffb3c ]\r\n" +
"      - [ be32, 0xa3c3b8, 0x38000238 ]\r\n" +
"      - [ be32, 0xa3c3bc, 0x4bfffb34 ]\r\n" +
"      - [ be32, 0xa3c3c0, 0x3800023c ]\r\n" +
"      - [ be32, 0xa3c3c4, 0x4bfffb2c ]\r\n" +
"      - [ be32, 0xa3c3c8, 0x38000240 ]\r\n" +
"      - [ be32, 0xa3c3cc, 0x4bfffb24 ]\r\n" +
"      - [ be32, 0xa3c3d0, 0x38000244 ]\r\n" +
"      - [ be32, 0xa3c3d4, 0x4bfffb1c ]\r\n" +
"      - [ be32, 0xa3c3d8, 0x38000248 ]\r\n" +
"      - [ be32, 0xa3c3dc, 0x4bfffb14 ]\r\n" +
"      - [ be32, 0xa3c3e0, 0x3800024c ]\r\n" +
"      - [ be32, 0xa3c3e4, 0x4bfffb0c ]\r\n" +
"      - [ be32, 0xa3c3e8, 0x38000250 ]\r\n" +
"      - [ be32, 0xa3c3ec, 0x4bfffb04 ]\r\n" +
"      - [ be32, 0xa3c3f0, 0x38000254 ]\r\n" +
"      - [ be32, 0xa3c3f4, 0x4bfffafc ]\r\n" +
"      - [ be32, 0xa3c3f8, 0x38000258 ]\r\n" +
"      - [ be32, 0xa3c3fc, 0x4bfffaf4 ]\r\n" +
"      - [ be32, 0xa3c400, 0x3800025c ]\r\n" +
"      - [ be32, 0xa3c404, 0x4bfffaec ]\r\n" +
"      - [ be32, 0xa3c408, 0x38000260 ]\r\n" +
"      - [ be32, 0xa3c40c, 0x4bfffae4 ]\r\n" +
"      - [ be32, 0xa3c410, 0x38000264 ]\r\n" +
"      - [ be32, 0xa3c414, 0x4bfffadc ]\r\n" +
"      - [ be32, 0xa3c418, 0x38000268 ]\r\n" +
"      - [ be32, 0xa3c41c, 0x4bfffad4 ]\r\n" +
"      - [ be32, 0xa3c420, 0x3800026c ]\r\n" +
"      - [ be32, 0xa3c424, 0x4bfffacc ]\r\n" +
"      - [ be32, 0xa3c428, 0x38000270 ]\r\n" +
"      - [ be32, 0xa3c42c, 0x4bfffac4 ]\r\n" +
"      - [ be32, 0xa3c430, 0x38000274 ]\r\n" +
"      - [ be32, 0xa3c434, 0x4bfffabc ]\r\n" +
"      - [ be32, 0xa3c438, 0x38000278 ]\r\n" +
"      - [ be32, 0xa3c43c, 0x4bfffab4 ]\r\n" +
"      - [ be32, 0xa3c440, 0x3800027c ]\r\n" +
"      - [ be32, 0xa3c444, 0x4bfffaac ]\r\n" +
"      - [ be32, 0xa3c448, 0x38000280 ]\r\n" +
"      - [ be32, 0xa3c44c, 0x4bfffaa4 ]\r\n" +
"      - [ be32, 0xa3c450, 0x38000284 ]\r\n" +
"      - [ be32, 0xa3c454, 0x4bfffa9c ]\r\n" +
"      - [ be32, 0xa3c458, 0x38000288 ]\r\n" +
"      - [ be32, 0xa3c45c, 0x4bfffa94 ]\r\n" +
"      - [ be32, 0xa3c460, 0x3800028c ]\r\n" +
"      - [ be32, 0xa3c464, 0x4bfffa8c ]\r\n" +
"      - [ be32, 0xa3c468, 0x38000290 ]\r\n" +
"      - [ be32, 0xa3c46c, 0x4bfffa84 ]\r\n" +
"      - [ be32, 0xa3c470, 0x38000294 ]\r\n" +
"      - [ be32, 0xa3c474, 0x4bfffa7c ]\r\n" +
"      - [ be32, 0xa3c478, 0x38000298 ]\r\n" +
"      - [ be32, 0xa3c47c, 0x4bfffa74 ]\r\n" +
"      - [ be32, 0xa3c480, 0x3800029c ]\r\n" +
"      - [ be32, 0xa3c484, 0x4bfffa6c ]\r\n" +
"      - [ be32, 0xa3c488, 0x380002a0 ]\r\n" +
"      - [ be32, 0xa3c48c, 0x4bfffa64 ]\r\n" +
"      - [ be32, 0xa3c490, 0x380002a4 ]\r\n" +
"      - [ be32, 0xa3c494, 0x4bfffa5c ]\r\n" +
"      - [ be32, 0xa3c498, 0x380002a8 ]\r\n" +
"      - [ be32, 0xa3c49c, 0x4bfffa54 ]\r\n" +
"      - [ be32, 0xa3c4a0, 0x380002ac ]\r\n" +
"      - [ be32, 0xa3c4a4, 0x4bfffa4c ]\r\n" +
"      - [ be32, 0xa3c4a8, 0x380002b0 ]\r\n" +
"      - [ be32, 0xa3c4ac, 0x4bfffa44 ]\r\n" +
"      - [ be32, 0xa3c4b0, 0x380002b4 ]\r\n" +
"      - [ be32, 0xa3c4b4, 0x4bfffa3c ]\r\n" +
"      - [ be32, 0xa3c4b8, 0x380002b8 ]\r\n" +
"      - [ be32, 0xa3c4bc, 0x4bfffa34 ]\r\n" +
"      - [ be32, 0xa3c4c0, 0x380002bc ]\r\n" +
"      - [ be32, 0xa3c4c4, 0x4bfffa2c ]\r\n" +
"      - [ be32, 0xa3c4c8, 0x380002c0 ]\r\n" +
"      - [ be32, 0xa3c4cc, 0x4bfffa24 ]\r\n" +
"      - [ be32, 0xa3c4d0, 0x380002c4 ]\r\n" +
"      - [ be32, 0xa3c4d4, 0x4bfffa1c ]\r\n" +
"      - [ be32, 0xce2cb8, 0xbadf00d ]\r\n" +
"      # bin2rpcs3patch end";

    }
}
