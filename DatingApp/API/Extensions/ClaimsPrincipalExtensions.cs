using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            Console.WriteLine("Logging blablablalbalbalba o91203910293021");
            Console.WriteLine(ClaimTypes.Name);
            Console.WriteLine(user.Identity.Name);
            Console.WriteLine("claims: " + user.Claims.ToHashSet());
            Console.WriteLine(user.Identities.ToString());
            return user.FindFirst(ClaimTypes.Name).Value;
        }
        public static int GetUserId(this ClaimsPrincipal user)
        {
            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}
