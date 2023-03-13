namespace OpenAIMVC.Models
{
    public class HyperParams
    {
        public int Epochs { get; set; }
        public double Learning_rate_multiplier { get; set; }
        public double Batch_size { get; set; }
        public double PromptLossWeight { get; set; }

    }
}
