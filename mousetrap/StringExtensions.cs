using System.Text.RegularExpressions;

namespace MouseTrap
{
    public static class StringExtensions
    {
        /// <summary>
        /// Searches the input string for the first occurrence of a regular expression, beginning
        ///   at the specified starting position in the string.
        /// </summary>
        /// <param name="str">The string to operate on.</param>
        /// <param name="regex">The regular expression to use.</param>
        /// <param name="startAt">The zero-based character position at which to start the search.</param>
        /// <returns>The matched string.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Startat is less than zero or greater than the length of input.</exception>
        /// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string Match(this string str, Regex regex, int startAt = 0)
            => regex.Match(str, startAt).Value;
        /// <summary>
        ///  Searches the input string for the first occurrence of a regular expression, beginning
        ///   at the specified starting position and searching only the specified number of characters.
        /// </summary>
        /// <param name="str">The string to search for a match.</param>
        /// <param name="regex">The regular expression to use.</param>
        /// <param name="begin">The zero-based character position in the input string that defines the leftmost position to be searched.</param>
        /// <param name="length">The number of characters in the substring to include in the search.</param>
        /// <returns>An object that contains information about the match.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Beginning is less than zero or greater than the length of input. -or- length is less than zero or greater than the length of input. -or- beginning+length-1 identifies a position that is outside the range of input.</exception>
        /// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string Match(this string str, Regex regex, int begin, int length)
            => regex.Match(str, begin, length).Value;
        /// <summary>
        /// Searches the specified input string for all occurrences of a regular expression, beginning at the specified starting position in the string.
        /// </summary>
        /// <param name="str">The string to search for a match.</param>
        /// <param name="regex">The regular expression to use.</param>
        /// <param name="startAt">The character position in the input string at which to start the search.</param>
        /// <returns>A collection of the System.Text.RegularExpressions.Match objects found by the search. If no matches are found, the method returns an empty collection object.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">Startat is less than zero or greater than the length of input.</exception>
        public static string[] MatchAll(this string str, Regex regex, int startAt = 0)
            => regex.Matches(str, startAt).Cast<string>().ToArray();
        /// <summary>
        /// In a specified input string, replaces all strings that match a specified regular expression with a string returned by a System.Text.RegularExpressions.MatchEvaluator delegate.
        /// </summary>
        /// <param name="str">The string to search for a match.</param>
        /// <param name="regex">The regular expression to use.</param>
        /// <param name="eval">A custom method that examines each match and returns either the original matched string or a replacement string.</param>
        /// <returns>A new string that is identical to the input string, except that a replacement string takes the place of each matched string. If the regular expression pattern is not matched in the current instance, the method returns the current instance unchanged.</returns>
        /// <exception cref="T:System.ArgumentNullException">Evaluator is null.</exception>
        /// <exception cref="T:System.Text.RegularExpressions.RegexMatchTimeoutException">A time-out occurred. For more information about time-outs, see the Remarks section.</exception>
        public static string Replace(this string str, Regex regex, MatchEvaluator eval)
            => regex.Replace(str, eval);
    }
}
