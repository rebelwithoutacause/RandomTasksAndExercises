﻿using System;

namespace PersonInfo;

public class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public Person(string firstName, string lastName, int age)
    {
        if (firstName.Length < 3)
            throw new ArgumentException("First name cannot contain fewer than 3 symbols!");
        if (lastName.Length < 3)
            throw new ArgumentException("Last name cannot contain fewer than 3 symbols!");
        if (age <= 0)
            throw new ArgumentException("Age cannot be zero or a negative integer!");

        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }
    public override string ToString()
    {
        return $"{FirstName} {LastName} is {Age} years old.";
    }
}
