namespace Sprint2_Attempt3.CommandClasses
{
    internal class ChangeEnemyAttackedStatus : ICommand
    {
        private Game1 game1;

        public ChangeEnemyAttackedStatus(Game1 game)
        {
            this.game1 = game;
        }

        public void Execute()
        {
            game1.enemy.ChangeAttackedStatus();
        }
    }
}
