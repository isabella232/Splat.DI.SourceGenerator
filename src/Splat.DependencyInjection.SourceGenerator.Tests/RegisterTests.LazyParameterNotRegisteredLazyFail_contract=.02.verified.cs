﻿//HintName: Splat.DI.Extensions.Registrations.SourceGenerated.cs

// <auto-generated />
namespace Splat
{
    internal static partial class SplatRegistrations
    {
        static partial void SetupIOCInternal( Splat.IDependencyResolver resolver) 
        {
            Splat.Locator.CurrentMutable.Register(() => new global::Test.Service1(), typeof(global::Test.IService1));
            Splat.Locator.CurrentMutable.Register(() => new global::Test.Service2(), typeof(global::Test.IService2));
        }
    }
}