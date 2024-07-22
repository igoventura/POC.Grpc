using System.Runtime.Serialization;

namespace POC.Grpc.Commons.Contracts;

[DataContract]
public class HelloRequest
{
    [DataMember(Order = 1)]
    public string Name { get; set; } = string.Empty;
}
