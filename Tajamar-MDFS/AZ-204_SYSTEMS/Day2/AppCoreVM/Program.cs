using Microsoft.Azure.Management.Compute.Fluent.Models;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using System;

namespace AppCoreVM
{
    class Program
    {
        static void Main(string[] args)
        {
            //De AZ CLI
            //az ad sp create-for-rbac --sdk:auth

            String clientId = "742b2038-8b0d-475f-aa4c-ab901825d0f8";
            String tenantId = "68519e48-83f3-435f-a38a-1a7aa77ba987";
            String SecretId = "0UyaAYXiCAy_xhE2M9LFTlWUgMgjwH-Z-W";

            var credentials = SdkContext.AzureCredentialsFactory.FromServicePrincipal(clientId, SecretId, tenantId, AzureEnvironment.AzureGlobalCloud);
            Console.WriteLine("1 - Credenciales Creadas");
            var azure = Azure.Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(credentials)
                .WithDefaultSubscription();
            Console.WriteLine("2 - Validacion correcta");
            var resourcegroup = azure.ResourceGroups
                .Define("RG-LINUX")
                .WithRegion(Region.USEast).Create();
            Console.WriteLine("3 - Grupo de recursos creado");
            var network = azure
                .Networks.Define("Network-console")
                .WithRegion(Region.USEast)
                .WithExistingResourceGroup(resourcegroup)
                .WithAddressSpace("10.0.0.0/16")
                .WithSubnet("subnet-console", "10.0.0.0/24")
                .Create();
            Console.WriteLine("4 - Network creada");
            var publicIp = azure.PublicIPAddresses
                .Define("public-console")
                .WithRegion(Region.USEast)
                .WithExistingResourceGroup(resourcegroup)
                .WithDynamicIP().Create();
            Console.WriteLine("5 - Public Ip creada");
            var networkInterface = azure.NetworkInterfaces
                .Define("network-interface")
                .WithRegion(Region.USEast)
                .WithExistingResourceGroup(resourcegroup)
                .WithExistingPrimaryNetwork(network)
                .WithSubnet("subnet-console")
                .WithPrimaryPrivateIPAddressDynamic()
                .WithExistingPrimaryPublicIPAddress(publicIp)
                .Create();
            Console.WriteLine("6 - Network Interface creada");
            Console.WriteLine("7 - Desplegando VM...");
            azure.VirtualMachines
                .Define("VM-CONSOLE")
                .WithRegion(Region.USEast)
                .WithExistingResourceGroup(resourcegroup)
                .WithExistingPrimaryNetworkInterface(networkInterface)
                .WithPopularLinuxImage(Microsoft.Azure.Management.Compute
                    .Fluent.KnownLinuxVirtualMachineImage.UbuntuServer16_04_Lts)
                .WithRootUsername("usuario")
                .WithRootPassword("Tajamar12345")
                .WithComputerName("VM-CONSOLE")
                .WithSize(VirtualMachineSizeTypes.StandardB1s)
                .Create();
            Console.WriteLine("8 - VM desplegada correctamente!");
        }
    }
}
