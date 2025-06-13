using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000495 RID: 1173
	[System.Serializable]
	public class GraphicsSettings : Il2CppSystem.Object
	{
		// Token: 0x06006452 RID: 25682 RVA: 0x001C9EA4 File Offset: 0x001C80A4
		// Note: this type is marked as 'beforefieldinit'.
		static GraphicsSettings()
		{
			Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "GraphicsSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr);
			GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GraphicsQuality");
			GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "AntiAliasingMode");
			GraphicsSettings.NativeFieldInfoPtr_FOV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "FOV");
			GraphicsSettings.NativeFieldInfoPtr_SSAO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "SSAO");
			GraphicsSettings.NativeFieldInfoPtr_GodRays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, "GodRays");
			GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr, 100676115);
		}

		// Token: 0x06006453 RID: 25683 RVA: 0x001C9F4C File Offset: 0x001C814C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GraphicsSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphicsSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GraphicsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006454 RID: 25684 RVA: 0x0002F2EF File Offset: 0x0002D4EF
		public GraphicsSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DF7 RID: 7671
		// (get) Token: 0x06006455 RID: 25685 RVA: 0x001C9F88 File Offset: 0x001C8188
		// (set) Token: 0x06006456 RID: 25686 RVA: 0x0002F2F8 File Offset: 0x0002D4F8
		public unsafe GraphicsSettings.EGraphicsQuality GraphicsQuality
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GraphicsQuality)) = value;
			}
		}

		// Token: 0x17001DF8 RID: 7672
		// (get) Token: 0x06006457 RID: 25687 RVA: 0x001C9FB0 File Offset: 0x001C81B0
		// (set) Token: 0x06006458 RID: 25688 RVA: 0x0002F313 File Offset: 0x0002D513
		public unsafe GraphicsSettings.EAntiAliasingMode AntiAliasingMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_AntiAliasingMode)) = value;
			}
		}

		// Token: 0x17001DF9 RID: 7673
		// (get) Token: 0x06006459 RID: 25689 RVA: 0x001C9FD8 File Offset: 0x001C81D8
		// (set) Token: 0x0600645A RID: 25690 RVA: 0x0002F32E File Offset: 0x0002D52E
		public unsafe float FOV
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_FOV)) = value;
			}
		}

		// Token: 0x17001DFA RID: 7674
		// (get) Token: 0x0600645B RID: 25691 RVA: 0x001CA000 File Offset: 0x001C8200
		// (set) Token: 0x0600645C RID: 25692 RVA: 0x0002F349 File Offset: 0x0002D549
		public unsafe bool SSAO
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_SSAO)) = value;
			}
		}

		// Token: 0x17001DFB RID: 7675
		// (get) Token: 0x0600645D RID: 25693 RVA: 0x001CA028 File Offset: 0x001C8228
		// (set) Token: 0x0600645E RID: 25694 RVA: 0x0002F364 File Offset: 0x0002D564
		public unsafe bool GodRays
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GraphicsSettings.NativeFieldInfoPtr_GodRays)) = value;
			}
		}

		// Token: 0x04004471 RID: 17521
		private static readonly System.IntPtr NativeFieldInfoPtr_GraphicsQuality;

		// Token: 0x04004472 RID: 17522
		private static readonly System.IntPtr NativeFieldInfoPtr_AntiAliasingMode;

		// Token: 0x04004473 RID: 17523
		private static readonly System.IntPtr NativeFieldInfoPtr_FOV;

		// Token: 0x04004474 RID: 17524
		private static readonly System.IntPtr NativeFieldInfoPtr_SSAO;

		// Token: 0x04004475 RID: 17525
		private static readonly System.IntPtr NativeFieldInfoPtr_GodRays;

		// Token: 0x04004476 RID: 17526
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A6A RID: 2666
		[OriginalName("Assembly-CSharp.dll", "", "EAntiAliasingMode")]
		public enum EAntiAliasingMode
		{
			// Token: 0x04008F33 RID: 36659
			Off,
			// Token: 0x04008F34 RID: 36660
			FXAA,
			// Token: 0x04008F35 RID: 36661
			SMAA
		}

		// Token: 0x02000A6B RID: 2667
		[OriginalName("Assembly-CSharp.dll", "", "EGraphicsQuality")]
		public enum EGraphicsQuality
		{
			// Token: 0x04008F37 RID: 36663
			Low,
			// Token: 0x04008F38 RID: 36664
			Medium,
			// Token: 0x04008F39 RID: 36665
			High,
			// Token: 0x04008F3A RID: 36666
			Ultra
		}
	}
}
