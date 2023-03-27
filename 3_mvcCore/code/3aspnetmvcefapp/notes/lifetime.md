Service lifetimes
---

Choose an appropriate lifetime for each registered service. ASP.NET Core services can be configured with the following lifetimes:

Transient (PerCall)   
---
Transient lifetime services (AddTransient) are created each time they're requested from the service container. This lifetime works best for lightweight, stateless services.

In apps that process requests, transient services are disposed at the end of the request.

Scoped (PerRequest)  
---
Scoped lifetime services (AddScoped) are created once per client request (connection).

In apps that process requests, scoped services are disposed at the end of the request.

    Warning
    When using a scoped service in a middleware, inject the service into the Invoke or InvokeAsync method. Don't inject via constructor injection because it forces the service to behave like a singleton. 

Singleton   
---
Singleton lifetime services (AddSingleton) are created the first time they're requested (or when Startup.ConfigureServices is run and an instance is specified with the service registration). Every subsequent request uses the same instance. If the app requires singleton behavior, allowing the service container to manage the service's lifetime is recommended. Don't implement the singleton design pattern and provide user code to manage the object's lifetime in the class.

In apps that process requests, singleton services are disposed when the ServiceProvider is disposed at app shutdown.

    Warning   
    It's dangerous to resolve a scoped service from a singleton. It may cause the service to have incorrect state when processing subsequent requests.