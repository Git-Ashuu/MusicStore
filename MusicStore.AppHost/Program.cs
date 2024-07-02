var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MusicStoreApi>("musicstoreapi");

builder.Build().Run();
