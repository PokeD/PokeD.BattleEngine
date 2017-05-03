using System;
using PokeD.BattleEngine.Trainer;

namespace PokeD.BattleEngine.Battle
{
    public class AdjacentTrainers
    {
        public int TrainerID { get; }

        public ITrainer Left { get; }
        public ITrainer Right { get; }

        public AdjacentTrainers(int trainerID, ITrainer left, ITrainer right)
        {
            TrainerID = trainerID;

            Left = left;
            Right = right;
        }
    }
    public class TrainerList
    {
        public byte Sides { get; }
        public byte Trainers { get; }
        private ITrainer[] _trainers;


        public TrainerList(byte sides, byte trainers)
        {
            if (sides > 4)
                throw new ArgumentOutOfRangeException();
            if (trainers > 3)
                throw new ArgumentOutOfRangeException();

            Sides = sides;
            Trainers = trainers;

            _trainers = new ITrainer[Sides * Trainers];
        }

        //public ITrainer this[int id] { get { return _trainers.Single(trainer => trainer.ID == id); } }
        public ITrainer this[byte index] { get { return _trainers[index]; } set { _trainers[index] = value; } }
        public ITrainer this[byte side, byte trainerPos]
        {
            get
            {
                if (side > 4)
                    throw new IndexOutOfRangeException();
                if (trainerPos > 3)
                    throw new IndexOutOfRangeException();

                return _trainers[Sides * (side - 1) + (trainerPos - 1)];
            }
            set
            {
                if (side > 4)
                    throw new IndexOutOfRangeException();
                if (trainerPos > 3)
                    throw new IndexOutOfRangeException();

                _trainers[Sides * (side - 1) + (trainerPos - 1)] = value;
            }
        }

        public Tuple<byte, byte> GetTrainerInfo(int trainerID)
        {
            for (byte side = 0; side < Sides; side++)
                for (byte trainerPos = 0; trainerPos < Trainers; trainerPos++)
                    if(this[side, trainerPos].ID == trainerID)
                        return new Tuple<byte, byte>(side, trainerPos);

            return new Tuple<byte, byte>(0, 0);
        }
        public AdjacentTrainers GetAdjacentTrainers(int trainerID)
        {
            ITrainer left = null;
            ITrainer right = null;

            var trainerInfo = GetTrainerInfo(trainerID);
            if (trainerInfo.Item2 > 0)
                left = this[trainerInfo.Item1, trainerInfo.Item2];
            if (trainerInfo.Item2 < 3)
                right = this[trainerInfo.Item1, trainerInfo.Item2];

            return new AdjacentTrainers(trainerID, left, right);
        }
    }
}
