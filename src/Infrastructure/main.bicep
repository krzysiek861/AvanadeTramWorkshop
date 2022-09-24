param location string = deployment().location

@minLength(3)
@maxLength(6)
@description('Provide a prefix. Use only lower case letters and numbers.')
param prefix string

var storageName = '${prefix}tramworkshop'
var functionName = '${prefix}-tram-workshop-function'
var eventHubName = '${prefix}-tram-workshop-event-hub'
var vmName = '${prefix}-tram-vm'
var networkSecutityGropuName = '${prefix}-tram-workshop-nsg'
var appInsightsName = '${prefix}-tram-workshop-ai'

targetScope = 'subscription'

resource rg 'Microsoft.Resources/resourceGroups@2021-01-01' = {
  name: 'AzureTramWorkshop'
  location: location
}

module storageModule 'modules/storage.bicep' = {
  name: 'storageDeployment'
  scope: rg
  params: {
    location: location
    name: storageName
  }
}

module vmModule 'modules/vm.bicep' = {
  name: 'vmDeployment'
  scope: rg
  params: {
    adminPassword: 'Password1234'
    adminUsername: 'Trainer1234'
    dnsLabelPrefix: 'mytestdnsname'
    location: location
    OSVersion: '2022-datacenter'
    publicIPAllocationMethod: 'Dynamic'
    publicIpName: 'web01'
    publicIpSku: 'Basic'
    vmName: vmName
    vmSize: 'Standard_D3_v2'
  }
}
