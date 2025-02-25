﻿using GameServer.Maps;
using GameServer.Networking;
using GameServer.Templates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameServer.PlayerCommands
{
    public class PlayerCommandReload : PlayerCommand
    {
        public override void Execute()
        {
            SystemDataService.ReloadData();
            MapGatewayProcess.ReloadContent();
        }
    }
}
