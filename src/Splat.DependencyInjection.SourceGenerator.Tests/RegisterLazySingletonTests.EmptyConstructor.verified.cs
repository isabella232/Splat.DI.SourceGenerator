﻿//HintName: Splat.DI.Extensions.SourceGenerated.cs

// <auto-generated />
namespace Splat
{
    /// <summary>
    /// Extension methods for the Splat DI source generator.
    /// </summary>
    internal static partial class SplatRegistrations
    {
        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        public static void Register<TInterface, TConcrete>()
        {
        }

        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        /// <param name="contract">Optional contract.</param>
        public static void Register<TInterface, TConcrete>(string contract)
        {
        }

        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        public static void RegisterLazySingleton<TInterface, TConcrete>()
        {
        }

        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        /// <param name="mode">The threading mode.</param>
        public static void RegisterLazySingleton<TInterface, TConcrete>(System.Threading.LazyThreadSafetyMode mode)
        {
        }

        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        /// <param name="contract">Optional contract.</param>
        public static void RegisterLazySingleton<TInterface, TConcrete>(string contract)
        {
        }

        /// <summary>
        /// Registers a class with its concrete class.
        /// </summary>
        /// <param name="contract">Optional contract.</param>
        /// <param name="mode">The threading mode.</param>
        public static void RegisterLazySingleton<TInterface, TConcrete>(string contract, System.Threading.LazyThreadSafetyMode mode)
        {
        }
    }

    /// <summary>
    /// Makes the property get added by the DI engine.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Property)]
    internal class DependencyInjectionPropertyAttribute : System.Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyInjectionPropertyAttribute"/> class.
        /// </summary>
        public DependencyInjectionPropertyAttribute()
        {
        }
    }

    /// <summary>
    /// Makes this the constructor used by the DI engine.
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Constructor)]
    internal class DependencyInjectionConstructorAttribute : System.Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DependencyInjectionConstructorAttribute"/> class.
        /// </summary>
        public DependencyInjectionConstructorAttribute()
        {
        }
    }
}