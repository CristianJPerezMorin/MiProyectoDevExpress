using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MiProyecto.Localization
{
    public static class MiProyectoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MiProyectoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MiProyectoLocalizationConfigurer).GetAssembly(),
                        "MiProyecto.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
