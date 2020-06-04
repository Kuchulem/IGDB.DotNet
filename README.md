![Build](https://github.com/Kuchulem/IGDB.DotNet/workflows/Build/badge.svg?branch=master) ![Unit Tests](https://github.com/Kuchulem/IGDB.DotNet/workflows/Unit%20Tests/badge.svg?branch=master)

# IGDB.DotNet

Client library for [IGDB API](https://api-docs.igdb.com/#about).

## Install

### Nuget package

*recommended*

In Visual studio *Package Manager* : search for `IGDB.DotNet.Client` and click `install` on the right panel

In command line :

```ps
Install-Package IGDB.DotNet
```

You can select a particular version.

```ps
Install-Package IGDB.DotNet.Client -Version 1.0.0
```

You can install the package for a project that is not the default one :

```ps
Install-Package IGDB.DotNet.Client -ProjectName YourMagicalProject
```

### From the source

*Not recommended*

Clone the repository :

```sh
git clone git@github.com:Kuchulem/IGDB.DotNet.git
```

Add the project to your solution in VisualStudio and add a reference to it in your own project.

If you prefere command line :

Add it to your solution

```sh
dotnet sln add ~/source/repo/IGDB.DotNet/IGDB.DotNet.Client/IGDB.DotNet.Client.csproj
```

Add a reference to the library

```sh
dotnet add Contoso.MyProject/Contoso.MyProject.csproj reference IGDB.DotNet.Client/IGDB.DotNet.Client.csproj
```
