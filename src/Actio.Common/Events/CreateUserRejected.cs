namespace Actio.Common.Events
{
    public class CreateUserRejected : IRejectedEvent
    {
        public string Email { get; }
        public string Reason { get; }
        public int Code { get; }

        protected CreateUserRejected()
        {

        }

        public CreateUserRejected(string email, string reason, int code)
        {
            Email = email;
            Reason = reason;
            Code = code;
        }
    }
}