using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class MyClass
{
    public long Crc { get; private set; }

    public void ValidateCrc(Type formatterType)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            IFormatter bf = (IFormatter)Activator.CreateInstance(formatterType);
            long oldCrc = Crc;

            try
            {
                Crc = 0;
                bf.Serialize(ms, this);
            }
            finally
            {
                Crc = oldCrc;
            }

            if (Crc != ComputeCrc(ms.GetBuffer()))
            {
                throw new InvalidOperationException("The stored CRC does not match the calculated CRC.");
            }
        }
    }

    private long ComputeCrc(byte[] data)
    {
        // 简单的 CRC 计算示例（实际应用中应使用更可靠的 CRC 算法）
        long crc = 0;
        foreach (byte b in data)
        {
            crc += b;
        }
        return crc;
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();
        myObject.ValidateCrc(typeof(BinaryFormatter));
        Console.WriteLine("CRC validation passed.");
    }
}
