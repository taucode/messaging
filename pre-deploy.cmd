dotnet restore

dotnet build TauCode.Messaging.sln -c Debug
dotnet build TauCode.Messaging.sln -c Release

dotnet test TauCode.Messaging.sln -c Debug
dotnet test TauCode.Messaging.sln -c Release

nuget pack nuget\TauCode.Messaging.nuspec