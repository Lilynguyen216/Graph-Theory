using graphTheory.Class_Graph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphTheory
{
    public partial class frmMatrix : Form
    {
        public frmMatrix()
        {
            InitializeComponent();
            pnlCayKhung.Enabled = false;
            pnlDinh.Enabled = false;
        }
        int[,] savematrix = new int[100, 100];
        Point[] point_Dinh = new Point[100];
        public int n_Point_Dinh = 0;
        public int[,] maTran = new int[100, 100];
        String duong_Dan = "";
        Class_Graph.FS_Graph Dothi = new Class_Graph.FS_Graph();
        string[] TPLT = new string[] { };
        AdjustableArrowCap arrowSize = new AdjustableArrowCap(7, 7);
        string Kruskal, Prim = string.Empty;
        #region KiemTra
        #region KTDTVH
        bool kiem_Tra_Do_Thi_Vo_Huong()
        {
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                for (int j = 0; j < n_Point_Dinh; ++j)
                {
                    if (maTran[i, j] != maTran[j, i]) return false;
                }
            }
            return true;
        }
        #endregion
        #region KiemTraTinhHopLe
        bool kiem_Tra_Tinh_Hop_Le_Cua_Ma_Tran()
        {
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                if (maTran[i, i] != 0) return false;
            }
            return true;
        }
        #endregion
        #region KT_KhoangCach
        bool kiem_Tra_Khoang_Cach(int x, int y)
        {
            int x_Vector = 0, y_Vector = 0;
            int khoang_Cach = 0;
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                x_Vector = Math.Abs(x - point_Dinh[i].X);
                y_Vector = Math.Abs(y - point_Dinh[i].Y);
                khoang_Cach = (int)Math.Sqrt(Math.Pow(x_Vector, 2) + Math.Pow(y_Vector, 2));
                if (khoang_Cach < 50) return false;
            }
            return true;
        }
        #endregion
        #region tải dữ liệu lên Combobox 
        private void LoadComBoBoxDinhBatDau()
        {
            int[] ArrVertex = new int[n_Point_Dinh];
            for (int i = 0; i < n_Point_Dinh; i++)
            {
                ArrVertex[i] = i;
            }
            cbxDinhBatDau.DataSource = ArrVertex;
        }
        private void LoadComBoBoxDinhKetThuc()
        {
            int[] ArrVertex = new int[n_Point_Dinh];
            for (int i = 0; i < n_Point_Dinh; i++)
            {
                ArrVertex[i] = i;
            }
            cbxDinhKetThuc.DataSource = ArrVertex;
        }
        #endregion
        #endregion
        #region Button DocFile
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                duong_Dan = open.FileName;
                txtDuongDan.Text = duong_Dan;
                StreamReader read = new StreamReader(open.FileName);
                txtMaTran.Text = read.ReadToEnd();
                read.Close();
            }
        }
        #endregion
        #region Button VeDoThi
        private void btnVeDoThi_Click(object sender, EventArgs e)
        {
            Dothi.nTPLT = 0;
            n_Point_Dinh = 0;
            if (txtMaTran.Text != "0\r\n")
            {
                int temp = 0;
                // đọc File 
                if (duong_Dan != "")
                {
                    StreamReader read = new StreamReader(duong_Dan.Trim()); // mở file lên đọc
                    string dong = "";
                    dong = read.ReadLine();// đếm có bao nhiêu dòng
                    bool check_n = int.TryParse(dong, out temp);// đang lưu số đỉnh
                    string[] str = new string[100];
                    for (int i = 0; i < temp; ++i)// duyệt đỉnh
                    {
                        dong = read.ReadLine();
                        str = dong.Split(new char[] { ' ' });// tách ra thành chuỗi nhiều dòng
                        /*
                        VD: 1 0 0 0 1 1 -->
                        1
                        0
                        0
                        0
                        1
                        1
                        */
                        for (int j = 0; j < temp; ++j)
                        {
                            int _temp = 0;
                            string s = str[j];// chuỗi s lưu số dưới dạng ký tự chả
                            bool check = int.TryParse(s, out _temp);// lưu số vào trong biến _temp
                            if (check) maTran[i, j] = _temp;
                        }
                    }
                    read.Close();
                    duong_Dan = "";
                }
                else
                {
                    string dong = "";
                    dong = txtMaTran.Text;
                    bool check = int.TryParse(dong[0].ToString(), out temp);
                    check = false;
                    int k = 0;
                    string[] str = new string[100];
                    dong = "";
                    for (int i = 3; i < txtMaTran.Text.Length; ++i)
                    {
                        if (txtMaTran.Text[i] != '\r')
                        {
                            dong += txtMaTran.Text[i];
                        }
                        else
                        {
                            str = dong.Split(new char[] { ' ' });
                            for (int j = 0; j < temp; ++j)
                            {
                                check = int.TryParse(str[j], out maTran[k, j]);
                            }
                            ++i;
                            ++k;
                            dong = "";
                        }
                        #region Ghi Chu
                        //if (i == txtMaTran.Text.Length - 1)
                        //{
                        //    str = dong.Split(new char[] { ' ' });
                        //    for (int j = 0; j < temp; ++j)
                        //    {
                        //        check = int.TryParse(str[j], out maTran[k, j]);
                        //    }
                        //    ++i;
                        //    ++k;
                        //    dong = "";
                        //}
                        #endregion
                    }
                }
                n_Point_Dinh = temp;
                if (kiem_Tra_Tinh_Hop_Le_Cua_Ma_Tran() && kiem_Tra_Do_Thi_Vo_Huong())
                {
                    n_Point_Dinh = 0;
                    Random rd = new Random();
                    while (n_Point_Dinh < temp)
                    {
                        // 594, 510
                        point_Dinh[n_Point_Dinh].X = rd.Next(30, 480);
                        point_Dinh[n_Point_Dinh].Y = rd.Next(30, 420);
                        if (n_Point_Dinh != 0)
                        {
                            if (kiem_Tra_Khoang_Cach(point_Dinh[n_Point_Dinh].X, point_Dinh[n_Point_Dinh].Y) == false) continue;
                        }
                        ++n_Point_Dinh;
                    }
                    pbBang.Refresh();
                    //txtKetQua.Text = nCanh.ToString();
                }
                else
                {
                    //MessageBox.Show("Chỉ dùng được vô hướng. Hãy chọn lại File khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                    n_Point_Dinh = 0;
                    Random rd = new Random();
                    while (n_Point_Dinh < temp)
                    {
                        // 594, 510
                        point_Dinh[n_Point_Dinh].X = rd.Next(30, 480);
                        point_Dinh[n_Point_Dinh].Y = rd.Next(30, 420);
                        if (n_Point_Dinh != 0)
                        {
                            if (kiem_Tra_Khoang_Cach(point_Dinh[n_Point_Dinh].X, point_Dinh[n_Point_Dinh].Y) == false) continue;
                        }
                        ++n_Point_Dinh;
                    }
                    pbBang.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa đọc File", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKetQua.Text = String.Empty;
            }
            LoadComBoBoxDinhBatDau();
            LoadComBoBoxDinhKetThuc();
            pbBang.Refresh();
        }
        #endregion
        #region ChuyenDoiCHSangVH
        private void ChuyenDoiCHSangVH()
        {
            for (int i = 0; i < n_Point_Dinh; i++)
            {
                for (int j = 0; j < n_Point_Dinh; j++)
                {
                    if (maTran[i, j] != 0)
                    {
                        savematrix[j, i] = savematrix[i, j] = 1;
                    }
                }
            }
        }
        #endregion
        #region Mã giả
        void SourceDijsktra()
        {
            // rtxtMaGia = new RichTextBox();
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectedText = "Each corresponding vertex g(N)\n\nInital cost from Starting to Destination Node\n\nClose: List of arrivred vertices\n\nOpen: List of pending vertices\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Inital step: \n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Open = {";
            rtxtMaGia.SelectionColor = Color.Red;
            rtxtMaGia.SelectedText = "S";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "}\nClose = {}\n\n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "g[] = {0}\nprev[] = {-1}\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Executing step: \n\n";
            rtxtMaGia.SelectionColor = Color.Red;
            rtxtMaGia.SelectedText = "While";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = "(";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Open != {}";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = ")\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = " Step 1: Select N of Minium g(N) in Open \n";
            rtxtMaGia.SelectionColor = Color.Green;
            rtxtMaGia.SelectedText = "      _Connecting to previous node (if existing)\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = " Step 2: Open vertices Q following by N\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = "      _If g(Q) > g(N) + w(N,Q)\n    _g(Q) = g(N) + w(N,Q)\n";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "      _prev(Q) = N\n";
            rtxtMaGia.SelectionColor = Color.DarkGoldenrod;
            rtxtMaGia.SelectedText = "      _If Q not in Open, Add Q to Open\n";
            rtxtMaGia.SelectionColor = Color.DarkSlateGray;
            rtxtMaGia.SelectedText = "      _Add N to Close. If N is Destination Node, Stop";
        }
        void SourceKruskal()
        {
            // rtxtMaGia = new RichTextBox();
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectedText = "From any vertex to all vertices such that the cost is minimal\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Initial Step\n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Arrange vertices in order from smallest to largest.Add them to Open\nClose = {}\n g = 0\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Executing Step: \n\n";
            rtxtMaGia.SelectionColor = Color.Red;
            rtxtMaGia.SelectedText = "While";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = "(";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Open != {}";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = ")\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = "  __Select edge N\n";
            rtxtMaGia.SelectionColor = Color.ForestGreen;
            rtxtMaGia.SelectedText = "      _If 2 vertices of N not in Close(), Add N\n";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "           g = g + w(N)\n\n";
            rtxtMaGia.SelectionColor = Color.LimeGreen;
            rtxtMaGia.SelectedText = "      _Add N, Graph will have connectively.\n";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "           g = g + w(N)\n\n";
            rtxtMaGia.SelectionColor = Color.DimGray;
            rtxtMaGia.SelectedText = "      _Eject N. 2 vertices of N existed in Close, graph stil have connectively.\n";
            rtxtMaGia.SelectionColor = Color.Green;
            rtxtMaGia.SelectedText = "    _Add 2 vertices of N existed in Close";
        }
        void SourcePrim()
        {
            // rtxtMaGia = new RichTextBox();
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectedText = "From Starting vertex to all vertices such that the cost is minimal\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Initial Step\n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Open = {}\nClose = {";
            rtxtMaGia.SelectionColor = Color.Red;
            rtxtMaGia.SelectedText = "S";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "}\n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "g = {0}\n\n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "Executing Step: \n\n";
            rtxtMaGia.SelectionColor = Color.Red;
            rtxtMaGia.SelectedText = "While";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = "(";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "Number of vertices in Close != Number of vertices in graph";
            rtxtMaGia.SelectionColor = Color.Black;
            rtxtMaGia.SelectedText = ")\n\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = "   Step 1: Select N (last vertex in Close)\n\n   Step 2: Add adjacent edges with N which not existed in Open\n\n";
            rtxtMaGia.SelectionColor = Color.Green;
            rtxtMaGia.SelectedText = "   Step 3: Select minimum edge NQ in Open\n\n";
            rtxtMaGia.SelectionColor = Color.DimGray;
            rtxtMaGia.SelectedText = "   Step 4: If Q existed in Close, drop NQ out of Open, roll back to Step 3\n\n";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "   Step 5: g = g + w(N,Q)\n\n";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = "   Step 6: If Q not in Close, Add Q";
        }
        void SourceBFS()
        {
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectedText = "function bfs(v1,v2): \n";
            rtxtMaGia.SelectionColor = Color.Brown;
            rtxtMaGia.SelectedText = "\tqueue:= {v1} \n";
            rtxtMaGia.SelectedText = "\tmark v1 as visited \n\n";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "while queue is not empty:\n";
            rtxtMaGia.SelectedText = "\t v:= queue.removeFist()\n";
            rtxtMaGia.SelectedText = "\t if v is v2: \n";
            rtxtMaGia.SelectedText = "\t\t a pathisis found\n\n";
            rtxtMaGia.SelectionColor = Color.Green;
            rtxtMaGia.SelectedText = "for each unvisited neighbor n of v: \n";
            rtxtMaGia.SelectedText = "\t mark n as visited\n";
            rtxtMaGia.SelectedText = "\t queue.addLast(n)";
        }
        void SourceDFS()
        {
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectionColor = Color.OrangeRed;
            rtxtMaGia.SelectedText = "DFS(G,u)\n";
            rtxtMaGia.SelectedText = "\t u.visited = true \n";
            rtxtMaGia.SelectedText = "\t for each v ∈ G.Adj[u]\n";
            rtxtMaGia.SelectedText = "\t\t if v.visited == false\n";
            rtxtMaGia.SelectedText = "\t\t\tDFS(G,v)\n\n";
            rtxtMaGia.SelectionColor = Color.DarkCyan;
            rtxtMaGia.SelectedText = "init(){\n";
            rtxtMaGia.SelectedText = "\tFor each u ∈ G\n";
            rtxtMaGia.SelectedText = "\t\t u.visited = false\n";
            rtxtMaGia.SelectedText = "\tFor each u ∈ G\n";
            rtxtMaGia.SelectedText = "\t\t DFS(G,u)";
        }
        void SourceLienThong()
        {
            rtxtMaGia.Text = "";
            rtxtMaGia.SelectionColor = Color.Purple;
            rtxtMaGia.SelectedText = "traverse(u,visited)\n";
            rtxtMaGia.SelectedText = "Begin\n";
            rtxtMaGia.SelectedText = "\tmark u as visited\n";
            rtxtMaGia.SelectedText = "\tfor all vertex v, if it is adjacent with u, do\n";
            rtxtMaGia.SelectedText = "\t\tif v is not visited, then\n";
            rtxtMaGia.SelectedText = "\t\t\ttraverse(v, visited)\n";
            rtxtMaGia.SelectedText = "\tdone\n";
            rtxtMaGia.SelectedText = "End\n\n";
            rtxtMaGia.SelectionColor = Color.YellowGreen;
            rtxtMaGia.SelectedText = "isConnected(graph)\n";
            rtxtMaGia.SelectedText = "Begin\n";
            rtxtMaGia.SelectedText = "\tdefine visited array\n";
            rtxtMaGia.SelectedText = "\t\tfor all vertices u in the graph, do\n";
            rtxtMaGia.SelectedText = "\t\t make all nodes unvisited\n";
            rtxtMaGia.SelectedText = "\t\t traverse(u, visited)\n";
            rtxtMaGia.SelectedText = "\t\t if any unvisited node is still remaining, then\n";
            rtxtMaGia.SelectedText = "\t\t\t return false\n";
            rtxtMaGia.SelectedText = "\t\tdone\n";
            rtxtMaGia.SelectedText = "\treturn true\n";
            rtxtMaGia.SelectedText = "End";
        }
        #endregion
        #region VeBang
        private void pbBang_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            SolidBrush MauTrang = new SolidBrush(Color.White);
            SolidBrush MauXanhLa = new SolidBrush(Color.GreenYellow);
            SolidBrush MauDen = new SolidBrush(Color.Black);
            SolidBrush MauDo = new SolidBrush(Color.Red);
            SolidBrush br_MauTrang = new SolidBrush(Color.White);
            SolidBrush[] arr_Br = { new SolidBrush(Color.Aqua), new SolidBrush(Color.Orange), new SolidBrush(Color.Green), new SolidBrush(Color.Purple), new SolidBrush(Color.DarkRed), new SolidBrush(Color.Pink), new SolidBrush(Color.Red), new SolidBrush(Color.Yellow) };
            Pen[] arr_Pen = { new Pen(Color.Aqua, 2), new Pen(Color.Orange, 2), new Pen(Color.Green, 2), new Pen(Color.Purple, 2), new Pen(Color.DarkRed, 2), new Pen(Color.Pink, 2), new Pen(Color.Red, 2), new Pen(Color.Yellow, 2) };
            Pen pen_Black = new Pen(Color.Black, 2);
            Pen pen_Red = new Pen(Color.Red, 2);

            lbDSCanh.Items.Clear();
            #region VeDoThi
            // vẽ cạnh
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                for (int j = 0; j < n_Point_Dinh; ++j)
                {
                    if (maTran[i, j] != 0)
                    {
                        if (kiem_Tra_Do_Thi_Vo_Huong() && j > i) //maTran[i, j] != 0 && maTran[i, j] == maTran[j, i])
                        {
                            g.FillEllipse(br_MauTrang, (point_Dinh[i].X + point_Dinh[j].X) / 2 - 10, (point_Dinh[i].Y + point_Dinh[j].Y) / 2 - 10, 20, 20);
                            g.DrawString(maTran[i, j].ToString(), Font, MauDo, (point_Dinh[i].X + point_Dinh[j].X) / 2 - 5, (point_Dinh[i].Y + point_Dinh[j].Y) / 2 - 5);
                            g.DrawLine(pen_Black, point_Dinh[i], point_Dinh[j]);                           
                            lbDSCanh.Items.Add(i.ToString() + "-" + j.ToString());
                        }
                    }
                    if (maTran[i, j] != 0)
                    {
                        if (!kiem_Tra_Do_Thi_Vo_Huong())
                        {
                            g.DrawLine(pen_Black, point_Dinh[i], point_Dinh[j]);
                            //  AdjustableArrowCap arrowSize = new AdjustableArrowCap(7, 7);// ve do thi co huong
                            pen_Black.EndCap = LineCap.ArrowAnchor;
                            pen_Black.CustomEndCap = arrowSize;
                            lbDSCanh.Items.Add(i.ToString() + "-" + j.ToString());
                        }
                        g.DrawLine(pen_Black, point_Dinh[i], point_Dinh[j]);
                    }
                }
            }
            lbDSDinh.Items.Clear();
            // vẽ đỉnh
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                g.FillEllipse(MauXanhLa, point_Dinh[i].X - 10, point_Dinh[i].Y - 10, 20, 20);
                g.DrawString((i).ToString(), Font, MauTrang, point_Dinh[i].X - 5, point_Dinh[i].Y - 5);
                lbDSDinh.Items.Add("Đỉnh" + i.ToString());
            }
            // làm lại ma trận
            txtMaTran.Text = n_Point_Dinh.ToString() + "\r\n";
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                for (int j = 0; j < n_Point_Dinh; ++j)
                {
                    if (j != 0) txtMaTran.Text += " ";
                    txtMaTran.Text += maTran[i, j].ToString();
                }
                if (i != n_Point_Dinh - 1) txtMaTran.Text += "\r\n";
            }
            #endregion
            #region ChucNang
            #region TPLT   
            if (Dothi.nTPLT != 0)
            {
                if (kiem_Tra_Do_Thi_Vo_Huong())
                {
                    for (int i = 1; i <= Dothi.nTPLT; ++i)
                    {
                        int dem = 0;
                        for (int j = 0; j < Dothi.sodinh; ++j)
                        {
                            if (Dothi.visited[j] == i)
                            {

                                if (dem == 0)// trường hợp thành phần liên thông có 1 đỉnh
                                {
                                    // temp = j;
                                    dem = 1;
                                    g.FillEllipse(arr_Br[i - 1], point_Dinh[j].X - 10, point_Dinh[j].Y - 10, 20, 20);
                                    g.DrawString((j).ToString(), Font, MauTrang, point_Dinh[j].X - 5, point_Dinh[j].Y - 5);
                                }
                                else if (dem == 1)
                                {
                                    for (int ii = 0; ii < n_Point_Dinh; ++ii)
                                    {
                                        if (maTran[j, ii] != 0)
                                        {
                                            g.DrawLine(arr_Pen[i - 1], point_Dinh[ii], point_Dinh[j]);
                                            g.FillEllipse(arr_Br[i - 1], point_Dinh[ii].X - 10, point_Dinh[ii].Y - 10, 20, 20);
                                            g.FillEllipse(arr_Br[i - 1], point_Dinh[j].X - 10, point_Dinh[j].Y - 10, 20, 20);
                                            g.FillEllipse(br_MauTrang, (point_Dinh[ii].X + point_Dinh[j].X) / 2 - 10, (point_Dinh[ii].Y + point_Dinh[j].Y) / 2 - 10, 20, 20);
                                            g.DrawString((ii).ToString(), Font, MauTrang, point_Dinh[ii].X - 5, point_Dinh[ii].Y - 5);
                                            g.DrawString((j).ToString(), Font, MauTrang, point_Dinh[j].X - 5, point_Dinh[j].Y - 5);
                                            g.DrawString((maTran[ii, j]).ToString(), Font, MauDo, (point_Dinh[ii].X + point_Dinh[j].X) / 2 - 5, (point_Dinh[ii].Y + point_Dinh[j].Y) / 2 - 5);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    ChuyenDoiCHSangVH();
                    for (int i = 1; i <= Dothi.nTPLT; ++i)
                    {
                        arr_Pen[i - 1].EndCap = LineCap.ArrowAnchor;
                        arr_Pen[i - 1].CustomEndCap = arrowSize;
                        int dem = 0;
                        for (int j = 0; j < n_Point_Dinh; ++j)
                        {

                            if (Dothi.visited[j] == i)
                            {
                                if (dem == 0)// trường hợp thành phần liên thông có 1 đỉnh
                                {
                                    // temp = j;
                                    dem = 1;
                                    g.FillEllipse(arr_Br[i - 1], point_Dinh[j].X - 10, point_Dinh[j].Y - 10, 20, 20);
                                    g.DrawString((j).ToString(), Font, MauTrang, point_Dinh[j].X - 5, point_Dinh[j].Y - 5);
                                }
                                else if (dem == 1)
                                {
                                    for (int ii = 0; ii < n_Point_Dinh; ii++)
                                    {
                                        //arr_Pen[i - 1].EndCap = LineCap.ArrowAnchor;
                                        //arr_Pen[i - 1].CustomEndCap = arrowSize;
                                        if (savematrix[j, ii] != 0)
                                        {
                                            g.DrawLine(arr_Pen[i - 1], point_Dinh[ii], point_Dinh[j]);
                                            g.FillEllipse(arr_Br[i - 1], point_Dinh[ii].X - 10, point_Dinh[ii].Y - 10, 20, 20);
                                            g.FillEllipse(arr_Br[i - 1], point_Dinh[j].X - 10, point_Dinh[j].Y - 10, 20, 20);
                                            g.FillEllipse(br_MauTrang, (point_Dinh[ii].X + point_Dinh[j].X) / 2 - 10, (point_Dinh[ii].Y + point_Dinh[j].Y) / 2 - 10, 20, 20);
                                            g.DrawString((ii).ToString(), Font, MauTrang, point_Dinh[ii].X - 5, point_Dinh[ii].Y - 5);
                                            g.DrawString((j).ToString(), Font, MauTrang, point_Dinh[j].X - 5, point_Dinh[j].Y - 5);
                                            g.DrawString((maTran[ii, j]).ToString(), Font, MauDo, (point_Dinh[ii].X + point_Dinh[j].X) / 2 - 5, (point_Dinh[ii].Y + point_Dinh[j].Y) / 2 - 5);
                                            //arr_Pen[i - 1].EndCap = LineCap.ArrowAnchor;
                                            //arr_Pen[i - 1].CustomEndCap = arrowSize;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    //txtKetQua.Text = n_Point_Dinh.ToString() + "\r\n";
                    //for (int i = 0; i < n_Point_Dinh; ++i)
                    //{
                    //    for (int j = 0; j < n_Point_Dinh; ++j)
                    //    {
                    //        if (j != 0) txtKetQua.Text += " ";
                    //        txtKetQua.Text += savematrix[i, j].ToString();
                    //    }
                    //    if (i != n_Point_Dinh - 1) txtKetQua.Text += "\r\n";
                    //}
                }
                Dothi.nTPLT = 0;
            }
            #endregion
            #region DFS
            if (Dothi.kqDFS.Count() != 0)
            {
                if (kiem_Tra_Do_Thi_Vo_Huong())
                {
                    int demm = 1;// 
                    for (int i = 0; i < Dothi.kqDFS.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i]].X - 10, point_Dinh[Dothi.kqDFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqDFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i]].X - 5, point_Dinh[Dothi.kqDFS[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqDFS[i - 1]], point_Dinh[Dothi.kqDFS[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i - 1]].X - 10, point_Dinh[Dothi.kqDFS[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i]].X - 10, point_Dinh[Dothi.kqDFS[i]].Y - 10, 20, 20);
                            g.FillEllipse(br_MauTrang, (point_Dinh[Dothi.kqDFS[i - 1]].X + point_Dinh[Dothi.kqDFS[i]].X) / 2 - 10, (point_Dinh[Dothi.kqDFS[i - 1]].Y + point_Dinh[Dothi.kqDFS[i]].Y) / 2 - 10, 20, 20);
                            g.DrawString((Dothi.kqDFS[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i - 1]].X - 5, point_Dinh[Dothi.kqDFS[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqDFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i]].X - 5, point_Dinh[Dothi.kqDFS[i]].Y - 5);
                            g.DrawString(maTran[Dothi.kqDFS[i - 1], Dothi.kqDFS[i]].ToString(), Font, MauDo, (point_Dinh[Dothi.kqDFS[i - 1]].X + point_Dinh[Dothi.kqDFS[i]].X) / 2 - 5, (point_Dinh[Dothi.kqDFS[i - 1]].Y + point_Dinh[Dothi.kqDFS[i]].Y) / 2 - 5);
                        }
                    }
                    Dothi.kqDFS.Clear();
                    pbBang.Refresh();
                }
                else
                {
                    int demm = 1;// 
                    for (int i = 0; i < Dothi.kqDFS.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i]].X - 10, point_Dinh[Dothi.kqDFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqDFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i]].X - 5, point_Dinh[Dothi.kqDFS[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            pen_Red.StartCap = LineCap.ArrowAnchor;
                            pen_Red.CustomStartCap = arrowSize;
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqDFS[i - 1]], point_Dinh[Dothi.kqDFS[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i - 1]].X - 10, point_Dinh[Dothi.kqDFS[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqDFS[i]].X - 10, point_Dinh[Dothi.kqDFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqDFS[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i - 1]].X - 5, point_Dinh[Dothi.kqDFS[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqDFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqDFS[i]].X - 5, point_Dinh[Dothi.kqDFS[i]].Y - 5);
                        }
                    }
                    Dothi.kqDFS.Clear();
                    pbBang.Refresh();

                }
            }
            #endregion
            #region BFS
            if (Dothi.kqBFS.Count() != 0)
            {
                if (kiem_Tra_Do_Thi_Vo_Huong())
                {
                    int demm = 1;
                    for (int i = 0; i < Dothi.kqBFS.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i]].X - 10, point_Dinh[Dothi.kqBFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqBFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i]].X - 5, point_Dinh[Dothi.kqBFS[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqBFS[i - 1]], point_Dinh[Dothi.kqBFS[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i - 1]].X - 10, point_Dinh[Dothi.kqBFS[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i]].X - 10, point_Dinh[Dothi.kqBFS[i]].Y - 10, 20, 20);
                            g.FillEllipse(br_MauTrang, (point_Dinh[Dothi.kqBFS[i - 1]].X + point_Dinh[Dothi.kqBFS[i]].X) / 2 - 10, (point_Dinh[Dothi.kqBFS[i - 1]].Y + point_Dinh[Dothi.kqBFS[i]].Y) / 2 - 10, 20, 20); 
                            g.DrawString((Dothi.kqBFS[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i - 1]].X - 5, point_Dinh[Dothi.kqBFS[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqBFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i]].X - 5, point_Dinh[Dothi.kqBFS[i]].Y - 5);
                            g.DrawString(maTran[Dothi.kqBFS[i - 1], Dothi.kqBFS[i]].ToString(), Font, MauDo, (point_Dinh[Dothi.kqBFS[i - 1]].X + point_Dinh[Dothi.kqBFS[i]].X) / 2 - 5, (point_Dinh[Dothi.kqBFS[i - 1]].Y + point_Dinh[Dothi.kqBFS[i]].Y) / 2 - 5);
                        }
                    }
                    Dothi.kqBFS.Clear();
                    pbBang.Refresh();
                }
                else
                {
                    int demm = 1;// 
                    for (int i = 0; i < Dothi.kqBFS.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i]].X - 10, point_Dinh[Dothi.kqBFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqBFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i]].X - 5, point_Dinh[Dothi.kqBFS[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            pen_Red.StartCap = LineCap.ArrowAnchor;
                            pen_Red.CustomStartCap = arrowSize;
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqBFS[i - 1]], point_Dinh[Dothi.kqBFS[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i - 1]].X - 10, point_Dinh[Dothi.kqBFS[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqBFS[i]].X - 10, point_Dinh[Dothi.kqBFS[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqBFS[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i - 1]].X - 5, point_Dinh[Dothi.kqBFS[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqBFS[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqBFS[i]].X - 5, point_Dinh[Dothi.kqBFS[i]].Y - 5);
                        }
                    }
                    Dothi.kqBFS.Clear();
                    pbBang.Refresh();
                }
            }
            #endregion
            #region Kruskal
            if (Dothi.kqKruskal.Count() != 0)
            {
                if (kiem_Tra_Do_Thi_Vo_Huong())
                {
                    int demm = 1;
                    for (int i = 0; i < Dothi.kqKruskal.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i]].X - 10, point_Dinh[Dothi.kqKruskal[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqKruskal[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i]].X - 5, point_Dinh[Dothi.kqKruskal[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqKruskal[i - 1]], point_Dinh[Dothi.kqKruskal[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i - 1]].X - 10, point_Dinh[Dothi.kqKruskal[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i]].X - 10, point_Dinh[Dothi.kqKruskal[i]].Y - 10, 20, 20);
                            g.FillEllipse(br_MauTrang, (point_Dinh[Dothi.kqKruskal[i - 1]].X + point_Dinh[Dothi.kqKruskal[i]].X) / 2 - 10, (point_Dinh[Dothi.kqKruskal[i - 1]].Y + point_Dinh[Dothi.kqKruskal[i]].Y) / 2 - 10, 20, 20);
                            g.DrawString((Dothi.kqKruskal[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i - 1]].X - 5, point_Dinh[Dothi.kqKruskal[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqKruskal[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i]].X - 5, point_Dinh[Dothi.kqKruskal[i]].Y - 5);
                            g.DrawString(maTran[Dothi.kqKruskal[i - 1], Dothi.kqKruskal[i]].ToString(), Font, MauDo, (point_Dinh[Dothi.kqKruskal[i - 1]].X + point_Dinh[Dothi.kqKruskal[i]].X) / 2 - 5, (point_Dinh[Dothi.kqKruskal[i - 1]].Y + point_Dinh[Dothi.kqKruskal[i]].Y) / 2 - 5);
                        }
                    }
                    Dothi.kqKruskal.Clear();
                    pbBang.Refresh();
                }
                else
                {
                    int demm = 1;// 
                    for (int i = 0; i < Dothi.kqKruskal.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i]].X - 10, point_Dinh[Dothi.kqKruskal[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqKruskal[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i]].X - 5, point_Dinh[Dothi.kqKruskal[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            pen_Red.StartCap = LineCap.ArrowAnchor;
                            pen_Red.CustomStartCap = arrowSize;
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqKruskal[i - 1]], point_Dinh[Dothi.kqKruskal[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i - 1]].X - 10, point_Dinh[Dothi.kqKruskal[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqKruskal[i]].X - 10, point_Dinh[Dothi.kqKruskal[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqKruskal[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i - 1]].X - 5, point_Dinh[Dothi.kqKruskal[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqKruskal[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqKruskal[i]].X - 5, point_Dinh[Dothi.kqKruskal[i]].Y - 5);
                        }
                    }
                    Dothi.kqKruskal.Clear();
                    pbBang.Refresh();
                }
            }
            #endregion
            #region Prim
            if (Dothi.kqPrim.Count() != 0)
            {
                if (kiem_Tra_Do_Thi_Vo_Huong())
                {
                    int demm = 1;
                    for (int i = 0; i < Dothi.kqPrim.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i]].X - 10, point_Dinh[Dothi.kqPrim[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqPrim[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i]].X - 5, point_Dinh[Dothi.kqPrim[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqPrim[i - 1]], point_Dinh[Dothi.kqPrim[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i - 1]].X - 10, point_Dinh[Dothi.kqPrim[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i]].X - 10, point_Dinh[Dothi.kqPrim[i]].Y - 10, 20, 20);
                            g.FillEllipse(br_MauTrang, (point_Dinh[Dothi.kqPrim[i - 1]].X + point_Dinh[Dothi.kqPrim[i]].X) / 2 - 10, (point_Dinh[Dothi.kqPrim[i - 1]].Y + point_Dinh[Dothi.kqPrim[i]].Y) / 2 - 10, 20, 20);
                            g.DrawString((Dothi.kqPrim[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i - 1]].X - 5, point_Dinh[Dothi.kqPrim[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqPrim[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i]].X - 5, point_Dinh[Dothi.kqPrim[i]].Y - 5);
                            g.DrawString(maTran[Dothi.kqPrim[i - 1], Dothi.kqPrim[i]].ToString(), Font, MauDo, (point_Dinh[Dothi.kqPrim[i - 1]].X + point_Dinh[Dothi.kqPrim[i]].X) / 2 - 5, (point_Dinh[Dothi.kqPrim[i - 1]].Y + point_Dinh[Dothi.kqPrim[i]].Y) / 2 - 5);
                        }
                    }
                    Dothi.kqPrim.Clear();
                    pbBang.Refresh();
                }
                else
                {
                    int demm = 1;// 
                    for (int i = 0; i < Dothi.kqPrim.Count(); ++i)
                    {
                        if (demm == 1)
                        {
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i]].X - 10, point_Dinh[Dothi.kqPrim[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqPrim[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i]].X - 5, point_Dinh[Dothi.kqPrim[i]].Y - 5);
                            demm = 2;
                        }
                        else
                        {
                            pen_Red.StartCap = LineCap.ArrowAnchor;
                            pen_Red.CustomStartCap = arrowSize;
                            g.DrawLine(pen_Red, point_Dinh[Dothi.kqPrim[i - 1]], point_Dinh[Dothi.kqPrim[i]]);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i - 1]].X - 10, point_Dinh[Dothi.kqPrim[i - 1]].Y - 10, 20, 20);
                            g.FillEllipse(MauDo, point_Dinh[Dothi.kqPrim[i]].X - 10, point_Dinh[Dothi.kqPrim[i]].Y - 10, 20, 20);
                            g.DrawString((Dothi.kqPrim[i - 1]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i - 1]].X - 5, point_Dinh[Dothi.kqPrim[i - 1]].Y - 5);
                            g.DrawString((Dothi.kqPrim[i]).ToString(), Font, MauTrang, point_Dinh[Dothi.kqPrim[i]].X - 5, point_Dinh[Dothi.kqPrim[i]].Y - 5);
                        }
                    }
                    Dothi.kqPrim.Clear();
                    pbBang.Refresh();
                }
            }
            #endregion
            #region Dijkstra & Ford Bellman
            if (Dothi.id != 0)
            {
                txtKetQua.Text = string.Empty;
                for (int i = Dothi.id; i >= 0; --i)
                {
                    if (i == Dothi.id)
                    {
                       txtKetQua.Text += (Dothi.duongDi[i]).ToString();

                        g.FillEllipse(MauDo, point_Dinh[Dothi.duongDi[i]].X - 10, point_Dinh[Dothi.duongDi[i]].Y - 10, 20, 20);
                        g.DrawString((Dothi.duongDi[i]).ToString(), Font, br_MauTrang, point_Dinh[Dothi.duongDi[i]].X - 5, point_Dinh[Dothi.duongDi[i]].Y - 5);

                    }
                    else
                    {
                        txtKetQua.Text += " ---> " + (Dothi.duongDi[i]).ToString();

                        g.DrawLine(pen_Red, point_Dinh[Dothi.duongDi[i + 1]], point_Dinh[Dothi.duongDi[i]]);
                        g.FillEllipse(MauDo, point_Dinh[Dothi.duongDi[i + 1]].X - 10, point_Dinh[Dothi.duongDi[i + 1]].Y - 10, 20, 20);
                        g.FillEllipse(MauDo, point_Dinh[Dothi.duongDi[i]].X - 10, point_Dinh[Dothi.duongDi[i]].Y - 10, 20, 20);

                        g.DrawString((Dothi.duongDi[i]).ToString(), Font, br_MauTrang, point_Dinh[Dothi.duongDi[i]].X - 5, point_Dinh[Dothi.duongDi[i]].Y - 5);
                        g.DrawString((Dothi.duongDi[i + 1] ).ToString(), Font, br_MauTrang, point_Dinh[Dothi.duongDi[i + 1]].X - 5, point_Dinh[Dothi.duongDi[i + 1]].Y - 5);


                        g.FillEllipse(br_MauTrang, (point_Dinh[Dothi.duongDi[i + 1]].X + point_Dinh[Dothi.duongDi[i]].X) / 2 - 10, (point_Dinh[Dothi.duongDi[i + 1]].Y + point_Dinh[Dothi.duongDi[i]].Y) / 2 - 10, 20, 20);
                        g.DrawString(maTran[Dothi.duongDi[i], Dothi.duongDi[i + 1]].ToString(), Font, MauDen, (point_Dinh[Dothi.duongDi[i + 1]].X + point_Dinh[Dothi.duongDi[i]].X) / 2 - 5, (point_Dinh[Dothi.duongDi[i + 1]].Y + point_Dinh[Dothi.duongDi[i]].Y) / 2 - 5);

                    }
                }
                Dothi.id = 0;
            }

            #endregion
            #endregion
        }
        #endregion
        #region cbo Chuc năng
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            btnDuyet.Text = cbxChucNang.Text;
            pbBang.Controls.Clear();
            pbBang.Invalidate();
            pbBang.Refresh();
            if(cbxChucNang.Text == "Kruskal")
            {
                SourceKruskal();
            }    
            else if(cbxChucNang.Text == "Duyệt DFS")
            {
                SourceDFS();
            }    
            else if(cbxChucNang.Text == "Duyệt BFS")
            {
                SourceBFS();
            }    
            else if(cbxChucNang.Text == "Prim")
            {
                SourcePrim();
            }    
            else if(cbxChucNang.Text == "Dijkstra" || cbxChucNang.Text == "Ford Bellman")
            {
                SourceDijsktra();
            }    
            else if(cbxChucNang.Text == "Xét liên thông")
            {
                SourceLienThong();
            }    
            if(cbxChucNang.Text == "Xét liên thông")
            {
                pnlCayKhung.Enabled = false;
                pnlDinh.Enabled = false;
            }    
            if(cbxChucNang.Text == "Kruskal" || cbxChucNang.Text == "Prim")
            {
                pnlCayKhung.Enabled = true;
                pnlDinh.Enabled = false;
            }    
            else if(cbxChucNang.Text == "Dijkstra" || cbxChucNang.Text == "Ford Bellman" || cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Duyệt BFS")
            {
                pnlCayKhung.Enabled = false;
                pnlDinh.Enabled = true;
            }    
        }
        #endregion
        #region ButtonDuyet
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (cbxChucNang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Dothi.readGRAPH(maTran, n_Point_Dinh);
            if (btnDuyet.Text == "Xét liên thông")
            {
                TPLT = Dothi.thanhPhanLienThong();
                string showLT = string.Empty;
                if (TPLT[0] == "0")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (TPLT[0] == "1")
                {
                    for (int i = 1; i < TPLT.Length; i++)
                    {
                        showLT += "Thành Phần Liên Thông Duy Nhất: " + TPLT[i] + Environment.NewLine;
                    }
                }
                else
                {
                    for (int i = 0; i < TPLT.Length; i++)
                    {
                        if (i == 0)
                        {
                            showLT += "Số Thành Phần Liên Thông: " + TPLT[0] + Environment.NewLine;
                        }
                        else
                        {
                            showLT += "Thành Phần Liên Thông Thứ " + i.ToString() + ": " + TPLT[i] + Environment.NewLine;
                        }
                    }
                }
                if (Convert.ToInt32(TPLT[0]) == 1)
                {
                    showLT += "Đồ Thị Liên Thông" + Environment.NewLine;
                }
                else
                {
                    showLT += "Đồ Thị Không Liên Thông" + Environment.NewLine;
                }
                txtKetQua.Text = showLT;
                pbBang.Refresh();
            }
            else if (btnDuyet.Text == "Duyệt BFS")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dothi.duyetBFS(Convert.ToInt32(cbxDinhBatDau.Text), Convert.ToInt32(cbxDinhKetThuc.Text));
                    if (Dothi.kqBFS.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = Dothi.kqBFS.Count() - 1; i >= 0; i--)
                        {
                            if (i != 0)
                            {
                                trave += Dothi.kqBFS[i].ToString() + "-->";
                            }
                            else
                            {
                                trave += Dothi.kqBFS[i].ToString();
                            }
                        }
                        txtKetQua.Text = trave;
                        pbBang.Refresh();
                    }
                }
            }
            else if (btnDuyet.Text == "Duyệt DFS")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Dothi.duyetDFS(Convert.ToInt32(cbxDinhBatDau.Text), Convert.ToInt32(cbxDinhKetThuc.Text));
                    if (Dothi.kqDFS.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = Dothi.kqDFS.Count() - 1; i >= 0; i--)
                        {
                            if (i != 0)
                            {
                                trave += Dothi.kqDFS[i].ToString() + "-->";
                            }
                            else
                            {
                                trave += Dothi.kqDFS[i].ToString();
                            }
                        }
                        txtKetQua.Text = trave;
                        pbBang.Refresh();
                    }
                }
            }
            else if (btnDuyet.Text == "Kruskal" && cboCayKhung.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa chọn cây khung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (btnDuyet.Text == "Kruskal" && cboCayKhung.Text == "Nhỏ nhất")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Kruskal = Dothi.KruskalMin();
                    if (Dothi.kqKruskal.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = 0; i <  Kruskal.Length; i = i + 2)
                        {
                            if (i == Kruskal.Length - 2)
                            {
                                trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")";
                            }
                            else trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")" + ",";
                        }
                        txtKetQua.Text = "Cây khung tối thiểu tìm được theo thuật toán Kruskal là: ";
                        txtKetQua.Text += trave;
                        txtKetQua.Text += Environment.NewLine + "Tổng trọng lượng cây khung nhỏ nhất: " + Dothi.TrongSoKruscal.ToString();
                        MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pbBang.Refresh();
                    }
                }
            }
            else if(btnDuyet.Text == "Kruskal" && cboCayKhung.Text == "Lớn nhất")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Kruskal = Dothi.KruskalMax();
                    if (Dothi.kqKruskal.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = 0; i < Kruskal.Length; i = i + 2)
                        {
                            if (i == Kruskal.Length - 2)
                            {
                                trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")";
                            }
                            else trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")" + ",";
                        }
                        txtKetQua.Text = "Cây khung tối đại tìm được theo thuật toán Kruskal là: ";
                        txtKetQua.Text += trave;
                        txtKetQua.Text += Environment.NewLine + "Tổng trọng lượng cây khung lớn nhất: " + Dothi.TrongSoKruscal.ToString();
                        MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pbBang.Refresh();
                    }
                }
            }
            else if (btnDuyet.Text == "Prim" && cboCayKhung.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa chọn cây khung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (btnDuyet.Text == "Prim" && cboCayKhung.Text == "Nhỏ nhất")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Prim = Dothi.PrimMin();
                    if (Dothi.kqPrim.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = 0; i < Prim.Length; i = i + 2)
                        {
                            if (i == Prim.Length - 2)
                            {
                                trave += "(" + Prim[i] + "," + Prim[i + 1] + ")";
                            }
                            else trave += "(" + Prim[i] + "," + Prim[i + 1] + ")" + ",";
                        }
                        txtKetQua.Text = "Cây khung tối thiểu tìm được theo thuật toán Prim là: ";
                        txtKetQua.Text += trave;
                        txtKetQua.Text += Environment.NewLine + "Tổng trọng lượng cây khung nhỏ nhất: " + Dothi.TrongSoPrim.ToString();
                        MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pbBang.Refresh();
                    }
                }
            }
            else if (btnDuyet.Text == "Prim" && cboCayKhung.Text == "Lớn nhất")
            {
                if (txtMaTran.Text == "0\r\n")
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Prim = Dothi.PrimMax();
                    if (Dothi.kqPrim.Count() == 0)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        string trave = "";
                        for (int i = 0; i < Prim.Length; i = i + 2)
                        {
                            if (i == Prim.Length - 2)
                            {
                                trave += "(" + Prim[i] + "," + Prim[i + 1] + ")";
                            }
                            else trave += "(" + Prim[i] + "," + Prim[i + 1] + ")" + ",";
                        }
                        txtKetQua.Text = "Cây khung tối đại tìm được theo thuật toán Prim là: ";
                        txtKetQua.Text += trave;
                        txtKetQua.Text += Environment.NewLine + "Tổng trọng lượng cây khung lớn nhất: " + Dothi.TrongSoPrim.ToString();
                        MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pbBang.Refresh();
                    }
                }
            }
            else if(btnDuyet.Text == "Dijkstra")
            {
                Dothi.dijkstra(int.Parse(cbxDinhBatDau.Text), int.Parse (cbxDinhKetThuc.Text));
                Dothi.xuat(int.Parse(cbxDinhBatDau.Text), int.Parse(cbxDinhKetThuc.Text));
                pbBang.Refresh();
            }
            else if(btnDuyet.Text == "Ford Bellman")
            {
                Dothi.fordBellman(int.Parse(cbxDinhBatDau.Text), int.Parse(cbxDinhKetThuc.Text));
                Dothi.xuat(int.Parse(cbxDinhBatDau.Text), int.Parse(cbxDinhKetThuc.Text));
                pbBang.Refresh();
            }
        }
        #endregion
        #region Button Lam Moi
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn chắc muốn làm mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (res == DialogResult.Yes)
            {
                for (int i = 0; i < n_Point_Dinh; i++)
                {
                    for (int j = 0; j < n_Point_Dinh; j++)
                    {
                        maTran[i, j] = 0;
                    }
                }
                txtMaTran.Text = string.Empty;
                txtKetQua.Text = string.Empty;
                n_Point_Dinh = 0;
                duong_Dan = "";
                pbBang.Controls.Clear();
                pbBang.Invalidate();
                cbxChucNang.SelectedIndex = -1;
                cbxDinhBatDau.DataSource = null;
                cbxDinhKetThuc.DataSource = null;
                pbBang.Refresh();
                btnDuyet.Text = "Duyệt";
                rtxtMaGia.Text = String.Empty;
                txtDuongDan.Text = String.Empty;
            }
        }
        #endregion
        private void label4_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
        #region ButtonXoaDinh
        private void btnXoaDinh_Click(object sender, EventArgs e)
        {
            int index = -1;
            string str = "";
            foreach (string item in lbDSDinh.SelectedItems)
            {
                str = item;
            }
            index = lbDSDinh.Items.IndexOf(str);
            lbDSDinh.Items.Remove(str);
            if (index != -1)
            {
                for (int i = index; i < n_Point_Dinh - 1; i++)
                {
                    point_Dinh[i] = point_Dinh[i + 1];
                }

                for (int i = index; i < n_Point_Dinh; i++)
                {
                    for (int j = 0; j < n_Point_Dinh; j++)
                    {
                        if (i != j)
                        {
                            maTran[i, j] = maTran[i + 1, j];
                            maTran[j, i] = maTran[j, i + 1];
                        }
                    }
                }
                n_Point_Dinh--;
                pbBang.Refresh();
            }
            LoadComBoBoxDinhBatDau();
            LoadComBoBoxDinhKetThuc();
        }
        #endregion
        #region ButtonXoaCanh
        private void btnXoaCanh_Click(object sender, EventArgs e)
        {
            string str = "";
            string dinhDau_Str = "";
            string dinhCuoi_Str = "";
            int dinhDau = 0, dinhCuoi = 0;
            foreach (string item in lbDSCanh.SelectedItems)
            {
                str = item;
            }
            if (str != "")
            {
                int dem = 1;
                for (int i = 0; i < str.Length; ++i)
                {
                    if (str[i] == '-')
                    {
                        ++dem;
                        continue;
                    }
                    if (dem == 1) dinhDau_Str += str[i];
                    if (dem == 2) dinhCuoi_Str += str[i];
                }
                bool check_DinhDau = int.TryParse(dinhDau_Str, out dinhDau);
                bool check_DinhCuoi = int.TryParse(dinhCuoi_Str, out dinhCuoi);
            }
            if (kiem_Tra_Do_Thi_Vo_Huong())
            {
                maTran[dinhDau, dinhCuoi] = 0;
                maTran[dinhCuoi, dinhDau] = 0;
            }
            else
            {
                maTran[dinhDau, dinhCuoi] = 0;
            }
            pbBang.Refresh();
        }
        #endregion
        #region KTKhoangCachDinh
        bool KTKhoangCachDinh(int x, int y)
        {
            for (int i = 0; i < n_Point_Dinh; i++)
            {
                float kc = (float)(Math.Sqrt(Math.Pow(x - point_Dinh[i].X, 2) + Math.Pow(y - point_Dinh[i].Y, 2)));
                if (kc < 40) return true;
            }
            return false;
        }
        #endregion
        #region ButtonThemDinh
        private void btnThemDinh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= n_Point_Dinh; i++)
            {
                maTran[n_Point_Dinh, i] = 0;
                maTran[i, n_Point_Dinh] = 0;
            }
            TaoViTriDinh(n_Point_Dinh);
            n_Point_Dinh++;
            pbBang.Refresh();
            LoadComBoBoxDinhKetThuc();
            LoadComBoBoxDinhBatDau();
        }
        #endregion
        #region TaoViTriDinh // random thêm đỉnh
        void TaoViTriDinh(int dem)
        {
            Random rnd = new Random();
            int randomX, randomY;
            while (true)
            {
                randomX = rnd.Next(12, 450);
                randomY = rnd.Next(20, 340);
                if (!KTKhoangCachDinh(randomX, randomY))// để không bị đè lên
                {
                    point_Dinh[dem] = new Point(randomX, randomY);
                    break;
                }
            }
        }
        #endregion
        #region ButtonThemCanh
        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            int DinhDau = 0, DinhCuoi = 0;
            if (kiem_Tra_Do_Thi_Vo_Huong())
            {
                if (cbxDinhBatDau.Text != String.Empty && cbxDinhKetThuc.Text != String.Empty)
                {
                    DinhDau = int.Parse(cbxDinhBatDau.Text);
                    DinhCuoi = int.Parse(cbxDinhKetThuc.Text);
                    if (DinhCuoi == DinhDau)
                    {
                        MessageBox.Show("Bạn nhập sai rồi. Cạnh đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txtTrongso.Text == String.Empty)
                        {
                            MessageBox.Show("Bạn chưa nhập trọng số cho cạnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);                       
                        }
                        else
                        {
                            maTran[DinhDau, DinhCuoi] = int.Parse(txtTrongso.Text);
                            maTran[DinhCuoi, DinhDau] = int.Parse(txtTrongso.Text);
                        }                       
                    }
                }
            }
            else
            {
                if (cbxDinhBatDau.Text != String.Empty && cbxDinhKetThuc.Text != String.Empty)
                {
                    DinhDau = int.Parse(cbxDinhBatDau.Text);
                    DinhCuoi = int.Parse(cbxDinhKetThuc.Text);
                    if (DinhCuoi == DinhDau)
                    {
                        MessageBox.Show("Bạn nhập sai rồi. Cạnh đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else maTran[DinhDau, DinhCuoi] = 1;
                    //maTran[DinhCuoi, DinhDau] = 1;
                }
            }
            pbBang.Refresh();
        }
        #endregion
        #region Button TaoMaTranNgauNhien
        private void btnTaoMaTran_Click(object sender, EventArgs e)
        {
            frmTaoMaTranNgauNhien tmt = new frmTaoMaTranNgauNhien();
            tmt.ShowDialog();
            n_Point_Dinh = tmt.sodinh;
            maTran = tmt.matran;
            txtMaTran.Text = n_Point_Dinh.ToString() + "\r\n";
            for (int i = 0; i < n_Point_Dinh; ++i)
            {
                for (int j = 0; j < n_Point_Dinh; ++j)
                {
                    if (j != 0) txtMaTran.Text += " ";
                    txtMaTran.Text += maTran[i, j].ToString();
                }
                if (i != n_Point_Dinh - 1) txtMaTran.Text += "\r\n";// để xuống dòng
            }
        }
        #endregion
        private void cbxDinhBatDau_SelectedValueChanged(object sender, EventArgs e)
        {
            pbBang.Controls.Clear();
            pbBang.Invalidate();
            pbBang.Refresh();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboCayKhung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxDinhKetThuc_SelectedValueChanged(object sender, EventArgs e)
        {
            pbBang.Controls.Clear();
            pbBang.Invalidate();
            pbBang.Refresh();
        }
    }
}

