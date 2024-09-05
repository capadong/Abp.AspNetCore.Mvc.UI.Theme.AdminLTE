# Abp.AspNetCore.Mvc.UI.Theme.AdminLTE


An [ABP](http://abp.io) theme module based on [AdminLTE](https://adminlte.io/)

something changed:
- Upgrade ABP to 8.2.3
- Upgrade AdminLTE to 3.2
- Upgrade .NET to 8.0


![demo](doc/images/demo.png)

# How to use

1. Install nuget package
    
    * Web project:

        ~~`Install-Package Abp.AspNetCore.Mvc.UI.Theme.AdminLTE`~~
    * This package is currently available only on GitHub and has not yet been published to NuGet.

1. Replace theme module depend

    * Web project:

        ``` csharp
        ...
        [DependsOn(
            ...
            // typeof(AbpAspNetCoreMvcUiBasicThemeModule),
            typeof(AbpAspNetCoreMvcUiAdminLTEThemeModule),
            ...
        ]
        public class YourWebModule : AbpModule
        {
            ...
        }
        ```

1. Enjoy
