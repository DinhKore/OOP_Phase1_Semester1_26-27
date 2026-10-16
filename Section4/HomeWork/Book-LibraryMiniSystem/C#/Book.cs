using System;
using System.Collections.Generic;

public class Book
{
    // Private fields
    private string title;
    private string author;
    private string isbn;
    private double price;

    // Properties
    public string Title 
    { 
        get { return title; } 
        set { title = value; } 
    }
    
    public string Author 
    { 
        get { return author; } 
        set { author = value; } 
    }
    
    public string Isbn 
    { 
        get { return isbn; } 
        set { isbn = value; } 
    }
    
    // Property có validation
    public double Price
    {
        get { return price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Giá (Price) không được là số âm.");
            }
            price = value;
        }
    }

    // Constructor
    public Book(string title, string author, string isbn, double price)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        Price = price; // Gọi qua property để kích hoạt validation
    }
}