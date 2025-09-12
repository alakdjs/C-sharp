using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509111502_GlobalData
{
    class GlobalData
    {
        private static int _score;
        private static int volume;
        private static int _stage;

        public static int Score // 정적 property
        {
            set => _score = value;
            get => _score;
        }

        public static int Volume
        {
            set => volume = value;
            get => volume;
        }

        public static int Stage
        {
            get => _stage;
            set => _stage = value;
        }
    }
}
