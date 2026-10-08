using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace WeatherBatchLambda;

public class Function
{

  public void FunctionHandler(object input, ILambdaContext context)
    {
        // 現在時刻と適当な気象データをログに出力
        var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        var temp = new Random().Next(10, 35); // 10℃〜35℃のランダムな値
        
        context.Logger.LogInformation($"[{now}] 定期バッチ実行中 - Temp={temp}°C, Condition=Cloudy");
    }
}


