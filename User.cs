﻿namespace Project;

public class User
{
    public string Name { get; set; }
    public int Balance { get; set; }

    public User(string name)
    {
        Name = name;
        Balance = 0;
    }

    public void AddToBalance(int value)
    {
        Balance += value;
    }

    public void SubtractFromBalance(int value)
    {
        Balance -= value;
    }
}
