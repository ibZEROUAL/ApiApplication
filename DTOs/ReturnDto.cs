namespace API.DTOs;

public class ReturnDto
{
    public string Username { get; set; }

    public string  Token { get; set; }
    
    public  IList<string> Role { get; set; }
    
}