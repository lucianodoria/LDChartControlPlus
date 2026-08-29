// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.ChartBarNivel
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.Windows.Forms;

#nullable disable
namespace LDChartControlPlus;

[ToolboxBitmap("D:\\Visual Studio 2005\\Projects\\LDChartControlPlus\\Resources\\grafico_Acertividade.bmp")]
public class ChartBarNivel : UserControl
{
  private const int MARK_SIZE = 3;
  private const int STEP_VALUE_Y = 1;
  private const int MAX_VALUE_Y = 5;
  private IContainer components;
  private ToolTip toolTip1;
  private List<ChartBarNivel.ItemsChartNivel> m_itemsChart;
  private int m_barCount;
  private string m_titleTop;
  private bool m_showTitleTop;
  private Font m_titleFontTop;
  private Color m_titleColorTop;
  private Color m_BGColor1;
  private Color m_BGColor2;
  private Image m_BGImage;
  private int m_colorMatrix;
  private ImageAttributes m_BGImageAttributes;
  private LinearGradientMode m_BGLinearGradientMode;
  private Color m_gridLineColor;
  private Pen m_gridLinePen;
  private Color m_gridColor;
  private DashStyle m_gridDashStyle;
  private Pen m_gridPen;
  private Color m_gridBGColor;
  private bool m_showHighlightValue;
  private int m_rotateLabelValue;
  private Font m_barLabelFont;
  private Font m_barValueFont;
  private Color m_barLabelColor;
  private string m_legendY;
  private bool m_showLegendY;
  private Font m_legendYFont;
  private Color m_legendYColor;
  private Color m_stepColorValueY;
  private Font m_stepValueYFont;
  private bool m_ShowGridY;
  private string m_legendX;
  private bool m_showLegendX;
  private Font m_legendXFont;
  private Color m_legendXColor;
  private bool m_ShowGridX;
  private int m_maxCountCharLineLabelX;
  private DirectionLabel m_labelXDirection;
  private RotateFlipType m_rotateFlipType;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    this.toolTip1 = new ToolTip(this.components);
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Name = "ChartBarAcertividade";
    this.Size = new Size(362, 236);
    this.DoubleClick += new EventHandler(this.ChartBarAcertividade_DoubleClick);
    this.ResumeLayout(false);
  }

  public ChartBarNivel()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint, true);
    this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
    this.BackColor = Color.White;
    this.m_titleTop = "Título";
    this.m_showTitleTop = false;
    this.m_titleFontTop = new Font("Tahoma", 10f, FontStyle.Bold);
    this.m_titleColorTop = Color.SteelBlue;
    this.m_legendY = "Legenda Y";
    this.m_showLegendY = false;
    this.m_legendYFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_legendYColor = Color.CadetBlue;
    this.m_stepValueYFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_ShowGridY = true;
    this.m_stepColorValueY = Color.Maroon;
    this.m_legendX = "Legenda X";
    this.m_showLegendX = false;
    this.m_legendXFont = new Font("Tahoma", 10f, FontStyle.Bold);
    this.m_legendXColor = Color.SteelBlue;
    this.m_ShowGridX = true;
    this.m_maxCountCharLineLabelX = 20;
    this.m_labelXDirection = DirectionLabel.Horizontal;
    this.m_rotateLabelValue = 0;
    this.m_barCount = 0;
    this.m_gridColor = Color.DimGray;
    this.m_gridDashStyle = DashStyle.Solid;
    this.m_gridPen = new Pen(this.m_gridColor);
    this.m_gridPen.DashStyle = this.m_gridDashStyle;
    this.m_gridBGColor = Color.WhiteSmoke;
    this.m_gridLineColor = Color.Black;
    this.m_gridLinePen = new Pen(this.m_gridLineColor);
    this.m_BGColor1 = Color.White;
    this.m_BGColor2 = Color.White;
    this.m_BGLinearGradientMode = LinearGradientMode.Horizontal;
    this.m_BGImage = (Image) null;
    this.m_BGImageAttributes = new ImageAttributes();
    this.m_colorMatrix = 200;
    this.m_showHighlightValue = true;
    this.m_barLabelFont = new Font("Tahoma", 8f, FontStyle.Regular);
    this.m_barLabelColor = Color.Navy;
    this.m_barValueFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_itemsChart = new List<ChartBarNivel.ItemsChartNivel>();
  }

  [Description("Define a cor do grid.")]
  [Category("Grid")]
  public Color GridColor
  {
    get => this.m_gridColor;
    set
    {
      this.m_gridColor = value;
      this.m_gridPen = new Pen(this.m_gridColor);
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      this.Invalidate();
    }
  }

  [Category("Grid")]
  [Description("Define a cor da linha do retângulo do grid.")]
  public Color GridLineColor
  {
    get => this.m_gridLineColor;
    set
    {
      this.m_gridLineColor = value;
      this.m_gridLinePen = new Pen(this.m_gridLineColor);
      this.Invalidate();
    }
  }

  [Description("Define se dever mostrar o grid do eixo Y..")]
  [Category("Grid")]
  public bool ShowGridY
  {
    get => this.m_ShowGridY;
    set
    {
      this.m_ShowGridY = value;
      this.Invalidate();
    }
  }

  [Category("Grid")]
  [Description("Define se dever mostrar o grid do eixo X.")]
  public bool ShowGridX
  {
    get => this.m_ShowGridX;
    set
    {
      this.m_ShowGridX = value;
      this.Invalidate();
    }
  }

  [Description("Define o estilo da linha do grid.")]
  [Category("Grid")]
  public DashStyle GridDashStyle
  {
    get => this.m_gridDashStyle;
    set
    {
      this.m_gridDashStyle = value;
      this.m_gridPen = new Pen(this.m_gridColor);
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      this.Invalidate();
    }
  }

  [Description("Define a cor do grid.")]
  [Category("Grid")]
  public Color GridBGColor
  {
    get => this.m_gridBGColor;
    set
    {
      this.m_gridBGColor = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Destaca o valor no topo da barra ou não.")]
  public bool ShowHighlightValue
  {
    get => this.m_showHighlightValue;
    set
    {
      this.m_showHighlightValue = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Fonte do Label da barra.")]
  public Font BarLabelFont
  {
    get => this.m_barLabelFont;
    set
    {
      this.m_barLabelFont = value;
      this.Invalidate();
    }
  }

  [Description("Fonte do valor da barra.")]
  [Category("Bar")]
  public Font BarValueFont
  {
    get => this.m_barValueFont;
    set
    {
      this.m_barValueFont = value;
      this.Invalidate();
    }
  }

  [Description("Cor da Fonte do Label da barra.")]
  [Category("Bar")]
  public Color BarLabelColor
  {
    get => this.m_barLabelColor;
    set
    {
      this.m_barLabelColor = value;
      this.Invalidate();
    }
  }

  [Description("Define o valor que o texto do valor da barra deve rotacionar.")]
  [Category("Bar")]
  public int RotateLabelValue
  {
    get => this.m_rotateLabelValue;
    set
    {
      this.m_rotateLabelValue = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Cor de fundo 1")]
  public Color BGColor1
  {
    get => this.m_BGColor1;
    set
    {
      this.m_BGColor1 = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo 2")]
  [Category("Chart")]
  public Color BGColor2
  {
    get => this.m_BGColor2;
    set
    {
      this.m_BGColor2 = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Direção da Cor de fundo gradiente.")]
  public LinearGradientMode BGLinearGradientMode
  {
    get => this.m_BGLinearGradientMode;
    set
    {
      this.m_BGLinearGradientMode = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Define/resgata o texto do título.")]
  public string Title
  {
    get => this.m_titleTop;
    set
    {
      this.m_titleTop = value;
      this.Invalidate();
    }
  }

  [Description("Define se dever mostrar o título.")]
  [Category("Chart")]
  public bool ShowTitle
  {
    get => this.m_showTitleTop;
    set
    {
      this.m_showTitleTop = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a fonte do texto do título.")]
  [Category("Chart")]
  public Font TitleFont
  {
    get => this.m_titleFontTop;
    set
    {
      this.m_titleFontTop = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor do texto do título.")]
  [Category("Chart")]
  public Color TitleColor
  {
    get => this.m_titleColorTop;
    set
    {
      this.m_titleColorTop = value;
      this.Invalidate();
    }
  }

  [Description("Image de fundo")]
  [Category("Chart")]
  public Image BGImage
  {
    get => this.m_BGImage;
    set
    {
      this.m_BGImage = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Valor da tranparência da imagem de fundo.")]
  public int BGImageTransparentValue
  {
    get => this.m_colorMatrix;
    set
    {
      this.m_colorMatrix = value;
      this.m_BGImageAttributes.SetColorMatrix(new ColorMatrix()
      {
        Matrix33 = (float) this.m_colorMatrix
      });
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata o legenda do eixo Y.")]
  public string LegendY
  {
    get => this.m_legendY;
    set
    {
      this.m_legendY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define se dever mostrar a legenda do eixo Y.")]
  public bool ShowLegendY
  {
    get => this.m_showLegendY;
    set
    {
      this.m_showLegendY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a fonte da legenda do eixo Y.")]
  public Font LegendYFont
  {
    get => this.m_legendYFont;
    set
    {
      this.m_legendYFont = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a Cor da legenda do eixo Y.")]
  public Color LegendYColor
  {
    get => this.m_legendYColor;
    set
    {
      this.m_legendYColor = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor do step value do eixo Y.")]
  [Category("Eixo Y")]
  public Color StepColorValueY
  {
    get => this.m_stepColorValueY;
    set
    {
      this.m_stepColorValueY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define/resgata o legenda do eixo X.")]
  public string LegendX
  {
    get => this.m_legendX;
    set
    {
      this.m_legendX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define se dever mostrar a legenda do eixo X.")]
  public bool ShowLegendX
  {
    get => this.m_showLegendX;
    set
    {
      this.m_showLegendX = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a fonte da legenda do eixo X.")]
  [Category("Eixo X")]
  public Font LegendXFont
  {
    get => this.m_legendXFont;
    set
    {
      this.m_legendXFont = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Define/resgata a Cor da legenda do eixo X.")]
  public Color LegendXColor
  {
    get => this.m_legendXColor;
    set
    {
      this.m_legendXColor = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [Description("Quantidade máxima de caracteres do label do eixo X.")]
  public int MaxCountCharLineLabelX
  {
    get => this.m_maxCountCharLineLabelX;
    set
    {
      this.m_maxCountCharLineLabelX = value;
      this.Invalidate();
    }
  }

  [Category("Eixo X")]
  [DefaultValue(DirectionLabel.Horizontal)]
  [Description("Direção do label do eixo X.")]
  public DirectionLabel LabelXDirection
  {
    get => this.m_labelXDirection;
    set
    {
      this.m_labelXDirection = value;
      this.Invalidate();
    }
  }

  [DefaultValue(RotateFlipType.RotateNoneFlipNone)]
  [Category("Eixo X")]
  [Description("Direção do label do eixo X.")]
  public RotateFlipType RotacaoLegenda
  {
    get => this.m_rotateFlipType;
    set
    {
      this.m_rotateFlipType = value;
      this.Invalidate();
    }
  }

  public void AddItems(List<ChartBarNivel.ItemsChartNivel> lstItemsChart)
  {
    this.ClearItems();
    if (lstItemsChart == null)
      return;
    this.m_itemsChart = lstItemsChart;
    this.m_barCount = this.m_itemsChart.Count;
    this.Invalidate();
  }

  public void ClearItems()
  {
    this.m_itemsChart.Clear();
    this.Invalidate();
  }

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

  protected override void OnPaint(PaintEventArgs e)
  {
    float num1 = 10f;
    float num2 = 30f;
    float num3 = 30f;
    float num4 = 100f;
    RectangleF rect1 = new RectangleF();
    SizeF sizeF1 = new SizeF(0.0f, 0.0f);
    SizeF sizeF2 = new SizeF(0.0f, 0.0f);
    SizeF sizeF3 = new SizeF(0.0f, 0.0f);
    SizeF sizeF4 = new SizeF(0.0f, 0.0f);
    Graphics graphics = e.Graphics;
    try
    {
      graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
      graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
      if (this.m_showTitleTop)
        sizeF1 = graphics.MeasureString(this.m_titleTop, this.m_titleFontTop);
      if (this.m_showLegendY)
        sizeF3 = graphics.MeasureString(this.m_legendY, this.m_legendYFont);
      if (this.m_showLegendX)
        sizeF2 = graphics.MeasureString(this.m_legendX, this.m_legendXFont);
      SizeF sizeF5 = graphics.MeasureString("TESTE", this.m_barLabelFont);
      SizeF sizeF6 = graphics.MeasureString(5.ToString(), this.m_stepValueYFont);
      float num5 = num3 + sizeF1.Height;
      float num6 = num1 + (float) ((double) sizeF3.Height + (double) sizeF6.Width + 5.0);
      float num7 = num4 + (sizeF2.Height + sizeF5.Height);
      int num8 = 5;
      float num9 = ((float) this.Height - (num5 + num7)) / (float) num8;
      rect1.X = num6;
      rect1.Y = num5;
      rect1.Width = (float) this.Width - (num6 + num2);
      rect1.Height = num9 * (float) num8;
      Rectangle rect2 = new Rectangle(0, 0, this.Width, this.Height);
      graphics.FillRectangle((Brush) new LinearGradientBrush(rect2, this.m_BGColor1, this.m_BGColor2, this.m_BGLinearGradientMode), rect2);
      graphics.FillRectangle((Brush) new SolidBrush(this.m_gridBGColor), rect1);
      if (this.m_showTitleTop)
      {
        PointF pointF = new PointF((float) ((double) rect1.Left + (double) rect1.Width * 0.5 - (double) sizeF1.Width * 0.5), 5f);
        Function.DrawString(ref graphics, this.m_titleTop, this.m_titleFontTop, this.m_titleColorTop, pointF);
      }
      if (this.m_showLegendY)
      {
        StringFormat format = new StringFormat();
        format.FormatFlags = StringFormatFlags.DirectionVertical;
        PointF point = new PointF(5f, (float) ((double) rect1.Top + (double) rect1.Height * 0.5 - (double) sizeF3.Width * 0.5));
        graphics.DrawString(this.m_legendY, this.m_legendYFont, (Brush) new SolidBrush(this.m_legendYColor), point, format);
      }
      if (this.m_showLegendX)
      {
        PointF pointF = new PointF((float) ((double) rect1.Left + (double) rect1.Width * 0.5 - (double) sizeF2.Width * 0.5), (float) this.Height - sizeF2.Height);
        Function.DrawString(ref graphics, this.m_legendX, this.m_legendXFont, this.m_legendXColor, pointF);
      }
      if (this.m_BGImage != null)
      {
        Rectangle destRect = new Rectangle();
        int num10 = (double) this.m_BGImage.Width < (double) rect1.Width ? (int) (double) this.m_BGImage.Width : (int) ((double) rect1.Width - 20.0);
        int num11 = (double) this.m_BGImage.Height < (double) rect1.Height ? (int) (double) this.m_BGImage.Height : (int) ((double) rect1.Height - 20.0);
        destRect.Width = num10;
        destRect.Height = num11;
        destRect.X = (int) ((double) rect1.Left + (double) rect1.Width * 0.5 - (double) (num10 / 2));
        destRect.Y = (int) ((double) rect1.Top + (double) rect1.Height * 0.5 - (double) (num11 / 2));
        graphics.DrawImage(this.m_BGImage, destRect, 0, 0, this.m_BGImage.Width, this.m_BGImage.Height, GraphicsUnit.Pixel, this.m_BGImageAttributes);
      }
      float num12 = rect1.Height / 4f;
      this.m_gridPen.DashStyle = this.m_gridDashStyle;
      int num13 = 5;
      PointF pointF1 = new PointF();
      PointF pt2_1 = new PointF();
      PointF pt1_1 = new PointF();
      pointF1.Y = rect1.Top;
      pointF1.X = rect1.Left;
      pt2_1.X = rect1.Right;
      pt1_1.X = rect1.Left - 5f;
      for (int index = 1; index <= 5; ++index)
      {
        pt2_1.Y = pointF1.Y;
        pt1_1.Y = pointF1.Y;
        if (this.m_ShowGridY && index == 1)
          graphics.DrawLine(this.m_gridPen, pointF1, pt2_1);
        graphics.DrawLine(this.m_gridLinePen, pt1_1, pointF1);
        SizeF sizeF7 = graphics.MeasureString(num13.ToString(), this.m_stepValueYFont);
        PointF pointF2 = new PointF((float) ((double) rect1.Left - (double) sizeF7.Width - 5.0), pointF1.Y - sizeF7.Height * 0.5f);
        Function.DrawString(ref graphics, num13.ToString(), this.m_stepValueYFont, this.m_stepColorValueY, pointF2);
        pointF1.Y += num12;
        --num13;
      }
      float num14 = rect1.Width / (float) this.m_barCount;
      float num15 = 0.0f;
      graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left, rect1.Bottom), new PointF(rect1.Left, rect1.Bottom + 5f));
      for (int index1 = 0; index1 < this.m_itemsChart.Count; ++index1)
      {
        float y1 = rect1.Bottom - (this.m_itemsChart[index1].Value * num12 - num12);
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left + num14 * num15, rect1.Bottom), new PointF(rect1.Left + num14 * num15, rect1.Top));
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left + num14 * num15 + num14, rect1.Bottom), new PointF(rect1.Left + num14 * num15 + num14, rect1.Top));
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Left + num14 * num15 + num14, rect1.Bottom), new PointF(rect1.Left + num14 * num15 + num14, rect1.Bottom + 5f));
        ++num15;
        PointF pt1_2 = new PointF(rect1.Left + (float) ((double) num14 * (double) num15 - (double) num14 * 0.5), y1);
        if (index1 < this.m_itemsChart.Count - 1)
        {
          int index2 = index1 + 1;
          float y2 = rect1.Bottom - (this.m_itemsChart[index2].Value * num12 - num12);
          PointF pt2_2 = new PointF(rect1.Left + (float) ((double) num14 * ((double) num15 + 1.0) - (double) num14 * 0.5), y2);
          graphics.DrawLine(new Pen(Color.Navy), pt1_2, pt2_2);
        }
        Point point = new Point((int) pt1_2.X, (int) pt1_2.Y);
        Point[] points = new Point[4];
        points[0] = point;
        points[0].Offset(0, 3);
        points[1] = point;
        points[1].Offset(3, 0);
        points[2] = point;
        points[2].Offset(0, -3);
        points[3] = point;
        points[3].Offset(-3, 0);
        graphics.FillPolygon((Brush) new SolidBrush(Color.Navy), points);
        graphics.DrawPolygon(new Pen(Color.Navy), points);
        SizeF sizeF8 = graphics.MeasureString(this.m_itemsChart[index1].Value.ToString("n2"), this.m_barValueFont);
        PointF pointF3 = new PointF(pt1_2.X - sizeF8.Width * 0.5f, pt1_2.Y - (sizeF8.Height + 3f));
        if (this.m_showHighlightValue)
        {
          RectangleF rectangleF = new RectangleF();
          rectangleF.Width = sizeF8.Width + sizeF8.Width * 0.2f;
          rectangleF.Height = sizeF8.Height - 2f;
          rectangleF.X = pointF3.X - sizeF8.Width * 0.1f;
          rectangleF.Y = pointF3.Y;
          graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
          graphics.DrawRectangle(new Pen(Color.Black), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
        }
        graphics.DrawString(this.m_itemsChart[index1].Value.ToString("n2"), this.m_barValueFont, (Brush) new SolidBrush(this.m_barLabelColor), pointF3);
        SizeF sizeF9 = graphics.MeasureString(this.m_itemsChart[index1].Label, this.m_stepValueYFont);
        List<string> stringArray = Function.GetStringArray(this.m_itemsChart[index1].Label, 17);
        pointF3 = new PointF(pt1_2.X - sizeF9.Height * (float) stringArray.Count, rect1.Bottom + 6f);
        if (stringArray.Count > 1)
        {
          for (int index3 = 0; index3 < stringArray.Count; ++index3)
          {
            SizeF sizeF10 = graphics.MeasureString(stringArray[index3], this.m_stepValueYFont);
            pointF3.Y = (float) ((double) rect1.Bottom + 2.0 + ((double) this.Height - (double) rect1.Bottom + 2.0) / 2.0 - (double) sizeF10.Width * 0.5);
            Function.DrawString(ref graphics, stringArray[index3], this.m_stepValueYFont, this.m_barLabelColor, -90, pointF3);
            pointF3.X += sizeF9.Height;
          }
        }
        else
          Function.DrawString(ref graphics, this.m_itemsChart[index1].Label, this.m_stepValueYFont, this.m_barLabelColor, -90, pointF3);
      }
      graphics.DrawLine(this.m_gridPen, new PointF(rect1.Right, rect1.Bottom), new PointF(rect1.Right, rect1.Top - 1f));
      graphics.DrawLine(this.m_gridPen, new PointF(rect1.Right, rect1.Bottom), new PointF(rect1.Right, rect1.Top - 1f));
      Pen pen = new Pen(this.m_gridLineColor, 1f);
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pt2_1.X, rect1.Bottom));
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom + 1f), new PointF(pt2_1.X, rect1.Bottom + 1f));
      graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pointF1.X, rect1.Top));
      graphics.DrawLine(pen, new PointF(pointF1.X + 1f, rect1.Bottom), new PointF(pointF1.X + 1f, rect1.Top));
    }
    catch (Exception ex)
    {
      graphics.Clear(Color.White);
      Function.DrawString(ref graphics, ex.Message + Environment.NewLine + ex.StackTrace, this.m_stepValueYFont, Color.Red, new PointF(0.0f, 0.0f));
    }
  }

  protected override void OnMouseMove(MouseEventArgs e) => base.OnMouseMove(e);

  private void ControlPicture_Resize(object sender, EventArgs e)
  {
  }

  protected override void OnMouseClick(MouseEventArgs e) => base.OnMouseClick(e);

  protected override void OnMouseDoubleClick(MouseEventArgs e) => base.OnMouseDoubleClick(e);

  private void ChartBarAcertividade_DoubleClick(object sender, EventArgs e)
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

  public struct ItemsChartNivel
  {
    public string Label;
    public float Value;
  }
}
