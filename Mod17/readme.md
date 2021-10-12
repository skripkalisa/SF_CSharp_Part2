## Задание

# Практика

В исходниках банковского приложения вы нашли следующий код:
```cs
public class Account
{
   // тип учетной записи
   public string Type { get; set; }
  
   // баланс учетной записи
   public double Balance { get; set; }
  
   // процентная ставка
   public double Interest { get; set; }
}

public static class Calculator 
{ 
   // Метод для расчета процентной ставки
   public static void CalculateInterest(Account account) 
   { 
       if (account.Type == "Обычный") 
       { 
           // расчет процентной ставки обычного аккаунта по правилам банка
               account.Interest = account.Balance * 0.4;
 
               if (account.Balance < 1000)
                   account.Interest -= account.Balance * 0.2;
              
               if (account.Balance < 50000)
                   account.Interest -= account.Balance * 0.4;
       } 
       else if(account.Type == "Зарплатный") 
       { 
           // расчет процентной ставк зарплатного аккаунта по правилам банка
           account.Interest = account.Balance * 0.5;
       } 
   }
} 
```

Напишите свой вариант рефакторинга кода из задания 4 в соответствии с Принципом открытости-закрытости.

## [Решение](./Task)

## Скриншот

![Screenshot](Task.png)
