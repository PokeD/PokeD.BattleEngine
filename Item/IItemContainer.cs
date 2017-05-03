namespace PokeD.BattleEngine.Item
{
    public interface IItemContainer
    {
        void Attach(IItem item);
        void Remove(IItem item);

        bool HoldsItem(int id);
    }
}