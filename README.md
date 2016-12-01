## Sample ASP.NET Core Web API application
Based on 
- [More about .NET Core](https://www.microsoft.com/net/core/platform)
- [HOSTING .NET CORE ON LINUX WITH DOCKER - A NOOB'S GUIDE](http://blog.scottlogic.com/2016/09/05/hosting-netcore-on-linux-with-docker.html)
- [Microsoft/dotnet docker image](https://hub.docker.com/r/microsoft/dotnet/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/).

### Run a docker container:
1. Clone or download this repository to local machine.
2. Install [Docker for your platform](https://www.docker.com/) if didn't install yet.
3. `cd SampleWebApiNetCore/src/SampleWebApiNetCore`
4. Create dbsettings.json - see more below
5. `sudo docker build -t enter-name-your-docker-container .`
6. `sudo docker run -p 5000:5000 -it enter-name-your-docker-container` or `sudo docker run -p 5000:5000 -d enter-name-your-docker-container` to run detached.


### Run local with CLI
1. Clone or download this repository to local machine.
2. Install [.NET Core SDK for your platform](https://www.microsoft.com/net/core#windowscmd) if didn't install yet.
3. `cd SampleWebApiNetCore/src/SampleWebApiNetCore`
4. Create dbsettings.json - see more below
5. `dotnet restore`
6. `dotnet run`

### Run on Visual Studio
1. Install [Visual Studio 2015 for your platform](https://www.visualstudio.com/vs/) if didn't install yet.
2. Install [Visual Studio 2015 Tools (Preview 2)](https://www.microsoft.com/net/download/core) if didn't install yet.
3. [Visual Studio tools include .NET Core 1.0.1. You need to also install .NET Core 1.1 runtime to add support the .NET Core 1.1](https://www.microsoft.com/net/download/core) if didn't install yet.
4. Open project
5. Create dbsettings.json - see more below
6. Debug -> Start debugging

### Create dbsettings.json
1. Create file `dbsettings.json` into SampleWebApiNetCore/src/SampleWebApiNetCore with right settings(host/login/password and etc.) 
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "User ID=your-user;Password=your-password;Host=your-host;Port=5432;Database=your-db-name;Pooling=true;"
  }
}
```
