﻿using System;
using System.Reflection;
using Abp.Dependency;
using Abp.Modules;
using Abp.Startup;
using Abp.Startup.Application;
using Abp.WebApi.Startup;

namespace SimpleTaskSystem
{
    public class SimpleTaskSystemWebApiModule : AbpModule
    {
        public override Type[] GetDependedModules()
        {
            return new[]
                   {
                       typeof(AbpApplicationModule),
                       typeof(AbpWebApiModule),
                       typeof(SimpleTaskSystemApplicationModule)
                   };
        }

        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            IocManager.Instance.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
