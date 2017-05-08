using PokeD.BattleEngine.Attack.Data;
using PokeD.BattleEngine.Monster.Data;
using PokeD.BattleEngine.Scripts;

namespace PokeD.BattleEngine.Attack
{
    public interface IAttackStaticData
    {
        short ID { get; }
        string Name { get; }
        MonsterType Type { get; }

        Target Target { get; }
        DamageClass DamageClass { get; }
        Condition AttackCondition { get; }

        byte Power { get; }
        byte Accuracy { get; }
        byte Priority { get; }

        byte PP { get; }

        //byte StatusEffectChance { get; }
        //MonsterType StatusEffectType { get; }

        IScript Script { get; }
    }
}