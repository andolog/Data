using System;
using System.Collections.Generic;
using System.Linq;

namespace cmstar.Data
{
    /// <summary>
    /// ����������֤���йط�����
    /// </summary>
    public static class ArgAssert
    {
        /// <summary>
        /// ���Բ����ǿ����á�
        /// </summary>
        /// <param name="arg">����ʵ����</param>
        /// <param name="name">�������ơ�</param>
        public static void NotNull(object arg, string name)
        {
            if (arg == null)
                throw new ArgumentNullException(name);
        }

        /// <summary>
        /// �����ַ������͵Ĳ����ǿ����û���ַ�����
        /// </summary>
        /// <param name="value">�ַ���ʵ����</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNullOrEmpty(string value, string parameterName)
        {
            if (value == null)
                throw new ArgumentNullException(parameterName);

            if (value.Length == 0)
                throw new ArgumentException("����\"{0}\"��ֵ����Ϊ�ա�".FormatWith(parameterName));
        }

        /// <summary>
        /// �����ַ������͵Ĳ����ǿ����û���ַ�����ֻ�����հ��ַ���
        /// </summary>
        /// <param name="value">�ַ���ʵ����</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNullOrEmptyOrWhitespace(string value, string parameterName)
        {
            NotNullOrEmpty(value, parameterName);

            if (value.All(char.IsWhiteSpace))
                throw new ArgumentException("����\"{0}\"��ֵ���ܽ������հ��ַ���".FormatWith(parameterName));
        }

        /// <summary>
        /// ���Լ������͵Ĳ����ǿ������ٰ���һ��Ԫ�ء�
        /// </summary>
        /// <typeparam name="T">������Ԫ�ص����͡�</typeparam>
        /// <param name="collection">���ϲ�����ʵ����</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNullOrEmpty<T>(ICollection<T> collection, string parameterName)
        {
            if (collection == null)
                throw new ArgumentNullException(parameterName);

            if (collection.Count == 0)
                throw new ArgumentException("����\"{0}\"�����������һ��Ԫ�ء�".FormatWith(parameterName));
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNegative(double value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С��0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotNegative(value, parameterName, msg);
        }


        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotNegative(double value, string parameterName, string errorMsg)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNegative(int value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С��0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotNegative(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotNegative(int value, string parameterName, string errorMsg)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotNegative(decimal value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С��0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotNegative(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�����С��0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotNegative(decimal value, string parameterName, string errorMsg)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotZero(double value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ���ܵ���0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotZero(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotZero(double value, string parameterName, string errorMsg)
        {
            if (0.00D.Equals(value))
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotZero(int value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ���ܵ���0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotZero(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotZero(int value, string parameterName, string errorMsg)
        {
            if (value == 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void NotZero(decimal value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ���ܵ���0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            NotZero(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ���������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void NotZero(decimal value, string parameterName, string errorMsg)
        {
            if (value == 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void IsPositive(double value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С�ڻ����0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            IsPositive(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void IsPositive(double value, string parameterName, string errorMsg)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void IsPositive(int value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С�ڻ����0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            IsPositive(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void IsPositive(int value, string parameterName, string errorMsg)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        public static void IsPositive(decimal value, string parameterName)
        {
            var msg = "����\"{0}\"��ֵ����С�ڻ����0����ǰֵΪ {1}��".FormatWith(parameterName, value);

            IsPositive(value, parameterName, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ�������0��
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void IsPositive(decimal value, string parameterName, string errorMsg)
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        public static void Between(double value, string parameterName, double min, double max)
        {
            var msg = "����\"{0}\"��ֵ�������{1}-{2}�䡣��ǰֵΪ {3}��".FormatWith(parameterName, min, max, value);

            Between(value, parameterName, min, max, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void Between(double value, string parameterName, double min, double max, string errorMsg)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        public static void Between(int value, string parameterName, int min, int max)
        {
            var msg = "����\"{0}\"��ֵ�������{1}-{2}�䡣��ǰֵΪ {3}��".FormatWith(parameterName, min, max, value);

            Between(value, parameterName, min, max, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void Between(int value, string parameterName, int min, int max, string errorMsg)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        public static void Between(decimal value, string parameterName, int min, int max)
        {
            var msg = "����\"{0}\"��ֵ�������{1}-{2}�䡣��ǰֵΪ {3}��".FormatWith(parameterName, min, max, value);

            Between(value, parameterName, min, max, msg);
        }

        /// <summary>
        /// ������ֵ���͵Ĳ������ڸ�����ֵ��Χ�ı������ڡ�
        /// </summary>
        /// <param name="value">ֵ��</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="min">��ֵ�������Сֵ��</param>
        /// <param name="max">��ֵ��������ֵ��</param>
        /// <param name="errorMsg">�����Բ�����ʱ����ʾ��Ϣ��</param>
        public static void Between(decimal value, string parameterName, int min, int max, string errorMsg)
        {
            if (value < min || value > max)
                throw new ArgumentOutOfRangeException(parameterName, errorMsg);
        }

        /// <summary>
        /// ���Բ�������ƥ����������͡�
        /// ע��<c>null</c>����ƥ���������£���<paramref name="arg"/>Ϊ<c>null</c>����˷��������׳��κ��쳣��
        /// </summary>
        /// <param name="arg">����ֵ��</param>
        /// <param name="type">������ƥ������͡�</param>
        /// <param name="parameterName">�������ơ�</param>
        /// <param name="canBeInheritted">
        /// ָ���Ƿ��ʹ�ò������͵Ļ���ƥ��������͡�������Ϊ<c>false</c>�������������������ͱ����ϸ���ȡ�
        /// Ĭ��ֵΪ<c>true</c>��
        /// </param>
        public static void IsType(object arg, Type type, string parameterName, bool canBeInheritted = true)
        {
            if (arg == null)
                return;

            var t = arg.GetType();

            if (t == type || (canBeInheritted && t.IsSubclassOf(type)))
                return;

            var msg = "����\"{0}\"������{0}�������ࡣ".FormatWith(parameterName, type.FullName);
            throw new ArgumentException(msg, parameterName);
        }

        public static string FormatWith(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}
