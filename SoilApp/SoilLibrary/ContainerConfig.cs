using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SoilLibrary.Models;
using SoilLibrary.Utilities;
using SoilLibrary.DataAccess;

namespace SoilLibrary
{
    public class ContainerConfig
    {
        // TODO - Come back to setting this up

        /// <summary>
        /// Sets up AutoFac
        /// </summary>
        /// <returns></returns>
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GoogleSheetConnector>().As<IGoogleSheetConnector>();
            builder.RegisterType<MasterSheet>().As<IMasterSheet>();
            builder.RegisterType<MasterSheetProcessor>().As<IMasterSheetProcessor>();
            builder.RegisterType<MasterSheetProcessor>().SingleInstance();
            

            return builder.Build();
        }

    }
}
