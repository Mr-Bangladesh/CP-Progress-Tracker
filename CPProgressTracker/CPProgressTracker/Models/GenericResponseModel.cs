namespace CPProgressTracker.Models
{
    public class GenericResponseModel<TResult> : BaseResponseModel
    {
        public GenericResponseModel() { }

        public TResult Data { get; set; }
    }
}
