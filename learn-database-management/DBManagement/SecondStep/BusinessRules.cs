namespace Program.SecondStep;

public class BusinessRules
{
    // Second Step: Write the required business rules according to the needs
    private static string bussinessRules = "A student can give zero or only one grade.\r\n" +
                                           "A grade can be given by many students.\r\n\r\n" +
                                           "" +
                                           "A session can have many grades.\r\n" +
                                           "A grade can have one and only one session.\r\n\r\n" +
                                           "" +
                                           "A teacher can create many sessions.\r\n" +
                                           "A session can be created one and only one teacher.\r\n\r\n" +
                                           "" +
                                           "A student can have many sessions.\r\n" +
                                           "A session can have many students.\r\n\r\n" +
                                           "" +
                                           "A student can be related to zero or only one student grade level.\r\n" +
                                           "A student grade level can be related to many grade levels.\r\n" +
                                           "" +
                                           "A student level grade can be related to many courses.\r\n" +
                                           "A course can be related one and only one student grade level." +
                                           " (we assume there is no mass lesson)\r\n\r\n\r\n" +
                                           "" +
                                           "A student can buy many credit packs.\r\n" +
                                           "A credit pack can be bought by many students.\r\n\r\n" +
                                           "" +
                                           "A student can buy many courses.\r\n" +
                                           "A course can be bought many students.\r\n\r\n" +
                                           "" +
                                           "A teacher can give many courses.\r\n" +
                                           "A course can be given by many teachers.\r\n\r\n" +
                                           "" +
                                           "A session can have one and only one course.\r\n" +
                                           "A course can have many sessions.\r\n";

    public static void writeBusinessRules()
    {
        Console.WriteLine(bussinessRules);
    }
}