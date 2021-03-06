using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSMakeTeamOwnerPacket : GamePacket
    {
        public CSMakeTeamOwnerPacket() : base(0x07d, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var teamId = stream.ReadUInt32();
            var memberId = stream.ReadUInt32();

            _log.Warn("MakeTeamOwner, TeamId: {0}, MemberId: {1}", teamId, memberId);
        }
    }
}
