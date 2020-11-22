
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTrackingProject
{
    public class BaseManager<T> : IBaseManager<T> where T : IEntity
    {
        protected List<T> entities;
        public BaseManager()
        {
            entities = new List<T>();
        }
        public void Add(T entity)
        {