using System;
using System.Web;
using System.Web.Http;

namespace SampleApplicationService_4_5
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (Object obj, ResolveEventArgs args) =>
            {
                String thisExe = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                System.Reflection.AssemblyName embeddedAssembly = new System.Reflection.AssemblyName(args.Name);
                String resourceName = thisExe + "." + embeddedAssembly.Name + ".dll";

                using (var stream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return System.Reflection.Assembly.Load(assemblyData);
                }
            };

            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}