# RconCli
<p>
  <a href="https://github.com/Russlyman/RconCli/releases/latest" alt="Release">
    <img src="https://img.shields.io/github/v/release/Russlyman/RconCli" /></a>
  <a href="https://github.com/Russlyman/RconCli/blob/main/LICENSE" alt="License">
    <img src="https://img.shields.io/github/license/Russlyman/RconCli" /></a>
</p>

RconCli is a command line utility for interacting with game servers that implement the Quake III Arena RCon protocol.

RconCli does not retain a persistent connection. Once a command has been sent, the program will exit and would need to be ran again to send additional commands.

While RconCli should support all implementations of the Quake III RCon protocol, the underlying .NET library I created to address the RCon client has only been tested with FiveM. Feel free to raise an issue if you experience any problems.

## Example Usage
```cmd
RconCli -i 127.0.0.1 -p 30120 -x fivem -c "restart Vita"
```

## Command Line Options

All command line options are required.

**Commands that include spaces must be surrounded with speech marks!**

| Option | Short | Long | Example Input |
| --- | --- | --- | --- |
| IP Address | -i | --ip | 127.0.0.1 |
| RCon Port | -p | --port | 30120 |
| RCon Password | -x | --password | fivem |
| RCon Command | -c | --command | "restart Vita" |

## Download

**For Windows x64 only, if you want to run on different platforms then see the Build Yourself section!**

- Download the ZIP file from the assets section in the [latest release](https://github.com/Russlyman/RconCli/releases/latest)
- Extract ZIP
- See Example Usage and Command Line Options sections to use RconCli
## Build Yourself
**You must install .NET 6 to build this project!**

You can substitute `win-x64` in the command below with a different .NET 6 runtime identifier to build for other platforms. Some popular examples include `linux-x64`, `osx-x64`, `win-x84`.

- Download and extract the latest [source code](https://github.com/Russlyman/RconCli/archive/refs/heads/main.zip)
- Navigate to the folder that contains `README.MD`
- Run the command `dotnet publish RconCli -c Release -o publish -r win-x64 -p:PublishSingleFile=true -p:PublishReadyToRun=true --self-contained`
- See the `publish` folder which contains the freshly built binary
## License

This project is licensed under MIT which can be viewed from the `LICENSE` file.

This project utilises third party libraries which have been licensed under their own respective licenses and can be viewed from the `THIRDPARTYLEGALNOTICES` file.
