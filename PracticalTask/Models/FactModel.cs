namespace PracticalTask.Models
{
    public class FactModel
    {
        public string Fact { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return $"{Fact}\t{Length}";
        }
    }
}
