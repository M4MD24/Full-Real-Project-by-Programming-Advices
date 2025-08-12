using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class MobileNumbers {
    public static int update(
        ref MobileNumber mobileNumber
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.updateMobileNumberByMobileNumberID(
        ref mobileNumber
    );

    public static int delete(
        ref int? mobileNumberID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.deleteMobileNumberByMobileNumberID(
        ref mobileNumberID
    );

    public static int add(
        ref MobileNumber mobileNumber
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.addNewMobileNumber(
        ref mobileNumber
    );

    public static MobileNumber? get(
        ref int mobileNumberID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.MobileNumbers.getMobileNumberByMobileNumberID(
        ref mobileNumberID
    );
}