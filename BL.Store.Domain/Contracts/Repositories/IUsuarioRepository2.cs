﻿using BL.Store.Domain.Entities;

namespace BL.Store.Domain.Contracts.Repositories
{
    public interface IUsuarioRepository2
    {
        Usuario Get(string email);
    }
}