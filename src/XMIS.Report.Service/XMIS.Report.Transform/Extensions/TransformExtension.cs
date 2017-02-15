// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TransformExtension.cs" company="">
//   
// </copyright>
// <summary>
//   The transform extension.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace XMIS.Report.Transform.Extensions
{
    using System;

    /// <summary>
    ///     The transform extension.
    /// </summary>
    public static class TransformExtension
    {
        /// <summary>
        /// The to date time.
        /// </summary>
        /// <param name="date">
        /// The date.
        /// </param>
        /// <param name="minutes">
        /// The minutes.
        /// </param>
        /// <returns>
        /// The <see cref="DateTime"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// Invalid date time format for : [date] [minutes]
        /// </exception>
        public static DateTime ToDateTime(this string date, int minutes)
        {
            try
            {
                var result = DateTime.Parse(date);
                result = new DateTime(result.Year, result.Month, result.Day);
                result = result.AddMinutes(minutes);
                return result;
            }
            catch (Exception ex)
            {
                // TODO  Logger.Log.Error(date + " : " + ex.Message, ex);
                throw ex;
            }
        }

        /// <summary>
        /// The get time minutes from legacy fox format of numbers separated by comma[12.00].
        /// </summary>
        /// <param name="time">
        /// The time.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// Invalid time string : [time]. 
        /// </exception>
        public static int ToMinutes(this string time)
        {
            try
            {
                var delimiter = ".";
                if (time.Contains(","))
                {
                    time = time.Replace(",", ".");
                }
                if (time.Contains(":"))
                {
                    time = time.Replace(":", ".");
                }
                var result = 0;
                if (time.Trim() == "." || time.Trim() == string.Empty)
                {
                    time = "0.0";
                }

                var timePair = time.Split('.');
                result = timePair[0].ToNumber() * 60 + timePair[1].ToNumber();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// The to number.
        /// </summary>
        /// <param name="s">
        /// The s.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="Exception">
        /// </exception>
        public static int ToNumber(this string s)
        {
            var result = 0;
            try
            {
                if (s.Trim() != string.Empty)
                {
                    result = Convert.ToInt32(s);
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}