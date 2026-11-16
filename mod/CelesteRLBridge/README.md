# CelesteRLBridge

## Development from a separate repository

The source project can live in a separate repository while build output is copied
to the installed mod directory. Configure the paths locally with an uncommitted
`Directory.Build.props` file in the source repository root:

```xml
<Project>
  <PropertyGroup>
    <ModDir>/Applications/Celeste.app/Contents/Resources/Mods/CelesteRLBridge</ModDir>
    <CelestePrefix>/Applications/Celeste.app/Contents/Resources</CelestePrefix>
  </PropertyGroup>
</Project>
```

For example:

```text
CelesteRLBridge/
├── Directory.Build.props
└── Source/
    └── CelesteRLBridge.csproj
```

`Directory.Build.props` is automatically imported by MSBuild. Replace the paths
with the locations on your machine, then build normally:

```sh
dotnet build Source/CelesteRLBridge.csproj -c Debug
```

The build copies `CelesteRLBridge.dll` and `.pdb` to `ModDir/bin`. Release builds
also create `CelesteRLBridge.zip` in `ModDir`. `CelestePrefix` must point to the
directory containing `Celeste.dll`, `MMHOOK_Celeste.dll`, and `FNA.dll`.

Because these paths are machine-specific, keep `Directory.Build.props` out of Git.