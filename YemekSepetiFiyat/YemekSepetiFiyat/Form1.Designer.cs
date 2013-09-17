using System.Windows.Forms;
namespace YemekSepetiFiyat
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prgGetPrice = new System.Windows.Forms.ProgressBar();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBurgerKing = new System.Windows.Forms.Button();
            this.btnMcDonalds = new System.Windows.Forms.Button();
            this.btnKFC = new System.Windows.Forms.Button();
            this.btnLittleCeasers = new System.Windows.Forms.Button();
            this.btnPopeyes = new System.Windows.Forms.Button();
            this.btnPizzaHut = new System.Windows.Forms.Button();
            this.btnPapaJohn = new System.Windows.Forms.Button();
            this.btnPizzaPizza = new System.Windows.Forms.Button();
            this.btnPizzaBulls = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.DateTimePicker();
            this.end = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.btnArchive = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemoveHistory = new System.Windows.Forms.Button();
            this.lblRessult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.BackColor = System.Drawing.Color.Transparent;
            this.btnExecute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExecute.Location = new System.Drawing.Point(979, 110);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(106, 22);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Fiyatları Göster";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(104, 110);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(2);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(850, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(31, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "YS Adresi:";
            // 
            // prgGetPrice
            // 
            this.prgGetPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prgGetPrice.Location = new System.Drawing.Point(13, 250);
            this.prgGetPrice.Margin = new System.Windows.Forms.Padding(2);
            this.prgGetPrice.Name = "prgGetPrice";
            this.prgGetPrice.Size = new System.Drawing.Size(1074, 19);
            this.prgGetPrice.TabIndex = 4;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.image,
            this.Firma,
            this.clmProduct,
            this.clmProductDetail,
            this.clmPrice,
            this.ClmnDate});
            this.dgvProducts.Location = new System.Drawing.Point(13, 273);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1073, 406);
            this.dgvProducts.TabIndex = 5;
            // 
            // image
            // 
            this.image.HeaderText = "Durum";
            this.image.Name = "image";
            // 
            // Firma
            // 
            this.Firma.HeaderText = "Firma";
            this.Firma.Name = "Firma";
            // 
            // clmProduct
            // 
            this.clmProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmProduct.HeaderText = "Fiyat";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Width = 54;
            // 
            // clmProductDetail
            // 
            this.clmProductDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmProductDetail.HeaderText = "Ürün";
            this.clmProductDetail.Name = "clmProductDetail";
            this.clmProductDetail.Width = 55;
            // 
            // clmPrice
            // 
            this.clmPrice.HeaderText = "Ürün Detayı";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Width = 750;
            // 
            // ClmnDate
            // 
            this.ClmnDate.HeaderText = "Tarih";
            this.ClmnDate.Name = "ClmnDate";
            // 
            // btnBurgerKing
            // 
            this.btnBurgerKing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBurgerKing.BackgroundImage")));
            this.btnBurgerKing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBurgerKing.Location = new System.Drawing.Point(31, 22);
            this.btnBurgerKing.Margin = new System.Windows.Forms.Padding(2);
            this.btnBurgerKing.Name = "btnBurgerKing";
            this.btnBurgerKing.Size = new System.Drawing.Size(99, 64);
            this.btnBurgerKing.TabIndex = 6;
            this.btnBurgerKing.UseVisualStyleBackColor = true;
            this.btnBurgerKing.Click += new System.EventHandler(this.btnBurgerKing_Click);
            // 
            // btnMcDonalds
            // 
            this.btnMcDonalds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMcDonalds.BackgroundImage")));
            this.btnMcDonalds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMcDonalds.Location = new System.Drawing.Point(134, 22);
            this.btnMcDonalds.Margin = new System.Windows.Forms.Padding(2);
            this.btnMcDonalds.Name = "btnMcDonalds";
            this.btnMcDonalds.Size = new System.Drawing.Size(99, 64);
            this.btnMcDonalds.TabIndex = 7;
            this.btnMcDonalds.UseVisualStyleBackColor = true;
            this.btnMcDonalds.Click += new System.EventHandler(this.btnMcDonalds_Click);
            // 
            // btnKFC
            // 
            this.btnKFC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKFC.BackgroundImage")));
            this.btnKFC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKFC.Location = new System.Drawing.Point(237, 22);
            this.btnKFC.Margin = new System.Windows.Forms.Padding(2);
            this.btnKFC.Name = "btnKFC";
            this.btnKFC.Size = new System.Drawing.Size(99, 64);
            this.btnKFC.TabIndex = 8;
            this.btnKFC.UseVisualStyleBackColor = true;
            this.btnKFC.Click += new System.EventHandler(this.btnKFC_Click);
            // 
            // btnLittleCeasers
            // 
            this.btnLittleCeasers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLittleCeasers.BackgroundImage")));
            this.btnLittleCeasers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLittleCeasers.Location = new System.Drawing.Point(341, 22);
            this.btnLittleCeasers.Margin = new System.Windows.Forms.Padding(2);
            this.btnLittleCeasers.Name = "btnLittleCeasers";
            this.btnLittleCeasers.Size = new System.Drawing.Size(99, 64);
            this.btnLittleCeasers.TabIndex = 9;
            this.btnLittleCeasers.UseVisualStyleBackColor = true;
            this.btnLittleCeasers.Click += new System.EventHandler(this.btnLittleCeasers_Click);
            // 
            // btnPopeyes
            // 
            this.btnPopeyes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPopeyes.BackgroundImage")));
            this.btnPopeyes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPopeyes.Location = new System.Drawing.Point(444, 22);
            this.btnPopeyes.Margin = new System.Windows.Forms.Padding(2);
            this.btnPopeyes.Name = "btnPopeyes";
            this.btnPopeyes.Size = new System.Drawing.Size(99, 64);
            this.btnPopeyes.TabIndex = 10;
            this.btnPopeyes.UseVisualStyleBackColor = true;
            this.btnPopeyes.Click += new System.EventHandler(this.btnPopeyes_Click);
            // 
            // btnPizzaHut
            // 
            this.btnPizzaHut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPizzaHut.BackgroundImage")));
            this.btnPizzaHut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizzaHut.Location = new System.Drawing.Point(547, 22);
            this.btnPizzaHut.Margin = new System.Windows.Forms.Padding(2);
            this.btnPizzaHut.Name = "btnPizzaHut";
            this.btnPizzaHut.Size = new System.Drawing.Size(99, 64);
            this.btnPizzaHut.TabIndex = 11;
            this.btnPizzaHut.UseVisualStyleBackColor = true;
            this.btnPizzaHut.Click += new System.EventHandler(this.btnPizzaHut_Click);
            // 
            // btnPapaJohn
            // 
            this.btnPapaJohn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPapaJohn.BackgroundImage")));
            this.btnPapaJohn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPapaJohn.Location = new System.Drawing.Point(650, 22);
            this.btnPapaJohn.Margin = new System.Windows.Forms.Padding(2);
            this.btnPapaJohn.Name = "btnPapaJohn";
            this.btnPapaJohn.Size = new System.Drawing.Size(99, 64);
            this.btnPapaJohn.TabIndex = 12;
            this.btnPapaJohn.UseVisualStyleBackColor = true;
            this.btnPapaJohn.Click += new System.EventHandler(this.btnPapaJohn_Click);
            // 
            // btnPizzaPizza
            // 
            this.btnPizzaPizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPizzaPizza.BackgroundImage")));
            this.btnPizzaPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizzaPizza.Location = new System.Drawing.Point(753, 22);
            this.btnPizzaPizza.Margin = new System.Windows.Forms.Padding(2);
            this.btnPizzaPizza.Name = "btnPizzaPizza";
            this.btnPizzaPizza.Size = new System.Drawing.Size(99, 64);
            this.btnPizzaPizza.TabIndex = 13;
            this.btnPizzaPizza.UseVisualStyleBackColor = true;
            this.btnPizzaPizza.Click += new System.EventHandler(this.btnPizzaPizza_Click);
            // 
            // btnPizzaBulls
            // 
            this.btnPizzaBulls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPizzaBulls.BackgroundImage")));
            this.btnPizzaBulls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizzaBulls.Location = new System.Drawing.Point(856, 22);
            this.btnPizzaBulls.Margin = new System.Windows.Forms.Padding(2);
            this.btnPizzaBulls.Name = "btnPizzaBulls";
            this.btnPizzaBulls.Size = new System.Drawing.Size(99, 64);
            this.btnPizzaBulls.TabIndex = 14;
            this.btnPizzaBulls.UseVisualStyleBackColor = true;
            this.btnPizzaBulls.Click += new System.EventHandler(this.btnPizzaBulls_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(6, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(284, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(296, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.start.Location = new System.Drawing.Point(70, 24);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(92, 20);
            this.start.TabIndex = 20;
            this.start.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // end
            // 
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.end.Location = new System.Drawing.Point(211, 24);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(92, 20);
            this.end.TabIndex = 21;
            this.end.ValueChanged += new System.EventHandler(this.end_ValueChanged);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStart.Location = new System.Drawing.Point(8, 28);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(66, 13);
            this.lblStart.TabIndex = 22;
            this.lblStart.Text = "Başlangıç:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnd.Location = new System.Drawing.Point(179, 28);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 13);
            this.lblEnd.TabIndex = 23;
            this.lblEnd.Text = "Bitiş:";
            // 
            // btnArchive
            // 
            this.btnArchive.BackColor = System.Drawing.Color.Transparent;
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArchive.Location = new System.Drawing.Point(311, 23);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(104, 23);
            this.btnArchive.TabIndex = 24;
            this.btnArchive.Text = "Ara";
            this.btnArchive.UseVisualStyleBackColor = false;
            this.btnArchive.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(908, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 34);
            this.button1.TabIndex = 27;
            this.button1.Text = "Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnRemoveHistory
            // 
            this.btnRemoveHistory.Location = new System.Drawing.Point(405, 217);
            this.btnRemoveHistory.Name = "btnRemoveHistory";
            this.btnRemoveHistory.Size = new System.Drawing.Size(398, 23);
            this.btnRemoveHistory.TabIndex = 28;
            this.btnRemoveHistory.Text = "***Şu an Geçmişte Arama Yapıyorsunuz Güncel Arama Yapmak için Tıklayın.";
            this.btnRemoveHistory.UseVisualStyleBackColor = true;
            this.btnRemoveHistory.Visible = false;
            this.btnRemoveHistory.Click += new System.EventHandler(this.btnRemoveHistory_Click);
            // 
            // lblRessult
            // 
            this.lblRessult.AutoSize = true;
            this.lblRessult.Image = ((System.Drawing.Image)(resources.GetObject("lblRessult.Image")));
            this.lblRessult.Location = new System.Drawing.Point(27, 222);
            this.lblRessult.Name = "lblRessult";
            this.lblRessult.Size = new System.Drawing.Size(249, 13);
            this.lblRessult.TabIndex = 29;
            this.lblRessult.Text = "        ***Sonuçlar internetten tüm firmalarda aranıyor.";
            this.lblRessult.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnArchive);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.end);
            this.groupBox1.Controls.Add(this.lblStart);
            this.groupBox1.Controls.Add(this.lblEnd);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(471, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 65);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arşiv";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(30, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 65);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Listesi";
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(965, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 98);
            this.label2.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1096, 690);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRessult);
            this.Controls.Add(this.btnRemoveHistory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPizzaBulls);
            this.Controls.Add(this.btnPizzaPizza);
            this.Controls.Add(this.btnPapaJohn);
            this.Controls.Add(this.btnPizzaHut);
            this.Controls.Add(this.btnPopeyes);
            this.Controls.Add(this.btnLittleCeasers);
            this.Controls.Add(this.btnKFC);
            this.Controls.Add(this.btnMcDonalds);
            this.Controls.Add(this.btnBurgerKing);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.prgGetPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = global::YemekSepetiFiyat.Properties.Resources.down1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemek Sepeti Fiyatları";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.myAPP_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //private System.Drawing.Icon same = YemekSepetiFiyat.Properties.Resources.same;
        //private System.Drawing.Icon up = YemekSepetiFiyat.Properties.Resources.up1;
        //private System.Drawing.Icon down = YemekSepetiFiyat.Properties.Resources.down1;

        #endregion

        private System.Windows.Forms.Button btnExecute;

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgGetPrice;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnBurgerKing;
        private System.Windows.Forms.Button btnMcDonalds;
        private System.Windows.Forms.Button btnKFC;
        private System.Windows.Forms.Button btnLittleCeasers;
        private System.Windows.Forms.Button btnPopeyes;
        private System.Windows.Forms.Button btnPizzaHut;
        private System.Windows.Forms.Button btnPapaJohn;
        private System.Windows.Forms.Button btnPizzaPizza;
        private System.Windows.Forms.Button btnPizzaBulls;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnSearch;
        private System.Drawing.Icon same = YemekSepetiFiyat.Properties.Resources.same;
        private System.Drawing.Icon up = YemekSepetiFiyat.Properties.Resources.up1;
        private System.Drawing.Icon down = YemekSepetiFiyat.Properties.Resources.down1;
        private DateTimePicker start;
        private DateTimePicker end;
        private Label lblStart;
        private Label lblEnd;
        private Button btnArchive;
        private Button button1;
        private Button btnRemoveHistory;
        private Label lblRessult;
        private DataGridViewImageColumn image;
        private DataGridViewTextBoxColumn Firma;
        private DataGridViewTextBoxColumn clmProduct;
        private DataGridViewTextBoxColumn clmProductDetail;
        private DataGridViewTextBoxColumn clmPrice;
        private DataGridViewTextBoxColumn ClmnDate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ImageList ımageList2;
        private Label label2;
    }
}

