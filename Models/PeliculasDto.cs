﻿namespace GeneroInfo.API.Models
{
    public class PeliculasDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
    }
}