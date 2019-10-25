using System.Windows.Forms;
using System.Net.Mail;
using System.Diagnostics;

/// <summary>
/// Author: Jefferson Saul G. Motta
/// 10-24-2019 20:50
/// Uses the System
/// </summary>
namespace System
{

    /// <summary>  
    /// This is my real code that I make to debug easly
    /// You can copy to .NET Core as Well
    /// If you are debugging in a local IIS (ASP.NET WebForms)
    /// The popup will raises too
    /// C# 7.3 and C# 8.0
    /// About extensions: http://www.c-sharpcorner.com/blogs/extension-method-in-c-sharp3
    /// </summary>
    public static class ExtensionMethodStrings
    {

        
        /// <summary>
        /// Popup for int value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this int value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);
        
        /// <summary>
        /// Popup for decimal value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this decimal value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);
        
        /// <summary>
        /// Popup for IntPtr value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this IntPtr value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);        
        
        /// <summary>
        /// Popup for double value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this double value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);
        
        /// <summary>
        /// Popup for long value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this long value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);
        
        /// <summary>
        /// Popup for string value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this string value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);
        
        
        /// <summary>
        /// Popup for string value if contem a string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="contem"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this string value, in string contem, in string message = "") => PopupIt($"Value: {value}", value.ContemUpper(contem), message);        
        
        /// <summary>
        /// Popup for bool value
        /// </summary>
        /// <param name="value"></param>
        /// <param name="showIf"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool PopupBox(this bool value, in bool showIf = true, in string message = "") => PopupIt($"Value: {value}", showIf, message);

        /// <summary>
        /// Check if exist comparing uppper text
        /// </summary>
        /// <param name="value"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static bool ContemUpper(this string value, string text) => string.IsNullOrEmpty(value) || string.IsNullOrEmpty(text) ? false : value.ToUpper().IndexOf(text.ToUpper()) != -1;


        /// <summary>
        /// Sample
        /// You can add another controls or objects
        /// </summary>
        /// <param name="button"></param>
        /// <param name="showIf"></param>
        /// <returns></returns>
        public static bool PopupBox(this Button button, in bool showIf = true) => PopupIt(button.Text, showIf);

        /// <summary>
        /// Sample
        /// You can add another controls or objects
        /// Test with MailAddress
        /// </summary>
        /// <param name="eml"></param>
        /// <param name="showIf"></param>
        /// <returns></returns>
        public static bool PopupBox(this MailAddress eml, in bool showIf = true) => PopupIt(eml.Address, showIf);

        /// <summary>
        /// Add the label if value not is empty
        /// </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        private static string LabelIfNotEmpty(this string value, string label) => string.IsNullOrEmpty(value) ? "" : $"{label}:{value}";

        /// <summary>
        /// Show popup only for DEBUG
        /// </summary>
        /// <param name="message"></param>
        /// <param name="showIf"></param>
        /// <param name="messageExtra"></param>
        /// <returns></returns>
        private static bool PopupIt(string message, in bool showIf = true, in string messageExtra = "")

#if (DEBUG)
        {
            // Show popup if true
            if (showIf)
            {
                Debug.WriteLine($"{messageExtra.LabelIfNotEmpty("Extra message:")}{message}");
            
                // Optional:
                MessageBox.Show($"{messageExtra.LabelIfNotEmpty("Extra message:")}{message}");
            
            }
            // showIf 
            return showIf;
        }
#else
            // on Releases returns false
            => false;

#endif

    }

}