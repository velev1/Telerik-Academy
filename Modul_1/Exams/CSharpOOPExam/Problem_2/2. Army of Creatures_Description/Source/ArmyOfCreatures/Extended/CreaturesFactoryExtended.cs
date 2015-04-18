namespace ArmyOfCreatures.Extended
{
    using System;
    using System.Globalization;

    using Extended.Creatures;
    using Logic;
    using Logic.Creatures;    

    public class CreaturesFactoryExtended : CreaturesFactory
    {
        public override Creature CreateCreature(string name)
        {
            switch (name)
            {
                case "Goblin":
                    return new Goblin();
                case "AncientBehemoth":
                    return new AncientBehemoth();
                case "CyclopsKing":
                    return new CyclopsKing();
                case "Griffin":
                    return new Griffin();
                case "WolfRaider":
                    return new WolfRaider();
                default:
                   return base.CreateCreature(name);
            }
        }
    }
}
