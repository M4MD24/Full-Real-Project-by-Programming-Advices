using System;

namespace ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

public static class Constants {
    public static readonly string[] imageExtensions = [
        "jpg",
        "jpeg",
        "png"
    ];
    public static readonly string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
    public const string RESOURCES_ICONS_PATH       = "ClientManagementSystem_WindowsFormsApplication_PresentationLayer.Resources.Icons",
                        IMAGE_FOLDER_RELATIVE_PATH = "Data\\Images";
    private const byte TARGET_AGE = 5;

    public static class ErrorMessages {
        public const string EMPTY      = "Is Empty",
                            NOT_UNIQUE = "Isn't Unique",
                            NOT_EXIST  = "Not Found",
                            PASSWORD_WRONG   = "Password is Wrong";
        public static readonly string lessThanTargetAge = $"Less Than {TARGET_AGE}";
    }
}