using AltV.Net.Client.Elements.Data;
using AltV.Net.Client.Elements.Interfaces;
namespace AltV.Atlas.KeyInputs.Client.Events;

/// <summary>
/// Class that receives and emits events that occur within the key input module
/// </summary>
public class AtlasKeyInputEvents
{
    #region PlayerKeyDownForwarded

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerKeyDownForwardedDelegate( IPlayer player, Key key );

    /// <summary>
    /// Triggers when a player triggers a key down event was forwarded to server-side
    /// </summary>
    public event PlayerKeyDownForwardedDelegate? OnPlayerKeyDownForwarded;

    /// <summary>
    /// Event that triggers when a player triggers a key down was forwarded to server-side
    /// </summary>
    /// <param name="player">The player who triggered the key down</param>
    /// <param name="key">The key which was pressed</param>
    public void PlayerKeyDownForwarded( IPlayer player, Key key )
    {
        OnPlayerKeyDownForwarded?.Invoke( player, key );
    }

    #endregion

    #region PlayerKeyUpForwarded

    /// <summary>
    /// Delegate
    /// </summary>
    public delegate void PlayerKeyUpForwardedDelegate( IPlayer player, Key key );

    /// <summary>
    /// Triggers when a player triggers a key up event was forwarded to server-side
    /// </summary>
    public event PlayerKeyUpForwardedDelegate? OnPlayerKeyUpForwarded;

    /// <summary>
    /// Event that triggers when a player triggers a key up was forwarded to server-side
    /// </summary>
    /// <param name="player">The player who triggered the key up</param>
    /// <param name="key">The key which was pressed</param>
    public void PlayerKeyUpForwarded( IPlayer player, Key key )
    {
        OnPlayerKeyUpForwarded?.Invoke( player, key );
    }

    #endregion
}