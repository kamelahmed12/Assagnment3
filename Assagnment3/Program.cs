namespace Assagnment3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // 1.
            #region Question 1
            double d = 9.99;
            int x = (int)d;
            Console.WriteLine(x);

            // Output: 9
            // Explanation:
            // تم عمل Explicit Casting من double إلى int.
            // الجزء العشري يتم حذفه (ليس تقريب).
            #endregion


            // 2.
            #region Question 2
            int n = 5;
            double d2 = n / 2.0;
            Console.WriteLine(d2);

            // Explanation:
            // القسمة بين int تعطي int.
            // لذلك جعلنا 2.0 double ليتم التحويل إلى double.
            #endregion


            // 3.
            #region Question 3
            int age = int.Parse(Console.ReadLine());
            #endregion


            // 4.
            #region Question 4
            string s = "12a";
            int x2 = int.Parse(s);
            Console.WriteLine(x2);

            // Explanation:
            // سيحدث FormatException لأن النص يحتوي على حرف.
            #endregion


            // 5.
            #region Question 5
            string s2 = "12a";

            if (int.TryParse(s2, out int result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            #endregion


            // 6.
            #region Question 6
            object o = 10;
            int a = (int)o;
            Console.WriteLine(a + 1);

            // Output: 11
            // Explanation:
            // تم Boxing للـ int داخل object
            // ثم Unboxing مرة أخرى إلى int
            #endregion


            // 7.
            #region Question 7
            object o2 = 10;

            try
            {
                long x3 = (long)o2;
                Console.WriteLine(x3);
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Invalid Cast");
            }

            // Explanation:
            // يحدث خطأ لأن object يحتوي int وليس long.
            #endregion


            // 8.
            #region Question 8
            object o3 = 10;

            long x4 = o3 is int temp ? temp : -1;
            Console.WriteLine(x4);

            // Explanation:
            // نتحقق من النوع أولاً لتجنب exception.
            #endregion


            // 9.
            #region Question 9
            string? name = null;
            Console.WriteLine(name?.Length);

            // Output: (nothing)
            // Explanation:
            // ?. يمنع NullReferenceException
            #endregion


            // 10.
            #region Question 10
            string? name2 = null;
            int length = name2?.Length ?? 0;
            Console.WriteLine(length);

            // Output: 0
            // Explanation:
            // ?. يرجع null
            // ?? تعطي القيمة البديلة
            #endregion


            // 11.
            #region Question 11
            // المشكلة أن int.Parse لا يقبل null
            // الحل الأفضل:

            string? s3 = null;
            int x5 = Convert.ToInt32(s3);
            Console.WriteLine(x5);
            #endregion


            // 12.
            #region Question 12
            string? s4 = null;

            try
            {
                Console.WriteLine(s4!.Length);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Reference");
            }

            // ! يخبر الكمبايلر أن القيمة ليست null
            // لكنه قد يسبب Runtime Error.
            #endregion


            // 13.
            #region Question 13
            string? s5 = null;
            int x6 = Convert.ToInt32(s5);
            Console.WriteLine(x6);

            // Output: 0
            #endregion


            // 14.
            #region Question 14
            string? s6 = null;

            // A
            // int a2 = int.Parse(s6);  // Exception

            // B
            int b = Convert.ToInt32(s6);
            Console.WriteLine(b);

            // Explanation:
            // int.Parse(null) → Exception
            // Convert.ToInt32(null) → 0
            #endregion


            // 15.
            #region Question 15
            string? user = null;
            Console.WriteLine((user ?? "Guest").ToUpper());
            #endregion






        }
    }
}
