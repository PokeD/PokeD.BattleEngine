using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public enum MonsterStatType
    {
        HP              = 1,
        Attack          = 2,
        Defense         = 3,
        SpecialAttack   = 4,
        SpecialDefense  = 5,
        Speed           = 6
    }
    public class MonsterStats
    {
        public static MonsterStats None => new MonsterStats(0, 0, 0, 0, 0, 0);

        public short HP { get; }
        public short Attack { get; }
        public short Defense { get; }
        public short SpecialAttack { get; }
        public short SpecialDefense { get; }
        public short Speed { get; }

        public short this[MonsterStatType statType]
        {
            get
            {
                switch (statType)
                {
                    case MonsterStatType.HP:
                        return HP;
                    case MonsterStatType.Attack:
                        return Attack;
                    case MonsterStatType.Defense:
                        return Defense;
                    case MonsterStatType.SpecialAttack:
                        return SpecialAttack;
                    case MonsterStatType.SpecialDefense:
                        return SpecialDefense;
                    case MonsterStatType.Speed:
                        return Speed;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            /*
            set
            {
                switch (statType)
                {
                    case MonsterStatType.HP:
                        HP = value;
                        break;
                    case MonsterStatType.Attack:
                        Attack = value;
                        break;
                    case MonsterStatType.Defense:
                        Defense = value;
                        break;
                    case MonsterStatType.SpecialAttack:
                        SpecialAttack = value;
                        break;
                    case MonsterStatType.SpecialDefense:
                        SpecialDefense = value;
                        break;
                    case MonsterStatType.Speed:
                        Speed = value;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            */
        }
        
        public MonsterStats(short hp, short attack, short defense, short specialAttack, short specialDefense, short speed)
        {
            HP = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            Speed = speed;
        }
        
        public override string ToString() => $"HP: {HP}, Atk: {Attack}, Def: {Defense}, SpAtt: {SpecialAttack}, SpDef: {SpecialDefense}, Spe: {Speed}";

        public short GetStat(MonsterStatType statType)
        {
            switch (statType)
            {
                case MonsterStatType.HP:
                    return HP;
                case MonsterStatType.Attack:
                    return Attack;
                case MonsterStatType.Defense:
                    return Defense;
                case MonsterStatType.SpecialAttack:
                    return SpecialAttack;
                case MonsterStatType.SpecialDefense:
                    return SpecialDefense;
                case MonsterStatType.Speed:
                    return Speed;
            }

            return 0;
        }

        public bool IsValidIV()
        {
            return (HP >= 0 && HP <= 31) &&
                   (Attack >= 0 && Attack <= 31) &&
                   (Defense >= 0 && Defense <= 31) &&
                   (SpecialAttack >= 0 && SpecialAttack <= 31) &&
                   (SpecialDefense >= 0 && SpecialDefense <= 31) &&
                   (Speed >= 0 && Speed <= 31);
        }

        public bool IsValidEV()
        {
            // TODO: 255 or 252?
            return (HP >= 0 && HP <= 255) &&
                   (Attack >= 0 && Attack <= 255) &&
                   (Defense >= 0 && Defense <= 255) &&
                   (SpecialAttack >= 0 && SpecialAttack <= 255) &&
                   (SpecialDefense >= 0 && SpecialDefense <= 255) &&
                   (Speed >= 0 && Speed <= 255) &&
                   (HP + Attack + Defense + SpecialAttack + SpecialDefense + Speed <= 510);
        }
    }
}