﻿using Gerenciamento.Funcionarios.Dominio.Entidades;

namespace Gerenciamento.Funcionarios.Dominio.Interfaces;
public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
{
    Task<Usuario?> FindByEmailAsync(string email);
}
