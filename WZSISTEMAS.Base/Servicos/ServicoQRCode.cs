using QRCoder;

namespace WZSISTEMAS.Base.Servicos;

public class ServicoQRCode
{
    public virtual byte[] GerarQRCode(string textoQRCode, int pixels)
    {
        var qRCodeGenerator = new QRCodeGenerator();
        var qRCodeData = qRCodeGenerator.CreateQrCode(textoQRCode, QRCodeGenerator.ECCLevel.Q);

        var qRCode = new BitmapByteQRCode(qRCodeData);

        return qRCode.GetGraphic(pixels);
    }
}
