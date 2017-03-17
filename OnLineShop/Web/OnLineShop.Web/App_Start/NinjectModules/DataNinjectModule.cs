using Ninject.Extensions.Conventions;
using Ninject.Extensions.Conventions.Syntax;
using Ninject.Modules;
using Ninject.Web.Common;

using OnLineShop.Data;

namespace OnLineShop.Web.App_Start.NinjectModules
{
    public class DataNinjectModule: NinjectModule
    {
        public override void Load()
        {
            this.Bind(this.BindAllClasses);
        }

        private void BindAllClasses(IFromSyntax binding)
        {
            binding
                .FromAssembliesMatching("OnLineShop.Data.dll")
                .SelectAllClasses()
                .BindDefaultInterface()
                .ConfigureFor<OnLineShopDbContext>(c => c.InRequestScope());
        }
    }
}