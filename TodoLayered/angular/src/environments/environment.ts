import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: "Todo",
    logoUrl: "",
  },
  oAuthConfig: {
    issuer: 'https://localhost:44346/',
    redirectUri: baseUrl,
    clientId: 'TodoAppLayered_App',
    responseType: 'code',
    scope: 'offline_access TodoAppLayered',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44346',
      rootNamespace: 'TodoAppLayered',
    },
  },
} as Environment;
