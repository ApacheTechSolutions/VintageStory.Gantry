﻿using ApacheTech.Common.BrighterSlim;
using Gantry.Core.Annotation;
using Gantry.Core.Brighter.Filters;
using Gantry.Services.BrighterChat;

namespace Gantry.Features.GantryChatCommands.ClientCommands;

[ClientSide]
internal class CmdClientDebug : MediatedChatCommand
{
    [ClientSide]
    internal class Handler : RequestHandler<CmdClientDebug>
    {

        [HandledOnClient]
        public override CmdClientDebug Handle(CmdClientDebug command)
        {
            // Do Stuff
            return base.Handle(command);
        }
    }
}