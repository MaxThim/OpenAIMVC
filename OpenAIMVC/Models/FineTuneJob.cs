namespace OpenAIMVC.Models
{
    public class FineTuneJob
    {
        public string Id { get; set; }
        public string Fine_tuned_model { get; set; }
        public int Created_at { get; set; }
        public List<HyperParams> HyperParams { get; set; }
        public string Status { get; set; }
        public int Updated_at { get; set; }
        public int NumberResultFiles { get; set; }
        public int NumberValidationFiles { get; set; }
        public int NumberTrainingFiles { get; set; }

    }
}
