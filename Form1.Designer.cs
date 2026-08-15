namespace Make_Your_Pizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rblLarg = new System.Windows.Forms.RadioButton();
            this.rblMeduim = new System.Windows.Forms.RadioButton();
            this.rblSmall = new System.Windows.Forms.RadioButton();
            this.gbCrust = new System.Windows.Forms.GroupBox();
            this.rblThink = new System.Windows.Forms.RadioButton();
            this.rblThin = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPreppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rblTakeOut = new System.Windows.Forms.RadioButton();
            this.rblEatin = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.labWheretoEat = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.labCrustType = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.labToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.labSize = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrust.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSize
            // 
            this.gbSize.BackColor = System.Drawing.Color.Transparent;
            this.gbSize.Controls.Add(this.rblLarg);
            this.gbSize.Controls.Add(this.rblMeduim);
            this.gbSize.Controls.Add(this.rblSmall);
            this.gbSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbSize.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.gbSize.Location = new System.Drawing.Point(207, 221);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(292, 214);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // rblLarg
            // 
            this.rblLarg.AutoSize = true;
            this.rblLarg.ForeColor = System.Drawing.Color.Cyan;
            this.rblLarg.Location = new System.Drawing.Point(30, 130);
            this.rblLarg.Name = "rblLarg";
            this.rblLarg.Size = new System.Drawing.Size(94, 36);
            this.rblLarg.TabIndex = 5;
            this.rblLarg.TabStop = true;
            this.rblLarg.Tag = "40";
            this.rblLarg.Text = "Larg";
            this.rblLarg.UseVisualStyleBackColor = true;
            this.rblLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rblMeduim
            // 
            this.rblMeduim.AutoSize = true;
            this.rblMeduim.ForeColor = System.Drawing.Color.Cyan;
            this.rblMeduim.Location = new System.Drawing.Point(30, 84);
            this.rblMeduim.Name = "rblMeduim";
            this.rblMeduim.Size = new System.Drawing.Size(135, 36);
            this.rblMeduim.TabIndex = 4;
            this.rblMeduim.TabStop = true;
            this.rblMeduim.Tag = "30";
            this.rblMeduim.Text = "Meduim";
            this.rblMeduim.UseVisualStyleBackColor = true;
            this.rblMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rblSmall
            // 
            this.rblSmall.AutoSize = true;
            this.rblSmall.ForeColor = System.Drawing.Color.Cyan;
            this.rblSmall.Location = new System.Drawing.Point(30, 38);
            this.rblSmall.Name = "rblSmall";
            this.rblSmall.Size = new System.Drawing.Size(103, 36);
            this.rblSmall.TabIndex = 3;
            this.rblSmall.TabStop = true;
            this.rblSmall.Tag = "20";
            this.rblSmall.Text = "Small";
            this.rblSmall.UseVisualStyleBackColor = true;
            this.rblSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrust
            // 
            this.gbCrust.BackColor = System.Drawing.Color.Transparent;
            this.gbCrust.Controls.Add(this.rblThink);
            this.gbCrust.Controls.Add(this.rblThin);
            this.gbCrust.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCrust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbCrust.Location = new System.Drawing.Point(183, 470);
            this.gbCrust.Name = "gbCrust";
            this.gbCrust.Size = new System.Drawing.Size(255, 182);
            this.gbCrust.TabIndex = 7;
            this.gbCrust.TabStop = false;
            this.gbCrust.Text = "Crust Type";
            // 
            // rblThink
            // 
            this.rblThink.AutoSize = true;
            this.rblThink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rblThink.Location = new System.Drawing.Point(14, 81);
            this.rblThink.Name = "rblThink";
            this.rblThink.Size = new System.Drawing.Size(183, 36);
            this.rblThink.TabIndex = 8;
            this.rblThink.TabStop = true;
            this.rblThink.Tag = "10";
            this.rblThink.Text = "Think Crust";
            this.rblThink.UseVisualStyleBackColor = true;
            this.rblThink.CheckedChanged += new System.EventHandler(this.rbThink_CheckedChanged);
            // 
            // rblThin
            // 
            this.rblThin.AutoSize = true;
            this.rblThin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rblThin.Location = new System.Drawing.Point(14, 37);
            this.rblThin.Name = "rblThin";
            this.rblThin.Size = new System.Drawing.Size(168, 36);
            this.rblThin.TabIndex = 7;
            this.rblThin.TabStop = true;
            this.rblThin.Tag = "0";
            this.rblThin.Text = "Thin Crust";
            this.rblThin.UseVisualStyleBackColor = true;
            this.rblThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.Color.Transparent;
            this.gbToppings.Controls.Add(this.chkGreenPreppers);
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbToppings.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbToppings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.gbToppings.Location = new System.Drawing.Point(573, 221);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Size = new System.Drawing.Size(546, 224);
            this.gbToppings.TabIndex = 14;
            this.gbToppings.TabStop = false;
            this.gbToppings.Text = "Toppings";
            // 
            // chkGreenPreppers
            // 
            this.chkGreenPreppers.AutoSize = true;
            this.chkGreenPreppers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkGreenPreppers.Location = new System.Drawing.Point(274, 125);
            this.chkGreenPreppers.Name = "chkGreenPreppers";
            this.chkGreenPreppers.Size = new System.Drawing.Size(224, 36);
            this.chkGreenPreppers.TabIndex = 19;
            this.chkGreenPreppers.Tag = "5";
            this.chkGreenPreppers.Text = "Green Preppers";
            this.chkGreenPreppers.UseVisualStyleBackColor = true;
            this.chkGreenPreppers.CheckedChanged += new System.EventHandler(this.chGreenPreppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkOlives.Location = new System.Drawing.Point(274, 80);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(111, 36);
            this.chkOlives.TabIndex = 18;
            this.chkOlives.Tag = "5";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkOnion.Location = new System.Drawing.Point(273, 38);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(112, 36);
            this.chkOnion.TabIndex = 17;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkTomatoes.Location = new System.Drawing.Point(22, 125);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(147, 36);
            this.chkTomatoes.TabIndex = 16;
            this.chkTomatoes.Tag = "5";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chTomatoes_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkMushrooms.Location = new System.Drawing.Point(22, 85);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(177, 36);
            this.chkMushrooms.TabIndex = 15;
            this.chkMushrooms.Tag = "5";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.chkExtraCheese.Location = new System.Drawing.Point(22, 45);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(194, 36);
            this.chkExtraCheese.TabIndex = 14;
            this.chkExtraCheese.Tag = "5";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chExtraCheese_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.BackColor = System.Drawing.Color.Transparent;
            this.gbWhereToEat.Controls.Add(this.rblTakeOut);
            this.gbWhereToEat.Controls.Add(this.rblEatin);
            this.gbWhereToEat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbWhereToEat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbWhereToEat.Location = new System.Drawing.Point(618, 465);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Size = new System.Drawing.Size(401, 187);
            this.gbWhereToEat.TabIndex = 17;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat";
            // 
            // rblTakeOut
            // 
            this.rblTakeOut.AutoSize = true;
            this.rblTakeOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rblTakeOut.Location = new System.Drawing.Point(210, 83);
            this.rblTakeOut.Name = "rblTakeOut";
            this.rblTakeOut.Size = new System.Drawing.Size(145, 36);
            this.rblTakeOut.TabIndex = 18;
            this.rblTakeOut.TabStop = true;
            this.rblTakeOut.Text = "Take Out";
            this.rblTakeOut.UseVisualStyleBackColor = true;
            this.rblTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rblEatin
            // 
            this.rblEatin.AutoSize = true;
            this.rblEatin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rblEatin.Location = new System.Drawing.Point(22, 83);
            this.rblEatin.Name = "rblEatin";
            this.rblEatin.Size = new System.Drawing.Size(108, 36);
            this.rblEatin.TabIndex = 17;
            this.rblEatin.TabStop = true;
            this.rblEatin.Text = "Eat in";
            this.rblEatin.UseVisualStyleBackColor = true;
            this.rblEatin.CheckedChanged += new System.EventHandler(this.rbEatin_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(533, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 74);
            this.label1.TabIndex = 26;
            this.label1.Text = "MAKE YOUR PIZZA";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.gbOrderSummary.Controls.Add(this.lblTotalPrice);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.lblWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labWheretoEat);
            this.gbOrderSummary.Controls.Add(this.lblCrustType);
            this.gbOrderSummary.Controls.Add(this.labCrustType);
            this.gbOrderSummary.Controls.Add(this.lblToppings);
            this.gbOrderSummary.Controls.Add(this.labToppings);
            this.gbOrderSummary.Controls.Add(this.lblSize);
            this.gbOrderSummary.Controls.Add(this.labSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.Color.Blue;
            this.gbOrderSummary.Location = new System.Drawing.Point(1214, 223);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(559, 498);
            this.gbOrderSummary.TabIndex = 27;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(208, 400);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(89, 68);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 34;
            this.label2.Text = "Total Price:";
            // 
            // lblWhereToEat
            // 
            this.lblWhereToEat.AutoSize = true;
            this.lblWhereToEat.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEat.Location = new System.Drawing.Point(208, 306);
            this.lblWhereToEat.Name = "lblWhereToEat";
            this.lblWhereToEat.Size = new System.Drawing.Size(86, 34);
            this.lblWhereToEat.TabIndex = 33;
            this.lblWhereToEat.Text = "Eat in";
            // 
            // labWheretoEat
            // 
            this.labWheretoEat.AutoSize = true;
            this.labWheretoEat.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWheretoEat.Location = new System.Drawing.Point(33, 266);
            this.labWheretoEat.Name = "labWheretoEat";
            this.labWheretoEat.Size = new System.Drawing.Size(179, 31);
            this.labWheretoEat.TabIndex = 32;
            this.labWheretoEat.Text = "Where to Eat:";
            // 
            // lblCrustType
            // 
            this.lblCrustType.AutoSize = true;
            this.lblCrustType.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustType.Location = new System.Drawing.Point(211, 225);
            this.lblCrustType.Name = "lblCrustType";
            this.lblCrustType.Size = new System.Drawing.Size(143, 34);
            this.lblCrustType.TabIndex = 31;
            this.lblCrustType.Text = "Thin Crust";
            // 
            // labCrustType
            // 
            this.labCrustType.AutoSize = true;
            this.labCrustType.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCrustType.Location = new System.Drawing.Point(33, 212);
            this.labCrustType.Name = "labCrustType";
            this.labCrustType.Size = new System.Drawing.Size(154, 31);
            this.labCrustType.TabIndex = 30;
            this.labCrustType.Text = "Crust Type:";
            // 
            // lblToppings
            // 
            this.lblToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblToppings.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(196, 97);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(328, 125);
            this.lblToppings.TabIndex = 29;
            this.lblToppings.Text = "NoToppings";
            // 
            // labToppings
            // 
            this.labToppings.AutoSize = true;
            this.labToppings.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labToppings.Location = new System.Drawing.Point(56, 88);
            this.labToppings.Name = "labToppings";
            this.labToppings.Size = new System.Drawing.Size(134, 31);
            this.labToppings.TabIndex = 28;
            this.labToppings.Text = "Toppings:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(144, 36);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(108, 33);
            this.lblSize.TabIndex = 27;
            this.lblSize.Text = "Meduim";
            // 
            // labSize
            // 
            this.labSize.AutoSize = true;
            this.labSize.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSize.Location = new System.Drawing.Point(54, 35);
            this.labSize.Name = "labSize";
            this.labSize.Size = new System.Drawing.Size(71, 31);
            this.labSize.TabIndex = 26;
            this.labSize.Text = "Size:";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Lime;
            this.btnOrder.Location = new System.Drawing.Point(476, 664);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(219, 47);
            this.btnOrder.TabIndex = 28;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Transparent;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.Color.Lime;
            this.btnResetForm.Location = new System.Drawing.Point(1006, 664);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(168, 47);
            this.btnResetForm.TabIndex = 29;
            this.btnResetForm.Text = "ResetForm";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 47);
            this.button1.TabIndex = 30;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1785, 723);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbCrust);
            this.Controls.Add(this.gbSize);
            this.Name = "Form1";
            this.Text = "Order Pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrust.ResumeLayout(false);
            this.gbCrust.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rblLarg;
        private System.Windows.Forms.RadioButton rblMeduim;
        private System.Windows.Forms.RadioButton rblSmall;
        private System.Windows.Forms.GroupBox gbCrust;
        private System.Windows.Forms.RadioButton rblThink;
        private System.Windows.Forms.RadioButton rblThin;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox chkGreenPreppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rblTakeOut;
        private System.Windows.Forms.RadioButton rblEatin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label labWheretoEat;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label labCrustType;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label labToppings;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label labSize;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

