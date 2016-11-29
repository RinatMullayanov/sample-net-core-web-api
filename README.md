## Sample ASP.NET Core Web API application
Based on 
- [More about .NET Core](https://www.microsoft.com/net/core/platform)
- [HOSTING .NET CORE ON LINUX WITH DOCKER - A NOOB'S GUIDE](http://blog.scottlogic.com/2016/09/05/hosting-netcore-on-linux-with-docker.html)
- [Microsoft/dotnet docker image](https://hub.docker.com/r/microsoft/dotnet/)

### Run a docker container:
1. Clone or download this repository to local machine.
2. Install [Docker for your platform](https://www.docker.com/) if didn't install yet.
3. `cd SampleWebApiNetCore/src/SampleWebApiNetCore`
4. `sudo docker build -t enter-name-your-docker-container .`
5. `sudo docker run -p 5000:5000 -it enter-name-your-docker-container` or `sudo docker run -p 5000:5000 -d enter-name-your-docker-container` to run detached.


### Run local with CLI
1. Clone or download this repository to local machine.
2. Install [.NET Core SDK for your platform](https://www.microsoft.com/net/core#windowscmd) if didn't install yet.
3. `cd SampleWebApiNetCore/src/SampleWebApiNetCore`
4. `dotnet restore`
5. `dotnet run`

### Run on Visual Studio
1. Install [Visual Studio 2015 for your platform](https://www.visualstudio.com/vs/) if didn't install yet.
2. Open project
3. Debug -> Start debugging