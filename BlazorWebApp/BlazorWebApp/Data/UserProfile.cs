namespace BlazorWebApp.Data;

public class UserProfile
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Firstname { get; set; } = null!;
    public string Lastname { get; set; } = null!;
    public string? ProfileImage { get; set; }
    public string? Bio { get; set; }
}
