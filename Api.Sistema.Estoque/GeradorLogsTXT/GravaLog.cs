using System;
using System.IO;
using System.Net;

namespace GeradorLogsTXT
{
    public class GravaLog
    {
        /// <summary>
        /// Metodo que grava logs de execuções da api
        /// </summary>
        /// <param name="textoLog"></param>
        public void GravaLogs(string textoLog)
        {
            using StreamWriter output = new StreamWriter(@"C:\Users\ADM\Documents\LogsSistemaEstoque\LogSistemaEstoque.txt", true);
            
            string data = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            string pc = Dns.GetHostName();

            output.WriteLine(data + " " + hora + " (" + pc + ") " + textoLog);
        }
    }
}
