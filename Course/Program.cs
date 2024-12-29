using Course.Entities;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Lesson> lessons = new List<Lesson>();

            Console.Write("Quantas aulas tem o curso? ");
            int quantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantity; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Dados da {i}ª aula: ");
                Console.Write("Conteúdo ou tarefa (c/t)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Título: ");
                string title = Console.ReadLine();

                if (ch == 'c')
                {
                    Console.Write("URL do vídeo: ");
                    string url = Console.ReadLine();
                    Console.Write("Duraçao em segundos: ");
                    int duration = int.Parse(Console.ReadLine());
                    lessons.Add(new Video(title, url, duration));
                }
                else
                {
                    Console.Write("Descrição: ");
                    string description = Console.ReadLine();
                    Console.Write("Quantidade de questão: ");
                    int questionCount = int.Parse(Console.ReadLine());
                    lessons.Add(new Entities.Task(title, description, questionCount));
                }
            }

            
            double total = 0.0;

            foreach (Lesson lesson in lessons)
            {
                total += lesson.Duration();
            }

            Console.WriteLine();
            Console.WriteLine($"DURAÇÃO TOTAL DO CURSO = {total} segundos");
        }
    }
}
