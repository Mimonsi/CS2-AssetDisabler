using System.Collections.Generic;
using Colossal.Serialization.Entities;
using Game;
using Game.Prefabs;

namespace AssetDisabler
{
    public partial class AssetDisablerSystem : GameSystemBase
    {
        public static AssetDisablerSystem Instance { get; private set; }
        private PrefabSystem _prefabSystem;

        protected override void OnCreate()
        {
            base.OnCreate();
            Instance = this;
            _prefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
        }

        protected override void OnGameLoadingComplete(Purpose purpose, GameMode mode)
        {
            base.OnGameLoadingComplete(purpose, mode);

            if (mode == GameMode.MainMenu)
            {
                ApplyFromSettings(Mod.Setting);
            }
        }

        private void ApplyFromSettings(Setting setting)
        {
            if (setting == null) return;
            var toRemove = new List<string>();
            foreach (var category in PrefabCatalog.Categories)
            {
                foreach (var entry in category.Entries)
                {
                    if (!setting.IsEnabled(entry.SettingPropertyName))
                        toRemove.Add(entry.PrefabName);
                }
            }
            RemovePrefabs(toRemove);
        }

        private void RemovePrefabs(List<string> prefabNames)
        {
            Mod.log.Info($"Removing prefabs: {prefabNames.Count}");
            foreach (var prefabName in prefabNames)
            {
                if (TryResolvePrefab(prefabName, out var prefab))
                {
                    _prefabSystem.RemovePrefab(prefab);
                    Mod.log.Info($"Removed prefab {prefabName}");
                }
                else
                {
                    Mod.log.Warn($"Could not find prefab {prefabName} to remove");
                }
            }
        }

        private bool TryResolvePrefab(string prefabName, out PrefabBase prefab)
        {
            foreach (var typeName in PrefabCatalog.PrefabTypeCandidates)
            {
                var prefabID = new PrefabID(typeName, prefabName);
                if (_prefabSystem.TryGetPrefab(prefabID, out prefab))
                    return true;
            }

            prefab = null;
            return false;
        }

        protected override void OnUpdate() { }
    }
}
