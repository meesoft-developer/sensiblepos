using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiblePOS.Utilities
{
    public static class PromptPayTools
    {
        const string ID_PAYLOAD_FORMAT = "00";
        const string ID_POI_METHOD = "01";
        const string ID_MERCHANT_INFORMATION_BOT = "29";
        const string ID_TRANSACTION_CURRENCY = "53";
        const string ID_TRANSACTION_AMOUNT = "54";
        const string ID_COUNTRY_CODE = "58";
        const string ID_CRC = "63";
        const string PAYLOAD_FORMAT_EMV_QRCPS_MERCHANT_PRESENTED_MODE = "01";
        const string POI_METHOD_STATIC = "11";
        const string POI_METHOD_DYNAMIC = "12";
        const string MERCHANT_INFORMATION_TEMPLATE_ID_GUID = "00";
        const string BOT_ID_MERCHANT_PHONE_NUMBER = "01";
        const string BOT_ID_MERCHANT_TAX_ID = "02";
        const string GUID_PROMPTPAY = "A000000677010111";
        const string TRANSACTION_CURRENCY_THB = "764";
        const string COUNTRY_CODE_TH = "TH";
        public static string GetString(string promptpayId, decimal amount)
        {
            string amountString = "";
            if (amount > 0) amountString = string.Format("{0:##.00}", amount);

            var POI_METHOD = amount > 0 ? POI_METHOD_DYNAMIC : POI_METHOD_STATIC;

            var TARGET_TYPE = promptpayId.Length >= 13
                ? BOT_ID_MERCHANT_TAX_ID
                : BOT_ID_MERCHANT_PHONE_NUMBER;

            promptpayId = TARGET_TYPE == BOT_ID_MERCHANT_PHONE_NUMBER ? $"0066{promptpayId.Substring(1)}" : promptpayId;
            var builder = new StringBuilder();
            builder.Append(ID_PAYLOAD_FORMAT)
                .Append(len(PAYLOAD_FORMAT_EMV_QRCPS_MERCHANT_PRESENTED_MODE))
                .Append(PAYLOAD_FORMAT_EMV_QRCPS_MERCHANT_PRESENTED_MODE)
                .Append(ID_POI_METHOD)
                .Append(len(POI_METHOD))
                .Append(POI_METHOD)
                .Append(ID_MERCHANT_INFORMATION_BOT)
                .Append("37")
                .Append(MERCHANT_INFORMATION_TEMPLATE_ID_GUID)
                .Append(len(GUID_PROMPTPAY))
                .Append(GUID_PROMPTPAY)
                .Append(TARGET_TYPE)
                .Append(len(promptpayId))
                .Append(promptpayId)
                .Append(ID_COUNTRY_CODE)
                .Append(len(COUNTRY_CODE_TH))
                .Append(COUNTRY_CODE_TH)
                .Append(ID_TRANSACTION_CURRENCY)
                .Append(len(TRANSACTION_CURRENCY_THB))
                .Append(TRANSACTION_CURRENCY_THB)
                .Append(amount > 0 ? ID_TRANSACTION_AMOUNT : "")
                .Append(amount > 0 ? len(amountString) : "")
                .Append(amount > 0 ? amountString : "")
                .Append(ID_CRC)
                .Append("04"); 

            var payload = builder.ToString().Select(x => Convert.ToByte(x)).ToArray();
            var crc = new CRC16().ComputeCheckSum(payload);

            builder.Append(crc.ToString("X").PadLeft(4, '0'));
            return builder.ToString();
        }

        static string len(string str)
        {
            return str.Length.ToString().PadLeft(2, '0');
        }

        class CRC16
        {
            private const ushort polynomial = 0x1021;
            private readonly ushort initialValue = 0xffff;
            private readonly ushort[] table = new ushort[256];

            public CRC16()
            {
                ushort temp, a;
                for (var i = 0; i < table.Length; i++)
                {
                    temp = 0;
                    a = (ushort)(i << 8);
                    for (var j = 0; j < 8; j++)
                    {
                        if (((temp ^ a) & 0x8000) != 0)
                            temp = (ushort)((temp << 1) ^ polynomial);
                        else
                            temp <<= 1;
                        a <<= 1;
                    }
                    table[i] = temp;
                }
            }

            public ushort ComputeCheckSum(byte[] bytes)
            {
                var crc = initialValue;
                for (var i = 0; i < bytes.Length; i++)
                    crc = (ushort)((crc << 8) ^ table[(crc >> 8) ^ (0xff & bytes[i])]);
                return crc;
            }

            public byte[] ComputeChecksumBytes(byte[] bytes)
            {
                var crc = ComputeCheckSum(bytes);
                return new[] { (byte)(crc >> 8), (byte)(crc & 0x00ff) };
            }
        }
    } 
}
