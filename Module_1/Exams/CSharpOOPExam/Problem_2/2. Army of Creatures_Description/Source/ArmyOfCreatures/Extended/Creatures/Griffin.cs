namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Griffin : Creature
    {
        private const int InitialAttack = 8;
        private const int InitialDefense = 8;
        private const int InitialHealthPoints = 25;
        private const decimal InitiaDamage = 4.5m;
        private const int DoubleDefenceRounds = 5;
        private const int DefenceWhenSkippingPoints = 3;        

        public Griffin()
            : base(Griffin.InitialAttack, Griffin.InitialDefense, Griffin.InitialHealthPoints, Griffin.InitiaDamage)
        {
            this.AddSpecialty(new DoubleDefenseWhenDefending(Griffin.DoubleDefenceRounds));
            this.AddSpecialty(new AddDefenseWhenSkip(Griffin.DefenceWhenSkippingPoints));
            this.AddSpecialty(new Hate(typeof(WolfRaider)));
        }
    }
}
