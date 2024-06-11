# Demo generating a service-side API

Source: open api specification (yaml)\
Stack: asp.net core\
\
Generates an abstract API as a library. The web project references this library and implements the abstract API.

## Requirements
* npm
* java

## Commands

### Generate the API
npx @openapitools/openapi-generator-cli generate -c generator.yaml