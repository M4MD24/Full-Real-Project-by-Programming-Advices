using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Svg;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

public static class Tools {
    public static Image loadSvgAsImage(
        string svgPath,
        int    width,
        int    height
    ) {
        using FileStream fileStream = File.OpenRead(
            svgPath
        );
        SvgDocument svgDocument = SvgDocument.Open<SvgDocument>(
            fileStream
        );
        svgDocument.Width  = width;
        svgDocument.Height = height;
        Bitmap bitmap = svgDocument.Draw();
        return bitmap;
    }

    public static Image loadEmbeddedSvg(
        string resourceFullName,
        int    width,
        int    height
    ) {
        Assembly assembly = Assembly.GetExecutingAssembly();
        using Stream? stream = assembly.GetManifestResourceStream(
            resourceFullName
        );

        if (stream == null)
            throw new FileNotFoundException(
                $"Resource '{resourceFullName}' not found."
            );

        SvgDocument svgDocument = SvgDocument.Open<SvgDocument>(
            stream
        );
        svgDocument.Width  = width;
        svgDocument.Height = height;
        return svgDocument.Draw();
    }

    public static void disableNewLine(
        KeyEventArgs e
    ) {
        if (e.KeyCode != Keys.Enter)
            return;
        e.SuppressKeyPress = true;
        e.Handled          = true;
    }

    public static class ImageTools {
        public static void deleteImageByNationalNumber(
            ref string? nationalNumber
        ) {
            if (nationalNumber is null)
                return;

            string imageDirectory = Path.Combine(
                Constants.baseDirectory,
                Constants.IMAGE_FOLDER_RELATIVE_PATH
            );

            string? imagePath = null;

            foreach (string extension in Constants.imageExtensions) {
                string possiblePath = Path.Combine(
                    imageDirectory,
                    $"{nationalNumber}.{extension}"
                );

                if (
                    !File.Exists(
                        possiblePath
                    )
                )
                    continue;
                imagePath = possiblePath;
                break;
            }

            if (imagePath is null)
                return;

            deleteImageByImagePath(
                ref imagePath
            );
        }

        public static void deleteImageByImagePath(
            ref string? imagePath
        ) {
            try {
                File.Delete(
                    imagePath!
                );
            } catch (Exception exception) {
                MessageBox.Show(
                    @$"Error deleting image: {exception.Message}",
                    @"Delete Image",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public static string copyImageToImageDirectory(
            ref string? nationalNumber,
            ref string  imagePath
        ) {
            string extension = Path.GetExtension(
                imagePath
            );
            string fileName = $"{nationalNumber}{extension}";

            string destinationFolder = Path.Combine(
                Constants.baseDirectory,
                @"Data\Images"
            );
            if (
                !Directory.Exists(
                    destinationFolder
                )
            )
                Directory.CreateDirectory(
                    destinationFolder
                );

            string destinationFile = Path.Combine(
                destinationFolder,
                fileName
            );

            return copyImage(
                imagePath,
                destinationFile
            );
        }

        private static string copyImage(
            string imagePath,
            string destinationFile
        ) {
            try {
                File.Copy(
                    imagePath,
                    destinationFile,
                    overwrite : true
                );
            } catch (Exception exception) {
                MessageBox.Show(
                    exception.Message,
                    @"Can't Copy to Image Directory",
                    MessageBoxButtons.RetryCancel,
                    MessageBoxIcon.Error
                );
                return null!;
            }

            return destinationFile;
        }
    }
}