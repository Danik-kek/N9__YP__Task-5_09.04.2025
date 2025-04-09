namespace N9__YP__Task_5_09._04._2025
{
    internal class Program
    {
        static void Main()
        {
            string Text = "В лесу родилась елочка";
            File.WriteAllText("Text.txt", Text);

            string text = File.ReadAllText("Text.txt").ToLower();
            char[] vowels = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            int vowelCount = 0;

            foreach (char c in text)
            {
                if (Array.Exists(vowels, v => v == c)) vowelCount++;
            }

            Console.WriteLine($"Количество гласных: {vowelCount}");
        }
    }
}
