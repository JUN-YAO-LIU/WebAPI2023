Asp.Net Core
==============
###### version：8

---

## Asp.net Core比較Asp.net
||Asp.net Core|Asp.net|
|:-|:-|:-|
|建置|Windows macOS Linux|Windows建置|
|Library|.NET|.NET Framework|
|相依性注入|內建DI|需安裝Nuget才可以做|
|環境|||
|參數檔|||

## 啟動

## Asp.net Core核心角色
1. 
2. 
3. 

### Host
以前的版本寫法是這樣，會有main這個方法程式進入點。
呼叫CreateWebHostBuilder，裡面主要做
<pre style="background:#ededec;color:black;">
public class Program
{
    public static void Main(string[] args)
    {
        CreateWebHostBuilder(args).Build().Run();
    }

    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
}
</pre>


ref：
https://learn.microsoft.com/zh-tw/aspnet/core/fundamentals/host/web-host?view=aspnetcore-7.0
https://www.cnblogs.com/xiaoxiaotank/p/15273093.html

![測試圖示]()