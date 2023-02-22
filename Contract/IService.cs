using API.Model;
using System.ServiceModel;

namespace API.Contract
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        string Ping(string s);

        [OperationContract]
        ComplexModelResponse PingComplexModel(ComplexModelInput inputModel);

        [OperationContract]
        int[] IntArray();

        [OperationContract]
        ComplexReturnModel[] ComplexReturnModel();

        [OperationContract]
        void VoidMethod(out string s);

        [OperationContract]
        Task<int> AsyncMethod();

        [OperationContract]
        int? NullableMethod(bool? arg);

        [OperationContract]
        void XmlMethod(System.Xml.Linq.XElement xml);
    }
}
