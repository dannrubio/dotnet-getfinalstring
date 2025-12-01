public class StringProcessor
{
    private readonly string _target;

    public StringProcessor(string targetString)
    {
        _target = targetString;
    }

    public string GetFinalString(string source)
    {
        int index = source.IndexOf(_target, StringComparison.Ordinal);
        if (index == -1)
            return source.Length > 0 ? source : "-1";

        string newString = source.Remove(index, _target.Length);

        if (newString.Length == 0)
            return "-1";

        return GetFinalString(newString);
    }
}