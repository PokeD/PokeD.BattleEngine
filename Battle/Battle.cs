using System.Collections.Generic;

using PokeD.BattleEngine.Attack;
using PokeD.BattleEngine.Monster;
using PokeD.BattleEngine.Trainer;

namespace PokeD.Core.Data.PokeD.Battle
{
    public class BattleTrainer
    {
        public int TrainerID { get; }

        public List<BattleAction> ActionHistory { get; }

        public IMonsterInstanceData[] Monsters { get; }

        public BattleTrainer(ITrainerInstanceData trainer)
        {

        }
    }
    public class BattleSide
    {
        public BattleSide(params BattleTrainer[] sideTrainers)
        {

        }
    }
    public class BattleFieldInfo
    {
        public BattleFieldInfo(BattleSide sideA, BattleSide sideB)
        {

        }

        public BattleFieldInfo(BattleSide sideA, BattleSide sideB, BattleSide sideC, BattleSide sideD)
        {

        }
    }


    public abstract class BattleAction
    {
    }
    public class BattleActionAttack : BattleAction
    {
        public int TargetID { get; }
        public IAttackInstanceData Attack { get; }
    }
    public class BattleActionItem : BattleAction
    {
        //public IItemInstanceData Item { get; }
    }
    public class BattleActionSwitch : BattleAction
    {
        public IMonsterInstanceData Monster { get; }
    }
    public class BattleActionFlee : BattleAction
    {

    }
    public class Battle
    {
        public Battle(BattleFieldInfo info)
        {

        }


        public bool Step()
        {
            return false;
        }
    }
}
