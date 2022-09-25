param location string = deployment().location

@minLength(3)
@maxLength(6)
@description('Provide a prefix. Use only lower case letters and numbers.')
param prefix string

var appInsightsName = '${prefix}-tram-ai'
var eventHubName = '${prefix}-tram-event-hub'
var functionAppName = '${prefix}-tram-function'
var hostingPlanName = '${prefix}-tram-plan'
var publicIpName = '${prefix}-tram-pip'
var storageAccountName = '${prefix}tramstg'
var vmName = '${prefix}-tram-vm'

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
    name: storageAccountName
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
    prefix: prefix
    publicIPAllocationMethod: 'Dynamic'
    publicIpName: publicIpName
    publicIpSku: 'Basic'
    storageAccountName : storageAccountName
    vmName: vmName
    vmSize: 'Standard_D3_v2'
  }
  dependsOn: [
    storageModule
  ]
}

module eventHubModule 'modules/eventhub.bicep' = {
  name: 'eventHubDeployment'
  scope: rg
  params: {
    location: location
    name: eventHubName
  }
}

module functionModule 'modules/function.bicep' = {
  name: 'functionDeployment'
  scope: rg
  params: {
    functionAppName: functionAppName
    appInsightsName: appInsightsName
    hostingPlanName: hostingPlanName
    location: location
    storageAccountName: storageAccountName
  }
  dependsOn: [
    storageModule, eventHubModule
  ]
}
