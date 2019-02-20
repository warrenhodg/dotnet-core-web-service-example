# Dotnet Core Web Services Example

Steps:
1. Create a new console application:
`dotnet new console`

2. Ensure that the `dotnet svcutil` tool is available:
Add to `dotnet-core-wsdl.csproj`:
```
  <ItemGroup>
    <DotNetCliToolReference Include="dotnet-svcutil" Version="1.0.*" />
  </ItemGroup>
```

then

`dotnet restore`

3. Add relevant Web Service Nuget packages:
```
dotnet add package System.ServiceModel.Primitives
dotnet add package System.ServiceModel.Http
```

4. Create the Web Service proxy classes:
`dotnet svcutil http://services.aonaware.com/DictService/DictService.asmx?WSDL -n '*,whatever-namespace-you-want'`

5. Tidy up:
Rename the `ServiceReference1` folder and related files as needed (`DictServers/DictServices.cs` in this case)

6. Execute:
`dotnet run`

