using System;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Monster
{
    internal class Dragon : Monster
    {
        public Dragon(string name, int health, int defense, int attack)
            : base(name, health, defense, attack) { }
    }
}
