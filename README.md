# Fluent URI

Create URI's quickly and easily in a fluent way

``` c#
Uri.Create("baseuri", true)
    .AddSection("testsection")
    .AddParameter("param", "value")
    .AddParameter("param2", "value2")
    .AddFragment("frag")
    .AsString();
```

``` c#
Uri.Create("baseuri", true)
    .AddSection("testsection")
    .AddParameter("param", "value")
    .AddParameter("param2", "value2")
    .AddFragment("frag")
    .AsUri();
```
            https://baseuri/testsection?param=value&param2=value2#frag
