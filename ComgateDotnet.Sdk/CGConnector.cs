using ComgateDotnet.Sdk.Models;
using RestSharp;
using RestSharp.Serializers;

namespace ComgateDotnet.Sdk;

public class CGConnector
{
    private string ApiPath { get; set; }
    private string MerchantId { get; set; }
    private bool Test { get; set; }

    public CGConnector(string merchantId, bool test)
    {
        ApiPath = "https://payments.comgate.cz/v1.0";
        MerchantId = merchantId;
        Test = test;
    }

    public CreatePaymentResponse CreatePayment(Payment payment)
    {
        var restRequest = CreateRestRequest("create");
        throw new NotImplementedException();
    } 
    
    public PaymentRefundResponse PaymentRefund(Payment payment)
    {
        var restRequest = CreateRestRequest("refund");
        throw new NotImplementedException();
    } 
    
    public PaymentCancelResponse PaymentCancel(Payment payment)
    {
        var restRequest = CreateRestRequest("cancel");
        throw new NotImplementedException();
    }

    public PreauthorizationConfirmationResponse PreauthorizationConfirmation(Payment payment)
    {
        var restRequest = CreateRestRequest("capturePreauth");
        throw new NotImplementedException();
    } 
    
    public PreauthorizationCancelationResponse PreauthorizationCancelation(Payment payment)
    {
        var restRequest = CreateRestRequest("cancelPreauth");
        throw new NotImplementedException();
    }
    
    private static RestRequest CreateRestRequest(string url, Parameter? parameter = null, Method method = Method.Post, string? contentType = ContentType.Json)
    {
        var restRequest = new RestRequest(url, method);
        
        if (parameter != null)
        {
            restRequest.AddParameter(parameter);
        }
        
        restRequest.AddHeader("Accept", "application/json");

        if (contentType != null)
        {
            restRequest.AddHeader("Content-Type", contentType);
        }
        
        return restRequest;
    }
}
