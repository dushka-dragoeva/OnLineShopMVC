﻿namespace OnLineShop.Common.Constants
{
    public class ValidationConstants
    {
        public const string EnBgSpaceMinus = @"^[a-zA-Zа-яА-Я\s\-]+$";
        public const string EnBgDigitSpaceMinus = @"^[a-zA-Zа-яА-Я0-9\s\-]+$";
        public const string DescriptionRegex = @"^[a-zA-Zа-яА-Я0-9\s\-\.,!():;?/+_%@""'#&=\*]+$";

        // sourse http://stackoverflow.com/questions/8908976/c-sharp-regex-to-validate-phone-number
        public const string PhoneRegex = @"^\+?(\d[\d-. ]+)?(\([\d-. ]+\))?[\d-. ]+\d$";

        // source https://msdn.microsoft.com/en-us/library/01escwtf(v=vs.110).aspx
        public const string EmailRegex = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";

        // source http://stackoverflow.com/questions/5717312/regular-expression-for-url
        public const string UrlRegex = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";

        public const int NameMinLength = 1;
        public const int NameMaxLength = 40;

        public const int DescriptionMinLength = 10;
        public const int DescriptionMaxLength = 500;

        public const int AddressMinLength = 2;
        public const int AddressMaxLength = 100;

        public const int UrlLengthMinLength = 6;
        public const int UrlLengthMaxValue = 300;

        public const int QuantityMinValue = 1;
        public const int QuantitiMaxValue = 10000000;

        public const string PriceMinValue = "0.00";
        public const string PriceMaxValue = "999999999.99";

        public const string ShortUrlError = "Линка към снимката трябва да бъде поне 6 символа";
        public const string LongUrlError = "Линка към снимката може да бъде максимум  символа";

        public const string ShortFieldError = "Полето трябва да бъде поне 1 символа";
        public const string LongFieldError = "Полето може да бъде максимум 40 символа";

        public const string ShortDescriptionError = "Описанието трябва да бъде поне 10 символа";
        public const string LongDescriptionError = "Описанието може да бъде максимум 500 символа";

        public const string NotAllowedSymbolsError = "Полето съдържа неразрешени символи";

        public const string QuаntityOutOfRangeError = "Невалидно количество, диапазон 1 000, 10 0000 000.";
        public const string PriceOutOfRangeError = "Невалиднa cenцена, диапазон 0,01, 999 999 999.99.";





    }
}