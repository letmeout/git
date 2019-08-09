using Microsoft.AspNetCore.Builder;

namespace aspnetcoreapp
{
    public static class RequestEncryptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestEncryption(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestEncryptionMiddleware>();
        }
    }
}