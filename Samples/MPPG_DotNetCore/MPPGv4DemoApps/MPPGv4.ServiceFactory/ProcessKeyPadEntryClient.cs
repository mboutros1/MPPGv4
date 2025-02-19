﻿using System;
using System.IO;
using System.Net;
using Gaeasoft.Magensa.Processors.Model;
using Microsoft.Extensions.Configuration;

namespace Gaeasoft.Magensa.Processors
{
    public class ProcessKeyPadEntryClient : IProcessKeyPadEntryClient
    {
        private IConfiguration _config;
        public Uri Host { get; private set; }
        public string CertificateFileName { get; private set; }
        public string CertificatePassword { get; private set; }
        public ProcessKeyPadEntryClient(IConfiguration config)
        {
            _config = config;
            Host = new Uri(_config.GetValue<string>(Constants.MPPGV4SERVICEURL));
            CertificateFileName = null;
            CertificatePassword = null;
        }
        /// <summary>
        /// ProcessKeyPadEntryResponseDto process the input request and returns the response
        /// </summary>
        /// <param name="processKeyPadEntryRequestDto"></param>
        /// <returns></returns>
        public ProcessKeyPadEntryResponseDto ProcessKeyPadEntry(ProcessKeyPadEntryRequestDto dto)
        {
            var response = new ProcessKeyPadEntryResponseDto();
            string pageContent = string.Empty;
            string soapAction = "http://www.magensa.net/MPPGv4/IMPPGv4Service/ProcessKeyPadEntry";

            try
            {
                string soapBody = $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:mpp=""http://www.magensa.net/MPPGv4/"" xmlns:mpp1=""http://schemas.datacontract.org/2004/07/MPPGv4WS.Core"" xmlns:sys=""http://schemas.datacontract.org/2004/07/System.Collections.Generic"">
  <soapenv:Header/>
  <soapenv:Body>
    <mpp:ProcessKeyPadEntry>
      <mpp:ProcessKeyPadEntryRequests>
        <mpp1:ProcessKeyPadEntryRequest>
          <mpp1:AdditionalRequestData>
            <sys:KeyValuePairOfstringstring>
              <sys:key></sys:key>
              <sys:value></sys:value>
            </sys:KeyValuePairOfstringstring>
          </mpp1:AdditionalRequestData>
          <mpp1:Authentication>
            <mpp1:CustomerCode>{dto.CustomerCode}</mpp1:CustomerCode>
            <mpp1:Password>{dto.Password}</mpp1:Password>
            <mpp1:Username>{dto.Username}</mpp1:Username>
          </mpp1:Authentication>
          <mpp1:CardSwipeInput>            
            <mpp1:EncryptedCardSwipe>
              <mpp1:DeviceSN>{dto.DeviceSN}</mpp1:DeviceSN>
              <mpp1:KSN>{dto.KSN}</mpp1:KSN>
              <mpp1:MagnePrint>{dto.MagnePrint}</mpp1:MagnePrint>
              <mpp1:MagnePrintStatus>{dto.MagnePrintStatus}</mpp1:MagnePrintStatus>
              <mpp1:Track1>{dto.Track1}</mpp1:Track1>
              <mpp1:Track2>{dto.Track2}</mpp1:Track2>
              <mpp1:Track3/>
            </mpp1:EncryptedCardSwipe>          
          </mpp1:CardSwipeInput>
          <mpp1:CustomerTransactionID>{dto.CustomerTransactionID}</mpp1:CustomerTransactionID>
          <mpp1:TransactionInput>
            <mpp1:Amount>{dto.Amount}</mpp1:Amount>
            <mpp1:ClientCertAsBase64String></mpp1:ClientCertAsBase64String>
            <mpp1:ClientCertPassword></mpp1:ClientCertPassword>
            <mpp1:ProcessorName>{dto.ProcessorName}</mpp1:ProcessorName>
            <mpp1:TransactionInputDetails>
              <sys:KeyValuePairOfstringstring>
                <sys:key></sys:key>
                <sys:value></sys:value>
              </sys:KeyValuePairOfstringstring>
            </mpp1:TransactionInputDetails>
            <mpp1:TransactionType>{dto.TransactionType}</mpp1:TransactionType>
          </mpp1:TransactionInput>
        </mpp1:ProcessKeyPadEntryRequest>
      </mpp:ProcessKeyPadEntryRequests>
    </mpp:ProcessKeyPadEntry>
  </soapenv:Body>
</soapenv:Envelope>";

                MagensaSOAPClient soapClient = new MagensaSOAPClient(host: Host, certificateFileName: CertificateFileName, certificatePassword: CertificatePassword);
                HttpWebResponse webResponse = soapClient.CallWebService(soapAction, soapBody);
                Stream responseStream = webResponse.GetResponseStream();
                using (StreamReader sr = new StreamReader(responseStream))
                {
                    response.StatusCode = (int)webResponse.StatusCode;
                    response.PageContent = sr.ReadToEnd();
                }
                responseStream.Close();
                webResponse.Close();
            }
            catch (WebException ex)
            {
                HttpStatusCode sCode = ((HttpWebResponse)ex.Response).StatusCode;
                response.StatusCode = (int)sCode;
                response.PageContent = new StreamReader(ex.Response.GetResponseStream()).ReadToEnd();
            }
            catch (Exception ex)
            {
                response.StatusCode = null;
                response.PageContent = ex.Message;
            }
            return response;
        }
    }
}
