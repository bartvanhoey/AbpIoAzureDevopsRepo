namespace AbpIoAzureDevops.Blazor
{
  public static class Constants
  {
    public static class Part1
    {
      public const string Title = "Part 1: Create a new GitHub Repository";
      public const string Href = "part1";
      public const string PageIdentifier = "1";
      public const string PrevHref = "";
      public const string NextHref = "part2";
    }

    public static class Part2
    {
      public const string Title = "Part 2: Create a new abp.io application";
      public const string Href = "part2";
      public const string PageIdentifier = "2";
      public const string PrevHref = "part1";
      public const string NextHref = "part3";
    }

    public static class Part3
    {
      public const string Title = "Part 3: Create an SQL Database on Azure and change connection string in appsettings.json files";
      public const string Href = "part3";
      public const string PageIdentifier = "3";
      public const string PrevHref = "part2";
      public const string NextHref = "part4";
    }

    public static class Part4
    {
      public const string Title = "Part 4: Setup the Build pipeline in AzureDevops and publish the Build Artifacts";
      public const string Href = "part4";
      public const string PageIdentifier = "4";
      public const string PrevHref = "part3";
      public const string NextHref = "part5";
    }

    public static class Part5
    {
      public const string Title = "Part 5: Create a Web App in the Azure Portal to deploy [YourAppName].HttpApi.Host project";
      public const string Href = "part5";
      public const string PageIdentifier = "5";
      public const string PrevHref = "part4";
      public const string NextHref = "part6";
    }

    public static class Part6
    {
      public const string Title = "Part 6: Create a Release pipeline in the AzureDevops and deploy [YourAppName].HttpApi.Host project";
      public const string Href = "part6";
      public const string PageIdentifier = "6";
      public const string PrevHref = "part5";
      public const string NextHref = "part7";
    }

    public static class Part7
    {
      public const string Title = "Part 7: Release pipeline finished, Deployment succeeded, but Web App still not working. How to fix the issues?";
      public const string Href = "part7";
      public const string PageIdentifier = "7";
      public const string PrevHref = "part6";
      public const string NextHref = "part8";
    }

    public static class Part8
    {
      public const string Title = "Part 8: Create a Web App in the Azure Portal to deploy [YourAppName].Blazor project";
      public const string Href = "part8";
      public const string PageIdentifier = "8";
      public const string PrevHref = "part7";
      public const string NextHref = "part9";
    }

    public static class Part9
    {
      public const string Title = "Part 9: Create extra Task in the Release pipeline in the AzureDevops to deploy [YourAppName].HttpApi.Blazor project";
      public const string Href = "part9";
      public const string PageIdentifier = "9";
      public const string PrevHref = "part8";
      public const string NextHref = "part10";
    }

  }
}