﻿using System.Collections.Generic;

namespace PKHeX.Core.AutoMod
{
    public static class xoroshiro8_wild
    {
        private static readonly Dictionary<int[], uint> zero_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] { 31, 31, 31, 31,  0,  0 }, 0x005DC65E },
            { new[] { 31,  0, 31,  0, 31, 31 }, 0x022F7135 },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x025FF1EE },
            { new[] { 31, 31, 31,  0, 31,  0 }, 0x02EDF501 },
            { new[] { 31,  0,  0, 31,  0, 31 }, 0x03FAFB14 },
            { new[] { 31, 31,  0, 31,  0, 31 }, 0x04DD6D04 },
            { new[] {  0, 31, 31, 31,  0,  0 }, 0x06A148C5 },
            { new[] {  0, 31,  0,  0, 31,  0 }, 0x10620EFD },
            { new[] {  0, 31,  0,  0,  0, 31 }, 0x11E8259D },
            { new[] {  0,  0, 31, 31,  0,  0 }, 0x12E909F7 },
            { new[] {  0, 31, 31,  0, 31,  0 }, 0x12E92CD7 },
            { new[] {  0,  0, 31,  0,  0, 31 }, 0x13839BCB },
            { new[] { 31,  0,  0,  0, 31,  0 }, 0x13D576E4 },
            { new[] {  0, 31, 31,  0, 31, 31 }, 0x14B37E3E },
            { new[] {  0, 31, 31,  0,  0, 31 }, 0x14C0A213 },
            { new[] { 31,  0, 31, 31,  0, 31 }, 0x153A707E },
            { new[] { 31,  0,  0,  0,  0,  0 }, 0x1645B6A1 },
            { new[] {  0,  0,  0,  0,  0,  0 }, 0x17033091 },
            { new[] {  0,  0,  0,  0, 31,  0 }, 0x17CE97AD },
            { new[] {  0, 31,  0, 31,  0, 31 }, 0x17DC94D2 },
            { new[] {  0,  0, 31,  0, 31, 31 }, 0x17E99D74 },
            { new[] {  0,  0,  0, 31,  0,  0 }, 0x19EF2793 },
            { new[] { 31,  0,  0, 31, 31, 31 }, 0x1E220AD7 },
            { new[] {  0,  0, 31,  0,  0,  0 }, 0x1EB65910 },
            { new[] {  0, 31, 31, 31, 31,  0 }, 0x1EEE3969 },
            { new[] { 31,  0, 31, 31, 31,  0 }, 0x200DA840 },
            { new[] { 31,  0, 31,  0,  0,  0 }, 0x255E3CBB },
            { new[] { 31, 31,  0,  0, 31, 31 }, 0x25CF4634 },
            { new[] { 31, 31,  0,  0,  0, 31 }, 0x2751DAA8 },
            { new[] {  0,  0, 31, 31,  0, 31 }, 0x289BB6E9 },
            { new[] { 31,  0, 31,  0, 31,  0 }, 0x2C0ABDFE },
            { new[] {  0,  0, 31, 31, 31, 31 }, 0x2F5E32DD },
            { new[] {  0,  0,  0,  0, 31, 31 }, 0x3353493F },
            { new[] {  0, 31,  0, 31, 31,  0 }, 0x343BFB03 },
            { new[] {  0,  0,  0, 31, 31,  0 }, 0x34470002 },
            { new[] { 31, 31, 31,  0,  0, 31 }, 0x367029A7 },
            { new[] { 31,  0,  0,  0,  0, 31 }, 0x3A804E4A },
            { new[] {  0,  0, 31,  0, 31,  0 }, 0x3C3EC3D3 },
            { new[] { 31, 31,  0,  0,  0,  0 }, 0x3E01AA74 },
            { new[] { 31,  0,  0,  0, 31, 31 }, 0x3F5D423D },
            { new[] {  0, 31,  0, 31,  0,  0 }, 0x4416AB5D },
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x44E87F35 },
            { new[] {  0, 31,  0,  0, 31, 31 }, 0x47491E8D },
            { new[] { 31, 31,  0, 31, 31,  0 }, 0x474F427F },
            { new[] {  0,  0,  0, 31,  0, 31 }, 0x4C7EEEC6 },
            { new[] {  0,  0,  0, 31, 31, 31 }, 0x5249D5CB },
            { new[] {  0, 31,  0,  0,  0,  0 }, 0x5C87F2CD },
            { new[] { 31,  0, 31,  0,  0, 31 }, 0x5FB0018E },
            { new[] { 31,  0,  0, 31,  0,  0 }, 0x6AAF1D30 },
            { new[] { 31, 31,  0,  0, 31,  0 }, 0x72E45644 },
            { new[] { 31,  0,  0, 31, 31,  0 }, 0x73F7C8F3 },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x76352687 },
            { new[] {  0, 31, 31,  0,  0,  0 }, 0x84E8D2B1 },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x857FA070 },
            { new[] { 31,  0, 31, 31,  0,  0 }, 0x8E15BF56 },
            { new[] {  0,  0, 31, 31, 31,  0 }, 0xA64E68D0 },
            { new[] {  0,  0,  0,  0,  0, 31 }, 0xB49628C0 },
            { new[] {  0, 31,  0, 31, 31, 31 }, 0xD85E0341 },
            { new[] { 31, 31, 31,  0,  0,  0 }, 0xE66E8A08 },
        };

        private static readonly Dictionary<int[], uint> one_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] {  0,  0, 31, 31,  0,  0 }, 0x0002129F },
            { new[] { 31, 31,  0,  0, 31, 31 }, 0x0006C34D },
            { new[] {  0, 31,  0,  0, 31, 31 }, 0x0007A8C9 },
            { new[] {  0,  0, 31, 31,  0, 31 }, 0x000E0890 },
            { new[] { 31, 31,  0,  0,  0,  0 }, 0x00126D28 },
            { new[] {  0,  0,  0,  0, 31, 31 }, 0x00238A05 },
            { new[] { 31, 31, 31, 31,  0,  0 }, 0x0023A752 },
            { new[] {  0,  0,  0,  0,  0, 31 }, 0x00291559 },
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x005BCE03 },
            { new[] {  0, 31,  0,  0,  0, 31 }, 0x00650B0F },
            { new[] { 31,  0,  0,  0,  0, 31 }, 0x0074868B },
            { new[] {  0,  0, 31, 31, 31,  0 }, 0x0090A638 },
            { new[] {  0,  0, 31,  0, 31, 31 }, 0x00A55015 },
            { new[] { 31, 31,  0,  0,  0, 31 }, 0x00C908B7 },
            { new[] { 31, 31,  0, 31, 31, 31 }, 0x00D60A65 },
            { new[] { 31,  0, 31, 31,  0, 31 }, 0x00E58195 },
            { new[] { 31,  0,  0, 31, 31,  0 }, 0x00FDA1C5 },
            { new[] {  0, 31, 31,  0, 31,  0 }, 0x01050034 },
            { new[] { 31,  0, 31,  0,  0, 31 }, 0x01060136 },
            { new[] { 31,  0,  0,  0, 31, 31 }, 0x0122E6BB },
            { new[] {  0,  0,  0,  0, 31,  0 }, 0x015FADB9 },
            { new[] {  0,  0,  0, 31, 31,  0 }, 0x016D6004 },
            { new[] { 31,  0, 31,  0,  0,  0 }, 0x018F6491 },
            { new[] { 31,  0,  0,  0, 31,  0 }, 0x0194D69D },
            { new[] { 31,  0, 31, 31, 31,  0 }, 0x01A92A80 },
            { new[] { 31,  0, 31, 31,  0,  0 }, 0x01AF64E2 },
            { new[] { 31,  0,  0, 31, 31, 31 }, 0x01AF7672 },
            { new[] {  0, 31,  0, 31,  0, 31 }, 0x01B775E6 },
            { new[] {  0, 31,  0,  0,  0,  0 }, 0x01C3FE0F },
            { new[] { 31, 31,  0, 31, 31,  0 }, 0x01C49C3B },
            { new[] { 31,  0,  0, 31,  0, 31 }, 0x01DCAA5F },
            { new[] {  0, 31, 31, 31, 31, 31 }, 0x01E534D6 },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x0211DB78 },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x0220C33A },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x0235487F },
            { new[] { 31, 31,  0, 31,  0, 31 }, 0x0247C78A },
            { new[] { 31, 31,  0,  0, 31,  0 }, 0x02859531 },
            { new[] {  0, 31,  0, 31, 31, 31 }, 0x028BBA5A },
            { new[] {  0,  0,  0, 31, 31, 31 }, 0x029B17D5 },
            { new[] {  0, 31, 31, 31, 31,  0 }, 0x02BA712A },
            { new[] {  0, 31,  0, 31,  0,  0 }, 0x02EAF126 },
            { new[] {  0,  0,  0, 31,  0, 31 }, 0x033A5BDE },
            { new[] {  0, 31, 31, 31,  0, 31 }, 0x03514D6C },
            { new[] {  0, 31, 31,  0,  0, 31 }, 0x0373C3E3 },
            { new[] {  0, 31, 31,  0, 31, 31 }, 0x0375AAE1 },
            { new[] { 31,  0, 31,  0, 31,  0 }, 0x03AA4EE8 },
            { new[] { 31, 31,  0, 31,  0,  0 }, 0x03C7F853 },
            { new[] {  0, 31, 31, 31,  0,  0 }, 0x04104680 },
            { new[] {  0,  0, 31,  0, 31,  0 }, 0x04112DC7 },
            { new[] {  0,  0, 31, 31, 31, 31 }, 0x041B98AD },
            { new[] { 31, 31, 31,  0,  0, 31 }, 0x04486D1B },
            { new[] {  0, 31,  0, 31, 31,  0 }, 0x04CFF417 },
            { new[] { 31, 31, 31, 31, 31, 31 }, 0x052D6808 },
            { new[] { 31, 31, 31,  0, 31,  0 }, 0x053B05B5 },
            { new[] {  0,  0, 31,  0,  0, 31 }, 0x05775C6E },
            { new[] { 31,  0,  0, 31,  0,  0 }, 0x07D6BC01 },
            { new[] { 31,  0, 31,  0, 31, 31 }, 0x08EE45AE },
            { new[] {  0, 31, 31,  0,  0,  0 }, 0x094EA84E },
            { new[] { 31, 31, 31,  0,  0,  0 }, 0x0C0296B9 },
            { new[] {  0, 31,  0,  0, 31,  0 }, 0x0D56ACBA },
            { new[] { 31,  0,  0,  0,  0,  0 }, 0x17033091 },
            { new[] {  0,  0, 31,  0,  0,  0 }, 0x1CEEE0C8 },
            { new[] {  0,  0,  0, 31,  0,  0 }, 0x3582A115 },
        };

        private static readonly Dictionary<int[], uint> two_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x00009BEC },
            { new[] {  0, 31, 31,  0, 31, 31 }, 0x00010626 },
            { new[] {  0, 31,  0,  0,  0, 31 }, 0x0001D41E },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x000209B0 },
            { new[] { 31,  0, 31, 31,  0,  0 }, 0x0002129F },
            { new[] {  0,  0, 31, 31, 31,  0 }, 0x00022A74 },
            { new[] {  0,  0, 31,  0, 31, 31 }, 0x000386C4 },
            { new[] { 31,  0, 31, 31,  0, 31 }, 0x00038F55 },
            { new[] { 31, 31,  0, 31,  0, 31 }, 0x0004B200 },
            { new[] { 31, 31,  0,  0, 31, 31 }, 0x0007A8C9 },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x00085349 },
            { new[] { 31, 31, 31, 31, 31, 31 }, 0x000A1428 },
            { new[] { 31, 31,  0, 31, 31, 31 }, 0x000C0774 },
            { new[] {  0, 31,  0, 31, 31, 31 }, 0x000CEE68 },
            { new[] { 31, 31,  0, 31, 31,  0 }, 0x000E1494 },
            { new[] { 31, 31, 31,  0,  0, 31 }, 0x000E671B },
            { new[] { 31,  0,  0, 31, 31,  0 }, 0x000FFAD1 },
            { new[] { 31,  0, 31,  0, 31,  0 }, 0x00111562 },
            { new[] {  0, 31, 31, 31, 31, 31 }, 0x00118B68 },
            { new[] {  0, 31, 31, 31,  0, 31 }, 0x0011A238 },
            { new[] { 31, 31,  0,  0,  0, 31 }, 0x0012224C },
            { new[] { 31, 31,  0, 31,  0,  0 }, 0x00151F19 },
            { new[] { 31,  0,  0, 31, 31, 31 }, 0x001648C6 },
            { new[] {  0,  0, 31,  0, 31,  0 }, 0x00170CD7 },
            { new[] { 31, 31,  0,  0, 31,  0 }, 0x0019D0BD },
            { new[] { 31,  0, 31,  0,  0, 31 }, 0x001B54B4 },
            { new[] {  0, 31, 31,  0,  0,  0 }, 0x001B7953 },
            { new[] {  0, 31,  0,  0, 31, 31 }, 0x001D4371 },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x001DD7BC },
            { new[] {  0, 31, 31, 31, 31,  0 }, 0x002049E7 },
            { new[] { 31,  0,  0, 31,  0,  0 }, 0x00216E4D },
            { new[] { 31,  0,  0,  0, 31, 31 }, 0x00238A05 },
            { new[] {  0,  0, 31, 31, 31, 31 }, 0x0026AAEE },
            { new[] { 31,  0,  0,  0,  0, 31 }, 0x00291559 },
            { new[] { 31,  0,  0, 31,  0, 31 }, 0x002A3DC1 },
            { new[] { 31,  0, 31,  0, 31, 31 }, 0x002AEF1D },
            { new[] {  0, 31,  0, 31, 31,  0 }, 0x00346DD7 },
            { new[] {  0, 31,  0, 31,  0, 31 }, 0x00388EB6 },
            { new[] {  0,  0,  0,  0, 31, 31 }, 0x003F6E2F },
            { new[] {  0, 31, 31,  0,  0, 31 }, 0x00413759 },
            { new[] { 31, 31, 31, 31,  0,  0 }, 0x004FB16D },
            { new[] { 31, 31, 31,  0, 31,  0 }, 0x00571436 },
            { new[] { 31,  0, 31, 31, 31,  0 }, 0x005CDD03 },
            { new[] {  0,  0,  0, 31, 31, 31 }, 0x005E61D3 },
            { new[] {  0, 31,  0,  0, 31,  0 }, 0x00643D42 },
            { new[] {  0,  0, 31, 31,  0,  0 }, 0x00661FB6 },
            { new[] {  0,  0, 31, 31,  0, 31 }, 0x0071D252 },
            { new[] {  0, 31,  0, 31,  0,  0 }, 0x007C7FC5 },
            { new[] {  0, 31, 31, 31,  0,  0 }, 0x00932FDD },
            { new[] {  0, 31, 31,  0, 31,  0 }, 0x009A1433 },
            { new[] { 31,  0, 31,  0,  0,  0 }, 0x00B9D520 },
            { new[] {  0,  0, 31,  0,  0, 31 }, 0x012F3F0A },
            { new[] { 31, 31, 31,  0,  0,  0 }, 0x014AACA3 },
            { new[] { 31,  0,  0,  0, 31,  0 }, 0x015FADB9 },
            { new[] { 31, 31,  0,  0,  0,  0 }, 0x01772901 },
            { new[] {  0,  0,  0, 31,  0, 31 }, 0x0241D345 },
            { new[] {  0,  0,  0, 31, 31,  0 }, 0x0394F8DC },
        };

        private static readonly Dictionary<int[], uint> three_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] { 31, 31, 31,  0, 31,  0 }, 0x000033F7 },
            { new[] { 31, 31, 31,  0,  0, 31 }, 0x0000443F },
            { new[] { 31, 31, 31, 31,  0,  0 }, 0x00004548 },
            { new[] { 31, 31,  0,  0, 31, 31 }, 0x00005695 },
            { new[] { 31,  0,  0, 31, 31, 31 }, 0x00009783 },
            { new[] { 31,  0, 31,  0, 31, 31 }, 0x00009B1B },
            { new[] { 31, 31, 31, 31, 31, 31 }, 0x00009C23 },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x0000D0E6 },
            { new[] { 31, 31,  0,  0,  0, 31 }, 0x0000E6BA },
            { new[] { 31, 31,  0, 31,  0, 31 }, 0x0000F110 },
            { new[] {  0,  0,  0, 31, 31, 31 }, 0x0000F2E2 },
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x0000F998 },
            { new[] {  0,  0, 31, 31, 31,  0 }, 0x00011060 },
            { new[] { 31,  0,  0, 31, 31,  0 }, 0x00013060 },
            { new[] {  0, 31,  0, 31, 31, 31 }, 0x00015A01 },
            { new[] { 31,  0,  0, 31,  0, 31 }, 0x00015D54 },
            { new[] {  0, 31, 31, 31, 31, 31 }, 0x00018823 },
            { new[] {  0, 31, 31, 31,  0, 31 }, 0x00020D0A },
            { new[] { 31,  0, 31, 31,  0, 31 }, 0x0002231D },
            { new[] { 31,  0, 31, 31, 31,  0 }, 0x00022A74 },
            { new[] {  0,  0, 31, 31, 31, 31 }, 0x00022DD5 },
            { new[] {  0,  0, 31, 31,  0, 31 }, 0x0002467F },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x00025536 },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x0002DC93 },
            { new[] { 31, 31,  0, 31, 31, 31 }, 0x000315E8 },
            { new[] { 31, 31, 31,  0,  0,  0 }, 0x0003398E },
            { new[] {  0, 31, 31,  0, 31, 31 }, 0x00034C3E },
            { new[] {  0, 31, 31, 31, 31,  0 }, 0x00038EBB },
            { new[] {  0, 31, 31,  0, 31,  0 }, 0x0003A8BF },
            { new[] {  0, 31, 31, 31,  0,  0 }, 0x0006A85F },
            { new[] {  0,  0, 31,  0, 31, 31 }, 0x0006C940 },
            { new[] { 31,  0, 31,  0,  0, 31 }, 0x0007670C },
            { new[] { 31, 31,  0, 31,  0,  0 }, 0x00078B1D },
            { new[] { 31,  0,  0,  0, 31, 31 }, 0x0008A45E },
            { new[] {  0, 31,  0, 31, 31,  0 }, 0x0008CE15 },
            { new[] { 31, 31,  0, 31, 31,  0 }, 0x00097342 },
            { new[] { 31,  0, 31,  0, 31,  0 }, 0x000F40D0 },
            { new[] { 31,  0, 31, 31,  0,  0 }, 0x001138E6 },
            { new[] {  0, 31,  0,  0, 31, 31 }, 0x001354BC },
            { new[] {  0, 31,  0, 31,  0, 31 }, 0x0016D9D8 },
            { new[] {  0, 31, 31,  0,  0, 31 }, 0x001B2914 },
            { new[] { 31, 31,  0,  0, 31,  0 }, 0x002D61F4 },
        };

        private static readonly Dictionary<int[], uint> four_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x6ACF03B6 },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x6ACF049D },
            { new[] {  0, 31, 31,  0, 31, 31 }, 0x6ACF0757 },
            { new[] { 31, 31, 31, 31, 31, 31 }, 0x6ACF0908 },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x6ACF0C45 },
            { new[] { 31, 31,  0, 31, 31, 31 }, 0x6ACF0DFD },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x6ACF0F18 },
            { new[] { 31,  0, 31, 31,  0, 31 }, 0x6ACF1229 },
            { new[] { 31,  0,  0, 31, 31, 31 }, 0x6ACF128D },
            { new[] {  0, 31, 31, 31, 31, 31 }, 0x6ACF1644 },
            { new[] {  0, 31, 31, 31,  0, 31 }, 0x6ACF191B },
            { new[] { 31, 31, 31, 31,  0,  0 }, 0x6ACF1B9F },
            { new[] { 31, 31, 31,  0,  0, 31 }, 0x6ACF2B7D },
            { new[] { 31, 31,  0,  0, 31, 31 }, 0x6ACF2B81 },
            { new[] {  0, 31,  0, 31, 31, 31 }, 0x6ACF2BB9 },
            { new[] { 31,  0, 31,  0, 31, 31 }, 0x6ACF2EAD },
            { new[] {  0, 31, 31, 31, 31,  0 }, 0x6ACF31B5 },
            { new[] { 31, 31, 31,  0, 31,  0 }, 0x6ACF33CB },
            { new[] { 31, 31,  0, 31, 31,  0 }, 0x6ACF4FE4 },
            { new[] { 31,  0, 31, 31, 31,  0 }, 0x6ACF5BC2 },
            { new[] {  0,  0, 31, 31, 31, 31 }, 0x6ACF829A },
            { new[] { 31, 31,  0, 31,  0, 31 }, 0x6ACFC2BC },
        };

        private static readonly Dictionary<int[], uint> five_fixed_ivs = new Dictionary<int[], uint>(new ArrayEqualityComparator())
        {
            { new[] { 31, 31, 31, 31, 31, 31 }, 0x112AAE7B },
            { new[] {  0, 31, 31, 31, 31, 31 }, 0x112AAE98 },
            { new[] { 31,  0, 31, 31, 31, 31 }, 0x112AAEAB },
            { new[] { 31, 31, 31, 31, 31,  0 }, 0x112AAEB3 },
            { new[] { 31, 31, 31, 31,  0, 31 }, 0x112AAF49 },
            { new[] { 31, 31,  0, 31, 31, 31 }, 0x112AAF7F },
            { new[] { 31, 31, 31,  0, 31, 31 }, 0x112AB13B },
        };

        public static int GetWildSeedFromIV8(int[] fixedivs, int[] ivs, out uint seed)
        {
            // { IV_HP, IV_ATK, IV_DEF, IV_SPE, IV_SPA, IV_SPD } (original order)
            // { IV_HP, IV_ATK, IV_DEF, IV_SPA, IV_SPD, IV_SPE } (corrected order)
            var ivtemp = new int[6];
            seed = 0;
            ivtemp[0] = ivs[0];
            ivtemp[1] = ivs[1];
            ivtemp[2] = ivs[2];
            ivtemp[3] = ivs[4];
            ivtemp[4] = ivs[5];
            ivtemp[5] = ivs[3];

            var fixediv = -1;

            foreach (int i in fixedivs)
            {
                if (!CheckValidSeed(i, ivtemp, ref seed))
                    continue;
                fixediv = i;
                break;
            }
            return fixediv;
        }

        private static bool CheckValidSeed(int i, int[] ivtemp, ref uint seed)
        {
            var seeds = i switch
            {
                0 => zero_fixed_ivs,
                1 => one_fixed_ivs,
                2 => two_fixed_ivs,
                3 => three_fixed_ivs,
                4 => four_fixed_ivs,
                5 => five_fixed_ivs,
                _ => zero_fixed_ivs
            };
            if (!seeds.ContainsKey(ivtemp))
                return false;
            seed = seeds[ivtemp];
            return true;
        }
    }
}