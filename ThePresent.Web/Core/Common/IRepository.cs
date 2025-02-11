﻿namespace ThePresent.Web.Core.Common
{
    public interface IRepository
    {
        void Attach<T>(T item) where T : class;

        void Add<T>(T item) where T : class;

        void Update<T>(T item) where T : class;

        void Remove<T>(T item) where T : class;

    }
}