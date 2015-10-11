using BattleshipsAI.Models;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace BattleshipsAI
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebGet]
        string GetData(int value);

        //[OperationContract]
        //[WebGet]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        [WebInvoke]
        int Start(StartRequest start);

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json)]
        PlaceResponse Place();

        [OperationContract]
        [WebInvoke(Method = "GET",
                   ResponseFormat = WebMessageFormat.Json)]
        MoveResponse Move();
    }
}