# MSBuildSdkExtrasTest
Solution de test pour https://github.com/onovotny/MSBuildSdkExtras 

# Some docs
https://www.glennwatson.net/posts/first-post  
https://dansiegel.net/post/2018/08/21/demystifying-the-sdk-project  
https://oren.codes/2017/08/29/use-all-tfms-with-sdk-style-projects-in-visual-studio-for-mac/  
  
# Current state (as of 16/06/2019)
With Nuget update and VSfM update the sample works on:
Mac for iOS & MacOS **still not for Android**

```
Target _AddAndroidCustomMetaData:
/Library/Frameworks/Mono.framework/External/xbuild/Xamarin/Android/Xamarin.Android.Common.targets(519,3): error MSB4044: The "FilterAssemblies" task was not given a value for the required parameter "DesignTimeBuild".
Done building target "_AddAndroidCustomMetaData" in project "ZeNuget.csproj" -- FAILED.
```

Visual Studio Enterprise 2019 (Preview) for Mac Version 8.2 Preview (8.2 build 732)


# Current state (as of 31/05/2019)
The sample works on

**Microsoft Visual Studio Professional 2017 Version 15.9.12**  
OK - Nuget - Android, iOS, MacOS, UWP, WPF

it doesn't work on  
Microsoft Visual Studio Enterprise 2019 (Preview) for Mac Version 8.1 Preview (8.1 build 2460)   
Microsoft Visual Studio Professional 2019 Version 16.1.1   

https://github.com/onovotny/MSBuildSdkExtras/issues/168
https://developercommunity.visualstudio.com/content/problem/536913/vsfm-2019-doesnt-work-with-project-file-sdks-like.html
