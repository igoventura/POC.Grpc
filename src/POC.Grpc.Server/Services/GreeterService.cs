using Microsoft.AspNetCore.JsonPatch;
using POC.Grpc.Commons.Contracts;
using ProtoBuf.Grpc;

namespace POC.Grpc.Server.Services;

public class GreeterService : IGreeterService
{
    public Task<HelloResponse> JsonPatchHelloAsync(JsonPatchRequest request, CallContext context = default)
    {
        return Task.FromResult(new HelloResponse() { Message = $"Operations count: {request.Document.Operations.Count}" });
    }

    public Task<HelloResponse> SayHelloAsync(HelloRequest request, CallContext context = default)
    {
        return Task.FromResult(new HelloResponse() { Message = $"Hello {request.Name}!" });
    }
}