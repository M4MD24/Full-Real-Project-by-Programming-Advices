namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class ContactInformation {
    public static int update(
        ref ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.updateContactInformationByContactInformationID(
        ref contactInformation
    );

    public static int delete(
        ref int? contactInformationID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.deleteContactInformationByContactInformationID(
        ref contactInformationID
    );

    public static int add(
        ref ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation contactInformation
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.addNewContactInformation(
        ref contactInformation
    );

    public static ClientManagementSystem_ClassLibrary_DataAccessLayer.Models.ContactInformation? get(
        ref int? contactInformationID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.ContactInformation.getContactInformationByContactInformationID(
        ref contactInformationID
    );
}