using Microsoft.EntityFrameworkCore;
using RestaurantTerminalSystem.DataAccess.Context;
using RestaurantTerminalSystem.Entities.Entities;
using RestaurantTerminalSystem.UI.Forms;
using RestaurantTerminalSystem.UI.Forms.AdminForms;
using System.Text;

namespace RestaurantTerminalSystem
{
    public partial class MainForm : Form
    {
        private readonly ApplicationDbContext _context;
        public MainForm()
        {
            _context = new ApplicationDbContext();
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            LoadProducts();


        }

        private List<decimal> totalPrice = new List<decimal>();



        private void LoadProducts(string categoryName = null)
        {
            flowLayoutPanel1.Controls.Clear(); // Paneli temizle

            var products = string.IsNullOrEmpty(categoryName)
                    ? _context.Products.Include(p => p.Category).OrderByDescending(p => p.Price).ToList() // Fiyatı en yüksekten en düşüğe sıralama
                    : _context.Products.Include(p => p.Category)
                        .Where(p => p.Category.Name == categoryName)
                        .OrderByDescending(p => p.Price) // Fiyatı en yüksekten en düşüğe sıralama
                        .ToList();

            foreach (var product in products)
            {
                var productPanel = new Panel
                {
                    Width = 160,
                    Height = 160,
                    BorderStyle = BorderStyle.Fixed3D,
                    Margin = new Padding(25),
                    Tag = product // Ürün bilgisini sakla
                };
                productPanel.Click += ProductPanel_Click;

                // Resim verisini PictureBox'a yükle
                var pictureBox = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Dock = DockStyle.Top,
                    Height = 100,
                    Width = 100
                };

                if (product.Image != null && product.Image.Length > 0)
                {
                    using (var ms = new MemoryStream(product.Image))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                pictureBox.Click += (s, e) => ProductPanel_Click(productPanel, e); // PictureBox için tıklama olayı

                var nameLabel = new Label
                {
                    Text = product.Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = ColorTranslator.FromHtml("#33745"),
                };
                nameLabel.Click += (s, e) => ProductPanel_Click(productPanel, e); // Label için tıklama olayı

                var priceLabel = new Label
                {
                    Text = $"Fiyat: {product.Price:C}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10)
                };
                priceLabel.Click += (s, e) => ProductPanel_Click(productPanel, e); // Label için tıklama olayı

                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(pictureBox);
                flowLayoutPanel1.Controls.Add(productPanel);
            }
        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            var clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                // Panelin Tag'ine atanmış Product nesnesini al
                var product = (Product)clickedPanel.Tag;
                if (product == null) return;

                int yOffset = pnlHeader.Height + (pnlBasket.Controls.Count * 30); // pnlHeader yüksekliği + boşluk

                // Yeni bir Label oluştur ve ürün bilgilerini yazdır
                var lblProductInfo = new Label
                {
                    Text = $"{product.Name} - {product.Price:C}",
                    AutoSize = true,
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    Font = new Font("Arial", 9, FontStyle.Bold),
                    TabIndex = 1,
                    Location = new Point(10, yOffset),
                    ForeColor = ColorTranslator.FromHtml("#33745"),
                };

                pnlBasket.Controls.Add(lblProductInfo);

                totalPrice.Add(product.Price);
                UpdateTotalPrice();
            }
        }

        private void UpdateTotalPrice()
        {
            decimal total = totalPrice.Sum();

            lblTotal.Text = $"Toplam: {total.ToString()} TL";
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();

        }

        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            LoadProducts("Ana Yemekler");
        }


        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (pnlBasket.Controls.Count <= 0)
            {
                MessageBox.Show("Sepet boş, fiş oluşturulamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder receipt = new StringBuilder();
            receipt.AppendLine("----- Fiş -----");
            receipt.AppendLine($"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm:ss}");
            receipt.AppendLine();

            decimal total = 0;
            foreach (Label lblProduct in pnlBasket.Controls.OfType<Label>())
            {
                receipt.AppendLine(lblProduct.Text);
                // Ürün fiyatını etiketten al ve toplam fiyatı hesapla
                string[] parts = lblProduct.Text.Split('-');
                if (parts.Length > 1 && decimal.TryParse(parts[1].Trim(' ', '₺'), out decimal price))
                {
                    total += price;
                }
            }

            receipt.AppendLine();
            receipt.AppendLine($"Toplam Fiyat: {total:C}");
            receipt.AppendLine("----------------");

            // Fişi göstermek için MessageBox kullanabilirsiniz
            MessageBox.Show(receipt.ToString(), "Fiş", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadProducts("Tatlılar");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadProducts("İçecekler");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadProducts("Çorbalar");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadProducts("Yan Ürünler");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadProducts("Salatalar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}
