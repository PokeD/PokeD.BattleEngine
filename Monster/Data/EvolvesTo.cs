using System.Collections.Generic;

using PokeD.BattleEngine.Attack;
using PokeD.BattleEngine.Battle.Data;
using PokeD.BattleEngine.Item;

namespace PokeD.BattleEngine.Monster.Data
{
    public class EvolvesTo
    {
        public interface IEvolutionCondition
        {
            IList<ISubEvolutionCondition> SubConditions { get; }
        }
        public class ByLevelUp : IEvolutionCondition
        {
            public IList<ISubEvolutionCondition> SubConditions { get; }

            public ByLevelUp(IList<ISubEvolutionCondition> subConditions) { SubConditions = subConditions; }

            public override string ToString() => $"By LevelUp";
        }
        public class ByItemUse : IEvolutionCondition
        {
            public IList<ISubEvolutionCondition> SubConditions { get; }

            public ByItemUse(IList<ISubEvolutionCondition> subConditions) { SubConditions = subConditions; }

            public override string ToString() => $"By Item Use";
        }
        public class ByTrade : IEvolutionCondition
        {
            public IList<ISubEvolutionCondition> SubConditions { get; }

            public ByTrade(IList<ISubEvolutionCondition> subConditions) { SubConditions = subConditions; }

            public override string ToString() => $"By Trade";
        }

        public interface ISubEvolutionCondition { }
        public class ByLevel : ISubEvolutionCondition
        {
            public byte Level { get; }

            public ByLevel(byte level) { Level = level; }

            public override string ToString() => $"Level [{Level:000}]";
        }
        public class ByHappiness : ISubEvolutionCondition
        {
            public byte Happiness { get; }

            public ByHappiness(byte happiness) { Happiness = happiness; }

            public override string ToString() => $"Happiness [{Happiness:000}]";
        }
        public class ByAffection : ISubEvolutionCondition
        {
            public byte Affection { get; }

            public ByAffection(byte affection) { Affection = affection; }

            public override string ToString() => $"Affection [{Affection:000}]";
        }
        public class ByAttack : ISubEvolutionCondition
        {
            public IAttackStaticData Attack { get; }

            public ByAttack(IAttackStaticData attack) { Attack = attack; }

            public override string ToString() => $"Attack [{Attack}]";
        }
        public class ByArea : ISubEvolutionCondition
        {
            public object Area { get; }

            public ByArea(object area) { Area = area; }

            public override string ToString() => $"Area [{Area}]";
        }
        public class ByTimeOfDay : ISubEvolutionCondition
        {
            public enum TimeOfDay
            {
                Day,
                Night
            }

            public TimeOfDay Time { get; }

            public ByTimeOfDay(TimeOfDay time) { Time = time; }

            public override string ToString() => $"Time Of Day [{Time}]";
        }
        public class ByItem : ISubEvolutionCondition
        {
            public IItemStaticData Item { get; }

            public ByItem(IItemStaticData item) { Item = item; }

            public override string ToString() => $"Item [{Item}]";
        }
        public class ByHeldItem : ISubEvolutionCondition
        {
            public IItemStaticData HeldItem { get; }

            public ByHeldItem(IItemStaticData heldItem) { HeldItem = heldItem; }

            public override string ToString() => $"Held Item [{HeldItem}]";
        }
        public class ByGender : ISubEvolutionCondition
        {
            public Gender Gender { get; }

            public ByGender(Gender gender) { Gender = gender; }

            public override string ToString() => $"Gender [{Gender}]";
        }
        public class ByBeauty : ISubEvolutionCondition
        {
            public byte Beauty { get; }

            public ByBeauty(byte beauty) { Beauty = beauty; }

            public override string ToString() => $"Beauty [{Beauty:00}]";
        }
        public class ByMonsterInTeam : ISubEvolutionCondition
        {
            public short MonsterID { get; }

            public ByMonsterInTeam(short monsterID) { MonsterID = monsterID; }

            public override string ToString() => $"Monster In Team [{MonsterID}]";
        }
        public class ByWeather : ISubEvolutionCondition
        {
            public Weather Weather { get; }

            public ByWeather(Weather weather) { Weather = weather; }

            public override string ToString() => $"Weather [{Weather}]";
        }
        public class ByKnownAttackType : ISubEvolutionCondition
        {
            public MonsterType AttackType { get; }

            public ByKnownAttackType(MonsterType attackType) { AttackType = attackType; }

            public override string ToString() => $"Known Attack Type [{AttackType}]";
        }
        public class ByTradeMonster : ISubEvolutionCondition
        {
            public short MonsterID { get; }

            public ByTradeMonster(short monsterID) { MonsterID = monsterID; }

            public override string ToString() => $"Trade Monster [{MonsterID}]";
        }




        public IMonsterStaticData Monster { get; }

        public IList<IEvolutionCondition> EvolutionConditions { get; } = new List<IEvolutionCondition>();


        public EvolvesTo(IMonsterStaticData monster, IList<IEvolutionCondition> evolutionConditions) { Monster = monster; EvolutionConditions = evolutionConditions; }

        public override string ToString() => $"{Monster}";
    }
}
