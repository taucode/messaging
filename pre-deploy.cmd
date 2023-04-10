dotnet restore

dotnet build TauCode.Messaging.Abstractions.sln -c Debug
dotnet build TauCode.Messaging.Abstractions.sln -c Release

dotnet test TauCode.Messaging.Abstractions.sln -c Debug
dotnet test TauCode.Messaging.Abstractions.sln -c Release

nuget pack nuget\TauCode.Messaging.Abstractions.nuspec