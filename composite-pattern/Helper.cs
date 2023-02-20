namespace composite_pattern
{
    public static class Helper
    {
        public static string PutSpaceBetweenWords(this string str) => string.Concat(str.Select(x => char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
    }
}