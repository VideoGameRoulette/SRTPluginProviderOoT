using System;
using static SRTPluginProviderOoT.Structs;

namespace SRTPluginProviderOri1
{
    public interface IGameMemoryOoT
    {
        ushort Entrance { get; set; }
        bool IsChild { get; set; }
        byte Cutscene { get; set; }
        ushort Deaths { get; set; }
        ushort HeartContainers { get; set; }
        byte Magic { get; set; }
        byte MagicUpgrades { get; set; }
        byte Hearts { get; set; }
        ushort Rupees { get; set; }
        bool HasMagic { get; set; }
        bool HasDoubleMagic { get; set; }
        //byte[] Inventory { get; set; }
        //byte[] ItemCounts { get; set; }
        byte SwordsAndShields { get; set; }
        byte TunicsAndBoots { get; set; }
        uint Upgrades { get; set; }
        byte MedallionsAndSongs { get; set; }
        byte Songs { get; set; }
        byte Misc { get; set; }
        byte HeartPieces { get; set; }
        byte Skulltulas { get; set; }
    }
}
