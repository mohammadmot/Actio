namespace Actio.Common.Events
{
    public interface IRejectedEvent : IEvents
    {
        public string Reason { get; }
        public int Code { get; } // code for multi language
    }
}