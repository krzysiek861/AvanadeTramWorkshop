param location string = resourceGroup().location
@minLength(3)
@maxLength(24)
@description('Provide a prefix. Use only lower case letters and numbers.')
param name string

resource exampleStorage 'Microsoft.Storage/storageAccounts@2022-05-01'= {
  name: name
  location: location
  sku: {
    name: 'Standard_LRS'
  }
  kind: 'StorageV2'
}
