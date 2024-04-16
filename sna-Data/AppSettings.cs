
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using sna_Data.Context.MSSQLContext;

namespace sna_Data
{
    public static class AppSettings
    {
        public static MSSQLSettings MSSQLSettings { get; set; }
        public static IConfiguration Keys { get; set; }
        public static void Init(IServiceCollection services, IConfiguration configuration)
        {
            MSSQLSettings = configuration.GetSection("ConnectionStrings").Get<MSSQLSettings>();
            Keys = configuration.GetSection("AppSettings");
        }
    }
}
