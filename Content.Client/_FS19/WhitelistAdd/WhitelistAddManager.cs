using Content.Shared._FS19.WhitelistAdd;
using Robust.Shared.Player;
using Robust.Shared.Network;

namespace Content.Client._FS19.WhitelistAdd;

public interface WhitelistAddManager : SharedWhitelistAddManager
{
    public void ReceivedWhitelistAddMessage(string invitee)
    {
        ICommonSession player = default!;
        NetUserId inviter = player.UserId;
        string Invitee = invitee;
    }
}
