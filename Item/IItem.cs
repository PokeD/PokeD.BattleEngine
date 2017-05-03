namespace PokeD.BattleEngine.Item
{
    public interface IItem
    {
        int ID { get; }

        IItemContainer Holder { get; }
    }
}