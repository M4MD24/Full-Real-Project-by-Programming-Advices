using ClientManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace ClientManagementSystem_ClassLibrary_BusinessLayer;

public static class MobileNumbers {
    public static int update(
        ref MobileNumber mobileNumber
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.updateMobileNumberByMobileNumberID(
        ref mobileNumber
    );

    public static int delete(
        ref int? mobileNumberID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.deleteMobileNumberByMobileNumberID(
        ref mobileNumberID
    );

    public static int add(
        ref MobileNumber mobileNumber
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.addNewMobileNumber(
        ref mobileNumber
    );

    public static MobileNumber? get(
        ref int? mobileNumberID
    ) => ClientManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.getMobileNumberByMobileNumberID(
        ref mobileNumberID
    );
}