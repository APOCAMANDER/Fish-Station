using Content.Shared._FS19.WhitelistAdd;
using Robust.Server.Player;

namespace Content.Server._FS19.WhitelistAdd;

public sealed class WhitelistAddManager
{
    [Dependency] private readonly IPlayerManager _player = default!;

    private void ReceivedWhitelistAddUsername(WhitelistAddUsername message)
    {
        var inviter = message.MsgChannel.UserName;
        var invitee = message.invitee;
    }

}
