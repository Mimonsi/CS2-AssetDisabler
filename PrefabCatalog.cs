using System.Collections.Generic;

namespace AssetDisabler
{
    public static class PrefabCatalog
    {
        public class Entry
        {
            public string PrefabName;
            public string DisplayName;
            public string SettingPropertyName;
        }

        public class Category
        {
            public string Key;
            public string DisplayName;
            public string DisableAllPropertyName;
            public string EnableAllPropertyName;
            public List<Entry> Entries;
        }

        // Prefab types to try when resolving a prefab name. The game stores
        // different vehicle classes under different prefab types; we try each
        // until one resolves.
        public static readonly string[] PrefabTypeCandidates =
        {
            "CarPrefab",
            "RollingStockPrefab",
        };

        public static readonly List<Category> Categories = new List<Category>
        {
            new Category
            {
                Key = "PersonalCars",
                DisplayName = "Personal Cars",
                DisableAllPropertyName = nameof(Setting.DisableAllPersonalCars),
                EnableAllPropertyName = nameof(Setting.EnableAllPersonalCars),
                Entries = new List<Entry>
                {
                    new Entry { PrefabName = "Car01",             DisplayName = "Car 01",              SettingPropertyName = nameof(Setting.Disable_Car01) },
                    new Entry { PrefabName = "Car02",             DisplayName = "Car 02",              SettingPropertyName = nameof(Setting.Disable_Car02) },
                    new Entry { PrefabName = "Car03",             DisplayName = "Car 03",              SettingPropertyName = nameof(Setting.Disable_Car03) },
                    new Entry { PrefabName = "Car04",             DisplayName = "Car 04",              SettingPropertyName = nameof(Setting.Disable_Car04) },
                    new Entry { PrefabName = "Car05",             DisplayName = "Car 05",              SettingPropertyName = nameof(Setting.Disable_Car05) },
                    new Entry { PrefabName = "Car06",             DisplayName = "Car 06",              SettingPropertyName = nameof(Setting.Disable_Car06) },
                    new Entry { PrefabName = "Car07",             DisplayName = "Car 07",              SettingPropertyName = nameof(Setting.Disable_Car07) },
                    new Entry { PrefabName = "Car08",             DisplayName = "Car 08",              SettingPropertyName = nameof(Setting.Disable_Car08) },
                    new Entry { PrefabName = "Car09",             DisplayName = "Car 09",              SettingPropertyName = nameof(Setting.Disable_Car09) },
                    new Entry { PrefabName = "Car10",             DisplayName = "Car 10",              SettingPropertyName = nameof(Setting.Disable_Car10) },
                    new Entry { PrefabName = "MuscleCar01",       DisplayName = "Muscle Car 01",       SettingPropertyName = nameof(Setting.Disable_MuscleCar01) },
                    new Entry { PrefabName = "MuscleCar02",       DisplayName = "Muscle Car 02",       SettingPropertyName = nameof(Setting.Disable_MuscleCar02) },
                    new Entry { PrefabName = "MuscleCar03",       DisplayName = "Muscle Car 03",       SettingPropertyName = nameof(Setting.Disable_MuscleCar03) },
                    new Entry { PrefabName = "MuscleCar04",       DisplayName = "Muscle Car 04",       SettingPropertyName = nameof(Setting.Disable_MuscleCar04) },
                    new Entry { PrefabName = "MuscleCar05",       DisplayName = "Muscle Car 05",       SettingPropertyName = nameof(Setting.Disable_MuscleCar05) },
                    new Entry { PrefabName = "Van01",             DisplayName = "Van 01",              SettingPropertyName = nameof(Setting.Disable_Van01) },
                    new Entry { PrefabName = "Motorbike01",       DisplayName = "Motorbike 01",        SettingPropertyName = nameof(Setting.Disable_Motorbike01) },
                    new Entry { PrefabName = "Motorbike02",       DisplayName = "Motorbike 02",        SettingPropertyName = nameof(Setting.Disable_Motorbike02) },
                    new Entry { PrefabName = "Scooter01",         DisplayName = "Scooter 01",          SettingPropertyName = nameof(Setting.Disable_Scooter01) },
                    new Entry { PrefabName = "ElectricScooter01", DisplayName = "Electric Scooter 01", SettingPropertyName = nameof(Setting.Disable_ElectricScooter01) },
                    new Entry { PrefabName = "Bicycle01",         DisplayName = "Bicycle 01",          SettingPropertyName = nameof(Setting.Disable_Bicycle01) },
                    new Entry { PrefabName = "Bicycle02",         DisplayName = "Bicycle 02",          SettingPropertyName = nameof(Setting.Disable_Bicycle02) },
                    new Entry { PrefabName = "Bicycle03",         DisplayName = "Bicycle 03",          SettingPropertyName = nameof(Setting.Disable_Bicycle03) },
                    new Entry { PrefabName = "CarTrailer01",      DisplayName = "Car Trailer 01",      SettingPropertyName = nameof(Setting.Disable_CarTrailer01) },
                    new Entry { PrefabName = "CamperTrailer01",   DisplayName = "Camper Trailer 01",   SettingPropertyName = nameof(Setting.Disable_CamperTrailer01) },
                },
            },
            new Category
            {
                Key = "Trains",
                DisplayName = "Trains",
                DisableAllPropertyName = nameof(Setting.DisableAllTrains),
                EnableAllPropertyName = nameof(Setting.EnableAllTrains),
                Entries = new List<Entry>
                {
                    new Entry { PrefabName = "EU_TrainPassengerEngine01", DisplayName = "EU Passenger Engine 01", SettingPropertyName = nameof(Setting.Disable_EU_TrainPassengerEngine01) },
                    new Entry { PrefabName = "NA_TrainPassengerEngine01", DisplayName = "NA Passenger Engine 01", SettingPropertyName = nameof(Setting.Disable_NA_TrainPassengerEngine01) },
                    new Entry { PrefabName = "EU_TrainCargoEngine01",     DisplayName = "EU Cargo Engine 01",     SettingPropertyName = nameof(Setting.Disable_EU_TrainCargoEngine01) },
                    new Entry { PrefabName = "NA_TrainCargoEngine01",     DisplayName = "NA Cargo Engine 01",     SettingPropertyName = nameof(Setting.Disable_NA_TrainCargoEngine01) },
                    new Entry { PrefabName = "EU_TrainPassengerCar01",    DisplayName = "EU Passenger Car 01",    SettingPropertyName = nameof(Setting.Disable_EU_TrainPassengerCar01) },
                    new Entry { PrefabName = "NA_TrainPassengerCar01",    DisplayName = "NA Passenger Car 01",    SettingPropertyName = nameof(Setting.Disable_NA_TrainPassengerCar01) },
                    new Entry { PrefabName = "TrainCargoCar01",           DisplayName = "Cargo Car 01",           SettingPropertyName = nameof(Setting.Disable_TrainCargoCar01) },
                    new Entry { PrefabName = "TrainForestryCar01",        DisplayName = "Forestry Car 01",        SettingPropertyName = nameof(Setting.Disable_TrainForestryCar01) },
                    new Entry { PrefabName = "TrainOreCar01",             DisplayName = "Ore Car 01",             SettingPropertyName = nameof(Setting.Disable_TrainOreCar01) },
                    new Entry { PrefabName = "TrainAgricultureCar01",     DisplayName = "Agriculture Car 01",     SettingPropertyName = nameof(Setting.Disable_TrainAgricultureCar01) },
                    new Entry { PrefabName = "TrainOilCar01",             DisplayName = "Oil Car 01",             SettingPropertyName = nameof(Setting.Disable_TrainOilCar01) },
                },
            },
            new Category
            {
                Key = "Trams",
                DisplayName = "Trams",
                DisableAllPropertyName = nameof(Setting.DisableAllTrams),
                EnableAllPropertyName = nameof(Setting.EnableAllTrams),
                Entries = new List<Entry>
                {
                    new Entry { PrefabName = "TramEngine01",   DisplayName = "Tram Engine 01",    SettingPropertyName = nameof(Setting.Disable_TramEngine01) },
                    new Entry { PrefabName = "TramEngineCO01", DisplayName = "Tram Engine CO 01", SettingPropertyName = nameof(Setting.Disable_TramEngineCO01) },
                    new Entry { PrefabName = "TramCar01",      DisplayName = "Tram Car 01",       SettingPropertyName = nameof(Setting.Disable_TramCar01) },
                    new Entry { PrefabName = "TramCarCO01",    DisplayName = "Tram Car CO 01",    SettingPropertyName = nameof(Setting.Disable_TramCarCO01) },
                },
            },
            new Category
            {
                Key = "Subways",
                DisplayName = "Subways",
                DisableAllPropertyName = nameof(Setting.DisableAllSubways),
                EnableAllPropertyName = nameof(Setting.EnableAllSubways),
                Entries = new List<Entry>
                {
                    new Entry { PrefabName = "SubwayEngine01", DisplayName = "Subway Engine 01", SettingPropertyName = nameof(Setting.Disable_SubwayEngine01) },
                    new Entry { PrefabName = "SubwayCar01",    DisplayName = "Subway Car 01",    SettingPropertyName = nameof(Setting.Disable_SubwayCar01) },
                },
            },
        };
    }
}
