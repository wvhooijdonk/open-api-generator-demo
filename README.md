# Demo generating a service-side API by using an open api specification (yaml) and asp.net core

Generates an abstract API as a library. The web project references this library and implements the abstract API.

## Requirements
* npm
* java

## Commands

### Generate the API
npx @openapitools/openapi-generator-cli generate -c generator.yaml