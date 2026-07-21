using MediatR;

namespace Application.Messaging
{
    public interface IHasPreCommitEvent
    {
        List<INotification> PreCommitEvents { get; }
    }
}
