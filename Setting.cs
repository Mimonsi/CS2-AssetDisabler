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

        // =====================================================================
        // Personal Cars
        // =====================================================================

        [SettingsUISection(kPersonalCarsTab, kActionsGroup)]
        public bool DisableAllPersonalCars { set => SetCategory("PersonalCars", true); }

        [SettingsUISection(kPersonalCarsTab, kActionsGroup)]
        public bool EnableAllPersonalCars { set => SetCategory("PersonalCars", false); }

        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car02 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car03 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car04 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car05 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car06 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car07 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car08 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car09 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Car10 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_MuscleCar01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_MuscleCar02 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_MuscleCar03 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_MuscleCar04 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_MuscleCar05 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Van01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Motorbike01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Motorbike02 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Scooter01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_ElectricScooter01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Bicycle01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Bicycle02 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_Bicycle03 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_CarTrailer01 { get; set; }
        [SettingsUISection(kPersonalCarsTab, kPrefabsGroup)] public bool Disable_CamperTrailer01 { get; set; }

        // =====================================================================
        // Trains
        // =====================================================================

        [SettingsUISection(kTrainsTab, kActionsGroup)]
        public bool DisableAllTrains { set => SetCategory("Trains", true); }

        [SettingsUISection(kTrainsTab, kActionsGroup)]
        public bool EnableAllTrains { set => SetCategory("Trains", false); }

        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_EU_TrainPassengerEngine01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_NA_TrainPassengerEngine01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_EU_TrainCargoEngine01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_NA_TrainCargoEngine01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_EU_TrainPassengerCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_NA_TrainPassengerCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_TrainCargoCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_TrainForestryCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_TrainOreCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_TrainAgricultureCar01 { get; set; }
        [SettingsUISection(kTrainsTab, kPrefabsGroup)] public bool Disable_TrainOilCar01 { get; set; }

        // =====================================================================
        // Trams
        // =====================================================================

        [SettingsUISection(kTramsTab, kActionsGroup)]
        public bool DisableAllTrams { set => SetCategory("Trams", true); }

        [SettingsUISection(kTramsTab, kActionsGroup)]
        public bool EnableAllTrams { set => SetCategory("Trams", false); }

        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Disable_TramEngine01 { get; set; }
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Disable_TramEngineCO01 { get; set; }
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Disable_TramCar01 { get; set; }
        [SettingsUISection(kTramsTab, kPrefabsGroup)] public bool Disable_TramCarCO01 { get; set; }

        // =====================================================================
        // Subways
        // =====================================================================

        [SettingsUISection(kSubwaysTab, kActionsGroup)]
        public bool DisableAllSubways { set => SetCategory("Subways", true); }

        [SettingsUISection(kSubwaysTab, kActionsGroup)]
        public bool EnableAllSubways { set => SetCategory("Subways", false); }

        [SettingsUISection(kSubwaysTab, kPrefabsGroup)] public bool Disable_SubwayEngine01 { get; set; }
        [SettingsUISection(kSubwaysTab, kPrefabsGroup)] public bool Disable_SubwayCar01 { get; set; }

        // =====================================================================
        // Helpers
        // =====================================================================

        public bool GetDisabled(string propertyName)
        {
            var pi = typeof(Setting).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (pi == null || pi.PropertyType != typeof(bool) || pi.GetGetMethod() == null)
                return false;
            return (bool)pi.GetValue(this);
        }

        private void SetDisabled(string propertyName, bool value)
        {
            var pi = typeof(Setting).GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
            if (pi == null || pi.PropertyType != typeof(bool) || pi.GetSetMethod() == null)
                return;
            pi.SetValue(this, value);
        }

        private void SetCategory(string categoryKey, bool disabled)
        {
            var category = PrefabCatalog.Categories.Find(c => c.Key == categoryKey);
            if (category == null) return;
            foreach (var entry in category.Entries)
                SetDisabled(entry.SettingPropertyName, disabled);
            ApplyAndSave();
        }

        public override void SetDefaults()
        {
            foreach (var category in PrefabCatalog.Categories)
                foreach (var entry in category.Entries)
                    SetDisabled(entry.SettingPropertyName, false);
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

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllPersonalCars)), "Disable All Personal Cars" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllPersonalCars)), "Mark every personal car in this category as disabled." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllPersonalCars)), "Enable All Personal Cars" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllPersonalCars)), "Clear the disabled flag for every personal car." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllTrains)), "Disable All Trains" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllTrains)), "Mark every train in this category as disabled." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllTrains)), "Enable All Trains" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllTrains)), "Clear the disabled flag for every train." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllTrams)), "Disable All Trams" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllTrams)), "Mark every tram in this category as disabled." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllTrams)), "Enable All Trams" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllTrams)), "Clear the disabled flag for every tram." },

                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.DisableAllSubways)), "Disable All Subways" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.DisableAllSubways)), "Mark every subway in this category as disabled." },
                { m_Setting.GetOptionLabelLocaleID(nameof(Setting.EnableAllSubways)), "Enable All Subways" },
                { m_Setting.GetOptionDescLocaleID(nameof(Setting.EnableAllSubways)), "Clear the disabled flag for every subway." },
            };

            foreach (var category in PrefabCatalog.Categories)
            {
                foreach (var entry in category.Entries)
                {
                    dict[m_Setting.GetOptionLabelLocaleID(entry.SettingPropertyName)] = entry.DisplayName;
                    dict[m_Setting.GetOptionDescLocaleID(entry.SettingPropertyName)] =
                        $"Disable the vanilla prefab \"{entry.PrefabName}\".";
                }
            }

            return dict;
        }

        public void Unload() { }
    }
}
