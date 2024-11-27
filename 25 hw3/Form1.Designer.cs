namespace hw
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освобождение всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                time_move.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Метод, необходимый для поддержки конструктора — не изменяйте
        /// его содержимое с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.time_move = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
           
            this.time_move.Interval = 50;
            this.time_move.Tick += new System.EventHandler(this.TimerMove_Tick);
           
            this.KeyPreview = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Resizing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer time_move;
    }
}
