using System;

namespace Atividade_3.Models
{
    public static class Dados{
    
     public static Consulta AgendaAtual { get; set;}
      static Dados()
      {
          AgendaAtual = new Consulta();
      }
    }
}
    
        