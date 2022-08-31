# MAGENSA:
# MPPGv4 REFERENCE LINKS

## REVISION HISTORY

| Date        | Author             | Description
| -----       | -----              | --------
| 2022/08/31  | Chuck Maggs        | Initial creation of document in MarkDown

## TABLE OF CONTENTS

- [A. MPPGv4 SERVICE](#A.-MPPGv4-SERVICE)
- [B. MPPG SUPPORTING SERVICES](#B.-MPPG-SUPPORTING-SERVICES)
- [C. MPPG PORTAL SERVICES](#C.-MPPG-PORTAL-SERVICES)

## BEFORE YOU BEGIN

To perform this you will need the following:
- An iOS (iPad or iPhone) device
- Access to the Apple App Store from the iOS device
- A MagTek reader that works with the iOS device
- A card with an MSR stripe


## A. MPPGv4 SERVICE ([TOP](#MAGENSA))"

- Link: [URL for MPPG Web Service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc)
- Link: [WSDL for MPPG Web Service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc?WSDL)
- Link: [JSON help for MPPG web service v4](https://mppg.magensa.net/v4/MPPGv4Service.svc/JSON/help)
- P/N 998200263: [Magensa Payment Protection Gateway version 4.0 | MPPG 4.0 Operations | Programmer's Reference Manual](https://www.magtek.com/Content/DocumentationFiles/D998200263.pdf)
- P/N D998200349: [Magensa Payment Protection Gateway (MPPGv4 and v3) | EMV (chip card) Acceptance | Integration Guide](https://www.magtek.com/content/documentationfiles/d998200349.pdf)
- P/N D998200457: [Sample MPPGv4 XML/SOAP requests](https://www.magtek.com/Content/SoftwarePackages/D998200457.zip)
- Link: [MPPGv4 documents and code samples on Github](https://github.com/Magensa/MPPGv4/tree/master)


## B. MPPG SUPPORTING SERVICES ([TOP](#MAGENSA))"

- E-wallets
	- Apple Pay -- NFC taps from devices with Apple Pay are handled by NFC-enabled MagTek readers like any other contactless card
	- Google Pay -- NFC taps from devices with Google Pay are handled by NFC-enabled MagTek readers like any other contactless card

- In-app payments
	- Apple Pay
	- P/N D998200515: [MPPG v3.0 and v4.0 | PayPal/Venmo API | Developer Program Manual](https://www.magtek.com/content/documentationfiles/d998200515.pdf)

- Pay request app
	- P/N D998200529: [Magensa Payment Protection Gateway Versions 3&4 | Payment Request API | Specifications and Integration Guide](https://www.magtek.com/Content/DocumentationFiles/D998200529.pdf)

- TokenExchange Connect -- TEConnect includes support for web based in-app purchases with Apple Pay</LI></A>
	- Link: [Github page for TokenExchange Connect](https://github.com/Magensa/te-connect)
		- Link: [TokenExchange Connect React component](https://github.com/Magensa/te-connect-react)
		- Link: [TokenExchange Connect Angular component](https://github.com/Magensa/te-connect-ng)
		- Link: [TokenExchange Connect JavaScript component](https://github.com/Magensa/te-connect-js)

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


## C. MPPG PORTAL SERVICES ([TOP](#MAGENSA))"

 - MPPGv2 Portal Service
	- Link: [URL for MPPG Web Portal Service v2](https://mppg.magensa.net/v2Portal/MPPGv2PortalService.svc)
	- P/N D998200216: [Magensa Web Services | Portal Service | MPPGv2 Portal Service Programmer's Reference Manual](https://www.magtek.com/content/documentationfiles/d998200216.pdf)
 - Magensa Reseller Portal
	- P/N D998200300: [Magensa Reseller Portal | Magensa Web Services | Operation Manual](https://www.magtek.com/content/documentationfiles/d998200300.pdf)
	- P/N D998200062: [Reseller Account Admin Portal | For Resellers & Magensa Support](https://www.magtek.com/content/documentationfiles/d998200062.pdf)
