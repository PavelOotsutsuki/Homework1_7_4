using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Homework1_7_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTopByLevel = 3;
            int countTopByPower = 3;

            GameStatistics gameStatistics = new GameStatistics();
            gameStatistics.ShowTopByLevel(countTopByLevel);
            gameStatistics.ShowTopByPower(countTopByPower);
        }
    }

    class Player
    {
        public Player (string name, int level, int power)
        {
            Name = name;
            Level = level;
            Power = power;
        }

        public string Name { get; private set; }
        public int Level { get; private set; }
        public int Power { get; private set; }
    }

    class GameStatistics
    {
        private List<Player> _players;

        public GameStatistics()
        {
            _players = new List<Player>()
            {
                new Player("Пупок228", 2, 30),
                new Player("СуперМолот", 50, 3000),
                new Player("Каспер", 34, 2900),
                new Player("Леденец", 17, 2300),
                new Player("Кока_и_кола", 3, 125),
                new Player("ЯРУСКИЙ", 8, 100),
                new Player("КатюшаУжеНаБерегу", 44, 2700),
                new Player("СынПупка", 1, 20),
                new Player("ДлинныйКарандаш", 49, 2400),
                new Player("МамаАмаКриминал", 34, 2000),
            };
        }

        public void ShowTopByLevel(int countTopElements)
        {
            var filtredPlayers = _players.OrderByDescending(player => player.Level).Take(countTopElements);
            Console.WriteLine($"Топ {countTopElements} по уровню:");
            ShowPlayers(filtredPlayers);
        }

        public void ShowTopByPower(int countTopElements)
        {
            var filtredPlayers = _players.OrderByDescending(player => player.Power).Take(countTopElements);
            Console.WriteLine($"Топ {countTopElements} по силе:");
            ShowPlayers(filtredPlayers);
        }

        private void ShowPlayers(IEnumerable <Player> players)
        {
            int number = 1;

            foreach (var player in players)
            {
                Console.WriteLine($"{number++}. {player.Name}");
            }
        }
    }
}