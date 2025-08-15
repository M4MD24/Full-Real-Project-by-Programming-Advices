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
        public static void deleteImage(
            string path
        ) {
            try {
                File.Delete(
                    path
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

        public static void deleteImageByPersonID(
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

            deleteImage(
                imagePath
            );
        }
    }
}