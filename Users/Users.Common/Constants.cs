using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Common
{
    public static class Constants
    {
        public static class Passwords
        {
            public const string Letters = "abcdefghijklmnopqrstuvwxyz";
            public const string Numbers = "1234567890";
            public const string Special = "$%#@!*?:^&";
        }
        
        public static class EncryptionKeys
        {
            public static readonly byte[] Key = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
            public static readonly byte[] Iv = { 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16 };
        }
    }
}
