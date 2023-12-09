namespace  Garagem.Models;
public class LoginResponseDto{
    public bool Error { get; set; }
    public User user { get; set; } = default!;
}
