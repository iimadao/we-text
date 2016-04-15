﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeText.Common.Commands;

namespace WeText.Domain.Commands
{
    public class AddFriendCommand : Command
    {
        public Guid OriginatorId { get; set; }

        public Guid AcceptorId { get; set; }
    }
}
