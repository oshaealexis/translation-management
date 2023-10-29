namespace TranslationManagement.Api.Models
{
  public class TranslatorModel
  {
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string HourlyRate { get; set; } = "";
    public string Status { get; set; } = TranslatorStatuses.Applicant.ToString();
    public string CreditCardNumber { get; set; } = "";
  }

  public enum TranslatorStatuses
  {
    Applicant,
    Certified,
    Deleted
  }
}
