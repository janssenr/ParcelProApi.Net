# ParcelProApi.Net [![Build status](https://ci.appveyor.com/api/projects/status/3hlolsaa6i8t27g1?svg=true)](https://ci.appveyor.com/project/janssenr/parcelproapi-net) [![NuGet version](https://badge.fury.io/nu/ParcelProApi.svg)](https://badge.fury.io/nu/ParcelProApi)
A C#/.net wrapper for the ParcelPro.nl API

# Installation

ParcelProApi.Net can easily be installed using the NuGet package

```
Install-Package ParcelProApi
```


# Getting started
Just create a new `ParcelProApiClient` with your own LoginId and API key.
API keys are available on [ParcelPro.nl](https://www.parcelpro.nl/). Check the API documentation [here](https://login.parcelpro.nl/api/docs.php)

```
var client = new ParcelProApiClient("[LoginId]", "[ApiKey]");
```

## Validatie
Om de juistheid van een gebruiker id en API key te valideren, kan gebruik worden gemaakt van deze API call.
```
var result = await client.ValidateApiKey();
```

## Type zendingen 
Om de mogelijke waarden voor de Type parameter van de zending aanmaken api op te vragen kan deze api worden aangeroepen. 
```
var results = await client.GetShipmentTypes();
```

## Uitreiklocaties
Om de uitreiklocaties van Pakje Gemak op te vragen tbv gebruik in de zending aanmaken api kan deze api worden aangeroepen. De api geeft de 20 dichtsbijzijnde uitreiklocaties in de omtrek van de opgegeven adresgegevens van de geadresseerde
```
var results = await client.GetPickupLocations("3191EE", "22", "Griede", Carrier.PostNl);
```

## Nieuwe zending
Een zending kan worden aangemeld met of zonder afzender gegevens. In het geval dat een zending wordt aangemeld met afzender gegevens, dan moet de postcode van de afzender worden opgenomen in de berekening van de HmacSha256 parameter tbv de authenticatie. In het geval dat er geen adresgegevens van de afzender worden meegegeven, dan wordt de zending aangemaakt met de adresgegevens van de opgegeven zoals geconfigureerd in login.parcelpro.nl. 

```
var shipmment = new ShipmentRequest
{
	Carrier = "DHL",
	ShipmentType = "DFY",
	Signature = false,
	OnlyRecipient = false,
	DirectEveningDelivery = false,
	SaturdayDelivery = false,
	ExtraSure = false,
	CashOnDelivery = 0,
	Insurance = 0,
	MailboxDelivery = true,
	AccountNumber = "",
	OrderNumber = "test",
	Reference = "test",
	SenderName = "Parcel Pro",
	SenderStreet = "Griede",
	SenderHousenumber = "22",
	SenderPostalcode = "3191EE",
	SenderCity = "Hoogvliet",
	SenderCountry = "NL",
	PickupLocationLocationType = "PostNL Postkantoor",
	PickupLocationName = "Jumbo",
	PickupLocationStreet = "Dorpsstraat",
	PickupLocationPostalcodeNumeric = "5737",
	PickupLocationPostalcodeAlpha = "GC",
	PickupLocationCity = "Lieshout",
	PickupLocationHousenumber = "54",
	PickupLocationHousenumeberAdditional = "A",
	PickupLocationProductCode = "1365092",
	SubmitAtServicePoint = true,
	RecipientName = "Pieter Jan Klaas",
	RecipientContactName = "",
	RecipientStreet = "Griede",
	RecipientHousenumber = "22",
	RecipientPostalcode = "3191EE",
	RecipientCity = "Hoogvliet",
	RecipientCountry = "NL",
	RecipientEmail = "test@test.nl",
	RecipientPhone = "0612345678",
	NumberOfPackages = 1,
	Weight = "10",
	Remark = "test"
};
var result = await client.PostShipment(shipmment);
```

## Label afdrukken 
Een label van een zending kan worden opgevraagd via deze API call. De response is een html pagina die direct een print opdracht aanroept. Je kunt alleen labels van je eigen zendingen printen. Het formaat van het label (A4 - A6) kan onder de instellingen van het account in het verzendsysteem aangepast worden. 
```
var result = await client.GetShipmentLabel(6597259, true);
```

## Status terugmelding
Het is mogelijk om te abonneren op bepaalde activiteiten binnen ons verzendsysteem. Je kan op de volgende activiteiten abonneren: 'Afgedrukt', 'Aannamenproces' en 'Afgeleverd' Als de zending deze status heeft bereikt zal de opgegegeven url getriggerd worden middels een POST request. 
```
var subscription = new Subscription
{
	Status = "afgedrukt",
	Url = "http://www.parcelpro.nl",
	Data = "ZendingId=?id&Status=Shipped&Referentie=?referentie"
};
var result = await client.PostSubscription(subscription);
```
