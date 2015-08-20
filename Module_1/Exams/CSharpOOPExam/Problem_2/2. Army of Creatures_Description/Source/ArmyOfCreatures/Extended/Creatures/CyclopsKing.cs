namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Extended.Specialties;
    using ArmyOfCreatures.Logic.Creatures;    
    using ArmyOfCreatures.Logic.Specialties;

    public class CyclopsKing : Creature
    {
        private const int InitialAttack = 17;
        private const int InitialDefense = 13;
        private const int InitialHealthPoints = 70;
        private const decimal InitiaDamage = 18m;
        private const int AddAttackWhenSkipPoints  = 3;
        private const int DoubleAttackWhenAttackingPoints  = 4;
        private const int DoubleDamageRounds = 1;

        public CyclopsKing()
            : base(CyclopsKing.InitialAttack, CyclopsKing.InitialDefense, CyclopsKing.InitialHealthPoints, CyclopsKing.InitiaDamage)
        {
            this.AddSpecialty(new AddAttackWhenSkip(CyclopsKing.AddAttackWhenSkipPoints));
            this.AddSpecialty(new DoubleAttackWhenAttacking(CyclopsKing.DoubleAttackWhenAttackingPoints));
            this.AddSpecialty(new DoubleDamage(CyclopsKing.DoubleDamageRounds));
        }
    }
}
