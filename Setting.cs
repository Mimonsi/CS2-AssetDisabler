using Colossal;
using Colossal.IO.AssetDatabase;
using Game.Modding;
using Game.Settings;
using System.Collections.Generic;
using System.Reflection;

namespace AssetDisabler
{
    [FileLocation(nameof(AssetDisabler))]
    [SettingsUITabOrder(kPersonalCarsTab, kTrainsTab, kTramsTab, kSubwaysTab)]
    [SettingsUIGroupOrder(kActionsGroup, kPrefabsGroup)]
    [SettingsUIShowGroupName(kActionsGroup, kPrefabsGroup)]
    public class Setting : ModSetting
    {
        public const string kPersonalCarsTab = "PersonalCars";
        public const string kTrainsTab = "Trains";
        public const string kTramsTab = "Trams";
        public const string kSubwaysTab = "Subways";

        public const string kActionsGroup = "Actions";
        public const string kPrefabsGroup = "Prefabs";

        public Setting(IMod mod) : base(mod) { }

        // Semantics: checked = enabled (default). Unchecked = the prefab will be removed.

        // =====================================================================
        // Personal Cars
        // =====================================================================

        [SettingsUISection(kPersonalCarsTab, kActionsGroup)]
        public bool EnableAllPersonalCars { set => SetCategory("PersonalCars", true); }

        [SettingsUISection(kPersonalCarsTab, kActionsGroup)]
        public bool DisableAllPersonalCars { set => SetCategory("PersonalCars", false); }

        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car02 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car03 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car04 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car05 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car06 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car07 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car08 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car09 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Car10 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_MuscleCar01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_MuscleCar02 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_MuscleCar03 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_MuscleCar04 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_MuscleCar05 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Van01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Motorbike01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Motorbike02 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Scooter01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_ElectricScooter01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Bicycle01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Bicycle02 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_Bicycle03 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_CarTrailer01 { get; set; } = true;
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Enable_CamperTrailer01 { get; set; } = true;

        // =====================================================================
        // Trains
        // =====================================================================

        [SettingsUISection(kTrainsTab, kActionsGroup)]
        public bool EnableAllTrains { set => SetCategory("Trains", true); }

        [SettingsUISection(kTrainsTab, kActionsGroup)]
        public bool DisableAllTrains { set => SetCategory("Trains", false); }

        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_EU_TrainPassengerEngine01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_NA_TrainPassengerEngine01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_EU_TrainCargoEngine01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_NA_TrainCargoEngine01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_EU_TrainPassengerCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_NA_TrainPassengerCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_TrainCargoCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_TrainForestryCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_TrainOreCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_TrainAgricultureCar01 { get; set; } = true;
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Enable_TrainOilCar01 { get; set; } = true;

        // =====================================================================
        // Trams
        // =====================================================================

        [SettingsUISection(kTramsTab, kActionsGroup)]
        public bool EnableAllTrams { set => SetCategory("Trams", true); }

        [SettingsUISection(kTramsTab, kActionsGroup)]
        public bool DisableAllTrams { set => SetCategory("Trams", false); }

        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Enable_TramEngine01 { get; set; } = true;
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Enable_TramEngineCO01 { get; set; } = true;
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Enable_TramCar01 { get; set; } = true;
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Enable_TramCarCO01 { get; set; } = true;

        // =====================================================================
        // Subways
        // =====================================================================

        [SettingsUISection(kSubwaysTab, kActionsGroup)]
        public bool EnableAllSubways { set => SetCategory("Subways", true); }

        [SettingsUISection(kSubwaysTab, kActionsGroup)]
        public bool DisableAllSubways { set => SetCategory("Subways", false); }

        [SettingsUISection(kSubwaysTab, kPrefabsGroup)] public bool Enable_SubwayEngine01 { get; set; } = true;
        [SettingsUISection(kSubwaysTab, kPrefabsGroup)] public bool Enable_SubwayCar01 { get; set; } = true;

        // =====================================================================
        // Helpers
        // =====================================================================

        public bool IsEnabled(string propertyName)
        {
            var pi = typeof(Setting).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (pi == null || pi.PropertyType != typeof(bool) || pi.GetGetMethod() == null)
                return true;
            return (bool)pi.GetValue(this);
        }

        private void SetEnabled(string propertyName, bool value)
        {
            var pi = typeof(Setting).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (pi == null || pi.PropertyType != typeof(bool) || pi.GetSetMethod() == null)
                return;
            pi.SetValue(this, value);
        }

        private void SetCategory(string categoryKey, bool enabled)
        {
            var category = PrefabCatalog.Categories.Find(c => c.Key == categoryKey);
            if (category == null) return;
            foreach (var entry in category.Entries)
                SetEnabled(entry.SettingPropertyName, enabled);
            ApplyAndSave();
        }

        public override void SetDefaults()
        {
            foreach (var category in PrefabCatalog.Categories)
                foreach (var entry in category.Entries)
                    SetEnabled(entry.SettingPropertyName, true);
        }
    }

    public class LocaleEN : IDictionarySource
    {
        private readonly Setting m_Setting;
        public LocaleEN(Setting setting) { m_Setting = setting; }

        public IEnumerable<KeyValuePair<string, string>> ReadEntries(IList<IDictionaryEntryError> errors, Dictionary<string, int> indexCounts)
        {
            var dict = new Dictionary<string, string>
            {
                { m_Setting.GetSettingsLocaleID(), "Asset Disabler" },

                { m_Setting.GetOptionTabLocaleID(Setting.kPersonalCarsTab), "Personal Cars" },
                { m_Setting.GetOptionTabLocaleID(Setting.kTrainsTab), "Trains" },
                { m_Setting.GetOptionTabLocaleID(Setting.kTramsTab), "Trams" },
                { m_Setting.GetOptionTabLocaleID(Setting.kSubwaysTab), "Subways" },

                { m_Setting.GetOptionGroupLocaleID(Setting.kActionsGroup), "Actions" },
                { m_Setting.GetOptionGroupLocaleID(Setting.kPrefabsGroup), "Prefabs" },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllPersonalCars)), "Enable All Personal Cars" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllPersonalCars)), "Enable every personal car in this category." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllPersonalCars)), "Disable All Personal Cars" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllPersonalCars)), "Disable every personal car in this category." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllTrains)), "Enable All Trains" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllTrains)), "Enable every train in this category." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllTrains)), "Disable All Trains" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllTrains)), "Disable every train in this category." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllTrams)), "Enable All Trams" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllTrams)), "Enable every tram in this category." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllTrams)), "Disable All Trams" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllTrams)), "Disable every tram in this category." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllSubways)), "Enable All Subways" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllSubways)), "Enable every subway in this category." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllSubways)), "Disable All Subways" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllSubways)), "Disable every subway in this category." },
            };

            foreach (var category in PrefabCatalog.Categories)
            {
                foreach (var entry in category.Entries)
                {
                    dict[m_Setting.GetOptionLabelLocaleID(entry.SettingPropertyName)] = entry.DisplayName;
                    dict[m_Setting.GetOptionDescLocaleID(entry.SettingPropertyName)] =
                        $"When unchecked, the vanilla prefab \"{entry.PrefabName}\" will be removed at game start.";
                }
            }

            return dict;
        }

        public void Unload() { }
    }
}
