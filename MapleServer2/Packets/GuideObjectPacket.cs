﻿using MaplePacketLib2.Tools;
using MapleServer2.Constants;
using MapleServer2.Types;

namespace MapleServer2.Packets
{
    public static class GuideObjectPacket {
        public static Packet Bracket(IFieldObject<Player> player) {
            return PacketWriter.Of(SendOp.GUIDE_OBJECT)
                .WriteByte(0x00)
                .WriteShort(1) // Type?
                .WriteInt(player.ObjectId)
                .WriteLong(player.Value.CharacterId)
                .Write(player.Coord.ClosestBlock())
                .Write(default); // Unknown
        }

        public static Packet Remove(IFieldObject<Player> player) {
            return PacketWriter.Of(SendOp.GUIDE_OBJECT)
                .WriteByte(0x01)
                .WriteInt(player.ObjectId)
                .WriteLong(player.Value.CharacterId);
        }
    }
}