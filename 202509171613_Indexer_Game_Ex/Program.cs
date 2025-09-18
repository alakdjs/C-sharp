using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202509171613_Indexer_Game_Ex
{
    public enum GameGenre
    {
        Rpg,
        Action,
        Adventure,
        Fps
    }

    public struct GameTitle
    {
        public string _name;    // 게임명
        public string _releaseDate; // 출시 년월일
        public GameGenre _type; // 게임 종류

        public GameTitle(string name, string releaseDate, GameGenre type)
        {
            _name = name;
            _releaseDate = releaseDate;
            _type = type;
        }
    }

    // 인덱서를 사용하지 않음
    public class GameTitleData
    {
        private List<GameTitle> datas = new List<GameTitle>();

        public void addGameTitle(GameTitle data)
        {
            datas.Add(data);
        }

        public GameTitle getGameTitle(int index)
        {
            return datas[index];
        }

        public GameTitle findGameTitle(string gameName)
        {
            for(int i = 0; i < datas.Count; i++)
            {
                if (datas[i]._name == gameName)
                {
                    return datas[i];
                }
            }

            return new GameTitle("없음", "0000", GameGenre.Action);
        }
    }

    public class GameTitleDataIndexer // 인덱서를 사용
    {
        private List<GameTitle> datas = new List<GameTitle>(10);

        // indexer
        public GameTitle this[int index]
        {
            get { return datas[index]; }
            set
            {
                if (datas.Count == 0)
                {
                    datas.Add(value);
                }
                else if (datas.Count <= index)
                {
                    datas.Add(value);
                }
                else
                {
                    datas[index] = value;
                }
            }
        }

        public GameTitle FindGameTitle(string gameName)
        {
            for(int i = 0; i < datas.Count; i++)
            {
                if (datas[i]._name == gameName)
                {
                    return datas[i];
                }
            }

            return new GameTitle("없음", "0000", GameGenre.Action);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            GameTitleData gameData = new GameTitleData();
            gameData.addGameTitle(new GameTitle("리니지", "19951110", GameGenre.Rpg));
            gameData.addGameTitle(new GameTitle("리니지1", "19951110", GameGenre.Rpg));
            gameData.addGameTitle(new GameTitle("리니지2", "19951110", GameGenre.Rpg));
            gameData.addGameTitle(new GameTitle("리니지3", "19951110", GameGenre.Rpg));

            GameTitle data = gameData.getGameTitle(0);

            Console.WriteLine($"제목:{data._name}, 출시년월일: {data._releaseDate}, 게임장르: {data._type.ToString()}");


            GameTitleDataIndexer gameData2 = new GameTitleDataIndexer();
            gameData2[0] = new GameTitle("리니지", "19951110", GameGenre.Rpg);
            gameData2[1] = new GameTitle("리니지1", "19951110", GameGenre.Rpg);
            gameData2[2] = new GameTitle("리니지2", "19951110", GameGenre.Rpg);
            gameData2[3] = new GameTitle("리니지3", "19951110", GameGenre.Rpg);

            Console.WriteLine($"제목:{gameData2[0]._name}, 출시년월일: {gameData2[0]._releaseDate}, 게임장르:{gameData2[0]._type.ToString()}");

            gameData2[2] = new GameTitle("리니지2-1", "19951110", GameGenre.Rpg);
            Console.WriteLine($"제목:{gameData2[2]._name}, 출시년월일: {gameData2[2]._releaseDate}, 게임쟝르:{gameData2[2]._type.ToString()}");
        }
    }
}
