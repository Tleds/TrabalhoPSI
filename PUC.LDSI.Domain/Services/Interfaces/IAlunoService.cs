﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Services.Interfaces
{
    public interface IAlunoService
    {
        Task<int> IncluirNovoAlunoAsync(string nome, string matricula);
    }
}
