﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBiblioteca
{
    internal interface IPodeSerEmprestado
    {
        void Emprestar();
        void Devolver(DateTime devolucao);
    }
}
