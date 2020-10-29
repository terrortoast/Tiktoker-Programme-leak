// Decompiled with JetBrains decompiler
// Type: DxLauncher.Properties.Resources
// Assembly: DxLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0C43FB74-0009-4DFC-9E5F-74A202E50751
// Assembly location: F:\Users\abtro\Desktop\Adobe Launcher - DxNetwork.exe.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DxLauncher.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (DxLauncher.Properties.Resources.resourceMan == null)
          DxLauncher.Properties.Resources.resourceMan = new ResourceManager("DxLauncher.Properties.Resources", typeof (DxLauncher.Properties.Resources).Assembly);
        return DxLauncher.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => DxLauncher.Properties.Resources.resourceCulture;
      set => DxLauncher.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap discord_profilbild => (Bitmap) DxLauncher.Properties.Resources.ResourceManager.GetObject("discord profilbild", DxLauncher.Properties.Resources.resourceCulture);

    internal static Bitmap drip_bild => (Bitmap) DxLauncher.Properties.Resources.ResourceManager.GetObject(nameof (drip_bild), DxLauncher.Properties.Resources.resourceCulture);
  }
}
