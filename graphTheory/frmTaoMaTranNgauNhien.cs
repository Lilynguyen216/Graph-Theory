using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphTheory
{
    public partial class frmTaoMaTranNgauNhien : Form
    {
        public frmTaoMaTranNgauNhien()
        {
            InitializeComponent();
        }
        public int sodinh;
        public int[,] matran = new int[100, 100];
        int h = 20, m = 3;
        int[] tmp = new int[10000];
        int chisotmp = 0;

        private void frmTaoMaTranNgauNhien_Load(object sender, EventArgs e)
        {

        }

        private void cbxChucNang_SelectedValueChanged(object sender, EventArgs e)
        {
            #region Tao Ma Tran
            if (cbxChucNang.Text == "Tạo Ma Trận")
            {
                if (txtSoDinh.Text == String.Empty)
                {
                    pnlMaTran.Controls.Clear();
                    MessageBox.Show("Bạn chưa nhập số đỉnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (int.Parse(txtSoDinh.Text) >= 8)
                {
                    pnlMaTran.Controls.Clear();
                    MessageBox.Show("Chỉ được tạo tối đa 7 đỉnh thôi. Tạo nhiều vẽ hình rối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    sodinh = int.Parse(txtSoDinh.Text);
                    int x = 3, y = 3;
                    pnlMaTran.Controls.Clear();
                    for (int i = 0; i <= sodinh; i++)
                    {
                        for (int j = 0; j <= sodinh; j++)
                        {
                            TextBox a = new TextBox();
                            a.Multiline = true;
                            a.Width = 50;
                            a.Height = h;
                            if (i == 0 && j == 0)
                            {
                                a.ReadOnly = true;
                                a.Text = $"*";
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"{j - 1}";
                                }
                                if (j == 0)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"{i - 1}";
                                }
                                if (i == j)
                                {
                                    a.ReadOnly = true;
                                    a.Text = $"0";
                                }
                                if (i > j && j != 0)
                                {
                                    a.ReadOnly = true;
                                }
                            }
                            a.Location = new Point(x, y);
                            pnlMaTran.Controls.Add(a);
                            x += m + 50;
                        }
                        x = 3;
                        y += m + h;
                    }
                }
            }
            #endregion
            #region Lay Trong so ngau nhien
            if (cbxChucNang.Text == "Lấy Trọng số ngẫu nhiên")
            {
                if (pnlMaTran.Controls.Count == 0)
                {
                    MessageBox.Show("Bạn chưa tạo ma trận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Random rnd = new Random();
                    foreach (TextBox txt in pnlMaTran.Controls.OfType<TextBox>())
                    {
                        if (txt.ReadOnly == false)
                        {
                            int trongso = rnd.Next(-20, 20);
                            if (trongso < 0) txt.Text = "0";
                            else txt.Text = trongso.ToString();
                        }
                    }
                }
            }
            #endregion
            #region Su dung ma tran
            if (cbxChucNang.Text == "Sử dụng ma trận")
            {
                foreach (TextBox txt in pnlMaTran.Controls.OfType<TextBox>())
                {
                    if (txt.Text == String.Empty && txt.ReadOnly == false)
                    {
                        MessageBox.Show("Bạn chưa nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                if (txtSoDinh.Text == String.Empty)
                {
                    MessageBox.Show("Bạn chưa tạo ma trận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if (pnlMaTran.Controls.Count == 0)
                {
                    MessageBox.Show("Bạn chưa tạo ma trận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    bool kt = true;
                    foreach (TextBox textBox in pnlMaTran.Controls)
                    {
                        if (!textBox.ReadOnly)
                        {
                            tmp[chisotmp++] = int.Parse(textBox.Text);
                        }
                    }
                    if (kt)
                    {
                        chisotmp = 0;
                        for (int i = 0; i < sodinh - 1; i++)
                        {
                            for (int j = i + 1; j < sodinh; j++)
                            {
                                if (i != j)
                                {
                                    matran[i, j] = matran[j, i] = tmp[chisotmp];
                                    chisotmp++;
                                }
                            }
                        }
                        chisotmp = 0;
                        this.Close();
                    }
                }
            }
            #endregion
        }
    }
}
