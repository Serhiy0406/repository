using System;
using System.Collections.Generic;
using System.Text;

namespace task_2
{
    class Book
    {
        private string author;
        private string title;
        private double price;
        public virtual string Author 
        {
            get { return author; }
            set
            {
                string[] s = value.Split(' ');
                if (Char.IsDigit(s[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                else { author = value; }  
            }
        }
        public virtual string Title
        {
            get { return title; }
            set
            {
                if (value.Length<=3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else { title = value; }
            }
        }
        public virtual double Price
        {
            get { return price; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Title not valid!");
                }
                else { price = value; }
            }
        }
        public Book(string author, string title, double price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:f2}");
            string result = resultBuilder.ToString().TrimEnd();
            return result;
        }
    }
}
