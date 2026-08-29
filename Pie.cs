// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.Pie
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

#nullable disable
namespace LDChartControlPlus;

[ToolboxBitmap("D:\\Visual Studio 2005\\Projects\\LDChartControlPlus\\Resources\\ChartPie.bmp")]
public class Pie : UserControl
{
  private IContainer components;
  private Color m_valueColor;
  private Font m_valueFont;
  private Color m_lineArcColor;
  private List<Pie.PieItem> m_listPieItem;
  private bool m_useCustomColor;
  private Color m_legendColor;
  private Font m_legendFont;
  private Color m_legendRoundLineColor;
  private Color m_legendRoundBackColor;
  private bool m_showBoundLine;
  private Color m_roundPenColor;
  private int m_roundPenWidth;
  private float m_roundRadius;
  private Color m_roundBackColor;

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
    this.Name = nameof (Pie);
    this.Size = new Size(562, 333);
    this.DoubleClick += new EventHandler(this.Pie_DoubleClick);
    this.ResumeLayout(false);
  }

  [Description("Fonte do Valor")]
  [Category("Pie")]
  public Font ValueFont
  {
    get => this.m_valueFont;
    set
    {
      this.m_valueFont = value;
      this.Invalidate();
    }
  }

  [Description("Cor do Valor")]
  [Category("Pie")]
  public Color ValueColor
  {
    get => this.m_valueColor;
    set
    {
      this.m_valueColor = value;
      this.Invalidate();
    }
  }

  [Description("Cor da linha do Arco")]
  [Category("Pie")]
  public Color LineArcColor
  {
    get => this.m_lineArcColor;
    set
    {
      this.m_lineArcColor = value;
      this.Invalidate();
    }
  }

  [Category("Pie")]
  [Description("Cor do Pie e da Legenda")]
  public bool UseCustomColor
  {
    get => this.m_useCustomColor;
    set
    {
      this.m_useCustomColor = value;
      this.Invalidate();
    }
  }

  [Description("Fonte da Legenda")]
  [Category("Legend")]
  public Font LegendFont
  {
    get => this.m_legendFont;
    set
    {
      this.m_legendFont = value;
      this.Invalidate();
    }
  }

  [Category("Legend")]
  [Description("Cor da Fonte da Legenda")]
  public Color LegendColor
  {
    get => this.m_legendColor;
    set
    {
      this.m_legendColor = value;
      this.Invalidate();
    }
  }

  [Category("Legend")]
  [Description("Cor da linha do retângulo da Legenda")]
  public Color LegendRoundLineColor
  {
    get => this.m_legendRoundLineColor;
    set
    {
      this.m_legendRoundLineColor = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo da Legenda")]
  [Category("Legend")]
  public Color LegendRoundBackColor
  {
    get => this.m_legendRoundBackColor;
    set
    {
      this.m_legendRoundBackColor = value;
      this.Invalidate();
    }
  }

  [Category("Round")]
  [Description("Desenha uma linha ao redor do Pie")]
  public bool ShowBoundLine
  {
    get => this.m_showBoundLine;
    set
    {
      this.m_showBoundLine = value;
      this.Invalidate();
    }
  }

  [Description("Cor da linha")]
  [Category("Round")]
  public Color RoundPenColor
  {
    get => this.m_roundPenColor;
    set
    {
      this.m_roundPenColor = value;
      this.Invalidate();
    }
  }

  [Category("Round")]
  [Description("Largura da linha")]
  public int RoundPenWidth
  {
    get => this.m_roundPenWidth;
    set
    {
      this.m_roundPenWidth = value;
      this.Invalidate();
    }
  }

  [Description("Radius da round")]
  [Category("Round")]
  public float RoundRadius
  {
    get => this.m_roundRadius;
    set
    {
      this.m_roundRadius = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo")]
  [Category("Round")]
  public Color RoundBackColor
  {
    get => this.m_roundBackColor;
    set
    {
      this.m_roundBackColor = value;
      this.Invalidate();
    }
  }

  public Pie()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    this.m_valueFont = new Font("Arial", 10f, FontStyle.Bold);
    this.m_valueColor = Color.Black;
    this.m_lineArcColor = Color.Black;
    this.m_listPieItem = new List<Pie.PieItem>();
    this.m_useCustomColor = false;
    this.m_legendFont = new Font("Tahoma", 10f, FontStyle.Regular);
    this.m_legendColor = Color.Black;
    this.m_legendRoundLineColor = Color.Black;
    this.m_legendRoundBackColor = Color.WhiteSmoke;
    this.m_showBoundLine = false;
    this.m_roundRadius = 60f;
    this.m_roundPenColor = Color.SteelBlue;
    this.m_roundPenWidth = 1;
    this.m_roundBackColor = this.BackColor;
    List<Pie.PieItem> listPieItem = new List<Pie.PieItem>();
    Pie.PieItem pieItem = new Pie.PieItem();
    pieItem.Label = "Sim";
    pieItem.Value = 10;
    pieItem.ColorPie = Color.Blue;
    listPieItem.Add(pieItem);
    pieItem.Label = "Não";
    pieItem.Value = 30;
    pieItem.ColorPie = Color.Red;
    listPieItem.Add(pieItem);
    pieItem.Label = "Talvez Sim\\Talvez Não";
    pieItem.Value = 70;
    pieItem.ColorPie = Color.Green;
    listPieItem.Add(pieItem);
    this.AddPieItems(listPieItem);
    this.Invalidate();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
    if (this.m_showBoundLine)
      Function.DrawRoundRect(e.Graphics, new Pen(this.m_roundPenColor, (float) this.m_roundPenWidth), new RectangleF()
      {
        X = (float) (this.m_roundPenWidth - 1),
        Y = (float) (this.m_roundPenWidth - 1),
        Width = (float) (this.Width - this.m_roundPenWidth * 2 + 1),
        Height = (float) (this.Height - this.m_roundPenWidth * 2 + 1)
      }, this.m_roundRadius, new Color?(this.m_roundBackColor));
    this.DrawPieChart(e.Graphics);
  }

  public void AddPieItems(List<Pie.PieItem> listPieItem)
  {
    try
    {
      this.m_listPieItem = listPieItem;
      this.Invalidate();
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void DrawPieChart(Graphics grPaint)
  {
    try
    {
      List<Color> colorList = new List<Color>();
      if (this.m_useCustomColor)
      {
        for (int index = 0; index < this.m_listPieItem.Count; ++index)
          colorList.Add(this.m_listPieItem[index].ColorPie);
      }
      else
      {
        colorList.Add(Color.Blue);
        colorList.Add(Color.Red);
        colorList.Add(Color.Yellow);
        colorList.Add(Color.Green);
        colorList.Add(Color.Cyan);
        colorList.Add(Color.Orange);
        colorList.Add(Color.Teal);
        colorList.Add(Color.Maroon);
        colorList.Add(Color.DimGray);
        colorList.Add(Color.SkyBlue);
        colorList.Add(Color.SteelBlue);
        colorList.Add(Color.LightCoral);
        colorList.Add(Color.SlateGray);
        colorList.Add(Color.MistyRose);
        colorList.Add(Color.RoyalBlue);
        colorList.Add(Color.Chocolate);
        colorList.Add(Color.Tan);
        colorList.Add(Color.Navy);
        colorList.Add(Color.SlateBlue);
        colorList.Add(Color.Olive);
        colorList.Add(Color.Indigo);
        colorList.Add(Color.OliveDrab);
        colorList.Add(Color.Purple);
        colorList.Add(Color.ForestGreen);
        colorList.Add(Color.Crimson);
      }
      int total = 0;
      float num1 = 0.0f;
      SizeF sizeF1 = new SizeF();
      for (int index = 0; index < this.m_listPieItem.Count; ++index)
      {
        total += this.m_listPieItem[index].Value;
        SizeF sizeF2 = grPaint.MeasureString(this.m_listPieItem[index].Label, this.m_legendFont);
        float width = sizeF2.Width;
        if ((double) width > (double) num1)
        {
          sizeF1 = sizeF2;
          num1 = width;
        }
      }
      SizeF sizeF3 = grPaint.MeasureString("[100,00%]", this.m_legendFont);
      float num2 = 360f / (float) total;
      Rectangle rect1 = new Rectangle();
      int num3 = this.Height / 10;
      rect1.Width = (int) ((double) (this.Width - 60) - (double) sizeF1.Width + (double) sizeF1.Width * 0.20000000298023224);
      rect1.Height = num3 * 7;
      rect1.Y = num3;
      rect1.X = 60;
      if (rect1.Width > rect1.Height)
        rect1.Width = rect1.Height;
      else
        rect1.Height = rect1.Width;
      float startAngle = 0.0f;
      int index1 = 0;
      Rectangle rect2 = new Rectangle();
      rect2.Height = (double) sizeF1.Height < 10.0 ? 10 : (int) sizeF1.Height;
      rect2.Width = 10;
      rect2.X = rect1.Width + 120;
      int num4 = (this.Height - (this.m_listPieItem.Count * rect2.Height + this.m_listPieItem.Count * rect2.Height / 2)) / 2;
      rect2.Y = num4;
      Function.DrawRoundRect(grPaint, new Pen(this.m_legendRoundLineColor, 2f), new RectangleF()
      {
        X = (float) (rect2.X - 8),
        Y = (float) (num4 - 5),
        Width = (float) ((double) rect2.Width + (double) sizeF1.Width + 6.0 + (double) sizeF3.Width + 6.0),
        Height = (float) (this.m_listPieItem.Count * rect2.Height + this.m_listPieItem.Count * rect2.Height / 2 + 3)
      }, 8f, new Color?(this.m_legendRoundBackColor));
      List<float> floatList = new List<float>();
      for (int index2 = 0; index2 < this.m_listPieItem.Count; ++index2)
      {
        grPaint.FillPie((Brush) new SolidBrush(colorList[index1]), rect1, startAngle, (float) this.m_listPieItem[index2].Value * num2);
        grPaint.DrawPie(new Pen(this.m_lineArcColor), rect1, startAngle, (float) this.m_listPieItem[index2].Value * num2);
        string percentage = Function.GetPercentage((float) this.m_listPieItem[index2].Value, (float) total, 2);
        grPaint.FillRectangle((Brush) new SolidBrush(colorList[index1]), rect2);
        grPaint.DrawRectangle(new Pen(Color.Black), rect2);
        PointF pointF = new PointF((float) (rect2.Right + 3), (float) rect2.Top);
        if (this.m_useCustomColor)
          this.m_legendColor = colorList[index1];
        Function.DrawString(ref grPaint, this.m_listPieItem[index2].Label, this.m_legendFont, this.m_legendColor, 0, pointF);
        pointF = new PointF((float) ((double) (rect2.Right + 3) + (double) sizeF1.Width + 6.0), (float) rect2.Top);
        Function.DrawString(ref grPaint, $"[{percentage}%]", this.m_legendFont, this.m_legendColor, 0, pointF);
        floatList.Add(startAngle);
        startAngle += (float) this.m_listPieItem[index2].Value * num2;
        ++index1;
        if (index1 >= colorList.Count)
          index1 = 0;
        rect2.Y += rect2.Height + rect2.Height / 2;
      }
    }
    catch
    {
    }
  }

  protected float TransformAngle(float angle, int width, int height)
  {
    double x = (double) width * Math.Cos((double) angle * Math.PI / 180.0);
    float num = (float) (Math.Atan2((double) height * Math.Sin((double) angle * Math.PI / 180.0), x) * 180.0 / Math.PI);
    return (double) num < 0.0 ? num + 360f : num;
  }

  private void CountPoint(
    float nAngle,
    ref PointF pt,
    RectangleF recPie,
    SizeF strSize,
    Point center,
    bool bPercent)
  {
    while ((double) nAngle < 0.0)
      nAngle += 360f;
    while ((double) nAngle > 359.0)
      nAngle -= 360f;
    double num1 = (double) nAngle * Math.PI / 180.0;
    double num2 = (double) recPie.Height * 0.5;
    if (bPercent)
      num2 = num2 * 3.0 / 5.0;
    double num3 = num2 * Math.Cos(num1);
    double num4 = 0.0 + num2 * Math.Sin(num1);
    double num5 = ((double) recPie.Right + (double) recPie.Left) * 0.5;
    double num6 = ((double) recPie.Top + (double) recPie.Bottom) * 0.5;
    pt.X = (float) (int) (num5 + num3);
    pt.Y = (float) (int) (num6 + num4);
    if ((double) nAngle > 270.0)
    {
      pt.X += 2f;
      pt.Y -= strSize.Height * 0.5f;
    }
    else if ((double) nAngle > 180.0)
    {
      pt.X -= strSize.Width * 0.5f;
      pt.Y -= strSize.Height * 0.5f;
    }
    else if ((double) nAngle > 90.0)
    {
      pt.X += strSize.Width * 0.5f;
      pt.Y += 2f;
    }
    else
    {
      if ((double) nAngle <= 0.0)
        return;
      pt.X += 2f;
      pt.Y += strSize.Width * 0.5f;
    }
  }

  private double DegreeToRadian(double angle) => Math.PI * angle / 180.0;

  private double RadianToDegree(double angle) => angle * (180.0 / Math.PI);

  public Bitmap GetBitmapFromGraphic(bool setClipBoard)
  {
    try
    {
      Application.DoEvents();
      Bitmap image = Utilitarios.GetImage(this.Handle, this.Width, this.Height);
      if (setClipBoard)
        Clipboard.SetImage((Image) image);
      return image;
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void Pie_DoubleClick(object sender, EventArgs e)
  {
    try
    {
      this.GetBitmapFromGraphic(true);
      int num = (int) MessageBox.Show("Imagem copiada para o clipboard com sucesso!\n\nObs.: para colar aperte as teclas [Ctrl + V] em algum programa que aceita colar imagem.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  public struct PieItem
  {
    public string Label;
    public int Value;
    public Color ColorPie;
  }
}
