using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnChatBoot.Models
{
    public class UserMessage
    {
        public UserMessage()
        {
            Mensagens = new List<Message>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { get; set; }

        public int IdMessage { get; set; }
        public List<Message> Mensagens { get; set; }
    }
}
