namespace _9lab
{
    partial class Request
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
            this.Run = new System.Windows.Forms.Button();
            this.Check = new System.Windows.Forms.Button();
            this.RequestControl = new System.Windows.Forms.TabControl();
            this.Fields = new System.Windows.Forms.TabPage();
            this.SelectedFields = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectLabel = new System.Windows.Forms.Label();
            this.AllLabel = new System.Windows.Forms.Label();
            this.DoubleLeft = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.DoubleRight = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.AllFields = new System.Windows.Forms.ListView();
            this.FieldName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FieldType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Conditions = new System.Windows.Forms.TabPage();
            this.ValueBox = new System.Windows.Forms.ComboBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.JoinLabel1 = new System.Windows.Forms.Label();
            this.ValueLabel1 = new System.Windows.Forms.Label();
            this.CriterionLabel1 = new System.Windows.Forms.Label();
            this.NameLabel1 = new System.Windows.Forms.Label();
            this.JoinBox = new System.Windows.Forms.ComboBox();
            this.CriterionBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.ComboBox();
            this.ConditionsList = new System.Windows.Forms.ListView();
            this.Order = new System.Windows.Forms.TabPage();
            this.SortSelectedFields = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SortAllFields = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderBox = new System.Windows.Forms.GroupBox();
            this.DESC = new System.Windows.Forms.RadioButton();
            this.ASC = new System.Windows.Forms.RadioButton();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.DoubleLeft1 = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.DoubleRight1 = new System.Windows.Forms.Button();
            this.Right1 = new System.Windows.Forms.Button();
            this.SelectedFieldsLabel = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RequestControl.SuspendLayout();
            this.Fields.SuspendLayout();
            this.Conditions.SuspendLayout();
            this.Order.SuspendLayout();
            this.OrderBox.SuspendLayout();
            this.Result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Run
            // 
            this.Run.Enabled = false;
            this.Run.Location = new System.Drawing.Point(549, 443);
            this.Run.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(155, 28);
            this.Run.TabIndex = 5;
            this.Run.Text = "Выполнить запрос";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Check
            // 
            this.Check.Enabled = false;
            this.Check.Location = new System.Drawing.Point(413, 443);
            this.Check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(123, 28);
            this.Check.TabIndex = 3;
            this.Check.Text = "Просмотр SQL";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // RequestControl
            // 
            this.RequestControl.Controls.Add(this.Fields);
            this.RequestControl.Controls.Add(this.Conditions);
            this.RequestControl.Controls.Add(this.Order);
            this.RequestControl.Controls.Add(this.Result);
            this.RequestControl.Location = new System.Drawing.Point(16, 15);
            this.RequestControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RequestControl.Name = "RequestControl";
            this.RequestControl.SelectedIndex = 0;
            this.RequestControl.Size = new System.Drawing.Size(1065, 421);
            this.RequestControl.TabIndex = 4;
            // 
            // Fields
            // 
            this.Fields.BackColor = System.Drawing.Color.Azure;
            this.Fields.Controls.Add(this.SelectedFields);
            this.Fields.Controls.Add(this.SelectLabel);
            this.Fields.Controls.Add(this.AllLabel);
            this.Fields.Controls.Add(this.DoubleLeft);
            this.Fields.Controls.Add(this.Left);
            this.Fields.Controls.Add(this.DoubleRight);
            this.Fields.Controls.Add(this.Right);
            this.Fields.Controls.Add(this.AllFields);
            this.Fields.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Fields.Location = new System.Drawing.Point(4, 25);
            this.Fields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fields.Name = "Fields";
            this.Fields.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Fields.Size = new System.Drawing.Size(1057, 392);
            this.Fields.TabIndex = 0;
            this.Fields.Text = "Поля";
            // 
            // SelectedFields
            // 
            this.SelectedFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3});
            this.SelectedFields.FullRowSelect = true;
            this.SelectedFields.Location = new System.Drawing.Point(605, 47);
            this.SelectedFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedFields.Name = "SelectedFields";
            this.SelectedFields.Size = new System.Drawing.Size(425, 270);
            this.SelectedFields.TabIndex = 8;
            this.SelectedFields.TileSize = new System.Drawing.Size(150, 30);
            this.SelectedFields.UseCompatibleStateImageBehavior = false;
            this.SelectedFields.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя поля";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Имя таблицы";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип поля";
            this.columnHeader3.Width = 100;
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(601, 27);
            this.SelectLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(125, 17);
            this.SelectLabel.TabIndex = 7;
            this.SelectLabel.Text = "Выбранные поля:";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Location = new System.Drawing.Point(17, 27);
            this.AllLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(72, 17);
            this.AllLabel.TabIndex = 6;
            this.AllLabel.Text = "Все поля:";
            // 
            // DoubleLeft
            // 
            this.DoubleLeft.Location = new System.Drawing.Point(477, 219);
            this.DoubleLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleLeft.Name = "DoubleLeft";
            this.DoubleLeft.Size = new System.Drawing.Size(100, 28);
            this.DoubleLeft.TabIndex = 4;
            this.DoubleLeft.Text = "<<";
            this.DoubleLeft.UseVisualStyleBackColor = true;
            this.DoubleLeft.Click += new System.EventHandler(this.DoubleLeft_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(477, 148);
            this.Left.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(100, 28);
            this.Left.TabIndex = 3;
            this.Left.Text = "<";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // DoubleRight
            // 
            this.DoubleRight.Location = new System.Drawing.Point(477, 183);
            this.DoubleRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleRight.Name = "DoubleRight";
            this.DoubleRight.Size = new System.Drawing.Size(100, 28);
            this.DoubleRight.TabIndex = 2;
            this.DoubleRight.Text = ">>";
            this.DoubleRight.UseVisualStyleBackColor = true;
            this.DoubleRight.Click += new System.EventHandler(this.DoubleRight_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(477, 112);
            this.Right.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(100, 28);
            this.Right.TabIndex = 1;
            this.Right.Text = ">";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // AllFields
            // 
            this.AllFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FieldName,
            this.TableName,
            this.FieldType});
            this.AllFields.FullRowSelect = true;
            this.AllFields.Location = new System.Drawing.Point(21, 47);
            this.AllFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AllFields.Name = "AllFields";
            this.AllFields.Size = new System.Drawing.Size(425, 270);
            this.AllFields.TabIndex = 0;
            this.AllFields.TileSize = new System.Drawing.Size(150, 30);
            this.AllFields.UseCompatibleStateImageBehavior = false;
            this.AllFields.View = System.Windows.Forms.View.Details;
            // 
            // FieldName
            // 
            this.FieldName.Text = "Имя поля";
            this.FieldName.Width = 106;
            // 
            // TableName
            // 
            this.TableName.Text = "Имя таблицы";
            this.TableName.Width = 106;
            // 
            // FieldType
            // 
            this.FieldType.Text = "Тип поля";
            this.FieldType.Width = 100;
            // 
            // Conditions
            // 
            this.Conditions.BackColor = System.Drawing.Color.Azure;
            this.Conditions.Controls.Add(this.ValueBox);
            this.Conditions.Controls.Add(this.Remove);
            this.Conditions.Controls.Add(this.Add);
            this.Conditions.Controls.Add(this.JoinLabel1);
            this.Conditions.Controls.Add(this.ValueLabel1);
            this.Conditions.Controls.Add(this.CriterionLabel1);
            this.Conditions.Controls.Add(this.NameLabel1);
            this.Conditions.Controls.Add(this.JoinBox);
            this.Conditions.Controls.Add(this.CriterionBox);
            this.Conditions.Controls.Add(this.NameBox);
            this.Conditions.Controls.Add(this.ConditionsList);
            this.Conditions.Location = new System.Drawing.Point(4, 25);
            this.Conditions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Conditions.Name = "Conditions";
            this.Conditions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Conditions.Size = new System.Drawing.Size(1057, 392);
            this.Conditions.TabIndex = 1;
            this.Conditions.Text = "Условия";
            // 
            // ValueBox
            // 
            this.ValueBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ValueBox.FormattingEnabled = true;
            this.ValueBox.Location = new System.Drawing.Point(429, 283);
            this.ValueBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ValueBox.Name = "ValueBox";
            this.ValueBox.Size = new System.Drawing.Size(200, 24);
            this.ValueBox.TabIndex = 15;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(700, 330);
            this.Remove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(133, 28);
            this.Remove.TabIndex = 14;
            this.Remove.Text = "Удалить";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(544, 330);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(133, 28);
            this.Add.TabIndex = 13;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // JoinLabel1
            // 
            this.JoinLabel1.AutoSize = true;
            this.JoinLabel1.Location = new System.Drawing.Point(660, 263);
            this.JoinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoinLabel1.Name = "JoinLabel1";
            this.JoinLabel1.Size = new System.Drawing.Size(58, 17);
            this.JoinLabel1.TabIndex = 12;
            this.JoinLabel1.Text = "Связка:";
            // 
            // ValueLabel1
            // 
            this.ValueLabel1.AutoSize = true;
            this.ValueLabel1.Location = new System.Drawing.Point(425, 263);
            this.ValueLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ValueLabel1.Name = "ValueLabel1";
            this.ValueLabel1.Size = new System.Drawing.Size(77, 17);
            this.ValueLabel1.TabIndex = 11;
            this.ValueLabel1.Text = "Значение:";
            // 
            // CriterionLabel1
            // 
            this.CriterionLabel1.AutoSize = true;
            this.CriterionLabel1.Location = new System.Drawing.Point(248, 263);
            this.CriterionLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CriterionLabel1.Name = "CriterionLabel1";
            this.CriterionLabel1.Size = new System.Drawing.Size(76, 17);
            this.CriterionLabel1.TabIndex = 10;
            this.CriterionLabel1.Text = "Критерий:";
            // 
            // NameLabel1
            // 
            this.NameLabel1.AutoSize = true;
            this.NameLabel1.Location = new System.Drawing.Point(8, 263);
            this.NameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel1.Name = "NameLabel1";
            this.NameLabel1.Size = new System.Drawing.Size(75, 17);
            this.NameLabel1.TabIndex = 9;
            this.NameLabel1.Text = "Имя поля:";
            // 
            // JoinBox
            // 
            this.JoinBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.JoinBox.FormattingEnabled = true;
            this.JoinBox.Items.AddRange(new object[] {
            "AND",
            "OR"});
            this.JoinBox.Location = new System.Drawing.Point(664, 283);
            this.JoinBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.JoinBox.Name = "JoinBox";
            this.JoinBox.Size = new System.Drawing.Size(113, 24);
            this.JoinBox.TabIndex = 7;
            // 
            // CriterionBox
            // 
            this.CriterionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CriterionBox.FormattingEnabled = true;
            this.CriterionBox.Location = new System.Drawing.Point(252, 283);
            this.CriterionBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CriterionBox.Name = "CriterionBox";
            this.CriterionBox.Size = new System.Drawing.Size(120, 24);
            this.CriterionBox.TabIndex = 6;
            // 
            // NameBox
            // 
            this.NameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameBox.FormattingEnabled = true;
            this.NameBox.Location = new System.Drawing.Point(12, 283);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(160, 24);
            this.NameBox.TabIndex = 1;
            this.NameBox.SelectedIndexChanged += new System.EventHandler(this.NameBox_SelectedIndexChanged);
            // 
            // ConditionsList
            // 
            this.ConditionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.ConditionsList.FullRowSelect = true;
            this.ConditionsList.Location = new System.Drawing.Point(12, 17);
            this.ConditionsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConditionsList.Name = "ConditionsList";
            this.ConditionsList.Size = new System.Drawing.Size(836, 216);
            this.ConditionsList.TabIndex = 0;
            this.ConditionsList.UseCompatibleStateImageBehavior = false;
            this.ConditionsList.View = System.Windows.Forms.View.Details;
            // 
            // Order
            // 
            this.Order.BackColor = System.Drawing.Color.Azure;
            this.Order.Controls.Add(this.SortSelectedFields);
            this.Order.Controls.Add(this.SortAllFields);
            this.Order.Controls.Add(this.OrderBox);
            this.Order.Controls.Add(this.OrderLabel);
            this.Order.Controls.Add(this.DoubleLeft1);
            this.Order.Controls.Add(this.Left1);
            this.Order.Controls.Add(this.DoubleRight1);
            this.Order.Controls.Add(this.Right1);
            this.Order.Controls.Add(this.SelectedFieldsLabel);
            this.Order.Location = new System.Drawing.Point(4, 25);
            this.Order.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Order.Name = "Order";
            this.Order.Size = new System.Drawing.Size(1057, 392);
            this.Order.TabIndex = 2;
            this.Order.Text = "Порядок";
            // 
            // SortSelectedFields
            // 
            this.SortSelectedFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.SortSelectedFields.FullRowSelect = true;
            this.SortSelectedFields.Location = new System.Drawing.Point(605, 47);
            this.SortSelectedFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortSelectedFields.MultiSelect = false;
            this.SortSelectedFields.Name = "SortSelectedFields";
            this.SortSelectedFields.Size = new System.Drawing.Size(425, 270);
            this.SortSelectedFields.TabIndex = 15;
            this.SortSelectedFields.UseCompatibleStateImageBehavior = false;
            this.SortSelectedFields.View = System.Windows.Forms.View.Details;
            this.SortSelectedFields.SelectedIndexChanged += new System.EventHandler(this.SortSelectedFields_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Имя поля";
            this.columnHeader7.Width = 106;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Имя таблицы";
            this.columnHeader8.Width = 106;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Тип поля";
            this.columnHeader9.Width = 100;
            // 
            // SortAllFields
            // 
            this.SortAllFields.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.SortAllFields.FullRowSelect = true;
            this.SortAllFields.Location = new System.Drawing.Point(21, 47);
            this.SortAllFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SortAllFields.Name = "SortAllFields";
            this.SortAllFields.Size = new System.Drawing.Size(425, 270);
            this.SortAllFields.TabIndex = 14;
            this.SortAllFields.TileSize = new System.Drawing.Size(150, 30);
            this.SortAllFields.UseCompatibleStateImageBehavior = false;
            this.SortAllFields.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Имя поля";
            this.columnHeader4.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Имя таблицы";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Тип поля";
            this.columnHeader6.Width = 100;
            // 
            // OrderBox
            // 
            this.OrderBox.BackColor = System.Drawing.SystemColors.Window;
            this.OrderBox.Controls.Add(this.DESC);
            this.OrderBox.Controls.Add(this.ASC);
            this.OrderBox.Location = new System.Drawing.Point(21, 325);
            this.OrderBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderBox.Name = "OrderBox";
            this.OrderBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OrderBox.Size = new System.Drawing.Size(276, 54);
            this.OrderBox.TabIndex = 13;
            this.OrderBox.TabStop = false;
            this.OrderBox.Text = "Порядок:";
            // 
            // DESC
            // 
            this.DESC.AutoSize = true;
            this.DESC.Location = new System.Drawing.Point(152, 23);
            this.DESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DESC.Name = "DESC";
            this.DESC.Size = new System.Drawing.Size(108, 21);
            this.DESC.TabIndex = 13;
            this.DESC.Text = "Убывающий";
            this.DESC.UseVisualStyleBackColor = true;
            this.DESC.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // ASC
            // 
            this.ASC.AutoSize = true;
            this.ASC.Checked = true;
            this.ASC.Location = new System.Drawing.Point(8, 23);
            this.ASC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ASC.Name = "ASC";
            this.ASC.Size = new System.Drawing.Size(128, 21);
            this.ASC.TabIndex = 12;
            this.ASC.TabStop = true;
            this.ASC.Text = "Возрастающий";
            this.ASC.UseVisualStyleBackColor = true;
            this.ASC.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Location = new System.Drawing.Point(601, 27);
            this.OrderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(231, 17);
            this.OrderLabel.TabIndex = 11;
            this.OrderLabel.Text = "Последовательность сортировки:";
            // 
            // DoubleLeft1
            // 
            this.DoubleLeft1.Location = new System.Drawing.Point(477, 219);
            this.DoubleLeft1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleLeft1.Name = "DoubleLeft1";
            this.DoubleLeft1.Size = new System.Drawing.Size(100, 28);
            this.DoubleLeft1.TabIndex = 9;
            this.DoubleLeft1.Text = "<<";
            this.DoubleLeft1.UseVisualStyleBackColor = true;
            this.DoubleLeft1.Click += new System.EventHandler(this.DoubleLeft1_Click);
            // 
            // Left1
            // 
            this.Left1.Location = new System.Drawing.Point(477, 148);
            this.Left1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(100, 28);
            this.Left1.TabIndex = 8;
            this.Left1.Text = "<";
            this.Left1.UseVisualStyleBackColor = true;
            this.Left1.Click += new System.EventHandler(this.Left1_Click);
            // 
            // DoubleRight1
            // 
            this.DoubleRight1.Location = new System.Drawing.Point(477, 183);
            this.DoubleRight1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleRight1.Name = "DoubleRight1";
            this.DoubleRight1.Size = new System.Drawing.Size(100, 28);
            this.DoubleRight1.TabIndex = 7;
            this.DoubleRight1.Text = ">>";
            this.DoubleRight1.UseVisualStyleBackColor = true;
            this.DoubleRight1.Click += new System.EventHandler(this.DoubleRight1_Click);
            // 
            // Right1
            // 
            this.Right1.Location = new System.Drawing.Point(477, 112);
            this.Right1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Right1.Name = "Right1";
            this.Right1.Size = new System.Drawing.Size(100, 28);
            this.Right1.TabIndex = 6;
            this.Right1.Text = ">";
            this.Right1.UseVisualStyleBackColor = true;
            this.Right1.Click += new System.EventHandler(this.Right1_Click);
            // 
            // SelectedFieldsLabel
            // 
            this.SelectedFieldsLabel.AutoSize = true;
            this.SelectedFieldsLabel.Location = new System.Drawing.Point(17, 27);
            this.SelectedFieldsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedFieldsLabel.Name = "SelectedFieldsLabel";
            this.SelectedFieldsLabel.Size = new System.Drawing.Size(125, 17);
            this.SelectedFieldsLabel.TabIndex = 5;
            this.SelectedFieldsLabel.Text = "Выбранные поля:";
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.Color.Azure;
            this.Result.Controls.Add(this.dataGridView1);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(1057, 392);
            this.Result.TabIndex = 3;
            this.Result.Text = "Результат";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1009, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Имя поля";
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Имя таблицы";
            this.columnHeader12.Width = 130;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Критерий";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Значение";
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Связка";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 484);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.RequestControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Request";
            this.Text = "Нестандартный запрос";
            this.RequestControl.ResumeLayout(false);
            this.Fields.ResumeLayout(false);
            this.Fields.PerformLayout();
            this.Conditions.ResumeLayout(false);
            this.Conditions.PerformLayout();
            this.Order.ResumeLayout(false);
            this.Order.PerformLayout();
            this.OrderBox.ResumeLayout(false);
            this.OrderBox.PerformLayout();
            this.Result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TabControl RequestControl;
        private System.Windows.Forms.TabPage Fields;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.Button DoubleLeft;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button DoubleRight;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.ListView AllFields;
        private System.Windows.Forms.ColumnHeader FieldName;
        private System.Windows.Forms.ColumnHeader TableName;
        private System.Windows.Forms.ColumnHeader FieldType;
        private System.Windows.Forms.TabPage Conditions;
        private System.Windows.Forms.ComboBox ValueBox;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label JoinLabel1;
        private System.Windows.Forms.Label ValueLabel1;
        private System.Windows.Forms.Label CriterionLabel1;
        private System.Windows.Forms.Label NameLabel1;
        private System.Windows.Forms.ComboBox JoinBox;
        private System.Windows.Forms.ComboBox CriterionBox;
        private System.Windows.Forms.ComboBox NameBox;
        private System.Windows.Forms.ListView ConditionsList;
        private System.Windows.Forms.TabPage Order;
        private System.Windows.Forms.GroupBox OrderBox;
        private System.Windows.Forms.RadioButton DESC;
        private System.Windows.Forms.RadioButton ASC;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.Button DoubleLeft1;
        private System.Windows.Forms.Button Left1;
        private System.Windows.Forms.Button DoubleRight1;
        private System.Windows.Forms.Button Right1;
        private System.Windows.Forms.Label SelectedFieldsLabel;
        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.ListView SelectedFields;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView SortAllFields;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView SortSelectedFields;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
    }
}