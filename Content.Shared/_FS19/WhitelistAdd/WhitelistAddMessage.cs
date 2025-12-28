using Lidgren.Network;
using Robust.Shared.Network;
using Robust.Shared.Serialization;

namespace Content.Shared._FS19.WhitelistAdd;

public sealed class WhitelistAddMessage : NetMessage
{
    public override MsgGroups MsgGroup => MsgGroups.Command;
    public WhitelistAddUsername Username = new();

    public override void ReadFromBuffer(NetIncomingMessage buffer, IRobustSerializer serializer)
    {
        Username.Invitee = buffer.ReadString();
    }

    public override void WriteToBuffer(NetOutgoingMessage buffer, IRobustSerializer serializer)
    {
        buffer.Write(Username.Invitee);
    }
}


public sealed class WhitelistAddUsername
{
    public string Invitee = string.Empty;
}
