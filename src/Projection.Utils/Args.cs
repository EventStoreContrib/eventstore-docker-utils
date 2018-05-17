﻿using PowerArgs;

namespace EventStoreContrib.Utils
{
    public class UpdateProjectionsIfNeededArgs : BaseArgs
    {
        [ArgRequired, ArgDescription("Full path to the directory that contains the projections."), ArgShortcut("d")]
        public string Directory { get; internal set; }
    }

    public class EnsureProjectionsEnabledArgs : BaseArgs
    {
        [ArgRequired, ArgDescription("A comma seperated list of projections to ensure that are enabled."), ArgShortcut("pr")]
        public string Projections { get; set; }
    }

    public class BaseArgs
    {
        [ArgRequired, ArgDescription("The ip address of the Event Store instance"), ArgShortcut("ip")]
        public string IpAddress { get; set; }

        [ArgRequired, ArgDescription("The port number (web) of the Event Store instance"), ArgShortcut("po"), ArgDefaultValue("2113")]
        public string Port { get; set; }

        [ArgRequired, ArgDescription("The username to connect to the Event Store instance with"), ArgShortcut("u"), ArgDefaultValue("admin")]
        public string Username { get; set; }

        [ArgRequired, ArgDescription("The password to connect to the Event Store instance with"), ArgShortcut("p"), ArgDefaultValue("changeit")]
        public string Password { get; set; }

        [ArgRequired, ArgDescription("The timeout to use for operations"), ArgShortcut("to"), ArgDefaultValue(3000)]
        public int OperationTimeout { get; set; }
    }
}