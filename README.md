# MSBuildSdkExtrasTest
Test and sample solution for https://github.com/onovotny/MSBuildSdkExtras 

# Some docs
https://www.glennwatson.net/posts/first-post  
https://dansiegel.net/post/2018/08/21/demystifying-the-sdk-project  
https://oren.codes/2017/08/29/use-all-tfms-with-sdk-style-projects-in-visual-studio-for-mac/  
  
# Current state (as of 16/06/2019)
| Version | State | ... |
| ------- |:-----:| --- |
| Visual Studio Professional 2017 Version 15.9.13 | OK | Android, iOS, MacOS, UWP & WPF |
| Visual Studio Professional 2019 Version 16.1.3 | OK* | Mac for iOS, MacOS, UWP & WPF **still not for Android** |
| Visual Studio Enterprise 2019 (Preview) for Mac Version 8.2 Preview (8.2 build 732) | OK* | Mac for iOS & MacOS **still not for Android** |

##Error on VSfM for Android##
```
Target _AddAndroidCustomMetaData:
/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets(519,3): error MSB4044: The "FilterAssemblies" task was not given a value for the required parameter "DesignTimeBuild".
Done building target "_AddAndroidCustomMetaData" in project "ZeNuget.csproj" -- FAILED.
```

##Error on VS2019 for Android##
```
Severity	Code	Description	Project	File	Line	Suppression State
Error	MSB4044	The "GetAdditionalResourcesFromAssemblies" task was not given a value for the required parameter "AndroidNdkDirectory".	ZeNuget	C:\Program Files (x86)\Microsoft Visual Studio\2019\Professional\MSBuild\Xamarin\Android\Xamarin.Android.Common.targets	482	
```    
   

# Current state (as of 31/05/2019)
| Version | State | ... |
| ------- |:-----:| --- |
| Visual Studio Professional 2017 Version 15.9.12 | OK | Android, iOS, MacOS, UWP & WPF |
| Visual Studio Professional 2019 Version 16.1.1 | KO |  |
| Visual Studio Enterprise 2019 (Preview) for Mac Version 8.1 Preview (8.1 build 2460) | KO |   |   

https://github.com/onovotny/MSBuildSdkExtras/issues/168
https://developercommunity.visualstudio.com/content/problem/536913/vsfm-2019-doesnt-work-with-project-file-sdks-like.html
