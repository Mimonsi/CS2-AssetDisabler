using System.Collections.Generic;
using Colossal.Serialization.Entities;
using Game;
using Game.Prefabs;

namespace AssetDisabler
{
    public partial class AssetDisablerSystem : GameSystemBase
    {
        public static AssetDisablerSystem Instance { get; private set; }
        private List<string> prefabsToRemove;
        private PrefabSystem _prefabSystem;
        protected override void OnCreate()
        {
            base.OnCreate();
            Instance = this;
            _prefabSystem = World.GetOrCreateSystemManaged<PrefabSystem>();
            // Initialization code here

            prefabsToRemove = new List<string>()
            {
                "RoadMaintenanceVehicle01"
            };
        }

        protected override void OnGameLoadingComplete(Purpose purpose, GameMode mode)
        {
            base.OnGameLoadingComplete(purpose, mode);

            if (mode == GameMode.MainMenu)
            {
                RemovePrefabs(prefabsToRemove);
            }
        }

        public static void RemovePrefabs(List<string> prefabNames)
        {
            Instance.DoRemovePrefabs(prefabNames);
        }

        private void DoRemovePrefabs(List<string> prefabNames)
        {
            Mod.log.Info("Removing prefabs: " + prefabNames.Count);
            foreach (string prefabName in prefabNames)
            {
                Mod.log.Info($"Removing prefab {prefabName}");
                if (TryResolvePrefab(prefabName, out var prefab))
                {
                    _prefabSystem.RemovePrefab(prefab);
                    Mod.log.Info($"Successfully removed prefab {prefabName}");
                }
                else
                {
                    Mod.log.Warn($"Could not find prefab {prefabName} to remove");
                }
            }
        }
        
        private bool TryResolvePrefab(string prefabName, out PrefabBase prefab)
        {
            var prefabID = new PrefabID("CarPrefab", prefabName);
            if (_prefabSystem.TryGetPrefab(prefabID, out prefab))
                return true;

            // Custom assets not supported
            /*var cachedId = PrefabCacheSystem.GetPrefabIDByName(prefabName);
            if (cachedId != null && m_PrefabSystem.TryGetPrefab(cachedId.Value, out prefab))
                return true;*/

            prefab = null;
            return false;
        }

        protected override void OnUpdate()
        {
            
        }
    }
}