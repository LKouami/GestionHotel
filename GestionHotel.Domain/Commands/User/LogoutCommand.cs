﻿using System;

namespace GestionHotel.Domain.Commands.User
{
    public class LogoutCommand : CreateCommandBase<String>
    {
        public string Token { get; set; }
        public LogoutCommand()
            : base()
        {   

        }
    }

}
