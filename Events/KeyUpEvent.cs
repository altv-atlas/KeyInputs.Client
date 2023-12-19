using AltV.Atlas.KeyInputs.Shared;
using AltV.Net.Client;
using AltV.Net.Client.Elements.Data;
using AltV.Net.Client.Elements.Interfaces;
namespace AltV.Atlas.KeyInputs.Client.Events;

public class KeyUpEvent
{
    private readonly AtlasKeyInputEvents _atlasKeyInputEvents;
    private readonly IPlayer _player = Alt.LocalPlayer;

    public KeyUpEvent( AtlasKeyInputEvents atlasKeyInputEvents )
    {
        _atlasKeyInputEvents = atlasKeyInputEvents;
        Alt.OnKeyUp += OnKeyUp;
    }

    private void OnKeyUp( Key key )
    {
        if( !KeyInputModule.Keys.Contains( key ) )
            return;

        Alt.EmitServer( KeyInputConstants.KeyUpEventName, ( int ) key );
        _atlasKeyInputEvents.PlayerKeyUpForwarded( _player, key );
    }
}