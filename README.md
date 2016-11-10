# Programming Questions
入門向けの簡単な問題を出しています。  
お時間あれば挑戦してみてください。

## 問題一覧
[Part1 Question](https://github.com/mystasly48/ProgrammingQuestion/blob/master/Part1/)  

[Part2 Question](https://github.com/mystasly48/ProgrammingQuestion/blob/master/Part2/)

[Part3 Question](https://github.com/mystasly48/ProgrammingQuestion/blob/master/Part3/)

## 解き方

### Part\#\\Readme.md
問題の内容が書かれています。  
こちらのファイルを見ながら自分なりに解いてみてください。

### Part\#\\Answer.cs
私による C\# における解答例です。  
１つの例としてご参照ください。

### 実行する
問題の通りに自分で入力して実行してみてください。  

### 分からない...
チョコッと解答例を見てみるのも良いかもしれません。  
問題の意味が分からない場合や、答えが合っているか分からない場合などは Issue にてご質問ください。  
例： [Part1 の問題の意味が分かりません · Issue #1](https://github.com/mystasly48/ProgrammingQuestion/issues/1)

## 解けたら...

### あなたの解答をお教えください！
よろしければ `Part#\UsersAnswer\` にて、ファイル名をユーザー名にして PullRequest をしてください！  
*※ 複数の回答を提出する場合にはのユーザー名のあとに数値をつけてください。例：`mystasly48_2.cs`*  
*※ `UsersAnswer` フォルダは存在しない場合があります。最初の方が作っていただきますようお願いします。*  
*※ 過去に全く同じ解き方があった場合は拒否とさせていただきます。少しでも違う処理をしていた場合には承諾いたします。*  

#### 承諾例
```csharp
using System;
public class Program {
  public static void Main() {
    Console.WriteLine("Hello, World!");
  }
}
```
```csharp
public class Program {
  public static void Main() {
    System.Console.Write("Hello, ");
    System.Console.WriteLine("World!");
  }
}
```

#### 拒否例
```csharp
public class Program {
  public static void Main() {
    System.Console.WriteLine("Hello, World!");
  }
}
```
```csharp
public class Program {
  public static void Main() {
    System.Console.WriteLine("Hello, World!"); // 文字列 "Hello, World!" を出力
  }
}
```
