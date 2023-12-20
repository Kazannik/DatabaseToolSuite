using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DatabaseToolSuite.Controls.Base
{
    [DesignerCategory("code")]
    [ToolboxBitmap(typeof(ComboBox))]
    [ComVisible(false)]
     public abstract class ComboBoxBase : ComboBox
    {
        protected StringFormat sfCode;
        protected StringFormat sfCaption;

        #region Initialize

        [DebuggerNonUserCode()]
        public ComboBoxBase (IContainer container) :this()
        {
            if (container != null) { container.Add(this); }
        }

        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        { try
            {
                if (disposing && components != null)
                { components.Dispose(); }
            }
            finally
            { base.Dispose(disposing); }
        }

        private IContainer components;

        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new Container();
        }

        public ComboBoxBase():base()
        {
            sfCode =(StringFormat) StringFormat.GenericTypographic.Clone();
            sfCode.Alignment = StringAlignment.Center;
            sfCode.LineAlignment = StringAlignment.Center;
            sfCode.FormatFlags = StringFormatFlags.NoClip | StringFormatFlags.NoWrap;

            sfCaption = (StringFormat)StringFormat.GenericTypographic.Clone();
            sfCaption.Alignment = StringAlignment.Near;
            sfCaption.LineAlignment = StringAlignment.Near;
            sfCaption.FormatFlags = StringFormatFlags.NoClip | StringFormatFlags.NoWrap;


            InitializeComponent();

            base.DropDownStyle = ComboBoxStyle.DropDownList;
            base.DrawMode = DrawMode.OwnerDrawFixed;
            base.MaxDropDownItems = 20;
            base.DropDownWidth = 80;
            base.AutoSize = false;
            base.Width = 80;
            base.DropDownHeight = 80;
            base.Items.Clear();
        }

        #endregion

        #region Draw Item

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Graphics graphics = e.Graphics;

            SizeF CodeSize = graphics.MeasureString("FFFFFFF", Font);
            ItemHeight =(int) CodeSize.Height + SystemInformation.BorderSize.Height * 4;
            DropDownHeight = ItemHeight * 8 + SystemInformation.BorderSize.Height * 4;

            Rectangle rectSelection = new Rectangle(e.Bounds.X + 1, e.Bounds.Y, e.Bounds.Width - 3, e.Bounds.Height - 1);
            Rectangle rectCode = new Rectangle(rectSelection.X + 2, rectSelection.Y + 2,(int) CodeSize.Width, rectSelection.Height - 4);
            Rectangle rectText = new Rectangle(rectCode.X + rectCode.Width + 6, rectCode.Y, e.Bounds.Width - rectCode.X - rectCode.Width - 6, rectCode.Height);

            Size TextSize = new Size(rectText.Width - SystemInformation.VerticalScrollBarWidth - 8, rectText.Height);


            Brush backCodeBrush, foreCodeBrush, backCaptionBrush, foreCaptionBrush;
            Pen borderPen;

            if (e.Index == -1)
            {
                backCodeBrush = SystemBrushes.Control;
                foreCodeBrush = SystemBrushes.ControlText;
                foreCaptionBrush = new SolidBrush(ForeColor);
                backCaptionBrush = new SolidBrush(BackColor);
                borderPen = new Pen(ForeColor);

                graphics.FillRectangle(backCaptionBrush, e.Bounds);
                graphics.FillRectangle(backCodeBrush, rectCode);
                graphics.DrawRectangle(borderPen, rectCode);
                graphics.DrawString("", Font, foreCodeBrush, rectCode, sfCode);
                graphics.DrawString("(не выбрано)", Font, foreCaptionBrush, rectText, sfCaption);
                return;
             }

            if (base.Items.Count <= e.Index) return;
            string itemCodeString = this[e.Index].Code;
            string itemCaptionString = this[e.Index].Text.Trim();
            if ((e.State & DrawItemState.ComboBoxEdit) == DrawItemState.ComboBoxEdit)
            {
                backCodeBrush = new SolidBrush(BackColor);
                foreCodeBrush = new SolidBrush(ForeColor);
                foreCaptionBrush = new SolidBrush(ForeColor);
                backCaptionBrush = new SolidBrush(BackColor);
                borderPen = new Pen(ForeColor);
            }
            else
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {                  
                    backCodeBrush = new LinearGradientBrush(rectCode, Color.FromArgb(249, 249, 249), Color.FromArgb(241, 241, 241), LinearGradientMode.Vertical);
                    foreCodeBrush = new SolidBrush(Color.FromArgb(0, 102, 204));
                    backCaptionBrush = SystemBrushes.Highlight;
                    foreCaptionBrush = new SolidBrush(this.BackColor); 
                    borderPen = new Pen( Color.FromArgb(0, 102, 204),1); 
                }
                else
                {
                    backCodeBrush = new SolidBrush(BackColor);
                    foreCodeBrush = new SolidBrush(ForeColor);
                    backCaptionBrush = new SolidBrush(BackColor);
                    foreCaptionBrush = new SolidBrush(ForeColor);
                    borderPen = new Pen(ForeColor, 1);
                }
            }
            graphics.FillRectangle(backCaptionBrush, e.Bounds);
            graphics.FillRectangle(backCodeBrush, rectCode);
            graphics.DrawRectangle(borderPen, rectCode);
            graphics.DrawString(itemCodeString, Font, foreCodeBrush, rectCode, sfCode);
            graphics.DrawString(itemCaptionString, Font, foreCaptionBrush, rectText, sfCaption);
        }
        #endregion

        [ReadOnly(true)]
        public IComboBoxItem this[int index]
        {
            get
            {
                return (IComboBoxItem)base.Items[index: index];               
            }
        }

        [ReadOnly(true)]
        public new ComboBoxStyle DropDownStyle
        {
            get { return base.DropDownStyle; }
        }

        protected void Clear()
        {
            base.Items.Clear();
        }

        protected void Insert(int index, IComboBoxItem item)
        {
            base.Items.Insert(index, item);
        }

        protected void Remove(IComboBoxItem value)
        {
            base.Items.Remove(value);
        }
        protected void RemoveAt(int index)
        {
            base.Items.RemoveAt(index);
        }
        public int Add(IComboBoxItem item)
        {
            foreach (IComboBoxItem i in base.Items)
            {
                if (i.Code == item.Code)
                {
                    throw new ArgumentException("Элемент с кодом [" + item.Code.ToString() + "] ранее добавлен в коллекцию.", "item.Code");
                }
            }
            return base.Items.Add(item);
        }

        public string SelectedCode
        {
            get
            {
                return ((IComboBoxItem)this.SelectedItem).Code;
            }
        }

        new string SelectedText
        {
            get
            {
                return ((IComboBoxItem)this.SelectedItem).Text;
            }
        }

        public abstract int Add(string code, string text);

        public interface IComboBoxItem
        {
            string Code { get; }
            string Text { get; }
        }
    }
}
