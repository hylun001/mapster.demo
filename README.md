# Mapster.Demo

## 1. 简介
mapster 是一个高性能的对象映射开源库 https://github.com/MapsterMapper/Mapster

## 2. 测试

|         Method |           Job |       Runtime |     Mean |     Error |    StdDev |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|--------------- |-------------- |-------------- |---------:|----------:|----------:|--------:|--------:|------:|----------:|
| AutoMapperTest |    .NET 4.7.2 |    .NET 4.7.2 | 7.154 ms | 0.4475 ms | 1.3124 ms |       - |       - |     - |    864 KB |
|    MapsterTest |    .NET 4.7.2 |    .NET 4.7.2 | 3.494 ms | 0.2248 ms | 0.6557 ms |       - |       - |     - |    280 KB |
| AutoMapperTest | .NET Core 3.1 | .NET Core 3.1 | 4.848 ms | 0.0958 ms | 0.1846 ms | 85.9375 | 23.4375 |     - | 564.77 KB |
|    MapsterTest | .NET Core 3.1 | .NET Core 3.1 | 1.848 ms | 0.0361 ms | 0.0469 ms | 31.2500 |  7.8125 |     - | 194.37 KB |
| AutoMapperTest | .NET Core 5.0 | .NET Core 5.0 | 6.775 ms | 0.4683 ms | 1.3660 ms |       - |       - |     - | 638.55 KB |
|    MapsterTest | .NET Core 5.0 | .NET Core 5.0 | 1.723 ms | 0.0344 ms | 0.0368 ms | 29.2969 |  7.8125 |     - |  184.5 KB |
