using System;
using System.Drawing;
using System.Windows.Forms;

namespace CreditCalculator
{
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.ListView lvPayments;
        private System.Windows.Forms.ColumnHeader chcredit;
        private System.Windows.Forms.ColumnHeader chpercent;
        private System.Windows.Forms.ColumnHeader chremaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbCom;
        private System.Windows.Forms.TextBox tbCom;
        private System.Windows.Forms.TextBox tbVznos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCreditCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader chcomission;
        private System.Windows.Forms.TextBox tbComAll;
        private System.Windows.Forms.Label label8;
        private CheckBox cbDef;
        private ColumnHeader chpayment;
        private ColumnHeader chmonth;
        private Button button1;

        private System.ComponentModel.Container components = null;

        public Form1()
        {

            InitializeComponent();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.tbSum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.lvPayments = new System.Windows.Forms.ListView();
            this.chmonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chpayment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chpercent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chcredit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chremaining = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chcomission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.cbCom = new System.Windows.Forms.CheckBox();
            this.tbCom = new System.Windows.Forms.TextBox();
            this.tbVznos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCreditCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbComAll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDef = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(22, 32);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(173, 22);
            this.tbSum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сумма кредита:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Срок, мес:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(220, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ставка в год, %:";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(19, 95);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(173, 22);
            this.tbTime.TabIndex = 4;
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(221, 95);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(173, 22);
            this.tbPercent.TabIndex = 5;
            // 
            // btnCount
            // 
            this.btnCount.BackColor = System.Drawing.Color.Silver;
            this.btnCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCount.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCount.Font = new System.Drawing.Font("Times NR Cyr MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCount.Location = new System.Drawing.Point(221, 226);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(173, 37);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Рассчитать";
            this.btnCount.UseVisualStyleBackColor = false;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(19, 254);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(173, 22);
            this.tbResult.TabIndex = 7;
            // 
            // lvPayments
            // 
            this.lvPayments.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvPayments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lvPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chmonth,
            this.chpayment,
            this.chpercent,
            this.chcredit,
            this.chremaining,
            this.chcomission});
            this.lvPayments.ForeColor = System.Drawing.Color.Black;
            this.lvPayments.HideSelection = false;
            this.lvPayments.Location = new System.Drawing.Point(19, 358);
            this.lvPayments.MultiSelect = false;
            this.lvPayments.Name = "lvPayments";
            this.lvPayments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvPayments.Size = new System.Drawing.Size(375, 242);
            this.lvPayments.TabIndex = 8;
            this.lvPayments.UseCompatibleStateImageBehavior = false;
            this.lvPayments.View = System.Windows.Forms.View.Details;
            this.lvPayments.SelectedIndexChanged += new System.EventHandler(this.lvPayments_SelectedIndexChanged);
            // 
            // chmonth
            // 
            this.chmonth.Text = "Месяц";
            this.chmonth.Width = 75;
            // 
            // chpayment
            // 
            this.chpayment.Text = "Платёж";
            this.chpayment.Width = 75;
            // 
            // chpercent
            // 
            this.chpercent.Text = "Проценты";
            this.chpercent.Width = 75;
            // 
            // chcredit
            // 
            this.chcredit.Text = "Погашение";
            this.chcredit.Width = 75;
            // 
            // chremaining
            // 
            this.chremaining.DisplayIndex = 5;
            this.chremaining.Text = "Остаток";
            this.chremaining.Width = 75;
            // 
            // chcomission
            // 
            this.chcomission.DisplayIndex = 4;
            this.chcomission.Text = "Комиссия";
            this.chcomission.Width = 75;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(19, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ежемесячный платёж:";
            // 
            // cbCom
            // 
            this.cbCom.Font = new System.Drawing.Font("Times NR Cyr MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbCom.Location = new System.Drawing.Point(12, 140);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(220, 37);
            this.cbCom.TabIndex = 10;
            this.cbCom.Text = "Ежемесячная комиссия, %:";
            this.cbCom.CheckedChanged += new System.EventHandler(this.cbCom_CheckedChanged);
            // 
            // tbCom
            // 
            this.tbCom.Location = new System.Drawing.Point(220, 147);
            this.tbCom.Name = "tbCom";
            this.tbCom.ReadOnly = true;
            this.tbCom.Size = new System.Drawing.Size(173, 22);
            this.tbCom.TabIndex = 11;
            // 
            // tbVznos
            // 
            this.tbVznos.Location = new System.Drawing.Point(220, 32);
            this.tbVznos.Name = "tbVznos";
            this.tbVznos.Size = new System.Drawing.Size(173, 22);
            this.tbVznos.TabIndex = 12;
            this.tbVznos.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(221, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Первый взнос, %:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(19, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Стоимость кредита:";
            // 
            // tbCreditCost
            // 
            this.tbCreditCost.Location = new System.Drawing.Point(19, 300);
            this.tbCreditCost.Name = "tbCreditCost";
            this.tbCreditCost.ReadOnly = true;
            this.tbCreditCost.Size = new System.Drawing.Size(173, 22);
            this.tbCreditCost.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(19, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "График погашения:";
            // 
            // tbComAll
            // 
            this.tbComAll.Location = new System.Drawing.Point(221, 300);
            this.tbComAll.Name = "tbComAll";
            this.tbComAll.ReadOnly = true;
            this.tbComAll.Size = new System.Drawing.Size(173, 22);
            this.tbComAll.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(221, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Из нее комиссия:";
            // 
            // cbDef
            // 
            this.cbDef.Font = new System.Drawing.Font("Times NR Cyr MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbDef.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbDef.Location = new System.Drawing.Point(12, 180);
            this.cbDef.Name = "cbDef";
            this.cbDef.Size = new System.Drawing.Size(195, 37);
            this.cbDef.TabIndex = 19;
            this.cbDef.Text = "Дифференцированный";
            this.cbDef.CheckedChanged += new System.EventHandler(this.cbDef_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 606);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 34);
            this.button1.TabIndex = 20;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(411, 652);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbComAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCreditCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbVznos);
            this.Controls.Add(this.tbCom);
            this.Controls.Add(this.cbCom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lvPayments);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.tbPercent);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        decimal sum;
        decimal sum2;
        decimal percent;
        int time;
        decimal payment;
        decimal com;


        private void btnCount_Click(object sender, System.EventArgs e)
        {
            lvPayments.Items.Clear(); //Очистить график платежей

            try
            {
                //Объявление переменных с присвоенными пользователем значениями из текст-бокса и приведением их к типу дабл / инт
                sum = decimal.Parse(tbSum.Text) * (1 - decimal.Parse(tbVznos.Text) / 100); //Сумма кредита
                sum2 = decimal.Parse(tbSum.Text) * (1 - decimal.Parse(tbVznos.Text) / 100); //Сумма кредита дл расчётов дифференцированного ежемесячного платежа
                time = Int32.Parse(tbTime.Text); //Период
                percent = decimal.Parse(tbPercent.Text);
                percent /= 1200; //dPercent/12/100 или /=1200

                if (cbDef.Checked == false) //Если одинаковый платёж
                {
                    payment = (sum * percent) / (decimal)(1 - Math.Pow(1 + (double)percent, -time)); //Одинаков в каждом месяце

                    if (cbCom.Checked) //Если комиссия включена
                    {
                        com = (decimal.Parse(tbCom.Text) / 100) * sum; //Формула расчёта ежемесячной комиссии от первоначальной суммы кредита
                        payment += com; //Ежемесячнй платёж увеличивается на сумму комиссии
                    }
                    else
                        com = 0; //Иначе (если комиссия не включена) комиссия равна нулю
                }
                else
                {
                    payment = (sum / time) + sum * percent; // Дифференцированный ежемесячный платёж (отличен в каждом месяце)

                    if (cbCom.Checked) //Если комиссия включена
                    {
                        com = (decimal.Parse(tbCom.Text) / 100) * sum; //Формула расчёта ежемесячной комиссии от первоначальной суммы кредита
                        payment += com; //Ежемесячнй дифференцированный платёж увеличивается на сумму комиссии
                    }
                    else
                        com = 0; //Иначе (если комиссия не включена) комиссия равна нулю
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат ввода данных"); //Фильтр формата
            }

            tbResult.Text = Math.Round(payment, 2).ToString(); // Округление и передача в текст-бокс значения ежемесячного аннуитетного или дифференцированного платежа

            if (cbDef.Checked == false)//Если одинаковый платёж
            {
                decimal comAll = com * time; // Расчёт суммы комиссий за весь период
                decimal payAll = payment * time; // Расчёт суммы ежемесячных платежей за весь период

                tbCreditCost.Text = Math.Round(payAll - sum, 2).ToString(); //Расчёт и передача в текст-бокс значения стоимости кредита
                tbComAll.Text = Math.Round(comAll, 2).ToString(); //Передача в текст-бокс значения суммы комиссий за весь период
            }
            else
            {
                decimal perMonth = sum * percent; //Расчёт процентов в теле платежа за 1 период
                decimal AllperMonth = perMonth * time / 2 + perMonth / 2; // Сумма всех процентов в дифференцированных платежах

                decimal comAll = com * time; // Расчёт суммы комиссий за весь период
                decimal payAll = AllperMonth + comAll; // Расчёт стоимости кредита

                tbCreditCost.Text = Math.Round(payAll, 2).ToString(); //Расчёт и передача в текст-бокс значения стоимости кредита (сумма процентов и комиссий)
                tbComAll.Text = Math.Round(comAll, 2).ToString(); //Передача в текст-бокс значения суммы комиссий за весь период
            }
            CalcPayments(); //Вызов калькуляции графика платежей
        }

        private void CalcPayments()
        {
            for (int i = 0; i < time; i++) //Объявление цикла для количества расчётных периодов (месяцев)
            {
                if (cbDef.Checked == false)
                {
                    decimal payMonth = payment;
                    decimal perMonth = sum * percent; //Расчёт процентов в теле платежа за 1 период
                    decimal sumMonth = payment - perMonth; //Расчёт суммы к погашению основной задолженности в теле платежа

                    if (cbCom.Checked) //Если комиссия включена
                        sumMonth -= com; //Из суммы к погашению основной задолженности в теле платежа вычитается ежемесячная комиссия
                    sum -= sumMonth; //Сумма основной задолженности уменьшается на сумму к погашению основной задолженности (в теле платежа)

                    ListViewItem item = new ListViewItem((i + 1).ToString()); //Создание новой строки графика платежей для декремента цикла количества периодов

                    item.SubItems.Add(Math.Round(payMonth, 2).ToString());
                    item.SubItems.Add(Math.Round(perMonth, 2).ToString()); //Округление и передача в график платежей суммы процентов в теле ежемесячного платежа
                    item.SubItems.Add(Math.Round(sumMonth, 2).ToString()); //Округление и передача в график платежей суммы к погашению основной задолженности
                    item.SubItems.Add(Math.Round(sum, 2).ToString()); //Округление и передача в график платежей значения основной задолженности

                    if (cbCom.Checked) //Если комиссия включена
                    {
                        item.SubItems.Add(Math.Round(com, 2).ToString()); // Округление и добавление в график платежей суммы ежемесячной комиссии
                    }

                    lvPayments.Items.Add(item); //Добавить в график платежей (ListViewItem)
                }
                else
                {
                    decimal perMonth = sum * percent; //Расчёт процентов в теле платежа за 1 период
                    decimal sumMonth = sum2 / time; //Расчёт суммы к погашению основной задолженности в теле платежа
                    decimal payMonth = sumMonth + perMonth;

                    if (cbCom.Checked) //Если комиссия включена
                        payMonth += com; //Из суммы к погашению основной задолженности в теле платежа вычитается ежемесячная комиссия
                    sum -= sumMonth; //Сумма основной задолженности уменьшается на сумму к погашению основной задолженности (в теле платежа)

                    ListViewItem item = new ListViewItem((i + 1).ToString()); //Создание новой строки графика платежей для декремента цикла количества периодов

                    item.SubItems.Add(Math.Round(payMonth, 2).ToString());
                    item.SubItems.Add(Math.Round(perMonth, 2).ToString()); //Округление и передача в график платежей суммы процентов в теле ежемесячного платежа
                    item.SubItems.Add(Math.Round(sumMonth, 2).ToString()); //Округление и передача в график платежей суммы к погашению основной задолженности
                    item.SubItems.Add(Math.Round(sum, 2).ToString()); //Округление и передача в график платежей значения основной задолженности

                    if (cbCom.Checked) //Если комиссия включена
                    {
                        item.SubItems.Add(Math.Round(com, 2).ToString()); // Округление и добавление в график платежей суммы ежемесячной комиссии
                    }

                    lvPayments.Items.Add(item); //Добавить в график платежей (ListViewItem)
                }
            }
        }

        private void cbCom_CheckedChanged(object sender, System.EventArgs e) //Проверка включения в расчёт ежемесяной комисии
        {
            tbCom.ReadOnly = !cbCom.Checked; //Текст-бокс активен при включении комиссии пользователем для присвоения, чтения и использования значения комиссии 
        }

        private void cbDef_CheckedChanged(object sender, EventArgs e) //Проверка включения расчёта дифференцированого платежа
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // Работа кнопки выход
        {
            this.Close();
        }
        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)// Обеспечивает передвижение окна по координатам X и Y
        {
            if(e.Button==MouseButtons.Left)                         //...
            {                                                       //
                this.Left += e.X - lastPoint.X;                     //      
                this.Top += e.Y - lastPoint.Y;                      //  
                                                                    //
            }                                                       //
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);                        //...
        }

        private void lvPayments_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
} 