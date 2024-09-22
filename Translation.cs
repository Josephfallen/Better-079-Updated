using System.ComponentModel;

using Exiled.API.Interfaces;

namespace Better079
{
    public sealed class Translation : ITranslation
    {
        [Description("User will see this message when he finishes copying SCP-079")]
        public string HackSuccessfully { get; private set; } = "<color=green>SCP-079 copied successfully.</color> Go to GATE B escape zone to help SCP-079 escape";

        [Description("User will see this message when he fails copying SCP-079")] 
        public string HackFailure { get; private set; } = "Hack failure. You should stay in place and hold chaos insurgency hack device to copy SCP-079. Try again.";

        [Description("User will see this message when he drops the device before SCP-079 escape")]
        public string DeviceDropMessage { get; private set; } = "Warning! You have {time} seconds to take device with SCP-079 back or copy will be lost";

        [Description("User will see this message if no active players as SCP-079 found")]
        public string HackFailureNoPlayers { get; private set; } = "Hack failure. No SCP-079 detected in facility systems";

        [Description("User will see this message on spawn as SCP-079")]
        public string SpawnMessage { get; private set; } = "<color=green>Connecting... Access granted!</color> <color=red>Open your console and enter .info to see your abilities</color>";
    }
}