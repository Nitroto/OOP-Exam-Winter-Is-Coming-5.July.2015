﻿using WinterIsComing.Core.Commands;

namespace WinterIsComing.Core
{
    public class CommandDispatcherExtension : CommandDispatcher
    {
        public override void SeedCommands()
        {
            this.commandsByName["toggle-effector"] = new ToggleEffectorCommand(this.Engine);
            base.SeedCommands();
        }
    }
}
