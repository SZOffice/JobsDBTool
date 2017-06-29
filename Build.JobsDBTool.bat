SET BuildConfig=%v8BuildConfig%
IF [%BuildConfig%]==[] SET BuildConfig=Debug

::"C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE\devenv.exe" /build %BuildConfig% "Work2013.sln" /Out "Work2013.%BuildConfig%.log"
C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild.exe JobsDBTool.sln /t:rebuild > "JobsDBTool.%BuildConfig%.log"

::pause & exit