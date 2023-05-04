namespace CPProgressTracker.Models
{
    public class BaseRequestModel<TModel>
    {
        public BaseRequestModel()
        {

        }
        public TModel Data { get; set; }
    }
}
