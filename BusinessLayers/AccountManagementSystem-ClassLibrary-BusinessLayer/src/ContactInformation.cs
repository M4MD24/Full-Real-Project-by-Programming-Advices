namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class ContactInformation {
    public static int update(
        ref AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.updateContactInformationByContactInformationID(
        ref contactInformation
    );

    public static int delete(
        ref int contactInformationID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.deleteContactInformationByContactInformationID(
        ref contactInformationID
    );

    public static int add(
        ref AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.addNewContactInformation(
        ref contactInformation
    );

    public static AccountManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation? get(
        ref int contactInformationID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.getContactInformationByContactInformationID(
        ref contactInformationID
    );
}