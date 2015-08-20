namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;

    public class WolfRaider : Creature
    {
        private const int InitialAttack = 8;
        private const int InitialDefense = 5;
        private const int InitialHealthPoints = 10;
        private const decimal InitiaDamage = 3.5m;
        private const int DoubleDamageRounds = 7;

        public WolfRaider()
            : base(WolfRaider.InitialAttack, WolfRaider.InitialDefense, WolfRaider.InitialHealthPoints, WolfRaider.InitiaDamage)
        {
            this.AddSpecialty(new DoubleDamage(WolfRaider.DoubleDamageRounds));
        }
    }
}
