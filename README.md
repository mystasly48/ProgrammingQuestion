# Programming Questions
入門向けの簡単な問題を出しています。  
お時間あれば挑戦してみてください。

## 解き方

### Part\#_Question.txt
問題の内容が書かれています。  
こちらのファイルを見ながら自分なりに解いてみてください。

### Part\#_Answer.cs
私による C\# における解答例です。  
私も初級から中級の中間レベルですので、完璧な解答ではありません。  
１つの例としてご参照ください。

### 実行する
問題の通りに自分で入力して実行してみてください。  

### 分からない...
チョコッと解答例を見てみるのも良いかもしれません。
問題の意味が分からない場合や、答えが合っているか分からない場合などは Issue にてご質問ください。  
例： [Part1 の問題の意味が分かりません · Issue #1](https://github.com/mystasly48/ProgrammingQuestion/issues/1)

## 解けたら...

### あなたの解答をお教えください！
よろしければ PullRequest にて、ファイル名を `Part#_Answer_#.cs` のようにしてお送りください！  
*※過去に全く同じ解き方があった場合は拒否とさせていただきます。少しでも違う処理をしていた場合には承諾いたします。*  

#### 承諾例
```csharp
using System;
public class Main {
  public static void main(string[] args) {
    Console.WriteLine("Hello, World!");
  }
}
```
```csharp
public class Main {
  public static void main(string[] args) {
    System.Console.Write("Hello, ");
    System.Console.WriteLine("World!");
  }
}
```