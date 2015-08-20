namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class AncientBehemoth : Creature
    {
        private const int InitialAttack = 19;
        private const int InitialDefense = 19;
        private const int InitialHealthPoints = 300;
        private const decimal InitiaDamage = 40m;
        private const int DefenceReduction = 80;
        private const int DoubleDefenceRounds = 5;

        public AncientBehemoth()
            : base(AncientBehemoth.InitialAttack, AncientBehemoth.InitialDefense, AncientBehemoth.InitialHealthPoints, AncientBehemoth.InitiaDamage)
        {
            this.AddSpecialty(new ReduceEnemyDefenseByPercentage(AncientBehemoth.DefenceReduction));
            this.AddSpecialty(new DoubleDefenseWhenDefending(AncientBehemoth.DoubleDefenceRounds));
        }
    }
}
