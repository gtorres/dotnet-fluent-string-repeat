namespace Wizkisoft.DotNet.FluentStringRepeater
{
    public static class StringRepeater
    {
        public static string Repeat(this string @this, int times)
        {
            var result = "";
            for (var i = 0; i < times; i++)
                result += @this;

            return result;
        }
    }
}
