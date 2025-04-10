using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Speech.Synthesis;
using System.Diagnostics;
namespace ProjectTuDien
{
    public partial class TuDienSieuCap : Form
    {
        private MyHashTable tudien = new MyHashTable();//Tao Dictionary de luu tu 

        AutoCompleteStringCollection TuDongDien = new AutoCompleteStringCollection();//TuDongDien tạo ở đây có thể truy cấp bất cứ đâu
        AutoCompleteStringCollection TuDongDienVietAnh = new AutoCompleteStringCollection();//danh cho viet anh
        private SpeechSynthesizer MayDoc = new SpeechSynthesizer(); // Tạo đối tượng đọc
        private MyHashTable tuDienDaoNguoc = new MyHashTable();//Tu dien Viet sang Anh
        public TuDienSieuCap()
        {
            InitializeComponent();
            LoadDictionary(); // Đọc dữ liệu từ file
            LoadLichSuTuFile();//Đọc dữ lieu lịch sử từ file
            SearchButton.Click += TimKiemTu; // Gán sự kiện click cho nút Search
                                             // Dung += để SearchButton không xóa mà chỉ thêm vô nhưng hàm mới từ những hàm có trước
            ThemTu.Click += ThemTu_Click;
            XacNhan.Click += XacNhanThemTu;
            XoaTu.Click += XoaTu_Click;
            DocTu.Click += DocTu_Click;
            AnhViet.Click += AnhViet_Click;
            XoaLichSu.Click += XoaLichSu_Click;
            buttonX.Click += Dongtab;
        }
        private void Dongtab(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadDictionary()
        {
            string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\dulieu.txt"; // Đặt đường dẫn 

            if (File.Exists(filePath))
            {

                foreach (string line in File.ReadAllLines(filePath))
                {
                    string[] parts = line.Split(';');//Tách chữ từ dữ liệu đầu vào
                    // Cos 4 phần từ, từ loại, phiên âm và nghĩa. 
                    if (parts.Length == 4)
                    {
                        string word = parts[0].Trim().ToLower(); // Lưu từ vào từ điển
                        string nghiaTiengViet = parts[3].Trim().ToLower(); // Lấy nghĩa để làm key cho tudien tiếng Việt
                        tudien.Add(word, $"{parts[1].Trim()}\n[{parts[2].Trim()}]\n{parts[3]}");

                        // Thêm vào danh sách gợi ý Anh - Việt
                        TuDongDien.Add(word);

                        // Thêm vào danh sách gợi ý Việt - Anh
                        TuDongDienVietAnh.Add(nghiaTiengViet);

                        // Thêm vào từ điển đảo ngược (Việt - Anh)
                        if (tudien.TryGetValue(word, out string value))
                        {
                            tuDienDaoNguoc.Add(nghiaTiengViet, value + "\n" + word);
                        }
                    }
                }
                ThanhSearch.AutoCompleteCustomSource = TuDongDien;
                ThanhSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ThanhSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else
            {
                MessageBox.Show("File dữ liệu không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TimKiemTu(object sender, EventArgs e)
        {
            string tunhapvao = ThanhSearch.Text.Trim().ToLower(); // Chuyển từ nhập vào thành lowercase
            //Điều kiện để: LICH SU SEARCCH
            if (!string.IsNullOrWhiteSpace(tunhapvao))
            {
                CapNhatLichSu(tunhapvao); // Gọi hàm cập nhật lịch sử
            }
            //Điều kiện để: check autocomplete
            if (ThanhSearch.AutoCompleteCustomSource == TuDongDien)
            {
                // Tìm bình thường Anh - Việt
                if (tudien.TryGetValue(tunhapvao, out string meaning))
                    Result.Text = meaning;
                else
                    Result.Text = "Không tìm thấy!";
            }
            else if (ThanhSearch.AutoCompleteCustomSource == TuDongDienVietAnh)
            {
                // Tìm bình thường Viet - Anh
                if (tuDienDaoNguoc.TryGetValue(tunhapvao, out string meaning))
                    Result.Text = meaning;
                else
                    Result.Text = "Không tìm thấy!";
            }
            //Điều kiện để: hiện nút đọc
            if (!string.IsNullOrWhiteSpace(ThanhSearch.Text) && Result.Text != "Không tìm thấy!")
            {
                DocTu.Visible = true;
            }
            else
            {
                DocTu.Visible = false;
            }
        }
        private void ThemTu_Click(object sender, EventArgs e)
        {    if(AnhViet.Text == "Việt-Anh")
            {
                MessageBox.Show("Chức năng chỉ hoạt động khi nhập tiếng Anh \n hãy chuyển sang  Anh-Việt trước đã.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DocTu.Visible=false;//Phòng trường hợp đã nhập 1 từ và nút đọc từ đang hiện sau đó ấn thêm nút thêm từ và đọc từ chưa tắt làm chèn cá nút khác
            AddTu.Visible = true;  // Hiện textbox nhập từ
            XacNhan.Visible = true; // Hiện nút xác nhận thêm từ
            
            Result.Text = " Hãy nhập theo mẫu: từ;từ loại;phiên âm;nghĩa";
        }
        private void XacNhanThemTu(object sender, EventArgs e)
        {
            // Nhap tu và tách chuỗi
            string input = AddTu.Text.Trim();
            string[] parts = input.Split(';');
            //Kiem Tra
            if (parts.Length == 4)
            {
                string word = parts[0].Trim().ToLower();
                string meaning = $"{parts[1].Trim()}\n[{parts[2].Trim()}]\n{parts[3].Trim()}";
                string nghiaTiengViet = parts[3].Trim().ToLower(); // Lấy nghĩa tiếng Việt
                if (!tudien.ContainsKey(word))
                {
                    tudien.Add(word, meaning);
                    TuDongDien.Add(word); // Cập nhật gợi ý
                    ThanhSearch.AutoCompleteCustomSource = TuDongDien; // Cập nhật danh sách gợi ý

                    // Lưu vào từ file từ điển
                    string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\dulieu.txt";
                    File.AppendAllText(filePath, $"\n\r{word};{parts[1].Trim()};{parts[2].Trim()};{parts[3].Trim()}");

                    // Cập nhật từ điển Việt - Anh
                    CapNhatTuDienVietAnh(word, nghiaTiengViet, true);

                    MessageBox.Show("Thêm từ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Từ này đã có trong từ điển!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Sai định dạng! Hãy nhập theo mẫu: từ;từ loại;phiên âm;nghĩa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Ẩn textbox sau khi thêm
            AddTu.Visible = false;
            XacNhan.Visible = false;
            AddTu.Text = "";
            Result.Text = "Nghĩa ở đây";
        }
        private void XoaTu_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\dulieu.txt";
            string TuMuonXoa = ThanhSearch.Text.Trim().ToLower();
            //Xoa từ trong Dictionary
            if (ThanhSearch.AutoCompleteCustomSource == TuDongDien) //Dang o trang thai tieng ANH
            {
                if (!tudien.ContainsKey(TuMuonXoa))
                {
                    MessageBox.Show("Không tìm thấy từ cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lưu nghĩa tiếng Việt trước khi xóa
                string nghiaTiengViet = "";
                if (tudien.TryGetValue(TuMuonXoa, out string nghia))
                {
                    nghiaTiengViet = nghia.Split('\n')[2].Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nghĩa của từ để xoá!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Xóa khỏi Dictionary Anh - Việt
                tudien.Remove(TuMuonXoa);
                //Cap nhat tudongdien
                TuDongDien.Remove(TuMuonXoa);
                ThanhSearch.AutoCompleteCustomSource = TuDongDien;//Cap mhat thanh autocomplete TA
                TuDongDienVietAnh.Remove(nghiaTiengViet);
                // Xóa khỏi Dictionary Việt - Anh (ngược lại)
                CapNhatTuDienVietAnh(TuMuonXoa, nghiaTiengViet, false);
            }
            else if (ThanhSearch.AutoCompleteCustomSource == TuDongDienVietAnh) // Dang o trang thai tIENG VIET
            {
                if (!tuDienDaoNguoc.ContainsKey(TuMuonXoa))
                {
                    MessageBox.Show("Không tìm thấy từ cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Lưu từ tiếng Anh trước khi xóa
                string tuTiengAnh = "";
                if (tuDienDaoNguoc.TryGetValue(TuMuonXoa, out string nghiaDaoNguoc))
                {
                    tuTiengAnh = nghiaDaoNguoc.Split('\n')[3].Trim();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nghĩa đảo ngược!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Xóa khỏi Dictionary Việt - Anh
                tuDienDaoNguoc.Remove(TuMuonXoa);
                TuDongDien.Remove(tuTiengAnh);
                TuDongDienVietAnh.Remove(TuMuonXoa);
                  ThanhSearch.AutoCompleteCustomSource = TuDongDienVietAnh;
                // Xóa khỏi Dictionary Anh - Việt
                tudien.Remove(tuTiengAnh);
            }
            // Xóa từ trong file dữ liệu
            var lines = File.ReadAllLines(filePath)
                            .Where(line => !line.StartsWith(TuMuonXoa + ";"))
                            .ToList();
            File.WriteAllLines(filePath, lines);
            MessageBox.Show("Xóa từ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DocTu_Click(object sender, EventArgs e)
        {
            string tuCanDoc = ThanhSearch.Text.Trim(); // Lấy từ trong ô tìm kiếm
            if (ThanhSearch.AutoCompleteCustomSource == TuDongDien) //Che do Anh-Viet
            {
                MayDoc.SelectVoice("Microsoft Zira Desktop");
                MayDoc.SpeakAsync(tuCanDoc);
            }
            else//Che do Viet-anh
            {
                tuDienDaoNguoc.TryGetValue(tuCanDoc, out string nghia);
                string[] a = nghia.Split('\n');
                string b = a[3];
                MayDoc.SelectVoice("Microsoft Zira Desktop");
                MayDoc.SpeakAsync(b);
            }
        }
        private void AnhViet_Click(object sender, EventArgs e)
        {
            if (ThanhSearch.AutoCompleteCustomSource == TuDongDien)
            {
                ThanhSearch.AutoCompleteCustomSource = TuDongDienVietAnh;
                AnhViet.Text = "Việt-Anh";
            }
            else
            {
                ThanhSearch.AutoCompleteCustomSource = TuDongDien;
                AnhViet.Text = "Anh-Việt";
            }

            // Đảm bảo AutoCompleteSource vẫn là CustomSource
            ThanhSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //Chỉ thêm từ mới sử dụng tuTiengAnh còn xóa thì kiếm đại cái nào cho có.
        private void CapNhatTuDienVietAnh(string tuTiengAnh, string nghiaTiengViet, bool isAdding)
        {
            if (isAdding) // Nếu đang thêm từ
            {
                if (!tuDienDaoNguoc.ContainsKey(nghiaTiengViet))
                {
                    if (tudien.TryGetValue(tuTiengAnh, out string nghia))
                    {
                        tuDienDaoNguoc.Add(nghiaTiengViet, nghia + "\n" + tuTiengAnh);
                    }
                }
                TuDongDienVietAnh.Add(nghiaTiengViet);
            }
            else // Nếu đang xóa từ
            {
                if (tuDienDaoNguoc.ContainsKey(nghiaTiengViet))
                {
                    tuDienDaoNguoc.Remove(nghiaTiengViet);
                }
                TuDongDienVietAnh.Remove(nghiaTiengViet);
            }
            // Cập nhật autocomplete nếu đang ở chế độ Việt - Anh
            if (ThanhSearch.AutoCompleteCustomSource == TuDongDienVietAnh)
            {
                ThanhSearch.AutoCompleteCustomSource = TuDongDienVietAnh;
            }
        }
        private void LoadLichSuTuFile()
        {
            string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\lichsu.txt";

            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                        LichSuSearch.Items.Add(line.Trim());
                }
            }
        }
        private void CapNhatLichSu(string tunhapvao)
        {
            string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\lichsu.txt";
            LichSuSearch.Items.Add(tunhapvao);
            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath,$"{tunhapvao}\r\n");
            }
            else
            {
                MessageBox.Show("File lịch sử không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void XoaLichSu_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\PHAT\Downloads\FinishedDictionary\DictionaryProject\lichsu.txt";
            LichSuSearch.Items.Clear();
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);
                LoadLichSuTuFile();
            }
            else
            {
                MessageBox.Show("File lịch sử không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void AddTu_TextChanged(object sender, EventArgs e)
        {
        }
        private void XacNhan_Click(object sender, EventArgs e)
        {
        }

        private void av_Click(object sender, EventArgs e)
        {

        }

        private void XoaTu_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void TuDienSieuCap_Load(object sender, EventArgs e)
        {

        }

        private void LichSuSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XoaLichSu_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
    public class MyHashTable
    {
        private class Node
        {
            public string Key;
            public string Value;
            public Node Next;

            public Node(string key, string value)
            {
                Key = key;
                Value = value;
                Next = null;
            }
        }

        private const int Size = 1000;
        private Node[] buckets;

        public MyHashTable()
        {
            buckets = new Node[Size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            foreach (char c in key)
            {
                hash = (hash * 31 + c) % Size;
            }
            return hash;
        }

        public void Add(string key, string value)
        {
            int index = Hash(key);
            Node head = buckets[index];

            // Kiểm tra nếu key đã tồn tại thì cập nhật lại
            while (head != null)
            {
                if (head.Key == key)
                {
                    head.Value = value;
                    return;
                }
                head = head.Next;
            }

            Node newNode = new Node(key, value);
            newNode.Next = buckets[index];
            buckets[index] = newNode;
        }

        public bool TryGetValue(string key, out string value)
        {
            int index = Hash(key);
            Node head = buckets[index];
            while (head != null)
            {
                if (head.Key == key)
                {
                    value = head.Value;
                    return true;
                }
                head = head.Next;
            }

            value = null;
            return false;
        }

        public bool ContainsKey(string key)
        {
            return TryGetValue(key, out _);
        }

        public void Remove(string key)
        {
            int index = Hash(key);
            Node head = buckets[index];
            Node prev = null;

            while (head != null)
            {
                if (head.Key == key)
                {
                    if (prev == null)
                        buckets[index] = head.Next;
                    else
                        prev.Next = head.Next;

                    return;
                }

                prev = head;
                head = head.Next;
            }
        }

        public List<string> GetAllKeys()
        {
            List<string> keys = new List<string>();
            foreach (var bucket in buckets)
            {
                Node current = bucket;
                while (current != null)
                {
                    keys.Add(current.Key);
                    current = current.Next;
                }
            }
            return keys;
        }
    }

}
