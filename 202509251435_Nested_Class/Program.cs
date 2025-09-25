using System;
using System.Collections.Generic;

namespace _202509251435_Nested_Class
{
    // 중첩클래스
    // 클래스 안에 클래스를 정의하는 것을 중첩클래스 라고 함.
    // 클래스 내부에서만 사용되기 때문에 코드를 더 쉽게 파악할 수 있다. 유지관리가 쉽다.
    // 클래스 구조가 단순해진다.
    // 클래스 외부에 공개하고 싶지 않은 형식을 만들고자 할 때.

    class Configuration
    {
        List<ItemValue> listConfig = new List<ItemValue>();

        public void SetConfig(string item, string value)
        {
            ItemValue iv = new ItemValue();
            iv.SetValue(this, item, value);
        }

        public string GetConfig(string item)
        {
            foreach(ItemValue iv in listConfig)
            {
                if(iv.GetItem() == item)
                    return iv.GetValue();
            }

            return "";
        }

        private class ItemValue // 중첩클래스
        {
            private string item;
            private string value;

            public void SetValue(Configuration config, string item, string value)
            {
                this.item = item;
                this.value = value;

                bool found = false;
                for(int i = 0; i < config.listConfig.Count; i++)
                {
                    if (config.listConfig[i].item == item)
                    {
                        config.listConfig[i] = this;
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    config.listConfig.Add(this);
            }

            public string GetItem() { return item; }

            public string GetValue() { return value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.SetConfig("Version", "V 5.0");
            config.SetConfig("Size", "655,324 KB");

            Console.WriteLine(config.GetConfig("Version"));
            Console.WriteLine(config.GetConfig("Size"));

            config.SetConfig("Version", "V 5.0.1");

            Console.WriteLine(config.GetConfig("Version"));
        }
    }
}
