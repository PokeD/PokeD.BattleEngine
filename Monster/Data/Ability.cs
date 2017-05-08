using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class Ability
    {
        public static Ability None => new Ability(0, "NONE");

        public int ID { get; }
        public string Name { get; }
        public bool IsHidden { get; }

        public Ability(int id, string name, bool isHidden = false) { ID = id; Name = name; IsHidden = isHidden; }

        public override string ToString() => $"{Name}";
    }

    public class Abilities
    {
        public static Abilities None => new Abilities();

        public Ability Ability_0 { get; } = Ability.None;
        public Ability Ability_1 { get; } = Ability.None;
        public Ability Ability_2 { get; } = Ability.None;

        public Abilities(params Ability[] abilities)
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

        public override string ToString() => $"{Ability_0}, {Ability_1}";


        public bool Contains(Ability ability) => Ability_0 == ability || Ability_1 == ability || Ability_2 == ability;
        public bool Contains(short abilityID) => Ability_0.ID == abilityID || Ability_1.ID == abilityID || Ability_2.ID == abilityID;
    }
}