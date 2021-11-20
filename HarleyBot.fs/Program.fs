// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open System.Threading.Tasks
open Discord
open Discord.WebSocket

let client = new DiscordSocketClient()
let token =
    Environment.GetEnvironmentVariable("DISCORD_TOKEN", EnvironmentVariableTarget.User)

let mainTask =
    async {
        do! client.LoginAsync(TokenType.Bot, token) |> Async.AwaitTask
        do! client.StartAsync() |> Async.AwaitTask
        do! Task.Delay(-1) |> Async.AwaitTask
    }

[<EntryPoint>]
let main argv =
    Async.RunSynchronously(mainTask)
    0

