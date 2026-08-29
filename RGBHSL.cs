// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.RGBHSL
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System.Drawing;

#nullable disable
namespace LDChartControlPlus;

public class RGBHSL
{
  public static Color SetBrightness(Color c, double brightness)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.L = brightness;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color ModifyBrightness(Color c, double brightness)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.L *= brightness;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color SetSaturation(Color c, double Saturation)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.S = Saturation;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color ModifySaturation(Color c, double Saturation)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.S *= Saturation;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color SetHue(Color c, double Hue)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.H = Hue;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color ModifyHue(Color c, double Hue)
  {
    RGBHSL.HSL hsl = RGBHSL.RGB_to_HSL(c);
    hsl.H *= Hue;
    return RGBHSL.HSL_to_RGB(hsl);
  }

  public static Color HSL_to_RGB(RGBHSL.HSL hsl)
  {
    double num1;
    double num2;
    double num3;
    if (hsl.L == 0.0)
    {
      double num4;
      num1 = num4 = 0.0;
      num2 = num4;
      num3 = num4;
    }
    else if (hsl.S == 0.0)
    {
      double l;
      num1 = l = hsl.L;
      num2 = l;
      num3 = l;
    }
    else
    {
      double num5 = hsl.L <= 0.5 ? hsl.L * (1.0 + hsl.S) : hsl.L + hsl.S - hsl.L * hsl.S;
      double num6 = 2.0 * hsl.L - num5;
      double[] numArray1 = new double[3]
      {
        hsl.H + 1.0 / 3.0,
        hsl.H,
        hsl.H - 1.0 / 3.0
      };
      double[] numArray2 = new double[3];
      for (int index = 0; index < 3; ++index)
      {
        if (numArray1[index] < 0.0)
          ++numArray1[index];
        if (numArray1[index] > 1.0)
          --numArray1[index];
        numArray2[index] = 6.0 * numArray1[index] >= 1.0 ? (2.0 * numArray1[index] >= 1.0 ? (3.0 * numArray1[index] >= 2.0 ? num6 : num6 + (num5 - num6) * (2.0 / 3.0 - numArray1[index]) * 6.0) : num5) : num6 + (num5 - num6) * numArray1[index] * 6.0;
      }
      num3 = numArray2[0];
      num2 = numArray2[1];
      num1 = numArray2[2];
    }
    return Color.FromArgb((int) ((double) byte.MaxValue * num3), (int) ((double) byte.MaxValue * num2), (int) ((double) byte.MaxValue * num1));
  }

  public static RGBHSL.HSL RGB_to_HSL(Color c)
  {
    return new RGBHSL.HSL()
    {
      H = (double) c.GetHue() / 360.0,
      L = (double) c.GetBrightness(),
      S = (double) c.GetSaturation()
    };
  }

  public class HSL
  {
    private double _h;
    private double _s;
    private double _l;

    public HSL()
    {
      this._h = 0.0;
      this._s = 0.0;
      this._l = 0.0;
    }

    public double H
    {
      get => this._h;
      set
      {
        this._h = value;
        this._h = this._h > 1.0 ? 1.0 : (this._h < 0.0 ? 0.0 : this._h);
      }
    }

    public double S
    {
      get => this._s;
      set
      {
        this._s = value;
        this._s = this._s > 1.0 ? 1.0 : (this._s < 0.0 ? 0.0 : this._s);
      }
    }

    public double L
    {
      get => this._l;
      set
      {
        this._l = value;
        this._l = this._l > 1.0 ? 1.0 : (this._l < 0.0 ? 0.0 : this._l);
      }
    }
  }
}
