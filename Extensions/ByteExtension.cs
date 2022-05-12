using HslCommunication;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFGeneral.Extensions
{
    /// <summary>
    /// 扩展方法
    /// </summary>
    public static class ByteExtension
    {



        /// <summary>
        /// 根据偏移获取字节数组 偏移位置的BIT值
        /// 
        /// </summary>
        /// <param name="bytes"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        public static bool GetBit(this byte[] bytes, int offset)
        {
            if (bytes.Length != 2)
            {
                return false;
            }

            if (offset <= 7)
            {
                return bytes[0].GetBoolByIndex(7 - offset);
            }
            else
            {
                return bytes[1].GetBoolByIndex(15 - offset);
            }
        }

        /// <summary>
        /// 查询字符串出现的字数
        /// </summary>
        /// <param name="source"></param>
        /// <param name="search"></param>
        /// <returns></returns>
        public static int GetCount(this string source, string search)
        {
            int count = 0; //计数器
            for (int i = 0; i < source.Length - search.Length; i++)
            {
                if (source.Substring(i, search.Length) == search)
                {
                    count++;
                }
            }
            return count;
        }


        /// <summary>
        /// 将byte[]转成二进制字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetBitString(this byte[] data)
        {
            StringBuilder result = new StringBuilder(data.Length * 8);
            foreach (byte b in data)
            {
                result.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
            }
            return result.ToString();
        }

        /// <summary>
        /// 将byte[]转成字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetString(this byte[] data)
        {
            return System.Text.Encoding.Default.GetString(data);
        }

        /// <summary>
        /// 字符串转成byte,指定byte长度
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] GetBytes(this string data, int len)
        {
            byte[] lst = new byte[len];
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            if (bytes.Length >= len)
            {
                for (int i = 0; i < len; i++)
                {
                    lst[i] = bytes[i];
                }
            }
            else
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    lst[i] = bytes[i];
                }
            }
            return lst;
        }


    }
}
