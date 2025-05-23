﻿using p3ppc.patch.jyokyohelp.Configuration;
using p3ppc.patch.jyokyohelp.Template;
using Reloaded.Hooks.Definitions;
using Reloaded.Hooks.ReloadedII.Interfaces;
using Reloaded.Mod.Interfaces;
using IReloadedHooks = Reloaded.Hooks.ReloadedII.Interfaces.IReloadedHooks;
using static p3ppc.patch.jyokyohelp.Utils;
using Reloaded.Mod.Interfaces.Internal;
using System.Runtime.InteropServices;

namespace p3ppc.patch.jyokyohelp
{
    /// <summary>
    /// Your mod logic goes here.
    /// </summary>
    public class Mod : ModBase // <= Do not Remove.
    {
        /// <summary>
        /// Provides access to the mod loader API.
        /// </summary>
        private readonly IModLoader _modLoader;

        /// <summary>
        /// Provides access to the Reloaded.Hooks API.
        /// </summary>
        /// <remarks>This is null if you remove dependency on Reloaded.SharedLib.Hooks in your mod.</remarks>
        private readonly IReloadedHooks? _hooks;

        /// <summary>
        /// Provides access to the Reloaded logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Entry point into the mod, instance that created this class.
        /// </summary>
        private readonly IMod _owner;

        /// <summary>
        /// Provides access to this mod's configuration.
        /// </summary>
        private Config _configuration;

        /// <summary>
        /// The configuration of the currently executing mod.
        /// </summary>
        private readonly IModConfig _modConfig;

        private delegate int GetJyokyoHelpMessageNo_FindDelegate(int skillID);
        private IHook<GetJyokyoHelpMessageNo_FindDelegate> _getDatJyokyoHelpMsgNoHook;

        private readonly Dictionary<int, int> _msgRedirect = new();

        public Mod(ModContext context)
        {
            _modLoader = context.ModLoader;
            _hooks = context.Hooks;
            _logger = context.Logger;
            _owner = context.Owner;
            _configuration = context.Configuration;
            _modConfig = context.ModConfig;

            Initialise(_logger, _configuration, _modLoader);

            SigScan("40 53 48 83 EC 20 8B D9 48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 81 FB 47 01 00 00", "GetJyokyoHelpMessageNo", address =>
            {
                _getDatJyokyoHelpMsgNoHook = _hooks.CreateHook<GetJyokyoHelpMessageNo_FindDelegate>(GetCustomDatJyokyoHelpMessage, address).Activate();
            });

            _modLoader.ModLoading += ModLoading;
        }

        public void RedirectMessageID(int oldID, int newID)
        {
            _msgRedirect[oldID] = newID;
        }

        private void ModLoading(IModV1 mod, IModConfigV1 modConfig)
        {
            var modsPath = Path.Combine(_modLoader.GetDirectoryForModId(modConfig.ModId), "skill");
            if (!Directory.Exists(modsPath))
                return;

            AddFolder(modsPath);
        }

        private void AddFolder(string folder)
        {
            var redirectsFile = Path.Join(folder, "datJyokyoHelp.txt");
            if (File.Exists(redirectsFile))
            {
                Log($"Loading MSG ID Redirections from {redirectsFile}");

                var redirects = DeserializeFile<int, int>(redirectsFile);
                foreach (var kv in redirects)
                {
                    RedirectMessageID(kv.Key, kv.Value);
                }
            }
        }

        public int GetCustomDatJyokyoHelpMessage(int skillID)
        {
            int result = _getDatJyokyoHelpMsgNoHook.OriginalFunction(skillID);

            if (0 >= skillID) return result;

            LogDebug($"GetCustomDatJyokyoHelpMessage: skill {skillID} -> msg {result}");

            if (_msgRedirect.TryGetValue(skillID, out var newID))
            {
                result = newID;
                LogDebug($"Redirected: skill {skillID} -> msg {result}");
            }

            return result;
        }

        #region Standard Overrides
        public override void ConfigurationUpdated(Config configuration)
        {
            // Apply settings from configuration.
            // ... your code here.
            _configuration = configuration;
            _logger.WriteLine($"[{_modConfig.ModId}] Config Updated: Applying");
        }
        #endregion

        #region For Exports, Serialization etc.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Mod() { }
#pragma warning restore CS8618
        #endregion
    }
}