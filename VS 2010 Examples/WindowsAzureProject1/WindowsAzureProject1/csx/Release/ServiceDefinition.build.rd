<?xml version="1.0" encoding="utf-8"?>
<serviceModel xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" name="WindowsAzureProject1" generation="1" functional="0" release="0" Id="b61559a5-68f5-4e2e-82f5-7931e8b6f6c6" dslVersion="1.2.0.0" xmlns="http://schemas.microsoft.com/dsltools/RDSM">
  <groups>
    <group name="WindowsAzureProject1Group" generation="1" functional="0" release="0">
      <componentports>
        <inPort name="MvcWebRole1:Endpoint1" protocol="http">
          <inToChannel>
            <lBChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/LB:MvcWebRole1:Endpoint1" />
          </inToChannel>
        </inPort>
        <inPort name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/LB:MvcWebRole1:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </inToChannel>
        </inPort>
        <inPort name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp">
          <inToChannel>
            <lBChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/LB:WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inToChannel>
        </inPort>
      </componentports>
      <settings>
        <aCS name="Certificate|MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapCertificate|MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="Certificate|WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapCertificate|WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </maps>
        </aCS>
        <aCS name="MvcWebRole1Instances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapMvcWebRole1Instances" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </maps>
        </aCS>
        <aCS name="WorkerRole2Instances" defaultValue="[1,1,1]">
          <maps>
            <mapMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MapWorkerRole2Instances" />
          </maps>
        </aCS>
      </settings>
      <channels>
        <lBChannel name="LB:MvcWebRole1:Endpoint1">
          <toPorts>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Endpoint1" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:MvcWebRole1:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint">
          <toPorts>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </toPorts>
        </lBChannel>
        <lBChannel name="LB:WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput">
          <toPorts>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </toPorts>
        </lBChannel>
        <sFSwitchChannel name="SW:MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp">
          <toPorts>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
          </toPorts>
        </sFSwitchChannel>
        <sFSwitchChannel name="SW:WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp">
          <toPorts>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
          </toPorts>
        </sFSwitchChannel>
      </channels>
      <maps>
        <map name="MapCertificate|MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapCertificate|WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" kind="Identity">
          <certificate>
            <certificateMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
          </certificate>
        </map>
        <map name="MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </setting>
        </map>
        <map name="MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </setting>
        </map>
        <map name="MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </setting>
        </map>
        <map name="MapMvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </setting>
        </map>
        <map name="MapMvcWebRole1Instances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1Instances" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" />
          </setting>
        </map>
        <map name="MapWorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" kind="Identity">
          <setting>
            <aCSMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" />
          </setting>
        </map>
        <map name="MapWorkerRole2Instances" kind="Identity">
          <setting>
            <sCSPolicyIDMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2Instances" />
          </setting>
        </map>
      </maps>
      <components>
        <groupHascomponents>
          <role name="MvcWebRole1" generation="1" functional="0" release="0" software="C:\Users\Anthony\Documents\UW PCE\github\UW-PCE-Cloud-Computing-302\VS 2010 Examples\WindowsAzureProject1\WindowsAzureProject1\csx\Release\roles\MvcWebRole1" entryPoint="base\x86\WaHostBootstrapper.exe" parameters="base\x86\WaIISHost.exe " memIndex="1792" hostingEnvironment="frontendadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Endpoint1" protocol="http" portRanges="80" />
              <inPort name="Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" protocol="tcp" portRanges="8172" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp" portRanges="3389" />
              <outPort name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/SW:MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
              <outPort name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/SW:WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;MvcWebRole1&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;MvcWebRole1&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WorkerRole2&quot;&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
            <storedcertificates>
              <storedCertificate name="Stored0Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1Instances" />
            <sCSPolicyFaultDomainMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1FaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
        <groupHascomponents>
          <role name="WorkerRole2" generation="1" functional="0" release="0" software="C:\Users\Anthony\Documents\UW PCE\github\UW-PCE-Cloud-Computing-302\VS 2010 Examples\WindowsAzureProject1\WindowsAzureProject1\csx\Release\roles\WorkerRole2" entryPoint="base\x86\WaHostBootstrapper.exe" parameters="base\x86\WaWorkerHost.exe " memIndex="1792" hostingEnvironment="consoleroleadmin" hostingEnvironmentVersion="2">
            <componentports>
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" protocol="tcp" />
              <inPort name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp" portRanges="3389" />
              <outPort name="MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/SW:MvcWebRole1:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
              <outPort name="WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" protocol="tcp">
                <outToChannel>
                  <sFSwitchChannelMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/SW:WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp" />
                </outToChannel>
              </outPort>
            </componentports>
            <settings>
              <aCS name="Microsoft.WindowsAzure.Plugins.Diagnostics.ConnectionString" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountEncryptedPassword" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountExpiration" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.AccountUsername" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteAccess.Enabled" defaultValue="" />
              <aCS name="Microsoft.WindowsAzure.Plugins.RemoteForwarder.Enabled" defaultValue="" />
              <aCS name="__ModelData" defaultValue="&lt;m role=&quot;WorkerRole2&quot; xmlns=&quot;urn:azure:m:v1&quot;&gt;&lt;r name=&quot;MvcWebRole1&quot;&gt;&lt;e name=&quot;Endpoint1&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint&quot; /&gt;&lt;/r&gt;&lt;r name=&quot;WorkerRole2&quot;&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteAccess.Rdp&quot; /&gt;&lt;e name=&quot;Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput&quot; /&gt;&lt;/r&gt;&lt;/m&gt;" />
            </settings>
            <resourcereferences>
              <resourceReference name="DiagnosticStore" defaultAmount="[4096,4096,4096]" defaultSticky="true" kind="Directory" />
              <resourceReference name="EventStore" defaultAmount="[1000,1000,1000]" defaultSticky="false" kind="LogStore" />
            </resourcereferences>
            <storedcertificates>
              <storedCertificate name="Stored0Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" certificateStore="My" certificateLocation="System">
                <certificate>
                  <certificateMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2/Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
                </certificate>
              </storedCertificate>
            </storedcertificates>
            <certificates>
              <certificate name="Microsoft.WindowsAzure.Plugins.RemoteAccess.PasswordEncryption" />
            </certificates>
          </role>
          <sCSPolicy>
            <sCSPolicyIDMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2Instances" />
            <sCSPolicyFaultDomainMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2FaultDomains" />
          </sCSPolicy>
        </groupHascomponents>
      </components>
      <sCSPolicy>
        <sCSPolicyFaultDomain name="MvcWebRole1FaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyFaultDomain name="WorkerRole2FaultDomains" defaultPolicy="[2,2,2]" />
        <sCSPolicyID name="MvcWebRole1Instances" defaultPolicy="[1,1,1]" />
        <sCSPolicyID name="WorkerRole2Instances" defaultPolicy="[1,1,1]" />
      </sCSPolicy>
    </group>
  </groups>
  <implements>
    <implementation Id="0b1c7274-71f3-4a89-8478-3f0dc9b04616" ref="Microsoft.RedDog.Contract\ServiceContract\WindowsAzureProject1Contract@ServiceDefinition.build">
      <interfacereferences>
        <interfaceReference Id="7f94a0c1-c878-4310-ba14-dbc00c2c3661" ref="Microsoft.RedDog.Contract\Interface\MvcWebRole1:Endpoint1@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1:Endpoint1" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="549a675c-9c71-4a56-89db-811b85b58ee6" ref="Microsoft.RedDog.Contract\Interface\MvcWebRole1:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/MvcWebRole1:Microsoft.WindowsAzure.Plugins.WebDeploy.InputEndpoint" />
          </inPort>
        </interfaceReference>
        <interfaceReference Id="90e773fc-4d4e-49a0-9866-e23a2df17f8e" ref="Microsoft.RedDog.Contract\Interface\WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput@ServiceDefinition.build">
          <inPort>
            <inPortMoniker name="/WindowsAzureProject1/WindowsAzureProject1Group/WorkerRole2:Microsoft.WindowsAzure.Plugins.RemoteForwarder.RdpInput" />
          </inPort>
        </interfaceReference>
      </interfacereferences>
    </implementation>
  </implements>
</serviceModel>