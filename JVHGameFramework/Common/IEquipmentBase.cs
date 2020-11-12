namespace JVHGameFramework.Common
{
    public interface IEquipmentBase
    {
        bool AttackWeapon { get; set; }
        string Description { get; set; }
        bool Enchanted { get; set; }
        int BaseMod { get; set; }
        int Quality { get; set; }
    }
}