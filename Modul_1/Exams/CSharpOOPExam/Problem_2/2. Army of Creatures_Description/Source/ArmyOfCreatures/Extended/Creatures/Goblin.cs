namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using ArmyOfCreatures.Logic.Specialties;

    public class Goblin : Creature
    {
        private const int InitialAttack = 4;
        private const int InitialDefense = 2;
        private const int InitialHealthPoints = 5;
        private const decimal InitiaDamage = 1.5m;

        public Goblin()
            : base(Goblin.InitialAttack, Goblin.InitialDefense, Goblin.InitialHealthPoints, Goblin.InitiaDamage)
        { 
        }
    }
}
