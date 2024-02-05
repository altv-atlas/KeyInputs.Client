using AltV.Atlas.KeyInputs.Client.Events;
using AltV.Net.Client.Elements.Data;
using Microsoft.Extensions.DependencyInjection;
namespace AltV.Atlas.KeyInputs.Client;

/// <summary>
/// Main entry point to client-side key input module
/// </summary>
public static class KeyInputModule
{
    /// <summary>
    /// The keys you want to listen for
    /// </summary>
    public static List<Key> Keys { get; private set; } = new( );

    /// <summary>
    /// Registers the key input module and it's classes/interfaces
    /// </summary>
    /// <param name="serviceCollection">A service collection</param>
    /// <returns>The service collection</returns>
    public static IServiceCollection RegisterKeyInputModule( this IServiceCollection serviceCollection )
    {
        Console.WriteLine( "[ATLAS] KeyInput Module Registered!" );
        serviceCollection.AddSingleton<AtlasKeyInputEvents>( );
        serviceCollection.AddSingleton<KeyDownEvent>( );
        serviceCollection.AddSingleton<KeyUpEvent>( );

        return serviceCollection;
    }

    /// <summary>
    /// Initializes the key input module
    /// </summary>
    /// <param name="serviceProvider">A service provider</param>
    /// <param name="keys">The keys the module should listen for</param>
    /// <returns></returns>
    public static IServiceProvider InitializeKeyInputModule( this IServiceProvider serviceProvider, List<Key> keys )
    {
        Console.WriteLine( "[ATLAS] KeyInput Module Initialized!" );
        _ = serviceProvider.GetService<KeyDownEvent>( );
        _ = serviceProvider.GetService<KeyUpEvent>( );

        Keys = keys;
        Console.WriteLine( $" [ATLAS] KeyInput Module is listening for {Keys.Count} keys!" );

        return serviceProvider;
    }
}