﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stracciatella
{
    class Decoder
    {
        public static string Base64Decode(string input)
        {
            byte[] data = System.Convert.FromBase64String(input);
            string output = System.Text.ASCIIEncoding.ASCII.GetString(data);

            return output;
        }

        public static byte[] Base64DecodeBinary(string input)
        {
            return System.Convert.FromBase64String(input);
        }

        public static string XorDecode(byte[] input, int key)
        {
            StringBuilder outsb = new StringBuilder(input.Length);
            char ch;

            for (int i = 0; i < input.Length; i++)
            {
                ch = (char)(input[i] ^ key);
                outsb.Append(ch);
            }
            return outsb.ToString();
        }

        public static string XorDecode(string input, int key)
        {
            StringBuilder insb = new StringBuilder(input);
            StringBuilder outsb = new StringBuilder(input.Length);
            char ch;

            for (int i = 0; i < input.Length; i++)
            {
                ch = (char)(insb[i] ^ key);
                outsb.Append(ch);
            }
            return outsb.ToString();
        }
    }
}
