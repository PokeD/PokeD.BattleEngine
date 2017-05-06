using PokeD.BattleEngine.Monster;

namespace PokeD.BattleEngine.Attack
{
    /*
    public interface IAttack
    {
        int ID { get; }
    }
    */

    public interface IAttackInstance
    {
        IAttackStaticData StaticData { get; }

        IMonsterStaticData User { get; }

        byte PPCurrent { get; }
        byte PPUps { get; }
    }
}