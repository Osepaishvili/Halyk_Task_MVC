using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HTO.Authorization;

namespace HTO
{
    [DependsOn(
        typeof(HTOCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HTOApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HTOAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HTOApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
