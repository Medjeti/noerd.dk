using noerd.dk.Application.Web.ApiControllers;
using noerd.Web.Application;
using noerd.Web.Plugins.Autofac;
using noerd.Web.Plugins.WebApi;
using noerd.Web.Plugins.WebApi.Autofac;
using noerd.Web.Umbraco.Plugins;

namespace noerd.dk.Web.Umbraco
{
    public class Startup : IStartup
    {
        public void Configure(IConfig cfg)
        {
            //cfg.AppSettings.AsMappedPath("APP_SET_KEY");
            //cfg.AppSettings.AsBool("APP_SET_KEY");
            //cfg.AppSettings.AsInt("APP_SET_KEY");

            cfg.UseWebApi(webapi => { });

            cfg.UseAutofac(autofac =>
            {
                autofac.UseMvc(typeof(TestController).Assembly);
                autofac.UseWebApi(typeof(TestController).Assembly);

                autofac.Services(builder =>
                {
                    // Container registrations
                });
            });

            cfg.UseUmbraco(umbraco =>
            {
                umbraco.OnApplicationInitialized((umbracoApplication, applicationContext) =>
                {
                    // Umbraco Initialized
                });

                umbraco.OnApplicationStarting((umbracoApplication, applicationContext) =>
                {
                    // Umbraco Starting
                });

                umbraco.OnApplicationStarted((umbracoApplication, applicationContext) =>
                {
                    // Umbraco Started
                });
            });
        }
    }
}
