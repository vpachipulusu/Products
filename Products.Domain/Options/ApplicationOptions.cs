namespace Products.Domain.Options
{
    public class ApplicationOptions
    {
        public ConnectionStringsOptions ConnectionStrings { get; set; }

        public JwtOptions Jwt { get; set; }
    }
}
