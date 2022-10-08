# String Concatenation Benchmark Test

A simple benchmark test to compare the different methods to concatenate strings.

## Run
Run benchmark by your own
```
    $ dotnet run -p Concatenation.csproj -c Release
```

## Results

|                        Method |         Mean |      Error |     StdDev |       Gen0 |   Allocated |
|------------------------------ |-------------:|-----------:|-----------:|-----------:|------------:|
|                 StringBuilder |     50.09 us |   0.260 us |   0.217 us |    25.2686 |    51.95 KB |
|    StringJoinMethodWithString |    138.48 us |   0.528 us |   0.468 us |   152.8320 |    312.5 KB |
|      StringJoinMethodWithChar |    295.97 us |   5.357 us |   5.011 us |   382.3242 |   781.25 KB |
| NormalConcatenationWithString |  9,910.00 us | 102.943 us |  85.962 us | 47750.0000 | 97910.15 KB |
|           StringInterpolation | 10,256.77 us | 205.007 us | 191.763 us | 47750.0000 | 97910.15 KB |
| StringConcateMethodWithString | 10,289.10 us | 131.544 us | 123.047 us | 47750.0000 | 97910.15 KB |
|   NormalConcatenationWithChar | 10,325.13 us | 201.892 us | 247.942 us | 47750.0000 | 97910.15 KB |
|   StringConcateMethodWithChar | 11,009.40 us | 194.274 us | 181.724 us | 48031.2500 |  98378.9 KB |
|        StringFormatWithString | 13,890.64 us | 220.318 us | 206.086 us | 47750.0000 | 97911.16 KB |
|          StringFormatWithChar | 14,686.59 us | 235.707 us | 220.481 us | 47953.1250 | 98145.66 KB |

## Lesson Learned

Always use StringBuilder!