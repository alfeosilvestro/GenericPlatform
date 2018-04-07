using System.Threading.Tasks;

namespace Com.PlatformServices.Communication.Events.Declaration
{
    public interface IDynamicIntegrationEventHandler
    {
        Task Handle(dynamic eventData);
    }
}
