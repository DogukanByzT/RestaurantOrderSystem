using RestaurantTerminalSystem.UI.Forms;

namespace RestaurantTerminalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            LoadProducts();


        }

        private List<decimal> totalPrice = new List<decimal>();



        private void LoadProducts()
        {
            var products = new List<(string Name, decimal Price, string ImagePath)>
        {
        ("�ay", 20.00m, "C:\\Users\\doguk\\Desktop\\TerminalSystem\\RestaurantTerminalSystem\\RestaurantTerminalSystem\\Images\\cay.png")

        };
            foreach (var product in products)
            {
                // Her �r�n i�in panel olu�tur
                var productPanel = new Panel
                {
                    Width = 160,
                    Height = 160,
                    BorderStyle = BorderStyle.Fixed3D,
                    Margin = new Padding(10),
                    Tag = product // �r�n bilgisini sakla
                };
                productPanel.Click += ProductPanel_Click;
                var pictureBox = new PictureBox
                {
                    ImageLocation = product.ImagePath,
                    SizeMode = PictureBoxSizeMode.CenterImage,
                    Dock = DockStyle.Top,
                    Height = 100,
                    Width = 100,
                };

                // �r�n ad�
                var nameLabel = new Label
                {
                    Text = product.Name,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };

                // �r�n fiyat�
                var priceLabel = new Label
                {
                    Text = $"Fiyat: {product.Price:C}",
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 10)
                };

                // Kontrolleri panele ekle
                productPanel.Controls.Add(priceLabel);
                productPanel.Controls.Add(nameLabel);
                productPanel.Controls.Add(pictureBox);

                // FlowLayoutPanel'e ekle
                flowLayoutPanel1.Controls.Add(productPanel);
            }

        }

        private void ProductPanel_Click(object sender, EventArgs e)
        {
            var clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                // Panelin Tag'ine atanm�� ValueTuple'� al
                var product = ((string Name, decimal Price, string ImagePath))clickedPanel.Tag;
                int yOffset = pnlHeader.Height + (pnlBasket.Controls.Count * 30); // pnlHeader'�n y�ksekli�i + her kontrol i�in 30 piksel bo�luk
                // Yeni bir Label olu�tur ve �r�n bilgilerini yazd�r
                var lblProductInfo = new Label
                {
                    Text = $"{product.Name} - {product.Price:C}",
                    AutoSize = true,
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TabIndex = 1,
                    Location = new Point(10, yOffset)
                };

                pnlBasket.Controls.Add(lblProductInfo);
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
           
        }
    }
}
