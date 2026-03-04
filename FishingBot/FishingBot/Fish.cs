namespace FishingBot
{
    public class Fish
    {
        public string fishName = "";
        public string fishDescription = "";

        public string fishImage = "";

        public uint fishId = 0;

        public float fishWeight = 0;
        public RarityType fishRarity;

        public Fish(string name, string description, string image, float weight, RarityType rarity, uint id)
        {
            this.fishName = name;
            this.fishDescription = description;
            this.fishImage = image;

            this.fishWeight = weight;
            this.fishRarity = rarity;

            this.fishId = id;
        }
    }
}