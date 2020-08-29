using ProcessMemory32;
using System;
using System.Diagnostics;

namespace SRTPluginProviderOri1
{
    internal class GameMemoryOoTScanner : IDisposable
    {
        // Variables
        private ProcessMemory32.ProcessMemory32 memoryAccess;
        private GameMemoryOoT gameMemoryValues;
        public bool HasScanned;
        public bool ProcessRunning => memoryAccess != null && memoryAccess.ProcessRunning;
        public int ProcessExitCode => (memoryAccess != null) ? memoryAccess.ProcessExitCode : 0;

        // Pointer Address Variables
        private int AddressGameData = 0x4D6A1C;

        // Pointer Classes
        private int BaseAddress { get; set; }
        private MultilevelPointer PointerGameData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="proc"></param>
        internal GameMemoryOoTScanner(Process process = null)
        {
            gameMemoryValues = new GameMemoryOoT();
            if (process != null)
                Initialize(process);

            // Setup the pointers.

        }

        internal void Initialize(Process process)
        {
            if (process == null)
                return; // Do not continue if this is null.

            int pid = GetProcessId(process).Value;
            memoryAccess = new ProcessMemory32.ProcessMemory32(pid);

            if (ProcessRunning)
            {
                BaseAddress = NativeWrappers.GetProcessBaseAddress(pid, PInvoke.ListModules.LIST_MODULES_32BIT).ToInt32(); // Bypass .NET's managed solution for getting this and attempt to get this info ourselves via PInvoke since some users are getting 299 PARTIAL COPY when they seemingly shouldn't.
                PointerGameData = new MultilevelPointer(memoryAccess, new IntPtr(AddressGameData));
            }
        }


        /// <summary>
        /// 
        /// </summary>
        internal void UpdatePointers()
        {
            PointerGameData.UpdatePointers();
        }

        internal IGameMemoryOoT Refresh()
        {
            gameMemoryValues.Entrance = PointerGameData.DerefUShort(0x11A5D0);
            gameMemoryValues.IsChild = PointerGameData.DerefByte(0x11A5D4) != 0;
            gameMemoryValues.Cutscene = PointerGameData.DerefByte(0x11A5D8);
            gameMemoryValues.Deaths = PointerGameData.DerefUShort(0x11A5F0);
            gameMemoryValues.HeartContainers = PointerGameData.DerefUShort(0x11A5FC);
            gameMemoryValues.Magic = PointerGameData.DerefByte(0x11A600);
            gameMemoryValues.MagicUpgrades = PointerGameData.DerefByte(0x11A601);
            gameMemoryValues.Hearts = PointerGameData.DerefByte(0x11A602);
            gameMemoryValues.Rupees = PointerGameData.DerefUShort(0x11A606);
            gameMemoryValues.HasMagic = PointerGameData.DerefByte(0x11A609) != 0;
            gameMemoryValues.HasDoubleMagic = PointerGameData.DerefByte(0x11A60F) != 0;

            //INSERT INVENTORY AND COUNTS HERE

            gameMemoryValues.SwordsAndShields = PointerGameData.DerefByte(0x11A66E);
            gameMemoryValues.TunicsAndBoots = PointerGameData.DerefByte(0x11A66F);
            gameMemoryValues.Upgrades = PointerGameData.DerefUInt(0x11A670);
            gameMemoryValues.MedallionsAndSongs = PointerGameData.DerefByte(0x11A674);
            gameMemoryValues.Songs = PointerGameData.DerefByte(0x11A675);
            gameMemoryValues.Misc = PointerGameData.DerefByte(0x11A676);
            gameMemoryValues.HeartPieces = PointerGameData.DerefByte(0x11A677);
            gameMemoryValues.Skulltulas = PointerGameData.DerefByte(0x11AA1C);
            HasScanned = true;
            return gameMemoryValues;
        }

        private int? GetProcessId(Process process) => process?.Id;

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    if (memoryAccess != null)
                        memoryAccess.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~REmake1Memory() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}
