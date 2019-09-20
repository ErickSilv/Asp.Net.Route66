using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace AppRoute66.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Categoria{ get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasAsNoticias()
        {
            var retorno = new Collection<Noticia>
            {
             new Noticia
             {
                 NoticiaId=1,
                 Categoria="Esportes",
                 Titulo="O Time da escola ganha dos catados",
                 Conteudo="O time da escola vence de 10X2 de time montado com os alunos sem time",
                 Data=new DateTime(22/03/2019)

             },
              new Noticia
             {
                 NoticiaId=2,
                 Categoria="Esportes",
                 Titulo="Ônibus da seleção masculina preso em blitz",
                 Conteudo="O ônibus da seleção foi parado pelo blitz por alguns motivos: sem volante, sem lateral, " +
                 " Grandes problemas na frente. E ainda transportando todos tipos de drogas, menos crack.",
                 Data=new DateTime(15/02/2019)
             },

                new Noticia
             {
             NoticiaId=3,
                 Categoria="Escola",
                 Titulo="Custo da Escola",
                 Conteudo="Pai vai reclamar do boleto de pagamento de Joãzinho." +
                 "Se ele é o que menos estuda na turma, a mensalidade tem que ser menor!",
                 Data=new DateTime(02/03/2019)
            },
                new Noticia
                {
                 NoticiaId=4,
                 Categoria="Escola",
                 Titulo="Diário de um Nerd",
                 Conteudo="Querido diário estou tão feliz..."  + 
                 "Fiz o meu primeiro Hellow word!!!",
                 
                 Data=new DateTime(15/02/2019)
                }
            };

            return retorno;
        }

    }
}