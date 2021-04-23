Imports System.Threading
Imports Discord
Imports Discord.WebSocket

Namespace Racebot
    Module Program

        Sub Main()
            MainAsync().GetAwaiter().GetResult()
        End Sub

        Async Function MainAsync() As Task
            Dim client = New DiscordSocketClient()
            Await client.LoginAsync(TokenType.Bot, "Bot Token") 'I'll figure out a better way to do this later.
            Await client.StartAsync()
            Await Task.Delay(Timeout.Infinite)
        End Function

    End Module
End Namespace