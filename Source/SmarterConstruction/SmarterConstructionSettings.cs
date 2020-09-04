﻿namespace SmarterConstruction
{
    public enum SCLogLevel
    {
        None = 0,
        Error = 1,
        Warning = 2,
        Info = 3,
        Debug = 4,
        Verbose = 5
    }

    public class SmarterConstructionSettings
    {
        public readonly SCLogLevel LogLevel = SCLogLevel.Debug;
        public bool ChangeMapEdgesCompatibility { get; set; }
        public readonly int FinishEncloseThingCacheTicks = 6;
        public readonly int GetJobEncloseThingCacheTicks = 20;
        public readonly int MaxRegionSize = 50;
    }
}
