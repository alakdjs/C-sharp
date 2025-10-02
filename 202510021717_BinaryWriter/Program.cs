using System.IO;

namespace _202510021717_BinaryWriter
{
    enum ItemType
    {
        Consumable, // 소모성
        UnConsumable // 비소모성
    }
    struct Item
    {
        public int itemNum;
        public string Name;
        public ItemType type;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Item[] datas = new Item[4];
            datas[0].itemNum = 1;
            datas[0].Name = "Gold";
            datas[0].type = ItemType.Consumable;

            datas[1].itemNum = 2;
            datas[1].Name = "potion";
            datas[1].type = ItemType.Consumable;

            datas[2].itemNum = 3;
            datas[2].Name = "Silver";
            datas[2].type = ItemType.Consumable;

            datas[3].itemNum = 4;
            datas[3].Name = "Weapon";
            datas[3].type = ItemType.UnConsumable;

            using (FileStream fstream = new FileStream("C:\\Save\\Item.bin", FileMode.Create))
            {
                BinaryWriter writer = new BinaryWriter(fstream);

                foreach(Item data in datas)
                {
                    writer.Write(data.itemNum);
                    writer.Write(data.Name);
                    writer.Write((int)data.type);
                }
                writer.Close();

            }
        }
    }
}
