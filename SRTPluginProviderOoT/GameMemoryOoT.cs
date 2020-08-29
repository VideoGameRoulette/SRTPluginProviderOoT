using System;
using System.Globalization;
using static SRTPluginProviderOoT.Structs;

namespace SRTPluginProviderOri1
{
    public struct GameMemoryOoT : IGameMemoryOoT
    {
        public ushort Entrance { get; set; }
        public bool IsChild { get; set; }
        public byte Cutscene { get; set; }
        public ushort Deaths { get; set; }
        public ushort HeartContainers { get; set; }
        public byte Magic { get; set; }
        public byte MagicUpgrades { get; set; }
        public byte Hearts { get; set; }
        public ushort Rupees { get; set; }
        public bool HasMagic { get; set; }
        public bool HasDoubleMagic { get; set; }
        //public byte[] Inventory { get; set; }
        //public byte[] ItemCounts { get; set; }
        public byte SwordsAndShields { get; set; }
        public byte TunicsAndBoots { get; set; }
        public uint Upgrades { get; set; }
        public byte MedallionsAndSongs { get; set; }
        public byte Songs { get; set; }
        public byte Misc { get; set; }
        public byte HeartPieces { get; set; }
        public byte Skulltulas { get; set; }
    }
}
