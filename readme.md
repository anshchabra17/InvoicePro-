3 layer clean architecture
presentation layer - invoicepro.api (controllers)
domain layer (entities )
invoice.infrastructure (data access layer ef used here)

# api folder contains controllers and configuration
exposes api to frontend
doest not have business logic
uses controller to receive http requestes

each controller telling endpoints 