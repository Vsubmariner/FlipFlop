namespace FlipFlop
{
    public abstract class State
    {
        protected Coin coin;

        public abstract void Flip(Coin coin);

        public abstract void DoMiracle(Coin coin);

        protected State(Coin coin)
        {
            this.coin = coin;
        }
    }
}
