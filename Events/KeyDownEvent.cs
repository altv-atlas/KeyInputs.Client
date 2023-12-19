using AltV.Atlas.KeyInputs.Shared;
using AltV.Net.Client;
using AltV.Net.Client.Elements.Data;
using AltV.Net.Client.Elements.Interfaces;
namespace AltV.Atlas.KeyInputs.Client.Events;

public class KeyDownEvent
{
    private readonly AtlasKeyInputEvents _atlasKeyInputEvents;
    private readonly IPlayer _player = Alt.LocalPlayer;

    public KeyDownEvent( AtlasKeyInputEvents atlasKeyInputEvents )
    {
        _atlasKeyInputEvents = atlasKeyInputEvents;
        Alt.OnKeyDown += OnKeyDown;
    }

    private void OnKeyDown( Key key )
    {
        if( !KeyInputModule.Keys.Contains( key ) )
            return;

        Alt.EmitServer( KeyInputConstants.KeyDownEventName, ( int ) key );
        _atlasKeyInputEvents.PlayerKeyDownForwarded( _player, key );
    }
}