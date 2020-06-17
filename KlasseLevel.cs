using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DND
{
    public partial class KlasseLevel
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("ability_score_bonuses")]
        public int AbilityScoreBonus { get; set; }

        [JsonProperty("Prof_bonus")]
        public int ProfBonus { get; set; }

        [JsonProperty("feature_choices")]
        public List<FeatureChoice> FeatureChoices { get; set; }

        [JsonProperty("features")]
        public List<Features> Features { get; set; }

        [JsonProperty("class_specific")]
        public ClassSpecific ClassSpecific { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("class")]
        public Klasse klasse { get; set; }
        [JsonProperty("subclass")]
        public Subclass Subclass { get; set; }
        [JsonProperty("spellcasting")]
        public Spellcasting Spellcasting { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
    public partial class Subclass
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
    public partial class Spellcasting
    {
        [JsonProperty("cantrips_known")]
        public int CantripsKnown { get; set; }
        [JsonProperty("spells_known")]
        public int SpellsKnown { get; set; }
        [JsonProperty("spell_slots_level_1")]
        public int SpellSlotsLevel1 { get; set; }
        [JsonProperty("spell_slots_level_2")]
        public int SpellSlotsLevel2 { get; set; }
        [JsonProperty("spell_slots_level_3")]
        public int SpellSlotsLevel3 { get; set; }
        [JsonProperty("spell_slots_level_4")]
        public int SpellSlotsLevel4 { get; set; }
        [JsonProperty("spell_slots_level_5")]
        public int SpellSlotsLevel5 { get; set; }
        [JsonProperty("spell_slots_level_6")]
        public int SpellSlotsLevel6 { get; set; }
        [JsonProperty("spell_slots_level_7")]
        public int SpellSlotsLevel7 { get; set; }
        [JsonProperty("spell_slots_level_8")]
        public int SpellSlotsLevel8 { get; set; }
        [JsonProperty("spell_slots_level_9")]
        public int SpellSlotsLevel9 { get; set; }
    }
    public partial class Features
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
    public partial class ClassSpecific
    {
        [JsonProperty("rage_count")]
        public string RageCount { get; set; }

        [JsonProperty("rage_damage_bonus")]
        public int RageDamageBonus { get; set; }

        [JsonProperty("brutal_critical_dice")]
        public int BrutalCriticalDice { get; set; }
        [JsonProperty("martial_arts")]
        public MartialArts MartialArts { get; set; }
        [JsonProperty("bardic_inspiration_die")]
        public int BardicInspirationDie { get; set; }
        [JsonProperty("song_of_rest_die")]
        public int SongOfRestDie { get; set; }
        [JsonProperty("magical_secrets_max_5")]
        public int MagicalSecretsMax5 { get; set; }
        [JsonProperty("magical_secrets_max_7")]
        public int MagicalSecretsMax7 { get; set; }
        [JsonProperty("magical_secrets_max_9")]
        public int MagicalSecretsMax9 { get; set; }
        [JsonProperty("channel_divinity_charges")]
        public int ChannelDivinityCharges { get; set; }
        [JsonProperty("destroy_undead_cr")]
        public double DestroyUndeadCR { get; set; }

    }
    public partial class FeatureChoice
    {

    }
    public partial class MartialArts
    {
        [JsonProperty("dice_count")]
        public int DiceCount { get; set; }

        [JsonProperty("dice_value")]
        public int DiceValue { get; set; }
    }
    public partial class KlasseLevel
    {
        public static KlasseLevel FromJson(string json) => JsonConvert.DeserializeObject<KlasseLevel>(json, DND.Converter.Settings);
    }
}
