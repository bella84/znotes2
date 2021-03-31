
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager products = new ProductManager();
            while (true)
            {
                Console.Clear();