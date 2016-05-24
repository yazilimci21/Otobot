using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Compression;

static class Compression
{
    public static byte[] gZipCompress(byte[] buffer)
    {
        MemoryStream ms = new MemoryStream();
        GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true);
        zip.Write(buffer, 0, buffer.Length);
        zip.Close();
        ms.Position = 0;

        MemoryStream outStream = new MemoryStream();

        byte[] compressed = new byte[ms.Length];
        ms.Read(compressed, 0, compressed.Length);

        byte[] gzBuffer = new byte[compressed.Length + 4];
        Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
        Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
        return gzBuffer;
    }

    public static byte[] gZipDecompress(byte[] gzBuffer)
    {
        MemoryStream ms = new MemoryStream();
        int msgLength = BitConverter.ToInt32(gzBuffer, 0);
        ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

        byte[] buffer = new byte[msgLength];

        ms.Position = 0;
        GZipStream zip = new GZipStream(ms, CompressionMode.Decompress);
        zip.Read(buffer, 0, buffer.Length);

        return buffer;
    }

    public static byte[] Base64(byte[] buffer)
    {
        return Encoding.Default.GetBytes(Convert.ToBase64String(buffer));
    }

    public static string Base64Str(byte[] buffer)
    {
        return Convert.ToBase64String(buffer);
    }

    public static byte[] UnBase64(byte[] buffer)
    {
        return Convert.FromBase64String(Encoding.Default.GetString(buffer));
    }
}