# HW-7

# Short Strings benchmarks :

|        Method |      Mean |     Error |    StdDev |    Median |
|-------------- |----------:|----------:|----------:|----------:|
|  PlusOperator | 15.874 us | 0.3445 us | 0.9773 us | 15.534 us |
| StringBuilder |  1.645 us | 0.0329 us | 0.0969 us |  1.598 us |
|    StringJoin |  1.599 us | 0.0284 us | 0.0618 us |  1.581 us |
|  StringConcat |  1.046 us | 0.0179 us | 0.0167 us |  1.051 us |

# Long Strings benchmarks : 

|        Method |       Mean |     Error |    StdDev |
|-------------- |-----------:|----------:|----------:|
|  PlusOperator | 8,930.8 us | 118.95 us | 136.99 us |
| StringBuilder |   353.0 us |   9.91 us |  28.44 us |
|    StringJoin |   125.9 us |   2.52 us |   4.97 us |
|  StringConcat |   125.9 us |   2.24 us |   5.98 us |

# Висновок 
якщо виконувати конкатенацію рядків у циклі або якщо конкатенувати велику кількість рядків, найкраще використовувати StringBuilder, щоб уникнути проблем із продуктивністю та пам’яттю.