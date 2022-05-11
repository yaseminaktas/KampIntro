using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSimulator.Concrete
{
    class GameManager : IGameService
    {
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi.");
        }

        public void Save(Game game)
        {
            Console.WriteLine("Yeni oyun eklendi");
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
