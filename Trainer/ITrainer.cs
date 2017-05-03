using PokeD.BattleEngine.Battle;
using PokeD.BattleEngine.Item;
using PokeD.BattleEngine.Monster;
using PokeD.BattleEngine.Trainer.Data;

namespace PokeD.BattleEngine.Trainer
{
    public interface ITrainer : IItemContainer
    {
        int ID { get; }

        IIMonsterTeam Team { get; }
        
        IMonsterInstance ForceSwitch(IMonsterInstance toBeSwitchedOut);

        Turn DoTurn();
    }
}