using System.Collections.Generic;

namespace PokeD.BattleEngine.Item
{
    public class Bag : IItemContainer
    {
        public List<IItem> Items { get; } = new List<IItem>();

        public void Attach(IItem item) => Items.Add(item);
        public void Remove(IItem item) => Items.Remove(item);


        public bool HoldsItem(int id) => Items.Exists(item => item.ID == id);
    }
}