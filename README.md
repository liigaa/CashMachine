# CashMachine

Interfaces ICashMachine implementation with MSTest tests. 

Cash machine accepts/withdraws only 5, 10, 20, 50, 100 banknotes.

public interface ICashMachine  
{  
      int Withdraw(int amount);  
      void Insert(int[] cash);  
} 
