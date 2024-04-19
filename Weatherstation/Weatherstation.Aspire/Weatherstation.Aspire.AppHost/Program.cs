var builder = DistributedApplication.CreateBuilder(args);

var coreserver = builder.AddProject<Projects.Weatherstation_CoreServer>("CoreServer");

builder.AddProject<Projects.Weatherstation_UI_Webserver>("UI_Webserver")
    .WithReference(coreserver);

builder.Build().Run();