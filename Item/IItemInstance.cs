namespace PokeD.BattleEngine.Item
{
    public interface IItemInstance
    {
        IItemStaticData StaticData { get; }

        IItemContainer Holder { get; }
    }
}