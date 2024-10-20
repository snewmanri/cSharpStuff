for (int i = 1; i < 101; i++){
Console.Write(i);
string tempStr = "";
  
if (i % 3 == 0 ){
    tempStr ="Fizz";
}
  
if (i % 5 == 0){
   tempStr = tempStr + "Buzz";
}

if (tempStr.Length > 0)
Console.Write($" - {tempStr}");

Console.WriteLine("");
}
