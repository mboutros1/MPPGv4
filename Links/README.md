# MPPGv4 REFERENCE LINKS

## TABLE OF CONTENTS

- [A. MPPGv4 SERVICE](#A-MPPGv4-SERVICE)
- [B. MPPG AND ALTERNATIVE PAYMENTS](#B-MPPG-AND-ALTERNATIVE-PAYMENTS)
- [C. MPPG PORTAL SERVICES](#C-MPPG-PORTAL-SERVICES)

## A. MPPGv4 SERVICE

- P/N D99810044: [Overview: Magensa Payment Protection Gateway Service](https://www.magtek.com/content/documentationfiles/d99810044.pdf)
- P/N 998200263: [Magensa Payment Protection Gateway version 4.0 | MPPG 4.0 Operations | Programmer's Reference Manual](https://www.magtek.com/Content/DocumentationFiles/D998200263.pdf)
- P/N D998200349: [Magensa Payment Protection Gateway (MPPGv4 and v3) | EMV (chip card) Acceptance | Integration Guide](https://www.magtek.com/content/documentationfiles/d998200349.pdf)
- P/N D998200457: [Sample MPPGv4 XML/SOAP requests](https://www.magtek.com/Content/SoftwarePackages/D998200457.zip)
- MPPG service links:
  - XML
    - Link: [URL for MPPG Web Service v4](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc)
    - Link: [WSDL for MPPG Web Service v4](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc?WSDL)
    - Link: [URI for ProcessData](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/ProcessData)
    - Link: [URI for ProcessReferenceID](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/ProcessReferenceID)
    - Link: [URI for ProcessToken](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/ProcessToken)
  - JSON
    - Link: [JSON help for MPPG web service v4](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/JSON/help)
    - Link: [URI for ProcessData](https://mppg.magensa.net/V4/MPPGv4Service.svc/JSON/ProcessData)
    - Link: [URI for ProcessReferenceID](https://mppg.magensa.net/V4/MPPGv4Service.svc/JSON/ProcessReferenceID)
    - Link: [URI for ProcessToken](https://mppg.magensa.net/V4/MPPGv4Service.svc/JSON/ProcessToken)
- Link: [MPPGv4 documents and code samples on Github](https://github.com/Magensa/MPPGv4/tree/master)


## B. MPPG AND ALTERNATIVE PAYMENTS

- Link: [Alternative Payments Demo - main landing page](https://demo.magensa.net/tec)

- E-wallets
  - Apple Pay -- NFC taps from devices with Apple Pay are handled by NFC-enabled MagTek readers like any other contactless card
  - Google Pay -- NFC taps from devices with Google Pay are handled by NFC-enabled MagTek readers like any other contactless card

- In-app payments
  - Apple Pay
    - Link: [XML/SOAP URI for MPPGv4 API method ProcessInAppApplePay](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/ProcessInAppApplePay)
    - Link: [JSON/REST URI for MPPGv4 API method ProcessInAppApplePay](https://mppg.magensa.net/V4/MPPGv4Service.svc/JSON/ProcessInAppApplePay)
  - Google Pay
    - Link: [XML/SOAP URI for MPPGv4 API method ProcessGooglePay](http://www.magensa.net/MPPGv4/IMPPGv4Service/ProcessGooglePay)
    - Link: [JSON/REST URI for MPPGv4 API method ProcessGooglePay](https://svc1.magensa.net/MPPGv4/MPPGv4Service.svc/JSON/ProcessGooglePay)
  - PayPal/Venmo
    - P/N D998200515: [MPPG v3.0 and v4.0 | PayPal/Venmo API | Developer Program Manual](https://www.magtek.com/content/documentationfiles/d998200515.pdf)
    - Link: [PayPal/Venmo demo page](https://demo.magensa.net/tec/paypal-venmo/paypal-venmo-request)

- Web app payments
  - Apple Pay
    - Link: [TokenExchange Connect / Apple Pay demo page](https://demo.magensa.net/tec/tec-apple-pay/apple-pay-button)
  - Google Pay
    - Link: [TokenExchange Connect / Google Pay demo page](https://demo.magensa.net/tec/tec-google-pay/)
  - Web app payment requests using Apple Pay or Google Pay
    - Link: [Github README: TokenExchange Connect Payment Request: React](https://github.com/Magensa/te-connect-react/blob/master/TecPaymentRequestREADME.md)
    - Link: [Github README: TokenExchange Connect Payment Request: Angular](https://github.com/Magensa/te-connect-ng/blob/master/TecPaymentRequestREADME.md)
    - Link: [Github README: TokenExchange Connect Payment Request: JavaScript](https://github.com/Magensa/te-connect-js/blob/master/TecPaymentRequestREADME.md)


- Pay request app (payment link for QR code)
  - P/N D998200529: [Magensa Payment Protection Gateway Versions 3&4 | Payment Request API | Specifications and Integration Guide](https://www.magtek.com/Content/DocumentationFiles/D998200529.pdf)
  - Link: [Payment Request demo page](https://demo.magensa.net/tec/payment-request/create-new-pr)
  - Link: [Swagger page for PaymentRequest API Gateway](https://paymentrequest.magensa.net/swagger/index.html)
  - URL for PaymentRequest API: https://paymentrequest.magensa.net/api/PaymentRequest

- TokenExchange Connect
  - Link: [Github page for TokenExchange Connect](https://github.com/Magensa/te-connect)
    - Link: [Github README: TokenExchange Connect React component](https://github.com/Magensa/te-connect-react)
    - Link: [Github README: TokenExchange Connect Angular component](https://github.com/Magensa/te-connect-ng)
    - Link: [Github README: TokenExchange Connect JavaScript component](https://github.com/Magensa/te-connect-js)
  - Link: [TokenExchange Connect demo page](https://demo.magensa.net/tec/tec-mppg/token-exchange-form)
  - **NOTE**:  The Github pages for the TokenExchange Connect components include sample code that refers to a parameter for createTEConnect() called either  "__publicKeyGoesHere__" or "__your_public_key_here__".  This is the same parameter that is included in the Magensa account onboarding worksheet and referred to as "Auth Header".  This value is a base64-encoded concatenation of the TokenExchange Connect credentials in the form "<CUSTOMER_CODE>/<USERNAME>:<PASSWORD>".

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

- MPPGv2 Portal Service API
  - Link: [URL for MPPG Portal Service v2 (svc1.magensa.net)](https://svc1.magensa.net/MPPGv2Portal/MPPGv2PortalService.svc)
  - Link: [WSDL for MPPG Portal Service v2 (svc1.magensa.net)](https://svc1.magensa.net/MPPGv2Portal/MPPGv2PortalService.svc?WSDL)
  - Link: [URL for MPPG Portal Service v2 (mppg.magensa.net)](https://mppg.magensa.net/v2Portal/MPPGv2PortalService.svc)
  - Link: [WSDL for MPPG Portal Service v2 (mppg.magensa.net)](https://mppg.magensa.net/v2Portal/MPPGv2PortalService.svc?WSDL)
  - P/N D998200216: [Magensa Web Services | Portal Service | MPPGv2 Portal Service Programmer's Reference Manual](https://www.magtek.com/content/documentationfiles/d998200216.pdf)
- Magensa Reseller Portal
  - Link: [MPPG Reseller Portal](https://reseller.magensa.net/Account/SignIn)
  - P/N D998200300: [Magensa Reseller Portal | Magensa Web Services | Operation Manual](https://www.magtek.com/content/documentationfiles/d998200300.pdf)
  - P/N D998200062: [Reseller Account Admin Portal | For Resellers & Magensa Support](https://www.magtek.com/content/documentationfiles/d998200062.pdf)
- Magensa Services status page
  - Link: [URL for StatusPage (magensa.statuspage.io)](https://magensa.statuspage.io/)
