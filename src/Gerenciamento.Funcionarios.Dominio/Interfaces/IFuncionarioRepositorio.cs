﻿using Gerenciamento.Funcionarios.Dominio.Entidades;

namespace Gerenciamento.Funcionarios.Dominio.Interfaces;
public interface IFuncionarioRepositorio : IBaseRepositorio<Funcionario>
{
    Task<Funcionario?> FindByCpfAsync(string cpf);
}
