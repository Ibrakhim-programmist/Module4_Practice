public interface Document
{
    void Open();
}

public class Report : Document
{
    public void Open()
    {
        Console.WriteLine("Открыт отчетик");
    }
}

public class Resume : Document
{
    public void Open()
    {
        Console.WriteLine("Открыто резюмешку");
    }
}

public class Letter : Document
{
    public void Open()
    {
        Console.WriteLine("Открыто письмо");
    }
}

public class Invoice : Document
{
    public void Open()
    {
        Console.WriteLine("Открыт счет (Invoice!)");
    }
}

public abstract class DocumentCreator
{
    public abstract Document CreateDocument();
}

public class ReportCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Report();
    }
}

public class ResumeCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Resume();
    }
}

public class LetterCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Letter();
    }
}

public class InvoiceCreator : DocumentCreator
{
    public override Document CreateDocument()
    {
        return new Invoice();
    }
}
/* В работе реализовал создание различных типов документов с использованием паттерна **Factory Method**. 
 * Создал общий интерфейс `Document`, конкретные классы (Report, Resume, Letter, Invoice) и отдельные классы-создатели для каждого типа.
 * Выбор документа осуществляется динамически через ввод пользователя, после чего объект создаётся через фабричный метод и вызывается его метод `Open()`. 
 * Решение позволяет легко добавлять новые типы документов без изменения существующего кода.
 */
