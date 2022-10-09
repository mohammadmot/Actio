namespace Actio.Common.Events
{
    public class CreateActivityRejected : IRejectedEvent
    {
        public Guid Id { get; }
        public string Reason { get; }
        public int Code { get; }

        protected CreateActivityRejected()
        {

        }

        public CreateActivityRejected(Guid id, string reason, int code)
        {
            Id = id;
            Reason = reason;
            Code = code;
        }

    }
}