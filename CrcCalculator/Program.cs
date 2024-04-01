using System;
using System.Text;

public class CRCCalculator
{
    // CRC多项式，这里使用CRC-32的标准多项式
    private const uint Polynomial = 0xEDB88320u;

    // CRC表，用于加速计算
    private static readonly uint[] CRCTable = new uint[256];

    // 初始化CRC表
    static CRCCalculator()
    {
        for (uint i = 0; i < 256; i++)
        {
            uint crc = i;
            for (int j = 8; j > 0; j--)
            {
                if ((crc & 1) == 1)
                {
                    crc = (crc >> 1) ^ Polynomial;
                }
                else
                {
                    crc >>= 1;
                }
            }
            CRCTable[i] = crc;
        }
    }

    // 计算数据的CRC校验值
    public static uint CalculateCRC(byte[] data)
    {
        uint crc = 0xFFFFFFFFu;
        foreach (byte b in data)
        {
            byte index = (byte)(((crc) & 0xFF) ^ b);
            crc = (crc >> 8) ^ CRCTable[index];
        }
        return ~crc;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string input = "Hello, CRC!";
        byte[] data = Encoding.ASCII.GetBytes(input);
        uint crcValue = CRCCalculator.CalculateCRC(data);
        Console.WriteLine("CRC value: " + crcValue.ToString("X"));
    }
}