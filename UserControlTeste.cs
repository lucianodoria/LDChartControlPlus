// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.UserControlTeste
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace LDChartControlPlus;

public class UserControlTeste : UserControl
{
  private IContainer components;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Name = nameof (UserControlTeste);
    this.Size = new Size(313, 241);
    this.ResumeLayout(false);
  }

  public UserControlTeste()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    Graphics graphics = e.Graphics;
    Color.FromArgb(0);
    Color blue = Color.Blue;
    if ((double) blue.GetBrightness() < 0.5)
    {
      try
      {
        this.BackColor = Color.FromArgb((int) blue.R + 76, (int) blue.G + 71, (int) blue.B + 66);
      }
      catch
      {
        this.BackColor = Color.FromArgb(250, 250, 250);
      }
    }
    else
    {
      try
      {
        this.BackColor = Color.FromArgb((int) blue.R - 96 /*0x60*/, (int) blue.G - 91, (int) blue.B - 86);
      }
      catch
      {
        this.BackColor = Color.FromArgb(10, 10, 10);
      }
    }
    KnownColor[] knownColorArray = new KnownColor[15];
    int num = 0;
    for (KnownColor color = (KnownColor) 0; color <= KnownColor.YellowGreen && num < 15; ++color)
    {
      if ((double) Color.FromKnownColor(color).GetBrightness() == (double) blue.GetBrightness())
        knownColorArray[num++] = color;
    }
    SolidBrush solidBrush = new SolidBrush(blue);
    Font font = new Font("Arial", 12f);
    int x = 20;
    int y = 20;
    Color color1 = blue;
    graphics.FillRectangle((Brush) solidBrush, x, y, 100, 30);
    graphics.DrawString(color1.ToString(), font, Brushes.Black, (float) (x + 120), (float) y);
    for (int index = 0; index < num; ++index)
    {
      y += 40;
      Color color2 = Color.FromKnownColor(knownColorArray[index]);
      solidBrush.Color = color2;
      graphics.FillRectangle((Brush) solidBrush, x, y, 100, 30);
      graphics.DrawString(color2.ToString(), font, Brushes.Black, (float) (x + 120), (float) y);
    }
    base.OnPaint(e);
  }
}
