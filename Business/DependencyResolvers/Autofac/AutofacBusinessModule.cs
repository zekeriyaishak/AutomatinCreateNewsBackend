using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.JWT.Abstract;
using Core.Utilities.Security.JWT.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<NewsManager>().As<INewsService>().SingleInstance();
            builder.RegisterType<EfNewsDal>().As<INewsDal>().SingleInstance();

            builder.RegisterType<CategoriesManager>().As<ICategoriesService>().SingleInstance();
            builder.RegisterType<EfCategoriesDal>().As<ICategoriesDal>().SingleInstance();


            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();






            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                    .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                    {
                        Selector = new AspectInterceptorSelector()
                    }).SingleInstance();
        }



    }
}
