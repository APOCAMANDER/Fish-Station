using Lidgren.Network;
using Robust.Shared.Network;
using Robust.Shared.Serialization;
using Robust.Shared.Player;

namespace Content.Shared._FS19.WhitelistAdd;

[Serializable, NetSerializable]
public sealed class WhitelistAddMessage
{
    public string Invitee = string.Empty;

    public WhitelistAddMessage(string inviter, string invitee)
    {
        Invitee = invitee;
    }

}

public sealed class MsgWhitelistAddMessage : NetMessage
{
    public override MsgGroups MsgGroup => MsgGroups.Command;
    public WhitelistAddMessage Message = default!;

    public override void ReadFromBuffer(NetIncomingMessage buffer, IRobustSerializer serializer)
    {
        Message.Invitee = buffer.ReadString();
    }

    public override void WriteToBuffer(NetOutgoingMessage buffer, IRobustSerializer serializer)
    {
        buffer.Write(Message.Invitee);
    }
}
