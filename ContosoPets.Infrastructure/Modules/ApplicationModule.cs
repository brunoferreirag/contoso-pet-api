using Autofac;
using ContosoPets.Application;
using ContosoPets.Application.Querys;
using ContosoPets.Application.Repositories;
using ContosoPets.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContosoPets.Infrastructure.Modules
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(GetAllProductUseCase).Assembly)
             .AsImplementedInterfaces()
             .InstancePerLifetimeScope();

            builder.RegisterType<ProductRepository>().As<IProductReadOnlyRepository>().As<IProductWriteOnlyRepository>();
        }
    }
}
