using Grpc.Net.Client;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using POC.Grpc.Commons.Contracts;
using ProtoBuf.Grpc.Client;

using var channel = GrpcChannel.ForAddress("https://localhost:7001");
var client = channel.CreateGrpcService<IGreeterService>();

var helloReply = await client.SayHelloAsync(
    new HelloRequest { Name = "GreeterClient" });

Console.WriteLine($"Greeting: {helloReply.Message}");

var request = new JsonPatchRequest() {
    Document = new JsonPatchDocument<HelloRequest>()
};
// request.Operations.Add(new Operation<HelloRequest>("replace", "/Name", null, "Igo"));
var jsonPatchReply = await client.JsonPatchHelloAsync(request);

Console.WriteLine($"Greeting: {jsonPatchReply.Message}");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();