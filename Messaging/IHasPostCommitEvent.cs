using MediatR;

namespace Application.Messaging
{
    public interface IHasPostCommitEvent
    {
        List<INotification> PostCommitEvents { get; }
    }
}
