using System.ServiceModel;
using Microsoft.AspNetCore.JsonPatch;
using ProtoBuf.Grpc;

namespace POC.Grpc.Commons.Contracts;

[ServiceContract]
public interface IGreeterService
{
    [OperationContract]
    Task<HelloResponse> SayHelloAsync(HelloRequest request, CallContext context = default);

    [OperationContract]
    Task<HelloResponse> JsonPatchHelloAsync(JsonPatchRequest request, CallContext context = default);
}