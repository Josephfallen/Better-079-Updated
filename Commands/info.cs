using System;
using System.Text;
using Exiled.API.Features;
using CommandSystem;
using RemoteAdmin;

namespace Better079.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class ListCommands : ICommand
    {
        public string Command => "info";
        public string Description => "Lists the Better079-specific commands.";

        public string[] Aliases => Array.Empty<string>();

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!(sender is PlayerCommandSender))
            {
                response = "Error. Only players can use this command.";
                return false;
            }

            // List of commands in the Better079.Commands namespace
            var commandList = new StringBuilder("Better079-specific commands:\n");
            commandList.AppendLine("copy - Allows you to copy SCP-079 and help him escape.");
            commandList.AppendLine("find - Teleport to random player room. Usage: .find <playerId/playerNick> or just .find");
            commandList.AppendLine("info - This command!");
            commandList.AppendLine("overcharge - Disables all lights in facility for selected time (Can be called only as SCP-079)");
            commandList.AppendLine("overload - Disabling all engaged generators (Can be called only as SCP-079)");
            commandList.AppendLine("shutdown - shutdown <playerId> <time> | Allows admins to lost signal for SCP-079");
            commandList.AppendLine("simulate - Send fake message to C.A.S.S.I.E by ID");

            response = commandList.ToString();
            return true;
        }
    }
}
