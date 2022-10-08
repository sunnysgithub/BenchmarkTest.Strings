using System.Text;
using BenchmarkDotNet.Attributes;

namespace Concatenation;

[MemoryDiagnoser]
public class BenchmarkStringConcatenations
{
    private const int Length = 10000;
    
    [Benchmark]
    public string NormalConcatenationWithChar()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result += 'a';
        }
        return result;
    }
    
    [Benchmark]
    public string NormalConcatenationWithString()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result += "a";
        }
        return result;
    }
    
    [Benchmark]
    public string StringInterpolation()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = $"{result}a";
        }
        return result;
    }
    
    [Benchmark]
    public string StringConcateMethodWithChar()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Concat(result, 'a');
        }
        return result;
    }
    
    [Benchmark]
    public string StringConcateMethodWithString()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Concat(result, "a");
        }
        return result;
    }
    
    [Benchmark]
    public string StringJoinMethodWithChar()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Join(result, 'a');
        }
        return result;
    }
    
    [Benchmark]
    public string StringJoinMethodWithString()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Join(result, "a");
        }
        return result;
    }
    
    [Benchmark]
    public string StringFormatWithChar()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Format("{0}{1}",result, 'a');
        }
        return result;
    }
    
    [Benchmark]
    public string StringFormatWithString()
    {
        var result = "";
        for (int i = 0; i < Length; i++)
        {
            result = string.Format("{0}{1}",result, "a");
        }
        return result;
    }
    
    [Benchmark]
    public string StringBuilder()
    {
        var result = new StringBuilder();
        for (int i = 0; i < Length; i++)
        {
            result.Append("a");
        }
        return result.ToString();
    }
    
    
}