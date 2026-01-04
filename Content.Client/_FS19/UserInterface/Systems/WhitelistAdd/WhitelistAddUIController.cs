using Content.Client._FS19.UserInterface.Systems.WhitelistAdd.UI;
using Content.Shared._FS19.WhitelistAdd;
using Content.Client.UserInterface.Screens;
using Content.Client.UserInterface.Systems.Gameplay;
using JetBrains.Annotations;
using Robust.Client.UserInterface.Controllers;
using Robust.Client.UserInterface.Controls;
using Robust.Client.Console;
using Robust.Client.UserInterface;
using Content.Client.Lobby.UI;
using Content.Client.Gameplay;
using Content.Client._FS19.WhitelistAdd;
using Robust.Shared.Player;

namespace Content.Client._FS19.UserInterface.Systems.WhitelistAdd;

[UsedImplicitly]

public sealed class WhitelistAddUIController : UIController
{
    [Dependency] private readonly IClientConsoleHost _console = default!;
    [Dependency] private readonly IUriOpener _uri = default!;

    private readonly WhitelistAddManager _manager = default!;

    private WhitelistAddMenu? _whitelistAddWindow;

    public override void Initialize()
    {
    }

    private void CloseWhitelistAddWindow()
    {
        _whitelistAddWindow?.Close();
    }

    public void ToggleWindow()
    {
        if (_whitelistAddWindow == null)
        {
            _whitelistAddWindow ??= UIManager.CreateWindow<WhitelistAddMenu>();
        }

        if (_whitelistAddWindow.IsOpen)
        {
            CloseWhitelistAddWindow();
            //EscapeButton!.Pressed = false;
        }
        else
        {
            _whitelistAddWindow.OpenCentered();
            //EscapeButton!.Pressed = true;
        }
    }

    public void OnWhitelistAddSent(string invitee)
    {
        Log.Debug(invitee);
        //Not init properly. reason unknown.
        //_manager.ReceivedWhitelistAddMessage(invitee);
    }
}
