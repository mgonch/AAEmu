﻿using AAEmu.Commons.Network;
using AAEmu.Game.Core.Managers;
using AAEmu.Game.Core.Network.Game;

namespace AAEmu.Game.Core.Packets.C2G
{
    public class CSUsePortalPacket : GamePacket
    {
        public CSUsePortalPacket() : base(0x0da, 1)
        {
        }

        public override void Read(PacketStream stream)
        {
            var objId = stream.ReadBc();
            var onlyMyPortal = stream.ReadBoolean();
            
            _log.Debug("UsePortal, ObjId: {0}, OnlyMyPortal: {1}", objId, onlyMyPortal);

            PortalManager.Instance.UsePortal(Connection.ActiveChar, objId);
        }
    }
}
