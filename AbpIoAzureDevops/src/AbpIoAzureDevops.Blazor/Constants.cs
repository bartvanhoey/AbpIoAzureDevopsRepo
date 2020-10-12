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
      public const string Title = "Part 3: Create an SQL Database on Azure and change ConnectionString in appsettings.json file";
      public const string Href = "part3";
      public const string PageIdentifier = "3";
      public const string PrevHref = "part2";
      public const string NextHref = "part4";
    }
  }
}