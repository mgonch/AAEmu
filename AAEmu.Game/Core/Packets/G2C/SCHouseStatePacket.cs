using AAEmu.Commons.Network;
using AAEmu.Game.Core.Network.Game;
using AAEmu.Game.Models.Game;

namespace AAEmu.Game.Core.Packets.G2C
{
    public class SCHouseStatePacket : GamePacket
    {
        private readonly HouseData _houseData;
        
        public SCHouseStatePacket(HouseData houseData) : base(0x0b4, 1)
        {
            _houseData = houseData;
        }

        public override PacketStream Write(PacketStream stream)
        {
            stream.Write(_houseData);
            return stream;
        }
    }
}
