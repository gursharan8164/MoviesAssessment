namespace MoviesAssessment
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVMovies = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVRented = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGVMovNotReturned = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGVBestCust = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.DGVTopMov = new System.Windows.Forms.DataGridView();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.btnUptMovie = new System.Windows.Forms.Button();
            this.btnUptCust = new System.Windows.Forms.Button();
            this.btnDelCust = new System.Windows.Forms.Button();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCustDate = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtMovYear = new System.Windows.Forms.TextBox();
            this.txtMovDate = new System.Windows.Forms.TextBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnTotalCust = new System.Windows.Forms.Button();
            this.btnTotalMov = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPlot = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnMovRentedCount = new System.Windows.Forms.Button();
            this.btnCustRentedCount = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovNotReturned)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBestCust)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMov)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1042, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1034, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomers.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 51;
            this.DGVCustomers.RowTemplate.Height = 24;
            this.DGVCustomers.Size = new System.Drawing.Size(1028, 342);
            this.DGVCustomers.TabIndex = 0;
            this.DGVCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovies);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1034, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVMovies
            // 
            this.DGVMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovies.Location = new System.Drawing.Point(3, 3);
            this.DGVMovies.Name = "DGVMovies";
            this.DGVMovies.RowHeadersWidth = 51;
            this.DGVMovies.RowTemplate.Height = 24;
            this.DGVMovies.Size = new System.Drawing.Size(1028, 342);
            this.DGVMovies.TabIndex = 0;
            this.DGVMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovies_CellContentClick_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVRented);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1034, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movies Rented";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVRented
            // 
            this.DGVRented.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRented.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRented.Location = new System.Drawing.Point(3, 3);
            this.DGVRented.Name = "DGVRented";
            this.DGVRented.RowHeadersWidth = 51;
            this.DGVRented.RowTemplate.Height = 24;
            this.DGVRented.Size = new System.Drawing.Size(1028, 342);
            this.DGVRented.TabIndex = 0;
            this.DGVRented.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRented_CellContentClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGVMovNotReturned);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1034, 348);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Movies Not Returned";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGVMovNotReturned
            // 
            this.DGVMovNotReturned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovNotReturned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMovNotReturned.Location = new System.Drawing.Point(3, 3);
            this.DGVMovNotReturned.Name = "DGVMovNotReturned";
            this.DGVMovNotReturned.RowHeadersWidth = 51;
            this.DGVMovNotReturned.RowTemplate.Height = 24;
            this.DGVMovNotReturned.Size = new System.Drawing.Size(1028, 342);
            this.DGVMovNotReturned.TabIndex = 0;
            this.DGVMovNotReturned.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMovNotReturned_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGVBestCust);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1034, 348);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Best Customers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGVBestCust
            // 
            this.DGVBestCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBestCust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVBestCust.Location = new System.Drawing.Point(3, 3);
            this.DGVBestCust.Name = "DGVBestCust";
            this.DGVBestCust.RowHeadersWidth = 51;
            this.DGVBestCust.RowTemplate.Height = 24;
            this.DGVBestCust.Size = new System.Drawing.Size(1028, 342);
            this.DGVBestCust.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.DGVTopMov);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1034, 348);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Top Movies";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // DGVTopMov
            // 
            this.DGVTopMov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTopMov.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVTopMov.Location = new System.Drawing.Point(3, 3);
            this.DGVTopMov.Name = "DGVTopMov";
            this.DGVTopMov.RowHeadersWidth = 51;
            this.DGVTopMov.RowTemplate.Height = 24;
            this.DGVTopMov.Size = new System.Drawing.Size(1028, 342);
            this.DGVTopMov.TabIndex = 0;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(16, 403);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(129, 23);
            this.btnAddCust.TabIndex = 1;
            this.btnAddCust.Text = "Add Customer";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(16, 505);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(129, 23);
            this.btnAddMovie.TabIndex = 2;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.Location = new System.Drawing.Point(16, 534);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(129, 23);
            this.btnDelMovie.TabIndex = 3;
            this.btnDelMovie.Text = "Delete Movie";
            this.btnDelMovie.UseVisualStyleBackColor = true;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // btnUptMovie
            // 
            this.btnUptMovie.Location = new System.Drawing.Point(16, 563);
            this.btnUptMovie.Name = "btnUptMovie";
            this.btnUptMovie.Size = new System.Drawing.Size(129, 23);
            this.btnUptMovie.TabIndex = 4;
            this.btnUptMovie.Text = "Update Movie";
            this.btnUptMovie.UseVisualStyleBackColor = true;
            this.btnUptMovie.Click += new System.EventHandler(this.btnUptMovie_Click);
            // 
            // btnUptCust
            // 
            this.btnUptCust.Location = new System.Drawing.Point(16, 463);
            this.btnUptCust.Name = "btnUptCust";
            this.btnUptCust.Size = new System.Drawing.Size(129, 23);
            this.btnUptCust.TabIndex = 5;
            this.btnUptCust.Text = "Update Customer";
            this.btnUptCust.UseVisualStyleBackColor = true;
            this.btnUptCust.Click += new System.EventHandler(this.btnUptCust_Click);
            // 
            // btnDelCust
            // 
            this.btnDelCust.Location = new System.Drawing.Point(16, 434);
            this.btnDelCust.Name = "btnDelCust";
            this.btnDelCust.Size = new System.Drawing.Size(129, 23);
            this.btnDelCust.TabIndex = 6;
            this.btnDelCust.Text = "Delete Customer";
            this.btnDelCust.UseVisualStyleBackColor = true;
            this.btnDelCust.Click += new System.EventHandler(this.btnDelCust_Click);
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(151, 464);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.Size = new System.Drawing.Size(56, 22);
            this.txtCustID.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(213, 464);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(124, 22);
            this.txtFirstName.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(470, 464);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(161, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(637, 464);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 10;
            // 
            // txtCustDate
            // 
            this.txtCustDate.Location = new System.Drawing.Point(743, 464);
            this.txtCustDate.Name = "txtCustDate";
            this.txtCustDate.Size = new System.Drawing.Size(175, 22);
            this.txtCustDate.TabIndex = 11;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(151, 537);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(53, 22);
            this.txtMovieID.TabIndex = 12;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(213, 537);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(496, 22);
            this.txtMovieName.TabIndex = 13;
            // 
            // txtMovYear
            // 
            this.txtMovYear.Location = new System.Drawing.Point(715, 537);
            this.txtMovYear.Name = "txtMovYear";
            this.txtMovYear.Size = new System.Drawing.Size(86, 22);
            this.txtMovYear.TabIndex = 14;
            // 
            // txtMovDate
            // 
            this.txtMovDate.Location = new System.Drawing.Point(807, 537);
            this.txtMovDate.Name = "txtMovDate";
            this.txtMovDate.Size = new System.Drawing.Size(111, 22);
            this.txtMovDate.TabIndex = 15;
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Green;
            this.btnReturn.Location = new System.Drawing.Point(952, 403);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 69);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.ForeColor = System.Drawing.Color.Red;
            this.btnIssue.Location = new System.Drawing.Point(952, 486);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(98, 69);
            this.btnIssue.TabIndex = 17;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnTotalCust
            // 
            this.btnTotalCust.Location = new System.Drawing.Point(676, 403);
            this.btnTotalCust.Name = "btnTotalCust";
            this.btnTotalCust.Size = new System.Drawing.Size(125, 23);
            this.btnTotalCust.TabIndex = 18;
            this.btnTotalCust.Text = "Total Customers";
            this.btnTotalCust.UseVisualStyleBackColor = true;
            this.btnTotalCust.Click += new System.EventHandler(this.btnTotalCust_Click);
            // 
            // btnTotalMov
            // 
            this.btnTotalMov.Location = new System.Drawing.Point(807, 403);
            this.btnTotalMov.Name = "btnTotalMov";
            this.btnTotalMov.Size = new System.Drawing.Size(125, 23);
            this.btnTotalMov.TabIndex = 19;
            this.btnTotalMov.Text = "Total Movies";
            this.btnTotalMov.UseVisualStyleBackColor = true;
            this.btnTotalMov.Click += new System.EventHandler(this.btnTotalMov_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "CustID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(210, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(467, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Address";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(634, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Phone N.O.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(343, 464);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(121, 22);
            this.txtLastName.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(345, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(740, 437);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Date Added";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(153, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "MovieID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(247, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 23);
            this.label8.TabIndex = 29;
            this.label8.Text = "Title";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(710, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "Year";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(156, 578);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "Genre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(259, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "Rating";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(276, 601);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(66, 22);
            this.txtRating.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(348, 578);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 23);
            this.label12.TabIndex = 36;
            this.label12.Text = "Plot";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPlot
            // 
            this.txtPlot.Location = new System.Drawing.Point(348, 601);
            this.txtPlot.Name = "txtPlot";
            this.txtPlot.Size = new System.Drawing.Size(358, 22);
            this.txtPlot.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(804, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Date Added";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(151, 601);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(119, 22);
            this.txtGenre.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(713, 577);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 23);
            this.label14.TabIndex = 40;
            this.label14.Text = "Rental Cost";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(712, 601);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 22);
            this.txtRentalCost.TabIndex = 41;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(16, 601);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(129, 23);
            this.btnClearAll.TabIndex = 42;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnMovRentedCount
            // 
            this.btnMovRentedCount.Location = new System.Drawing.Point(941, 573);
            this.btnMovRentedCount.Name = "btnMovRentedCount";
            this.btnMovRentedCount.Size = new System.Drawing.Size(109, 52);
            this.btnMovRentedCount.TabIndex = 43;
            this.btnMovRentedCount.Text = "# of Movie Rentals";
            this.btnMovRentedCount.UseVisualStyleBackColor = true;
            this.btnMovRentedCount.Click += new System.EventHandler(this.btnMovRentedCount_Click);
            // 
            // btnCustRentedCount
            // 
            this.btnCustRentedCount.Location = new System.Drawing.Point(826, 573);
            this.btnCustRentedCount.Name = "btnCustRentedCount";
            this.btnCustRentedCount.Size = new System.Drawing.Size(109, 52);
            this.btnCustRentedCount.TabIndex = 44;
            this.btnCustRentedCount.Text = "# of Customer Rentals";
            this.btnCustRentedCount.UseVisualStyleBackColor = true;
            this.btnCustRentedCount.Click += new System.EventHandler(this.btnCustRentedCount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1066, 640);
            this.Controls.Add(this.btnCustRentedCount);
            this.Controls.Add(this.btnMovRentedCount);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtPlot);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTotalMov);
            this.Controls.Add(this.btnTotalCust);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txtMovDate);
            this.Controls.Add(this.txtMovYear);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtCustDate);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtCustID);
            this.Controls.Add(this.btnDelCust);
            this.Controls.Add(this.btnUptCust);
            this.Controls.Add(this.btnUptMovie);
            this.Controls.Add(this.btnDelMovie);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovies)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRented)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovNotReturned)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBestCust)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTopMov)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVCustomers;
        // private System.Windows.Forms.DataGridView DGVRentedDGVMovies;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVRented;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.Button btnUptMovie;
        private System.Windows.Forms.Button btnUptCust;
        private System.Windows.Forms.Button btnDelCust;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCustDate;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtMovYear;
        private System.Windows.Forms.TextBox txtMovDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnTotalCust;
        private System.Windows.Forms.Button btnTotalMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPlot;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.DataGridView DGVMovies;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnMovRentedCount;
        private System.Windows.Forms.Button btnCustRentedCount;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGVBestCust;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView DGVTopMov;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView DGVMovNotReturned;
    }
}

