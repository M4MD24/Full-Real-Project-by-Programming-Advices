using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Svg;

namespace AccountManagementSystem_WindowsFormsApplication_PresentationLayer.Utilities;

public class Tools {
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
}