using Newtonsoft.Json.Linq;
using ServiceAlexaMeme.Data;
using ServiceAlexaMeme.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceAlexaMeme.Repositories
{
    public class RepositoryMemes
    {
        MemesContext context;
        Random rand;
        public RepositoryMemes(MemesContext context)
        {
            this.context = context;
            rand = new Random();
        }


        public List<Meme> GetMemes()
        {
            return context.Memes.ToList();
        }
        public Meme GetMeme(int id)
        {
            return context.Memes.SingleOrDefault(x => x.Id == id);
        }
        public String insertMeme(String frase)
        {
            try
            {
                Meme meme = new Meme()
                {
                    Id = GetLastMemeId()+1,
                    Frase = frase
                };
                context.Memes.Add(meme);
                context.SaveChanges();
                return "OK";
            }
            catch(Exception ex)
            {
                return ex.Message + ex.InnerException;
            }
        }
        public int GetLastMemeId()
        {
            return context.Memes.Max(u => (int?)u.Id).Value;
        }
        public String GetRandomMeme()
        {
            List<Meme> memes = GetMemes();

            int meme = rand.Next(1, memes.Count);
            return RandomStartPhrase()+" "+GetMeme(meme).Frase;
            //return rand.Next(1, memes.Count).ToString();
        }
        public String RandomStartPhrase()
        {
            String[] frases = new string[] 
            {
                "Te diré otro: ",
                "Escucha este: ",
                "Mira una cosa:",
                "En serio: ",
                "¿Sabes que?: ",
                "Se acabó: "
            };
            return frases[rand.Next(frases.Length)];
        }
    }
}
