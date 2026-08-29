// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.ChartBarResposta
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

[ToolboxBitmap("D:\\Visual Studio 2005\\Projects\\LDChartControlPlus\\Resources\\ChartBar.bmp")]
public class ChartBarResposta : UserControl
{
  private List<ItemsChart> m_itemsChart;
  private List<Color> m_colorsBar;
  private float m_maxValue;
  private int m_barCount;
  private float m_itemsTotalValue;
  private string m_titleTop;
  private bool m_showTitleTop;
  private Font m_titleFontTop;
  private Color m_titleColorTop;
  private Color m_BGColor1;
  private Color m_BGColor2;
  private Image m_BGImage;
  private int m_colorMatrix;
  private ChartStyle m_ChartStyle;
  private ImageAttributes m_BGImageAttributes;
  private LinearGradientMode m_BGLinearGradientMode;
  private bool m_showTotalValue;
  private Color m_gridLineColor;
  private Pen m_gridLinePen;
  private Color m_gridColor;
  private DashStyle m_gridDashStyle;
  private Pen m_gridPen;
  private Color m_gridBGColor;
  private bool m_barGradientColor;
  private LinearGradientMode m_barLinearGradientMode;
  private bool m_colorsBarRandom;
  private bool m_showHighlightValue;
  private bool m_showPercentValue;
  private int m_rotateLabelValue;
  private Font m_barLabelFont;
  private Font m_barValueFont;
  private Color m_barLabelColor;
  private string m_legendY;
  private bool m_showLegendY;
  private Font m_legendYFont;
  private Color m_legendYColor;
  private int m_maxStepValueY;
  private int m_stepValueY;
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
  private IContainer components;
  private ToolTip toolTip1;

  public ChartBarResposta()
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
    this.m_stepValueY = 1;
    this.m_maxStepValueY = 5;
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
    this.m_maxValue = 0.0f;
    this.m_barCount = 0;
    this.m_colorsBarRandom = true;
    this.m_ChartStyle = ChartStyle.StyleNormal;
    this.m_showTotalValue = false;
    this.m_gridColor = Color.DarkGray;
    this.m_gridDashStyle = DashStyle.Dot;
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
    this.m_itemsTotalValue = 0.0f;
    this.m_showPercentValue = true;
    this.m_showHighlightValue = true;
    this.m_barGradientColor = true;
    this.m_barLinearGradientMode = LinearGradientMode.Horizontal;
    this.m_barLabelFont = new Font("Tahoma", 8f, FontStyle.Regular);
    this.m_barLabelColor = Color.Navy;
    this.m_barValueFont = new Font("Tahoma", 8f, FontStyle.Bold);
    this.m_itemsChart = new List<ItemsChart>();
    this.m_colorsBar = new List<Color>();
    this.m_colorsBar.Add(Color.DimGray);
    this.m_colorsBar.Add(Color.Teal);
    this.m_colorsBar.Add(Color.Maroon);
    this.m_colorsBar.Add(Color.SkyBlue);
    this.m_colorsBar.Add(Color.Red);
    this.m_colorsBar.Add(Color.SteelBlue);
    this.m_colorsBar.Add(Color.LightCoral);
    this.m_colorsBar.Add(Color.SlateGray);
    this.m_colorsBar.Add(Color.MistyRose);
    this.m_colorsBar.Add(Color.RoyalBlue);
    this.m_colorsBar.Add(Color.Chocolate);
    this.m_colorsBar.Add(Color.Tan);
    this.m_colorsBar.Add(Color.Navy);
    this.m_colorsBar.Add(Color.Orange);
    this.m_colorsBar.Add(Color.SlateBlue);
    this.m_colorsBar.Add(Color.Olive);
    this.m_colorsBar.Add(Color.Indigo);
    this.m_colorsBar.Add(Color.OliveDrab);
    this.m_colorsBar.Add(Color.Purple);
    this.m_colorsBar.Add(Color.ForestGreen);
    this.m_colorsBar.Add(Color.Crimson);
    this.m_colorsBar.Add(Color.Green);
    for (int green = 0; green < 50; ++green)
      this.m_colorsBar.Add(Color.FromArgb((int) byte.MaxValue, green, 200));
    List<ItemsChart> lstItemsChart = new List<ItemsChart>();
    string[] strArray = new string[4]
    {
      "VALOR 1 COM MAIS DOIS SAO TRES",
      "VALOR 2",
      "VALOR 3",
      "VALOR 4"
    };
    float[] numArray = new float[4]{ 1f, 3.5f, 4f, 5f };
    for (int index = 0; index < strArray.Length; ++index)
      lstItemsChart.Add(new ItemsChart()
      {
        Color = Color.Blue,
        Label = strArray[index],
        Value = numArray[index]
      });
    this.AddItems(lstItemsChart);
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

