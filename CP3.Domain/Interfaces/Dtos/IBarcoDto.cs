﻿namespace CP3.Domain.Interfaces.Dtos
{
    public interface IBarcoDto
    {
        int? Id { get; set; }
        string Nome { get; set; }
        int Ano { get; set; }
        string Modelo { get; set; }
        double  Tamanho { get; set; }
        void Validate();
    }
}
