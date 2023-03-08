namespace DeginPaterrn.ChainResponsibility
{
    public struct RequestContextSanpp
    {
        public int UserId { get; set; }
        public PointSanpp Origin { get; set; }
        public PointSanpp Destination { get; set; }

    }

    public struct PointSanpp
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public struct ResponseContextSanpp
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }

    public interface IHandelRequestSnapp
    {
        IHandelRequestSnapp SetSuccessor(IHandelRequestSnapp successor);
        ResponseContextSanpp Execute(RequestContextSanpp requestContext);
    }

    public abstract class SanppSteps: IHandelRequestSnapp
    {
        public IHandelRequestSnapp _successor;

        protected SanppSteps()
        {
        }

        public abstract ResponseContextSanpp Execute(RequestContextSanpp requestContext);

        public IHandelRequestSnapp SetSuccessor(IHandelRequestSnapp successor)
        {
            _successor = successor;
            return successor;
        }
    }

    public class CreateOrder : SanppSteps
    {
        public override ResponseContextSanpp Execute(RequestContextSanpp requestContext)
        {
            bool orderCreated = true;
            if (orderCreated)
            {
                Console.WriteLine("Order Created.....");
                if (_successor != null)
                {
                    return _successor.Execute(requestContext);
                }
                else
                {
                    ///
                }
            }
            return new ResponseContextSanpp
            {
                IsSuccess = false,
                Message = "Error Order Created "
            };
        }
    }

    public class SendOrderToDriver : SanppSteps
    {
        public override ResponseContextSanpp Execute(RequestContextSanpp requestContext)
        {
            Console.WriteLine("Send tto Driver");
            if (_successor != null)
            {
                return _successor.Execute(requestContext);
            }

            return new ResponseContextSanpp
            {
                IsSuccess = true,
                Message = "Order Create and send to driver"
            };

        }
    }

    public class CheckUserActiveUser : SanppSteps
    {
        public override ResponseContextSanpp Execute(RequestContextSanpp requestContext)
        {
            if (requestContext.UserId != 1)
            {
                Console.WriteLine("User Not Active");
                return new ResponseContextSanpp
                {
                    IsSuccess = false,
                    Message = "User not Active"
                };
            }
            else if (_successor != null)
            {
                Console.WriteLine("User Is Active");
                return _successor.Execute(requestContext);
            }
            else
            {
                return new ResponseContextSanpp
                {
                    IsSuccess = false,
                    Message = "error"
                };
            }
        }
    }

    public class CheckTest : SanppSteps
    {
        public override ResponseContextSanpp Execute(RequestContextSanpp requestContext)
        {
            Console.WriteLine("Check Test is Done");

            if (_successor != null)
            {
                return _successor.Execute(requestContext);
            }

            return new ResponseContextSanpp
            {
                IsSuccess = false,
                Message = "error"
            };
        }
    }
}
