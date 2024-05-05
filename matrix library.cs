// Tran Huy Hoang 20206282
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Thu_vien_ma_tran
{
    class Program
    {
        // Nhan ma tran voi 1 so
        public static double[,] Nhan_ma_tran_voi_1_so(double[,] A, double k)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            double [,] C = new double[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j] * k;
                }
            }
            return C;
        }
        // Cong 2 ma tran
        public static double[,] cong_ma_tran(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            double[, ] C = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }
        // Tru 2 ma tran
        public static double[,] tru_ma_tran(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            double[, ] C = new double[n, m];
            if (n == B.GetLength(0) && m == B.GetLength(1))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        C[i, j] = A[i, j] - B[i, j];
                    }
                }
            }
            return C;
        }
        // Nhan 2 ma tran
        public static double[,] nhan_ma_tran(double[,] A, double[,] B)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            int p = B.GetLength(0);
            int q = B.GetLength(1);
            double [,] C = new double[m, q];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    C[i, j] = 0;
                    for (int k = 0; k < m; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }
        // tinh dịnh thuc cua ma tran
        public static double dinh_thuc_ma_tran(double[,] A)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            double det = 0;
            if (n == 1)
            {
                det = A[0, 0];
            }
            else if (n == 2)
            {
                det = A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    double[,] B = new double[n - 1, n - 1];
                    for (int j = 1; j < n; j++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (k < i)
                            {
                                B[j - 1, k] = A[j, k];
                            }
                            else if (k > i)
                            {
                                B[j - 1, k - 1] = A[j, k];
                            }
                        }
                    }
                    det += Math.Pow(-1, i) * A[0, i] * dinh_thuc_ma_tran(B);
                }
            }
            return det;
        }
        // tim ma tran chuyen vi
        public static double[,] chuyen_vi_ma_tran(double[,] A)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            double[,] At = new double[m, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    At[j, i] = A[i, j];
                }
            }
            return At;
        }
        // nhap ma tran tu ban phim
        public static double[,] nhap_ma_tran()
        {
            int n = 0;
            int m = 0;
            Console.Write("Nhap so hang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so cot: ");
            m = Convert.ToInt32(Console.ReadLine());
            double[,] A = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("[{0},{1}]: ", i+1, j+1);
                    A[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            return A;
        }
        // in ma tran ra man hinh
        public static void In_ma_tran(double[,] A)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            // nguoi dung nhap vao lua chon
            int lua_chon = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1. Nhan ma tran voi mot so");
                Console.WriteLine("2. Cong 2 ma tran");
                Console.WriteLine("3. Tru 2 ma tran");
                Console.WriteLine("4. Nhan 2 ma tran");
                Console.WriteLine("5. Chuyen vi ma tran");
                Console.WriteLine("6. Dinh thuc ma tran");
                Console.WriteLine("7. Thoat");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Nhap lua chon: ");
                lua_chon = Convert.ToInt32(Console.ReadLine());
                switch (lua_chon)
                {
                    case 1:
                        Console.WriteLine("Nhap ma tran: ");
                        double[,] A = nhap_ma_tran();
                        Console.WriteLine("Ma tran vua nhap: ");
                        In_ma_tran(A);
                        Console.WriteLine("");
                        Console.Write("Nhap so thuc k: ");
                        double k = Convert.ToDouble(Console.ReadLine());
                        double [, ] C = Nhan_ma_tran_voi_1_so(A, k);
                        Console.WriteLine("");
                        Console.WriteLine("Ma tran sau khi nhan voi 1 so: ");
                        In_ma_tran(C);
                        break;
                    case 2:
                    //nhập ma trận A1
                        Console.WriteLine("Nhap ma tran A: ");
                        double[,] A1 = nhap_ma_tran();
                        Console.WriteLine("Nhap ma tran B: ");
                        double[,] B1 = nhap_ma_tran();
                        double[,] C1 = new double[A1.GetLength(0), A1.GetLength(1)];
                        int n = A1.GetLength(0);
                        int m = A1.GetLength(1);
                        int p = B1.GetLength(0);
                        int q = B1.GetLength(1);
                        if (m != q || n != p)
                        {
                            Console.WriteLine("Khong the thuc hien phep cong 2 ma tran khac kich thuoc");
                            break;
                        }
                        else{
                            C1 = cong_ma_tran(A1, B1);
                            Console.WriteLine("Ma tran A+B: ");
                            In_ma_tran(C1);
                        }
                        break;
                    //tru 2 ma tran
                    case 3:
                        //
                        Console.WriteLine("Nhap ma tran A: ");
                        double[,] A2 = nhap_ma_tran();
                        Console.WriteLine("Nhap ma tran B: ");
                        double[,] B2 = nhap_ma_tran();
                        double[,] C2 = new double[A2.GetLength(0), A2.GetLength(1)];
                        int n2 = A2.GetLength(0);
                        int m2 = A2.GetLength(1);
                        int p2 = B2.GetLength(0);
                        int q2 = B2.GetLength(1);
                        if (m2 != q2 || n2 != p2)
                        {
                            Console.WriteLine("Khong the thuc hien phep cong 2 ma tran khac kich thuoc");
                            break;
                        }
                        else{
                            C2 = tru_ma_tran(A2, B2);
                            Console.WriteLine("Ma tran A-B: ");
                            In_ma_tran(C2);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Nhap ma tran A: ");
                        double[,] A3 = nhap_ma_tran();
                        Console.WriteLine("Nhap ma tran B: ");
                        double[,] B3 = nhap_ma_tran();
                        int n3 = A3.GetLength(0);
                        int m3 = A3.GetLength(1);
                        int p3 = B3.GetLength(0);
                        int q3 = B3.GetLength(1); 
                        double[,] C3 = new double[n3, p3];
                        if(m3 != p3){
                            Console.WriteLine("Khong the nhan hai ma tran");
                        }    
                        else{
                            C3 = nhan_ma_tran(A3, B3);
                            Console.WriteLine("Ma tran A*B: ");
                            In_ma_tran(C3);
                        }                
                        break;
                    case 5:
                        Console.WriteLine("Nhap ma tran A: ");
                        double[,] A4 = nhap_ma_tran();
                        // in ra ma trân A4
                        Console.WriteLine("Ma tran A: ");
                        In_ma_tran(A4);
                        Console.WriteLine("");
                        //số hàng và số côt của ma trận A4
                        int n4 = A4.GetLength(0);
                        int m4 = A4.GetLength(1);
                        if(n4 != m4){
                            Console.WriteLine("Khong the chuyen vi ma tran");
                        }
                        else{
                            double[,] C4 = chuyen_vi_ma_tran(A4);
                            Console.WriteLine("Ma tran A sau khi chuyen vi: ");
                            In_ma_tran(C4);
                        }
                        break; 
                    case 6:
                        //
                        Console.WriteLine("Nhap ma tran A: ");
                        double[,] A5 = nhap_ma_tran();
                        Console.WriteLine("Ma tran A: ");
                        In_ma_tran(A5);
                        int n5 = A5.GetLength(0);
                        int m5 = A5.GetLength(1);
                        double det;
                        if(n5 != m5){
                            Console.WriteLine("Khong the tinh dinh thuc ma tran vi ma tran khong phai ma tran");
                        }
                        else{
                            det = dinh_thuc_ma_tran(A5);
                            Console.WriteLine("Dinh thuc ma tran la: " + det);
                        }
                        break;    
                    case 7:
                        break;       
                }
            
            }
            while (lua_chon != 7);
        }
    }
}