using System;
using System.Text;

namespace FlipFlop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Coin coin = new Coin();
            coin.state.Flip(coin);
            coin.isMiracleEvent = true;
            coin.state.Flip(coin);
            coin.isMiracleEvent = false;
            coin.state.Flip(coin);
            coin.state.Flip(coin);
            coin.state.DoMiracle(coin);
            coin.state.Flip(coin);

            Console.ReadLine();
        }
    }
}
