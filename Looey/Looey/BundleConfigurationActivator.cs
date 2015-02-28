using System.Web.Optimization;

[assembly: WebActivator.PostApplicationStartMethod(typeof(Looey.BundleConfigurationActivator), "Activate")]
namespace Looey
{
    public static class BundleConfigurationActivator
    {
        public static void Activate()
        {
            BundleTable.Bundles.RegisterConfigurationBundles();
        }
    }
}