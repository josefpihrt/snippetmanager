using System;

namespace Pihrtsoft.Snippets.Validations
{
    internal static class ValidationHelper
    {
        /// <summary>
        /// Gets a value indicating whether the specified <paramref name="value"/> is valid snippet shortcut.
        /// </summary>
        /// <param name="value">A value to validate.</param>
        /// <returns><c>true</c> if <paramref name="value"/> is valid snippet shortcut; Otherwise, <c>false</c>.</returns>
        public static bool IsValidShortcut(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            for (int i = 0; i < value.Length; i++)
            {
                int ch = value[i];

                if (!((ch >= 65 && ch <= 90)
                    || (ch >= 97 && ch <= 122)
                    || (ch >= 48 && ch <= 57)
                    || ch == 95
                    || ch == 35))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Gets a value indicating whether the specified <paramref name="value"/> is a valid literal identifier.
        /// </summary>
        /// <param name="value">A value to validate.</param>
        /// <returns><c>true</c> if <paramref name="value"/> is valid literal identifier; Otherwise, <c>false</c>.</returns>
        public static bool IsValidLiteralIdentifier(string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            if (Literal.IdentifierComparer.Equals(value, Placeholder.EndIdentifier))
                return false;

            if (Literal.IdentifierComparer.Equals(value, Placeholder.SelectedIdentifier))
                return false;

            return true;
        }

        /// <summary>
        /// Gets a value indicating whether the specified <see cref="Version"/> is valid snippet format version.
        /// </summary>
        /// <param name="version">A <see cref="Version"/> to validate.</param>
        /// <returns><c>true</c> if <paramref name="version"/> is valid snippet format version; Otherwise, <c>false</c>.</returns>
        public static bool IsValidVersion(Version version)
        {
            if (version == null)
                return false;

            return !(version.Major == -1 || version.Minor == -1 || version.Build == -1 || version.Revision != -1);
        }
    }
}
