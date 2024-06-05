var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.cafesys_ApiService>("apiservice");

builder.AddProject<Projects.cafesys_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
