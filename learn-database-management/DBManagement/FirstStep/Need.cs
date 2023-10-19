namespace Program.FirstStep;

public class Need
{
    private static string requirements =
        "- Students select their existing grades. \n\n- Teacher creates weekly available sessions \n\n- Students would search sessions.\n\n- Students enroll/attend the sessions.\n\n- Students can grade the session\n\n- Students have credits for courses.\n\n- Students can buy course credit packs.\n\nNote: You can assume rules for any unstated points. ";

    public static void writeRequirements()
    {
        Console.WriteLine(requirements);
    }
}