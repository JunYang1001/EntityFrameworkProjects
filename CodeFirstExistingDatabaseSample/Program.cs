﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDatabaseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var bloggingContext = new BloggingContext())
            {
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();
                var blog = new Blog()
                {
                    Name = name
                };
                bloggingContext.Blogs.Add(blog);
                bloggingContext.SaveChanges();

                var query = from b in bloggingContext.Blogs
                            orderby b.Name
                            select b;
                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
