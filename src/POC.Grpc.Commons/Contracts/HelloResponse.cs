using System.Runtime.Serialization;

namespace POC.Grpc.Commons.Contracts;

[DataContract]
public class HelloResponse
{
    [DataMember(Order = 1)]
    public string Message { get; set; } = string.Empty;
}