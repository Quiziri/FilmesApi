﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models;

public class Sessao
{
    [Key]
    [Required]
    public int Id { get; set; }
    [Required]
    public int FilmeId { get; set; }
    public virtual Filme Filme { get; set; }

}
