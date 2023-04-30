namespace dotnetapp.Models
{
    public class ResponseModel
    {
        public dynamic Message { get; set; }
        public bool Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}
