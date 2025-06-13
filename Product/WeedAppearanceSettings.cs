using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005D2 RID: 1490
	[System.Serializable]
	public class WeedAppearanceSettings : Il2CppSystem.Object
	{
		// Token: 0x0600820E RID: 33294 RVA: 0x0022EF98 File Offset: 0x0022D198
		// Note: this type is marked as 'beforefieldinit'.
		static WeedAppearanceSettings()
		{
			Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "WeedAppearanceSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr);
			WeedAppearanceSettings.NativeFieldInfoPtr_MainColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "MainColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "SecondaryColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "LeafColor");
			WeedAppearanceSettings.NativeFieldInfoPtr_StemColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, "StemColor");
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679735);
			WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679736);
			WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr, 100679737);
		}

		// Token: 0x0600820F RID: 33295 RVA: 0x0022F054 File Offset: 0x0022D254
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247376, RefRangeEnd = 247377, XrefRangeStart = 247375, XrefRangeEnd = 247376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings(Color32 mainColor, Color32 secondaryColor, Color32 leafColor, Color32 stemColor) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mainColor;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref secondaryColor;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref leafColor;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref stemColor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008210 RID: 33296 RVA: 0x0022F0C8 File Offset: 0x0022D2C8
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedAppearanceSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedAppearanceSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008211 RID: 33297 RVA: 0x0022F104 File Offset: 0x0022D304
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 247377, RefRangeEnd = 247378, XrefRangeStart = 247377, XrefRangeEnd = 247377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnintialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WeedAppearanceSettings.NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x0003D63F File Offset: 0x0003B83F
		public WeedAppearanceSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x06008213 RID: 33299 RVA: 0x0022F140 File Offset: 0x0022D340
		// (set) Token: 0x06008214 RID: 33300 RVA: 0x0003D648 File Offset: 0x0003B848
		public unsafe Color32 MainColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_MainColor)) = value;
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x06008215 RID: 33301 RVA: 0x0022F168 File Offset: 0x0022D368
		// (set) Token: 0x06008216 RID: 33302 RVA: 0x0003D663 File Offset: 0x0003B863
		public unsafe Color32 SecondaryColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_SecondaryColor)) = value;
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x06008217 RID: 33303 RVA: 0x0022F190 File Offset: 0x0022D390
		// (set) Token: 0x06008218 RID: 33304 RVA: 0x0003D67E File Offset: 0x0003B87E
		public unsafe Color32 LeafColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_LeafColor)) = value;
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x06008219 RID: 33305 RVA: 0x0022F1B8 File Offset: 0x0022D3B8
		// (set) Token: 0x0600821A RID: 33306 RVA: 0x0003D699 File Offset: 0x0003B899
		public unsafe Color32 StemColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WeedAppearanceSettings.NativeFieldInfoPtr_StemColor)) = value;
			}
		}

		// Token: 0x040058A4 RID: 22692
		private static readonly System.IntPtr NativeFieldInfoPtr_MainColor;

		// Token: 0x040058A5 RID: 22693
		private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryColor;

		// Token: 0x040058A6 RID: 22694
		private static readonly System.IntPtr NativeFieldInfoPtr_LeafColor;

		// Token: 0x040058A7 RID: 22695
		private static readonly System.IntPtr NativeFieldInfoPtr_StemColor;

		// Token: 0x040058A8 RID: 22696
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color32_Color32_Color32_Color32_0;

		// Token: 0x040058A9 RID: 22697
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040058AA RID: 22698
		private static readonly System.IntPtr NativeMethodInfoPtr_IsUnintialized_Public_Boolean_0;
	}
}
