namespace FishingBot.Data
{
    public class Inventory
    {
        public List<Fish> fishList = new List<Fish>();

        public Fish AddFish()
        {
            var fish = FishStorage.Fishing();
            fishList.Add(fish);

            return fish;
        }
    }
}