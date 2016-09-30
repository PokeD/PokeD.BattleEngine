using PokeD.BattleEngine.Attack.Data;

namespace PokeD.BattleEngine.Attack
{
    public interface IAttackStaticData
    {
        short ID { get; }
        string Name { get; }

        AttackTarget AttackTarget { get; }
        AttackCategory DamageCategory { get; }
        AttackCondition AttackCondition { get; }

        byte Power { get; }
        byte Accuracy { get; }
        byte Priority { get; }

        byte PP { get; }
        byte PPMax { get; }

        byte StatusEffectChance { get; }
        PokeType StatusEffectType { get; }

        IScript Script { get; }
    }
}