using System.Threading.Tasks;

namespace Catalog.Api
{
    public interface ICatalogIntegrationEventService
    {
        Task SaveEventAndCatalogContextChangesAsync(IntegrationEvent evt);
        Task PublishThroughEventBusAsync(IntegrationEvent evt);
    }
}

//using Microsoft.eShopOnContainers.BuildingBlocks.EventBus.Events;
//using System.Threading.Tasks;
//
//namespace Catalog.API.IntegrationEvents
//{
//    public interface ICatalogIntegrationEventService
//    {
//        Task SaveEventAndCatalogContextChangesAsync(IntegrationEvent evt);
//        Task PublishThroughEventBusAsync(IntegrationEvent evt);
//    }
//}