namespace TeamTaskList.Api.Requests
{
    public class CreateProjectRequest
    {
        public string Nome { get; set; }
        public Guid UserId { get; set; }
    }
}
