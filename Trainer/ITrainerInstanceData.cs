using PokeD.BattleEngine.Trainer.Data;

namespace PokeD.BattleEngine.Trainer
{
    public interface ITrainerInstanceData
    {
        ITrainerStaticData StaticData { get; }

        string Name { get; }
        short TrainerID { get; }
        short SecretID { get; }

        Gender Gender { get; }
    }
}