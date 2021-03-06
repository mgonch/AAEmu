using AAEmu.Commons.Network;

namespace AAEmu.Game.Models.Game.Items.Actions
{
    public class ItemBuyback : ItemTask
    {
        private Item _item;

        public ItemBuyback(Item item)
        {
            _type = 6;
            _item = item;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);
            stream.Write((byte) 0); // v
            stream.Write((byte) _item.SlotType); // v
            stream.Write((byte) 0); // v
            stream.Write((byte) _item.Slot); // v

            stream.Write(_item.TemplateId);
            stream.Write(_item.Id);
            stream.Write(_item.Grade);
            stream.Write((byte) 0); // bounded
            stream.Write(_item.Count); // stack
            var details = new PacketStream();
            details.Write(_item.DetailType);
            _item.WriteDetails(details);
            stream.Write((short) 128); // length details?
            stream.Write(details, false);
            stream.Write(new byte[128 - details.Count]);
            stream.Write(_item.CreateTime);
            stream.Write(_item.LifespanMins);
            stream.Write(0); // type(id)
            stream.Write(_item.WorldId);
            stream.Write(_item.UnsecureTime);
            stream.Write(_item.UnpackTime);
            return stream;
        }
    }
}