using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World from .NET Web API running in Kubernetes! with ArgoCD -Deployments :) ");

app.Run();

