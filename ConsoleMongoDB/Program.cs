// See https://aka.ms/new-console-template for more information
using ConsoleMongoDB;
using MongoDB.Driver;


var cliente = new MongoClient("mongodb+srv://lucaseparila_db_user:5tBRs36wUj3jQmKt@interacaomongo.vumklsf.mongodb.net/"); // conexão com o atlas
//var cliente = new MongoClient("mongodb:// localhost:27017"); // para conectar no docker

var database = cliente.GetDatabase("InterAcaoMongoDb"); // use nomedobanco

var collection = database.GetCollection<User>("Usuarios");

// var usuario = new User("Felipe", "123mudar");

//collection.InsertOne(usuario);

//var usuariosNovos = new List<User>();
//usuariosNovos.Add(new User("Maria", "123mudar"));
//usuariosNovos.Add(new User("Luiz", "123mudar"));
//usuariosNovos.Add(new User("Ana", "123mudar"));
//collection.InsertMany(usuariosNovos);

//var usuarios = collection.Find(x => true).ToList();

//foreach(var usuar in usuarios)
//{
//   Console.WriteLine(usuar);
//   Console.WriteLine("---");
//}

//var usuario = collection.Find(x => x.Login == "Felipe").FirstOrDefault(); // traz a primeira ocorrência encontrada
//var usuario = collection.Find(x => x.Login == "Felipe").ToList(); // traz todas as ocorrências 
//Console.WriteLine(usuario);

//collection.UpdateOne<User>(x => x.Id == "691739cdef79586e8b3f68bf",)


//var usuario = collection.Find(x => x.Id == "691739cdef79586e8b3f68bf").FirstOrDefault();

//Console.WriteLine("Cgegou do banco assim: \n" + usuario);

//Console.WriteLine("########");
//usuario.Password = "456mudar"; // atualização em memoria na aplicação 

//collection.ReplaceOne(x => x.Id == usuario.Id, usuario); // salva no banco a atualização
//var usuario1 = collection.Find(x => x.Id == "691739cdef79586e8b3f68bf").FirstOrDefault();
//Console.WriteLine(usuario1);

var usuario = collection.Find(x => x.Id == "691739cdef79586e8b3f68c0").FirstOrDefault();

Console.WriteLine("Cgegou do banco assim: \n" + usuario);

//var filtro = Builders<User>.Filter.Eq(u => u.Id, "691739cdef79586e8b3f68c0");

//var update = Builders<User>.Update.Set(u => u.Password, "159mudar");

//collection.UpdateOne(filtro, update);


//collection.UpdateOne(
//    x => x.Id == "691739cdef79586e8b3f68c0",
//    Builders<User>.Update.Set(x => x.Password, "100mudar")    atualiza um único campo do objeto
//);

//collection.UpdateOne(
//    x => x.Id == "691739cdef79586e8b3f68c1", 
//    Builders<User>.Update.Set(x => x.Password, "99mudar").Set(x => x.Login, "Ana Clara") // atualiza dois campos do objeto>
//);


//usuario = collection.Find(x => x.Id == "691739cdef79586e8b3f68c1").FirstOrDefault();

//Console.WriteLine( usuario);

//collection.DeleteOne(x => x.Id == "691739cdef79586e8b3f68c0");



// trabalhando com operações assincronas. São utilizadas para não travar a aplicação: mesmo sem reposta, a aplicação continua executando. Quando tiver um retorno, ele processo o retorno. 


//foreach(var  user in await collection.FindAsync(x => x.IsActive == true).Result.ToListAsync())
//{
//    Console.WriteLine(user);
//    Console.WriteLine("---");
//}

List<User> usuariosNovos = new List<User>();
for(int i = 0; i < 15000; i++)
{
    usuariosNovos.Add(new User("Maria", "123mudar"));
    usuariosNovos.Add(new User("Luiz", "123mudar"));
    usuariosNovos.Add(new User("Ana", "123mudar"));
}

collection.InsertMany(usuariosNovos);