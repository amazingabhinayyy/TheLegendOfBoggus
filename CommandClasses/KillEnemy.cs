namespace Sprint2_Attempt3.CommandClasses
{
    internal class KillEnemy : ICommand
    {
        private Game1 game1;

        public KillEnemy(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            game1.enemy.Kill();
        }
    }
}
