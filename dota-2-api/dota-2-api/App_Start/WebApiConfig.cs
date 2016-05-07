using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using DryIoc;
using DryIoc.WebApi;
using dota_2_api.Repositories.Interfaces;
using dota_2_api.Repositories;
using AutoMapper;
using dota_2_api.Models.Dota2;
using dota_2_api.ViewModels.Dota2;

namespace dota_2_api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            //Setup automapper            
            var mappingConfig = new MapperConfiguration(cfg => cfg.CreateMap<Hero, HeroDto>());            

            //Add Dry IOC
            var container = new Container(rules => rules.With(FactoryMethod.ConstructorWithResolvableArguments));
            
            container.Register<IHeroRepository, HeroRepository>(reuse: Reuse.Singleton);            
            container.RegisterDelegate(r => mappingConfig.CreateMapper(), reuse: Reuse.Singleton);            

            container.WithWebApi(config);

                        

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/v1/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            config.Routes.MapHttpRoute(
              name: "DefaultNameApi",
              routeTemplate: "api/v1/{controller}/{name}",
              defaults: new { name = RouteParameter.Optional }
          );
        }
    }
}
