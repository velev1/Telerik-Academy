namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using Extended.Creatures;
    using Logic;
    using Logic.Battles;
    using Logic.Creatures;

    public class BattleManagerExtended : BattleManager
    {
        private readonly ICollection<ICreaturesInBattle> thitdArmyCreatures;

        public BattleManagerExtended(ICreaturesFactory creaturesFactory, ILogger logger)
            : base(creaturesFactory, logger)
        {
            this.thitdArmyCreatures = new List<ICreaturesInBattle>();
        }

        protected override void AddCreaturesByIdentifier(CreatureIdentifier creatureIdentifier, ICreaturesInBattle creaturesInBattle)
        {
            // TOCHECK: to make shure there is need to check null validatino here
            if (creatureIdentifier == null)
            {
                throw new ArgumentNullException("creatureIdentifier");
            }

            if (creaturesInBattle == null)
            {
                throw new ArgumentNullException("creaturesInBattle");
            }

            if (creatureIdentifier.ArmyNumber == 3)
            {
                this.thitdArmyCreatures.Add(creaturesInBattle);
            }
            else
            {
                base.AddCreaturesByIdentifier(creatureIdentifier, creaturesInBattle);
            }           
        }

        protected override ICreaturesInBattle GetByIdentifier(CreatureIdentifier identifier)
        {
            // TOCHECK: to make shure there is need to check null validatino here
            if (identifier == null)
            {
                throw new ArgumentNullException("identifier");
            }           

            if (identifier.ArmyNumber == 3)
            { 
                return this.thitdArmyCreatures.FirstOrDefault(x => x.Creature.GetType().Name == identifier.CreatureType);                
            }
            else
            {
                return base.GetByIdentifier(identifier);
            }            
        }
    }
}
