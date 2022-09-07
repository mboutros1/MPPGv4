# MPPGv4 REFERENCE LINKS

## TABLE OF CONTENTS

- [A. MPPGv4 SERVICE](#A-MPPGv4-SERVICE)
- [B. MPPG AND ALTERNATIVE PAYMENTS](#B-MPPG-AND-ALTERNATIVE-PAYMENTS)
- [C. MPPG PORTAL SERVICES](#C-MPPG-PORTAL-SERVICES)

## A. MPPGv4 SERVICE

- P/N 998200263: [Magensa Payment Protection Gateway version 4.0 | MPPG 4.0 Operations | Programmer's Reference Manual](https://www.magtek.com/Content/DocumentationFiles/D998200263.pdf)
- P/N D998200349: [Magensa Payment Protection Gateway (MPPGv4 and v3) | EMV (chip card) Acceptance | Integration Guide](https://www.magtek.com/content/documentationfiles/d998200349.pdf)
- P/N D998200457: [Sample MPPGv4 XML/SOAP requests](https://www.magtek.com/Content/SoftwarePackages/D998200457.zip)
- Link: [URL for MPPG Web Service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc)
- Link: [WSDL for MPPG Web Service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc?WSDL)
- Link: [JSON help for MPPG web service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc/JSON/help)
- Link: [MPPGv4 documents and code samples on Github](https://github.com/Magensa/MPPGv4/tree/master)


## B. MPPG AND ALTERNATIVE PAYMENTS

- Link: [Alternative Payments Demo - main landing page](https://demo.magensa.net/tec)

- E-wallets
	- Apple Pay -- NFC taps from devices with Apple Pay are handled by NFC-enabled MagTek readers like any other contactless card
	- Google Pay -- NFC taps from devices with Google Pay are handled by NFC-enabled MagTek readers like any other contactless card

- In-app payments
	- Apple Pay
	- PayPal/Venmo
		- P/N D998200515: [MPPG v3.0 and v4.0 | PayPal/Venmo API | Developer Program Manual](https://www.magtek.com/content/documentationfiles/d998200515.pdf)
		- Link: [PayPal/Venmo demo page](https://demo.magensa.net/tec/paypal-venmo/paypal-venmo-request)

- Web app payments
	- Apple Pay
		- Link: [Github README: TokenExchange Connect Payment Request with Apple Pay: React](https://github.com/Magensa/te-connect-react/blob/master/TecPaymentRequestREADME.md)
		- Link: [Github README: TokenExchange Connect Payment Request with Apple Pay: Angular](https://github.com/Magensa/te-connect-ng/blob/master/TecPaymentRequestREADME.md)
		- Link: [Github README: TokenExchange Connect Payment Request with Apple Pay: JavaScript](https://github.com/Magensa/te-connect-js/blob/master/TecPaymentRequestREADME.md)
		- Link: [TokenExchange Connect / Apple Pay demo page](https://demo.magensa.net/tec/tec-apple-pay/apple-pay-button)

- Pay request app
	- P/N D998200529: [Magensa Payment Protection Gateway Versions 3&4 | Payment Request API | Specifications and Integration Guide](https://www.magtek.com/Content/DocumentationFiles/D998200529.pdf)
	- Link: [Payment Request demo page](https://demo.magensa.net/tec/payment-request/create-new-pr)

- TokenExchange Connect
	- Link: [Github page for TokenExchange Connect](https://github.com/Magensa/te-connect)
		- Link: [Github README: TokenExchange Connect React component](https://github.com/Magensa/te-connect-react)
		- Link: [Github README: TokenExchange Connect Angular component](https://github.com/Magensa/te-connect-ng)
		- Link: [Github README: TokenExchange Connect JavaScript component](https://github.com/Magensa/te-connect-js)
	- Link: [TokenExchange Connect demo page](https://demo.magensa.net/tec/tec-mppg/token-exchange-form)

The following is an outline of how you would integrate TokenExchange Connect with your MPPG implementation …

- COLLECT CARD DATA
	- Enter card information into the iframe provided by Magensa
	- Send the card data via the iframe’s secured, encrypted connection to the Magensa TokenExchange service
	- The TokenExchange service returns a response that contains a token that contains the card data in an encrypted vaultless token
- SEND TRANSACTION REQUEST
	- Build a ProcessToken request message that includes your transaction information as well as the token you received back from the TokenExchange service</LI>
	- Send the ProcessToken request to the MPPG service</LI>
	- Evaluate the response message received from the MPPG service</LI>

In order to use TokenExchange Connect and MPPG together, your Magensa credentials for TokenExchange and MPPG must be linked by the Magensa support team.  After they are linked, you can use the tokens returned by TokenExchange Connect in your MPPG transactions.


## C. MPPG PORTAL SERVICES

 - MPPGv2 Portal Service
	- Link: [URL for MPPG Web Portal Service v2](https://mppg.magensa.net/v2Portal/MPPGv2PortalService.svc)
	- P/N D998200216: [Magensa Web Services | Portal Service | MPPGv2 Portal Service Programmer's Reference Manual](https://www.magtek.com/content/documentationfiles/d998200216.pdf)
 - Magensa Reseller Portal
	- P/N D998200300: [Magensa Reseller Portal | Magensa Web Services | Operation Manual](https://www.magtek.com/content/documentationfiles/d998200300.pdf)
	- P/N D998200062: [Reseller Account Admin Portal | For Resellers & Magensa Support](https://www.magtek.com/content/documentationfiles/d998200062.pdf)
