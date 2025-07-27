namespace AccountManagementSystem.Models;

public class FullName {
    public int    fullNameID { get; set; }
    public string firstName  { get; set; }
    public string secondName { get; set; }
    public string thirdName  { get; set; }
    public string fourthName { get; set; }

    public FullName(
        int    fullNameID,
        string firstName,
        string secondName,
        string thirdName,
        string fourthName
    ) {
        this.fullNameID = fullNameID;
        this.firstName  = firstName;
        this.secondName = secondName;
        this.thirdName  = thirdName;
        this.fourthName = fourthName;
    }

    public FullName(
        string firstName,
        string secondName,
        string thirdName,
        string fourthName
    ) {
        this.firstName  = firstName;
        this.secondName = secondName;
        this.thirdName  = thirdName;
        this.fourthName = fourthName;
    }
}