using System;

namespace FlipFlop
{
    class Miracle : State
    {
        public override void DoMiracle(Coin coin)
        {
            Console.WriteLine("\nПроизошло чудо! Зависла в воздухе!");
        }

        public override void Flip(Coin coin)
        {
            if (coin.isMiracleEvent)
            {
                DoMiracle(coin);
            }
            else
            {
                Console.WriteLine("\nИсходное состояние: Чудо!");
                Random rand = new Random();
                double x = rand.NextDouble();
                if (x < 0.5d)
                {
                    coin.ChangeState(new Reshka(coin));
                    Console.WriteLine("А теперь Решка!");
                }
                else
                {
                    coin.ChangeState(new Orel(coin));
                    Console.WriteLine("А теперь Орёл!");
                }
            }
        }

        public Miracle(Coin coin) : base(coin)
        {
            this.coin = coin;
        }
    }
}
