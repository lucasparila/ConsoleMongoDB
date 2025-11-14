using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMongoDB
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreateAt { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }

        public User(string login, string password)
        {
            
            Login = login;
            Password = password;
            CreateAt = DateTime.Now;
            UpdateAt = DateTime.Now;
            IsActive = true;
        }

        public override string ToString()
        {
            return $"Id: {this.Id}\n" +
                $"Login: {this.Login}\n" +
                $"Senha: {this.Password}\n" +
                $"Data de Criação: {this.CreateAt}\n" +
                $"Ultima atualização: {this.UpdateAt}\n" +
                $"Ativo: {this.IsActive}";
        }
    }
}