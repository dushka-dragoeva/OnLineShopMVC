using Ninject.Extensions.Conventions;
using Ninject.Extensions.Conventions.Syntax;
using Ninject.Modules;

namespace OnLineShop.Web.App_Start.NinjectModules
{
    public class ServiceNingectModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind(this.BindAllClasses);
        }

        private void BindAllClasses(IFromSyntax binding)
        {
            binding
                .FromAssembliesMatching("*.Services.*")
                .SelectAllClasses()
                .BindDefaultInterface();
        }
    }
}