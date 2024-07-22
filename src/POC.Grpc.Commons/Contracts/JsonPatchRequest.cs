using System.Runtime.Serialization;
using Microsoft.AspNetCore.JsonPatch;
using ProtoBuf;

namespace POC.Grpc.Commons.Contracts;

[DataContract]
[ProtoInclude(300, typeof(HelloRequest))]
[ProtoInclude(400, typeof(JsonPatchDocument<HelloRequest>))]
public class JsonPatchRequest
{
    [DataMember(Order = 1)]
    public JsonPatchDocument<HelloRequest> Document { get; set; } = new();
}
