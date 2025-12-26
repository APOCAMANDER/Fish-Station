using Content.Client._FS19.UserInterface.Systems.WhitelistAdd.UI;
using Content.Client.UserInterface.Screens;
using Content.Client.UserInterface.Systems.Gameplay;
using Content.Client.UserInterface.Systems.Vote;
using JetBrains.Annotations;
using Robust.Client.UserInterface.Controllers;
using Robust.Client.UserInterface.Controls;
using Robust.Client.Console;
using Robust.Client.UserInterface;

namespace Content.Client._FS19.UserInterface.Systems.WhitelistAdd;

[UsedImplicitly]

public sealed class WhitelistAddUIController : UIController
{
    [Dependency] private readonly IClientConsoleHost _console = default!;
    [Dependency] private readonly IUriOpener _uri = default!;

    private WhitelistAddMenu? _whitelistAddWindow;

    private void CloseWhitelistAddWindow()
    {
        _whitelistAddWindow?.Close();
    }

    public void ToggleWindow()
    {
        if (_whitelistAddWindow == null)
            return;

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
}
