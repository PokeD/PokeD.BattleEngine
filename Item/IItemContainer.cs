namespace PokeD.BattleEngine.Item
{
    public interface IItemContainer
    {
        void AttachItem(IItemInstance item);
        void RemoveItem(IItemInstance item);

        bool HoldsItem(IItemStaticData item);
    }
    public interface IItemListContainer
    {
        void AttachItem(IItemInstance item);
        void RemoveItem(IItemInstance item);

        bool HoldsItem(IItemStaticData item);
    }
}