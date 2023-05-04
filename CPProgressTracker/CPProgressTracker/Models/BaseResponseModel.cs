namespace CPProgressTracker.Models
{
    public class BaseResponseModel
    {
        public BaseResponseModel()
        {
            ErrorList = new();
            Message = string.Empty;
        }

        public string Message { get; set; }
        public List<string> ErrorList { get; set; }
    }
}
