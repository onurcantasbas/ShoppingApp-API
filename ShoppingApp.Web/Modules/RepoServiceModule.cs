using Autofac;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
using ShoppingApp.Core.Repositories;
using ShoppingApp.Core.Services;
using ShoppingApp.Core.UnitOfWorks;
using ShoppingApp.Repository;
using ShoppingApp.Repository.Repositories;
using ShoppingApp.Repository.UnitOfWorks;
using ShoppingApp.Service.Mapping;
using ShoppingApp.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace ShoppingApp.Web.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(UnitOfWork)).As<IUnitOfWork>();
            var webAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(webAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().
                InstancePerLifetimeScope();
            builder.RegisterAssemblyTypes(webAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().
                InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
