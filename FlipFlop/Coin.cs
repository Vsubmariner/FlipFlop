namespace FlipFlop
{
    public class Coin
    {
        public State state { get; set; }
        public bool isMiracleEvent;

        public void ChangeState(State state)
        {
            this.state = state;
        }

        public Coin()
        {
            this.state = new Orel(this);
        }
    }
}
