using pg.data.data.objects.parameters.impl;

namespace pg.data.data.objects.gameobjects.impl
{
    public sealed class AbsorbBlasterAbility : AbstractGameObjectType
    {
        public StringParameter AbsorbChance { get; } = new StringParameter("absorb_chance");
        public StringParameter DamageAbsorbPercentage { get; } = new StringParameter("damage_absorb_percentage");
        public StringParameter DamageAbsorbAmount { get; } = new StringParameter("damage_absorb_amount");
        
        public AbsorbBlasterAbility(string id) : base(id)
        {
        }
    }
}