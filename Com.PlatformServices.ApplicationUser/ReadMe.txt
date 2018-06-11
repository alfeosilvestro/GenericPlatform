# Scope # 

- Application User Create / Update / Delete / List / Search


# Stardardisation #

- reference "Com.PlatformServices.Common" project
- Create "Configurations" folder on the project
- Create "AppSettings.cs" under "Configurations" folder
- Inherits "BaseSettings" in AppSettings.cs


dotnet publish -o obj/Docker/publish -c Release -r linux-x64