using AAEmu.Commons.Network;
using AAEmu.Commons.Utils;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCTeleportUnitPacket : GamePacket
    {
        private readonly byte _reason;
        private readonly short _errorMessage;
        private readonly float _x;
        private readonly float _y;
        private readonly float _z;
        private readonly float _z2;
        
        public SCTeleportUnitPacket(byte reason, short errorMessage, float x, float y, float z, float z2) : base(0x06d, 1)
        {
            _reason = reason;
            _errorMessage = errorMessage;
            _x = x;
            _y = y;
            _z = z;
            _z2 = z2;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_reason);
            stream.Write(_errorMessage);
            stream.Write(Helpers.ConvertX(_x));
            stream.Write(Helpers.ConvertY(_y));
            stream.Write(Helpers.ConvertZ(_z));
            stream.Write(_z2);
            return stream;
        }
    }
}
