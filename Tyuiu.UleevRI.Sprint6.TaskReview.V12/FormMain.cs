﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UleevRI.Sprint6.TaskReview.V12.Lib;

namespace Tyuiu.UleevRI.Sprint6.TaskReview.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemHelp_URI_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }

        static int[,] num;
        DataService ds = new DataService();
        private void buttonDone_URI_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN_URI.Text);
                int m = Convert.ToInt32(textBoxM_URI.Text);
                int n1 = Convert.ToInt32(textBoxN1_URI.Text);
                int n2 = Convert.ToInt32(textBoxN2_URI.Text);
                int k = Convert.ToInt32(textBoxK_URI.Text);
                int l = Convert.ToInt32(textBoxL_URI.Text);
                int C = Convert.ToInt32(textBoxC_URI.Text);
                if ((k < l) && (C <= m) && (k < n) && (l < n))
                {
                    int result = ds.CalculateMatrix(num, n1, n2, C, k, l);
                    textBoxResult_URI.Text = Convert.ToString(result);
                }
                else MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGeneration_URI_Click(object sender, EventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(textBoxN_URI.Text);
                int m = Convert.ToInt32(textBoxM_URI.Text);
                int n1 = Convert.ToInt32(textBoxN1_URI.Text);
                int n2 = Convert.ToInt32(textBoxN2_URI.Text);
                if ((n1 < n2) && (n > 1) && (m > 1))
                {
                    Random rng = new Random();

                    dataGridViewMatrix_URI.RowCount = n;
                    dataGridViewMatrix_URI.ColumnCount = m;

                    num = new int[n, m];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            num[i, j] = rng.Next(n1, n2 + 1);
                        }
                    }
                    int t = 0;
                    int sum = 0;
                    int count = 99999;
                    if (m / 3 - 1 == 0)
                    {
                        int sh = 1;
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (sh == 1)
                                {
                                    if (j == 3 || j == count)
                                    {
                                        count = j + 4;
                                        num[i, j] = sum;
                                        sum = 0;
                                        sh++;
                                    }
                                    else sum += num[i, j];
                                }
                                else
                                {
                                    sh = 1;
                                    sum = 0;
                                }
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (t != m / 3 - 1)
                                {
                                    if (j == 3 || j == count)
                                    {
                                        count = j + 4;
                                        num[i, j] = sum;
                                        sum = 0;
                                        t++;
                                    }
                                    else sum += num[i, j];
                                }
                                else t = 0;
                            }
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            dataGridViewMatrix_URI.Columns[j].Width = 30;
                            dataGridViewMatrix_URI.Rows[i].Cells[j].Value = num[i, j];
                        }
                    }

                    if ((m / 3 - 1) % 3 == 0 && n < m)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (t != m / 3 - 2)
                                {
                                    if (j == 3 || j == count)
                                    {
                                        count = j + 4;
                                        num[i, j] = sum;
                                        sum = 0;
                                        t++;
                                    }
                                    else sum += num[i, j];
                                }
                                else t = 0;
                            }
                        }
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                if (i % 2 == 0 && j == m - 1)
                                {
                                    int q = Convert.ToInt32(dataGridViewMatrix_URI.Rows[i].Cells[j - 3].Value);
                                    int w = Convert.ToInt32(dataGridViewMatrix_URI.Rows[i].Cells[j - 2].Value);
                                    int a = Convert.ToInt32(dataGridViewMatrix_URI.Rows[i].Cells[j - 1].Value);
                                    dataGridViewMatrix_URI.Rows[i].Cells[j].Value = Convert.ToString(w + a + q);
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
