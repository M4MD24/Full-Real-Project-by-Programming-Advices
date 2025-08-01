using AccountManagementSystem_ClassLibrary_DataAccessLayer.Models;

namespace AccountManagementSystem_ClassLibrary_BusinessLayer;

public class Persons {
    public static int update(
        ref Person person
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Persons.updatePersonByPersonID(
        ref person
    );

    public static int delete(
        ref int personID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Persons.deletePersonByPersonID(
        ref personID
    );

    public static int add(
        ref Person person
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Persons.addNewPerson(
        ref person
    );

    public static Person? get(
        ref int personID
    ) => AccountManagementSystem_ClassLibrary_DataAccessLayer.Persons.getPersonByPersonID(
        ref personID
    );
}