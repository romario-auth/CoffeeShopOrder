﻿using System;

namespace CoffeeShopOrder.Domain.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string message) :base(message) { }
    }
}
