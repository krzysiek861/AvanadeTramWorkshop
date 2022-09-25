param location string = resourceGroup().location

@minLength(3)
@maxLength(24)
@description('Provide a prefix. Use only lower case letters and numbers.')
param name string

// One namespace allow maximum ten event hub.
var eventHubsCollection = [
  'tram-speed', 'wheel-speed', 'engine-temperature', 'inverter-temperature', 'air-temperature', 'traction-voltage'
  //'battery-voltage', 'current-consumption', 'tram-weight', 'blackout-sensor', 'smoke-sensor'
]

resource eventHubNamespace 'Microsoft.EventHub/namespaces@2022-01-01-preview' = {
  name: name
  location: location
  sku: {
    capacity: 1
    name: 'Standard'
    tier: 'Standard'
  }
  properties: {
    disableLocalAuth: false
    isAutoInflateEnabled: false
    kafkaEnabled: true
    minimumTlsVersion: '1.2'
    publicNetworkAccess: 'Enabled'
    zoneRedundant: true
  }
}

resource eventHub 'Microsoft.EventHub/namespaces/eventhubs@2022-01-01-preview' = [for item in eventHubsCollection: {
  name: '${item}-hub'
  parent: eventHubNamespace
  properties: {
    messageRetentionInDays: 1
    partitionCount: 1
    status: 'Active'
  }
}]

output eventHubConnectionString string = eventHubNamespace.properties.serviceBusEndpoint
