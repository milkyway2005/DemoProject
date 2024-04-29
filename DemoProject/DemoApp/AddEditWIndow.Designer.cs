namespace DemoApp
{
    partial class AddEditWIndow
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
            textId = new TextBox();
            textDate = new TextBox();
            textEquipment = new TextBox();
            textDefect = new TextBox();
            textResponsible = new TextBox();
            textProblemDescription = new RichTextBox();
            boxState = new ComboBox();
            textClient = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            buttonBack = new Button();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // textId
            // 
            textId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textId.Location = new Point(47, 48);
            textId.Name = "textId";
            textId.Size = new Size(374, 38);
            textId.TabIndex = 0;
            // 
            // textDate
            // 
            textDate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textDate.Location = new Point(47, 131);
            textDate.Name = "textDate";
            textDate.Size = new Size(374, 38);
            textDate.TabIndex = 1;
            // 
            // textEquipment
            // 
            textEquipment.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textEquipment.Location = new Point(47, 219);
            textEquipment.Name = "textEquipment";
            textEquipment.Size = new Size(374, 38);
            textEquipment.TabIndex = 2;
            // 
            // textDefect
            // 
            textDefect.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textDefect.Location = new Point(47, 308);
            textDefect.Name = "textDefect";
            textDefect.Size = new Size(374, 38);
            textDefect.TabIndex = 3;
            // 
            // textResponsible
            // 
            textResponsible.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textResponsible.Location = new Point(47, 755);
            textResponsible.Name = "textResponsible";
            textResponsible.Size = new Size(374, 38);
            textResponsible.TabIndex = 4;
            // 
            // textProblemDescription
            // 
            textProblemDescription.Location = new Point(47, 399);
            textProblemDescription.Name = "textProblemDescription";
            textProblemDescription.Size = new Size(374, 120);
            textProblemDescription.TabIndex = 5;
            textProblemDescription.Text = "";
            // 
            // boxState
            // 
            boxState.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            boxState.FormattingEnabled = true;
            boxState.Items.AddRange(new object[] { "Выполнено", "В работе", "Не выполнено" });
            boxState.Location = new Point(47, 662);
            boxState.Name = "boxState";
            boxState.Size = new Size(374, 39);
            boxState.TabIndex = 6;
            // 
            // textClient
            // 
            textClient.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textClient.Location = new Point(47, 571);
            textClient.Name = "textClient";
            textClient.Size = new Size(374, 38);
            textClient.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 18);
            label1.Name = "label1";
            label1.Size = new Size(29, 28);
            label1.TabIndex = 8;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(170, 28);
            label2.TabIndex = 9;
            label2.Text = "Дата добавления";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 188);
            label3.Name = "label3";
            label3.Size = new Size(151, 28);
            label3.TabIndex = 10;
            label3.Text = "Оборудование";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(50, 277);
            label4.Name = "label4";
            label4.Size = new Size(192, 28);
            label4.TabIndex = 11;
            label4.Text = "Тип неисправности";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(50, 368);
            label5.Name = "label5";
            label5.Size = new Size(206, 28);
            label5.TabIndex = 12;
            label5.Text = "Описание проблемы";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(50, 540);
            label6.Name = "label6";
            label6.Size = new Size(77, 28);
            label6.TabIndex = 13;
            label6.Text = "Клиент";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(50, 631);
            label7.Name = "label7";
            label7.Size = new Size(136, 28);
            label7.TabIndex = 14;
            label7.Text = "Статус заявки";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(50, 724);
            label8.Name = "label8";
            label8.Size = new Size(152, 28);
            label8.TabIndex = 15;
            label8.Text = "Ответственный";
            // 
            // buttonBack
            // 
            buttonBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(47, 821);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(173, 50);
            buttonBack.TabIndex = 16;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(248, 821);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(173, 50);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // AddEditWIndow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 895);
            Controls.Add(buttonSave);
            Controls.Add(buttonBack);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textClient);
            Controls.Add(boxState);
            Controls.Add(textProblemDescription);
            Controls.Add(textResponsible);
            Controls.Add(textDefect);
            Controls.Add(textEquipment);
            Controls.Add(textDate);
            Controls.Add(textId);
            Name = "AddEditWIndow";
            Text = "AddEditWIndow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button buttonBack;
        private Button buttonSave;
        public TextBox textId;
        public TextBox textDate;
        public TextBox textEquipment;
        public TextBox textDefect;
        public TextBox textResponsible;
        public RichTextBox textProblemDescription;
        public ComboBox boxState;
        public TextBox textClient;
    }
}