dotnet new console

Add to csproj:
  <ItemGroup>
    <DotNetCliToolReference Include="dotnet-svcutil" Version="1.0.*" />
  </ItemGroup>

dotnet add package System.ServiceModel.Primitives
dotnet add package System.ServiceModel.Http

dotnet svcutil http://services.aonaware.com/DictService/DictService.asmx?WSDL -n '*,whatever-namespace-you-want'

Rename the ServiceReference1 folder and related files as needed (DictServers/DictServices.cs in this case)

dotnet run

