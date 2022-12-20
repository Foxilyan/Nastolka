namespace ConsoleVersion
{
    internal class Hero
    { 
        private List<Card> hand = new List<Card>();
        private int gold = 0;
        private int currentResouseValue;
        private int maxResourseValue;
        private int initiative;
        private int currentActionPointsValue = 5;
        private int maxActionPointsValue = 5;
        private string heroClass;
        private Dictionary<string, Item> equipment = new Dictionary<string, Item>;

        public Hero(string heroClass)
        {
            this.heroClass = heroClass;
            equipment.Add("helmet", null);
            equipment.Add("armor", null);
            equipment.Add("shoulderPads", null);
            equipment.Add("gloves", null);
            equipment.Add("greaves", null);
            equipment.Add("boots", null);
            equipment.Add("ring", null);
            equipment.Add("amulet", null);
        }

        //поставить ограничения на то, кто может менять статусы или сделать переменные паблик?...
        public int Gold { get { return gold; } set { gold = value; } }
        public int CurrentResouseValue { get { return currentResouseValue; } set { currentResouseValue = value; } }
        public int MaxResourseValue { get { return maxResourseValue; } set { maxResourseValue = value; } }
        public int Initiative { get { return initiative; } set { initiative = value; } }
        public int CurrentActionsPointValue { get { return currentActionPointsValue; } set { currentActionPointsValue = value; } }
        public int MaxActionPointsValue { get { return maxActionPointsValue; } set { maxActionPointsValue = value; } }
        
        //добавить исключения
        //карту нельзя продать потому что дорогая или потому что не в городе?
        public bool buyCard(Card card)
        {
            if (card.GoldCost > gold) return false;
            hand.Add(card);
            gold -= card.GoldCost;
            return true;
        }

        public Card sellCard(Card card)
        {
            hand.Remove(card);
            gold += card.GoldCost;
            return card;
        }
    }
}
