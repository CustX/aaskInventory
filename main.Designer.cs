namespace inventoryAASK
{
    partial class main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.main_1 = new System.Windows.Forms.Panel();
            this.usersShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Panel();
            this.roomsBack = new System.Windows.Forms.Button();
            this.showRoom = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.roomsDel = new System.Windows.Forms.Button();
            this.roomsAdd = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.roomUser = new System.Windows.Forms.Label();
            this.numOfSelectedRoom = new System.Windows.Forms.Label();
            this.roomBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.item = new System.Windows.Forms.ListBox();
            this.itemDel = new System.Windows.Forms.Button();
            this.roomAdd = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Panel();
            this.userList = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.addCommit = new System.Windows.Forms.Button();
            this.itemAdd = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newItemId = new System.Windows.Forms.TextBox();
            this.newItemName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.users = new System.Windows.Forms.Panel();
            this.usersBack = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.ListBox();
            this.userDel = new System.Windows.Forms.Button();
            this.usersAdd = new System.Windows.Forms.Button();
            this.userAdd = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.userPosition = new System.Windows.Forms.TextBox();
            this.userLastName = new System.Windows.Forms.TextBox();
            this.userFirstName = new System.Windows.Forms.TextBox();
            this.userMiddleName = new System.Windows.Forms.TextBox();
            this.userAddBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.userAddCommit = new System.Windows.Forms.Button();
            this.main_1.SuspendLayout();
            this.rooms.SuspendLayout();
            this.room.SuspendLayout();
            this.add.SuspendLayout();
            this.itemAdd.SuspendLayout();
            this.users.SuspendLayout();
            this.userAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_1
            // 
            this.main_1.Controls.Add(this.usersShow);
            this.main_1.Controls.Add(this.button1);
            this.main_1.Location = new System.Drawing.Point(12, 12);
            this.main_1.Name = "main_1";
            this.main_1.Size = new System.Drawing.Size(758, 379);
            this.main_1.TabIndex = 0;
            // 
            // usersShow
            // 
            this.usersShow.Location = new System.Drawing.Point(426, 152);
            this.usersShow.Name = "usersShow";
            this.usersShow.Size = new System.Drawing.Size(192, 68);
            this.usersShow.TabIndex = 1;
            this.usersShow.Text = "Преподаватели";
            this.usersShow.UseVisualStyleBackColor = true;
            this.usersShow.Click += new System.EventHandler(this.usersShow_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "Аудитории";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // rooms
            // 
            this.rooms.Controls.Add(this.roomsBack);
            this.rooms.Controls.Add(this.showRoom);
            this.rooms.Controls.Add(this.label1);
            this.rooms.Controls.Add(this.roomsList);
            this.rooms.Controls.Add(this.roomsDel);
            this.rooms.Controls.Add(this.roomsAdd);
            this.rooms.Location = new System.Drawing.Point(12, 12);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(758, 379);
            this.rooms.TabIndex = 2;
            this.rooms.Visible = false;
            // 
            // roomsBack
            // 
            this.roomsBack.Location = new System.Drawing.Point(505, 3);
            this.roomsBack.Name = "roomsBack";
            this.roomsBack.Size = new System.Drawing.Size(192, 68);
            this.roomsBack.TabIndex = 5;
            this.roomsBack.Text = "Назад";
            this.roomsBack.UseVisualStyleBackColor = true;
            this.roomsBack.Click += new System.EventHandler(this.roomsBack_Click);
            // 
            // showRoom
            // 
            this.showRoom.Location = new System.Drawing.Point(505, 262);
            this.showRoom.Name = "showRoom";
            this.showRoom.Size = new System.Drawing.Size(192, 68);
            this.showRoom.TabIndex = 4;
            this.showRoom.Text = "Посмотреть";
            this.showRoom.UseVisualStyleBackColor = true;
            this.showRoom.Click += new System.EventHandler(this.showRoom_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(98, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Аудитории";
            // 
            // roomsList
            // 
            this.roomsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomsList.FormattingEnabled = true;
            this.roomsList.ItemHeight = 29;
            this.roomsList.Items.AddRange(new object[] {
            "1"});
            this.roomsList.Location = new System.Drawing.Point(66, 94);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(300, 236);
            this.roomsList.TabIndex = 2;
            // 
            // roomsDel
            // 
            this.roomsDel.Location = new System.Drawing.Point(505, 174);
            this.roomsDel.Name = "roomsDel";
            this.roomsDel.Size = new System.Drawing.Size(192, 68);
            this.roomsDel.TabIndex = 1;
            this.roomsDel.Text = "Удалить";
            this.roomsDel.UseVisualStyleBackColor = true;
            this.roomsDel.Click += new System.EventHandler(this.roomsDel_Click);
            // 
            // roomsAdd
            // 
            this.roomsAdd.Location = new System.Drawing.Point(505, 88);
            this.roomsAdd.Name = "roomsAdd";
            this.roomsAdd.Size = new System.Drawing.Size(192, 68);
            this.roomsAdd.TabIndex = 0;
            this.roomsAdd.Text = "Добавить";
            this.roomsAdd.UseVisualStyleBackColor = true;
            this.roomsAdd.Click += new System.EventHandler(this.roomsAdd_Click);
            // 
            // room
            // 
            this.room.Controls.Add(this.label15);
            this.room.Controls.Add(this.label14);
            this.room.Controls.Add(this.roomUser);
            this.room.Controls.Add(this.numOfSelectedRoom);
            this.room.Controls.Add(this.roomBack);
            this.room.Controls.Add(this.label4);
            this.room.Controls.Add(this.item);
            this.room.Controls.Add(this.itemDel);
            this.room.Controls.Add(this.roomAdd);
            this.room.Location = new System.Drawing.Point(12, 12);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(758, 379);
            this.room.TabIndex = 5;
            this.room.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(197, 70);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Предмет";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(39, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "id";
            // 
            // roomUser
            // 
            this.roomUser.AutoSize = true;
            this.roomUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roomUser.Location = new System.Drawing.Point(418, 11);
            this.roomUser.Name = "roomUser";
            this.roomUser.Size = new System.Drawing.Size(62, 48);
            this.roomUser.TabIndex = 6;
            this.roomUser.Text = "№";
            // 
            // numOfSelectedRoom
            // 
            this.numOfSelectedRoom.AutoSize = true;
            this.numOfSelectedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numOfSelectedRoom.Location = new System.Drawing.Point(271, 11);
            this.numOfSelectedRoom.Name = "numOfSelectedRoom";
            this.numOfSelectedRoom.Size = new System.Drawing.Size(62, 48);
            this.numOfSelectedRoom.TabIndex = 5;
            this.numOfSelectedRoom.Text = "№";
            // 
            // roomBack
            // 
            this.roomBack.Location = new System.Drawing.Point(505, 250);
            this.roomBack.Name = "roomBack";
            this.roomBack.Size = new System.Drawing.Size(192, 68);
            this.roomBack.TabIndex = 4;
            this.roomBack.Text = "Назад";
            this.roomBack.UseVisualStyleBackColor = true;
            this.roomBack.Click += new System.EventHandler(this.roomBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "Аудитория";
            // 
            // item
            // 
            this.item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item.FormattingEnabled = true;
            this.item.ItemHeight = 20;
            this.item.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.item.Location = new System.Drawing.Point(31, 94);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(449, 224);
            this.item.TabIndex = 2;
            this.item.SelectedIndexChanged += new System.EventHandler(this.itemName_SelectedIndexChanged);
            // 
            // itemDel
            // 
            this.itemDel.Location = new System.Drawing.Point(505, 173);
            this.itemDel.Name = "itemDel";
            this.itemDel.Size = new System.Drawing.Size(192, 68);
            this.itemDel.TabIndex = 1;
            this.itemDel.Text = "Удалить";
            this.itemDel.UseVisualStyleBackColor = true;
            this.itemDel.Click += new System.EventHandler(this.itemDel_Click);
            // 
            // roomAdd
            // 
            this.roomAdd.Location = new System.Drawing.Point(505, 94);
            this.roomAdd.Name = "roomAdd";
            this.roomAdd.Size = new System.Drawing.Size(192, 68);
            this.roomAdd.TabIndex = 0;
            this.roomAdd.Text = "Добавить";
            this.roomAdd.UseVisualStyleBackColor = true;
            this.roomAdd.Click += new System.EventHandler(this.roomAdd_Click);
            // 
            // add
            // 
            this.add.Controls.Add(this.userList);
            this.add.Controls.Add(this.textBox1);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.addBack);
            this.add.Controls.Add(this.label2);
            this.add.Controls.Add(this.addCommit);
            this.add.Location = new System.Drawing.Point(12, 12);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(758, 379);
            this.add.TabIndex = 5;
            this.add.Visible = false;
            // 
            // userList
            // 
            this.userList.FormattingEnabled = true;
            this.userList.Location = new System.Drawing.Point(400, 175);
            this.userList.Name = "userList";
            this.userList.Size = new System.Drawing.Size(121, 24);
            this.userList.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(167, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(360, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ответственный";
            // 
            // addBack
            // 
            this.addBack.Location = new System.Drawing.Point(542, 275);
            this.addBack.Name = "addBack";
            this.addBack.Size = new System.Drawing.Size(192, 68);
            this.addBack.TabIndex = 4;
            this.addBack.Text = "Назад";
            this.addBack.UseVisualStyleBackColor = true;
            this.addBack.Click += new System.EventHandler(this.addBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(162, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "№ Аудитории";
            // 
            // addCommit
            // 
            this.addCommit.Location = new System.Drawing.Point(257, 275);
            this.addCommit.Name = "addCommit";
            this.addCommit.Size = new System.Drawing.Size(192, 68);
            this.addCommit.TabIndex = 0;
            this.addCommit.Text = "Добавить";
            this.addCommit.UseVisualStyleBackColor = true;
            this.addCommit.Click += new System.EventHandler(this.addCommit_Click);
            // 
            // itemAdd
            // 
            this.itemAdd.Controls.Add(this.label7);
            this.itemAdd.Controls.Add(this.label6);
            this.itemAdd.Controls.Add(this.newItemId);
            this.itemAdd.Controls.Add(this.newItemName);
            this.itemAdd.Controls.Add(this.button3);
            this.itemAdd.Controls.Add(this.label5);
            this.itemAdd.Controls.Add(this.button5);
            this.itemAdd.Location = new System.Drawing.Point(9, 12);
            this.itemAdd.Name = "itemAdd";
            this.itemAdd.Size = new System.Drawing.Size(758, 379);
            this.itemAdd.TabIndex = 6;
            this.itemAdd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(252, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Серийный номер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(74, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Предмет";
            // 
            // newItemId
            // 
            this.newItemId.Enabled = false;
            this.newItemId.Location = new System.Drawing.Point(304, 198);
            this.newItemId.Name = "newItemId";
            this.newItemId.Size = new System.Drawing.Size(100, 22);
            this.newItemId.TabIndex = 6;
            // 
            // newItemName
            // 
            this.newItemName.Location = new System.Drawing.Point(79, 197);
            this.newItemName.Name = "newItemName";
            this.newItemName.Size = new System.Drawing.Size(128, 22);
            this.newItemName.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(508, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 68);
            this.button3.TabIndex = 4;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(71, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(385, 48);
            this.label5.TabIndex = 3;
            this.label5.Text = "Добавить предмет";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(508, 158);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(192, 68);
            this.button5.TabIndex = 0;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // users
            // 
            this.users.Controls.Add(this.usersBack);
            this.users.Controls.Add(this.button4);
            this.users.Controls.Add(this.label8);
            this.users.Controls.Add(this.usersList);
            this.users.Controls.Add(this.userDel);
            this.users.Controls.Add(this.usersAdd);
            this.users.Location = new System.Drawing.Point(12, 11);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(758, 379);
            this.users.TabIndex = 6;
            this.users.Visible = false;
            // 
            // usersBack
            // 
            this.usersBack.Location = new System.Drawing.Point(505, 3);
            this.usersBack.Name = "usersBack";
            this.usersBack.Size = new System.Drawing.Size(192, 68);
            this.usersBack.TabIndex = 5;
            this.usersBack.Text = "Назад";
            this.usersBack.UseVisualStyleBackColor = true;
            this.usersBack.Click += new System.EventHandler(this.usersBack_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(505, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 68);
            this.button4.TabIndex = 4;
            this.button4.Text = "Посмотреть";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(98, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(323, 48);
            this.label8.TabIndex = 3;
            this.label8.Text = "Преподаватели";
            // 
            // usersList
            // 
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usersList.FormattingEnabled = true;
            this.usersList.ItemHeight = 29;
            this.usersList.Items.AddRange(new object[] {
            "1"});
            this.usersList.Location = new System.Drawing.Point(66, 94);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(300, 236);
            this.usersList.TabIndex = 2;
            // 
            // userDel
            // 
            this.userDel.Location = new System.Drawing.Point(505, 174);
            this.userDel.Name = "userDel";
            this.userDel.Size = new System.Drawing.Size(192, 68);
            this.userDel.TabIndex = 1;
            this.userDel.Text = "Удалить";
            this.userDel.UseVisualStyleBackColor = true;
            this.userDel.Click += new System.EventHandler(this.userDel_Click);
            // 
            // usersAdd
            // 
            this.usersAdd.Location = new System.Drawing.Point(505, 88);
            this.usersAdd.Name = "usersAdd";
            this.usersAdd.Size = new System.Drawing.Size(192, 68);
            this.usersAdd.TabIndex = 0;
            this.usersAdd.Text = "Добавить";
            this.usersAdd.UseVisualStyleBackColor = true;
            this.usersAdd.Click += new System.EventHandler(this.usersAdd_Click);
            // 
            // userAdd
            // 
            this.userAdd.Controls.Add(this.label13);
            this.userAdd.Controls.Add(this.label12);
            this.userAdd.Controls.Add(this.label11);
            this.userAdd.Controls.Add(this.label10);
            this.userAdd.Controls.Add(this.userPosition);
            this.userAdd.Controls.Add(this.userLastName);
            this.userAdd.Controls.Add(this.userFirstName);
            this.userAdd.Controls.Add(this.userMiddleName);
            this.userAdd.Controls.Add(this.userAddBack);
            this.userAdd.Controls.Add(this.label9);
            this.userAdd.Controls.Add(this.userAddCommit);
            this.userAdd.Location = new System.Drawing.Point(11, 11);
            this.userAdd.Name = "userAdd";
            this.userAdd.Size = new System.Drawing.Size(758, 379);
            this.userAdd.TabIndex = 7;
            this.userAdd.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(70, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Должность";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(80, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Отчество";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Имя";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Фамилия";
            // 
            // userPosition
            // 
            this.userPosition.Location = new System.Drawing.Point(163, 184);
            this.userPosition.Name = "userPosition";
            this.userPosition.Size = new System.Drawing.Size(184, 22);
            this.userPosition.TabIndex = 9;
            // 
            // userLastName
            // 
            this.userLastName.Location = new System.Drawing.Point(163, 156);
            this.userLastName.Name = "userLastName";
            this.userLastName.Size = new System.Drawing.Size(184, 22);
            this.userLastName.TabIndex = 8;
            // 
            // userFirstName
            // 
            this.userFirstName.Location = new System.Drawing.Point(163, 127);
            this.userFirstName.Name = "userFirstName";
            this.userFirstName.Size = new System.Drawing.Size(184, 22);
            this.userFirstName.TabIndex = 7;
            // 
            // userMiddleName
            // 
            this.userMiddleName.Location = new System.Drawing.Point(163, 99);
            this.userMiddleName.Name = "userMiddleName";
            this.userMiddleName.Size = new System.Drawing.Size(184, 22);
            this.userMiddleName.TabIndex = 6;
            // 
            // userAddBack
            // 
            this.userAddBack.Location = new System.Drawing.Point(330, 276);
            this.userAddBack.Name = "userAddBack";
            this.userAddBack.Size = new System.Drawing.Size(192, 68);
            this.userAddBack.TabIndex = 5;
            this.userAddBack.Text = "Назад";
            this.userAddBack.UseVisualStyleBackColor = true;
            this.userAddBack.Click += new System.EventHandler(this.userAddBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(98, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(516, 48);
            this.label9.TabIndex = 3;
            this.label9.Text = "Добавить преподавателя";
            // 
            // userAddCommit
            // 
            this.userAddCommit.Location = new System.Drawing.Point(530, 276);
            this.userAddCommit.Name = "userAddCommit";
            this.userAddCommit.Size = new System.Drawing.Size(192, 68);
            this.userAddCommit.TabIndex = 0;
            this.userAddCommit.Text = "Добавить";
            this.userAddCommit.UseVisualStyleBackColor = true;
            this.userAddCommit.Click += new System.EventHandler(this.userAddCommit_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.userAdd);
            this.Controls.Add(this.users);
            this.Controls.Add(this.rooms);
            this.Controls.Add(this.main_1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.itemAdd);
            this.Controls.Add(this.room);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main";
            this.Text = "inventoryAASK";
            this.Load += new System.EventHandler(this.main_Load);
            this.main_1.ResumeLayout(false);
            this.rooms.ResumeLayout(false);
            this.rooms.PerformLayout();
            this.room.ResumeLayout(false);
            this.room.PerformLayout();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.itemAdd.ResumeLayout(false);
            this.itemAdd.PerformLayout();
            this.users.ResumeLayout(false);
            this.users.PerformLayout();
            this.userAdd.ResumeLayout(false);
            this.userAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button usersShow;
        private System.Windows.Forms.Panel rooms;
        private System.Windows.Forms.Button roomsDel;
        private System.Windows.Forms.Button roomsAdd;
        private System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showRoom;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.ComboBox userList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCommit;
        private System.Windows.Forms.Panel room;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox item;
        private System.Windows.Forms.Button itemDel;
        private System.Windows.Forms.Button roomAdd;
        private System.Windows.Forms.Button roomBack;
        private System.Windows.Forms.Button roomsBack;
        private System.Windows.Forms.Panel itemAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newItemId;
        private System.Windows.Forms.TextBox newItemName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label numOfSelectedRoom;
        private System.Windows.Forms.Label roomUser;
        private System.Windows.Forms.Panel users;
        private System.Windows.Forms.Button usersBack;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox usersList;
        private System.Windows.Forms.Button userDel;
        private System.Windows.Forms.Button usersAdd;
        private System.Windows.Forms.Panel userAdd;
        private System.Windows.Forms.Button userAddBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button userAddCommit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox userPosition;
        private System.Windows.Forms.TextBox userLastName;
        private System.Windows.Forms.TextBox userFirstName;
        private System.Windows.Forms.TextBox userMiddleName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

