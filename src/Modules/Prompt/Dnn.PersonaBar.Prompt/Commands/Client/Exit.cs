﻿using DotNetNuke.Entities.Portals;
using DotNetNuke.Entities.Users;
using Dnn.PersonaBar.Library.Prompt.Attributes;
using Dnn.PersonaBar.Library.Prompt;
using Dnn.PersonaBar.Library.Prompt.Models;
using System;

namespace Dnn.PersonaBar.Prompt.Commands.Client
{
    [ConsoleCommand("exit", "Exits console screen", new string[] { })]
    public class Exit : IConsoleCommand
    {

        public string ValidationMessage
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Init(string[] args, PortalSettings portalSettings, UserInfo userInfo, int activeTabId)
        {
            throw new NotImplementedException();
        }

        public bool IsValid()
        {
            throw new NotImplementedException();
        }

        public ConsoleResultModel Run()
        {
            throw new NotImplementedException();
        }

    }
}