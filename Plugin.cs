﻿using PluginAPI.Core.Attributes;
using PluginAPI.Enums;

namespace SwiftNPCs
{
    public class Plugin
    {
        /// <summary>
        /// Singleton for the SwiftNPC API base plugin class. 
        /// This can be used anywhere to access the base class.
        /// </summary>
        public static Plugin? Instance;

        private const string Author = "SwiftKraft";

        private const string Name = "SwiftNPCs";

        private const string Description = "An Open Source NPC API for NWAPI SCP: SL Servers. ";

        private const string Version = "Alpha v0.0.1";

        [PluginPriority(LoadPriority.Lowest)]
        [PluginEntryPoint(Name, Version, Description, Author)]
        public void Init()
        {
            Instance = this;
        }
    }
}
