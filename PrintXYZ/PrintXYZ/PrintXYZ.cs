using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MiNET;
using MiNET.Plugins;
using MiNET.Plugins.Attributes;
using MiNET.Net;
using MiNET.Utils;
using MiNET.Plugins.Commands;

namespace PrintXYZ
{
    [Plugin]
    public class PrintXYZ : Plugin
    {
        protected override void OnEnable()
        {
            base.OnEnable();
            Console.WriteLine("[PrintXYZ] > Enable!");
            Console.WriteLine("[PrintXYZ] Made by ANDLOG | 엔로그");
        }
        
        [PacketHandler, Receive]
        public Package onMove (McpeMovePlayer pk, Player pl)
        {
           if(pl.Inventory.GetItemInHand().Id == 345)
            {
                double x = Math.Round(pl.KnownPosition.X, 1);
                double y = Math.Round(pl.KnownPosition.Y, 1);
                double z = Math.Round(pl.KnownPosition.Z, 1);
                pl.SendTitle($"§6X : {x} Y : {y} Z : {z}", stayTime: 1);
            }
            return pk;
        }
    }
}