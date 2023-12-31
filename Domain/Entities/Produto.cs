﻿using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
  
    [Table("TB_PRODUTO")]
    public class Produto
    {
      [Column("PRD_ID")]
      [Display(Name = "Código")]
      public int Id { get; set; }

      [Column("PRD_NOME")]
      [Display(Name = "Nome")]
      [MaxLength(255)]
      [Required(ErrorMessage = "O nome do produto é obrigatório.")]
      public string Nome { get; set; }

      [Column("PRD_DESCRICAO")]
      [Display(Name = "Descrição")]
      [MaxLength(150)]
      public string Descricao { get; set; }

      [Column("PRD_OBSERVACAO")]
      [Display(Name = "Observação")]
      [MaxLength(2000)]
      public string Observacao { get; set; }

      [Column("PRD_VALOR")]
      [Display(Name = "Valor")]
      [Range(0.01, double.MaxValue, ErrorMessage = "O valor do produto deve ser maior que zero.")]
      public decimal Valor { get; set; }

      [Column("PRD_QTD_ESTOQUE")]
      [Display(Name = "Quantidade Estoque")]
      [Range(0, int.MaxValue, ErrorMessage = "A quantidade em estoque não pode ser menor que zero.")]
      public int QtdEstoque { get; set; }

      [Display(Name = "Usuário")]
      [ForeignKey("ApplicationUser")]
      [Column(Order = 1)]
      public string UserId { get; set; }
      public virtual ApplicationUser ApplicationUser { get; set; }

      [Column("PRD_ESTADO")]
      [Display(Name = "Estado")]
      public bool Estado { get; set; }

      [Column("PRD_DATA_CADASTRO")]
      [Display(Name = "Data de Cadastro")]
      public DateTime DataCadastro { get; set; }

      [Column("PRD_DATA_ALTERACAO")]
      [Display(Name = "Data de Alteração")]
      public DateTime DataAlteracao { get; set; }

      [NotMapped]
      public int IdProdutoCarrinho { get; set; }

      [NotMapped]
      public int QtdCompra { get; set; }

      [NotMapped]
      public IFormFile Imagem { get; set; }

      [Column("PRD_URL")]
      public string Url { get; set; } = string.Empty;

      [NotMapped]
      public DateTime? DataCompra { get; set; }
    }
}


