namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person("Dawid", "Pilarski", new DateTime(2000,01,01),new Address("Poznań","Polna","10a","23-234"));
            Console.WriteLine($"Osoba:\nImie: {person.Name}, Nazwisko: {person.Surname}, Data urodzenia: {person.DataOfBirth.ToString("d")} r.,\nAdres:\nMiasto: {person.Addres.City}, Ulica: {person.Addres.Street}, Numer domu: {person.Addres.HouseNumber}, Kod pocztowy: {person.Addres.PostalCode}. ");
            Student student = new Student("Dawid", "Pilarski", new DateTime(2000, 01, 01), 23);
            Console.WriteLine($"Osoba:\nImie: {student.Name}, Nazwisko: {student.Surname}, Data urodzenia: {student.DataOfBirth.ToString("d")} r., Indeks: {student.StudentNumber}");
            Teacher teacher = new Teacher("Adam", "Nowak", DateTime.Parse("01/01/2000"), new List<string>() {"a","b","c"});
            Console.WriteLine($"Osoba:\nImie: {student.Name}, Nazwisko: {student.Surname}, Data urodzenia: {student.DataOfBirth.ToString("d")} r.,Przemioty: {string.Join(", ", teacher.Subject)} ");
            /*•
             * Aby dodać do zadania menu, które umożliwia dodawanie użytkowników i zapamiętanie ich w pamięci, a następnie odczyt wprowadzonych użytkowników, możesz użyć następujących kroków:
•	Utwórz zmienną typu List<Person>, która będzie przechowywać listę użytkowników.
•	Utwórz metodę DisplayMenu, która będzie wyświetlać opcje menu na konsoli i zwracać wybraną opcję jako liczbę całkowitą.
•	Utwórz metodę AddUser, która będzie pobierać dane użytkownika z konsoli i dodawać je do listy użytkowników.
•	Utwórz metodę DisplayUsers, która będzie wyświetlać dane użytkowników z listy na konsoli.
•	Utwórz metodę Main, która będzie używać pętli while do wyświetlania menu i wykonywania odpowiednich akcji w zależności od wybranej opcji.*/
        }
    }
}