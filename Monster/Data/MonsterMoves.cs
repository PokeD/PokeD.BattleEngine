using System;

namespace PokeD.BattleEngine.Monster.Data
{
    public class MonsterMove
    {
        public static MonsterMove None => new MonsterMove(0, 0, "NONE");

        public int ID { get; }
        public int PPUPs { get; }
        public string Name { get; }
        public IScript Script { get; }


        public MonsterMove(int id, int ppUPs, string name)
        {
            ID = id;
            PPUPs = ppUPs;
            Name = name;
        }
    }

    public class MonsterMoves
    {
        public static MonsterMoves None => new MonsterMoves();

        public MonsterMove Move_0 { get; } = MonsterMove.None;
        public MonsterMove Move_1 { get; } = MonsterMove.None;
        public MonsterMove Move_2 { get; } = MonsterMove.None;
        public MonsterMove Move_3 { get; } = MonsterMove.None;

        public MonsterMoves(params MonsterMove[] moves)
        {
            if (moves.Length > 0)
                Move_0 = moves[0];

            if (moves.Length > 1)
                Move_1 = moves[1];

            if (moves.Length > 2)
                Move_2 = moves[2];

            if (moves.Length > 3)
                Move_3 = moves[3];

            if (moves.Length > 4)
                throw new ArgumentOutOfRangeException();
        }


        public bool Contains(MonsterMove move) => Move_0 == move || Move_1 == move || Move_2 == move || Move_3 == move;
        public bool Contains(short moveID) => Move_0.ID == moveID || Move_1.ID == moveID || Move_2.ID == moveID || Move_3.ID == moveID;
    }
}