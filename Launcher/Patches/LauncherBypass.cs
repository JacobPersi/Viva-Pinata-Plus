namespace PinataParty {
    public class LauncherBypass : PatchCollection  {
        public LauncherBypass() {
            Name = "Launcher Bypass";
            Description = "Avoids various 'IsLauncherRunning' checks.";
            Patches = new IPatch[] {
                new SimpleMemoryPatch(0x8C1C64,   new byte[] { 0x0F, 0x84, 0x4C, 0x02, 0x00, 0x00 },
                                            new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }),
                new SimpleMemoryPatch(0x8C1C71,   new byte[] { 0x0F, 0x84, 0x3F, 0x02, 0x00, 0x00 },
                                            new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 })
            };
        }
    }
}