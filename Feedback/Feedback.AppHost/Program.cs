var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Feedback>("feedback");

builder.Build().Run();
