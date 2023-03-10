using System.Runtime.Serialization;

namespace API.Model
{
    [DataContract]
    public class ComplexModelResponse
    {
        [DataMember]
        public float FloatProperty { get; set; }

        [DataMember]
        public string StringProperty { get; set; }

        [DataMember]
        public List<string> ListProperty { get; set; }

        [DataMember]
        public DateTimeOffset DateTimeOffsetProperty { get; set; }

        [DataMember]
        public TestEnum TestEnum { get; set; }
    }
}
