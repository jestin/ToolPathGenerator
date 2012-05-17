using System;

namespace WebGenerator
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            StructureMap.ObjectFactory.Initialize(x =>
                                                      {
                                                          x.AddRegistry(new DependencyRegistry());
                                                          x.AddRegistry(new UI.DependencyRegistry());
                                                          x.AddRegistry(new Service.DependencyRegistry());
                                                      });
        }
    }
}
