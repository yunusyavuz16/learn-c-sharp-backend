namespace Program;

public class FiveStep
{
    public void FiveStep()
    {
        // Five Step
        
        //Partial Dependency:
        // StId - StName is a partial  because there is no connection between courseId and StName where
        // course id is also primary key
        //              PK      PK
        // col names: StId - CourseId - StName
        // rows     :   12       2         Ali
        // rows     :   3       4         Mehmet
        //rows     :    12       4         Ali
        
        //Transitive Dependency:
        // DpId - DpName is a transitive 
        //              PK      
        // col names: StId -    DpId -    DpName
        // rows     :   12       2         Eng
        // rows     :   3       4          Ed
        //rows     :    2       4          Ed
        
        // Independent Dependency
        // StudentId - ComputerName
        // ComputerName does not related to studentId so this is independent
        
        //we want to our db should be 3nd NF
        
        // if there is independent dep then it is unnormal
        // if there is partial then it is 1st normal form
        // if there is transitive it is 2nd normal form
        // if there is no partial independnet and transitive then 3rd normal form
        
    } 
}