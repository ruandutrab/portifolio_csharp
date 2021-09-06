using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portifolio_CSharp
{
    static class Extender
    {
        public static string diretorioPrincipal = System.Environment.CurrentDirectory;
        public static string NomeDataBase = "db_jogos.db";
        public static string diretorioDb = diretorioPrincipal + @"\db\";
        private static string directoryQuizPath = diretorioPrincipal + @"\Quiz";
        public static string fileQuizPath = directoryQuizPath + @"\quiz.txt";
        public static string directoryUsersPath = diretorioPrincipal + @"\Users";
        public static string fileUsersPath = directoryUsersPath + @"\Users.txt";


        public static List<Pergunta> LeituraDasPerguntas()
        {
            try
            {
                if (Directory.Exists(directoryQuizPath))
                {
                    return Centralizar(fileQuizPath);
                }
                else
                {
                    Directory.CreateDirectory(directoryQuizPath);
                    return Centralizar(fileQuizPath);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private static List<Pergunta> Centralizar(string fileQuizPath)
        {
            if (File.Exists(fileQuizPath))
            {
                string textQuiz = File.ReadAllText(fileQuizPath, Encoding.UTF8);
                List<Pergunta> perguntas = new List<Pergunta>();
                perguntas = JsonConvert.DeserializeObject<List<Pergunta>>(textQuiz);
                return perguntas;
            } 
            else
            {
                File.CreateText(fileQuizPath);
                return null;
            }
        }

        public static void EscrevePerguntas(List<Pergunta> perguntas)
        {
            try
            {
                if (Directory.Exists(directoryQuizPath))
                {
                    if (File.Exists(fileQuizPath))
                    {
                        string textQuiz = JsonConvert.SerializeObject(perguntas);
                        File.WriteAllText(fileQuizPath, textQuiz);
                    }
                    else
                    {
                        File.CreateText(fileQuizPath);
                        string textQuiz = JsonConvert.SerializeObject(perguntas);
                        File.WriteAllText(fileQuizPath, textQuiz);
                    }
                }
                else
                {
                    Directory.CreateDirectory(directoryQuizPath);
                    if (File.Exists(fileQuizPath))
                    {
                        string textQuiz = JsonConvert.SerializeObject(perguntas);
                        File.Exists(fileQuizPath);
                    }
                    else
                    {
                        File.CreateText(fileQuizPath);
                        string textQuiz = JsonConvert.SerializeObject(perguntas);
                        File.WriteAllText(fileQuizPath, textQuiz);
                    }
                }
                
            }
            catch (Exception ex)
            {
            }
        }

        public static List<Users> SearchUsers() // Busca por novos usuários.
        {
            List<Users> users = null; 
            if (Directory.Exists(directoryUsersPath))
            {
                if (File.Exists(fileUsersPath))
                {
                    users = new List<Users>();
                    string textUsers = File.ReadAllText(fileUsersPath, Encoding.UTF8);
                    users = JsonConvert.DeserializeObject<List<Users>>(textUsers);
                }
                else
                {
                    Directory.CreateDirectory(directoryUsersPath);
                    File.CreateText(fileUsersPath);
                }
            }
            return users;

        }

        public static void WriteUsers(List<Users> users)
        {
            if (Directory.Exists(directoryUsersPath))
            {
                if (File.Exists(fileUsersPath))
                {
                    string textUsers = JsonConvert.SerializeObject(users);
                    File.WriteAllText(fileUsersPath, textUsers);
                }
                else
                {
                    File.CreateText(fileUsersPath);
                    string textUsers = JsonConvert.SerializeObject(users);
                    File.WriteAllText(fileUsersPath, textUsers);
                }
            }
            else
            {
                Directory.CreateDirectory(directoryUsersPath);
                if (File.Exists(fileUsersPath))
                {
                    string textUsers = JsonConvert.SerializeObject(users);
                    File.WriteAllText(fileUsersPath, textUsers);
                }
                else
                {
                    File.CreateText(fileUsersPath);
                    string textUsers = JsonConvert.SerializeObject(users);
                    File.WriteAllText(fileUsersPath, textUsers);
                }
            }
        }
    }

}
