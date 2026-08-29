// Decompiled with JetBrains decompiler
// Type: LDChartControlPlus.Utilitarios
// Assembly: LDChartControlPlus, Version=1.0.3873.26967, Culture=neutral, PublicKeyToken=null
// MVID: B87EBCC8-B602-40E5-94CA-0C821CC4B7FA
// Assembly location: G:\Projetos\GITEA\LDChartControlPlus\LDChartControlPlus.dll

using System;
using System.Drawing;
using System.Runtime.InteropServices;

#nullable disable
namespace LDChartControlPlus;

public class Utilitarios
{
  [DllImport("gdi32.dll")]
  private static extern bool BitBlt(
    IntPtr hdcDest,
    int nXDest,
    int nYDest,
    int nWidth,
    int nHeight,
    IntPtr hdcSrc,
    int nXSrc,
    int nYSrc,
    int dwRop);

  [DllImport("User32.dll")]
  private static extern IntPtr GetDC(IntPtr hWnd);

  [DllImport("User32.dll")]
  private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

  public static Bitmap GetImage(IntPtr hWnd, int width, int height)
  {
    try
    {
      IntPtr dc = Utilitarios.GetDC(hWnd);
      Bitmap image = new Bitmap(width, height);
      Graphics graphics = Graphics.FromImage((Image) image);
      IntPtr hdc = graphics.GetHdc();
      Utilitarios.BitBlt(hdc, 0, 0, width, height, dc, 0, 0, 13369376);
      Utilitarios.ReleaseDC(IntPtr.Zero, dc);
      graphics.ReleaseHdc(hdc);
      graphics.Dispose();
      return image;
    }
    catch (Exception ex)
    {
      throw ex;
    }
  }
}
