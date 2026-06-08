using System;


namespace SucharithaBank.Configuration
{
   /// <summary>
   /// Project level configuration settings
   /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Customernumber starts from 1001;incremented by 1
        /// </summary>
        public static long BaseCustomeNo { get; set; } = 1000;
    }
}
