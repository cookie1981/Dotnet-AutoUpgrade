﻿namespace Automatize.Version
{
    public class Version2Point2Updater : IDotNetVersionUpdater
    {
        public int MajorVersion => 2;
        public int MinorVersion => 2;
        public string CurrentFramework => "netcoreapp2.1";
        public string MinimumCommonLibVersion => "1.0.345";
        public string LinuxSdkImageVersion => "dotnet:2.2.105-sdk";
        public string AlpineSdkImageVersion => "dotnet:2.2.105-sdk-alpine3.9";
        public string LinuxRuntimeImageVersion => "dotnet:2.2.3-aspnetcore-runtime";
        public string AlpineRuntimeImageVersion => "dotnet:2.2.3-aspnetcore-runtime-alpine3.9";
        public string MonoVersion => "5.16.0.179";

        public string TargetFramework => $"netcoreapp{MajorVersion}.{MinorVersion}";
    }
}