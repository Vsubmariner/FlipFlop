using System;

namespace FlipFlop
{
    class Reshka : State
    {
        public override void DoMiracle(Coin coin)
        {
            coin.ChangeState(new Miracle(coin));
            Console.WriteLine("\nИсходное состояние: Решка");
            Console.WriteLine("Произошло чудо! Зависла в воздухе!");
        }

        public override void Flip(Coin coin)
        {
            if (coin.isMiracleEvent)
            {
                DoMiracle(coin);
            }
            else
            {
                Console.WriteLine("\nИсходное состояние: Решка");
                coin.ChangeState(new Orel(coin));
                Console.WriteLine("А теперь Орёл!");
            }
        }

        public Reshka(Coin coin) : base(coin)
        {
            this.coin = coin;
        }
    }
}
