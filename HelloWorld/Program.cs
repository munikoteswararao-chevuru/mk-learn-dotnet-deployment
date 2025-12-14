using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Prometheus;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

/* Collect HTTP metrics automatically */
app.UseHttpMetrics();

/* Expose Prometheus metrics */
app.MapMetrics();

app.MapGet("/", () => "Hello World from .NET Web API running in Kubernetes! with ArgoCD -Deployments :( ");

app.Run();
