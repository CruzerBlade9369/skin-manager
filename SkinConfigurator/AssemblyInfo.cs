using SMShared;
using System.Reflection;
using System.Runtime.Versioning;
using System.Windows;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]

[assembly: AssemblyTitle("SkinConfigurator")]
[assembly: AssemblyProduct("SkinConfigurator")]
[assembly: AssemblyCompany("Derail Valley Modding")]

[assembly: AssemblyVersion(Constants.MOD_VERSION)]
[assembly: AssemblyFileVersion(Constants.MOD_VERSION)]

[assembly: SupportedOSPlatform("windows")]