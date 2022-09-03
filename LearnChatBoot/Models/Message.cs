using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnChatBoot.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }
    }
}
