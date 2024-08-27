namespace Domain.Entities;

public class FormSubmission
{
    public Guid SubmissionId { get; set; }

    public Guid FormId { get; set; }
    public string Data { get; set; }
    public DateTime? submissionDate { get; set; }
}
