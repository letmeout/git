# ASP.NET Core 2.2 Learning Note

---

## Fundamentals

- How to retrieve IServiceCollection in app and context.
    + In Application, use IApplicationBuilder app to get IServiceProvider
    ```csharp
    app.ApplicationServices.GetRequiredService<Interface>();
    ```
    + In Pipeline, use HttpContext httpContext to get IServiceProvider
    ```csharp
    httpContext.RequestServices.GetService(typeof(Interface));
    ```
- Built-in Middleware
    +  | Middleware | Description | Order |
        |:---|:---|:---|
        | Authentication | Provides authentication support. | Before HttpContext.User is needed. Terminal for OAuth callbacks. |
        | Cookie Policy | Tracks consent from users for storing personal information and enforces minimum standards for cookie fields, such as secure and SameSite. | Before middleware that issues cookies. Examples: Authentication, Session, MVC (TempData). |
        | CORS | Configures Cross-Origin Resource Sharing. | Before components that use CORS. |
        | Exception Handling | Handles exceptions. | Before components that generate errors. |
        | Forwarded Headers | Forwards proxied headers onto the current request | Before components that consume the updated fields. Examples: scheme, host, client IP, method |
        | Health Check | Checks the health of an ASP.NET Core app and its dependencies, such as checking database availability. | Terminal if a request matches a health check endpoint. |
        |  |  |  |
        |  |  |  |
        |  |  |  |
        |  |  |  |




