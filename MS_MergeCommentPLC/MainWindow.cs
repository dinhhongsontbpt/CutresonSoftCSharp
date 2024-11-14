using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS_MergeCommentPLC
{
    public partial class MainWindow : Form
    {
        private string filePath1;
        private string filePath2;
        private string saveFilePath;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSelectFile1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Chọn file CSV thứ nhất"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath1 = openFileDialog.FileName;
                textBox1.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectFile2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Chọn file CSV thứ hai"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath2 = openFileDialog.FileName;
                textBox2.Text = openFileDialog.FileName;
            }
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Chọn thư mục và tên file để lưu",
                DefaultExt = "csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                saveFilePath = saveFileDialog.FileName;
                textBox3.Text = saveFileDialog.FileName;
            }
        }
        private readonly string delimiter = "\t";
        private void btnMergeFiles_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath1) || string.IsNullOrEmpty(filePath2) || string.IsNullOrEmpty(saveFilePath))
            {
                MessageBox.Show("Vui lòng chọn đủ các file và nơi lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Đọc hai dòng đầu tiên của file CSV thứ nhất
                var csv1Header = File.ReadLines(filePath1).Take(2).ToList();

                // Đọc dữ liệu từ dòng thứ 3 trở đi của file CSV thứ nhất và loại bỏ dấu ngoặc kép
                List<string[]> csv1Data = File.ReadLines(filePath1).Skip(2)
                    .Select(line => line.Split('\t')
                        .Select(cell => cell.Replace("\"", "").Trim()) // Loại bỏ dấu ngoặc kép và các khoảng trắng dư thừa
                        .ToArray()).ToList();

                // Đọc dữ liệu từ dòng thứ 3 trở đi của file CSV thứ hai và loại bỏ dấu ngoặc kép
                List<string[]> csv2Data = File.ReadLines(filePath2).Skip(2)
                    .Select(line => line.Split('\t')
                        .Select(cell => cell.Replace("\"", "").Trim()) // Loại bỏ dấu ngoặc kép và các khoảng trắng dư thừa
                        .ToArray()).ToList();

                // Tạo một HashSet để lưu cột 1 của file CSV 1 để so sánh
                HashSet<string> csv1Column1 = new HashSet<string>(csv1Data.Select(row => row[0]));

                // Dữ liệu kết hợp từ file CSV 1 (giữ nguyên hai dòng đầu tiên) và những dòng từ CSV 2 không có trong CSV 1
                List<string[]> mergedData = new List<string[]>(csv1Data);

                // Thêm các dòng từ file 2 vào file 1 nếu cột 1 không có trong file 1
                foreach (var row in csv2Data)
                {
                    if (!csv1Column1.Contains(row[0]))  // Nếu cột 1 của row từ CSV 2 không có trong CSV 1
                    {
                        mergedData.Add(row); // Thêm dòng vào dữ liệu gộp
                    }
                }

                // Tạo file Excel
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (var package = new ExcelPackage(new FileInfo(saveFilePath)))
                {
                    // Tạo worksheet mới
                    var worksheet = package.Workbook.Worksheets.Add("MergedData");

                    // Ghi hai dòng đầu tiên từ file CSV 1 vào worksheet
                    int row = 1;
                    foreach (var headerLine in csv1Header)
                    {
                        worksheet.Cells[row++, 1].Value = headerLine.Replace("\"", "").Trim(); // Loại bỏ dấu ngoặc kép
                    }

                    // Ghi dữ liệu đã gộp vào worksheet, mỗi dòng sẽ ghi vào 2 cột tương ứng
                    foreach (var rowData in mergedData)
                    {
                        worksheet.Cells[row++, 1].Value = rowData[0];  // Cột 1
                        worksheet.Cells[row, 2].Value = rowData[1];    // Cột 2
                    }

                    // Lưu file Excel
                    package.Save();
                }

                MessageBox.Show("Gộp file thành công và lưu dưới dạng Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi trong quá trình gộp file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
