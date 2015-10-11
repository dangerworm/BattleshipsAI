using BattleshipsAI.Enums;
using BattleshipsAI.Helpers;
using BattleshipsAI.Models;
using System.ServiceModel.Web;

namespace BattleshipsAI
{
    public class Service : IService
    {
        public string GetData(int value)
        {
            return $"You entered: {value}";
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "World";
        //    }
        //    return composite;
        //}

        public int Start(StartRequest start)
        {
            return 200;
        }

        public PlaceResponse Place()
        {
            return new PlaceResponse
            {
                GridReference = GridHelper.GetGridReferenceFromXAndY(0, 0),
                Orientation = Ship.Orientation.Horizontal.GetString()
            };
        }

        public MoveResponse Move()
        {
            return new MoveResponse
            {
                Type = MoveType.Attack.GetString(),
                GridReference = GridHelper.GetGridReferenceFromXAndY(0, 0)
            };
        }
    }
}
