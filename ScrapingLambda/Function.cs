using Amazon.Lambda.CloudWatchEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ScrapingLambda;

public class Function
{
    
    /// <summary>
    /// Scrape data using a cron trigger by Amazon Event Bridge
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public void FunctionHandler(CloudWatchEvent<object> input, ILambdaContext context)
    {
        context.Logger.LogInformation($"Scraping data... Received call at {input.Time}");
        // Add here the scrap call
    }
}
