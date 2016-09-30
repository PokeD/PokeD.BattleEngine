using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterAbility
    {
        public static MonsterAbility None => new MonsterAbility(0, "NONE");

        public int ID { get; }
        public string Name { get; }

        public MonsterAbility(int id, string name) { ID = id; Name = name; }

        public override string ToString() => $"{Name}, ID: {ID}";
    }

    public class MonsterAbilities
    {
        public static MonsterAbilities None => new MonsterAbilities();

        public MonsterAbility Ability_0 { get; } = MonsterAbility.None;
        public MonsterAbility Ability_1 { get; } = MonsterAbility.None;
        public MonsterAbility Ability_2 { get; } = MonsterAbility.None;

        public MonsterAbilities(params MonsterAbility[] abilities)
        {
            if (abilities.Length > 0)
                Ability_0 = abilities[0];

            if (abilities.Length > 1)
                Ability_1 = abilities[1];

            if (abilities.Length > 2)
                Ability_2 = abilities[2];

            if (abilities.Length > 3)
                throw new ArgumentOutOfRangeException();
        }

        public override string ToString() => $"Ability1: {Ability_0}; Ability2: {Ability_1}";


        public bool Contains(MonsterAbility ability) => Ability_0 == ability || Ability_1 == ability || Ability_2 == ability;
        public bool Contains(short abilityID) => Ability_0.ID == abilityID || Ability_1.ID == abilityID || Ability_2.ID == abilityID;
    }
}