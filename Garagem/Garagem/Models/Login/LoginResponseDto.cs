namespace  Garagem.Models;
public class LoginResponseDto{
    public bool Error { get; set; }
    public User User { get; set; } = default!;
}
