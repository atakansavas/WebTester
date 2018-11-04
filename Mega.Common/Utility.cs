using System;
using System.Collections.Generic;
using System.Text;

namespace Mega.Common
{
    public static class Utility
    {
        /// <summary>
        /// Encodes given text
        /// </summary>
        /// <param name="veri"></param>
        /// <returns></returns>
        static public string TextEncode(this string veri)
        {
            // gelen veri byte dizisine aktarılıyor
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            // base64 şifreleme algoritmasına göre şifreleniyor.
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return sifrelenmisVeri;
        }

        /// <summary>
        /// Decodes given text
        /// </summary>
        /// <param name="cozVeri"></param>
        /// <returns></returns>
        static public string TextDecode(this string cozVeri)
        {
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }
    }
}
