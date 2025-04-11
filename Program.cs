using ContentGraphClientNS;
using Microsoft.Extensions.DependencyInjection;

var services = new ServiceCollection();
services.AddHttpClient("ContentGraphClient",
    client =>
    {
        client.BaseAddress =
            new Uri("https://cg.optimizely.com/content/v2?auth=eBrGunULiC5TziTCtiOLEmov2LijBf30obh0KmhcBlyTktGZ");
    });
services.AddContentGraphClient();
var serviceProvider = services.BuildServiceProvider();

var contentGraphClient = serviceProvider.GetRequiredService<IContentGraphClient>();
var data = contentGraphClient.GetProductPages.ExecuteAsync().Result;