namespace Auth.Model
{
    public class LoginResponse
    {
        public string? Token { get; set; }
        public int ExpirationTime { get; set; }

        public LoginResponse()
        {
            
        }
        public LoginResponse(string token, int expirationTime)
        {
            this.Token = token;
            this.ExpirationTime = expirationTime;
        }
    }
}
