using System;

namespace FlipFlop
{
    class Orel : State
    {
        public override void DoMiracle(Coin coin)
        {
            coin.ChangeState(new Miracle(coin));
            Console.WriteLine("\nИсходное состояние: Орёл");
            Console.WriteLine("Произошло чудо! Зависла в воздухе");
        }

        public override void Flip(Coin coin)
        {
            if (coin.isMiracleEvent)
            {
                DoMiracle(coin);
            }
            else
            {
                Console.WriteLine("\nИсходное состояние: Орёл");
                coin.ChangeState(new Reshka(coin));
                Console.WriteLine("А теперь Решка!");
            }
        }

        public Orel(Coin coin) : base(coin)
        {
            this.coin = coin;
        }
    }
}
