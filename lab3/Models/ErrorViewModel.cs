namespace lab3.Models;

public record ErrorViewModel
{
    public string RequestId { get; set; } = null!;

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}