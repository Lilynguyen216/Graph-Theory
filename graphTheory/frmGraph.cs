using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace graphTheory
{
    public partial class frmGraph : Form
    {
        #region khai báo
        private bool haveEllipse = false;
        private IconButton currentBtn;
        private Panel rightBorderBtn;
        private Button btncreate = new Button();
        private bool Checkiconbtn = false;
        private int dx = 0, dy = 0, dx1 = 0, dy1 = 0;
        private int d1 = -1, d2 = -1;
        private int Dinh1 = -1, Dinh2 = -1;
        private Class_Graph.Egde Egdes = new Class_Graph.Egde();
        private List<Class_Graph.Egde> ListarrEgde = new List<Class_Graph.Egde> { };
        private bool CheckHuong = false;
        private Class_Graph.NodeGraph Nod = new Class_Graph.NodeGraph();
        private List<Class_Graph.NodeGraph> ListarrNod = new List<Class_Graph.NodeGraph> { };
        private int PtuxoaNod = -1;
        private int sodinh = 0;
        private int sodinhcheck = 0;
        public int[,] Matrix = new int[100, 100];
        private Class_Graph.FS_Graph Dothi = new Class_Graph.FS_Graph();
        private string FS = string.Empty;
        private string FS1 = string.Empty;
        private string Prim = string.Empty;
        private string Kruskal = string.Empty;
        private string Dijsktra = string.Empty;
        private string[] TPLT = new string[] { };
        private int i = 0;
        private int dem = 0;
        private List<Class_Graph.Egde> Egl = new List<Class_Graph.Egde> { };
        private List<Class_Graph.NodeGraph> LNodLT = new List<Class_Graph.NodeGraph> { };
        private Class_Graph.Egde Eg = new Class_Graph.Egde();
        private Class_Graph.NodeGraph NodLT = new Class_Graph.NodeGraph();
        private bool Xacnhan = false;
        private int socanh = 0;
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
        public frmGraph()
        {
            InitializeComponent();
            rightBorderBtn = new Panel();
            rightBorderBtn.Size = new Size(7, 42);
            panelClickSukien.Controls.Add(rightBorderBtn);
            btnThemCanh.Enabled = false;
            btnXoaCanh.Enabled = false;
            pnlCachDuyet.Enabled = false;
            pnlCayKhung.Enabled = false;
            pnlFS.Enabled = false;
        }
        private void ResetDTMau()
        {
            pnlVeDoThi.Invalidate();
            pnlVeDoThi.Refresh();
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                VeDoThi1(ListarrEgde[i]);
            }
            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
            {
                btn.BackColor = Color.YellowGreen;
            }
        }
        #region Lấy màu
        private Color[] a =
        {
            Color.FromArgb(51, 255, 153),
            Color.FromArgb(255, 255, 51),
            Color.FromArgb(102, 255, 255),
            Color.FromArgb(178, 102, 255),
            Color.FromArgb(255, 102, 178),
            Color.FromArgb(255, 153, 153),
        };
        #endregion
        #region LoadComboboxDinhBatDau
        private void LoadComBoBoxDinhBatDau()
        {
            int[] ArrVertex = new int[sodinh];
            for (int i = 0; i < sodinh; i++)
            {
                ArrVertex[i] = i;
            }
            cboBD.DataSource = ArrVertex;
        }
        #endregion
        #region LoadComboboxKetThuc
        private void LoadComBoBoxDinhKetThuc()
        {
            int[] ArrVertex = new int[sodinh];
            for (int i = 0; i < sodinh; i++)
            {
                ArrVertex[i] = i;
            }
            cboDinhKT.DataSource = ArrVertex;
        }
        #endregion
        #region Event
        #region 1. Thay Đổi Trạng Thái Button Thêm Đỉnh
        private void btnThemDinh_Click(object sender, EventArgs e)
        {
            if (Checkiconbtn == false)
            {
                ActivateButton(sender);
                Checkiconbtn = true;
            }
            else
            {
                DisableButton(sender);
                Checkiconbtn = false;
            }

        }
        #endregion
        #region 2. Thay Đổi Text Button Duyệt Theo Chức Năng
        private void cbxChucNang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxChucNang.Text == "Duyệt BFS" || cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Dijkstra")
            {
                pnlFS.Enabled = true;
                pnlCachDuyet.Enabled = true;
                pnlCayKhung.Enabled = false;
                btnDuyet.Padding = new Padding(50, 0, 40, 0);
            }
            else
            {
                btnDuyet.Padding = new Padding(40, 0, 40, 0);
                pnlCachDuyet.Enabled = false;
                pnlFS.Enabled = false;
            }
            if (cbxChucNang.Text == "Prim" || cbxChucNang.Text == "Kruskal" || cbxChucNang.Text == "Dijkstra" && (cbxChucNang.Text != "Duyệt BFS" || cbxChucNang.Text != "Duyệt DFS"))
            {
                pnlCachDuyet.Enabled = true;
                btnDuyet.Padding = new Padding(50, 0, 40, 0);
            }
            if (cbxChucNang.Text == "Kruskal" || cbxChucNang.Text == "Prim")
            {
                pnlCayKhung.Enabled = true;
            }    
            if(cbxChucNang.Text == "Kruskal")
            {
                SourceKruskal();
            }  
            else if(cbxChucNang.Text == "Prim")
            {
                SourcePrim();
            }    
            else if(cbxChucNang.Text == "Dijkstra")
            {
                SourceDijsktra();
            }    
            else if(cbxChucNang.Text == "Duyệt BFS")
            {
                SourceBFS();
            } 
            else if(cbxChucNang.Text == "Duyệt DFS")
            {
                SourceDFS();
            }    
            else if(cbxChucNang.Text == "Xét Liên Thông")
            {
                SourceLienThong();
            }    
            btnDuyet.Text = cbxChucNang.Text;
            Xacnhan = false;
        }
        #endregion
        #region 3. Tạo Đỉnh Đồ Thị
        private void pnlVeDoThi_MouseClick(object sender, MouseEventArgs e)
        {
            if (Checkiconbtn == true)
            {
                Button btn = new Button();
                btn.Width = 40;
                btn.Height = 40;
                btn.Location = new Point(e.X, e.Y);
                btn.Name = string.Format("{0},{1}", e.X, e.Y);
                btn.Text = string.Format("{0}", sodinh++);
                btn.BackColor = Color.YellowGreen;
                btn.ForeColor = Color.White;
                btn.Click += new EventHandler(getToaDo);
                pnlVeDoThi.Controls.Add(btn);
                Nod.x = e.X;
                Nod.y = e.Y;
                ListarrNod.Add(Nod);
                Nod = new Class_Graph.NodeGraph();
                LoadComBoBoxDinhBatDau();
                LoadComBoBoxDinhKetThuc();
            }
        }
        #endregion
        #region 4. Button Xóa đỉnh
        private void btnXoaDinh_Click(object sender, EventArgs e)
        {

            if (ListarrNod.Count == 0)
            {
                MessageBox.Show("Không còn đỉnh để Xxa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nod = new Class_Graph.NodeGraph();
                Egdes = new Class_Graph.Egde();
                btncreate = null;
                dx = dy = dx1 = dy1 = 0;
                d1 = d2 = -1;
                Dinh1 = Dinh2 = -1;
                return;
            }
            if (btncreate != null)
            {
                int n = 0;
                int tmp = ListarrNod.Count();
                Nod.x = btncreate.Location.X;
                Nod.y = btncreate.Location.Y;
                Class_Graph.NodeGraph NodEgde = new Class_Graph.NodeGraph();
                NodEgde.x = btncreate.Location.X + 12;
                NodEgde.y = btncreate.Location.Y + 12;
                pnlVeDoThi.Controls.Clear();
                pnlVeDoThi.Invalidate();
                pnlVeDoThi.Refresh();
                for (int i = 0; i < ListarrEgde.Count; i++)
                {
                    if (!NodEgde.SoSanhNodeVH(ListarrEgde[i]))
                    {
                        VeDoThi1(ListarrEgde[i]);
                    }
                    else
                    {
                        ListarrEgde.RemoveAt(i);
                        i = i - 1;
                    }
                }
                /*for (int i = 0; i < ListarrEgde.Count; i++)
                {
                    s += ListarrEgde[i].x.ToString() + " " + ListarrEgde[i].y.ToString() + " " + ListarrEgde[i].z.ToString() + " " + ListarrEgde[i].t.ToString() + Environment.NewLine;
                }*/
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    if (!Nod.SoSanhNode(ListarrNod[i]))
                    {
                        Button btn = new Button();
                        btn.Width = 40;
                        btn.Height = 40;
                        btn.Location = new Point(ListarrNod[i].x, ListarrNod[i].y);
                        btn.Text = string.Format("{0}", n++);
                        btn.BackColor = Color.YellowGreen;
                        btn.ForeColor = Color.White;
                        btn.Click += new EventHandler(getToaDo);
                        pnlVeDoThi.Controls.Add(btn);
                    }
                    else
                    {
                        PtuxoaNod = i;
                    }
                }
                if (PtuxoaNod != -1 && ListarrNod.Count > 0)
                {
                    ListarrNod.RemoveAt(PtuxoaNod);
                    Nod = new Class_Graph.NodeGraph();
                    Egdes = new Class_Graph.Egde();
                    btncreate = null;
                    dx = dy = dx1 = dy1 = 0;
                    d1 = d2 = -1;
                    Dinh1 = Dinh2 = -1;
                }
                if (tmp > ListarrNod.Count() && cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
                {
                    TaolaiMaTranCH();
                }
                if (tmp > ListarrNod.Count() && cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
                {
                    TaolaiMaTranVH();
                }
                /*m += Environment.NewLine + Nod.x.ToString() + " " + Nod.y.ToString() + " " + Environment.NewLine;*/
                /*for (int i = 0; i < ListarrNod.Count; i++)
                {
                    p += Environment.NewLine + (ListarrNod[i].x + 12).ToString() + " " + (ListarrNod[i].y + 12).ToString() + " " + Environment.NewLine;
                }*/
                /*txtKetqua.Text = s + p;*/
                sodinh = ListarrNod.Count;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn đỉnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Nod = new Class_Graph.NodeGraph();
            Egdes = new Class_Graph.Egde();
            LoadComBoBoxDinhBatDau();
            LoadComBoBoxDinhKetThuc();
            btncreate = null;
            dx = dy = dx1 = dy1 = 0;
            d1 = d2 = -1;
            Dinh1 = Dinh2 = -1;
        }
        #endregion
        #region 5. Button Vẽ Cạnh 
        private void btnThemCanh_Click(object sender, EventArgs e)
        {
            int num;
            if (txtTrongSo.Text == "0" && cbxChucNang.Text != "Dijkstra")
            {
                MessageBox.Show("Trọng số bằng 0 không thể vẽ cạnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Egdes = new Class_Graph.Egde();
                Nod = new Class_Graph.NodeGraph();
                btncreate = null;
                dx = dy = dx1 = dy1 = 0;
                d1 = d2 = -1;
                Dinh1 = Dinh2 = -1;
                labTrongSo.Text = "Trọng Số";
                txtTrongSo.Text = String.Empty;
                txtKetqua.Text = "Kết Quả";
                return;
            }
            else if( int.TryParse(txtTrongSo.Text, out num) )
            {
                if (num < 0)
                {
                    MessageBox.Show("Trọng số không thể âm được", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Egdes = new Class_Graph.Egde();
                    Nod = new Class_Graph.NodeGraph();
                    btncreate = null;
                    dx = dy = dx1 = dy1 = 0;
                    d1 = d2 = -1;
                    Dinh1 = Dinh2 = -1;
                    labTrongSo.Text = "Trọng Số";
                    txtTrongSo.Text = String.Empty;
                    txtKetqua.Text = "Kết Quả";
                    return;
                }
            }    
            
            VeDoThi(Egdes);
            if (haveEllipse == true)
            {
                btnXoaCanh.Enabled = true;
            }
            Egdes = new Class_Graph.Egde();
            Nod = new Class_Graph.NodeGraph();
            btncreate = null;
            dx = dy = dx1 = dy1 = 0;
            d1 = d2 = -1;
            Dinh1 = Dinh2 = -1;
            labTrongSo.Text = "Trọng Số";
            txtKetqua.Text = "Kết Quả";
            txtTrongSo.Text = String.Empty;
        }
        #endregion
        #region 6. Button Xóa Cạnh 
        private void btnXoaCanh_Click(object sender, EventArgs e)
        {
            if (ListarrEgde.Count == 0)
            {
                MessageBox.Show("Không còn cạnh nào để xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Nod = new Class_Graph.NodeGraph();
                Egdes = new Class_Graph.Egde();
                btncreate = null;
                dx = dy = dx1 = dy1 = 0;
                d1 = d2 = -1;
                Dinh1 = Dinh2 = -1;
                return;
            }
            if (btncreate == null)
            {
                MessageBox.Show("Bạn chưa chọn cạnh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            pnlVeDoThi.Invalidate();
            pnlVeDoThi.Refresh();
            int n = ListarrEgde.Count;
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
                {
                    if (!ListarrEgde[i].SoSanhEgdeVH(Egdes))
                    {
                        VeDoThi1(ListarrEgde[i]);
                    }
                    else
                    {
                        ListarrEgde.RemoveAt(i);
                        i = i - 1;
                        Matrix[d1, d2] = 0;
                        Matrix[d2, d1] = 0;
                    }
                }
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
                {
                    if (!ListarrEgde[i].SoSanhEgdeCH(Egdes))
                    {
                        VeDoThi1(ListarrEgde[i]);
                    }
                    else
                    {
                        ListarrEgde.RemoveAt(i);
                        i = i - 1;
                        Matrix[d1, d2] = 0;
                    }
                    if (false || (!CheckHuong && ListarrEgde.Count >= 1))
                    {
                        CheckHuong = ListarrEgde[i].CheckHuong(Egdes);
                    }
                }
            }
            if (ListarrEgde.Count > 0)
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng" && n == ListarrEgde.Count)
                {
                    MessageBox.Show("Không tồn tại đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng" && n == ListarrEgde.Count)
                {
                    MessageBox.Show("Không tồn tại đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            Egdes = new Class_Graph.Egde();
            Nod = new Class_Graph.NodeGraph();
            btncreate = null;
            dx = dy = dx1 = dy1 = 0;
            d1 = d2 = -1;
            Dinh1 = Dinh2 = -1;
            CheckHuong = false;
        }
        #endregion
        #region 7. Button Xác nhận các dữ liệu
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            #region test dữ liệu đầu vào
            if (cbxLoaiDoThi.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn loại đồ thị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxChucNang.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn chức năng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbxCachDuyet.Text == string.Empty && (cbxChucNang.Text == "Duyệt BFS" || cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Dothi"))
            {
                MessageBox.Show("Vui lòng chọn cách duyệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((cbxChucNang.Text == "Duyệt BFS" || cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Dothi") && (cboBD.Text == string.Empty || cboDinhKT.Text == String.Empty))
            {
                MessageBox.Show("Bạn chưa nhập đỉnh bắt đầu hoặc đỉnh kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(cbxChucNang.Text == "Kruscal" && cboCayKhung.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa chọn tìm cây khung lớn nhất hay nhỏ nhất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            if (cbxChucNang.Text == "Duyệt BFS" || cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Dijkstra")
            {
                //if (Int32.TryParse(cboBD.Text, out num) && Int32.TryParse(cboDinhKT.Text, out num))
                //{

                //}
                //else
                //{
                //    MessageBox.Show("Vui lòng kiểm tra lại đỉnh bắt đầu hoặc đỉnh kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
            }
            if (cbxChucNang.Text == "Duyệt DFS" || cbxChucNang.Text == "Duyệt BFS" || cbxChucNang.Text == "Dijkstra")
            {
                //if (Convert.ToInt32(txtDinhBatDau.Text) >= ListarrNod.Count || Convert.ToInt32(txtDinhKetThuc.Text) >= ListarrNod.Count || Convert.ToInt32(txtDinhBatDau.Text) < 0 || Convert.ToInt32(txtDinhKetThuc.Text) < 0)
                //{
                //    MessageBox.Show("Vui lòng kiểm tra lại đỉnh bắt đầu hoặc đỉnh kết thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}
            }
            #endregion 
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
            {
                TaolaiMaTranVH();
                string Mtran = string.Empty;
                Mtran += sodinh.ToString() + Environment.NewLine;
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    for (int j = 0; j < ListarrNod.Count; j++)
                    {
                        Mtran += Matrix[i, j] + "  ";
                    }
                    Mtran += Environment.NewLine;
                }
                txtMatran.Text = Mtran;
                Egl = new List<Class_Graph.Egde> { };
                ResetDT();
                ResetDTMau();
            }
            if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
            {
                TaolaiMaTranCH();
                string Mtran = string.Empty;
                Mtran += sodinh.ToString() + Environment.NewLine;
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    for (int j = 0; j < ListarrNod.Count; j++)
                    {
                        Mtran += Matrix[i, j] + "  ";
                    }
                    Mtran += Environment.NewLine;
                }
                txtMatran.Text = Mtran;
                Egl = new List<Class_Graph.Egde> { };
                ResetDT();
                ResetDTMau();
            }
            if (cbxChucNang.Text == "Xét Liên Thông" && cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
            {
                TaolaiMaTranVH();
                string Mtran = string.Empty;
                Mtran += sodinh.ToString() + Environment.NewLine;
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    for (int j = 0; j < ListarrNod.Count; j++)
                    {
                        Mtran += Matrix[i, j] + "  ";
                    }
                    Mtran += Environment.NewLine;
                }
                Egl = new List<Class_Graph.Egde> { };
                ResetDT();
                ResetDTMau();
            }
            /*string Mtran2 = string.Empty;
            for (int i = 0; i < ListarrNod.Count; i++)
            {
                for (int j = 0; j < ListarrNod.Count; j++)
                {
                    Mtran2 += Matrix[i, j] + " ";
                }
                Mtran2 += Environment.NewLine;
            }
            MessageBox.Show(Mtran2);*/
            socanh = ListarrEgde.Count;
            sodinhcheck = ListarrNod.Count;
            FS = string.Empty;
            FS1 = string.Empty;
            Prim = string.Empty;
            Kruskal = string.Empty;
            Dijsktra = string.Empty;
            dem = 0;
            btncreate = null;
            Dothi.TrongSoKruscal = 0;
            Dothi.TrongSoPrim = 0;
            Dothi.readGRAPH(Matrix, sodinh);
            DuyetGraph();
            Egl = new List<Class_Graph.Egde> { };
            if (FS != string.Empty)
            {
                getDD(FS);
                i = FS.Length - 1;
            }
            if (Prim != string.Empty)
            {
                getcaykhung(Prim);
                i = 0;
            }
            if (Kruskal != string.Empty)
            {
                getcaykhung(Kruskal);
                i = 0;
            }
            if (Dijsktra != string.Empty)
            {
                getDD2(Dijsktra);
                i = 0;
            }
            dx = dy = dx1 = dy1 = 0;
            Dinh1 = Dinh2 = -1;
            d1 = d2 = -1;
            Nod = new Class_Graph.NodeGraph();
            Egdes = new Class_Graph.Egde();
            Xacnhan = true;
        }
        #endregion
        #region 8. Button Duyệt
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            dx = dy = dx1 = dy1 = 0;
            d1 = d2 = -1;
            Dinh1 = Dinh2 = -1;
            Nod = new Class_Graph.NodeGraph();
            Egdes = new Class_Graph.Egde();
            btncreate = null;
            #region Xác nhận dữ liệu đầu vào
            if (!Xacnhan || socanh != ListarrEgde.Count || sodinhcheck != ListarrNod.Count)
            {
                MessageBox.Show("Bạn chưa xác nhận dữ liệu đầu vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ListarrNod.Count == 0 && Xacnhan)
            {
                /*txtKetqua.Text = "Bạn Chưa Vẽ Đồ Thị";*/
                MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            #region Prim
            if((cbxChucNang.Text == "Prim" && cbxCachDuyet.Text == String.Empty)|| (cbxChucNang.Text == "Prim" && cboCayKhung.Text == String.Empty))
            {
                MessageBox.Show("Bạn chưa chọn cách duyệt hay cây khung", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }    
            if (cbxChucNang.Text == "Prim" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboCayKhung.Text == "Nhỏ nhất")
            {
                if (Prim == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == Prim[i].ToString() || btn.Text == Prim[i + 1].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                        }
                    }
                    txtKetqua.Text = "Cây khung nhỏ nhất tìm được theo thuật toán Prim: ";
                    txtKetqua.Text += trave;
                    txtKetqua.Text += Environment.NewLine + "Tổng trọng lượng cây khung nhỏ nhất: " + Dothi.TrongSoPrim.ToString();
                    DanhDauDuongDiTB();
                    MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (cbxChucNang.Text == "Prim" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboCayKhung.Text == "Lớn nhất")
            {
                if (Prim == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == Prim[i].ToString() || btn.Text == Prim[i + 1].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                        }
                    }
                    txtKetqua.Text = "Cây khung lớn nhất tìm được theo thuật toán Prim: ";
                    txtKetqua.Text += trave;
                    txtKetqua.Text += Environment.NewLine + "Tổng trọng lượng cây khung lớn nhất: " + Dothi.TrongSoPrim.ToString();
                    DanhDauDuongDiTB();
                    MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }    
            else
            {
                if (cbxChucNang.Text == "Prim" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboCayKhung.Text == "Nhỏ nhất")
                {
                    if (Prim == string.Empty)
                    {
                        MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {
                        if (i < Prim.Length)
                        {
                            if (i == 0)
                            {
                                FS1 += "Cây khung tối thiểu tìm được theo thuật toán Prim là: ";
                            }
                            if (i == Prim.Length - 2)
                            {
                                FS1 += "(" + Prim[i] + "," + Prim[i + 1] + ")";
                                FS1 += Environment.NewLine + "Trọng lượng cây khung tối thiểu là " + Dothi.TrongSoPrim;
                            }
                            else FS1 += "(" + Prim[i] + "," + Prim[i + 1] + ")" + ",";
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == Prim[i].ToString() || btn.Text == Prim[i + 1].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i = i + 2;
                            txtKetqua.Text = FS1;
                        }
                        if (dem != Egl.Count)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if(dem == Egl.Count )
                        {
                            MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }    
                    }
                }
                else if(cbxChucNang.Text == "Prim" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboCayKhung.Text == "Lớn nhất")
                {
                    if (Prim == string.Empty)
                    {
                        MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {
                        if (i < Prim.Length)
                        {
                            if (i == 0)
                            {
                                FS1 += "Cây khung tối đại tìm được theo thuật toán Prim là: ";
                            }
                            if (i == Prim.Length - 2)
                            {
                                FS1 += "(" + Prim[i] + "," + Prim[i + 1] + ")";
                                FS1 += Environment.NewLine + "Trọng lượng cây khung tối đại là " + Dothi.TrongSoPrim;
                            }
                            else FS1 += "(" + Prim[i] + "," + Prim[i + 1] + ")" + ",";
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == Prim[i].ToString() || btn.Text == Prim[i + 1].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i = i + 2;
                            txtKetqua.Text = FS1;
                        }
                        if (dem != Egl.Count)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem == Egl.Count)
                        {
                            MessageBox.Show("Thuật toán Prim đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }    
            }
            #endregion
            #region Kruskal
            if ((cbxChucNang.Text == "Kruskal" && cbxCachDuyet.Text == String.Empty) || (cbxChucNang.Text == "Kruskal" && cboCayKhung.Text == String.Empty))
            {
                MessageBox.Show("Bạn chưa chọn cách duyệt hay cây khung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cbxChucNang.Text == "Kruskal" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboCayKhung.Text == "Nhỏ nhất")
            {
                if (Kruskal == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string trave = "";
                    for (int i = 0; i < Kruskal.Length; i = i + 2)
                    {
                        if(i == Kruskal.Length -2)
                        {
                            trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")";
                        }    
                        else  trave += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")" + ",";
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == Kruskal[i].ToString()|| btn.Text == Kruskal[i + 1].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }    
                        }    
                    }
                    txtKetqua.Text = "Cây khung tối thiểu tìm được theo thuật toán Kruskal là: ";
                    txtKetqua.Text += trave;
                    txtKetqua.Text += Environment.NewLine + "Tổng trọng lượng cây khung nhỏ nhất: " +  Dothi.TrongSoKruscal.ToString();
                    DanhDauDuongDiTB();
                    MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else if (cbxChucNang.Text == "Kruskal" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboCayKhung.Text == "Lớn nhất")
            {
                if (Kruskal == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == Kruskal[i].ToString() || btn.Text == Kruskal[i + 1].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                        }
                    }
                    txtKetqua.Text = "Cây khung tối đại tìm được theo thuật toán Kruskal là: ";
                    txtKetqua.Text += trave;
                    txtKetqua.Text += Environment.NewLine + "Tổng trọng lượng cây khung lớn nhất: " + Dothi.TrongSoKruscal.ToString();
                    DanhDauDuongDiTB();
                    MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }        
            else
            {
                if (cbxChucNang.Text == "Kruskal" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboCayKhung.Text == "Nhỏ nhất")
                {
                    if (Kruskal == string.Empty)
                    {
                        MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {                    
                        if (i < Kruskal.Length)
                        {
                            if(i == 0)
                            {
                                FS1 += "Cây khung tối thiểu tìm được theo thuật toán Kruskal là: ";
                            }    
                            if (i == Kruskal.Length - 2)
                            {
                                FS1 += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")";
                                FS1 += Environment.NewLine +  "Trọng lượng cây khung tối thiểu là " + Dothi.TrongSoKruscal;
                            }    
                            else FS1 += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")" + ",";
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == Kruskal[i].ToString() || btn.Text == Kruskal[i + 1].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i = i + 2;                         
                            txtKetqua.Text = FS1;
                        }
                        if (dem != Egl.Count)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem == Egl.Count)
                        {
                            MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }
                }
                else if (cbxChucNang.Text == "Kruskal" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboCayKhung.Text == "Lớn nhất")
                {
                    if (Kruskal == string.Empty)
                    {
                        MessageBox.Show("Không có cây khung", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {
                        if (i < Kruskal.Length)
                        {
                            if (i == 0)
                            {
                                FS1 += "Cây khung tối thiểu tìm được theo thuật toán Kruskal là: ";
                            }
                            if (i == Kruskal.Length - 2)
                            {
                                FS1 += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")";
                                FS1 += Environment.NewLine + "Trọng lượng cây khung tối thiểu là " + Dothi.TrongSoKruscal;
                            }    
                            else FS1 += "(" + Kruskal[i] + "," + Kruskal[i + 1] + ")" + ",";
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == Kruskal[i].ToString() || btn.Text == Kruskal[i + 1].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i = i + 2;
                            txtKetqua.Text = FS1;
                        }
                        if (dem != Egl.Count)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem == Egl.Count)
                        {
                            MessageBox.Show("Thuật toán Kruscal đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }    
            }
            #endregion
            #region dijsktra
            if(cbxChucNang.Text == "Dijkstra" && cbxCachDuyet.Text ==String.Empty)
            {
                MessageBox.Show("Bạn chưa chọn cách duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (cbxChucNang.Text == "Dijkstra" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboDinhKT.Text != string.Empty && cboBD.Text != string.Empty)
            {
                if (Dijsktra == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Đồ thị không liên thông nên không tìm được đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string trave = "";
                    for (int i = 0; i < Dijsktra.Length; i++)
                    {
                        if (i != Dijsktra.Length - 1)
                        {
                            trave += Dijsktra[i].ToString() + " --> ";
                        }
                        else
                        {
                            trave += Dijsktra[i].ToString();
                        }
                    }
                    txtKetqua.Text = trave;
                    DanhDauDuongDiTB();
                    for (int i = Dijsktra.Length - 1; i >= 0; i--)
                    {
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == Dijsktra[i].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                        }
                    }
                    MessageBox.Show("Thuật toán Dijkstra đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                if (cbxChucNang.Text == "Dijkstra" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboBD.Text != string.Empty && cboDinhKT.Text != string.Empty)
                {
                    if (Dijsktra == string.Empty)
                    {
                        MessageBox.Show("Đồ thị không liên thông nên không tìm được đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {
                        if (i == 0)
                        {

                            FS1 += Dijsktra[i].ToString();
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == FS1[0].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i++;
                        }
                        else
                        {
                            if (i < Dijsktra.Length)
                            {
                                FS1 += " --> " + Dijsktra[i].ToString();
                                foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                                {
                                    if (btn.Text == Dijsktra[i].ToString())
                                    {
                                        btn.BackColor = Color.Brown;
                                    }
                                }
                                i++;
                            }

                        }
                        txtKetqua.Text = FS1;
                        if (dem != Egl.Count && i > 1)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem  == Egl.Count)
                        {
                            MessageBox.Show("Thuật toán Dijkstra đã chạy xong", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                    }
                }
            }
            #endregion
            #region BFS
            if(cbxChucNang.Text == "Duyệt BFS" && cbxCachDuyet.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa chọn cách duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (cbxChucNang.Text == "Duyệt BFS" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboBD.Text != string.Empty && cboDinhKT.Text != string.Empty)
            {
                if (FS == string.Empty)
                {
                    /*txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string trave = "";
                    for (int i = FS.Length - 1; i >= 0; i--)
                    {
                        if (i != 0)
                        {
                            trave += FS[i].ToString() + " --> ";
                        }
                        else
                        {
                            trave += FS[i].ToString();
                            
                        }
                    }
                    txtKetqua.Text = trave;
                    DanhDauDuongDiTB();
                    for (int i = FS.Length - 1; i >= 0; i--)
                    {
                        foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                        {
                            if (btn.Text == FS[i].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                        }
                    }
                    MessageBox.Show("Đã duyệt xong thuật toán BFS", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            else
            {
                if (cbxChucNang.Text == "Duyệt BFS" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboDinhKT.Text != string.Empty && cboBD.Text != string.Empty)
                {
                    if (FS == string.Empty)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        /*txtKetqua.Text = "Không có đường đi";*/
                        return;
                    }
                    else
                    {
                        if (i == FS.Length - 1)
                        {

                            FS1 += FS[i].ToString();
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == FS1[0].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i--;
                        }
                        else
                        {
                            if (i > -1)
                            {
                                FS1 += " --> " + FS[i].ToString();
                                foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                                {
                                    if (btn.Text == FS[i].ToString())
                                    {
                                        btn.BackColor = Color.Brown;
                                    }
                                }
                                i--;
                            }

                        }
                        txtKetqua.Text = FS1;
                        if (dem != Egl.Count && i != FS.Length - 2)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem  == Egl.Count)    
                        MessageBox.Show("Đã duyệt xong BFS", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            #endregion
            #region DFS
            if(cbxChucNang.Text == "Duyệt DFS" && cbxCachDuyet.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa chọn cách duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }    
            if (cbxChucNang.Text == "Duyệt DFS" && cbxCachDuyet.Text == "Duyệt Toàn Bộ" && cboDinhKT.Text != string.Empty && cboBD.Text != string.Empty)
            {
                if (FS == string.Empty)
                {
                    /* txtKetqua.Text = "Không có đường đi";*/
                    MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string trave = "";
                    for (int i = FS.Length - 1; i >= 0; i--)
                    {
                        if (i != 0)
                        {
                            trave += FS[i].ToString() + " --> ";// để không có dấu mũi tên
                        }
                        else
                        {
                            trave += FS[i].ToString();
                        }
                    }
                    txtKetqua.Text = trave;
                    DanhDauDuongDiTB();
                    foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                    {
                        for (int i = FS.Length - 1; i >= 0 ; i--)
                            if (btn.Text == FS[i].ToString())
                            {
                                btn.BackColor = Color.Brown;
                            }
                    }
                    MessageBox.Show("Đã duyệt xong thuật toán DFS", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                if (cbxChucNang.Text == "Duyệt DFS" && cbxCachDuyet.Text == "Duyệt Từng Bước" && cboBD.Text != string.Empty && cboDinhKT.Text != string.Empty)
                {
                    if (FS == string.Empty)
                    {
                        MessageBox.Show("Không có đường đi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (i == FS.Length - 1)
                        {
                            FS1 += FS[i].ToString();
                            foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                            {
                                if (btn.Text == FS1[0].ToString())
                                {
                                    btn.BackColor = Color.Brown;
                                }
                            }
                            i--;
                        }
                        else
                        {
                            if (i > -1)
                            {
                                FS1 += "-->" + FS[i].ToString();
                                foreach (Button btn in pnlVeDoThi.Controls.OfType<Button>())
                                {
                                        if (btn.Text == FS[i].ToString())
                                        {
                                            btn.BackColor = Color.Brown;
                                        }
                                }
                                i--;
                            }
                        }
                        txtKetqua.Text = FS1;
                        if (dem != Egl.Count && i != FS.Length - 2)
                        {
                            DanhDauDuongDiTB2();
                            dem = dem + 1;
                        }
                        if (dem == Egl.Count)
                            MessageBox.Show("Đã duyệt xong DFS", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            #endregion
            #region Xét liên thông
            if (cbxChucNang.Text == "Xét Liên Thông" && Xacnhan)
            {
                string showLT = string.Empty;
                if (TPLT[0] != "0")
                {
                    /*if (Convert.ToInt32(TPLT[0]) == 1)
                    {
                        showLT += "Đồ Thị Liên Thông" + Environment.NewLine;
                    }
                    else
                    {
                        showLT += "Đồ Thị Không Liên Thông" + Environment.NewLine;
                    }*/
                }
                else
                {
                    MessageBox.Show("Bạn chưa vẽ đồ thị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (TPLT[0] == "1")
                {
                    for (int i = 1; i < TPLT.Length; i++)
                    {
                        showLT += "Thành Phần Liên Thông Duy Nhất: " + TPLT[i] + Environment.NewLine;
                    }
                    txtKetqua.Text = showLT;
                    return;
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
                            string arrListStr = TPLT[i].Replace(" ", "");
                            getDDLT(arrListStr);
                            Pen pen;
                            if (i > 5)
                            {
                                Random r = new Random();
                                pen = new Pen(Color.FromArgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 233)), 2);
                            }
                            else
                            {
                                pen = new Pen(a[i - 1], 2);
                            }
                            ResetLT(pen);
                            pen = null;
                            LNodLT = new List<Class_Graph.NodeGraph> { };
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

                    txtKetqua.Text = showLT;
                    return;
                }
            }
            #endregion
        }
        #endregion
        #region 9. Button Tạo Mới Và Xóa
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn làm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                pnlVeDoThi.Controls.Clear();
                pnlVeDoThi.Invalidate();
                pnlVeDoThi.Refresh();
                cboDinhKT.Text = string.Empty;
                cboBD.Text = string.Empty;
                txtTrongSo.Text = String.Empty;
                txtKetqua.Text = "Kết Quả";
                btncreate = new Button();
                Checkiconbtn = false;
                dx = 0; dy = 0; dx1 = 0; dy1 = 0;
                d1 = -1; d2 = -1;
                Dinh1 = -1; Dinh2 = -1;
                Class_Graph.Egde Egdes = new Class_Graph.Egde();
                ListarrEgde = new List<Class_Graph.Egde> { };
                CheckHuong = false;
                Class_Graph.NodeGraph Nod = new Class_Graph.NodeGraph();
                ListarrNod = new List<Class_Graph.NodeGraph> { };
                PtuxoaNod = -1;
                sodinh = 0;
                Matrix = new int[100, 100];
                Class_Graph.FS_Graph Dothi = new Class_Graph.FS_Graph();
                FS = string.Empty;
                FS1 = string.Empty;
                TPLT = new string[] { };
                i = 0;
                btnThemDinh.TextAlign = ContentAlignment.MiddleCenter;
                btnThemDinh.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnThemDinh.ImageAlign = ContentAlignment.MiddleLeft;
                btnThemDinh.IconChar = IconChar.PlusCircle;
                btnThemDinh.Text = "Thêm Đỉnh";
                rightBorderBtn.Visible = false;
                Xacnhan = false;
                rtxtMaGia.Text = String.Empty;
                txtMatran.Text = "Ma Trận";
            }
        }
        #endregion
        #region Event Reset Đồ Thị và textBox Kết Quả Theo Các Input
        private void cbxCachDuyet_TextChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "Kết Quả";
            ResetDT();
            ResetDTMau();
            Xacnhan = false;
        }
        private void cboBD_TextChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "Kết Quả";
            Xacnhan = false;
        }

        private void cboDinhKT_TextChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "Kết Quả";
            Xacnhan = false;
        }
        private void cbxChucNang_TextChanged(object sender, EventArgs e)
        {
            txtKetqua.Text = "Kết Quả";
            Xacnhan = false;
            ResetDT();
        }
        #endregion
        #endregion
        #region Method Vẽ Đồ Thị
        #region 1. Lấy Tọa Độ Các Đỉnh
        public void getToaDo(object sender, EventArgs e)
        {
            btncreate = (Button)sender;
            if (dx != 0 && dx1 != 0)
            {
                dx = dy = dx1 = dy1 = 0;
                dx = btncreate.Location.X + 12;
                dy = btncreate.Location.Y + 12;
                Egdes.x = dx;
                Egdes.y = dy;
                Egdes.z = dx1;
                Egdes.t = dy1;
            }

            if (dx == 0 && dy == 0)
            {
                dx = btncreate.Location.X + 12;
                dy = btncreate.Location.Y + 12;
                Egdes.x = dx;
                Egdes.y = dy;
            }
            else
            {
                if (dx1 == 0 && dy1 == 0)
                {
                    dx1 = btncreate.Location.X + 12;
                    dy1 = btncreate.Location.Y + 12;
                    Egdes.z = dx1;
                    Egdes.t = dy1;
                }
            }
            if (dx1 == dx)
            {
                dx1 = dy1 = 0;
                Egdes.z = dx1;
                Egdes.t = dy1;
            }
            //
            if (d1 != -1 && d2 != -1)
            {
                d1 = d2 = -1;
                d1 = Convert.ToInt32(btncreate.Text);
                Dinh1 = d1;
                Dinh2 = d2;
            }
            if (d1 == -1 && d2 == -1)
            {
                d1 = Convert.ToInt32(btncreate.Text);
                Dinh1 = d1;

            }
            else
            {
                if (d2 == -1)
                {
                    d2 = Convert.ToInt32(btncreate.Text);
                    Dinh2 = d2;
                }
            }
            if (d1 == d2)
            {
                d2 = -1;
                Dinh2 = d2;
            }
            txtKetqua.Text = dx.ToString() + " " + dy.ToString() + " " + Dinh1.ToString() + " " + dx1.ToString() + " " + dy1.ToString() + " " + Dinh2.ToString();
            if (Dinh1 != -1 && Dinh2 == -1)
            {
                labTrongSo.Text = "Trọng số từ đỉnh " + Dinh1.ToString();
            }
            else if (Dinh2 != -1 && Dinh2 != -1)
            {
                labTrongSo.Text = "Trọng số từ đinh " + Dinh1.ToString() + " đến đỉnh " + Dinh2.ToString();
            }

        }
        #endregion
        #region 2. Vẽ Cạnh 
        private void VeDoThi(Class_Graph.Egde NodeG)
        {
            if (check1(Dinh1, Dinh2))
            {
                #region đồ thị vô hướng
                if (Matrix[Dinh1, Dinh2] != 0 && cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng" && NodeG.CheckEgde())
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    if (txtTrongSo.Text != String.Empty)
                    {
                        NodeG.trongso = Convert.ToInt32(txtTrongSo.Text);
                    }
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;

                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                    haveEllipse = true;

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        Panel pnlDraw = new Panel();

                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                        
                    }
                    Matrix[Dinh1, Dinh2] = NodeG.trongso;
                    Matrix[Dinh2, Dinh1] = NodeG.trongso;
                    for (int i = 0; i < ListarrEgde.Count; i++)
                    {
                        if (ListarrEgde[i].SoSanhEgdeVH(NodeG))
                        {
                            ListarrEgde[i].trongso = NodeG.trongso;
                            break;
                        }

                    }
                    return;
                }
                #endregion
                #region đồ thị có hướng
                else if (Matrix[Dinh1, Dinh2] != 0 && cbxLoaiDoThi.Text == "Đồ Thị Có Hướng" && NodeG.CheckEgde())
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    if (txtTrongSo.Text != String.Empty)
                    {
                        NodeG.trongso = Convert.ToInt32(txtTrongSo.Text);
                    }
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;

                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        Panel pnlDraw = new Panel();

                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                    }
                    Matrix[Dinh1, Dinh2] = NodeG.trongso;
                    for (int i = 0; i < ListarrEgde.Count; i++)
                    {
                        if (ListarrEgde[i].SoSanhEgdeCH(NodeG))
                        {
                            ListarrEgde[i].trongso = NodeG.trongso;
                            break;
                        }

                    }
                    return;
                }
                #endregion
            }
            #region đồ thị vô hướng
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng" && NodeG.CheckEgde() && check(Dinh1, Dinh2))
            {
                Graphics dc = pnlVeDoThi.CreateGraphics();
                dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen BlackPen = new Pen(Color.Black, 2);
                dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                // dc.DrawArc(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t, 45, 46);
                dx = dy = dx1 = dy1 = 0;
                if (txtTrongSo.Text != String.Empty)
                {
                    NodeG.trongso = Convert.ToInt32(txtTrongSo.Text);
                }
                int x = (NodeG.x + NodeG.z) / 2;
                int y = (NodeG.y + NodeG.t) / 2;

                SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                haveEllipse = true;
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;

                    Panel pnlDraw = new Panel();

                    dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                }
                ListarrEgde.Add(NodeG);
                Matrix[Dinh1, Dinh2] = NodeG.trongso;
                Matrix[Dinh2, Dinh1] = NodeG.trongso;
                return;
            }
            #endregion
            #region đồ thị có hướng
            else
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng" && NodeG.CheckEgde() && check(Dinh1, Dinh2))
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Pen BlackPen = new Pen(Color.Black, 2);
                    dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    DrawArrowhead(dc, BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    dx = dy = dx1 = dy1 = 0;
                    if (txtTrongSo.Text != String.Empty)
                    {
                        NodeG.trongso = Convert.ToInt32(txtTrongSo.Text);
                    }
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;

                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);

                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;

                        Panel pnlDraw = new Panel();

                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                    }
                    ListarrEgde.Add(NodeG);
                    Matrix[Dinh1, Dinh2] = NodeG.trongso;
                    return;
                }
            }
            #endregion
        }
        #endregion
        #region 3. Vẽ Đồ Thị Lúc Xóa Cạnh
        private void VeDoThi1(Class_Graph.Egde NodeG)
        {
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
            {

                Graphics dc = pnlVeDoThi.CreateGraphics();
                dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen BlackPen = new Pen(Color.Black, 2);
                dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                int x = (NodeG.x + NodeG.z) / 2;
                int y = (NodeG.y + NodeG.t) / 2;
                SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    Panel pnlDraw = new Panel();
                    dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                }

            }
            else
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Pen BlackPen = new Pen(Color.Black, 2);
                    dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    DrawArrowhead(dc, BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;
                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        Panel pnlDraw = new Panel();
                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                    }

                }

            }
        }
        #endregion
        #region 4. Vẽ Đường Đi Kết Quả
        private void VeDoThi2(Class_Graph.Egde NodeG)
        {
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
            {
                Graphics dc = pnlVeDoThi.CreateGraphics();
                dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                Pen BlackPen = new Pen(Color.Red, 2);
                dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                int x = (NodeG.x + NodeG.z) / 2;
                int y = (NodeG.y + NodeG.t) / 2;
                SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    Panel pnlDraw = new Panel();
                    dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                }

            }
            else
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    Pen BlackPen = new Pen(Color.Red, 2);
                    dc.DrawLine(BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    DrawArrowhead(dc, BlackPen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;
                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        Panel pnlDraw = new Panel();
                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                    }

                }
            }
        }
        #endregion
        #region 5. Trạng Thái Buttton Thêm Đỉnh
        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                //button
                currentBtn = (IconButton)senderBtn;
                currentBtn.IconChar = IconChar.StopCircle;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.TopLeft;
                currentBtn.Text = "Dừng";
                //left border button
                rightBorderBtn.BackColor = Color.FromArgb(172, 126, 241);
                rightBorderBtn.Location = new Point(currentBtn.Location.X, currentBtn.Location.Y);
                rightBorderBtn.Visible = true;
                rightBorderBtn.BringToFront();

            }
        }
        #endregion
        #region 6. Trạng Thái Button Dừng Thêm Đỉnh
        private void DisableButton(object sender)
        {
            if (currentBtn != null)
            {
                currentBtn = (IconButton)sender;
                currentBtn.IconChar = IconChar.PlusCircle;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Text = "Thêm Đỉnh";
                rightBorderBtn.Visible = false;
            }
        }
        #endregion
        #region 7. Vẽ Hướng Đồ Thị
        private void DrawArrowhead(Graphics gr, Pen pen, int x, int y, int z, int t)
        {
            float dx = z - x;
            float dy = t - y;
            float dist = (float)Math.Sqrt(dx * dx + dy * dy);
            dx /= dist;
            dy /= dist;
            const float scale = 5;
            dx *= scale;
            dy *= scale;
            float p1x = -dy;
            float p1y = dx;
            float p2x = dy;
            float p2y = -dx;
            float cx = (x + z) / 2f;
            float cy = (y + t) / 2f;
            float cxy = (cx + z) / 2f;
            float cyx = (cy + t) / 2f;
            PointF[] points =
            {
        new PointF (cxy - dx + p1x, cyx - dy + p1y),
        new PointF (cxy, cyx),
        new PointF (cxy - dx + p2x, cyx - dy + p2y),
    };
            gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            gr.DrawLines(pen, points);
        }
        #endregion
        #region 8. Ktra Cạnh Đã Vẽ
        private bool check(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                return Matrix[x, y] != 1;
            }
            else
            {
                return false;
            }
        }
        private bool check1(int x, int y)
        {
            if (x >= 0 && y >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region 9. Tạo Ma Trận Có Hướng
        private void TaolaiMaTranCH()
        {
            Matrix = new int[100, 100];
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                Class_Graph.Egde Eg = ListarrEgde[i];
                for (int j = 0; j < ListarrNod.Count; j++)
                {
                    for (int l = 0; l < ListarrNod.Count; l++)
                    {
                        Class_Graph.NodeGraph Nod1 = new Class_Graph.NodeGraph();
                        Nod1.x = ListarrNod[j].x + 12;
                        Nod1.y = ListarrNod[j].y + 12;
                        Class_Graph.NodeGraph Nod2 = new Class_Graph.NodeGraph();
                        Nod2.x = ListarrNod[l].x + 12;
                        Nod2.y = ListarrNod[l].y + 12;
                        if (Eg.CheckMatrixCH(Nod1, Nod2))
                        {
                            Matrix[j, l] = Eg.trongso;
                        }
                    }
                }
            }
        }
        #endregion
        #region 10. Tạo Ma Trận Vô Hướng
        private void TaolaiMaTranVH()
        {
            Matrix = new int[100, 100];
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                Class_Graph.Egde Eg = ListarrEgde[i];
                for (int j = 0; j < ListarrNod.Count; j++)
                {
                    for (int l = j + 1; l < ListarrNod.Count; l++)
                    {
                        Class_Graph.NodeGraph Nod1 = new Class_Graph.NodeGraph();
                        Nod1.x = ListarrNod[j].x + 12;
                        Nod1.y = ListarrNod[j].y + 12;
                        Class_Graph.NodeGraph Nod2 = new Class_Graph.NodeGraph();
                        Nod2.x = ListarrNod[l].x + 12;
                        Nod2.y = ListarrNod[l].y + 12;
                        if (Eg.CheckMatrixVH(Nod1, Nod2))
                        {
                            Matrix[j, l] = Eg.trongso;
                            Matrix[l, j] = Eg.trongso;
                        }
                    }
                }
            }
        }
        #endregion
        #region 11. Xét Sụ Thay Đổi Đồ Thị Mà Vẽ Lại Ma Trận Và Đồ Thị
        private void cbxLoaiDoThi_TextChanged(object sender, EventArgs e)
        {
            if (cbxLoaiDoThi.Text == string.Empty)
            {
                btnThemCanh.Enabled = false;
            }
            else
            {
                btnThemCanh.Enabled = true;
                //btnXoaCanh.Enabled = true;
            }
            txtKetqua.Text = "Kết Quả";
            ResetDT();
            ResetDTMau();
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
            {
                TaolaiMaTranVH();
                string Mtran = string.Empty;
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    for (int j = 0; j < ListarrNod.Count; j++)
                    {
                        Mtran += Matrix[i, j] + " ";
                    }
                    Mtran += Environment.NewLine;
                }
                txtMatran.Text = Mtran;
                Egl = new List<Class_Graph.Egde> { };
            }
            if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
            {
                TaolaiMaTranCH();
                string Mtran = string.Empty;
                for (int i = 0; i < ListarrNod.Count; i++)
                {
                    for (int j = 0; j < ListarrNod.Count; j++)
                    {
                        Mtran += Matrix[i, j] + " ";
                    }
                    Mtran += Environment.NewLine;
                }
                txtMatran.Text = Mtran;
                Egl = new List<Class_Graph.Egde> { };
            }
            Xacnhan = false;
        }
        #endregion
        #region  12. Vẽ Lại Đồ Thị
        private void ResetDT()
        {
            pnlVeDoThi.Invalidate();
            pnlVeDoThi.Refresh();
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                VeDoThi1(ListarrEgde[i]);
            }
        }
        #endregion
        #region 13. Vẽ Liên Thông
        private void VeDoThiLT(Class_Graph.Egde NodeG, Pen pen)
        {
            if (cbxLoaiDoThi.Text == "Đồ Thị Vô Hướng")
            {

                Graphics dc = pnlVeDoThi.CreateGraphics();
                dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                dc.DrawLine(pen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                int x = (NodeG.x + NodeG.z) / 2;
                int y = (NodeG.y + NodeG.t) / 2;
                SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    Panel pnlDraw = new Panel();
                    dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                }
            }
            else
            {
                if (cbxLoaiDoThi.Text == "Đồ Thị Có Hướng")
                {
                    Graphics dc = pnlVeDoThi.CreateGraphics();
                    dc.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    dc.DrawLine(pen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    DrawArrowhead(dc, pen, NodeG.x, NodeG.y, NodeG.z, NodeG.t);
                    int x = (NodeG.x + NodeG.z) / 2;
                    int y = (NodeG.y + NodeG.t) / 2;
                    SolidBrush sb = new SolidBrush(Color.FromArgb(241, 175, 0));
                    dc.FillEllipse(sb, x - 15, y - 15, 30, 30);
                    using (StringFormat sf = new StringFormat())
                    {
                        sf.Alignment = StringAlignment.Center;
                        sf.LineAlignment = StringAlignment.Center;
                        Panel pnlDraw = new Panel();
                        dc.DrawString($"{NodeG.trongso}", pnlDraw.Font, new SolidBrush(Color.Black), x, y, sf);
                    }

                }
            }

        }
        #endregion
        #region 14. Vẽ Thành Phần Liên Thông
        private void ResetLT(Pen a)
        {
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                for (int j = 0; j < LNodLT.Count; j++)
                {
                    if (LNodLT[j].SoSanhNodeVH(ListarrEgde[i]))
                    {
                        VeDoThiLT(ListarrEgde[i], a);
                    }
                }
            }
        }
        #endregion
        #endregion
        # region method Duyệt Và Trả Kết Quả
        #region 1.Duyệt Theo Chức Năng
        private void DuyetGraph()
        {
            if (cbxChucNang.Text == "Duyệt BFS" && Int32.TryParse(cboBD.Text, out PtuxoaNod) && Int32.TryParse(cboDinhKT.Text, out PtuxoaNod))
            {
                FS = Dothi.duyetBFS(Convert.ToInt32(cboBD.Text), Convert.ToInt32(cboDinhKT.Text));
            }
            else
            {
                if (cbxChucNang.Text == "Duyệt DFS" && Int32.TryParse(cboBD.Text, out PtuxoaNod) && Int32.TryParse(cboDinhKT.Text, out PtuxoaNod))
                {
                    FS = Dothi.duyetDFS(Convert.ToInt32(cboBD.Text), Convert.ToInt32(cboDinhKT.Text));
                }
                else
                {
                    if (cbxChucNang.Text == "Xét Liên Thông")
                    {
                        TPLT = Dothi.thanhPhanLienThong();
                    }
                    else
                    {
                        if (cbxChucNang.Text == "Kruskal" && cboCayKhung.Text == "Nhỏ nhất" )
                        {
                            Kruskal = Dothi.KruskalMin();
                        }
                        else if (cbxChucNang.Text == "Kruskal" && cboCayKhung.Text == "Lớn nhất")
                        {
                            Kruskal = Dothi.KruskalMax();
                        }    
                        else
                        {
                            if (cbxChucNang.Text == "Prim" && cboCayKhung.Text == "Nhỏ nhất")
                            {
                                Prim = Dothi.PrimMin();
                            }
                            else if(cbxChucNang.Text== "Prim" && cboCayKhung.Text == "Lớn nhất")
                            {
                                Prim = Dothi.PrimMax();
                            }    
                            else
                            {
                                if (cbxChucNang.Text == "Dijkstra" && Int32.TryParse(cboBD.Text, out PtuxoaNod) && Int32.TryParse(cboDinhKT.Text, out PtuxoaNod))
                                {
                                    Dijsktra= Dothi.Xuat(Convert.ToInt32(cboBD.Text), Convert.ToInt32(cboDinhKT.Text));
                                }
                                else
                                {
                                    MessageBox.Show("Vui lòng kiểm tra lại dữ liệu đầu vào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                        }
                    }

                }
            }

            /*if (cbxChucNang.Text == "Duyệt DFS" && Int32.TryParse(txtDinhBatDau.Text, out PtuxoaNod) && Int32.TryParse(txtDinhKetThuc.Text, out PtuxoaNod))
            {
                FS = Dothi.duyetDFS(Convert.ToInt32(txtDinhBatDau.Text), Convert.ToInt32(txtDinhKetThuc.Text));
            }
            if (cbxChucNang.Text == "Xét Liên Thông")
            {
                TPLT = Dothi.thanhPhanLienThong();
            }*/
        }
        #endregion
        #region 2. Lấy Đường Đi BFS hoặc DFS
        private void getDD2(string a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                Eg.x = ListarrNod[(int)a[i] - '0'].x + 12;
                Eg.y = ListarrNod[(int)a[i] - '0'].y + 12;
                Eg.z = ListarrNod[(int)a[i + 1] - '0'].x + 12;
                Eg.t = ListarrNod[(int)a[i + 1] - '0'].y + 12;
                Eg.trongso = Matrix[(int)a[i] - '0', (int)a[i + 1] - '0'];
                Egl.Add(Eg);
                Eg = new Class_Graph.Egde();
            }
        }
        #endregion
        #region getDD
        private void getDD(string a)
        {
            for (int i = a.Length - 1; i > 0; i--)
            {
                Eg.x = ListarrNod[(int)a[i] - '0'].x + 12;
                Eg.y = ListarrNod[(int)a[i] - '0'].y + 12;
                Eg.z = ListarrNod[(int)a[i - 1] - '0'].x + 12;
                Eg.t = ListarrNod[(int)a[i - 1] - '0'].y + 12;
                Eg.trongso = Matrix[(int)a[i] - '0', (int)a[i - 1] - '0'];
                Egl.Add(Eg);
                Eg = new Class_Graph.Egde();
            }
        }
        #endregion
        #region Cay Khung
        private void getcaykhung(string a)
        {
            for (int i = 0; i < a.Length; i = i + 2)
            {
                Eg.x = ListarrNod[(int)a[i] - '0'].x + 12;
                Eg.y = ListarrNod[(int)a[i] - '0'].y + 12;
                Eg.z = ListarrNod[(int)a[i + 1] - '0'].x + 12;
                Eg.t = ListarrNod[(int)a[i + 1] - '0'].y + 12;
                Eg.trongso = Matrix[(int)a[i] - '0', (int)a[i + 1] - '0'];
                Egl.Add(Eg);
                Eg = new Class_Graph.Egde();
            }
        }
        #region KTDT Vo Huong
        bool kiem_Tra_Do_Thi_Vo_Huong()
        {
            for (int i = 0; i < sodinh; ++i)
            {
                for (int j = 0; j < sodinh; ++j)
                {
                    if (Matrix[i, j] != Matrix[j, i]) return false;
                }
            }
            return true;// ma tran
        }
        #endregion
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #region KT Khoang cach
        bool kiem_Tra_Khoang_Cach(int x, int y)
        {
            int x_Vector = 0, y_Vector = 0;
            int khoang_Cach = 0;
            for (int i = 0; i < sodinh; ++i)
            {
                x_Vector = Math.Abs(x - ListarrNod[i].x);
                y_Vector = Math.Abs(y - ListarrNod[i].y);
                khoang_Cach = (int)Math.Sqrt(Math.Pow(x_Vector, 2) + Math.Pow(y_Vector, 2));
                if (khoang_Cach < 50) return false;
            }
            return true;
        }
        #endregion
        private void panelClickSukien_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void pnlVeDoThi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGraph_Load(object sender, EventArgs e)
        {

        }

        private void txtTrongSo_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region 3.Lấy Các Đỉnh Liên Thông
        private void getDDLT(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                NodLT.x = ListarrNod[(int)(a[i] - '0')].x + 12;
                NodLT.y = ListarrNod[(int)a[i] - '0'].y + 12;
                LNodLT.Add(NodLT);
                NodLT = new Class_Graph.NodeGraph();
            }
        }
        #endregion
        #region 4. Vẽ Đường Đi BFS hoặc DFS Toàn Bộ
        private void DanhDauDuongDiTB()
        {
            pnlVeDoThi.Invalidate();
            pnlVeDoThi.Refresh();
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                VeDoThi1(ListarrEgde[i]);
            }
            for (int j = 0; j < Egl.Count; j++)
            {
                VeDoThi2(Egl[j]);
            }
        }
        #endregion
        #region 5. Vẽ Đường Đi BFS hoặc DFS Từng Bước
        private void DanhDauDuongDiTB2()
        {
            pnlVeDoThi.Invalidate();
            pnlVeDoThi.Refresh();
            for (int i = 0; i < ListarrEgde.Count; i++)
            {
                VeDoThi1(ListarrEgde[i]); // vẽ cạnh màu đen
            }
            for (int j = 0; j <= dem; j++)
            {
                VeDoThi2(Egl[j]); // vẽ cạnh màu đỏ
            }
        }
        #endregion
        #endregion
        private void pnlVeDoThi_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
