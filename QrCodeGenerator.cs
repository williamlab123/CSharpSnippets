using QRCoder;
using System;
using System.IO;

class QRGenerator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o texto a ser codificado:");
        string inputText = Console.ReadLine();
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
        AsciiQRCode qrCode = new AsciiQRCode(qrCodeData);
        string qrCodeAscii = qrCode.GetGraphic(1);
        Console.WriteLine(qrCodeAscii);

        // Adicionando a funcionalidade de marcar o QR code como lido
        string qrCodeFile = "qrCodeRead.txt";
        if (File.Exists(qrCodeFile))
        {
            using (StreamWriter sw = File.AppendText(qrCodeFile))
            {
                sw.WriteLine(inputText);
            }
        }
        else
        {
            using (StreamWriter sw = File.CreateText(qrCodeFile))
            {
                sw.WriteLine(inputText);
            }
        }
        Console.WriteLine("QR Code marcado como lido!");
    }
}


/*
This code crrates a qrcode in your terminal 
To create the qrcode, you need to download the qrcoder library




*/
