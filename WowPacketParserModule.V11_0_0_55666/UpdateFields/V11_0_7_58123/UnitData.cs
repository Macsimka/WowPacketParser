// <auto-generated>
// DO NOT EDIT
// </auto-generated>

using System.CodeDom.Compiler;
using WowPacketParser.Misc;
using WowPacketParser.Store.Objects.UpdateFields;

namespace WowPacketParserModule.V11_0_0_55666.UpdateFields.V11_0_7_58123
{
    [GeneratedCode("UpdateFieldCodeGenerator.Formats.WowPacketParserHandler", "1.0.0.0")]
    public class UnitData : IMutableUnitData
    {
        public System.Nullable<int> DisplayID { get; set; }
        public System.Nullable<uint> NpcFlags { get; set; }
        public System.Nullable<uint> NpcFlags2 { get; set; }
        public System.Nullable<uint> StateSpellVisualID { get; set; }
        public System.Nullable<uint> StateAnimID { get; set; }
        public System.Nullable<uint> StateAnimKitID { get; set; }
        public System.Nullable<uint> StateWorldEffectsQuestObjectiveID { get; set; }
        public System.Nullable<int> SpellOverrideNameID { get; set; }
        public System.Nullable<uint>[] StateWorldEffectIDs { get; set; }
        public WowGuid Charm { get; set; }
        public WowGuid Summon { get; set; }
        public WowGuid Critter { get; set; }
        public WowGuid CharmedBy { get; set; }
        public WowGuid SummonedBy { get; set; }
        public WowGuid CreatedBy { get; set; }
        public WowGuid DemonCreator { get; set; }
        public WowGuid LookAtControllerTarget { get; set; }
        public WowGuid Target { get; set; }
        public WowGuid BattlePetCompanionGUID { get; set; }
        public System.Nullable<ulong> BattlePetDBID { get; set; }
        public IUnitChannel ChannelData { get; set; }
        public System.Nullable<sbyte> SpellEmpowerStage { get; set; }
        public System.Nullable<uint> SummonedByHomeRealm { get; set; }
        public System.Nullable<byte> Race { get; set; }
        public System.Nullable<byte> ClassId { get; set; }
        public System.Nullable<byte> PlayerClassId { get; set; }
        public System.Nullable<byte> Sex { get; set; }
        public System.Nullable<byte> DisplayPower { get; set; }
        public System.Nullable<uint> OverrideDisplayPowerID { get; set; }
        public System.Nullable<long> Health { get; set; }
        public System.Nullable<int>[] Power { get; } = new System.Nullable<int>[10];
        public System.Nullable<int>[] MaxPower { get; } = new System.Nullable<int>[10];
        public System.Nullable<float>[] PowerRegenFlatModifier { get; } = new System.Nullable<float>[10];
        public System.Nullable<float>[] PowerRegenInterruptedFlatModifier { get; } = new System.Nullable<float>[10];
        public System.Nullable<long> MaxHealth { get; set; }
        public System.Nullable<int> Level { get; set; }
        public System.Nullable<int> EffectiveLevel { get; set; }
        public System.Nullable<int> ContentTuningID { get; set; }
        public System.Nullable<int> ScalingLevelMin { get; set; }
        public System.Nullable<int> ScalingLevelMax { get; set; }
        public System.Nullable<int> ScalingLevelDelta { get; set; }
        public System.Nullable<int> ScalingFactionGroup { get; set; }
        public System.Nullable<int> FactionTemplate { get; set; }
        public IVisibleItem[] VirtualItems { get; } = new IVisibleItem[3];
        public System.Nullable<uint> Flags { get; set; }
        public System.Nullable<uint> Flags2 { get; set; }
        public System.Nullable<uint> Flags3 { get; set; }
        public System.Nullable<uint> AuraState { get; set; }
        public System.Nullable<uint>[] AttackRoundBaseTime { get; } = new System.Nullable<uint>[2];
        public System.Nullable<uint> RangedAttackRoundBaseTime { get; set; }
        public System.Nullable<float> BoundingRadius { get; set; }
        public System.Nullable<float> CombatReach { get; set; }
        public System.Nullable<float> DisplayScale { get; set; }
        public System.Nullable<int> CreatureFamily { get; set; }
        public System.Nullable<int> CreatureType { get; set; }
        public System.Nullable<int> NativeDisplayID { get; set; }
        public System.Nullable<float> NativeXDisplayScale { get; set; }
        public System.Nullable<int> MountDisplayID { get; set; }
        public System.Nullable<int> CosmeticMountDisplayID { get; set; }
        public System.Nullable<float> MinDamage { get; set; }
        public System.Nullable<float> MaxDamage { get; set; }
        public System.Nullable<float> MinOffHandDamage { get; set; }
        public System.Nullable<float> MaxOffHandDamage { get; set; }
        public System.Nullable<byte> StandState { get; set; }
        public System.Nullable<byte> PetTalentPoints { get; set; }
        public System.Nullable<byte> VisFlags { get; set; }
        public System.Nullable<byte> AnimTier { get; set; }
        public System.Nullable<uint> PetNumber { get; set; }
        public System.Nullable<uint> PetNameTimestamp { get; set; }
        public System.Nullable<uint> PetExperience { get; set; }
        public System.Nullable<uint> PetNextLevelExperience { get; set; }
        public System.Nullable<float> ModCastingSpeed { get; set; }
        public System.Nullable<float> ModCastingSpeedNeg { get; set; }
        public System.Nullable<float> ModSpellHaste { get; set; }
        public System.Nullable<float> ModHaste { get; set; }
        public System.Nullable<float> ModRangedHaste { get; set; }
        public System.Nullable<float> ModHasteRegen { get; set; }
        public System.Nullable<float> ModTimeRate { get; set; }
        public System.Nullable<int> CreatedBySpell { get; set; }
        public System.Nullable<int> EmoteState { get; set; }
        public System.Nullable<int>[] Stats { get; } = new System.Nullable<int>[4];
        public System.Nullable<int>[] StatPosBuff { get; } = new System.Nullable<int>[4];
        public System.Nullable<int>[] StatNegBuff { get; } = new System.Nullable<int>[4];
        public System.Nullable<int>[] StatSupportBuff { get; } = new System.Nullable<int>[4];
        public System.Nullable<int>[] Resistances { get; } = new System.Nullable<int>[7];
        public System.Nullable<int>[] BonusResistanceMods { get; } = new System.Nullable<int>[7];
        public System.Nullable<int>[] ManaCostModifier { get; } = new System.Nullable<int>[7];
        public System.Nullable<int> BaseMana { get; set; }
        public System.Nullable<int> BaseHealth { get; set; }
        public System.Nullable<byte> SheatheState { get; set; }
        public System.Nullable<byte> PvpFlags { get; set; }
        public System.Nullable<byte> PetFlags { get; set; }
        public System.Nullable<byte> ShapeshiftForm { get; set; }
        public System.Nullable<int> AttackPower { get; set; }
        public System.Nullable<int> AttackPowerModPos { get; set; }
        public System.Nullable<int> AttackPowerModNeg { get; set; }
        public System.Nullable<float> AttackPowerMultiplier { get; set; }
        public System.Nullable<int> AttackPowerModSupport { get; set; }
        public System.Nullable<int> RangedAttackPower { get; set; }
        public System.Nullable<int> RangedAttackPowerModPos { get; set; }
        public System.Nullable<int> RangedAttackPowerModNeg { get; set; }
        public System.Nullable<float> RangedAttackPowerMultiplier { get; set; }
        public System.Nullable<int> RangedAttackPowerModSupport { get; set; }
        public System.Nullable<int> MainHandWeaponAttackPower { get; set; }
        public System.Nullable<int> OffHandWeaponAttackPower { get; set; }
        public System.Nullable<int> RangedWeaponAttackPower { get; set; }
        public System.Nullable<int> SetAttackSpeedAura { get; set; }
        public System.Nullable<float> Lifesteal { get; set; }
        public System.Nullable<float> MinRangedDamage { get; set; }
        public System.Nullable<float> MaxRangedDamage { get; set; }
        public System.Nullable<float> ManaCostMultiplier { get; set; }
        public System.Nullable<float> MaxHealthModifier { get; set; }
        public System.Nullable<float> HoverHeight { get; set; }
        public System.Nullable<int> MinItemLevelCutoff { get; set; }
        public System.Nullable<int> MinItemLevel { get; set; }
        public System.Nullable<int> MaxItemLevel { get; set; }
        public System.Nullable<int> AzeriteItemLevel { get; set; }
        public System.Nullable<int> WildBattlePetLevel { get; set; }
        public System.Nullable<int> BattlePetCompanionExperience { get; set; }
        public System.Nullable<uint> BattlePetCompanionNameTimestamp { get; set; }
        public System.Nullable<int> InteractSpellID { get; set; }
        public System.Nullable<int> ScaleDuration { get; set; }
        public System.Nullable<int> LooksLikeMountID { get; set; }
        public System.Nullable<int> LooksLikeCreatureID { get; set; }
        public System.Nullable<int> LookAtControllerID { get; set; }
        public System.Nullable<int> PerksVendorItemID { get; set; }
        public System.Nullable<int> TaxiNodesID { get; set; }
        public WowGuid GuildGUID { get; set; }
        public System.Nullable<int> FlightCapabilityID { get; set; }
        public System.Nullable<float> GlideEventSpeedDivisor { get; set; }
        public System.Nullable<int> MaxHealthModifierFlatNeg { get; set; }
        public System.Nullable<int> MaxHealthModifierFlatPos { get; set; }
        public System.Nullable<uint> SilencedSchoolMask { get; set; }
        public System.Nullable<uint> CurrentAreaID { get; set; }
        public System.Nullable<float> Field_31C { get; set; }
        public System.Nullable<float> Field_320 { get; set; }
        public WowGuid NameplateAttachToGUID { get; set; }
        public DynamicUpdateField<IPassiveSpellHistory> PassiveSpells { get; } = new DynamicUpdateField<IPassiveSpellHistory>();
        public DynamicUpdateField<System.Nullable<int>> WorldEffects { get; } = new DynamicUpdateField<System.Nullable<int>>();
        public DynamicUpdateField<WowGuid> ChannelObjects { get; } = new DynamicUpdateField<WowGuid>();
        public System.Nullable<bool> Field_314 { get; set; }

        uint?[] IUnitData.NpcFlags => new[] { NpcFlags, NpcFlags2 };
    }
}
