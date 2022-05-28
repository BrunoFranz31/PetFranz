using System;
using System.Collections.Generic;

namespace Atividade_3.Models
{
    public class Consulta
    {
        public static List<criarAgendamento>agendamentos;

        static Consulta(){

            agendamentos = new List<criarAgendamento>();
        }

        public void Criar(criarAgendamento agendamento) {

            agendamentos.Add(agendamento);
        }

        public List<criarAgendamento> MostrarLista()
        {
            return agendamentos;
        }
    }
}