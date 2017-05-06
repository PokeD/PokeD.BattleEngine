using System.Collections.Generic;

namespace PokeD.BattleEngine.Item
{
    public class Bag : IItemContainer
    {
        public List<IItemInstance> Items { get; } = new List<IItemInstance>();

        public void AttachItem(IItemInstance item) => Items.Add(item);
        public void RemoveItem(IItemInstance item) => Items.Remove(item);


        public bool HoldsItem(IItemStaticData item) => Items.Exists(i => i.StaticData == item);
    }
}