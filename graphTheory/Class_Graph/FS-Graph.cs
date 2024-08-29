using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphTheory.Class_Graph
{
    internal class FS_Graph
    {
        Queue<int> DSDinhDuyet = new Queue<int>();
        public int sodinh;
        public int nTPLT;
        public int DTerror;
        private int[,] a = new int[100, 100];
        private int[] LuuVet = new int[100];
        public int[] visited = new int[100];
        private int nT;
        private int tongsocanh = 0;
        Graph[] DSCanh = new Graph[100];
        Graph canhtam = new Graph();
        public int TrongSoKruscal = 0;
        public int TrongSoPrim = 0;
        
        bool[] ThuocT = new bool[20];
        int[] Length = new int[20];
        int[] LastV = new int[20];
        public List<int> kqDFS = new List<int> { };
        public List<int> kqBFS = new List<int> { };
        public List<int> kqKruskal = new List<int> { };
        public List<int> kqDijkstra = new List<int> { };
        public List<int> kqPrim = new List<int> { };
        public bool[] thuocT = new bool[100];
        public int[] length = new int[100];
        public int[] lastV = new int[100]; // lastV[3] = 2
        struct Graph
        {
            public int u;
            public int v;
            public int value;
        }
        private Graph CanhNhoNhat = new Graph();
        private Graph[] g = new Graph[100];
        private Graph[] T = new Graph[100];
        public int voCuc = -1;

        public void readMatrix(string[] array, int sodinh)
        {
            int x = 0;
            this.sodinh = sodinh;
            int num = 0;
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    if (Int32.TryParse(array[x], out num))
                    {
                        this.a[i, j] = Convert.ToInt32(array[x++]);
                    }
                    else
                    {
                        this.DTerror = 1;
                        return;
                    }
                }
            }
        }
        public void readMatrixCH(string[] array, int sodinh)
        {
            int x = 0;
            this.sodinh = sodinh;
            int num = 0;
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    if (Int32.TryParse(array[x], out num))
                    {
                        num = Convert.ToInt32(array[x++]);
                        if (num > 0)
                        {

                            this.a[i, j] = num;
                            this.a[j, i] = num;
                        }
                    }
                    else
                    {
                        this.DTerror = 1;
                        return;
                    }
                }
            }
        }
        #region DocDoThi
        public void readGRAPH(int[,] array, int sodinh)
        {

            this.sodinh = sodinh;
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    this.a[i, j] = array[i, j];
                }
            }

        }
        #endregion
        #region DFS
        public void DFS(int s)
        {
            this.visited[s] = 1;
            for (int i = 0; i < this.sodinh; i++)
                if (this.visited[i] == 0 && this.a[s, i] != 0)
                {
                    this.LuuVet[i] = s; //Lưu trước đỉnh i là đỉnh s
                    this.DFS(i);//gọi đệ quy tiến hành xét tiếp
                }
        }


        public string duyetDFS(int s, int f)
        {
            string kq = "";
            //Khởi tạo giá trị ban đầu, tất cả các địh chư đuợc duyệt và chưa lưu vết
            for (int i = 0; i < this.sodinh; i++)
            {
                this.visited[i] = 0;
                this.LuuVet[i] = -1;
            }

            //Gọi hàm DFS
            this.DFS(s);

            if (this.visited[f] == 1)
            {
                //In ket qua
                int j = f;
                while (j != s)
                {
                    kqDFS.Add(j);
                    kq += Convert.ToString(j);
                    j = this.LuuVet[j];
                }
                kqDFS.Add(s);
                kq += Convert.ToString(s);
            }
            else
            {
                kq = string.Empty;
            }
            return kq;
        }
        #endregion
        #region BFS
        public void BFS(int s)
        {
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(s);
            while (Q.Count > 0)
            {
                s = Q.Dequeue();
                this.visited[s] = 1;
                for (int i = 0; i < this.sodinh; i++)
                    if (this.visited[i] == 0 && this.a[s, i] != 0)
                    {
                        Q.Enqueue(i); this.LuuVet[i] = s;
                    }
            }
        }
        public string duyetBFS(int s, int f)
        {
            string kq = "";
            //Khởi tạo giá trị ban đầu, tất cả các địh chư đuợc duyệt và chưa lưu vết
            for (int i = 0; i < this.sodinh; i++)
            {
                this.visited[i] = 0;
                this.LuuVet[i] = -1;
            }

            //Gọi hàm BFS
            BFS(s);

            if (this.visited[f] == 1)
            {
                //In ket qua
                int j = f;
                while (j != s)
                {
                    kqBFS.Add(j);
                    kq += Convert.ToString(j);
                    j = this.LuuVet[j];
                }
                kqBFS.Add(s);
                kq += Convert.ToString(s);
            }
            else
                kq = string.Empty;
            return kq;
        }
        #endregion
        #region Lien Thong
        public void visitedLT(int s, int nLabel)
        {
            Queue<int> Q = new Queue<int>();
            Q.Enqueue(s);
            this.visited[s] = nLabel;
            while (Q.Count > 0)
            {
                s = Q.Dequeue();
                for (int i = 0; i < this.sodinh; i++)
                    if (this.visited[i] == 0 && this.a[s, i] != 0)
                    {
                        Q.Enqueue(i); this.visited[i] = nLabel;
                    }
            }
        }
        public void xetLT()
        {
            for (int i = 0; i < this.sodinh; i++)
                this.visited[i] = 0;
            // đặt số miền liên thông ban đầu la 0
            this.nTPLT = 0;

            // dùng một vòng for i để tìm đỉnh chưa xét, gọi hàm duyệt cho đỉnh này
            for (int i = 0; i < this.sodinh; i++)
                if (this.visited[i] == 0)
                {
                    this.nTPLT++;
                    // nSoMienLienThong là nhãn sẽ gán cho các đỉnh trong lần duyệt này
                    this.visitedLT(i, this.nTPLT);
                }
        }
        public string[] thanhPhanLienThong()
        {
            xetLT();
            string[] TPLT = new string[this.nTPLT + 1];
            TPLT[0] = this.nTPLT.ToString();
            for (int i = 1; i <= TPLT.Length; i++)
            {
                // xét tất cả các đỉnh, nếu có nhãn trùng với nMienLienThong, in ra
                for (int j = 0; j < this.sodinh; j++)
                {
                    if (visited[j] == i)
                    {
                        TPLT[i] += j.ToString() + " ";
                    }
                }
            }
            return TPLT;
        }
        #endregion
        #region PrimMin
        public string PrimMin()
        {
            nT = 0;
            string kq = string.Empty;
            this.xetLT();
            if (this.nTPLT > 1)
            {
                return kq;
            }

            for (int i = 0; i < sodinh; i++)
            {
                this.visited[i] = 0;
            }
            this.visited[0] = 1;
            while (nT < sodinh - 1)
            {
                int GTNN = 100;
                for (int i = 0; i < sodinh; i++)
                {
                    if (visited[i] == 1)
                    {
                        for (int j = 0; j < sodinh; j++)
                        {
                            if (visited[j] == 0 && a[i, j] != 0 && GTNN > a[i, j])
                            {
                                CanhNhoNhat.u = i;
                                CanhNhoNhat.v = j;
                                CanhNhoNhat.value = a[i, j];
                                GTNN = this.a[i, j];
                            }
                        }
                    }

                }
                g[nT] = CanhNhoNhat;
                nT++;
                visited[CanhNhoNhat.v] = 1;
            }
            TrongSoPrim = 0;
            for (int i = 0; i < nT; i++)
            {
                kq += g[i].u.ToString() + g[i].v.ToString();
                kqPrim.Add(g[i].u);
                kqPrim.Add(g[i].v);
                TrongSoPrim += g[i].value;
            }
            return kq;
        }
        #endregion
        #region PrimMax
        public string PrimMax()
        {
            nT = 0;
            string kq = string.Empty;
            this.xetLT();
            if (this.nTPLT > 1)
            {
                return kq;
            }

            for (int i = 0; i < sodinh; i++)
            {
                this.visited[i] = 0;
            }
            this.visited[0] = 1;
            while (nT < sodinh - 1)
            {
                int GTNN = -1;
                for (int i = 0; i < sodinh; i++)
                {
                    if (visited[i] == 1)
                    {
                        for (int j = 0; j < sodinh; j++)
                        {
                            if (visited[j] == 0 && a[i, j] != 0 && GTNN < a[i, j])
                            {
                                CanhNhoNhat.u = i;
                                CanhNhoNhat.v = j;
                                CanhNhoNhat.value = a[i, j];
                                GTNN = this.a[i, j];
                            }
                        }
                    }

                }
                g[nT] = CanhNhoNhat;
                nT++;
                visited[CanhNhoNhat.v] = 1;
            }
            TrongSoPrim = 0;
            for (int i = 0; i < nT; i++)
            {
                kq += g[i].u.ToString() + g[i].v.ToString();
                kqPrim.Add(g[i].u);
                kqPrim.Add(g[i].v);
                TrongSoPrim += g[i].value;
            }
            return kq;
        }
        #endregion
        public void SapXepCachTangDan()
        {
            for (int i = 0; i < tongsocanh - 1; i++)
            {
                for (int j = i + 1; j < tongsocanh; j++)
                {
                    if (DSCanh[i].value > DSCanh[j].value)
                    {
                        canhtam = DSCanh[i];
                        DSCanh[i] = DSCanh[j];
                        DSCanh[j] = canhtam;
                    }
                }
            }
        }
        public void SapXepCachGiamDan()
        {
            for (int i = 0; i < tongsocanh - 1; i++)
            {
                for (int j = i + 1; j < tongsocanh; j++)
                {
                    if (DSCanh[i].value < DSCanh[j].value)
                    {
                        canhtam = DSCanh[i];
                        DSCanh[i] = DSCanh[j];
                        DSCanh[j] = canhtam;
                    }
                }
            }
        }
        #region KruscalMin
        public string KruskalMin()
        {
            string kq = String.Empty;
            int _nT = 0;
            int[] Nhan = new int[100];
            this.xetLT();
            if (this.nTPLT > 1)
            {
                return kq;
            }
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    if (this.a[i, j] > 0)
                    {
                        DSCanh[tongsocanh].u = i;
                        DSCanh[tongsocanh].v = j;
                        DSCanh[tongsocanh].value = a[i, j];
                        this.tongsocanh++;
                    }
                }
            }
            this.SapXepCachTangDan();
            for (int i = 0; i < this.sodinh; i++)
            {
                Nhan[i] = i;
            }
            int iMin = 0;
            while (_nT < this.sodinh - 1)
            {
                if (iMin < tongsocanh)
                {
                    if (Nhan[DSCanh[iMin].u] != Nhan[DSCanh[iMin].v])
                    {
                        T[_nT] = DSCanh[iMin];
                        _nT++;
                        int giatri = Nhan[DSCanh[iMin].v];
                        for (int j = 0; j < this.sodinh; j++)
                        {
                            if (Nhan[j] == giatri)
                                Nhan[j] = Nhan[DSCanh[iMin].u];
                        }
                    }
                    iMin++;
                }
                else
                {
                    break;
                }
            }
            if (_nT != this.sodinh - 1)
            {
                return kq;
            }
            else
            {
                TrongSoKruscal = 0;
                for (int i = 0; i < _nT; i++)
                {
                    kq += T[i].u.ToString() + T[i].v.ToString();
                    kqKruskal.Add(T[i].u);
                    kqKruskal.Add(T[i].v);
                    TrongSoKruscal += T[i].value;
                }  
            }
            return kq;
        }
        #endregion
        #region Kruscal Max
        public string KruskalMax()
        {
            string kq = string.Empty;
            int _nT = 0;
            int[] Nhan = new int[100];
            this.xetLT();
            if (this.nTPLT > 1)
            {
                return kq;
            }
            for (int i = 0; i < this.sodinh; i++)
            {
                for (int j = 0; j < this.sodinh; j++)
                {
                    if (this.a[i, j] > 0)
                    {
                        DSCanh[tongsocanh].u = i;
                        DSCanh[tongsocanh].v = j;
                        DSCanh[tongsocanh].value = a[i, j];
                        this.tongsocanh++;
                    }
                }
            }
            this.SapXepCachGiamDan();
            for (int i = 0; i < this.sodinh; i++)
            {
                Nhan[i] = i;
            }
            int iMin = 0;
            while (_nT < this.sodinh - 1)
            {
                if (iMin < tongsocanh)
                {
                    if (Nhan[DSCanh[iMin].u] != Nhan[DSCanh[iMin].v])
                    {
                        T[_nT] = DSCanh[iMin];
                        _nT++;
                        int giatri = Nhan[DSCanh[iMin].v];
                        for (int j = 0; j < this.sodinh; j++)
                        {
                            if (Nhan[j] == giatri)
                                Nhan[j] = Nhan[DSCanh[iMin].u];
                        }
                    }
                    iMin++;
                }
                else
                {
                    break;
                }
            }
            if (_nT != this.sodinh - 1)
            {
                return kq;
            }
            else
            {
                TrongSoKruscal = 0;
                for (int i = 0; i < _nT; i++)
                {
                    kq += T[i].u.ToString() + T[i].v.ToString();
                    kqKruskal.Add(T[i].u);
                    kqKruskal.Add(T[i].v);
                    TrongSoKruscal += T[i].value;
                }
            }
            return kq;
        }
        //
        #endregion
        #region Dijkstra
        public void Dijsktra(int s, int f)
        {
            int v = s;
            int t = s;
            //
            for (int i = 0; i < sodinh; i++)
            {
                ThuocT[i] = true;
                Length[i] = -1; // VoCuc
                LastV[i] = -1;
            }
            Length[s] = 0;
            ThuocT[s] = false;
            LastV[s] = s;
            //
            while (ThuocT[f])
            {
                for (int k = 0; k < sodinh; k++)
                {
                    if (a[v, k] != 0 && ThuocT[k] == true && (Length[k] == -1 || Length[k] > Length[v] + a[v, k]))
                    {
                        Length[k] = Length[v] + a[v, k];
                        LastV[k] = v;
                    }
                }
                v = -1;
                for (int i = 0; i < sodinh; i++)
                {
                    if (ThuocT[i] == true && Length[i] != -1)
                        if (v == -1 || Length[v] > Length[i])
                        {
                            v = i;
                        }
                }
                ThuocT[v] = false;
            }
        }
        public void dijkstra(int dinhDau, int dinhCuoi)
        {
            int i = 0;
            for (i = 0; i < sodinh; ++i)
            {
                thuocT[i] = true;
                length[i] = voCuc;
                lastV[i] = -1;
            }

            length[dinhDau] = 0;
            thuocT[dinhDau] = false;
            lastV[dinhDau] = dinhDau;

            int v = dinhDau;
            int t = dinhDau;

            while (thuocT[dinhCuoi])
            {
                for (int k = 0; k < sodinh; ++k)
                {
                    if (a[v, k] != 0 && thuocT[k] == true && (length[k] == voCuc || length[k] > length[v] + a[v, k]))
                    {
                        length[k] = length[v] + a[v, k];
                        lastV[k] = v;
                    }
                }

                v = -1;

                for (i = 0; i < sodinh; ++i)
                {
                    if (thuocT[i] == true && length[i] != voCuc)
                    {
                        if (v == -1 || length[v] > length[i]) v = i;
                    }
                }
                thuocT[v] = false;
            }
        }
        public int[] duongDi = new int[100];
        public int id = 0;
        public void xuat(int dinhDau, int dinhCuoi)
        {
            int v = dinhCuoi;// v = 3

            while (v != dinhDau)// v != 1
            {
                duongDi[id] = v;
                v = lastV[v];
                ++id;
            }

            duongDi[id] = dinhDau;
        }
        #endregion
        #region Xuat
        public string Xuat(int s, int f)
        {
            string kq = string.Empty;
            this.xetLT();
            if (this.nTPLT > 1)
            {
                return kq;
            }
            Dijsktra(s, f);
            int[] DuongDi = new int[20];
            int v = f, i;

            int id = 0;
            while (v != s)
            {
                DuongDi[id] = v;
                v = LastV[v];
                id++;
            }
            DuongDi[id] = s;
            for (i = id; i > 0; i--)
            {
                kq += DuongDi[i];
                kqDijkstra.Add(DuongDi[i]);
            }
            kqDijkstra.Add(DuongDi[i]);
            kq += DuongDi[i];
            return kq;
        }
        #endregion
        #region ford-Bellman
        public void fordBellman(int dinhDau, int dinhCuoi)
        {
            int i = 0;
            for (i = 0; i < sodinh; ++i)
            {
                thuocT[i] = true;
                length[i] = voCuc;
                lastV[i] = -1;
            }

            length[dinhDau] = 0;
            thuocT[dinhDau] = false;
            lastV[dinhDau] = dinhDau;

            DSDinhDuyet.Enqueue(dinhDau);
            int choice = DSDinhDuyet.Peek();
            int v = dinhDau;
            int t = dinhDau;

            while (thuocT[dinhCuoi])
            {
                while (DSDinhDuyet.Count()!=0)
                {
                    choice = DSDinhDuyet.Peek();
                    for (int k = 0; k < sodinh; ++k)
                    {
                        if (a[choice, k] != 0 && thuocT[k] == true && (length[k] == voCuc || length[k] > length[choice] + a[choice, k]))
                        {
                            length[k] = length[choice] + a[choice, k];
                            lastV[k] = choice;
                        }
                    }
                    DSDinhDuyet.Dequeue();
                }
                
                //choice = -1;

                for (i = 0; i < sodinh; ++i)
                {
                    if (thuocT[i] == true && length[i] != voCuc)
                    {
                        //if (choice == -1 || length[choice] > length[i]) choice = i;
                        DSDinhDuyet.Enqueue(i);
                        thuocT[i] = false;
                    }
                }
                //thuocT[v] = false;
            }
        }
        #endregion
    }

}