  [Category("Grid")]
  [Description("Define o estilo da linha do grid.")]
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

  [Description("Define a cor da barra aletatoriamente.")]
  [Category("Bar")]
  public bool ColorBarRandom
  {
    get => this.m_colorsBarRandom;
    set
    {
      this.m_colorsBarRandom = value;
      this.Invalidate();
    }
  }

  [Description("Direção da Cor de fundo gradiente.")]
  [Category("Bar")]
  public LinearGradientMode BarLinearGradientMode
  {
    get => this.m_barLinearGradientMode;
    set
    {
      this.m_barLinearGradientMode = value;
      this.Invalidate();
    }
  }

  [Description("Se deseja a Cor de fundo gradiente ou não.")]
  [Category("Bar")]
  public bool BarGradientColor
  {
    get => this.m_barGradientColor;
    set
    {
      this.m_barGradientColor = value;
      this.Invalidate();
    }
  }

  [Description("Destaca o valor no topo da barra ou não.")]
  [Category("Bar")]
  public bool ShowHighlightValue
  {
    get => this.m_showHighlightValue;
    set
    {
      this.m_showHighlightValue = value;
      this.Invalidate();
    }
  }

  [Description("Fonte do Label da barra.")]
  [Category("Bar")]
  public Font BarLabelFont
  {
    get => this.m_barLabelFont;
    set
    {
      this.m_barLabelFont = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Fonte do valor da barra.")]
  public Font BarValueFont
  {
    get => this.m_barValueFont;
    set
    {
      this.m_barValueFont = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Cor da Fonte do Label da barra.")]
  public Color BarLabelColor
  {
    get => this.m_barLabelColor;
    set
    {
      this.m_barLabelColor = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Mostra o valor em porcentagem no topo da barra.")]
  public bool ShowPercentValue
  {
    get => this.m_showPercentValue;
    set
    {
      this.m_showPercentValue = value;
      this.Invalidate();
    }
  }

  [Category("Bar")]
  [Description("Define o valor que o texto do valor da barra deve rotacionar.")]
  public int RotateLabelValue
  {
    get => this.m_rotateLabelValue;
    set
    {
      this.m_rotateLabelValue = value;
      this.Invalidate();
    }
  }

  [Description("Cor de fundo 1")]
  [Category("Chart")]
  public Color BGColor1
  {
    get => this.m_BGColor1;
    set
    {
      this.m_BGColor1 = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Cor de fundo 2")]
  public Color BGColor2
  {
    get => this.m_BGColor2;
    set
    {
      this.m_BGColor2 = value;
      this.Invalidate();
    }
  }

  [Description("Direção da Cor de fundo gradiente.")]
  [Category("Chart")]
  public LinearGradientMode BGLinearGradientMode
  {
    get => this.m_BGLinearGradientMode;
    set
    {
      this.m_BGLinearGradientMode = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o texto do título.")]
  [Category("Chart")]
  public string Title
  {
    get => this.m_titleTop;
    set
    {
      this.m_titleTop = value;
      this.Invalidate();
    }
  }

  [Category("Chart")]
  [Description("Define se dever mostrar o título.")]
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

  [Category("Chart")]
  [Description("Image de fundo")]
  public Image BGImage
  {
    get => this.m_BGImage;
    set
    {
      this.m_BGImage = value;
      this.Invalidate();
    }
  }

  [Description("Valor da tranparência da imagem de fundo.")]
  [Category("Chart")]
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

  [Category("Chart")]
  [Description("Valor da tranparência da imagem de fundo.")]
  public ChartStyle ChartStyle
  {
    get => this.m_ChartStyle;
    set
    {
      this.m_ChartStyle = value;
      this.Invalidate();
    }
  }

  [Description("Mostra o valor total.")]
  [Category("Chart")]
  public bool ShowTotalValue
  {
    get => this.m_showTotalValue;
    set
    {
      this.m_showTotalValue = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o legenda do eixo Y.")]
  [Category("Eixo Y")]
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

  [Description("Define/resgata a fonte da legenda do eixo Y.")]
  [Category("Eixo Y")]
  public Font LegendYFont
  {
    get => this.m_legendYFont;
    set
    {
      this.m_legendYFont = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata a Cor da legenda do eixo Y.")]
  [Category("Eixo Y")]
  public Color LegendYColor
  {
    get => this.m_legendYColor;
    set
    {
      this.m_legendYColor = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata o valor máximo do eixo Y.")]
  public int MaxValueY
  {
    get => this.m_maxStepValueY;
    set
    {
      this.m_maxStepValueY = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o step value do eixo Y.")]
  [Category("Eixo Y")]
  public int StepValueY
  {
    get => this.m_stepValueY;
    set
    {
      this.m_stepValueY = value;
      this.Invalidate();
    }
  }

  [Category("Eixo Y")]
  [Description("Define/resgata a Cor do step value do eixo Y.")]
  public Color StepColorValueY
  {
    get => this.m_stepColorValueY;
    set
    {
      this.m_stepColorValueY = value;
      this.Invalidate();
    }
  }

  [Description("Define/resgata o legenda do eixo X.")]
  [Category("Eixo X")]
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

  [Description("Define/resgata a Cor da legenda do eixo X.")]
  [Category("Eixo X")]
  public Color LegendXColor
  {
    get => this.m_legendXColor;
    set
    {
      this.m_legendXColor = value;
      this.Invalidate();
    }
  }

  [Description("Quantidade máxima de caracteres do label do eixo X.")]
  [Category("Eixo X")]
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
  [Description("Direção do label do eixo X.")]
  [DefaultValue(DirectionLabel.Horizontal)]
  public DirectionLabel LabelXDirection
  {
    get => this.m_labelXDirection;
    set
    {
      this.m_labelXDirection = value;
      this.Invalidate();
    }
  }

  [Description("Direção do label do eixo X.")]
  [DefaultValue(RotateFlipType.RotateNoneFlipNone)]
  [Category("Eixo X")]
  public RotateFlipType RotacaoLegenda
  {
    get => this.m_rotateFlipType;
    set
    {
      this.m_rotateFlipType = value;
      this.Invalidate();
    }
  }

  public void AddItems(List<ItemsChart> lstItemsChart)
  {
    this.ClearItems();
    if (lstItemsChart == null)
      return;
    this.m_itemsChart = lstItemsChart;
    for (int index = this.m_itemsChart.Count - 1; index >= 0; --index)
    {
      if ((double) this.m_itemsChart[index].Value <= 0.0)
        this.m_itemsChart.RemoveAt(index);
      else if ((double) this.m_itemsChart[index].Value > (double) this.m_maxValue)
        this.m_maxValue = this.m_itemsChart[index].Value;
      this.m_itemsTotalValue += this.m_itemsChart[index].Value;
    }
    this.m_barCount = this.m_itemsChart.Count;
    if ((double) this.m_maxValue < 1000.0)
    {
      long num1 = (long) ((int) this.m_maxValue % 100);
      long num2 = (long) ((int) this.m_maxValue / 100);
      if (num1 > 0L)
        ++num2;
      this.m_maxStepValueY = (int) num2 * 100;
    }
    else
    {
      long num3 = (long) ((int) this.m_maxValue % 1000);
      long num4 = (long) ((int) this.m_maxValue / 1000);
      if (num3 > 0L)
        ++num4;
      this.m_maxStepValueY = (int) num4 * 1000;
    }
    this.m_stepValueY = this.m_maxStepValueY / 10;
    this.Invalidate();
  }

  public void ClearItems()
  {
    this.m_itemsChart.Clear();
    this.m_maxValue = 0.0f;
    this.m_itemsTotalValue = 0.0f;
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
    float num2 = 10f;
    float num3 = 40f;
    float num4 = 20f;
    RectangleF rect1 = new RectangleF();
    SizeF sizeF1 = new SizeF(0.0f, 0.0f);
    SizeF sizeF2 = new SizeF(0.0f, 0.0f);
    SizeF sizeF3 = new SizeF(0.0f, 0.0f);
    SizeF sizeF4 = new SizeF(0.0f, 0.0f);
    using (Graphics graphics = e.Graphics)
    {
      try
      {
        if (this.m_maxStepValueY <= 0)
        {
          this.m_maxStepValueY = 5;
          this.m_stepValueY = 1;
        }
        graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
        graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        if (this.m_showTitleTop)
          sizeF1 = graphics.MeasureString(this.m_titleTop, this.m_titleFontTop);
        if (this.m_showLegendY)
          sizeF3 = graphics.MeasureString(this.m_legendY, this.m_legendYFont);
        if (this.m_showLegendX)
          sizeF2 = graphics.MeasureString(this.m_legendX, this.m_legendXFont);
        SizeF sizeF5 = graphics.MeasureString("TESTE", this.m_barLabelFont);
        SizeF sizeF6 = graphics.MeasureString(this.m_maxStepValueY.ToString(), this.m_stepValueYFont);
        float num5 = num3 + sizeF1.Height;
        float num6 = num1 + (float) ((double) sizeF3.Height + (double) sizeF6.Width + 5.0);
        float num7 = num4 + (sizeF2.Height + sizeF5.Height);
        int num8 = this.m_maxStepValueY / this.m_stepValueY;
        float num9 = ((float) this.Height - (num5 + num7)) / (float) (num8 - 1);
        rect1.X = num6;
        rect1.Y = num5;
        rect1.Width = (float) this.Width - (num6 + num2);
        rect1.Height = num9 * (float) (num8 - 1);
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
        this.m_gridPen.DashStyle = this.m_gridDashStyle;
        PointF pointF1 = new PointF();
        PointF pt2 = new PointF();
        PointF pt1 = new PointF();
        pointF1.Y = rect1.Bottom;
        pointF1.X = rect1.Left;
        pt2.X = rect1.Right;
        pt1.X = rect1.Left - 5f;
        for (int index = 1; index <= num8; ++index)
        {
          pt2.Y = pointF1.Y;
          pt1.Y = pointF1.Y;
          if (this.m_ShowGridY)
            graphics.DrawLine(this.m_gridPen, pointF1, pt2);
          graphics.DrawLine(this.m_gridLinePen, pt1, pointF1);
          int num12 = index;
          SizeF sizeF7 = graphics.MeasureString(num12.ToString(), this.m_stepValueYFont);
          PointF pointF2 = new PointF((float) ((double) rect1.Left - (double) sizeF7.Width - 5.0), pointF1.Y - sizeF7.Height * 0.5f);
          Function.DrawString(ref graphics, num12.ToString(), this.m_stepValueYFont, this.m_stepColorValueY, pointF2);
          pointF1.Y -= num9;
        }
        float num13 = num9;
        float num14 = (float) ((double) rect1.Width / (double) this.m_barCount * 0.5);
        float num15 = 0.0f;
        for (int index1 = 0; index1 < this.m_itemsChart.Count; ++index1)
        {
          Color color = this.m_itemsChart[index1].Color;
          float num16 = this.m_itemsChart[index1].Value;
          float num17 = rect1.Bottom - num16 * num13;
          if (this.m_colorsBarRandom)
            color = this.m_colorsBar[index1];
          if (this.m_ShowGridX)
          {
            graphics.DrawLine(this.m_gridPen, new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5), rect1.Bottom), new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5), rect1.Top));
            graphics.DrawLine(this.m_gridPen, new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5) + num14, rect1.Bottom), new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5) + num14, rect1.Top));
          }
          RectangleF rect3 = new RectangleF();
          rect3.Width = num14;
          rect3.Height = num16 * (num13 - 1f);
          rect3.X = (float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5);
          rect3.Y = num17;
          if (this.m_barGradientColor)
          {
            Color baseColor1 = RGBHSL.SetBrightness(color, 0.7);
            Color baseColor2 = RGBHSL.SetBrightness(color, 0.3);
            using (GraphicsPath path = new GraphicsPath())
            {
              path.AddRectangle(rect3);
              PathGradientBrush pathGradientBrush = new PathGradientBrush(path);
              pathGradientBrush.CenterColor = Color.FromArgb((int) byte.MaxValue, baseColor1);
              pathGradientBrush.CenterPoint = new PointF(rect3.X + rect3.Width * 0.5f, 0.0f);
              Color[] colorArray = new Color[1]
              {
                Color.FromArgb((int) byte.MaxValue, baseColor2)
              };
              pathGradientBrush.SurroundColors = colorArray;
              pathGradientBrush.FocusScales = new PointF(1f / 1000f, 1f);
              graphics.FillRectangle((Brush) pathGradientBrush, rect3);
            }
          }
          else
            graphics.FillRectangle((Brush) new SolidBrush(color), rect3);
          graphics.DrawRectangle(new Pen(Color.Black, 1f), rect3.X, rect3.Y, rect3.Width, rect3.Height);
          SizeF sizeF8 = graphics.MeasureString(num16.ToString("#.##"), this.m_barValueFont);
          PointF pointF3 = new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5 + (double) num14 * 0.5 - (double) sizeF8.Width * 0.5), num17 - sizeF8.Height * 1.2f);
          if (this.m_showHighlightValue)
          {
            RectangleF rectangleF = new RectangleF();
            rectangleF.Width = sizeF8.Width + sizeF8.Width * 0.2f;
            rectangleF.Height = sizeF8.Height - 2f;
            rectangleF.X = pointF3.X - sizeF8.Width * 0.1f;
            rectangleF.Y = pointF3.Y;
            graphics.FillRectangle((Brush) new SolidBrush(Color.Ivory), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
            graphics.DrawRectangle(new Pen(Color.Black), rectangleF.X, rectangleF.Y, rectangleF.Width, rectangleF.Height);
            graphics.DrawLine(new Pen(Color.Black), rect3.X + rect3.Width * 0.5f, rect3.Y, rect3.X + rect3.Width * 0.5f, pointF3.Y + (sizeF8.Height - 2f));
          }
          graphics.DrawString(num16.ToString("#.##"), this.m_barValueFont, (Brush) new SolidBrush(Color.Navy), pointF3);
          if (this.m_showPercentValue)
          {
            string percentage = this.GetPercentage(num16, this.m_itemsTotalValue, 2);
            SizeF sizeF9 = graphics.MeasureString(percentage + "%", this.m_barValueFont);
            PointF point = new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5 + (double) num14 * 0.5 - (double) sizeF9.Width * 0.40000000596046448), num17 - sizeF9.Height * 2.3f);
            graphics.DrawString(percentage + "%", this.m_barValueFont, (Brush) new SolidBrush(Color.Navy), point);
          }
          if (this.m_itemsChart[index1].Label.Length > this.m_maxCountCharLineLabelX)
          {
            List<string> stringList = new List<string>();
            string[] strArray = this.m_itemsChart[index1].Label.Split(' ');
            for (int index2 = 0; index2 < strArray.Length; ++index2)
            {
              if (stringList.Count > 0)
              {
                int index3 = stringList.Count - 1;
                if (strArray[index2].Length + stringList[index3].Length < this.m_maxCountCharLineLabelX)
                  stringList[index3] = $"{stringList[index3]} {strArray[index2]}";
                else
                  stringList.Add(strArray[index2]);
              }
              else
                stringList.Add(strArray[index2]);
            }
            for (int index4 = 0; index4 < stringList.Count; ++index4)
            {
              SizeF sizeF10 = graphics.MeasureString(stringList[index4], this.m_barLabelFont);
              pointF3 = new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5 + (double) num14 * 0.5 - (double) sizeF10.Width * 0.5), (float) ((double) rect1.Bottom + 5.0 + (double) sizeF10.Height * (double) index4));
              graphics.DrawString(stringList[index4], this.m_barLabelFont, (Brush) new SolidBrush(this.m_barLabelColor), pointF3);
            }
          }
          else if (this.m_labelXDirection == DirectionLabel.Horizontal)
          {
            SizeF sizeF11 = graphics.MeasureString(this.m_itemsChart[index1].Label, this.m_barLabelFont);
            pointF3 = new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + (double) num14 * 0.5 + (double) num14 * 0.5 - (double) sizeF11.Width * 0.5), rect1.Bottom + 5f);
            graphics.DrawString(this.m_itemsChart[index1].Label, this.m_barLabelFont, (Brush) new SolidBrush(this.m_barLabelColor), pointF3);
          }
          else
          {
            SizeF sizeF12 = graphics.MeasureString(this.m_itemsChart[index1].Label, this.m_barLabelFont);
            pointF3 = new PointF((float) ((double) rect1.Left + (double) num14 * (double) num15 + 10.0 + (double) num14 / 2.0 - (double) sizeF12.Height / 2.0), num7 + sizeF12.Height);
            Function.DrawString(ref graphics, this.m_itemsChart[index1].Label, this.m_barLabelFont, this.m_barLabelColor, pointF3);
          }
          num15 += 2f;
        }
        graphics.DrawLine(this.m_gridPen, new PointF(rect1.Right, rect1.Bottom), new PointF(rect1.Right, rect1.Top - 1f));
        Pen pen = new Pen(this.m_gridLineColor, 1f);
        graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom + 1f), new PointF(pt2.X, rect1.Bottom + 1f));
        graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pt2.X, rect1.Bottom));
        graphics.DrawLine(pen, new PointF(pointF1.X, rect1.Bottom), new PointF(pointF1.X, rect1.Top));
        graphics.DrawLine(pen, new PointF(pointF1.X + 1f, rect1.Bottom), new PointF(pointF1.X + 1f, rect1.Top));
      }
      catch (Exception ex)
      {
        int num18 = (int) MessageBox.Show($"Erro: {ex.Message}\n\nStackTrace: {ex.StackTrace}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        throw ex;
      }
    }
  }

  protected override void OnMouseMove(MouseEventArgs e) => base.OnMouseMove(e);

  private void ControlPicture_Resize(object sender, EventArgs e) => this.Invalidate();

  protected override void OnMouseClick(MouseEventArgs e) => base.OnMouseClick(e);

  public string GetPercentage(float value, float total, int places)
  {
    try
    {
      string empty = string.Empty;
      string str = new string('0', places);
      if ((double) value < 0.0)
        value = 0.0f;
      if ((double) total < 0.0)
        total = 0.0f;
      Decimal num;
      if ((double) value == 0.0 || (double) total == 0.0)
      {
        num = 0M;
      }
      else
      {
        num = Decimal.Divide((Decimal) value, (Decimal) total) * 100M;
        if (num > 0M && places > 0)
          str = "0." + str;
      }
      return num.ToString("#" + str);
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }

  private void ChartBar_DoubleClick(object sender, EventArgs e)
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
    this.Name = "ChartBar";
    this.Size = new Size(362, 236);
    this.DoubleClick += new EventHandler(this.ChartBar_DoubleClick);
    this.ResumeLayout(false);
  }
}
