namespace ExemploFechandoArquivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stream entrada = null;
            StreamReader leitor = null;
            try { 
                entrada = File.Open(@"c:\\windows\\temp\\aida.txt", FileMode.Open);
                leitor = new StreamReader(entrada);
                string linhas = leitor.ReadToEnd();
                Console.WriteLine(linhas);
            }
            catch (IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
            finally { 
                if (leitor != null) { leitor.Close(); }
                if (entrada != null) { entrada.Close(); }
            }
        }
    }
}