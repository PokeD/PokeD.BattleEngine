using System;

using PokeD.BattleEngine.Scripts;

namespace PokeD.BattleEngine.Monster.Data
{
    /*
    public class Move
    {
        public static Move None => new Move(0, 0, "NONE");

        public int ID { get; }
        public int PPUPs { get; }
        public string Name { get; }
        public IScript Script { get; }


        public Move(int id, int ppUPs, string name)
        {
            ID = id;
            PPUPs = ppUPs;
            Name = name;
        }
    }

    public class Moves
    {
        public static Moves None => new Moves();

        public Move Move_0 { get; } = Move.None;
        public Move Move_1 { get; } = Move.None;
        public Move Move_2 { get; } = Move.None;
        public Move Move_3 { get; } = Move.None;

        public Moves(params Move[] moves)
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


        public bool Contains(Move move) => Move_0 == move || Move_1 == move || Move_2 == move || Move_3 == move;
        public bool Contains(short moveID) => Move_0.ID == moveID || Move_1.ID == moveID || Move_2.ID == moveID || Move_3.ID == moveID;
    }
    */
}