using System;

namespace Celeste.Mod.CelesteRLBridge;

public sealed class CelesteRLBridgeModule : EverestModule {
    public static CelesteRLBridgeModule Instance { get; private set; }

    public CelesteRLBridgeModule() {
        Instance = this;
        Logger.SetLogLevel(nameof(CelesteRLBridgeModule), LogLevel.Info);
    }

    public override void Load() {
        Logger.Log(LogLevel.Info, nameof(CelesteRLBridgeModule), "Bridge connected.");
    }

    public override void Unload() {
        // TODO: unapply any hooks applied in Load()
    }
}