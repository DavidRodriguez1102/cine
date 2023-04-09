using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarys
{
    public class Functions
    {
        public Boolean SearchUser(string[] user_returned, string user)
        {
            Boolean user_response = false;
            for (int i = 0; i < user_returned.Length; i++)
            {
                if (user_returned[i] == user)
                {
                    user_response = true;
                }
            }
            return user_response;
        }
        public Boolean SearchPasswrod(string[] pwd_returned, string pwd)
        {
            Boolean pwd_response = false;
            for (int i = 0; i < pwd_returned.Length; i++)
            {
                if (pwd_returned[i] == pwd)
                {
                    pwd_response = true;
                }
            }
            return pwd_response;
        }
        public Boolean SearchDocument(int[] doc_returned, int[] doc_posted)
        {
            Boolean doc_response = false;
            for (int i = 0; i < doc_returned.Length; i++)
            {
                if (doc_posted[i] == doc_returned[i])
                {

                }
            }
            return doc_response;
        }

        public void Opciones()
        {
            Console.Write("\n\t\t 1) Entrar al sistema");
            Console.Write("\n");
            Console.Write("\n\t\t 2) Soporte");
            Console.Write("\n");
            Console.Write("\n\t\t 3) Salir del sistema");
        }
    }
}
