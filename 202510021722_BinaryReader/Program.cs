using System;
using System.IO;
using System.Collections.Generic;

namespace _202510021341_BinaryReader
{
    enum ItemType
    {
        Consumable,
        UnConsumable
    }
    struct Item
    {
        public int itemNum;
        public string Name;
        public ItemType type;

        public override string ToString()
        {
            return $"아이템번호: {itemNum}, 아이템이름: {Name}, 아이템 타입: {type}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Item> datas = new List<Item>();
            using (FileStream fstream = new FileStream("C:\\Save\\Item.bin", FileMode.Open))
            {
                BinaryReader reader = new BinaryReader(fstream);

                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    Item data = new Item();
                    data.itemNum = reader.ReadInt32();
                    data.Name = reader.ReadString();
                    data.type = (ItemType)reader.ReadInt32();

                    datas.Add(data);
                }

                reader.Close();
            }


            foreach (Item data in datas)
            {
                Console.WriteLine(data);
            }

        }
    }
}

